namespace https.w3id.org.ontouml.hash

open DoxAletheia.Rdf_Vocabulary

module ontouml =
    let _namespace_name = "https://w3id.org/ontouml#"
    /// <summary>
    /// An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.
    /// <see href="https://w3id.org/ontouml#abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes abstract individuals among its instances.
    /// <see href="https://w3id.org/ontouml#abstractNature"></see></summary>
    let abstractNature =
        Namespaced_IRI.parse _namespace_name "abstractNature" |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:PropertyStereotype used to assign the corresponding stereotype to a given ontouml:Property.
    /// <see href="https://w3id.org/ontouml#begin"></see></summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#bringsAbout"></see></summary>
    let bringsAbout =
        Namespaced_IRI.parse _namespace_name "bringsAbout" |> NamespacedName

    /// <summary>
    /// A rigid mixin that does not require a dependency to be specified. It is used to aggregate essential properties of individuals following different identity principles.
    /// <see href="https://w3id.org/ontouml#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    /// An ontouml:RelationStereotype attributed to a relation between a bearer type and its feature.
    /// <see href="https://w3id.org/ontouml#characterization"></see></summary>
    let characterization =
        Namespaced_IRI.parse _namespace_name "characterization" |> NamespacedName

    /// <summary>
    /// An ontouml:ClassStereotype used to represent rigid concepts that provide an identity principle for their instances.
    /// <see href="https://w3id.org/ontouml#collective"></see></summary>
    let collective = Namespaced_IRI.parse _namespace_name "collective" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes collective individuals among its instances.
    /// <see href="https://w3id.org/ontouml#collectiveNature"></see></summary>
    let collectiveNature =
        Namespaced_IRI.parse _namespace_name "collectiveNature" |> NamespacedName

    /// <summary>
    /// The stereotype for comparative relations (e.g., heavier-than). Decorates relations that always hold between any two individuals bearing the same relevant quality.
    /// <see href="https://w3id.org/ontouml#comparative"></see></summary>
    let comparative =
        Namespaced_IRI.parse _namespace_name "comparative" |> NamespacedName

    /// <summary>
    /// A parthood relation between two complexes.
    /// <see href="https://w3id.org/ontouml#componentOf"></see></summary>
    let componentOf =
        Namespaced_IRI.parse _namespace_name "componentOf" |> NamespacedName

    /// <summary>
    /// The value denoting that an ontouml:Property represents a composite aggregation, i.e., a strong form of aggregation.
    /// <see href="https://w3id.org/ontouml#composite"></see></summary>
    let composite = Namespaced_IRI.parse _namespace_name "composite" |> NamespacedName
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#creation"></see></summary>
    let creation = Namespaced_IRI.parse _namespace_name "creation" |> NamespacedName
    /// <summary>
    /// An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.
    /// <see href="https://w3id.org/ontouml#datatype"></see></summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#derivation"></see></summary>
    let derivation = Namespaced_IRI.parse _namespace_name "derivation" |> NamespacedName
    /// <summary>
    /// An individual of the ontouml:PropertyStereotype used to assign the corresponding stereotype to a given ontouml:Property.
    /// <see href="https://w3id.org/ontouml#end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName

    /// <summary>
    /// Represents the enumeration stereotype, having values represented using ontouml:Literal instances.
    /// <see href="https://w3id.org/ontouml#enumeration"></see></summary>
    let enumeration =
        Namespaced_IRI.parse _namespace_name "enumeration" |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.
    /// Things that happen to or are performed by endurants (Casati and Varzi, 2015).
    /// <see href="https://w3id.org/ontouml#event"></see></summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes event individuals among its instances.
    /// <see href="https://w3id.org/ontouml#eventNature"></see></summary>
    let eventNature =
        Namespaced_IRI.parse _namespace_name "eventNature" |> NamespacedName

    /// <summary>
    /// Identifies an endurant on which the extrinsicMode depends.
    /// <see href="https://w3id.org/ontouml#externalDependence"></see></summary>
    let externalDependence =
        Namespaced_IRI.parse _namespace_name "externalDependence" |> NamespacedName

    /// <summary>
    /// Identifies what inheres in a concrete individual and depends on others for its existence.
    /// <see href="https://w3id.org/ontouml#extrinsicModeNature"></see></summary>
    let extrinsicModeNature =
        Namespaced_IRI.parse _namespace_name "extrinsicModeNature" |> NamespacedName

    /// <summary>
    /// Identifies the nature of a complex object whose parts (components) play different roles in its composition.
    /// <see href="https://w3id.org/ontouml#functionalComplexNature"></see></summary>
    let functionalComplexNature =
        Namespaced_IRI.parse _namespace_name "functionalComplexNature" |> NamespacedName

    /// <summary>
    /// Identifies a concrete individual on which another concrete individual depends historically.
    /// <see href="https://w3id.org/ontouml#historicalDependence"></see></summary>
    let historicalDependence =
        Namespaced_IRI.parse _namespace_name "historicalDependence" |> NamespacedName

    /// <summary>
    /// Denotes the role of an endurant in virtue of having participated in an event of a particular type.
    /// <see href="https://w3id.org/ontouml#historicalRole"></see></summary>
    let historicalRole =
        Namespaced_IRI.parse _namespace_name "historicalRole" |> NamespacedName

    /// <summary>
    /// Denotes the equivalent of historicalRole for types that aggregate instances with different identity principles.
    /// <see href="https://w3id.org/ontouml#historicalRoleMixin"></see></summary>
    let historicalRoleMixin =
        Namespaced_IRI.parse _namespace_name "historicalRoleMixin" |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#instantiation"></see></summary>
    let instantiation =
        Namespaced_IRI.parse _namespace_name "instantiation" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes intrinsic mode individuals among its instances.
    /// <see href="https://w3id.org/ontouml#intrinsicModeNature"></see></summary>
    let intrinsicModeNature =
        Namespaced_IRI.parse _namespace_name "intrinsicModeNature" |> NamespacedName

    /// <summary>
    /// Used to represent rigid concepts that provide an identity principle for their instances and do not require a relational dependency.
    /// <see href="https://w3id.org/ontouml#kind"></see></summary>
    let kind = Namespaced_IRI.parse _namespace_name "kind" |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#manifestation"></see></summary>
    let manifestation =
        Namespaced_IRI.parse _namespace_name "manifestation" |> NamespacedName

    /// <summary>
    /// Identifies relations that have material structure on their own and include examples such as employments, kisses, enrollments, flight, connections and commitments.
    /// <see href="https://w3id.org/ontouml#material"></see></summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName
    /// <summary>
    /// A type of existential dependence relation (a form of nonfunctional inherence). It can be derived from the relation between the relata and the qua individuals that compose the relator and that inhere in the relata.
    /// <see href="https://w3id.org/ontouml#mediation"></see></summary>
    let mediation = Namespaced_IRI.parse _namespace_name "mediation" |> NamespacedName
    /// <summary>
    /// A parthood relation between a functional complex or a Collective (as a part) and a Collective (as a whole).
    /// <see href="https://w3id.org/ontouml#memberOf"></see></summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
    /// <summary>
    /// Represents a semi-rigid type, i.e., it behaves as a rigid type for some individuals and as an anti-rigid one for others.
    /// <see href="https://w3id.org/ontouml#mixin"></see></summary>
    let mixin_ = Namespaced_IRI.parse _namespace_name "mixin" |> NamespacedName
    /// <summary>
    /// A particular type of intrinsic property that has no structured value.
    /// <see href="https://w3id.org/ontouml#mode"></see></summary>
    let mode = Namespaced_IRI.parse _namespace_name "mode" |> NamespacedName
    /// <summary>
    /// Denotes that an ontouml:Property is neither ontouml:shared nor ontouml:composite, but just an aggregation.
    /// <see href="https://w3id.org/ontouml#none"></see></summary>
    let none = Namespaced_IRI.parse _namespace_name "none" |> NamespacedName

    /// <summary>
    /// A relation for representing when an event depends on a single object.
    /// <see href="https://w3id.org/ontouml#participation"></see></summary>
    let participation =
        Namespaced_IRI.parse _namespace_name "participation" |> NamespacedName

    /// <summary>
    /// Denotes a kind of event decomposition.
    /// <see href="https://w3id.org/ontouml#participational"></see></summary>
    let participational =
        Namespaced_IRI.parse _namespace_name "participational" |> NamespacedName

    /// <summary>
    /// Used to represent anti-rigid subtypes of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity) that are instantiated by changes in intrinsic properties (e.g., the age of a person, the color of an object, the condition of a car).Phases always come in partitions.
    /// <see href="https://w3id.org/ontouml#phase"></see></summary>
    let phase = Namespaced_IRI.parse _namespace_name "phase" |> NamespacedName
    /// <summary>
    /// The equivalent of Phase for types that aggregate instances with different identity principles. A class stereotyped as PhaseMixin is also an anti-rigid type. PhaseMixin is similar semantically to RoleMixin with the difference in relational dependency.
    /// <see href="https://w3id.org/ontouml#phaseMixin"></see></summary>
    let phaseMixin = Namespaced_IRI.parse _namespace_name "phaseMixin" |> NamespacedName
    /// <summary>
    /// A Quality is a particular type of intrinsic property that has a structured value. Qualities are things that existentially depend on the things they characterize, called their bearers.
    /// <see href="https://w3id.org/ontouml#quality"></see></summary>
    let quality = Namespaced_IRI.parse _namespace_name "quality" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes quality individuals among its instances.
    /// <see href="https://w3id.org/ontouml#qualityNature"></see></summary>
    let qualityNature =
        Namespaced_IRI.parse _namespace_name "qualityNature" |> NamespacedName

    /// <summary>
    /// Construct used to represent rigid concepts that provide an identity principle for their instances.
    /// <see href="https://w3id.org/ontouml#quantity"></see></summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes quantity individuals among its instances.
    /// <see href="https://w3id.org/ontouml#quantityNature"></see></summary>
    let quantityNature =
        Namespaced_IRI.parse _namespace_name "quantityNature" |> NamespacedName

    /// <summary>
    /// A construct used to represent truth-makers of material relations, i.e., the things that must exist for two or more individuals to be connected by material relations.
    /// <see href="https://w3id.org/ontouml#relator"></see></summary>
    let relator = Namespaced_IRI.parse _namespace_name "relator" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes relator individuals among its instances.
    /// <see href="https://w3id.org/ontouml#relatorNature"></see></summary>
    let relatorNature =
        Namespaced_IRI.parse _namespace_name "relatorNature" |> NamespacedName

    /// <summary>
    /// Used to represent anti-rigid specializations of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity) that are instantiated in relational contexts.
    /// <see href="https://w3id.org/ontouml#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// The equivalent of Role for types that aggregate instances with different identity principles.
    /// <see href="https://w3id.org/ontouml#roleMixin"></see></summary>
    let roleMixin = Namespaced_IRI.parse _namespace_name "roleMixin" |> NamespacedName
    /// <summary>
    /// Indicates that the ontouml:Property has shared aggregation semantics.
    /// <see href="https://w3id.org/ontouml#shared"></see></summary>
    let shared = Namespaced_IRI.parse _namespace_name "shared" |> NamespacedName
    /// <summary>
    /// Can be used to represent certain configurations of entities that can be comprehended as a whole.
    /// <see href="https://w3id.org/ontouml#situation"></see></summary>
    let situation = Namespaced_IRI.parse _namespace_name "situation" |> NamespacedName

    /// <summary>
    /// Indicates that the restricted type includes situation individuals among its instances.
    /// <see href="https://w3id.org/ontouml#situationNature"></see></summary>
    let situationNature =
        Namespaced_IRI.parse _namespace_name "situationNature" |> NamespacedName

    /// <summary>
    /// A parthood relation between two collectives.
    /// <see href="https://w3id.org/ontouml#subCollectionOf"></see></summary>
    let subCollectionOf =
        Namespaced_IRI.parse _namespace_name "subCollectionOf" |> NamespacedName

    /// <summary>
    /// A parthood relation between two quantities.
    /// <see href="https://w3id.org/ontouml#subQuantityOf"></see></summary>
    let subQuantityOf =
        Namespaced_IRI.parse _namespace_name "subQuantityOf" |> NamespacedName

    /// <summary>
    /// Used to represent rigid specializations of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity).
    /// <see href="https://w3id.org/ontouml#subkind"></see></summary>
    let subkind = Namespaced_IRI.parse _namespace_name "subkind" |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#termination"></see></summary>
    let termination =
        Namespaced_IRI.parse _namespace_name "termination" |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#triggers"></see></summary>
    let triggers = Namespaced_IRI.parse _namespace_name "triggers" |> NamespacedName
    /// <summary>
    /// The stereotype for high-order types.
    /// <see href="https://w3id.org/ontouml#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// Indicates that the restricted type includes type individuals among its instances.
    /// <see href="https://w3id.org/ontouml#typeNature"></see></summary>
    let typeNature = Namespaced_IRI.parse _namespace_name "typeNature" |> NamespacedName

    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:composite, ontouml:none, and ontouml:shared.
    /// Groups all possible aggregation kinds to which an ontouml:Property can be related.
    /// <see href="https://w3id.org/ontouml#AggregationKind"></see></summary>
    let AggregationKind =
        Namespaced_IRI.parse _namespace_name "AggregationKind" |> NamespacedName

    /// <summary>
    /// Represents the cardinality of an ontouml:Property through its data property ontouml:cardinalityValue.
    /// <see href="https://w3id.org/ontouml#Cardinality"></see></summary>
    let Cardinality =
        Namespaced_IRI.parse _namespace_name "Cardinality" |> NamespacedName

    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:abstractNature, ontouml:collectiveNature, ontouml:eventNature, ontouml:extrinsicModeNature, ontouml:functionalComplexNature, ontouml:intrinsicModeNature, ontouml:qualityNature, ontouml:quantityNature, ontouml:relatorNature, ontouml:situationNature, and ontouml:typeNature.
    /// Collection of individuals that represent fundamental conceptual modeling issues according to the Unified Foundational Ontology (UFO) theory.
    /// <see href="https://w3id.org/ontouml#OntologicalNature"></see></summary>
    let OntologicalNature =
        Namespaced_IRI.parse _namespace_name "OntologicalNature" |> NamespacedName

    /// <summary>
    /// Abstract class that groups different elements an ontoUML model can have.
    /// <see href="https://w3id.org/ontouml#OntoumlElement"></see></summary>
    let OntoumlElement =
        Namespaced_IRI.parse _namespace_name "OntoumlElement" |> NamespacedName

    /// <summary>
    /// Contains the ontouml:xCoordinate value and ontouml:yCoordinate value. These values represent the top left position of an ontouml:RectangularShape, to which the ontouml:Point is related vian ontouml:topLeftPosition property.
    /// <see href="https://w3id.org/ontouml#Point"></see></summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    /// Indicates meta-properties of classes, properties, or relations.
    /// <see href="https://w3id.org/ontouml#Stereotype"></see></summary>
    let Stereotype = Namespaced_IRI.parse _namespace_name "Stereotype" |> NamespacedName
    /// <summary>
    /// An ontouml:Class have exactly one ontouml:Stereotype (i.e., it is a mandatory property) of specific type ontouml:ClassStereotype. This information is formalized by the ontouml:stereotype property.
    /// Represents a type defined in the ontology.
    /// <see href="https://w3id.org/ontouml#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName

    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:abstract, ontouml:category, ontouml:collective, ontouml:datatype, ontouml:enumeration, ontouml:event, ontouml:historicalRole, ontouml:historicalRoleMixin, ontouml:kind, ontouml:mixin, ontouml:mode, ontouml:phase, ontouml:phaseMixin, ontouml:quality, ontouml:quantity, ontouml:relator, ontouml:role, ontouml:roleMixin, ontouml:situation, ontouml:subkind, and ontouml:type.
    /// Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Class.
    /// <see href="https://w3id.org/ontouml#ClassStereotype"></see></summary>
    let ClassStereotype =
        Namespaced_IRI.parse _namespace_name "ClassStereotype" |> NamespacedName

    /// <summary>
    /// Identifies the ontouml:Stereotype applied to the ontouml:DecoratableElement.
    /// <see href="https://w3id.org/ontouml#stereotype"></see></summary>
    let stereotype = Namespaced_IRI.parse _namespace_name "stereotype" |> NamespacedName
    /// <summary>
    /// Abstract class that groups the classes ontouml:Class and ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#Classifier"></see></summary>
    let Classifier = Namespaced_IRI.parse _namespace_name "Classifier" |> NamespacedName
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Class in a given ontouml:Diagram.
    /// Does not directly contain data about the visual representation (rectangular shape's size and position) itself, but is related to this information via the ontouml:shape property.
    /// <see href="https://w3id.org/ontouml#ClassView"></see></summary>
    let ClassView = Namespaced_IRI.parse _namespace_name "ClassView" |> NamespacedName
    /// <summary>
    /// Abstract class that groups the classes ontouml:NoteView, ontouml:ClassView, and ontouml:PackageView.
    /// <see href="https://w3id.org/ontouml#NodeView"></see></summary>
    let NodeView = Namespaced_IRI.parse _namespace_name "NodeView" |> NamespacedName

    /// <summary>
    /// Abstract class that groups the classes ontouml:Classifier and the ontouml:Property.
    /// <see href="https://w3id.org/ontouml#DecoratableElement"></see></summary>
    let DecoratableElement =
        Namespaced_IRI.parse _namespace_name "DecoratableElement" |> NamespacedName

    /// <summary>
    /// An ontouml:Relation may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:RelationStereotype. This information is formalized by the ontouml:stereotype property.
    /// Represents a relation defined in the ontology.
    /// <see href="https://w3id.org/ontouml#Relation"></see></summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName

    /// <summary>
    /// Abstract class that groups the classes ontouml:RelationView and ontouml:GeneralizationView.
    /// <see href="https://w3id.org/ontouml#ConnectorView"></see></summary>
    let ConnectorView =
        Namespaced_IRI.parse _namespace_name "ConnectorView" |> NamespacedName

    /// <summary>
    /// Abstract class that groups the classes ontouml:ConnectorView, ontouml:GeneralizationSetView, and ontouml:NodeView.
    /// Represents the diagramatical representation of an element on an ontouml:Diagram.
    /// E.g., an ontouml:ClassView is created whenever an ontouml:ModelElement is represented in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#ElementView"></see></summary>
    let ElementView =
        Namespaced_IRI.parse _namespace_name "ElementView" |> NamespacedName

    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Generalization in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#GeneralizationView"></see></summary>
    let GeneralizationView =
        Namespaced_IRI.parse _namespace_name "GeneralizationView" |> NamespacedName

    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Relation in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#RelationView"></see></summary>
    let RelationView =
        Namespaced_IRI.parse _namespace_name "RelationView" |> NamespacedName

    /// <summary>
    /// Abstract class that groups diverse elements that can be represented in on OntoUML model.
    /// <see href="https://w3id.org/ontouml#ModelElement"></see></summary>
    let ModelElement =
        Namespaced_IRI.parse _namespace_name "ModelElement" |> NamespacedName

    /// <summary>
    /// An ontouml:Property may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:PropertyStereotype. This information is formalized by the ontouml:stereotype property.
    /// Represents a property defined in the ontology. Properties contained by classes are deemed attributes and those contained by relations are deemed association ends.
    /// <see href="https://w3id.org/ontouml#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    /// A visual representation of an OntoUML model or of a portion of it.
    /// <see href="https://w3id.org/ontouml#Diagram"></see></summary>
    let Diagram = Namespaced_IRI.parse _namespace_name "Diagram" |> NamespacedName

    /// <summary>
    /// Abstract class that groups the classes ontouml:ElementView and the ontouml:Shape.
    /// <see href="https://w3id.org/ontouml#DiagramElement"></see></summary>
    let DiagramElement =
        Namespaced_IRI.parse _namespace_name "DiagramElement" |> NamespacedName

    /// <summary>
    /// Contains information about the diagramation of an ontouml:ModelElement through its relation with an ontouml:ElementView.
    /// <see href="https://w3id.org/ontouml#Shape"></see></summary>
    let Shape = Namespaced_IRI.parse _namespace_name "Shape" |> NamespacedName

    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:GeneralizationSet in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#GeneralizationSetView"></see></summary>
    let GeneralizationSetView =
        Namespaced_IRI.parse _namespace_name "GeneralizationSetView" |> NamespacedName

    /// <summary>
    /// Represents a generalization defined in an ontology.
    /// <see href="https://w3id.org/ontouml#Generalization"></see></summary>
    let Generalization =
        Namespaced_IRI.parse _namespace_name "Generalization" |> NamespacedName

    /// <summary>
    /// Represents a generalization set defined in the ontology.
    /// <see href="https://w3id.org/ontouml#GeneralizationSet"></see></summary>
    let GeneralizationSet =
        Namespaced_IRI.parse _namespace_name "GeneralizationSet" |> NamespacedName

    /// <summary>
    /// Represents a possible value for an ontouml:Class defined by an ontouml:enumeration.
    /// <see href="https://w3id.org/ontouml#Literal"></see></summary>
    let Literal = Namespaced_IRI.parse _namespace_name "Literal" |> NamespacedName
    /// <summary>
    /// Type of ontouml:ModelElement used to represent textual information.
    /// <see href="https://w3id.org/ontouml#Note"></see></summary>
    let Note = Namespaced_IRI.parse _namespace_name "Note" |> NamespacedName
    /// <summary>
    /// Aggregates ontology components, working as a container.
    /// <see href="https://w3id.org/ontouml#Package"></see></summary>
    let Package = Namespaced_IRI.parse _namespace_name "Package" |> NamespacedName
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Note in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#NoteView"></see></summary>
    let NoteView = Namespaced_IRI.parse _namespace_name "NoteView" |> NamespacedName

    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Package in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#PackageView"></see></summary>
    let PackageView =
        Namespaced_IRI.parse _namespace_name "PackageView" |> NamespacedName

    /// <summary>
    /// It is the upper non-abstract class available in the OntoUML Vocabulary.
    /// Aggregates all entities that are part of a same conceptual model, including concepts declaration and their visual representation.
    /// <see href="https://w3id.org/ontouml#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    /// A list of connected ontouml:Point values to represent an ontouml:ElementView's shape.
    /// <see href="https://w3id.org/ontouml#Path"></see></summary>
    let Path = Namespaced_IRI.parse _namespace_name "Path" |> NamespacedName

    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:begin, and ontouml:end.
    /// Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Property.
    /// <see href="https://w3id.org/ontouml#PropertyStereotype"></see></summary>
    let PropertyStereotype =
        Namespaced_IRI.parse _namespace_name "PropertyStereotype" |> NamespacedName

    /// <summary>
    /// A particular type of ontouml:RectangularShape, mainly used to represent entities of type ontouml:Class.
    /// <see href="https://w3id.org/ontouml#Rectangle"></see></summary>
    let Rectangle = Namespaced_IRI.parse _namespace_name "Rectangle" |> NamespacedName

    /// <summary>
    /// Represents a rectangular shape in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#RectangularShape"></see></summary>
    let RectangularShape =
        Namespaced_IRI.parse _namespace_name "RectangularShape" |> NamespacedName

    /// <summary>
    /// An ontouml:RectangularShape used to represent some textual information in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#Text"></see></summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName

    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:bringsAbout, ontouml:characterization, ontouml:comparative, ontouml:componentOf, ontouml:creation, ontouml:derivation, ontouml:externalDependence, ontouml:historicalDependence, ontouml:instantiation, ontouml:manifestation, ontouml:material, ontouml:mediation, ontouml:memberOf, ontouml:participation, ontouml:participational, ontouml:subCollectionOf, ontouml:subQuantityOf, ontouml:termination, and ontouml:triggers.
    /// Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#RelationStereotype"></see></summary>
    let RelationStereotype =
        Namespaced_IRI.parse _namespace_name "RelationStereotype" |> NamespacedName

    /// <summary>
    /// Characterizes an ontouml:Property with an ontouml:AggregationKind instance, i.e., indicates whether the ontouml:Property is a simple (ontouml:none), a shared (ontouml:shared), or a composite (ontouml:composite) property.
    /// <see href="https://w3id.org/ontouml#aggregationKind"></see></summary>
    let aggregationKind =
        Namespaced_IRI.parse _namespace_name "aggregationKind" |> NamespacedName

    /// <summary>
    /// Relates an instance of an ontouml:Class to its properties, which are instances of the ontouml:Property class.
    /// <see href="https://w3id.org/ontouml#attribute"></see></summary>
    let attribute = Namespaced_IRI.parse _namespace_name "attribute" |> NamespacedName
    /// <summary>
    /// Identifies an ontouml:Property exhibited by an ontouml:Classifier. If the ontouml:Classifier is of type ontouml:Class, the ontouml:property is specialized in ontouml:attribute. If the ontouml:Classifier is an ontouml:Relation, the property is specialized in ontouml:relationEnd.
    /// Aggregates its subproperties ontouml:attribute and ontouml:relationEnd. Should not be directly used.
    /// <see href="https://w3id.org/ontouml#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    /// Identifies the individual of type ontouml:Cardinality that represents the cardinalities of an ontouml:Property.
    /// <see href="https://w3id.org/ontouml#cardinality"></see></summary>
    let cardinality =
        Namespaced_IRI.parse _namespace_name "cardinality" |> NamespacedName

    /// <summary>
    /// Provides the complete (i.e., both lower and upper cardinality's bounds) cardinalities of an ontouml:Property via its related ontouml:Cardinality.
    /// <see href="https://w3id.org/ontouml#cardinalityValue"></see></summary>
    let cardinalityValue =
        Namespaced_IRI.parse _namespace_name "cardinalityValue" |> NamespacedName

    /// <summary>
    ///  Identifies the ontouml:Class that is instantiated by the specific classes of the ontouml:Generalization type composing the ontouml:GeneralizationSet
    /// <see href="https://w3id.org/ontouml#categorizer"></see></summary>
    let categorizer =
        Namespaced_IRI.parse _namespace_name "categorizer" |> NamespacedName

    /// <summary>
    /// It is mapped to the OntoUML Metamodel's 'contents' relation between the Package and ModelElement classes.
    /// Identifies an instance of type ontouml:ModelElement that composes in an ontouml:Package.
    /// <see href="https://w3id.org/ontouml#containsModelElement"></see></summary>
    let containsModelElement =
        Namespaced_IRI.parse _namespace_name "containsModelElement" |> NamespacedName

    /// <summary>
    /// Identifies an instance of type ontouml:ElementView that is contained in an ontouml:Diagram, representing the concrete diagramation of an ontouml:ModelElement.
    /// <see href="https://w3id.org/ontouml#containsView"></see></summary>
    let containsView =
        Namespaced_IRI.parse _namespace_name "containsView" |> NamespacedName

    /// <summary>
    /// Relates an ontouml:OntoumlElement to a string representing its description in free textual format.
    /// <see href="https://w3id.org/ontouml#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// It is mapped to the OntoUML Metamodel's 'diagrams' relation between the Project and Diagram classes.
    /// Identifies which entities of type ontouml:Diagram are part of an ontouml:Project.
    /// <see href="https://w3id.org/ontouml#diagram"></see></summary>
    let diagram = Namespaced_IRI.parse _namespace_name "diagram" |> NamespacedName
    /// <summary>
    /// Identifies the parent ontouml:Classifier (e.g., a superclass) that participates in an ontouml:Generalization relation.
    /// <see href="https://w3id.org/ontouml#general"></see></summary>
    let general = Namespaced_IRI.parse _namespace_name "general" |> NamespacedName

    /// <summary>
    /// Identifies an ontouml:Generalization that participates in an ontouml:GeneralizationSet.
    /// <see href="https://w3id.org/ontouml#generalization"></see></summary>
    let generalization =
        Namespaced_IRI.parse _namespace_name "generalization" |> NamespacedName

    /// <summary>
    /// Indicates the height of an ontouml:RectangularShape that is represented in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    /// Indicates if the ontouml:Classifier can have direct instances. If set to true, the classifier must be specialized before being instantiated. Otherwise, it can have direct instances.
    /// <see href="https://w3id.org/ontouml#isAbstract"></see></summary>
    let isAbstract = Namespaced_IRI.parse _namespace_name "isAbstract" |> NamespacedName
    /// <summary>
    /// Indicates if an ontouml:GeneralizationSet is complete, i.e., if it does not admit further generalizations.
    /// <see href="https://w3id.org/ontouml#isComplete"></see></summary>
    let isComplete = Namespaced_IRI.parse _namespace_name "isComplete" |> NamespacedName
    /// <summary>
    /// Indicates if an ontouml:DecoratableElement can be defined through a derivation rule.
    /// <see href="https://w3id.org/ontouml#isDerived"></see></summary>
    let isDerived = Namespaced_IRI.parse _namespace_name "isDerived" |> NamespacedName
    /// <summary>
    /// Indicates if an ontouml:GeneralizationSet is disjoint, i.e., it does not admit generalizations having overlapping subclasses.
    /// <see href="https://w3id.org/ontouml#isDisjoint"></see></summary>
    let isDisjoint = Namespaced_IRI.parse _namespace_name "isDisjoint" |> NamespacedName

    /// <summary>
    /// Indicates if an ontouml:Class is extensionally defined (i.e., it's parts cannot change).
    /// <see href="https://w3id.org/ontouml#isExtensional"></see></summary>
    let isExtensional =
        Namespaced_IRI.parse _namespace_name "isExtensional" |> NamespacedName

    /// <summary>
    /// Indicates if an ontouml:Property is ordered or not, i.e., if it requires an exact order of its values or not.
    /// <see href="https://w3id.org/ontouml#isOrdered"></see></summary>
    let isOrdered = Namespaced_IRI.parse _namespace_name "isOrdered" |> NamespacedName

    /// <summary>
    /// The ontouml:Class data property ontouml:isPowertype must not be true when it has an ontouml:order equal to one.
    /// Indicates if an ontouml:Class is a powertype in multi-level modeling.
    /// <see href="https://w3id.org/ontouml#isPowertype"></see></summary>
    let isPowertype =
        Namespaced_IRI.parse _namespace_name "isPowertype" |> NamespacedName

    /// <summary>
    /// Indicates if an ontouml:Property can or cannot be updated or modified.
    /// <see href="https://w3id.org/ontouml#isReadOnly"></see></summary>
    let isReadOnly = Namespaced_IRI.parse _namespace_name "isReadOnly" |> NamespacedName
    /// <summary>
    /// Relates an ontouml:ElementView to ontouml:ModelElement, indicating the diagrammatical representation of the latter in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#isViewOf"></see></summary>
    let isViewOf = Namespaced_IRI.parse _namespace_name "isViewOf" |> NamespacedName
    /// <summary>
    /// Relates an ontouml:Literal to its container enumeration class (an ontouml:Class that has the ontouml:stereotype property with ontouml:enumeration).
    /// <see href="https://w3id.org/ontouml#literal"></see></summary>
    let literal = Namespaced_IRI.parse _namespace_name "literal" |> NamespacedName
    /// <summary>
    /// Identifies the lower bound of an ontouml:Cardinality.
    /// E.g., if the ontouml:cardinalityValue set is [1..*] then the lower bound is '1'.
    /// An ontouml:Cardinality's lower bound must correspond to the one indicated by its ontouml:cardinalityValue property.
    /// <see href="https://w3id.org/ontouml#lowerBound"></see></summary>
    let lowerBound = Namespaced_IRI.parse _namespace_name "lowerBound" |> NamespacedName
    /// <summary>
    /// Relates an ontouml:Project to an ontouml:Package that is part of it.
    /// <see href="https://w3id.org/ontouml#model"></see></summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName
    /// <summary>
    /// A string that identifies or names an ontouml:OntoumlElement.
    /// <see href="https://w3id.org/ontouml#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Indicates the order of an ontouml:Class, enabling multi-level modeling.
    /// Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype ontouml:type must have an ontouml:order value grater than 1.
    /// Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype different than ontouml:type must have an ontouml:order value equal to 1.
    /// <see href="https://w3id.org/ontouml#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// Relates an ontouml:Diagram to an ontouml:ModelElement that is represented on it, i.e., to an ontouml:ModelElement that has an ontouml:ElementView on that ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    /// Relates an ontouml:Path to an ontouml:Point that composes it.
    /// <see href="https://w3id.org/ontouml#point"></see></summary>
    let point = Namespaced_IRI.parse _namespace_name "point" |> NamespacedName
    /// <summary>
    /// Relates an ontouml:OntoumlElement different than ontouml:Project to an ontouml:Project that it composes.
    /// <see href="https://w3id.org/ontouml#project"></see></summary>
    let project = Namespaced_IRI.parse _namespace_name "project" |> NamespacedName

    /// <summary>
    /// Identifies an ontouml:Class or ontouml:Relation (i.e., an ontouml:Classifier) to which an ontouml:Property refers.
    /// <see href="https://w3id.org/ontouml#propertyType"></see></summary>
    let propertyType =
        Namespaced_IRI.parse _namespace_name "propertyType" |> NamespacedName

    /// <summary>
    /// Identifies a target ontouml:Property that is redefined by a source ontouml:Property.
    /// <see href="https://w3id.org/ontouml#redefinesProperty"></see></summary>
    let redefinesProperty =
        Namespaced_IRI.parse _namespace_name "redefinesProperty" |> NamespacedName

    /// <summary>
    /// Identifies a property that represents one end (source or target) of an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#relationEnd"></see></summary>
    let relationEnd =
        Namespaced_IRI.parse _namespace_name "relationEnd" |> NamespacedName

    /// <summary>
    /// Associates an ontouml:Class to an ontouml:OntologicalNature, restricting its allowed values.
    /// <see href="https://w3id.org/ontouml#restrictedTo"></see></summary>
    let restrictedTo =
        Namespaced_IRI.parse _namespace_name "restrictedTo" |> NamespacedName

    /// <summary>
    /// Relates an ontouml:ElementView to an ontouml:Shape that contains the diagramation's data (size and position) about the ontouml:ModelElement it is a view of.
    /// <see href="https://w3id.org/ontouml#shape"></see></summary>
    let shape = Namespaced_IRI.parse _namespace_name "shape" |> NamespacedName
    /// <summary>
    /// Identifies an ontouml:Property that represents the source side of an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#sourceEnd"></see></summary>
    let sourceEnd = Namespaced_IRI.parse _namespace_name "sourceEnd" |> NamespacedName
    /// <summary>
    /// Identifies an ontouml:ElementView that participates as source of an ontouml:RelationView or ontouml:GeneralizationView.
    /// <see href="https://w3id.org/ontouml#sourceView"></see></summary>
    let sourceView = Namespaced_IRI.parse _namespace_name "sourceView" |> NamespacedName
    /// <summary>
    /// Identifies the child ontouml:Classifier (e.g., a subclass) that participates in an ontouml:Generalization relation.
    /// <see href="https://w3id.org/ontouml#specific"></see></summary>
    let specific = Namespaced_IRI.parse _namespace_name "specific" |> NamespacedName

    /// <summary>
    /// Identifies a target ontouml:Property that is subsetted by a source ontouml:Property.
    /// <see href="https://w3id.org/ontouml#subsetsProperty"></see></summary>
    let subsetsProperty =
        Namespaced_IRI.parse _namespace_name "subsetsProperty" |> NamespacedName

    /// <summary>
    /// Identifies an ontouml:Property that represents the target side of an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#targetEnd"></see></summary>
    let targetEnd = Namespaced_IRI.parse _namespace_name "targetEnd" |> NamespacedName
    /// <summary>
    /// Identifies an ontouml:ElementView that participates as target of an ontouml:ConnectorView.
    /// <see href="https://w3id.org/ontouml#targetView"></see></summary>
    let targetView = Namespaced_IRI.parse _namespace_name "targetView" |> NamespacedName
    /// <summary>
    /// A string that register any information of an ontouml:Note
    /// <see href="https://w3id.org/ontouml#text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName

    /// <summary>
    /// Is direct mapped to the OntoUML Metamodel's 'topLeft' relationship between the classes RectangularShape and Point.
    /// Relates an ontouml:RectangularShape to an ontouml:Point that contains the horizontal and vertical coordinates (ontouml:xCoordinate and ontouml:yCoordinate, respectively) representing the former's top left position in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#topLeftPosition"></see></summary>
    let topLeftPosition =
        Namespaced_IRI.parse _namespace_name "topLeftPosition" |> NamespacedName

    /// <summary>
    /// Identifies the upper bound of an ontouml:Cardinality.
    /// E.g., if the ontouml:cardinalityValue set is [1..*] then the upper bound is '*'.
    /// An ontouml:Cardinality's upper bound must correspond to the one indicated by its ontouml:cardinalityValue property.
    /// <see href="https://w3id.org/ontouml#upperBound"></see></summary>
    let upperBound = Namespaced_IRI.parse _namespace_name "upperBound" |> NamespacedName
    /// <summary>
    /// Indicates the width of an ontouml:RectangularShape that is represented in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName

    /// <summary>
    /// Relates an ontouml:Point to the value indicating the specific x (horizontal) coordinate of the top left position of an ontouml:RectangularShape.
    /// Is direct mapped to the metamodel's 'x' attribute of the Point class.
    /// <see href="https://w3id.org/ontouml#xCoordinate"></see></summary>
    let xCoordinate =
        Namespaced_IRI.parse _namespace_name "xCoordinate" |> NamespacedName

    /// <summary>
    /// Relates an ontouml:Point to the value indicating the specific y (vertical) coordinate of the top left position of an ontouml:RectangularShape.
    /// Is direct mapped to the metamodel's 'y' attribute of the Point class.
    /// <see href="https://w3id.org/ontouml#yCoordinate"></see></summary>
    let yCoordinate =
        Namespaced_IRI.parse _namespace_name "yCoordinate" |> NamespacedName
