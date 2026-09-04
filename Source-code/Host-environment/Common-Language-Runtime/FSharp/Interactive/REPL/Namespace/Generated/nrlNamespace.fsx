#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nrl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#" "nrl"

    /// <summary>
    ///   <para>rdfs:label : AsymmetricProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A marker class to identify asymmetric properties^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#AsymmetricProperty">nrl:AsymmetricProperty</a>
    /// </summary>
    let AsymmetricProperty = _prefixId.prefix "AsymmetricProperty"
    /// <summary>
    ///   <para>rdfs:label : Configuration^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a named graph containing configuration data^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Configuration">nrl:Configuration</a>
    /// </summary>
    let Configuration = _prefixId.prefix "Configuration"
    /// <summary>
    ///   <para>rdfs:label : Data^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class representing all named graph roles^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Data">nrl:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    let DefaultGraph = _prefixId.prefix "DefaultGraph"
    /// <summary>
    ///   <para>rdfs:comment : A defining property's value is part of what defines a resource, changing it means
    ///                           means chaning the identity of the resource. The set of values of all defining
    ///                           properties of a resource make up its identify.
    ///                           Whenever comparing resources or sharing them the value of this property should
    ///                           be taken into account. By default all properties with a literal range are to be
    ///                           treated as defining properties unless they are marked as nrl:NonDefiningProperty.^^xsd:string</para>
    ///   <para>rdfs:label : defining property^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DefiningProperty">nrl:DefiningProperty</a>
    /// </summary>
    let DefiningProperty = _prefixId.prefix "DefiningProperty"
    /// <summary>
    ///   <para>rdfs:label : DiscardableInstanceBase^^xsd:string</para>
    ///   <para>rdfs:comment : A named graph containing instance data that can be recreated by analyzing the original resources. Intended to be used by metadata extractors.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DiscardableInstanceBase">nrl:DiscardableInstanceBase</a>
    /// </summary>
    let DiscardableInstanceBase = _prefixId.prefix "DiscardableInstanceBase"
    /// <summary>
    ///   <para>rdfs:label : DocumentGraph^^xsd:string</para>
    ///   <para>rdfs:comment : A marker class to identify named graphs that exist within a physical document^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#DocumentGraph">nrl:DocumentGraph</a>
    /// </summary>
    let DocumentGraph = _prefixId.prefix "DocumentGraph"
    /// <summary>
    ///   <para>rdfs:label : ExternalViewSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an external view specification, this usually being a program which automatically generates the required view for an input graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ExternalViewSpecification">nrl:ExternalViewSpecification</a>
    /// </summary>
    let ExternalViewSpecification = _prefixId.prefix "ExternalViewSpecification"
    /// <summary>
    ///   <para>rdfs:label : FunctionalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A marker class to identify functional properties^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#FunctionalProperty">nrl:FunctionalProperty</a>
    /// </summary>
    let FunctionalProperty = _prefixId.prefix "FunctionalProperty"
    /// <summary>
    ///   <para>rdfs:label : Graph^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a named graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Graph">nrl:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>rdfs:label : GraphMetadata^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a special named graph that contains metadata for another graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphMetadata">nrl:GraphMetadata</a>
    /// </summary>
    let GraphMetadata = _prefixId.prefix "GraphMetadata"
    /// <summary>
    ///   <para>rdfs:label : GraphView^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies a graph which is itself a view of another named graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#GraphView">nrl:GraphView</a>
    /// </summary>
    let GraphView = _prefixId.prefix "GraphView"
    /// <summary>
    ///   <para>rdfs:label : InstanceBase^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a named graph containing instance data^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InstanceBase">nrl:InstanceBase</a>
    /// </summary>
    let InstanceBase = _prefixId.prefix "InstanceBase"
    /// <summary>
    ///   <para>rdfs:label : InverseFunctionalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A marker class to identify inverse functional properties^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#InverseFunctionalProperty">nrl:InverseFunctionalProperty</a>
    /// </summary>
    let InverseFunctionalProperty = _prefixId.prefix "InverseFunctionalProperty"
    /// <summary>
    ///   <para>rdfs:label : KnowledgeBase^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a named graph containing both schematic and instance data^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#KnowledgeBase">nrl:KnowledgeBase</a>
    /// </summary>
    let KnowledgeBase = _prefixId.prefix "KnowledgeBase"
    /// <summary>
    ///   <para>rdfs:comment : A non-defining property's value is not part of what defines a resource, it rather
    ///                           is part of the resource's state or expresses an opinion about the resource. Whenever
    ///                           comparing resources or sharing them the value of this property should not be taken into
    ///                           account. By default all properties with a resource range are to be treated as
    ///                           non-defining properties unless they are marked as nrl:DefiningProperty.^^xsd:string</para>
    ///   <para>rdfs:label : non-defining property^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#NonDefiningProperty">nrl:NonDefiningProperty</a>
    /// </summary>
    let NonDefiningProperty = _prefixId.prefix "NonDefiningProperty"
    /// <summary>
    ///   <para>rdfs:label : Ontology^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a named graph having the role of an Ontology^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Ontology">nrl:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:label : ReflexiveProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A marker class to identify reflexive properties^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ReflexiveProperty">nrl:ReflexiveProperty</a>
    /// </summary>
    let ReflexiveProperty = _prefixId.prefix "ReflexiveProperty"
    /// <summary>
    ///   <para>rdfs:label : RuleViewSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a view specification that is composed of a set of rules which generate the required view from the input graph upon firing^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#RuleViewSpecification">nrl:RuleViewSpecification</a>
    /// </summary>
    let RuleViewSpecification = _prefixId.prefix "RuleViewSpecification"
    /// <summary>
    ///   <para>rdfs:label : Schema^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a named graph containing schematic data^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Schema">nrl:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    /// <summary>
    ///   <para>rdfs:label : Semantics^^xsd:string</para>
    ///   <para>rdfs:comment : Represents some declarative semantics^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#Semantics">nrl:Semantics</a>
    /// </summary>
    let Semantics = _prefixId.prefix "Semantics"
    /// <summary>
    ///   <para>rdfs:label : SymmetricProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A marker class to identify symmetric properties^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#SymmetricProperty">nrl:SymmetricProperty</a>
    /// </summary>
    let SymmetricProperty = _prefixId.prefix "SymmetricProperty"
    /// <summary>
    ///   <para>rdfs:label : TransitiveProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A marker class to identify transitive properties^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#TransitiveProperty">nrl:TransitiveProperty</a>
    /// </summary>
    let TransitiveProperty = _prefixId.prefix "TransitiveProperty"
    /// <summary>
    ///   <para>rdfs:label : ViewSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a specification of the means to achieve a transformation of an input graph into the required graph view^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ViewSpecification">nrl:ViewSpecification</a>
    /// </summary>
    let ViewSpecification = _prefixId.prefix "ViewSpecification"
    /// <summary>
    ///   <para>rdfs:label : cardinality^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the precise value cardinality for a specific property^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#cardinality">nrl:cardinality</a>
    /// </summary>
    let cardinality = _prefixId.prefix "cardinality"
    /// <summary>
    ///   <para>rdfs:label : coreGraphMetadataFor^^xsd:string</para>
    ///   <para>rdfs:comment : Links a metadata graph to the graph for which it specifies the core graph properties including the semantics and the graph namespace. A graph can have only one unique core metadata graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#coreGraphMetadataFor">nrl:coreGraphMetadataFor</a>
    /// </summary>
    let coreGraphMetadataFor = _prefixId.prefix "coreGraphMetadataFor"
    /// <summary>
    ///   <para>rdfs:label : equivalentGraph^^xsd:string</para>
    ///   <para>rdfs:comment : Links two equivalent named graphs. A symmetric property^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#equivalentGraph">nrl:equivalentGraph</a>
    /// </summary>
    let equivalentGraph = _prefixId.prefix "equivalentGraph"
    /// <summary>
    ///   <para>rdfs:label : externalRealizer^^xsd:string</para>
    ///   <para>rdfs:comment : Points to the location of the realizer for the external view specification^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#externalRealizer">nrl:externalRealizer</a>
    /// </summary>
    let externalRealizer = _prefixId.prefix "externalRealizer"
    /// <summary>
    ///   <para>nrl:minCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : graphMetadataFor^^xsd:string</para>
    ///   <para>rdfs:comment : Links a metadata graph to the graph that is being described. A unique value is compulsory^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#graphMetadataFor">nrl:graphMetadataFor</a>
    /// </summary>
    let graphMetadataFor = _prefixId.prefix "graphMetadataFor"
    /// <summary>
    ///   <para>rdfs:label : hasSemantics^^xsd:string</para>
    ///   <para>rdfs:comment : Points to a representation of the declarative semantics for a graph role^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSemantics">nrl:hasSemantics</a>
    /// </summary>
    let hasSemantics = _prefixId.prefix "hasSemantics"
    /// <summary>
    ///   <para>rdfs:label : hasSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : Points to the representation of the view specification required to generate the graph view in question^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#hasSpecification">nrl:hasSpecification</a>
    /// </summary>
    let hasSpecification = _prefixId.prefix "hasSpecification"
    /// <summary>
    ///   <para>rdfs:label : imports^^xsd:string</para>
    ///   <para>rdfs:comment : Models a subsumption relationship between two graphs, stating that the object graph is imported and included in the subject graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#imports">nrl:imports</a>
    /// </summary>
    let imports = _prefixId.prefix "imports"
    /// <summary>
    ///   <para>rdfs:label : inverseProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Links two properties and specifies their inverse behaviour^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#inverseProperty">nrl:inverseProperty</a>
    /// </summary>
    let inverseProperty = _prefixId.prefix "inverseProperty"
    /// <summary>
    ///   <para>rdfs:label : maxCardinality^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a maximum value cardinality for a specific property^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#maxCardinality">nrl:maxCardinality</a>
    /// </summary>
    let maxCardinality = _prefixId.prefix "maxCardinality"
    /// <summary>
    ///   <para>rdfs:label : minCardinality^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a minimum value cardinality for a specific property^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#minCardinality">nrl:minCardinality</a>
    /// </summary>
    let minCardinality = _prefixId.prefix "minCardinality"
    /// <summary>
    ///   <para>rdfs:label : realizes^^xsd:string</para>
    ///   <para>rdfs:comment : Points to a representation of the declarative semantics that the view specification realizes^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#realizes">nrl:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"
    /// <summary>
    ///   <para>rdfs:label : rule^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies rules for a view specification that is driven by rules^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#rule">nrl:rule</a>
    /// </summary>
    let rule = _prefixId.prefix "rule"
    /// <summary>
    ///   <para>rdfs:label : ruleLanguage^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the rule language for a view specification that is driven by rules^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#ruleLanguage">nrl:ruleLanguage</a>
    /// </summary>
    let ruleLanguage = _prefixId.prefix "ruleLanguage"
    /// <summary>
    ///   <para>rdfs:label : semanticsDefinedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Points to the human readable specifications for a representation of some declarative semantics^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#semanticsDefinedBy">nrl:semanticsDefinedBy</a>
    /// </summary>
    let semanticsDefinedBy = _prefixId.prefix "semanticsDefinedBy"
    /// <summary>
    ///   <para>rdfs:label : subGraphOf^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a containment relationship between two graphs, meaning that the subject graph is included in the object graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#subGraphOf">nrl:subGraphOf</a>
    /// </summary>
    let subGraphOf = _prefixId.prefix "subGraphOf"
    /// <summary>
    ///   <para>rdfs:label : superGraphOf^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a subsumption relationship between two graphs, meaning that the object graph is included in the subject graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#superGraphOf">nrl:superGraphOf</a>
    /// </summary>
    let superGraphOf = _prefixId.prefix "superGraphOf"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : updatable^^xsd:string</para>
    ///   <para>rdfs:comment : A core graph metadata property, this defines whether a graph can be freely updated '1' or otherwise '0'^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#updatable">nrl:updatable</a>
    /// </summary>
    let updatable = _prefixId.prefix "updatable"
    /// <summary>
    ///   <para>rdfs:label : viewOn^^xsd:string</para>
    ///   <para>rdfs:comment : Points to a graph view over the subject named graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#viewOn">nrl:viewOn</a>
    /// </summary>
    let viewOn = _prefixId.prefix "viewOn"
