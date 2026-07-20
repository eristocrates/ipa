namespace https.w3id.org.ontouml.hash

open DoxAletheia

module ontouml =
    let _namespace_name = "https://w3id.org/ontouml#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.
    /// <see href="https://w3id.org/ontouml#abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// Indicates that the restricted type includes abstract individuals among its instances.
    /// <see href="https://w3id.org/ontouml#abstractNature"></see></summary>
    let abstractNature = _prefix "abstractNature"
    /// <summary>
    /// An individual of the ontouml:PropertyStereotype used to assign the corresponding stereotype to a given ontouml:Property.
    /// <see href="https://w3id.org/ontouml#begin"></see></summary>
    let begin_ = _prefix "begin"
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#bringsAbout"></see></summary>
    let bringsAbout = _prefix "bringsAbout"
    /// <summary>
    /// A rigid mixin that does not require a dependency to be specified. It is used to aggregate essential properties of individuals following different identity principles.
    /// <see href="https://w3id.org/ontouml#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// An ontouml:RelationStereotype attributed to a relation between a bearer type and its feature.
    /// <see href="https://w3id.org/ontouml#characterization"></see></summary>
    let characterization = _prefix "characterization"
    /// <summary>
    /// An ontouml:ClassStereotype used to represent rigid concepts that provide an identity principle for their instances.
    /// <see href="https://w3id.org/ontouml#collective"></see></summary>
    let collective = _prefix "collective"
    /// <summary>
    /// Indicates that the restricted type includes collective individuals among its instances.
    /// <see href="https://w3id.org/ontouml#collectiveNature"></see></summary>
    let collectiveNature = _prefix "collectiveNature"
    /// <summary>
    /// The stereotype for comparative relations (e.g., heavier-than). Decorates relations that always hold between any two individuals bearing the same relevant quality.
    /// <see href="https://w3id.org/ontouml#comparative"></see></summary>
    let comparative = _prefix "comparative"
    /// <summary>
    /// A parthood relation between two complexes.
    /// <see href="https://w3id.org/ontouml#componentOf"></see></summary>
    let componentOf = _prefix "componentOf"
    /// <summary>
    /// The value denoting that an ontouml:Property represents a composite aggregation, i.e., a strong form of aggregation.
    /// <see href="https://w3id.org/ontouml#composite"></see></summary>
    let composite = _prefix "composite"
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#creation"></see></summary>
    let creation = _prefix "creation"
    /// <summary>
    /// An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.
    /// <see href="https://w3id.org/ontouml#datatype"></see></summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#derivation"></see></summary>
    let derivation = _prefix "derivation"
    /// <summary>
    /// An individual of the ontouml:PropertyStereotype used to assign the corresponding stereotype to a given ontouml:Property.
    /// <see href="https://w3id.org/ontouml#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// Represents the enumeration stereotype, having values represented using ontouml:Literal instances.
    /// <see href="https://w3id.org/ontouml#enumeration"></see></summary>
    let enumeration = _prefix "enumeration"
    /// <summary>
    /// An individual of the ontouml:ClassStereotype used to assign the corresponding stereotype to a given ontouml:Class.
    /// Things that happen to or are performed by endurants (Casati and Varzi, 2015).
    /// <see href="https://w3id.org/ontouml#event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// Indicates that the restricted type includes event individuals among its instances.
    /// <see href="https://w3id.org/ontouml#eventNature"></see></summary>
    let eventNature = _prefix "eventNature"
    /// <summary>
    /// Identifies an endurant on which the extrinsicMode depends.
    /// <see href="https://w3id.org/ontouml#externalDependence"></see></summary>
    let externalDependence = _prefix "externalDependence"
    /// <summary>
    /// Identifies what inheres in a concrete individual and depends on others for its existence.
    /// <see href="https://w3id.org/ontouml#extrinsicModeNature"></see></summary>
    let extrinsicModeNature = _prefix "extrinsicModeNature"
    /// <summary>
    /// Identifies the nature of a complex object whose parts (components) play different roles in its composition.
    /// <see href="https://w3id.org/ontouml#functionalComplexNature"></see></summary>
    let functionalComplexNature = _prefix "functionalComplexNature"
    /// <summary>
    /// Identifies a concrete individual on which another concrete individual depends historically.
    /// <see href="https://w3id.org/ontouml#historicalDependence"></see></summary>
    let historicalDependence = _prefix "historicalDependence"
    /// <summary>
    /// Denotes the role of an endurant in virtue of having participated in an event of a particular type.
    /// <see href="https://w3id.org/ontouml#historicalRole"></see></summary>
    let historicalRole = _prefix "historicalRole"
    /// <summary>
    /// Denotes the equivalent of historicalRole for types that aggregate instances with different identity principles.
    /// <see href="https://w3id.org/ontouml#historicalRoleMixin"></see></summary>
    let historicalRoleMixin = _prefix "historicalRoleMixin"
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#instantiation"></see></summary>
    let instantiation = _prefix "instantiation"
    /// <summary>
    /// Indicates that the restricted type includes intrinsic mode individuals among its instances.
    /// <see href="https://w3id.org/ontouml#intrinsicModeNature"></see></summary>
    let intrinsicModeNature = _prefix "intrinsicModeNature"
    /// <summary>
    /// Used to represent rigid concepts that provide an identity principle for their instances and do not require a relational dependency.
    /// <see href="https://w3id.org/ontouml#kind"></see></summary>
    let kind = _prefix "kind"
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#manifestation"></see></summary>
    let manifestation = _prefix "manifestation"
    /// <summary>
    /// Identifies relations that have material structure on their own and include examples such as employments, kisses, enrollments, flight, connections and commitments.
    /// <see href="https://w3id.org/ontouml#material"></see></summary>
    let material = _prefix "material"
    /// <summary>
    /// A type of existential dependence relation (a form of nonfunctional inherence). It can be derived from the relation between the relata and the qua individuals that compose the relator and that inhere in the relata.
    /// <see href="https://w3id.org/ontouml#mediation"></see></summary>
    let mediation = _prefix "mediation"
    /// <summary>
    /// A parthood relation between a functional complex or a Collective (as a part) and a Collective (as a whole).
    /// <see href="https://w3id.org/ontouml#memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// Represents a semi-rigid type, i.e., it behaves as a rigid type for some individuals and as an anti-rigid one for others.
    /// <see href="https://w3id.org/ontouml#mixin"></see></summary>
    let mixin_ = _prefix "mixin"
    /// <summary>
    /// A particular type of intrinsic property that has no structured value.
    /// <see href="https://w3id.org/ontouml#mode"></see></summary>
    let mode = _prefix "mode"
    /// <summary>
    /// Denotes that an ontouml:Property is neither ontouml:shared nor ontouml:composite, but just an aggregation.
    /// <see href="https://w3id.org/ontouml#none"></see></summary>
    let none = _prefix "none"
    /// <summary>
    /// A relation for representing when an event depends on a single object.
    /// <see href="https://w3id.org/ontouml#participation"></see></summary>
    let participation = _prefix "participation"
    /// <summary>
    /// Denotes a kind of event decomposition.
    /// <see href="https://w3id.org/ontouml#participational"></see></summary>
    let participational = _prefix "participational"
    /// <summary>
    /// Used to represent anti-rigid subtypes of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity) that are instantiated by changes in intrinsic properties (e.g., the age of a person, the color of an object, the condition of a car).Phases always come in partitions.
    /// <see href="https://w3id.org/ontouml#phase"></see></summary>
    let phase = _prefix "phase"
    /// <summary>
    /// The equivalent of Phase for types that aggregate instances with different identity principles. A class stereotyped as PhaseMixin is also an anti-rigid type. PhaseMixin is similar semantically to RoleMixin with the difference in relational dependency.
    /// <see href="https://w3id.org/ontouml#phaseMixin"></see></summary>
    let phaseMixin = _prefix "phaseMixin"
    /// <summary>
    /// A Quality is a particular type of intrinsic property that has a structured value. Qualities are things that existentially depend on the things they characterize, called their bearers.
    /// <see href="https://w3id.org/ontouml#quality"></see></summary>
    let quality = _prefix "quality"
    /// <summary>
    /// Indicates that the restricted type includes quality individuals among its instances.
    /// <see href="https://w3id.org/ontouml#qualityNature"></see></summary>
    let qualityNature = _prefix "qualityNature"
    /// <summary>
    /// Construct used to represent rigid concepts that provide an identity principle for their instances.
    /// <see href="https://w3id.org/ontouml#quantity"></see></summary>
    let quantity = _prefix "quantity"
    /// <summary>
    /// Indicates that the restricted type includes quantity individuals among its instances.
    /// <see href="https://w3id.org/ontouml#quantityNature"></see></summary>
    let quantityNature = _prefix "quantityNature"
    /// <summary>
    /// A construct used to represent truth-makers of material relations, i.e., the things that must exist for two or more individuals to be connected by material relations.
    /// <see href="https://w3id.org/ontouml#relator"></see></summary>
    let relator = _prefix "relator"
    /// <summary>
    /// Indicates that the restricted type includes relator individuals among its instances.
    /// <see href="https://w3id.org/ontouml#relatorNature"></see></summary>
    let relatorNature = _prefix "relatorNature"
    /// <summary>
    /// Used to represent anti-rigid specializations of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity) that are instantiated in relational contexts.
    /// <see href="https://w3id.org/ontouml#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// The equivalent of Role for types that aggregate instances with different identity principles.
    /// <see href="https://w3id.org/ontouml#roleMixin"></see></summary>
    let roleMixin = _prefix "roleMixin"
    /// <summary>
    /// Indicates that the ontouml:Property has shared aggregation semantics.
    /// <see href="https://w3id.org/ontouml#shared"></see></summary>
    let shared = _prefix "shared"
    /// <summary>
    /// Can be used to represent certain configurations of entities that can be comprehended as a whole.
    /// <see href="https://w3id.org/ontouml#situation"></see></summary>
    let situation = _prefix "situation"
    /// <summary>
    /// Indicates that the restricted type includes situation individuals among its instances.
    /// <see href="https://w3id.org/ontouml#situationNature"></see></summary>
    let situationNature = _prefix "situationNature"
    /// <summary>
    /// A parthood relation between two collectives.
    /// <see href="https://w3id.org/ontouml#subCollectionOf"></see></summary>
    let subCollectionOf = _prefix "subCollectionOf"
    /// <summary>
    /// A parthood relation between two quantities.
    /// <see href="https://w3id.org/ontouml#subQuantityOf"></see></summary>
    let subQuantityOf = _prefix "subQuantityOf"
    /// <summary>
    /// Used to represent rigid specializations of identity providers (Kind, Collective, Quantity, Relator, Mode, and Quantity).
    /// <see href="https://w3id.org/ontouml#subkind"></see></summary>
    let subkind = _prefix "subkind"
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#termination"></see></summary>
    let termination = _prefix "termination"
    /// <summary>
    /// An individual of the ontouml:RelationStereotype used to assign the corresponding stereotype to a given ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#triggers"></see></summary>
    let triggers = _prefix "triggers"
    /// <summary>
    /// The stereotype for high-order types.
    /// <see href="https://w3id.org/ontouml#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Indicates that the restricted type includes type individuals among its instances.
    /// <see href="https://w3id.org/ontouml#typeNature"></see></summary>
    let typeNature = _prefix "typeNature"
    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:composite, ontouml:none, and ontouml:shared.
    /// Groups all possible aggregation kinds to which an ontouml:Property can be related.
    /// <see href="https://w3id.org/ontouml#AggregationKind"></see></summary>
    let AggregationKind = _prefix "AggregationKind"
    /// <summary>
    /// Represents the cardinality of an ontouml:Property through its data property ontouml:cardinalityValue.
    /// <see href="https://w3id.org/ontouml#Cardinality"></see></summary>
    let Cardinality = _prefix "Cardinality"
    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:abstractNature, ontouml:collectiveNature, ontouml:eventNature, ontouml:extrinsicModeNature, ontouml:functionalComplexNature, ontouml:intrinsicModeNature, ontouml:qualityNature, ontouml:quantityNature, ontouml:relatorNature, ontouml:situationNature, and ontouml:typeNature.
    /// Collection of individuals that represent fundamental conceptual modeling issues according to the Unified Foundational Ontology (UFO) theory.
    /// <see href="https://w3id.org/ontouml#OntologicalNature"></see></summary>
    let OntologicalNature = _prefix "OntologicalNature"
    /// <summary>
    /// Abstract class that groups different elements an ontoUML model can have.
    /// <see href="https://w3id.org/ontouml#OntoumlElement"></see></summary>
    let OntoumlElement = _prefix "OntoumlElement"
    /// <summary>
    /// Contains the ontouml:xCoordinate value and ontouml:yCoordinate value. These values represent the top left position of an ontouml:RectangularShape, to which the ontouml:Point is related vian ontouml:topLeftPosition property.
    /// <see href="https://w3id.org/ontouml#Point"></see></summary>
    let Point = _prefix "Point"
    /// <summary>
    /// Indicates meta-properties of classes, properties, or relations.
    /// <see href="https://w3id.org/ontouml#Stereotype"></see></summary>
    let Stereotype = _prefix "Stereotype"
    /// <summary>
    /// An ontouml:Class have exactly one ontouml:Stereotype (i.e., it is a mandatory property) of specific type ontouml:ClassStereotype. This information is formalized by the ontouml:stereotype property.
    /// Represents a type defined in the ontology.
    /// <see href="https://w3id.org/ontouml#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:abstract, ontouml:category, ontouml:collective, ontouml:datatype, ontouml:enumeration, ontouml:event, ontouml:historicalRole, ontouml:historicalRoleMixin, ontouml:kind, ontouml:mixin, ontouml:mode, ontouml:phase, ontouml:phaseMixin, ontouml:quality, ontouml:quantity, ontouml:relator, ontouml:role, ontouml:roleMixin, ontouml:situation, ontouml:subkind, and ontouml:type.
    /// Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Class.
    /// <see href="https://w3id.org/ontouml#ClassStereotype"></see></summary>
    let ClassStereotype = _prefix "ClassStereotype"
    /// <summary>
    /// Identifies the ontouml:Stereotype applied to the ontouml:DecoratableElement.
    /// <see href="https://w3id.org/ontouml#stereotype"></see></summary>
    let stereotype = _prefix "stereotype"
    /// <summary>
    /// Abstract class that groups the classes ontouml:Class and ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#Classifier"></see></summary>
    let Classifier = _prefix "Classifier"
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Class in a given ontouml:Diagram.
    /// Does not directly contain data about the visual representation (rectangular shape's size and position) itself, but is related to this information via the ontouml:shape property.
    /// <see href="https://w3id.org/ontouml#ClassView"></see></summary>
    let ClassView = _prefix "ClassView"
    /// <summary>
    /// Abstract class that groups the classes ontouml:NoteView, ontouml:ClassView, and ontouml:PackageView.
    /// <see href="https://w3id.org/ontouml#NodeView"></see></summary>
    let NodeView = _prefix "NodeView"
    /// <summary>
    /// Abstract class that groups the classes ontouml:Classifier and the ontouml:Property.
    /// <see href="https://w3id.org/ontouml#DecoratableElement"></see></summary>
    let DecoratableElement = _prefix "DecoratableElement"
    /// <summary>
    /// An ontouml:Relation may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:RelationStereotype. This information is formalized by the ontouml:stereotype property.
    /// Represents a relation defined in the ontology.
    /// <see href="https://w3id.org/ontouml#Relation"></see></summary>
    let Relation = _prefix "Relation"
    /// <summary>
    /// Abstract class that groups the classes ontouml:RelationView and ontouml:GeneralizationView.
    /// <see href="https://w3id.org/ontouml#ConnectorView"></see></summary>
    let ConnectorView = _prefix "ConnectorView"
    /// <summary>
    /// Abstract class that groups the classes ontouml:ConnectorView, ontouml:GeneralizationSetView, and ontouml:NodeView.
    /// Represents the diagramatical representation of an element on an ontouml:Diagram.
    /// E.g., an ontouml:ClassView is created whenever an ontouml:ModelElement is represented in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#ElementView"></see></summary>
    let ElementView = _prefix "ElementView"
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Generalization in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#GeneralizationView"></see></summary>
    let GeneralizationView = _prefix "GeneralizationView"
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Relation in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#RelationView"></see></summary>
    let RelationView = _prefix "RelationView"
    /// <summary>
    /// Abstract class that groups diverse elements that can be represented in on OntoUML model.
    /// <see href="https://w3id.org/ontouml#ModelElement"></see></summary>
    let ModelElement = _prefix "ModelElement"
    /// <summary>
    /// An ontouml:Property may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:PropertyStereotype. This information is formalized by the ontouml:stereotype property.
    /// Represents a property defined in the ontology. Properties contained by classes are deemed attributes and those contained by relations are deemed association ends.
    /// <see href="https://w3id.org/ontouml#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// A visual representation of an OntoUML model or of a portion of it.
    /// <see href="https://w3id.org/ontouml#Diagram"></see></summary>
    let Diagram = _prefix "Diagram"
    /// <summary>
    /// Abstract class that groups the classes ontouml:ElementView and the ontouml:Shape.
    /// <see href="https://w3id.org/ontouml#DiagramElement"></see></summary>
    let DiagramElement = _prefix "DiagramElement"
    /// <summary>
    /// Contains information about the diagramation of an ontouml:ModelElement through its relation with an ontouml:ElementView.
    /// <see href="https://w3id.org/ontouml#Shape"></see></summary>
    let Shape = _prefix "Shape"
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:GeneralizationSet in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#GeneralizationSetView"></see></summary>
    let GeneralizationSetView = _prefix "GeneralizationSetView"
    /// <summary>
    /// Represents a generalization defined in an ontology.
    /// <see href="https://w3id.org/ontouml#Generalization"></see></summary>
    let Generalization = _prefix "Generalization"
    /// <summary>
    /// Represents a generalization set defined in the ontology.
    /// <see href="https://w3id.org/ontouml#GeneralizationSet"></see></summary>
    let GeneralizationSet = _prefix "GeneralizationSet"
    /// <summary>
    /// Represents a possible value for an ontouml:Class defined by an ontouml:enumeration.
    /// <see href="https://w3id.org/ontouml#Literal"></see></summary>
    let Literal = _prefix "Literal"
    /// <summary>
    /// Type of ontouml:ModelElement used to represent textual information.
    /// <see href="https://w3id.org/ontouml#Note"></see></summary>
    let Note = _prefix "Note"
    /// <summary>
    /// Aggregates ontology components, working as a container.
    /// <see href="https://w3id.org/ontouml#Package"></see></summary>
    let Package = _prefix "Package"
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Note in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#NoteView"></see></summary>
    let NoteView = _prefix "NoteView"
    /// <summary>
    /// Represents the diagramation (i.e., the visual representation) of an ontouml:Package in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#PackageView"></see></summary>
    let PackageView = _prefix "PackageView"
    /// <summary>
    /// It is the upper non-abstract class available in the OntoUML Vocabulary.
    /// Aggregates all entities that are part of a same conceptual model, including concepts declaration and their visual representation.
    /// <see href="https://w3id.org/ontouml#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// A list of connected ontouml:Point values to represent an ontouml:ElementView's shape.
    /// <see href="https://w3id.org/ontouml#Path"></see></summary>
    let Path = _prefix "Path"
    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:begin, and ontouml:end.
    /// Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Property.
    /// <see href="https://w3id.org/ontouml#PropertyStereotype"></see></summary>
    let PropertyStereotype = _prefix "PropertyStereotype"
    /// <summary>
    /// A particular type of ontouml:RectangularShape, mainly used to represent entities of type ontouml:Class.
    /// <see href="https://w3id.org/ontouml#Rectangle"></see></summary>
    let Rectangle = _prefix "Rectangle"
    /// <summary>
    /// Represents a rectangular shape in a given ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#RectangularShape"></see></summary>
    let RectangularShape = _prefix "RectangularShape"
    /// <summary>
    /// An ontouml:RectangularShape used to represent some textual information in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#Text"></see></summary>
    let Text = _prefix "Text"
    /// <summary>
    /// This class is an enumeration of its individuals, which are: ontouml:bringsAbout, ontouml:characterization, ontouml:comparative, ontouml:componentOf, ontouml:creation, ontouml:derivation, ontouml:externalDependence, ontouml:historicalDependence, ontouml:instantiation, ontouml:manifestation, ontouml:material, ontouml:mediation, ontouml:memberOf, ontouml:participation, ontouml:participational, ontouml:subCollectionOf, ontouml:subQuantityOf, ontouml:termination, and ontouml:triggers.
    /// Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#RelationStereotype"></see></summary>
    let RelationStereotype = _prefix "RelationStereotype"
    /// <summary>
    /// Characterizes an ontouml:Property with an ontouml:AggregationKind instance, i.e., indicates whether the ontouml:Property is a simple (ontouml:none), a shared (ontouml:shared), or a composite (ontouml:composite) property.
    /// <see href="https://w3id.org/ontouml#aggregationKind"></see></summary>
    let aggregationKind = _prefix "aggregationKind"
    /// <summary>
    /// Relates an instance of an ontouml:Class to its properties, which are instances of the ontouml:Property class.
    /// <see href="https://w3id.org/ontouml#attribute"></see></summary>
    let attribute = _prefix "attribute"
    /// <summary>
    /// Identifies an ontouml:Property exhibited by an ontouml:Classifier. If the ontouml:Classifier is of type ontouml:Class, the ontouml:property is specialized in ontouml:attribute. If the ontouml:Classifier is an ontouml:Relation, the property is specialized in ontouml:relationEnd.
    /// Aggregates its subproperties ontouml:attribute and ontouml:relationEnd. Should not be directly used.
    /// <see href="https://w3id.org/ontouml#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// Identifies the individual of type ontouml:Cardinality that represents the cardinalities of an ontouml:Property.
    /// <see href="https://w3id.org/ontouml#cardinality"></see></summary>
    let cardinality = _prefix "cardinality"
    /// <summary>
    /// Provides the complete (i.e., both lower and upper cardinality's bounds) cardinalities of an ontouml:Property via its related ontouml:Cardinality.
    /// <see href="https://w3id.org/ontouml#cardinalityValue"></see></summary>
    let cardinalityValue = _prefix "cardinalityValue"
    /// <summary>
    ///  Identifies the ontouml:Class that is instantiated by the specific classes of the ontouml:Generalization type composing the ontouml:GeneralizationSet
    /// <see href="https://w3id.org/ontouml#categorizer"></see></summary>
    let categorizer = _prefix "categorizer"
    /// <summary>
    /// It is mapped to the OntoUML Metamodel's 'contents' relation between the Package and ModelElement classes.
    /// Identifies an instance of type ontouml:ModelElement that composes in an ontouml:Package.
    /// <see href="https://w3id.org/ontouml#containsModelElement"></see></summary>
    let containsModelElement = _prefix "containsModelElement"
    /// <summary>
    /// Identifies an instance of type ontouml:ElementView that is contained in an ontouml:Diagram, representing the concrete diagramation of an ontouml:ModelElement.
    /// <see href="https://w3id.org/ontouml#containsView"></see></summary>
    let containsView = _prefix "containsView"
    /// <summary>
    /// Relates an ontouml:OntoumlElement to a string representing its description in free textual format.
    /// <see href="https://w3id.org/ontouml#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// It is mapped to the OntoUML Metamodel's 'diagrams' relation between the Project and Diagram classes.
    /// Identifies which entities of type ontouml:Diagram are part of an ontouml:Project.
    /// <see href="https://w3id.org/ontouml#diagram"></see></summary>
    let diagram = _prefix "diagram"
    /// <summary>
    /// Identifies the parent ontouml:Classifier (e.g., a superclass) that participates in an ontouml:Generalization relation.
    /// <see href="https://w3id.org/ontouml#general"></see></summary>
    let general = _prefix "general"
    /// <summary>
    /// Identifies an ontouml:Generalization that participates in an ontouml:GeneralizationSet.
    /// <see href="https://w3id.org/ontouml#generalization"></see></summary>
    let generalization = _prefix "generalization"
    /// <summary>
    /// Indicates the height of an ontouml:RectangularShape that is represented in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// Indicates if the ontouml:Classifier can have direct instances. If set to true, the classifier must be specialized before being instantiated. Otherwise, it can have direct instances.
    /// <see href="https://w3id.org/ontouml#isAbstract"></see></summary>
    let isAbstract = _prefix "isAbstract"
    /// <summary>
    /// Indicates if an ontouml:GeneralizationSet is complete, i.e., if it does not admit further generalizations.
    /// <see href="https://w3id.org/ontouml#isComplete"></see></summary>
    let isComplete = _prefix "isComplete"
    /// <summary>
    /// Indicates if an ontouml:DecoratableElement can be defined through a derivation rule.
    /// <see href="https://w3id.org/ontouml#isDerived"></see></summary>
    let isDerived = _prefix "isDerived"
    /// <summary>
    /// Indicates if an ontouml:GeneralizationSet is disjoint, i.e., it does not admit generalizations having overlapping subclasses.
    /// <see href="https://w3id.org/ontouml#isDisjoint"></see></summary>
    let isDisjoint = _prefix "isDisjoint"
    /// <summary>
    /// Indicates if an ontouml:Class is extensionally defined (i.e., it's parts cannot change).
    /// <see href="https://w3id.org/ontouml#isExtensional"></see></summary>
    let isExtensional = _prefix "isExtensional"
    /// <summary>
    /// Indicates if an ontouml:Property is ordered or not, i.e., if it requires an exact order of its values or not.
    /// <see href="https://w3id.org/ontouml#isOrdered"></see></summary>
    let isOrdered = _prefix "isOrdered"
    /// <summary>
    /// The ontouml:Class data property ontouml:isPowertype must not be true when it has an ontouml:order equal to one.
    /// Indicates if an ontouml:Class is a powertype in multi-level modeling.
    /// <see href="https://w3id.org/ontouml#isPowertype"></see></summary>
    let isPowertype = _prefix "isPowertype"
    /// <summary>
    /// Indicates if an ontouml:Property can or cannot be updated or modified.
    /// <see href="https://w3id.org/ontouml#isReadOnly"></see></summary>
    let isReadOnly = _prefix "isReadOnly"
    /// <summary>
    /// Relates an ontouml:ElementView to ontouml:ModelElement, indicating the diagrammatical representation of the latter in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#isViewOf"></see></summary>
    let isViewOf = _prefix "isViewOf"
    /// <summary>
    /// Relates an ontouml:Literal to its container enumeration class (an ontouml:Class that has the ontouml:stereotype property with ontouml:enumeration).
    /// <see href="https://w3id.org/ontouml#literal"></see></summary>
    let literal = _prefix "literal"
    /// <summary>
    /// Identifies the lower bound of an ontouml:Cardinality.
    /// E.g., if the ontouml:cardinalityValue set is [1..*] then the lower bound is '1'.
    /// An ontouml:Cardinality's lower bound must correspond to the one indicated by its ontouml:cardinalityValue property.
    /// <see href="https://w3id.org/ontouml#lowerBound"></see></summary>
    let lowerBound = _prefix "lowerBound"
    /// <summary>
    /// Relates an ontouml:Project to an ontouml:Package that is part of it.
    /// <see href="https://w3id.org/ontouml#model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    /// A string that identifies or names an ontouml:OntoumlElement.
    /// <see href="https://w3id.org/ontouml#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Indicates the order of an ontouml:Class, enabling multi-level modeling.
    /// Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype ontouml:type must have an ontouml:order value grater than 1.
    /// Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype different than ontouml:type must have an ontouml:order value equal to 1.
    /// <see href="https://w3id.org/ontouml#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Relates an ontouml:Diagram to an ontouml:ModelElement that is represented on it, i.e., to an ontouml:ModelElement that has an ontouml:ElementView on that ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// Relates an ontouml:Path to an ontouml:Point that composes it.
    /// <see href="https://w3id.org/ontouml#point"></see></summary>
    let point = _prefix "point"
    /// <summary>
    /// Relates an ontouml:OntoumlElement different than ontouml:Project to an ontouml:Project that it composes.
    /// <see href="https://w3id.org/ontouml#project"></see></summary>
    let project = _prefix "project"
    /// <summary>
    /// Identifies an ontouml:Class or ontouml:Relation (i.e., an ontouml:Classifier) to which an ontouml:Property refers.
    /// <see href="https://w3id.org/ontouml#propertyType"></see></summary>
    let propertyType = _prefix "propertyType"
    /// <summary>
    /// Identifies a target ontouml:Property that is redefined by a source ontouml:Property.
    /// <see href="https://w3id.org/ontouml#redefinesProperty"></see></summary>
    let redefinesProperty = _prefix "redefinesProperty"
    /// <summary>
    /// Identifies a property that represents one end (source or target) of an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#relationEnd"></see></summary>
    let relationEnd = _prefix "relationEnd"
    /// <summary>
    /// Associates an ontouml:Class to an ontouml:OntologicalNature, restricting its allowed values.
    /// <see href="https://w3id.org/ontouml#restrictedTo"></see></summary>
    let restrictedTo = _prefix "restrictedTo"
    /// <summary>
    /// Relates an ontouml:ElementView to an ontouml:Shape that contains the diagramation's data (size and position) about the ontouml:ModelElement it is a view of.
    /// <see href="https://w3id.org/ontouml#shape"></see></summary>
    let shape = _prefix "shape"
    /// <summary>
    /// Identifies an ontouml:Property that represents the source side of an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#sourceEnd"></see></summary>
    let sourceEnd = _prefix "sourceEnd"
    /// <summary>
    /// Identifies an ontouml:ElementView that participates as source of an ontouml:RelationView or ontouml:GeneralizationView.
    /// <see href="https://w3id.org/ontouml#sourceView"></see></summary>
    let sourceView = _prefix "sourceView"
    /// <summary>
    /// Identifies the child ontouml:Classifier (e.g., a subclass) that participates in an ontouml:Generalization relation.
    /// <see href="https://w3id.org/ontouml#specific"></see></summary>
    let specific = _prefix "specific"
    /// <summary>
    /// Identifies a target ontouml:Property that is subsetted by a source ontouml:Property.
    /// <see href="https://w3id.org/ontouml#subsetsProperty"></see></summary>
    let subsetsProperty = _prefix "subsetsProperty"
    /// <summary>
    /// Identifies an ontouml:Property that represents the target side of an ontouml:Relation.
    /// <see href="https://w3id.org/ontouml#targetEnd"></see></summary>
    let targetEnd = _prefix "targetEnd"
    /// <summary>
    /// Identifies an ontouml:ElementView that participates as target of an ontouml:ConnectorView.
    /// <see href="https://w3id.org/ontouml#targetView"></see></summary>
    let targetView = _prefix "targetView"
    /// <summary>
    /// A string that register any information of an ontouml:Note
    /// <see href="https://w3id.org/ontouml#text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// Is direct mapped to the OntoUML Metamodel's 'topLeft' relationship between the classes RectangularShape and Point.
    /// Relates an ontouml:RectangularShape to an ontouml:Point that contains the horizontal and vertical coordinates (ontouml:xCoordinate and ontouml:yCoordinate, respectively) representing the former's top left position in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#topLeftPosition"></see></summary>
    let topLeftPosition = _prefix "topLeftPosition"
    /// <summary>
    /// Identifies the upper bound of an ontouml:Cardinality.
    /// E.g., if the ontouml:cardinalityValue set is [1..*] then the upper bound is '*'.
    /// An ontouml:Cardinality's upper bound must correspond to the one indicated by its ontouml:cardinalityValue property.
    /// <see href="https://w3id.org/ontouml#upperBound"></see></summary>
    let upperBound = _prefix "upperBound"
    /// <summary>
    /// Indicates the width of an ontouml:RectangularShape that is represented in an ontouml:Diagram.
    /// <see href="https://w3id.org/ontouml#width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// Relates an ontouml:Point to the value indicating the specific x (horizontal) coordinate of the top left position of an ontouml:RectangularShape.
    /// Is direct mapped to the metamodel's 'x' attribute of the Point class.
    /// <see href="https://w3id.org/ontouml#xCoordinate"></see></summary>
    let xCoordinate = _prefix "xCoordinate"
    /// <summary>
    /// Relates an ontouml:Point to the value indicating the specific y (vertical) coordinate of the top left position of an ontouml:RectangularShape.
    /// Is direct mapped to the metamodel's 'y' attribute of the Point class.
    /// <see href="https://w3id.org/ontouml#yCoordinate"></see></summary>
    let yCoordinate = _prefix "yCoordinate"
