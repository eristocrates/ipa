namespace http.www.semanticdesktop.org.ontologies._2007._08._15.nrl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nrl =
    let _namespace_iri = Namespace_Iri nrl |> NamespaceIRI
    /// <summary>
    ///   <para>nrl:AsymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A marker class to identify asymmetric properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AsymmetricProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#AsymmetricProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#AsymmetricProperty</seealso>
    let AsymmetricProperty = Prefixed_Name(nrl, "AsymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a named graph containing configuration data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Configuration">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Configuration</seealso>
    let Configuration = Prefixed_Name(nrl, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstract class representing all named graph roles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Data">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Data</seealso>
    let Data = Prefixed_Name(nrl, "Data") |> PrefixedName
    /// <summary>
    ///   <para>nrl:DefaultGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:Graph</para>
    ///   <para>"Represents the default graph, the graph which contains any triple that does not belong to any other named graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DefaultGraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefaultGraph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefaultGraph</seealso>
    let DefaultGraph = Prefixed_Name(nrl, "DefaultGraph") |> PrefixedName
    /// <summary>
    ///   <para>nrl:DefiningProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A defining property's value is part of what defines a resource, changing it means
    ///                           means chaning the identity of the resource. The set of values of all defining
    ///                           properties of a resource make up its identify.
    ///                           Whenever comparing resources or sharing them the value of this property should
    ///                           be taken into account. By default all properties with a literal range are to be
    ///                           treated as defining properties unless they are marked as nrl:NonDefiningProperty."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"defining property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefiningProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefiningProperty</seealso>
    let DefiningProperty = Prefixed_Name(nrl, "DefiningProperty") |> PrefixedName

    /// <summary>
    ///   <para>nrl:DiscardableInstanceBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A named graph containing instance data that can be recreated by analyzing the original resources. Intended to be used by metadata extractors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DiscardableInstanceBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DiscardableInstanceBase">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DiscardableInstanceBase</seealso>
    let DiscardableInstanceBase =
        Prefixed_Name(nrl, "DiscardableInstanceBase") |> PrefixedName

    /// <summary>
    ///   <para>nrl:DocumentGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A marker class to identify named graphs that exist within a physical document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DocumentGraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DocumentGraph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DocumentGraph</seealso>
    let DocumentGraph = Prefixed_Name(nrl, "DocumentGraph") |> PrefixedName

    /// <summary>
    ///   <para>nrl:ExternalViewSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents an external view specification, this usually being a program which automatically generates the required view for an input graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExternalViewSpecification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ExternalViewSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ExternalViewSpecification</seealso>
    let ExternalViewSpecification =
        Prefixed_Name(nrl, "ExternalViewSpecification") |> PrefixedName

    /// <summary>
    ///   <para>nrl:FunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A marker class to identify functional properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FunctionalProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#FunctionalProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#FunctionalProperty</seealso>
    let FunctionalProperty = Prefixed_Name(nrl, "FunctionalProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a named graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Graph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Graph</seealso>
    let Graph = Prefixed_Name(nrl, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>nrl:GraphMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a special named graph that contains metadata for another graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphMetadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphMetadata">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphMetadata</seealso>
    let GraphMetadata = Prefixed_Name(nrl, "GraphMetadata") |> PrefixedName
    /// <summary>
    ///   <para>nrl:GraphView</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Identifies a graph which is itself a view of another named graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GraphView"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphView">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphView</seealso>
    let GraphView = Prefixed_Name(nrl, "GraphView") |> PrefixedName
    /// <summary>
    ///   <para>nrl:InstanceBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a named graph containing instance data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InstanceBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InstanceBase">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InstanceBase</seealso>
    let InstanceBase = Prefixed_Name(nrl, "InstanceBase") |> PrefixedName

    /// <summary>
    ///   <para>nrl:InverseFunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A marker class to identify inverse functional properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InverseFunctionalProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InverseFunctionalProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InverseFunctionalProperty</seealso>
    let InverseFunctionalProperty =
        Prefixed_Name(nrl, "InverseFunctionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>nrl:KnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a named graph containing both schematic and instance data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KnowledgeBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#KnowledgeBase">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#KnowledgeBase</seealso>
    let KnowledgeBase = Prefixed_Name(nrl, "KnowledgeBase") |> PrefixedName
    /// <summary>
    ///   <para>nrl:MaxCardinality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#MaxCardinality">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#MaxCardinality</seealso>
    let MaxCardinality = Prefixed_Name(nrl, "MaxCardinality") |> PrefixedName
    /// <summary>
    ///   <para>nrl:NonDefiningProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A non-defining property's value is not part of what defines a resource, it rather
    ///                           is part of the resource's state or expresses an opinion about the resource. Whenever
    ///                           comparing resources or sharing them the value of this property should not be taken into
    ///                           account. By default all properties with a resource range are to be treated as
    ///                           non-defining properties unless they are marked as nrl:DefiningProperty."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"non-defining property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#NonDefiningProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#NonDefiningProperty</seealso>
    let NonDefiningProperty = Prefixed_Name(nrl, "NonDefiningProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a named graph having the role of an Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Ontology">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Ontology</seealso>
    let Ontology = Prefixed_Name(nrl, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>nrl:ReflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A marker class to identify reflexive properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ReflexiveProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ReflexiveProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ReflexiveProperty</seealso>
    let ReflexiveProperty = Prefixed_Name(nrl, "ReflexiveProperty") |> PrefixedName

    /// <summary>
    ///   <para>nrl:RuleViewSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a view specification that is composed of a set of rules which generate the required view from the input graph upon firing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RuleViewSpecification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#RuleViewSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#RuleViewSpecification</seealso>
    let RuleViewSpecification =
        Prefixed_Name(nrl, "RuleViewSpecification") |> PrefixedName

    /// <summary>
    ///   <para>nrl:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a named graph containing schematic data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Schema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Schema">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Schema</seealso>
    let Schema = Prefixed_Name(nrl, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>nrl:Semantics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents some declarative semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Semantics">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Semantics</seealso>
    let Semantics = Prefixed_Name(nrl, "Semantics") |> PrefixedName
    /// <summary>
    ///   <para>nrl:SymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A marker class to identify symmetric properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SymmetricProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#SymmetricProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#SymmetricProperty</seealso>
    let SymmetricProperty = Prefixed_Name(nrl, "SymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:TransitiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A marker class to identify transitive properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransitiveProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#TransitiveProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#TransitiveProperty</seealso>
    let TransitiveProperty = Prefixed_Name(nrl, "TransitiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:ViewSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a specification of the means to achieve a transformation of an input graph into the required graph view"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ViewSpecification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ViewSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ViewSpecification</seealso>
    let ViewSpecification = Prefixed_Name(nrl, "ViewSpecification") |> PrefixedName
    /// <summary>
    ///   <para>nrl:cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies the precise value cardinality for a specific property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#cardinality">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#cardinality</seealso>
    let cardinality = Prefixed_Name(nrl, "cardinality") |> PrefixedName

    /// <summary>
    ///   <para>nrl:coreGraphMetadataFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a metadata graph to the graph for which it specifies the core graph properties including the semantics and the graph namespace. A graph can have only one unique core metadata graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"coreGraphMetadataFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#coreGraphMetadataFor">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#coreGraphMetadataFor</seealso>
    let coreGraphMetadataFor =
        Prefixed_Name(nrl, "coreGraphMetadataFor") |> PrefixedName

    /// <summary>
    ///   <para>nrl:equivalentGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>nrl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links two equivalent named graphs. A symmetric property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"equivalentGraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#equivalentGraph">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#equivalentGraph</seealso>
    let equivalentGraph = Prefixed_Name(nrl, "equivalentGraph") |> PrefixedName
    /// <summary>
    ///   <para>nrl:externalRealizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to the location of the realizer for the external view specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"externalRealizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#externalRealizer">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#externalRealizer</seealso>
    let externalRealizer = Prefixed_Name(nrl, "externalRealizer") |> PrefixedName
    /// <summary>
    ///   <para>nrl:graphMetadataFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a metadata graph to the graph that is being described. A unique value is compulsory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"graphMetadataFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#graphMetadataFor">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#graphMetadataFor</seealso>
    let graphMetadataFor = Prefixed_Name(nrl, "graphMetadataFor") |> PrefixedName
    /// <summary>
    ///   <para>nrl:hasSemantics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a representation of the declarative semantics for a graph role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSemantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSemantics">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSemantics</seealso>
    let hasSemantics = Prefixed_Name(nrl, "hasSemantics") |> PrefixedName
    /// <summary>
    ///   <para>nrl:hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to the representation of the view specification required to generate the graph view in question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSpecification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSpecification">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSpecification</seealso>
    let hasSpecification = Prefixed_Name(nrl, "hasSpecification") |> PrefixedName
    /// <summary>
    ///   <para>nrl:imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Models a subsumption relationship between two graphs, stating that the object graph is imported and included in the subject graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#imports">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#imports</seealso>
    let imports = Prefixed_Name(nrl, "imports") |> PrefixedName
    /// <summary>
    ///   <para>nrl:inverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links two properties and specifies their inverse behaviour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inverseProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#inverseProperty">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#inverseProperty</seealso>
    let inverseProperty = Prefixed_Name(nrl, "inverseProperty") |> PrefixedName
    /// <summary>
    ///   <para>nrl:maxCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies a maximum value cardinality for a specific property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maxCardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#maxCardinality">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#maxCardinality</seealso>
    let maxCardinality = Prefixed_Name(nrl, "maxCardinality") |> PrefixedName
    /// <summary>
    ///   <para>nrl:minCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies a minimum value cardinality for a specific property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"minCardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#minCardinality">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#minCardinality</seealso>
    let minCardinality = Prefixed_Name(nrl, "minCardinality") |> PrefixedName
    /// <summary>
    ///   <para>nrl:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a representation of the declarative semantics that the view specification realizes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realizes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#realizes">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#realizes</seealso>
    let realizes = Prefixed_Name(nrl, "realizes") |> PrefixedName
    /// <summary>
    ///   <para>nrl:rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies rules for a view specification that is driven by rules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#rule">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#rule</seealso>
    let rule = Prefixed_Name(nrl, "rule") |> PrefixedName
    /// <summary>
    ///   <para>nrl:ruleLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies the rule language for a view specification that is driven by rules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ruleLanguage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ruleLanguage">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ruleLanguage</seealso>
    let ruleLanguage = Prefixed_Name(nrl, "ruleLanguage") |> PrefixedName
    /// <summary>
    ///   <para>nrl:semanticsDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to the human readable specifications for a representation of some declarative semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"semanticsDefinedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#semanticsDefinedBy">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#semanticsDefinedBy</seealso>
    let semanticsDefinedBy = Prefixed_Name(nrl, "semanticsDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>nrl:subGraphOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies a containment relationship between two graphs, meaning that the subject graph is included in the object graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subGraphOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#subGraphOf">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#subGraphOf</seealso>
    let subGraphOf = Prefixed_Name(nrl, "subGraphOf") |> PrefixedName
    /// <summary>
    ///   <para>nrl:superGraphOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies a subsumption relationship between two graphs, meaning that the object graph is included in the subject graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"superGraphOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#superGraphOf">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#superGraphOf</seealso>
    let superGraphOf = Prefixed_Name(nrl, "superGraphOf") |> PrefixedName
    /// <summary>
    ///   <para>nrl:updatable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A core graph metadata property, this defines whether a graph can be freely updated '1' or otherwise '0'"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"updatable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#updatable">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#updatable</seealso>
    let updatable = Prefixed_Name(nrl, "updatable") |> PrefixedName
    /// <summary>
    ///   <para>nrl:viewOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a graph view over the subject named graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"viewOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#viewOn">http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#viewOn</seealso>
    let viewOn = Prefixed_Name(nrl, "viewOn") |> PrefixedName
