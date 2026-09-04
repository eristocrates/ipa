#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ontouml =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/ontouml#" "ontouml"
    /// <summary>
    ///   <para>rdfs:comment : This class is an enumeration of its individuals, which are: ontouml:composite, ontouml:none, and ontouml:shared.rdfs:comment : Groups all possible aggregation kinds to which an ontouml:Property can be related.</para>
    ///   <para>rdfs:label : AggregationKind</para>
    ///   <a href="https://w3id.org/ontouml#AggregationKind">ontouml:AggregationKind</a>
    /// </summary>
    let AggregationKind = _prefixId.prefix "AggregationKind"
    /// <summary>
    ///   <para>rdfs:comment : Represents the cardinality of an ontouml:Property through its data property ontouml:cardinalityValue.</para>
    ///   <para>rdfs:label : Cardinality</para>
    ///   <a href="https://w3id.org/ontouml#Cardinality">ontouml:Cardinality</a>
    /// </summary>
    let Cardinality = _prefixId.prefix "Cardinality"
    /// <summary>
    ///   <para>rdfs:comment : An ontouml:Class have exactly one ontouml:Stereotype (i.e., it is a mandatory property) of specific type ontouml:ClassStereotype. This information is formalized by the ontouml:stereotype property.rdfs:comment : Represents a type defined in the ontology.</para>
    ///   <para>rdfs:label : Class</para>
    ///   <a href="https://w3id.org/ontouml#Class">ontouml:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:comment : This class is an enumeration of its individuals, which are: ontouml:abstract, ontouml:category, ontouml:collective, ontouml:datatype, ontouml:enumeration, ontouml:event, ontouml:historicalRole, ontouml:historicalRoleMixin, ontouml:kind, ontouml:mixin, ontouml:mode, ontouml:phase, ontouml:phaseMixin, ontouml:quality, ontouml:quantity, ontouml:relator, ontouml:role, ontouml:roleMixin, ontouml:situation, ontouml:subkind, and ontouml:type.rdfs:comment : Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Class.</para>
    ///   <para>rdfs:label : ClassStereotype</para>
    ///   <a href="https://w3id.org/ontouml#ClassStereotype">ontouml:ClassStereotype</a>
    /// </summary>
    let ClassStereotype = _prefixId.prefix "ClassStereotype"
    /// <summary>
    ///   <para>rdfs:comment : Represents the diagramation (i.e., the visual representation) of an ontouml:Class in a given ontouml:Diagram.rdfs:comment : Does not directly contain data about the visual representation (rectangular shape's size and position) itself, but is related to this information via the ontouml:shape property.</para>
    ///   <para>rdfs:label : ClassView</para>
    ///   <a href="https://w3id.org/ontouml#ClassView">ontouml:ClassView</a>
    /// </summary>
    let ClassView = _prefixId.prefix "ClassView"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups the classes ontouml:Class and ontouml:Relation.</para>
    ///   <para>rdfs:label : Classifier</para>
    ///   <a href="https://w3id.org/ontouml#Classifier">ontouml:Classifier</a>
    /// </summary>
    let Classifier = _prefixId.prefix "Classifier"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups the classes ontouml:RelationView and ontouml:GeneralizationView.</para>
    ///   <para>rdfs:label : ConnectorView</para>
    ///   <a href="https://w3id.org/ontouml#ConnectorView">ontouml:ConnectorView</a>
    /// </summary>
    let ConnectorView = _prefixId.prefix "ConnectorView"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups the classes ontouml:Classifier and the ontouml:Property.</para>
    ///   <para>rdfs:label : DecoratableElement</para>
    ///   <a href="https://w3id.org/ontouml#DecoratableElement">ontouml:DecoratableElement</a>
    /// </summary>
    let DecoratableElement = _prefixId.prefix "DecoratableElement"
    /// <summary>
    ///   <para>rdfs:comment : A visual representation of an OntoUML model or of a portion of it.</para>
    ///   <para>rdfs:label : Diagram</para>
    ///   <a href="https://w3id.org/ontouml#Diagram">ontouml:Diagram</a>
    /// </summary>
    let Diagram = _prefixId.prefix "Diagram"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups the classes ontouml:ElementView and the ontouml:Shape.</para>
    ///   <para>rdfs:label : DiagramElement</para>
    ///   <a href="https://w3id.org/ontouml#DiagramElement">ontouml:DiagramElement</a>
    /// </summary>
    let DiagramElement = _prefixId.prefix "DiagramElement"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups the classes ontouml:ConnectorView, ontouml:GeneralizationSetView, and ontouml:NodeView.rdfs:comment : Represents the diagramatical representation of an element on an ontouml:Diagram.rdfs:comment : E.g., an ontouml:ClassView is created whenever an ontouml:ModelElement is represented in an ontouml:Diagram.</para>
    ///   <para>rdfs:label : ElementView</para>
    ///   <a href="https://w3id.org/ontouml#ElementView">ontouml:ElementView</a>
    /// </summary>
    let ElementView = _prefixId.prefix "ElementView"
    /// <summary>
    ///   <para>rdfs:comment : Represents a generalization defined in an ontology.</para>
    ///   <para>rdfs:label : Generalization</para>
    ///   <a href="https://w3id.org/ontouml#Generalization">ontouml:Generalization</a>
    /// </summary>
    let Generalization = _prefixId.prefix "Generalization"
    /// <summary>
    ///   <para>rdfs:comment : Represents a generalization set defined in the ontology.</para>
    ///   <para>rdfs:label : GeneralizationSet</para>
    ///   <a href="https://w3id.org/ontouml#GeneralizationSet">ontouml:GeneralizationSet</a>
    /// </summary>
    let GeneralizationSet = _prefixId.prefix "GeneralizationSet"
    /// <summary>
    ///   <para>rdfs:comment : Represents the diagramation (i.e., the visual representation) of an ontouml:GeneralizationSet in a given ontouml:Diagram.</para>
    ///   <para>rdfs:label : GeneralizationSetView</para>
    ///   <a href="https://w3id.org/ontouml#GeneralizationSetView">ontouml:GeneralizationSetView</a>
    /// </summary>
    let GeneralizationSetView = _prefixId.prefix "GeneralizationSetView"
    /// <summary>
    ///   <para>rdfs:comment : Represents the diagramation (i.e., the visual representation) of an ontouml:Generalization in a given ontouml:Diagram.</para>
    ///   <para>rdfs:label : GeneralizationView</para>
    ///   <a href="https://w3id.org/ontouml#GeneralizationView">ontouml:GeneralizationView</a>
    /// </summary>
    let GeneralizationView = _prefixId.prefix "GeneralizationView"
    /// <summary>
    ///   <para>rdfs:comment : Represents a possible value for an ontouml:Class defined by an ontouml:enumeration.</para>
    ///   <para>rdfs:label : Literal</para>
    ///   <a href="https://w3id.org/ontouml#Literal">ontouml:Literal</a>
    /// </summary>
    let Literal = _prefixId.prefix "Literal"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups diverse elements that can be represented in on OntoUML model.</para>
    ///   <para>rdfs:label : ModelElement</para>
    ///   <a href="https://w3id.org/ontouml#ModelElement">ontouml:ModelElement</a>
    /// </summary>
    let ModelElement = _prefixId.prefix "ModelElement"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups the classes ontouml:NoteView, ontouml:ClassView, and ontouml:PackageView.</para>
    ///   <para>rdfs:label : NodeView</para>
    ///   <a href="https://w3id.org/ontouml#NodeView">ontouml:NodeView</a>
    /// </summary>
    let NodeView = _prefixId.prefix "NodeView"
    /// <summary>
    ///   <para>rdfs:comment : Type of ontouml:ModelElement used to represent textual information.</para>
    ///   <para>rdfs:label : Note</para>
    ///   <a href="https://w3id.org/ontouml#Note">ontouml:Note</a>
    /// </summary>
    let Note = _prefixId.prefix "Note"
    /// <summary>
    ///   <para>rdfs:comment : Represents the diagramation (i.e., the visual representation) of an ontouml:Note in a given ontouml:Diagram.</para>
    ///   <para>rdfs:label : NoteView</para>
    ///   <a href="https://w3id.org/ontouml#NoteView">ontouml:NoteView</a>
    /// </summary>
    let NoteView = _prefixId.prefix "NoteView"
    /// <summary>
    ///   <para>rdfs:comment : This class is an enumeration of its individuals, which are: ontouml:abstractNature, ontouml:collectiveNature, ontouml:eventNature, ontouml:extrinsicModeNature, ontouml:functionalComplexNature, ontouml:intrinsicModeNature, ontouml:qualityNature, ontouml:quantityNature, ontouml:relatorNature, ontouml:situationNature, and ontouml:typeNature.rdfs:comment : Collection of individuals that represent fundamental conceptual modeling issues according to the Unified Foundational Ontology (UFO) theory.</para>
    ///   <para>rdfs:label : OntologicalNature</para>
    ///   <a href="https://w3id.org/ontouml#OntologicalNature">ontouml:OntologicalNature</a>
    /// </summary>
    let OntologicalNature = _prefixId.prefix "OntologicalNature"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class that groups different elements an ontoUML model can have.</para>
    ///   <para>rdfs:label : OntoumlElement</para>
    ///   <a href="https://w3id.org/ontouml#OntoumlElement">ontouml:OntoumlElement</a>
    /// </summary>
    let OntoumlElement = _prefixId.prefix "OntoumlElement"
    /// <summary>
    ///   <para>rdfs:comment : Aggregates ontology components, working as a container.</para>
    ///   <para>rdfs:label : Package</para>
    ///   <a href="https://w3id.org/ontouml#Package">ontouml:Package</a>
    /// </summary>
    let Package = _prefixId.prefix "Package"
    /// <summary>
    ///   <para>rdfs:comment : Represents the diagramation (i.e., the visual representation) of an ontouml:Package in a given ontouml:Diagram.</para>
    ///   <para>rdfs:label : PackageView</para>
    ///   <a href="https://w3id.org/ontouml#PackageView">ontouml:PackageView</a>
    /// </summary>
    let PackageView = _prefixId.prefix "PackageView"
    /// <summary>
    ///   <para>rdfs:comment : A list of connected ontouml:Point values to represent an ontouml:ElementView's shape.</para>
    ///   <para>rdfs:label : Path</para>
    ///   <a href="https://w3id.org/ontouml#Path">ontouml:Path</a>
    /// </summary>
    let Path = _prefixId.prefix "Path"
    /// <summary>
    ///   <para>rdfs:comment : Contains the ontouml:xCoordinate value and ontouml:yCoordinate value. These values represent the top left position of an ontouml:RectangularShape, to which the ontouml:Point is related vian ontouml:topLeftPosition property.</para>
    ///   <para>rdfs:label : Point</para>
    ///   <a href="https://w3id.org/ontouml#Point">ontouml:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:comment : It is the upper non-abstract class available in the OntoUML Vocabulary.rdfs:comment : Aggregates all entities that are part of a same conceptual model, including concepts declaration and their visual representation.</para>
    ///   <para>rdfs:label : Project</para>
    ///   <a href="https://w3id.org/ontouml#Project">ontouml:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:comment : An ontouml:Property may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:PropertyStereotype. This information is formalized by the ontouml:stereotype property.rdfs:comment : Represents a property defined in the ontology. Properties contained by classes are deemed attributes and those contained by relations are deemed association ends.</para>
    ///   <para>rdfs:label : Property</para>
    ///   <a href="https://w3id.org/ontouml#Property">ontouml:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:comment : This class is an enumeration of its individuals, which are: ontouml:begin, and ontouml:end.rdfs:comment : Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Property.</para>
    ///   <para>rdfs:label : PropertyStereotype</para>
    ///   <a href="https://w3id.org/ontouml#PropertyStereotype">ontouml:PropertyStereotype</a>
    /// </summary>
    let PropertyStereotype = _prefixId.prefix "PropertyStereotype"
    /// <summary>
    ///   <para>rdfs:comment : A particular type of ontouml:RectangularShape, mainly used to represent entities of type ontouml:Class.</para>
    ///   <para>rdfs:label : Rectangle</para>
    ///   <a href="https://w3id.org/ontouml#Rectangle">ontouml:Rectangle</a>
    /// </summary>
    let Rectangle = _prefixId.prefix "Rectangle"
    /// <summary>
    ///   <para>rdfs:comment : Represents a rectangular shape in a given ontouml:Diagram.</para>
    ///   <para>rdfs:label : RectangularShape</para>
    ///   <a href="https://w3id.org/ontouml#RectangularShape">ontouml:RectangularShape</a>
    /// </summary>
    let RectangularShape = _prefixId.prefix "RectangularShape"
    /// <summary>
    ///   <para>rdfs:comment : An ontouml:Relation may have at most one ontouml:Stereotype (i.e., it is an optional property) of specific type ontouml:RelationStereotype. This information is formalized by the ontouml:stereotype property.rdfs:comment : Represents a relation defined in the ontology.</para>
    ///   <para>rdfs:label : Relation</para>
    ///   <a href="https://w3id.org/ontouml#Relation">ontouml:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:comment : This class is an enumeration of its individuals, which are: ontouml:bringsAbout, ontouml:characterization, ontouml:comparative, ontouml:componentOf, ontouml:creation, ontouml:derivation, ontouml:externalDependence, ontouml:historicalDependence, ontouml:instantiation, ontouml:manifestation, ontouml:material, ontouml:mediation, ontouml:memberOf, ontouml:participation, ontouml:participational, ontouml:subCollectionOf, ontouml:subQuantityOf, ontouml:termination, and ontouml:triggers.rdfs:comment : Aggregates all possible instances that can be assigned via an ontouml:stereotype property to an ontouml:Relation.</para>
    ///   <para>rdfs:label : RelationStereotype</para>
    ///   <a href="https://w3id.org/ontouml#RelationStereotype">ontouml:RelationStereotype</a>
    /// </summary>
    let RelationStereotype = _prefixId.prefix "RelationStereotype"
    /// <summary>
    ///   <para>rdfs:comment : Represents the diagramation (i.e., the visual representation) of an ontouml:Relation in a given ontouml:Diagram.</para>
    ///   <para>rdfs:label : RelationView</para>
    ///   <a href="https://w3id.org/ontouml#RelationView">ontouml:RelationView</a>
    /// </summary>
    let RelationView = _prefixId.prefix "RelationView"
    /// <summary>
    ///   <para>rdfs:comment : Contains information about the diagramation of an ontouml:ModelElement through its relation with an ontouml:ElementView.</para>
    ///   <para>rdfs:label : Shape</para>
    ///   <a href="https://w3id.org/ontouml#Shape">ontouml:Shape</a>
    /// </summary>
    let Shape = _prefixId.prefix "Shape"
    /// <summary>
    ///   <para>rdfs:comment : Indicates meta-properties of classes, properties, or relations.</para>
    ///   <para>rdfs:label : Stereotype</para>
    ///   <a href="https://w3id.org/ontouml#Stereotype">ontouml:Stereotype</a>
    /// </summary>
    let Stereotype = _prefixId.prefix "Stereotype"
    /// <summary>
    ///   <para>rdfs:comment : An ontouml:RectangularShape used to represent some textual information in an ontouml:Diagram.</para>
    ///   <para>rdfs:label : Text</para>
    ///   <a href="https://w3id.org/ontouml#Text">ontouml:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    let abstract_ = _prefixId.prefix "abstract"
    let abstractNature = _prefixId.prefix "abstractNature"
    /// <summary>
    ///   <para>rdfs:comment : Characterizes an ontouml:Property with an ontouml:AggregationKind instance, i.e., indicates whether the ontouml:Property is a simple (ontouml:none), a shared (ontouml:shared), or a composite (ontouml:composite) property.</para>
    ///   <para>rdfs:label : aggregationKind</para>
    ///   <a href="https://w3id.org/ontouml#aggregationKind">ontouml:aggregationKind</a>
    /// </summary>
    let aggregationKind = _prefixId.prefix "aggregationKind"
    /// <summary>
    ///   <para>rdfs:comment : Relates an instance of an ontouml:Class to its properties, which are instances of the ontouml:Property class.</para>
    ///   <para>rdfs:label : attribute</para>
    ///   <a href="https://w3id.org/ontouml#attribute">ontouml:attribute</a>
    /// </summary>
    let attribute = _prefixId.prefix "attribute"
    let begin_ = _prefixId.prefix "begin"
    let bringsAbout = _prefixId.prefix "bringsAbout"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the individual of type ontouml:Cardinality that represents the cardinalities of an ontouml:Property.</para>
    ///   <para>rdfs:label : cardinality</para>
    ///   <a href="https://w3id.org/ontouml#cardinality">ontouml:cardinality</a>
    /// </summary>
    let cardinality = _prefixId.prefix "cardinality"
    /// <summary>
    ///   <para>rdfs:comment : Provides the complete (i.e., both lower and upper cardinality's bounds) cardinalities of an ontouml:Property via its related ontouml:Cardinality.</para>
    ///   <para>rdfs:label : cardinalityValue</para>
    ///   <a href="https://w3id.org/ontouml#cardinalityValue">ontouml:cardinalityValue</a>
    /// </summary>
    let cardinalityValue = _prefixId.prefix "cardinalityValue"
    /// <summary>
    ///   <para>rdfs:comment :  Identifies the ontouml:Class that is instantiated by the specific classes of the ontouml:Generalization type composing the ontouml:GeneralizationSet</para>
    ///   <para>rdfs:label : categorizer</para>
    ///   <a href="https://w3id.org/ontouml#categorizer">ontouml:categorizer</a>
    /// </summary>
    let categorizer = _prefixId.prefix "categorizer"
    let category = _prefixId.prefix "category"
    let characterization = _prefixId.prefix "characterization"
    let collective = _prefixId.prefix "collective"
    let collectiveNature = _prefixId.prefix "collectiveNature"
    let comparative = _prefixId.prefix "comparative"
    let componentOf = _prefixId.prefix "componentOf"
    let composite = _prefixId.prefix "composite"
    /// <summary>
    ///   <para>rdfs:comment : It is mapped to the OntoUML Metamodel's 'contents' relation between the Package and ModelElement classes.rdfs:comment : Identifies an instance of type ontouml:ModelElement that composes in an ontouml:Package.</para>
    ///   <para>rdfs:label : containsModelElement</para>
    ///   <a href="https://w3id.org/ontouml#containsModelElement">ontouml:containsModelElement</a>
    /// </summary>
    let containsModelElement = _prefixId.prefix "containsModelElement"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an instance of type ontouml:ElementView that is contained in an ontouml:Diagram, representing the concrete diagramation of an ontouml:ModelElement.</para>
    ///   <para>rdfs:label : containsView</para>
    ///   <a href="https://w3id.org/ontouml#containsView">ontouml:containsView</a>
    /// </summary>
    let containsView = _prefixId.prefix "containsView"
    let creation = _prefixId.prefix "creation"
    let datatype = _prefixId.prefix "datatype"
    let derivation = _prefixId.prefix "derivation"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:OntoumlElement to a string representing its description in free textual format.</para>
    ///   <para>rdfs:label : description</para>
    ///   <a href="https://w3id.org/ontouml#description">ontouml:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : It is mapped to the OntoUML Metamodel's 'diagrams' relation between the Project and Diagram classes.rdfs:comment : Identifies which entities of type ontouml:Diagram are part of an ontouml:Project.</para>
    ///   <para>rdfs:label : diagram</para>
    ///   <a href="https://w3id.org/ontouml#diagram">ontouml:diagram</a>
    /// </summary>
    let diagram = _prefixId.prefix "diagram"
    let end_ = _prefixId.prefix "end"
    let enumeration = _prefixId.prefix "enumeration"
    let event_ = _prefixId.prefix "event"
    let eventNature = _prefixId.prefix "eventNature"
    let externalDependence = _prefixId.prefix "externalDependence"
    let extrinsicModeNature = _prefixId.prefix "extrinsicModeNature"
    let functionalComplexNature = _prefixId.prefix "functionalComplexNature"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the parent ontouml:Classifier (e.g., a superclass) that participates in an ontouml:Generalization relation.</para>
    ///   <para>rdfs:label : general</para>
    ///   <a href="https://w3id.org/ontouml#general">ontouml:general</a>
    /// </summary>
    let general = _prefixId.prefix "general"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an ontouml:Generalization that participates in an ontouml:GeneralizationSet.</para>
    ///   <para>rdfs:label : generalization</para>
    ///   <a href="https://w3id.org/ontouml#generalization">ontouml:generalization</a>
    /// </summary>
    let generalization = _prefixId.prefix "generalization"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the height of an ontouml:RectangularShape that is represented in an ontouml:Diagram.</para>
    ///   <para>rdfs:label : height</para>
    ///   <a href="https://w3id.org/ontouml#height">ontouml:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    let historicalDependence = _prefixId.prefix "historicalDependence"
    let historicalRole = _prefixId.prefix "historicalRole"
    let historicalRoleMixin = _prefixId.prefix "historicalRoleMixin"
    let instantiation = _prefixId.prefix "instantiation"
    let intrinsicModeNature = _prefixId.prefix "intrinsicModeNature"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if the ontouml:Classifier can have direct instances. If set to true, the classifier must be specialized before being instantiated. Otherwise, it can have direct instances.</para>
    ///   <para>rdfs:label : isAbstract</para>
    ///   <a href="https://w3id.org/ontouml#isAbstract">ontouml:isAbstract</a>
    /// </summary>
    let isAbstract = _prefixId.prefix "isAbstract"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if an ontouml:GeneralizationSet is complete, i.e., if it does not admit further generalizations.</para>
    ///   <para>rdfs:label : isComplete</para>
    ///   <a href="https://w3id.org/ontouml#isComplete">ontouml:isComplete</a>
    /// </summary>
    let isComplete = _prefixId.prefix "isComplete"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if an ontouml:DecoratableElement can be defined through a derivation rule.</para>
    ///   <para>rdfs:label : isDerived</para>
    ///   <a href="https://w3id.org/ontouml#isDerived">ontouml:isDerived</a>
    /// </summary>
    let isDerived = _prefixId.prefix "isDerived"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if an ontouml:GeneralizationSet is disjoint, i.e., it does not admit generalizations having overlapping subclasses.</para>
    ///   <para>rdfs:label : isDisjoint</para>
    ///   <a href="https://w3id.org/ontouml#isDisjoint">ontouml:isDisjoint</a>
    /// </summary>
    let isDisjoint = _prefixId.prefix "isDisjoint"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if an ontouml:Class is extensionally defined (i.e., it's parts cannot change).</para>
    ///   <para>rdfs:label : isExtensional</para>
    ///   <a href="https://w3id.org/ontouml#isExtensional">ontouml:isExtensional</a>
    /// </summary>
    let isExtensional = _prefixId.prefix "isExtensional"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if an ontouml:Property is ordered or not, i.e., if it requires an exact order of its values or not.</para>
    ///   <para>rdfs:label : isOrdered</para>
    ///   <a href="https://w3id.org/ontouml#isOrdered">ontouml:isOrdered</a>
    /// </summary>
    let isOrdered = _prefixId.prefix "isOrdered"
    /// <summary>
    ///   <para>rdfs:comment : The ontouml:Class data property ontouml:isPowertype must not be true when it has an ontouml:order equal to one.rdfs:comment : Indicates if an ontouml:Class is a powertype in multi-level modeling.</para>
    ///   <para>rdfs:label : isPowertype</para>
    ///   <a href="https://w3id.org/ontouml#isPowertype">ontouml:isPowertype</a>
    /// </summary>
    let isPowertype = _prefixId.prefix "isPowertype"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if an ontouml:Property can or cannot be updated or modified.</para>
    ///   <para>rdfs:label : isReadOnly</para>
    ///   <a href="https://w3id.org/ontouml#isReadOnly">ontouml:isReadOnly</a>
    /// </summary>
    let isReadOnly = _prefixId.prefix "isReadOnly"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:ElementView to ontouml:ModelElement, indicating the diagrammatical representation of the latter in an ontouml:Diagram.</para>
    ///   <para>rdfs:label : isViewOf</para>
    ///   <a href="https://w3id.org/ontouml#isViewOf">ontouml:isViewOf</a>
    /// </summary>
    let isViewOf = _prefixId.prefix "isViewOf"
    let kind = _prefixId.prefix "kind"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:Literal to its container enumeration class (an ontouml:Class that has the ontouml:stereotype property with ontouml:enumeration).</para>
    ///   <para>rdfs:label : literal</para>
    ///   <a href="https://w3id.org/ontouml#literal">ontouml:literal</a>
    /// </summary>
    let literal = _prefixId.prefix "literal"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the lower bound of an ontouml:Cardinality.rdfs:comment : E.g., if the ontouml:cardinalityValue set is [1..*] then the lower bound is '1'.rdfs:comment : An ontouml:Cardinality's lower bound must correspond to the one indicated by its ontouml:cardinalityValue property.^^xsd:string</para>
    ///   <para>rdfs:label : lowerBound</para>
    ///   <a href="https://w3id.org/ontouml#lowerBound">ontouml:lowerBound</a>
    /// </summary>
    let lowerBound = _prefixId.prefix "lowerBound"
    let manifestation = _prefixId.prefix "manifestation"
    let material = _prefixId.prefix "material"
    let mediation = _prefixId.prefix "mediation"
    let memberOf = _prefixId.prefix "memberOf"
    let mixin_ = _prefixId.prefix "mixin"
    let mode = _prefixId.prefix "mode"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:Project to an ontouml:Package that is part of it.</para>
    ///   <para>rdfs:label : model</para>
    ///   <a href="https://w3id.org/ontouml#model">ontouml:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    /// <summary>
    ///   <para>rdfs:comment : A string that identifies or names an ontouml:OntoumlElement.</para>
    ///   <para>rdfs:label : name</para>
    ///   <a href="https://w3id.org/ontouml#name">ontouml:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let none = _prefixId.prefix "none"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the order of an ontouml:Class, enabling multi-level modeling.rdfs:comment : Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype ontouml:type must have an ontouml:order value grater than 1.rdfs:comment : Constraint: an ontouml:Class that has an ontouml:stereotype property with an ontouml:Stereotype different than ontouml:type must have an ontouml:order value equal to 1.</para>
    ///   <para>rdfs:label : order</para>
    ///   <a href="https://w3id.org/ontouml#order">ontouml:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:Diagram to an ontouml:ModelElement that is represented on it, i.e., to an ontouml:ModelElement that has an ontouml:ElementView on that ontouml:Diagram.</para>
    ///   <para>rdfs:label : owner</para>
    ///   <a href="https://w3id.org/ontouml#owner">ontouml:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    let participation = _prefixId.prefix "participation"
    let participational = _prefixId.prefix "participational"
    let phase = _prefixId.prefix "phase"
    let phaseMixin = _prefixId.prefix "phaseMixin"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:Path to an ontouml:Point that composes it.</para>
    ///   <para>rdfs:label : point</para>
    ///   <a href="https://w3id.org/ontouml#point">ontouml:point</a>
    /// </summary>
    let point = _prefixId.prefix "point"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:OntoumlElement different than ontouml:Project to an ontouml:Project that it composes.</para>
    ///   <para>rdfs:label : project</para>
    ///   <a href="https://w3id.org/ontouml#project">ontouml:project</a>
    /// </summary>
    let project = _prefixId.prefix "project"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an ontouml:Property exhibited by an ontouml:Classifier. If the ontouml:Classifier is of type ontouml:Class, the ontouml:property is specialized in ontouml:attribute. If the ontouml:Classifier is an ontouml:Relation, the property is specialized in ontouml:relationEnd.rdfs:comment : Aggregates its subproperties ontouml:attribute and ontouml:relationEnd. Should not be directly used.</para>
    ///   <para>rdfs:label : property</para>
    ///   <a href="https://w3id.org/ontouml#property">ontouml:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an ontouml:Class or ontouml:Relation (i.e., an ontouml:Classifier) to which an ontouml:Property refers.</para>
    ///   <para>rdfs:label : propertyType</para>
    ///   <a href="https://w3id.org/ontouml#propertyType">ontouml:propertyType</a>
    /// </summary>
    let propertyType = _prefixId.prefix "propertyType"
    let quality = _prefixId.prefix "quality"
    let qualityNature = _prefixId.prefix "qualityNature"
    let quantity = _prefixId.prefix "quantity"
    let quantityNature = _prefixId.prefix "quantityNature"
    /// <summary>
    ///   <para>rdfs:comment : Identifies a target ontouml:Property that is redefined by a source ontouml:Property.</para>
    ///   <para>rdfs:label : redefinesProperty</para>
    ///   <a href="https://w3id.org/ontouml#redefinesProperty">ontouml:redefinesProperty</a>
    /// </summary>
    let redefinesProperty = _prefixId.prefix "redefinesProperty"
    /// <summary>
    ///   <para>rdfs:comment : Identifies a property that represents one end (source or target) of an ontouml:Relation.</para>
    ///   <para>rdfs:label : relationEnd</para>
    ///   <a href="https://w3id.org/ontouml#relationEnd">ontouml:relationEnd</a>
    /// </summary>
    let relationEnd = _prefixId.prefix "relationEnd"
    let relator = _prefixId.prefix "relator"
    let relatorNature = _prefixId.prefix "relatorNature"
    /// <summary>
    ///   <para>rdfs:comment : Associates an ontouml:Class to an ontouml:OntologicalNature, restricting its allowed values.</para>
    ///   <para>rdfs:label : restrictedTo</para>
    ///   <a href="https://w3id.org/ontouml#restrictedTo">ontouml:restrictedTo</a>
    /// </summary>
    let restrictedTo = _prefixId.prefix "restrictedTo"
    let role = _prefixId.prefix "role"
    let roleMixin = _prefixId.prefix "roleMixin"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:ElementView to an ontouml:Shape that contains the diagramation's data (size and position) about the ontouml:ModelElement it is a view of.</para>
    ///   <para>rdfs:label : shape</para>
    ///   <a href="https://w3id.org/ontouml#shape">ontouml:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    let shared = _prefixId.prefix "shared"
    let situation = _prefixId.prefix "situation"
    let situationNature = _prefixId.prefix "situationNature"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an ontouml:Property that represents the source side of an ontouml:Relation.</para>
    ///   <para>rdfs:label : sourceEnd</para>
    ///   <a href="https://w3id.org/ontouml#sourceEnd">ontouml:sourceEnd</a>
    /// </summary>
    let sourceEnd = _prefixId.prefix "sourceEnd"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an ontouml:ElementView that participates as source of an ontouml:RelationView or ontouml:GeneralizationView.</para>
    ///   <para>rdfs:label : sourceView</para>
    ///   <a href="https://w3id.org/ontouml#sourceView">ontouml:sourceView</a>
    /// </summary>
    let sourceView = _prefixId.prefix "sourceView"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the child ontouml:Classifier (e.g., a subclass) that participates in an ontouml:Generalization relation.</para>
    ///   <para>rdfs:label : specific</para>
    ///   <a href="https://w3id.org/ontouml#specific">ontouml:specific</a>
    /// </summary>
    let specific = _prefixId.prefix "specific"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the ontouml:Stereotype applied to the ontouml:DecoratableElement.</para>
    ///   <para>rdfs:label : stereotype</para>
    ///   <a href="https://w3id.org/ontouml#stereotype">ontouml:stereotype</a>
    /// </summary>
    let stereotype = _prefixId.prefix "stereotype"
    let subCollectionOf = _prefixId.prefix "subCollectionOf"
    let subQuantityOf = _prefixId.prefix "subQuantityOf"
    let subkind = _prefixId.prefix "subkind"
    /// <summary>
    ///   <para>rdfs:comment : Identifies a target ontouml:Property that is subsetted by a source ontouml:Property.</para>
    ///   <para>rdfs:label : subsetsProperty</para>
    ///   <a href="https://w3id.org/ontouml#subsetsProperty">ontouml:subsetsProperty</a>
    /// </summary>
    let subsetsProperty = _prefixId.prefix "subsetsProperty"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an ontouml:Property that represents the target side of an ontouml:Relation.</para>
    ///   <para>rdfs:label : targetEnd</para>
    ///   <a href="https://w3id.org/ontouml#targetEnd">ontouml:targetEnd</a>
    /// </summary>
    let targetEnd = _prefixId.prefix "targetEnd"
    /// <summary>
    ///   <para>rdfs:comment : Identifies an ontouml:ElementView that participates as target of an ontouml:ConnectorView.</para>
    ///   <para>rdfs:label : targetView</para>
    ///   <a href="https://w3id.org/ontouml#targetView">ontouml:targetView</a>
    /// </summary>
    let targetView = _prefixId.prefix "targetView"
    let termination = _prefixId.prefix "termination"
    /// <summary>
    ///   <para>rdfs:comment : A string that register any information of an ontouml:Note</para>
    ///   <para>rdfs:label : text</para>
    ///   <a href="https://w3id.org/ontouml#text">ontouml:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:comment : Is direct mapped to the OntoUML Metamodel's 'topLeft' relationship between the classes RectangularShape and Point.rdfs:comment : Relates an ontouml:RectangularShape to an ontouml:Point that contains the horizontal and vertical coordinates (ontouml:xCoordinate and ontouml:yCoordinate, respectively) representing the former's top left position in an ontouml:Diagram.</para>
    ///   <para>rdfs:label : topLeftPosition</para>
    ///   <a href="https://w3id.org/ontouml#topLeftPosition">ontouml:topLeftPosition</a>
    /// </summary>
    let topLeftPosition = _prefixId.prefix "topLeftPosition"
    let triggers = _prefixId.prefix "triggers"
    let type_ = _prefixId.prefix "type"
    let typeNature = _prefixId.prefix "typeNature"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the upper bound of an ontouml:Cardinality.rdfs:comment : E.g., if the ontouml:cardinalityValue set is [1..*] then the upper bound is '*'.rdfs:comment : An ontouml:Cardinality's upper bound must correspond to the one indicated by its ontouml:cardinalityValue property.^^xsd:string</para>
    ///   <para>rdfs:label : upperBound</para>
    ///   <a href="https://w3id.org/ontouml#upperBound">ontouml:upperBound</a>
    /// </summary>
    let upperBound = _prefixId.prefix "upperBound"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the width of an ontouml:RectangularShape that is represented in an ontouml:Diagram.</para>
    ///   <para>rdfs:label : width</para>
    ///   <a href="https://w3id.org/ontouml#width">ontouml:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:Point to the value indicating the specific x (horizontal) coordinate of the top left position of an ontouml:RectangularShape.rdfs:comment : Is direct mapped to the metamodel's 'x' attribute of the Point class.</para>
    ///   <para>rdfs:label : xCoordinate</para>
    ///   <a href="https://w3id.org/ontouml#xCoordinate">ontouml:xCoordinate</a>
    /// </summary>
    let xCoordinate = _prefixId.prefix "xCoordinate"
    /// <summary>
    ///   <para>rdfs:comment : Relates an ontouml:Point to the value indicating the specific y (vertical) coordinate of the top left position of an ontouml:RectangularShape.rdfs:comment : Is direct mapped to the metamodel's 'y' attribute of the Point class.</para>
    ///   <para>rdfs:label : yCoordinate</para>
    ///   <a href="https://w3id.org/ontouml#yCoordinate">ontouml:yCoordinate</a>
    /// </summary>
    let yCoordinate = _prefixId.prefix "yCoordinate"
