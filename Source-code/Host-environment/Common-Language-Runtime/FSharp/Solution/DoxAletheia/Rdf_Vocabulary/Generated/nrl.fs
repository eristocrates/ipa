namespace http.www.semanticdesktop.org.ontologies._2007._08._15.nrl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nrl =
    let _namespace_iri = Namespace_Iri nrl |> NamespaceIRI
    /// <summary>
    ///   <para>nrl:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An abstract class representing all named graph roles</para>
    /// labels<para>Data</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Data">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Data</seealso>
    let Data = Prefixed_Name(nrl, "Data") |> PrefixedName
    /// <summary>
    ///   <para>nrl:DefaultGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:Graph</para>
    ///   <para>Represents the default graph, the graph which contains any triple that does not belong to any other named graph</para>
    /// labels<para>DefaultGraph</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefaultGraph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefaultGraph</seealso>
    let DefaultGraph = Prefixed_Name(nrl, "DefaultGraph") |> PrefixedName

    /// <summary>
    ///   <para>nrl:coreGraphMetadataFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links a metadata graph to the graph for which it specifies the core graph properties including the semantics and the graph namespace. A graph can have only one unique core metadata graph</para>
    /// labels<para>coreGraphMetadataFor</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#coreGraphMetadataFor">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#coreGraphMetadataFor</seealso>
    let coreGraphMetadataFor =
        Prefixed_Name(nrl, "coreGraphMetadataFor") |> PrefixedName

    /// <summary>
    ///   <para>nrl:graphMetadataFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a metadata graph to the graph that is being described. A unique value is compulsory</para>
    /// labels<para>graphMetadataFor</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#graphMetadataFor">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#graphMetadataFor</seealso>
    let graphMetadataFor = Prefixed_Name(nrl, "graphMetadataFor") |> PrefixedName
    /// <summary>
    ///   <para>nrl:minCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a minimum value cardinality for a specific property</para>
    /// labels<para>minCardinality</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#minCardinality">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#minCardinality</seealso>
    let minCardinality = Prefixed_Name(nrl, "minCardinality") |> PrefixedName
    /// <summary>
    ///   <para>nrl:hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points to the representation of the view specification required to generate the graph view in question</para>
    /// labels<para>hasSpecification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSpecification</seealso>
    let hasSpecification = Prefixed_Name(nrl, "hasSpecification") |> PrefixedName
    /// <summary>
    ///   <para>nrl:DefiningProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A defining property's value is part of what defines a resource, changing it means
    ///                           means chaning the identity of the resource. The set of values of all defining
    ///                           properties of a resource make up its identify.
    ///                           Whenever comparing resources or sharing them the value of this property should
    ///                           be taken into account. By default all properties with a literal range are to be
    ///                           treated as defining properties unless they are marked as nrl:NonDefiningProperty.</para>
    /// labels<para>defining property</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefiningProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefiningProperty</seealso>
    let DefiningProperty = Prefixed_Name(nrl, "DefiningProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:ViewSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a specification of the means to achieve a transformation of an input graph into the required graph view</para>
    /// labels<para>ViewSpecification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ViewSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ViewSpecification</seealso>
    let ViewSpecification = Prefixed_Name(nrl, "ViewSpecification") |> PrefixedName
    /// <summary>
    ///   <para>nrl:DocumentGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify named graphs that exist within a physical document</para>
    /// labels<para>DocumentGraph</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DocumentGraph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DocumentGraph</seealso>
    let DocumentGraph = Prefixed_Name(nrl, "DocumentGraph") |> PrefixedName
    /// <summary>
    ///   <para>nrl:InstanceBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a named graph containing instance data</para>
    /// labels<para>InstanceBase</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InstanceBase">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InstanceBase</seealso>
    let InstanceBase = Prefixed_Name(nrl, "InstanceBase") |> PrefixedName

    /// <summary>
    ///   <para>nrl:DiscardableInstanceBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A named graph containing instance data that can be recreated by analyzing the original resources. Intended to be used by metadata extractors.</para>
    /// labels<para>DiscardableInstanceBase</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DiscardableInstanceBase">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DiscardableInstanceBase</seealso>
    let DiscardableInstanceBase =
        Prefixed_Name(nrl, "DiscardableInstanceBase") |> PrefixedName

    /// <summary>
    ///   <para>nrl:GraphMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a special named graph that contains metadata for another graph</para>
    /// labels<para>GraphMetadata</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphMetadata">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphMetadata</seealso>
    let GraphMetadata = Prefixed_Name(nrl, "GraphMetadata") |> PrefixedName
    /// <summary>
    ///   <para>nrl:GraphView</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Identifies a graph which is itself a view of another named graph</para>
    /// labels<para>GraphView</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphView">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphView</seealso>
    let GraphView = Prefixed_Name(nrl, "GraphView") |> PrefixedName

    /// <summary>
    ///   <para>nrl:InverseFunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify inverse functional properties</para>
    /// labels<para>InverseFunctionalProperty</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InverseFunctionalProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InverseFunctionalProperty</seealso>
    let InverseFunctionalProperty =
        Prefixed_Name(nrl, "InverseFunctionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>nrl:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a named graph having the role of an Ontology</para>
    /// labels<para>Ontology</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Ontology">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Ontology</seealso>
    let Ontology = Prefixed_Name(nrl, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>nrl:NonDefiningProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A non-defining property's value is not part of what defines a resource, it rather
    ///                           is part of the resource's state or expresses an opinion about the resource. Whenever
    ///                           comparing resources or sharing them the value of this property should not be taken into
    ///                           account. By default all properties with a resource range are to be treated as
    ///                           non-defining properties unless they are marked as nrl:DefiningProperty.</para>
    /// labels<para>non-defining property</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#NonDefiningProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#NonDefiningProperty</seealso>
    let NonDefiningProperty = Prefixed_Name(nrl, "NonDefiningProperty") |> PrefixedName

    /// <summary>
    ///   <para>nrl:ExternalViewSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents an external view specification, this usually being a program which automatically generates the required view for an input graph</para>
    /// labels<para>ExternalViewSpecification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ExternalViewSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ExternalViewSpecification</seealso>
    let ExternalViewSpecification =
        Prefixed_Name(nrl, "ExternalViewSpecification") |> PrefixedName

    /// <summary>
    ///   <para>nrl:KnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a named graph containing both schematic and instance data</para>
    /// labels<para>KnowledgeBase</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#KnowledgeBase">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#KnowledgeBase</seealso>
    let KnowledgeBase = Prefixed_Name(nrl, "KnowledgeBase") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a named graph containing schematic data</para>
    /// labels<para>Schema</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Schema">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Schema</seealso>
    let Schema = Prefixed_Name(nrl, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>nrl:ReflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify reflexive properties</para>
    /// labels<para>ReflexiveProperty</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ReflexiveProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ReflexiveProperty</seealso>
    let ReflexiveProperty = Prefixed_Name(nrl, "ReflexiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Semantics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents some declarative semantics</para>
    /// labels<para>Semantics</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Semantics">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Semantics</seealso>
    let Semantics = Prefixed_Name(nrl, "Semantics") |> PrefixedName
    /// <summary>
    ///   <para>nrl:SymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify symmetric properties</para>
    /// labels<para>SymmetricProperty</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#SymmetricProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#SymmetricProperty</seealso>
    let SymmetricProperty = Prefixed_Name(nrl, "SymmetricProperty") |> PrefixedName

    /// <summary>
    ///   <para>nrl:RuleViewSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a view specification that is composed of a set of rules which generate the required view from the input graph upon firing</para>
    /// labels<para>RuleViewSpecification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#RuleViewSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#RuleViewSpecification</seealso>
    let RuleViewSpecification =
        Prefixed_Name(nrl, "RuleViewSpecification") |> PrefixedName

    /// <summary>
    ///   <para>nrl:TransitiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify transitive properties</para>
    /// labels<para>TransitiveProperty</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#TransitiveProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#TransitiveProperty</seealso>
    let TransitiveProperty = Prefixed_Name(nrl, "TransitiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the precise value cardinality for a specific property</para>
    /// labels<para>cardinality</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#cardinality">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#cardinality</seealso>
    let cardinality = Prefixed_Name(nrl, "cardinality") |> PrefixedName
    /// <summary>
    ///   <para>nrl:equivalentGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>nrl:SymmetricProperty</para>
    ///   <para>Links two equivalent named graphs. A symmetric property</para>
    /// labels<para>equivalentGraph</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#equivalentGraph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#equivalentGraph</seealso>
    let equivalentGraph = Prefixed_Name(nrl, "equivalentGraph") |> PrefixedName
    /// <summary>
    ///   <para>nrl:externalRealizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points to the location of the realizer for the external view specification</para>
    /// labels<para>externalRealizer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#externalRealizer">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#externalRealizer</seealso>
    let externalRealizer = Prefixed_Name(nrl, "externalRealizer") |> PrefixedName
    /// <summary>
    ///   <para>nrl:hasSemantics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points to a representation of the declarative semantics for a graph role</para>
    /// labels<para>hasSemantics</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSemantics">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSemantics</seealso>
    let hasSemantics = Prefixed_Name(nrl, "hasSemantics") |> PrefixedName
    /// <summary>
    ///   <para>nrl:superGraphOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a subsumption relationship between two graphs, meaning that the object graph is included in the subject graph</para>
    /// labels<para>superGraphOf</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#superGraphOf">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#superGraphOf</seealso>
    let superGraphOf = Prefixed_Name(nrl, "superGraphOf") |> PrefixedName
    /// <summary>
    ///   <para>nrl:imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Models a subsumption relationship between two graphs, stating that the object graph is imported and included in the subject graph</para>
    /// labels<para>imports</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#imports">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#imports</seealso>
    let imports = Prefixed_Name(nrl, "imports") |> PrefixedName
    /// <summary>
    ///   <para>nrl:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points to a representation of the declarative semantics that the view specification realizes</para>
    /// labels<para>realizes</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#realizes">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#realizes</seealso>
    let realizes = Prefixed_Name(nrl, "realizes") |> PrefixedName
    /// <summary>
    ///   <para>nrl:rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies rules for a view specification that is driven by rules</para>
    /// labels<para>rule</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#rule">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#rule</seealso>
    let rule = Prefixed_Name(nrl, "rule") |> PrefixedName
    /// <summary>
    ///   <para>nrl:semanticsDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points to the human readable specifications for a representation of some declarative semantics</para>
    /// labels<para>semanticsDefinedBy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#semanticsDefinedBy">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#semanticsDefinedBy</seealso>
    let semanticsDefinedBy = Prefixed_Name(nrl, "semanticsDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>nrl:subGraphOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a containment relationship between two graphs, meaning that the subject graph is included in the object graph</para>
    /// labels<para>subGraphOf</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#subGraphOf">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#subGraphOf</seealso>
    let subGraphOf = Prefixed_Name(nrl, "subGraphOf") |> PrefixedName
    /// <summary>
    ///   <para>nrl:updatable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A core graph metadata property, this defines whether a graph can be freely updated '1' or otherwise '0'</para>
    /// labels<para>updatable</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#updatable">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#updatable</seealso>
    let updatable = Prefixed_Name(nrl, "updatable") |> PrefixedName
    /// <summary>
    ///   <para>nrl:viewOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points to a graph view over the subject named graph</para>
    /// labels<para>viewOn</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#viewOn">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#viewOn</seealso>
    let viewOn = Prefixed_Name(nrl, "viewOn") |> PrefixedName
    /// <summary>
    ///   <para>nrl:inverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links two properties and specifies their inverse behaviour</para>
    /// labels<para>inverseProperty</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#inverseProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#inverseProperty</seealso>
    let inverseProperty = Prefixed_Name(nrl, "inverseProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:maxCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a maximum value cardinality for a specific property</para>
    /// labels<para>maxCardinality</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#maxCardinality">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#maxCardinality</seealso>
    let maxCardinality = Prefixed_Name(nrl, "maxCardinality") |> PrefixedName
    /// <summary>
    ///   <para>nrl:ruleLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the rule language for a view specification that is driven by rules</para>
    /// labels<para>ruleLanguage</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ruleLanguage">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ruleLanguage</seealso>
    let ruleLanguage = Prefixed_Name(nrl, "ruleLanguage") |> PrefixedName
    /// <summary>
    ///   <para>nrl:AsymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify asymmetric properties</para>
    /// labels<para>AsymmetricProperty</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#AsymmetricProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#AsymmetricProperty</seealso>
    let AsymmetricProperty = Prefixed_Name(nrl, "AsymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a named graph containing configuration data</para>
    /// labels<para>Configuration</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Configuration">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Configuration</seealso>
    let Configuration = Prefixed_Name(nrl, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a named graph</para>
    /// labels<para>Graph</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Graph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Graph</seealso>
    let Graph = Prefixed_Name(nrl, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>nrl:FunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify functional properties</para>
    /// labels<para>FunctionalProperty</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#FunctionalProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#FunctionalProperty</seealso>
    let FunctionalProperty = Prefixed_Name(nrl, "FunctionalProperty") |> PrefixedName
