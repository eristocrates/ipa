namespace http.www.semanticdesktop.org.ontologies._2007._08._15.nrl.hash

open DoxAletheia.Rdf_Vocabulary

module nrl =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#"

    /// <summary>
    /// A marker class to identify asymmetric properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#AsymmetricProperty"></see></summary>
    let AsymmetricProperty =
        Namespaced_IRI.parse _namespace_name "AsymmetricProperty" |> NamespacedName

    /// <summary>
    /// Represents a named graph containing configuration data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Configuration"></see></summary>
    let Configuration =
        Namespaced_IRI.parse _namespace_name "Configuration" |> NamespacedName

    /// <summary>
    /// An abstract class representing all named graph roles
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Data"></see></summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    /// Represents a named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Graph"></see></summary>
    let Graph = Namespaced_IRI.parse _namespace_name "Graph" |> NamespacedName

    /// <summary>
    /// Represents the default graph, the graph which contains any triple that does not belong to any other named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefaultGraph"></see></summary>
    let DefaultGraph =
        Namespaced_IRI.parse _namespace_name "DefaultGraph" |> NamespacedName

    /// <summary>
    /// A defining property's value is part of what defines a resource, changing it means
    ///                           means chaning the identity of the resource. The set of values of all defining
    ///                           properties of a resource make up its identify.
    ///                           Whenever comparing resources or sharing them the value of this property should
    ///                           be taken into account. By default all properties with a literal range are to be
    ///                           treated as defining properties unless they are marked as nrl:NonDefiningProperty.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefiningProperty"></see></summary>
    let DefiningProperty =
        Namespaced_IRI.parse _namespace_name "DefiningProperty" |> NamespacedName

    /// <summary>
    /// A named graph containing instance data that can be recreated by analyzing the original resources. Intended to be used by metadata extractors.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DiscardableInstanceBase"></see></summary>
    let DiscardableInstanceBase =
        Namespaced_IRI.parse _namespace_name "DiscardableInstanceBase" |> NamespacedName

    /// <summary>
    /// Represents a named graph containing instance data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InstanceBase"></see></summary>
    let InstanceBase =
        Namespaced_IRI.parse _namespace_name "InstanceBase" |> NamespacedName

    /// <summary>
    /// A marker class to identify named graphs that exist within a physical document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DocumentGraph"></see></summary>
    let DocumentGraph =
        Namespaced_IRI.parse _namespace_name "DocumentGraph" |> NamespacedName

    /// <summary>
    /// Represents an external view specification, this usually being a program which automatically generates the required view for an input graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ExternalViewSpecification"></see></summary>
    let ExternalViewSpecification =
        Namespaced_IRI.parse _namespace_name "ExternalViewSpecification" |> NamespacedName

    /// <summary>
    /// Represents a specification of the means to achieve a transformation of an input graph into the required graph view
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ViewSpecification"></see></summary>
    let ViewSpecification =
        Namespaced_IRI.parse _namespace_name "ViewSpecification" |> NamespacedName

    /// <summary>
    /// A marker class to identify functional properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#FunctionalProperty"></see></summary>
    let FunctionalProperty =
        Namespaced_IRI.parse _namespace_name "FunctionalProperty" |> NamespacedName

    /// <summary>
    /// Represents a special named graph that contains metadata for another graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphMetadata"></see></summary>
    let GraphMetadata =
        Namespaced_IRI.parse _namespace_name "GraphMetadata" |> NamespacedName

    /// <summary>
    /// Identifies a graph which is itself a view of another named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphView"></see></summary>
    let GraphView = Namespaced_IRI.parse _namespace_name "GraphView" |> NamespacedName

    /// <summary>
    /// A marker class to identify inverse functional properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty =
        Namespaced_IRI.parse _namespace_name "InverseFunctionalProperty" |> NamespacedName

    /// <summary>
    /// Represents a named graph containing both schematic and instance data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#KnowledgeBase"></see></summary>
    let KnowledgeBase =
        Namespaced_IRI.parse _namespace_name "KnowledgeBase" |> NamespacedName

    /// <summary>
    /// Represents a named graph having the role of an Ontology
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    /// A non-defining property's value is not part of what defines a resource, it rather
    ///                           is part of the resource's state or expresses an opinion about the resource. Whenever
    ///                           comparing resources or sharing them the value of this property should not be taken into
    ///                           account. By default all properties with a resource range are to be treated as
    ///                           non-defining properties unless they are marked as nrl:DefiningProperty.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#NonDefiningProperty"></see></summary>
    let NonDefiningProperty =
        Namespaced_IRI.parse _namespace_name "NonDefiningProperty" |> NamespacedName

    /// <summary>
    /// Represents a named graph containing schematic data
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Schema"></see></summary>
    let Schema = Namespaced_IRI.parse _namespace_name "Schema" |> NamespacedName

    /// <summary>
    /// A marker class to identify reflexive properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ReflexiveProperty"></see></summary>
    let ReflexiveProperty =
        Namespaced_IRI.parse _namespace_name "ReflexiveProperty" |> NamespacedName

    /// <summary>
    /// Represents a view specification that is composed of a set of rules which generate the required view from the input graph upon firing
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#RuleViewSpecification"></see></summary>
    let RuleViewSpecification =
        Namespaced_IRI.parse _namespace_name "RuleViewSpecification" |> NamespacedName

    /// <summary>
    /// Represents some declarative semantics
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Semantics"></see></summary>
    let Semantics = Namespaced_IRI.parse _namespace_name "Semantics" |> NamespacedName

    /// <summary>
    /// A marker class to identify symmetric properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#SymmetricProperty"></see></summary>
    let SymmetricProperty =
        Namespaced_IRI.parse _namespace_name "SymmetricProperty" |> NamespacedName

    /// <summary>
    /// A marker class to identify transitive properties
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#TransitiveProperty"></see></summary>
    let TransitiveProperty =
        Namespaced_IRI.parse _namespace_name "TransitiveProperty" |> NamespacedName

    /// <summary>
    /// Specifies the precise value cardinality for a specific property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#cardinality"></see></summary>
    let cardinality =
        Namespaced_IRI.parse _namespace_name "cardinality" |> NamespacedName

    /// <summary>
    /// Links a metadata graph to the graph for which it specifies the core graph properties including the semantics and the graph namespace. A graph can have only one unique core metadata graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#coreGraphMetadataFor"></see></summary>
    let coreGraphMetadataFor =
        Namespaced_IRI.parse _namespace_name "coreGraphMetadataFor" |> NamespacedName

    /// <summary>
    /// Links a metadata graph to the graph that is being described. A unique value is compulsory
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#graphMetadataFor"></see></summary>
    let graphMetadataFor =
        Namespaced_IRI.parse _namespace_name "graphMetadataFor" |> NamespacedName

    /// <summary>
    /// Links two equivalent named graphs. A symmetric property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#equivalentGraph"></see></summary>
    let equivalentGraph =
        Namespaced_IRI.parse _namespace_name "equivalentGraph" |> NamespacedName

    /// <summary>
    /// Points to the location of the realizer for the external view specification
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#externalRealizer"></see></summary>
    let externalRealizer =
        Namespaced_IRI.parse _namespace_name "externalRealizer" |> NamespacedName

    /// <summary>
    /// Specifies a minimum value cardinality for a specific property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#minCardinality"></see></summary>
    let minCardinality =
        Namespaced_IRI.parse _namespace_name "minCardinality" |> NamespacedName

    /// <summary>
    /// Points to a representation of the declarative semantics for a graph role
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSemantics"></see></summary>
    let hasSemantics =
        Namespaced_IRI.parse _namespace_name "hasSemantics" |> NamespacedName

    /// <summary>
    /// Points to the representation of the view specification required to generate the graph view in question
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSpecification"></see></summary>
    let hasSpecification =
        Namespaced_IRI.parse _namespace_name "hasSpecification" |> NamespacedName

    /// <summary>
    /// Models a subsumption relationship between two graphs, stating that the object graph is imported and included in the subject graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#imports"></see></summary>
    let imports = Namespaced_IRI.parse _namespace_name "imports" |> NamespacedName

    /// <summary>
    /// Specifies a subsumption relationship between two graphs, meaning that the object graph is included in the subject graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#superGraphOf"></see></summary>
    let superGraphOf =
        Namespaced_IRI.parse _namespace_name "superGraphOf" |> NamespacedName

    /// <summary>
    /// Links two properties and specifies their inverse behaviour
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#inverseProperty"></see></summary>
    let inverseProperty =
        Namespaced_IRI.parse _namespace_name "inverseProperty" |> NamespacedName

    /// <summary>
    /// Specifies a maximum value cardinality for a specific property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#maxCardinality"></see></summary>
    let maxCardinality =
        Namespaced_IRI.parse _namespace_name "maxCardinality" |> NamespacedName

    /// <summary>
    /// Points to a representation of the declarative semantics that the view specification realizes
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#realizes"></see></summary>
    let realizes = Namespaced_IRI.parse _namespace_name "realizes" |> NamespacedName
    /// <summary>
    /// Specifies rules for a view specification that is driven by rules
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#rule"></see></summary>
    let rule = Namespaced_IRI.parse _namespace_name "rule" |> NamespacedName

    /// <summary>
    /// Specifies the rule language for a view specification that is driven by rules
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ruleLanguage"></see></summary>
    let ruleLanguage =
        Namespaced_IRI.parse _namespace_name "ruleLanguage" |> NamespacedName

    /// <summary>
    /// Points to the human readable specifications for a representation of some declarative semantics
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#semanticsDefinedBy"></see></summary>
    let semanticsDefinedBy =
        Namespaced_IRI.parse _namespace_name "semanticsDefinedBy" |> NamespacedName

    /// <summary>
    /// Specifies a containment relationship between two graphs, meaning that the subject graph is included in the object graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#subGraphOf"></see></summary>
    let subGraphOf = Namespaced_IRI.parse _namespace_name "subGraphOf" |> NamespacedName
    /// <summary>
    /// A core graph metadata property, this defines whether a graph can be freely updated '1' or otherwise '0'
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#updatable"></see></summary>
    let updatable = Namespaced_IRI.parse _namespace_name "updatable" |> NamespacedName
    /// <summary>
    /// Points to a graph view over the subject named graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#viewOn"></see></summary>
    let viewOn = Namespaced_IRI.parse _namespace_name "viewOn" |> NamespacedName
