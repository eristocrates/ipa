#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module voidext =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/query/voidext#" "voidext"

    /// <summary>
    ///   <para>voidext:querySharedInstanceSet : prefix void:    &lt;http://rdfs.org/ns/void#&gt;
    /// prefix voidext:&lt;http://purl.org/query/voidext#&gt;
    /// prefix dcterms: &lt;http://purl.org/dc/terms/&gt;
    ///
    /// SELECT distinct ?links ?source_dataset1_name ?target_dataset2_name ?sharedType
    ///   ?resourceMapping ?source_endpoint ?target_endpoint{
    ///
    ///  #values(?source_db){ (bioquery:EBI) }
    ///  #values(?target_db){ (bioquery:UNIPROT) }
    ///
    ///  ?links a voidext:ComplexLinkSet.
    ///  ?links voidext:intersectAt ?set1; voidext:intersectAt ?set2.
    ///  ?set1  voidext:isSubsetOf ?target_db.
    ///  ?target_db dcterms:title ?target_dataset2_name;
    ///            void:sparqlEndpoint ?target_endpoint.
    ///  ?set2 voidext:sharedInstanceType  ?sharedType .
    ///  ?set2 voidext:isSubsetOf ?source_db .
    ///  ?source_db dcterms:title ?source_dataset1_name;
    ///             void:sparqlEndpoint ?source_endpoint.
    ///
    ///  optional{   ?links voidext:recommendedMapping ?set2.
    ///              ?set2 voidext:resourceMapping  ?resourceMapping}
    ///  filter(?target_db != ?source_db)
    ///
    /// } order by ?links^^rdfs:Literal</para>
    ///   <para>voidext:queryLinkset : prefix void:    &lt;http://rdfs.org/ns/void#&gt;
    /// prefix voidext:&lt;http://purl.org/query/voidext#&gt;
    /// prefix dcterms: &lt;http://purl.org/dc/terms/&gt;
    ///
    /// SELECT distinct ?links ?source_dataset1_name ?target_dataset2_name ?predicate
    ///  ?intersection_type ?subj_type ?obj_type  ?source_endpoint ?target_endpoint
    ///  ?resourceMapping {
    ///
    ///  #values(?dataset1){ (bioquery:EBI_ORDO) }
    ///  #values(?dataset2){ (bioquery:DRUGBANK) }
    ///
    ///  ?links a voidext:ComplexLinkSet.
    ///  ?links  voidext:intersectAt ?set2;
    ///          voidext:intersectionType/rdfs:label ?intersection_type.
    ///  ?set2   voidext:isSubsetOf ?target_db.
    ///  ?target_db dcterms:title ?target_dataset2_name;
    ///             void:sparqlEndpoint ?target_endpoint.
    ///  ?set2 void:linkPredicate ?predicate2 .
    ///
    ///
    ///  ?links  voidext:intersectAt ?set1.
    ///  ?set1 void:linkPredicate ?predicate .
    ///  ?set1 voidext:isSubsetOf ?source_db .
    ///  ?source_db dcterms:title ?source_dataset1_name;
    ///             void:sparqlEndpoint ?source_endpoint.
    /// optional{ ?set1 voidext:linkPredicateDomain ?subj_type}
    /// optional{ ?set1 voidext:linkPredicateRange ?obj_type.}
    /// optional{ ?links voidext:recommendedMapping ?set1.
    ///                ?set1 voidext:resourceMapping  ?resourceMapping}
    /// filter(?source_db != ?target_db)
    ///
    /// } order by ?links^^rdfs:Literal</para>
    ///   <para>rdfs:label : Complex link set</para>
    ///   <para>rdfs:comment : It is a complex virtual link set. A complex link set is composed of exactly two link sets xor two shared instance sets where xor is the exclusive or. For example, two link sets that intersects at some graph node (e.g. the object nodes of link predicates).</para>
    ///   <a href="http://purl.org/query/voidext#ComplexLinkSet">voidext:ComplexLinkSet</a>
    /// </summary>
    let ComplexLinkSet = _prefixId.prefix "ComplexLinkSet"
    let LINK_SHAREDINSTANCE_SET = _prefixId.prefix "LINK_SHAREDINSTANCE_SET"
    /// <summary>
    ///   <para>rdfs:label : Linkset intersection</para>
    ///   <para>rdfs:comment : The possible intersection types between the RDF graph nodes in different void:Dataset(s) (i.e. either the subject or the object node of a link predicate). The instances of this class are exclusively voidext:OBJECT_OBJECT, voidext:OBJECT_SUBJECT, and voidext:SUBJECT_SUBJECT.</para>
    ///   <a href="http://purl.org/query/voidext#LinkSetIntersection">voidext:LinkSetIntersection</a>
    /// </summary>
    let LinkSetIntersection = _prefixId.prefix "LinkSetIntersection"
    let MODIFIED_TARGET_1 = _prefixId.prefix "MODIFIED_TARGET_1"
    let OBJECT_OBJECT = _prefixId.prefix "OBJECT_OBJECT"
    let SUBJECT_OBJECT = _prefixId.prefix "SUBJECT_OBJECT"
    let SUBJECT_SUBJECT = _prefixId.prefix "SUBJECT_SUBJECT"
    /// <summary>
    ///   <para>rdfs:label : Shared instance set</para>
    ///   <para>rdfs:comment : A shared instance set between exactly two datasets. For example, two datasets that contain the same OWL/RDFS class instances.</para>
    ///   <a href="http://purl.org/query/voidext#SharedInstanceSet">voidext:SharedInstanceSet</a>
    /// </summary>
    let SharedInstanceSet = _prefixId.prefix "SharedInstanceSet"
    /// <summary>
    ///   <para>voidext:querySharedInstanceSet : prefix void:    &lt;http://rdfs.org/ns/void#&gt;
    /// prefix voidext:&lt;http://purl.org/query/voidext#&gt;
    /// prefix dcterms: &lt;http://purl.org/dc/terms/&gt;
    ///
    /// SELECT distinct ?links ?dataset1_name  ?dataset2_name  ?sharedType
    ///                        ?dataset1_endpoint ?dataset2_endpoint {
    ///
    ///  #values(?dataset1){ (bioquery:BGEE) }
    ///  #values(?dataset2){ (bioquery:OMA) }
    ///
    /// ?links a voidext:SharedInstanceSet.
    /// ?links void:target ?dataset1.
    /// ?links void:target ?dataset2.
    /// ?links voidext:sharedInstanceType ?sharedType.
    /// ?dataset1   dcterms:title ?dataset1_name;
    ///                    void:sparqlEndpoint ?dataset1_endpoint.
    /// ?dataset2  dcterms:title ?dataset2_name;
    ///                    void:sparqlEndpoint ?dataset2_endpoint.
    ///
    /// filter not exists { ?complexLink voidext:intersectAt ?links .}
    /// filter(?dataset1 != ?dataset2)
    /// } order by ?links^^rdfs:Literal</para>
    ///   <para>voidext:queryLinkset : prefix void:    &lt;http://rdfs.org/ns/void#&gt;
    /// prefix voidext:&lt;http://purl.org/query/voidext#&gt;
    /// prefix dcterms: &lt;http://purl.org/dc/terms/&gt;
    ///
    /// SELECT distinct ?links  ?source  ?predicate_from_endpoint ?subj_from ?subj_type ?predicate
    ///  ?obj_type  ?obj_from  ?resourceMapping {
    ///
    /// ###if we want to specify the target datasets that contain one of the resources
    /// ###related with a virtual link.
    /// #values(?dataset_link_subj){  (bioquery:OMA)  }
    /// #values(?dataset_link_obj){  (bioquery:UNIPROT)  }
    ///
    /// ?links  a void:Linkset.
    /// {
    ///  ?links void:subjectsTarget ?dataset_link_subj .
    ///  ?links void:objectsTarget ?dataset_link_obj.
    /// } UNION {
    ///  ?links void:target ?dataset_link_subj.
    ///  ?links void:target ?dataset_link_obj .}
    ///  ?links void:linkPredicate ?predicate;
    ///         voidext:isSubsetOf ?source_db.
    ///  ?dataset_link_subj void:sparqlEndpoint ?subj_from.
    ///  ?dataset_link_obj void:sparqlEndpoint ?obj_from.
    ///  ?source_db dcterms:title ?source;
    ///             void:sparqlEndpoint ?predicate_from_endpoint.
    ///
    ///  optional {?links  voidext:linkPredicateRange ?obj_type}.
    ///  optional {?links voidext:linkPredicateDomain ?subj_type. }
    ///  optional{ ?links voidext:resourceMapping  ?resourceMapping}
    ///
    /// filter not exists { ?complexLink  voidext:intersectAt ?links.}
    /// filter ( ?dataset_link_subj  !=  ?dataset_link_obj )
    ///
    /// } order by ?links^^rdfs:Literal</para>
    ///   <para>rdfs:label : Simple link set</para>
    ///   <para>rdfs:comment : A simple link set must be a linkset that does not target another linkset (i.e. it has exactly one link predicate) or a set with exactly the same shared instances of the same type (i.e. class) in both datasets. The instances of this class must be also instances of either void:Linkset or voidext:SharedInstanceSet.</para>
    ///   <a href="http://purl.org/query/voidext#SimpleLinkSet">voidext:SimpleLinkSet</a>
    /// </summary>
    let SimpleLinkSet = _prefixId.prefix "SimpleLinkSet"
    /// <summary>
    ///   <para>rdfs:label : Virtual link set</para>
    ///   <para>rdfs:comment : A set of virtual links between two datasets. A virtual link is a connection between resources such as literals and instances with some commonality. Each of these resources is from a different RDF dataset. A resource mapping can be also considered when defining common resources between datasets. For example, the datasets uses different prefix namespaces for similar instances in a given domain scope. A virtual link can be interpreted as an intersection data point between two datasets. In addition, a virtual link is not concretely stored. The link may be physically established during a federated query execution, for example. This class must only have instances of its subclasses. It is recommendable to comment (rdfs:comment) the scope of the virtual link set.</para>
    ///   <a href="http://purl.org/query/voidext#VirtualLinkSet">voidext:VirtualLinkSet</a>
    /// </summary>
    let VirtualLinkSet = _prefixId.prefix "VirtualLinkSet"
    /// <summary>
    ///   <para>rdfs:label : has performance measure</para>
    ///   <para>rdfs:comment : This property assings the performance of the virtual link set, for example, in terms of recall and precision. The values to be assigned (property range) are represented with the ontology MEX Performance Ontology.</para>
    ///   <a href="http://purl.org/query/voidext#hasPerformanceMeasure">voidext:hasPerformanceMeasure</a>
    /// </summary>
    let hasPerformanceMeasure = _prefixId.prefix "hasPerformanceMeasure"
    /// <summary>
    ///   <para>rdfs:label : intersects at</para>
    ///   <para>rdfs:comment : This property is used to assign exactly either two shared instance sets (voidext:SharedInstanceSet) or two link sets (void:Linkset) to compose a complex link set (voidext:ComplexLinkSet). For each void:Linkset, either the subject or the object node of its link predicate intersects an RDF node of the link predicate from the other link set. In other words, the subject xor the object of a link predicate matches the subject xor the object of the other link predicate, where xor is the exclusive or. These link predicates must be from different datasets.</para>
    ///   <a href="http://purl.org/query/voidext#intersectAt">voidext:intersectAt</a>
    /// </summary>
    let intersectAt = _prefixId.prefix "intersectAt"
    /// <summary>
    ///   <para>rdfs:label : intersection type</para>
    ///   <para>rdfs:comment : This property assigns the intersection type of two RDF triples in different datasets (void:Dataset). In other words, if the intersection occurs at the subject xor the object node of a link predicate.</para>
    ///   <a href="http://purl.org/query/voidext#intersectionType">voidext:intersectionType</a>
    /// </summary>
    let intersectionType = _prefixId.prefix "intersectionType"
    /// <summary>
    ///   <para>rdfs:label : is subset of^^xsd:string</para>
    ///   <a href="http://purl.org/query/voidext#isSubsetOf">voidext:isSubsetOf</a>
    /// </summary>
    let isSubsetOf = _prefixId.prefix "isSubsetOf"
    /// <summary>
    ///   <para>rdfs:comment : The link predicate's subject type (i.e. class), if any. Moreover, in the case of a void:Linkset that is classified as a simple link set (voidext:SimpleLinkSet), if the two datasets are linked through the link predicate's subject then the link predicate domain must be specified. Indeed, this subject matches a second resource in an external dataset. Therefore, the type of this second resource is asserted as the link predicate domain.</para>
    ///   <para>rdfs:label : link predicate domain</para>
    ///   <a href="http://purl.org/query/voidext#linkPredicateDomain">voidext:linkPredicateDomain</a>
    /// </summary>
    let linkPredicateDomain = _prefixId.prefix "linkPredicateDomain"
    /// <summary>
    ///   <para>rdfs:label : link predicate range</para>
    ///   <para>rdfs:comment : The link predicate's object type (i.e. class), if any. Moreover, in the case of a void:Linkset that is not classified as a simple link set, if the two datasets are linked through the link predicate's object then the link predicate range must be specified. Indeed, this object matches a second resource in an external dataset. Therefore, the type of this second resource is asserted as the link predicate range.</para>
    ///   <a href="http://purl.org/query/voidext#linkPredicateRange">voidext:linkPredicateRange</a>
    /// </summary>
    let linkPredicateRange = _prefixId.prefix "linkPredicateRange"
    /// <summary>
    ///   <para>rdfs:comment : This property must only assign one standard SPARQL query per category (i.e. subclass) of VirtualLinkSet to retrieve the formal definition of linkset (i.e. query projection) as presented in the voidext specification.</para>
    ///   <para>rdfs:label : query for linkset</para>
    ///   <a href="http://purl.org/query/voidext#queryLinkset">voidext:queryLinkset</a>
    /// </summary>
    let queryLinkset = _prefixId.prefix "queryLinkset"
    /// <summary>
    ///   <para>rdfs:comment : This property must only assign one standard SPARQL query per category (i.e. subclass) of VirtualLinkSet to retrieve the formal definition of shared instance set (i.e. query projection) as presented in the voidext specification.</para>
    ///   <para>rdfs:label : query for shared instance set</para>
    ///   <a href="http://purl.org/query/voidext#querySharedInstanceSet">voidext:querySharedInstanceSet</a>
    /// </summary>
    let querySharedInstanceSet = _prefixId.prefix "querySharedInstanceSet"
    /// <summary>
    ///   <para>rdfs:label : recommended mapping from</para>
    ///   <para>rdfs:comment : If more than one mapping is defined in the different void:Linkset(s) that are part of a voidext:ComplexLinkSet, one of the resource mappings may be recommended by asserting this property. The recommended mapping is the one stated to the void:Linkset assigned as the value of this property. If no mapping is explicitly recommended, solely one of them must arbitrarily be applied to establish a virtual link. At most one mapping function can be defined either per linkset or per shared instance set.</para>
    ///   <a href="http://purl.org/query/voidext#recommendedMapping">voidext:recommendedMapping</a>
    /// </summary>
    let recommendedMapping = _prefixId.prefix "recommendedMapping"
    /// <summary>
    ///   <para>dcterms:description : Example of a value assigned with this property is the following
    ///     "?objectsTarget a &lt;urn:Example&gt;. BIND(IF(contains(?objectsTarget, "Example:" ), IRI(concat("http://example.org/uniprot:",strafter(?objectsTarget,"Example:"))), ?objectsTargetConverted)
    ///          as ?converted_object)
    ///      FILTER(BOUND(?obj_converted))".
    ///      This will convert strings that contains "Example:" into IRIs defined in http://example.org/ namespace.^^xsd:string</para>
    ///   <para>rdfs:label : resource mapped with</para>
    ///   <para>rdfs:comment : The preprocessing of a resource (i.e. IRI or literal) in a source void:Dataset in order
    /// to match another resource in the target void:Dataset. A resource is either the subject or the
    /// object of an RDF triple. The resource preprocessing (i.e. the resource mapping)
    /// must be defined with the SPARQL language by mainly using SPARQL built-ins for assignments
    /// (e.g. BIND), and expression and testing values (e.g. IF and FILTER). BIND is used to assign
    /// the output of a function.^^xsd:string</para>
    ///   <a href="http://purl.org/query/voidext#resourceMapping">voidext:resourceMapping</a>
    /// </summary>
    let resourceMapping = _prefixId.prefix "resourceMapping"
    /// <summary>
    ///   <para>rdfs:label : shared instance type</para>
    ///   <para>rdfs:comment : This property assings the type (i.e. class) of the shared instances from a given void:Dataset. Shared instances implies equivalent or similar instance IRIs that belong to different datasets.</para>
    ///   <a href="http://purl.org/query/voidext#sharedInstanceType">voidext:sharedInstanceType</a>
    /// </summary>
    let sharedInstanceType = _prefixId.prefix "sharedInstanceType"
    /// <summary>
    ///   <para>rdfs:label : supports SPARQL 1.1 federated query</para>
    ///   <para>rdfs:comment : This property should be used to explicitly assert that a void:Dataset supports SPARQL 1.1. federated queries to be able to access the dataset with the SERVICE keyword and perform federated join queries.</para>
    ///   <a href="http://purl.org/query/voidext#supportFederatedQuery">voidext:supportFederatedQuery</a>
    /// </summary>
    let supportFederatedQuery = _prefixId.prefix "supportFederatedQuery"
