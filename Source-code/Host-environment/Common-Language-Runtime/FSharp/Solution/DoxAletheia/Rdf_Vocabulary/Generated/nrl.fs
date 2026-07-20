namespace http.www.semanticdesktop.org.ontologies._2007._08._15.nrl.hash

open DoxAletheia

module nrl =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A marker class to identify asymmetric properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#AsymmetricProperty"></see></summary>
    let AsymmetricProperty = _prefix "AsymmetricProperty"
    /// <summary>
    /// Represents a named graph containing configuration data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Configuration"></see></summary>
    let Configuration = _prefix "Configuration"
    /// <summary>
    /// An abstract class representing all named graph roles
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Data"></see></summary>
    let Data = _prefix "Data"
    /// <summary>
    /// Represents a named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Graph"></see></summary>
    let Graph = _prefix "Graph"
    /// <summary>
    /// Represents the default graph, the graph which contains any triple that does not belong to any other named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefaultGraph"></see></summary>
    let DefaultGraph = _prefix "DefaultGraph"
    /// <summary>
    /// A defining property's value is part of what defines a resource, changing it means
    ///                           means chaning the identity of the resource. The set of values of all defining
    ///                           properties of a resource make up its identify.
    ///                           Whenever comparing resources or sharing them the value of this property should
    ///                           be taken into account. By default all properties with a literal range are to be
    ///                           treated as defining properties unless they are marked as nrl:NonDefiningProperty.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefiningProperty"></see></summary>
    let DefiningProperty = _prefix "DefiningProperty"
    /// <summary>
    /// A named graph containing instance data that can be recreated by analyzing the original resources. Intended to be used by metadata extractors.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DiscardableInstanceBase"></see></summary>
    let DiscardableInstanceBase = _prefix "DiscardableInstanceBase"
    /// <summary>
    /// Represents a named graph containing instance data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InstanceBase"></see></summary>
    let InstanceBase = _prefix "InstanceBase"
    /// <summary>
    /// A marker class to identify named graphs that exist within a physical document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DocumentGraph"></see></summary>
    let DocumentGraph = _prefix "DocumentGraph"
    /// <summary>
    /// Represents an external view specification, this usually being a program which automatically generates the required view for an input graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ExternalViewSpecification"></see></summary>
    let ExternalViewSpecification = _prefix "ExternalViewSpecification"
    /// <summary>
    /// Represents a specification of the means to achieve a transformation of an input graph into the required graph view
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ViewSpecification"></see></summary>
    let ViewSpecification = _prefix "ViewSpecification"
    /// <summary>
    /// A marker class to identify functional properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#FunctionalProperty"></see></summary>
    let FunctionalProperty = _prefix "FunctionalProperty"
    /// <summary>
    /// Represents a special named graph that contains metadata for another graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphMetadata"></see></summary>
    let GraphMetadata = _prefix "GraphMetadata"
    /// <summary>
    /// Identifies a graph which is itself a view of another named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphView"></see></summary>
    let GraphView = _prefix "GraphView"
    /// <summary>
    /// A marker class to identify inverse functional properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty = _prefix "InverseFunctionalProperty"
    /// <summary>
    /// Represents a named graph containing both schematic and instance data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#KnowledgeBase"></see></summary>
    let KnowledgeBase = _prefix "KnowledgeBase"
    /// <summary>
    /// Represents a named graph having the role of an Ontology
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// A non-defining property's value is not part of what defines a resource, it rather
    ///                           is part of the resource's state or expresses an opinion about the resource. Whenever
    ///                           comparing resources or sharing them the value of this property should not be taken into
    ///                           account. By default all properties with a resource range are to be treated as
    ///                           non-defining properties unless they are marked as nrl:DefiningProperty.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#NonDefiningProperty"></see></summary>
    let NonDefiningProperty = _prefix "NonDefiningProperty"
    /// <summary>
    /// Represents a named graph containing schematic data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Schema"></see></summary>
    let Schema = _prefix "Schema"
    /// <summary>
    /// A marker class to identify reflexive properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ReflexiveProperty"></see></summary>
    let ReflexiveProperty = _prefix "ReflexiveProperty"
    /// <summary>
    /// Represents a view specification that is composed of a set of rules which generate the required view from the input graph upon firing
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#RuleViewSpecification"></see></summary>
    let RuleViewSpecification = _prefix "RuleViewSpecification"
    /// <summary>
    /// Represents some declarative semantics
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Semantics"></see></summary>
    let Semantics = _prefix "Semantics"
    /// <summary>
    /// A marker class to identify symmetric properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#SymmetricProperty"></see></summary>
    let SymmetricProperty = _prefix "SymmetricProperty"
    /// <summary>
    /// A marker class to identify transitive properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#TransitiveProperty"></see></summary>
    let TransitiveProperty = _prefix "TransitiveProperty"
    /// <summary>
    /// Specifies the precise value cardinality for a specific property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#cardinality"></see></summary>
    let cardinality = _prefix "cardinality"
    /// <summary>
    /// Links a metadata graph to the graph for which it specifies the core graph properties including the semantics and the graph namespace. A graph can have only one unique core metadata graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#coreGraphMetadataFor"></see></summary>
    let coreGraphMetadataFor = _prefix "coreGraphMetadataFor"
    /// <summary>
    /// Links a metadata graph to the graph that is being described. A unique value is compulsory
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#graphMetadataFor"></see></summary>
    let graphMetadataFor = _prefix "graphMetadataFor"
    /// <summary>
    /// Links two equivalent named graphs. A symmetric property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#equivalentGraph"></see></summary>
    let equivalentGraph = _prefix "equivalentGraph"
    /// <summary>
    /// Points to the location of the realizer for the external view specification
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#externalRealizer"></see></summary>
    let externalRealizer = _prefix "externalRealizer"
    /// <summary>
    /// Specifies a minimum value cardinality for a specific property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#minCardinality"></see></summary>
    let minCardinality = _prefix "minCardinality"
    /// <summary>
    /// Points to a representation of the declarative semantics for a graph role
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSemantics"></see></summary>
    let hasSemantics = _prefix "hasSemantics"
    /// <summary>
    /// Points to the representation of the view specification required to generate the graph view in question
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSpecification"></see></summary>
    let hasSpecification = _prefix "hasSpecification"
    /// <summary>
    /// Models a subsumption relationship between two graphs, stating that the object graph is imported and included in the subject graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#imports"></see></summary>
    let imports = _prefix "imports"
    /// <summary>
    /// Specifies a subsumption relationship between two graphs, meaning that the object graph is included in the subject graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#superGraphOf"></see></summary>
    let superGraphOf = _prefix "superGraphOf"
    /// <summary>
    /// Links two properties and specifies their inverse behaviour
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#inverseProperty"></see></summary>
    let inverseProperty = _prefix "inverseProperty"
    /// <summary>
    /// Specifies a maximum value cardinality for a specific property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#maxCardinality"></see></summary>
    let maxCardinality = _prefix "maxCardinality"
    /// <summary>
    /// Points to a representation of the declarative semantics that the view specification realizes
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#realizes"></see></summary>
    let realizes = _prefix "realizes"
    /// <summary>
    /// Specifies rules for a view specification that is driven by rules
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#rule"></see></summary>
    let rule = _prefix "rule"
    /// <summary>
    /// Specifies the rule language for a view specification that is driven by rules
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ruleLanguage"></see></summary>
    let ruleLanguage = _prefix "ruleLanguage"
    /// <summary>
    /// Points to the human readable specifications for a representation of some declarative semantics
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#semanticsDefinedBy"></see></summary>
    let semanticsDefinedBy = _prefix "semanticsDefinedBy"
    /// <summary>
    /// Specifies a containment relationship between two graphs, meaning that the subject graph is included in the object graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#subGraphOf"></see></summary>
    let subGraphOf = _prefix "subGraphOf"
    /// <summary>
    /// A core graph metadata property, this defines whether a graph can be freely updated '1' or otherwise '0'
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#updatable"></see></summary>
    let updatable = _prefix "updatable"
    /// <summary>
    /// Points to a graph view over the subject named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#viewOn"></see></summary>
    let viewOn = _prefix "viewOn"
