namespace http.purl.org.query.voidext.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module voidext =
    let _namespace_iri = Namespace_Iri voidext |> NamespaceIRI
    /// <summary>
    ///   <para>voidext:queryLinkset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property must only assign one standard SPARQL query per category (i.e. subclass) of VirtualLinkSet to retrieve the formal definition of linkset (i.e. query projection) as presented in the voidext specification.</para>
    /// labels<para>query for linkset</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#queryLinkset">http://purl.org/query/voidext#queryLinkset</seealso>
    let queryLinkset = Prefixed_Name(voidext, "queryLinkset") |> PrefixedName
    /// <summary>
    ///   <para>voidext:ComplexLinkSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>It is a complex virtual link set. A complex link set is composed of exactly two link sets xor two shared instance sets where xor is the exclusive or. For example, two link sets that intersects at some graph node (e.g. the object nodes of link predicates).</para>
    /// labels<para>Complex link set</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#ComplexLinkSet">http://purl.org/query/voidext#ComplexLinkSet</seealso>
    let ComplexLinkSet = Prefixed_Name(voidext, "ComplexLinkSet") |> PrefixedName

    /// <summary>
    ///   <para>voidext:querySharedInstanceSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property must only assign one standard SPARQL query per category (i.e. subclass) of VirtualLinkSet to retrieve the formal definition of shared instance set (i.e. query projection) as presented in the voidext specification.</para>
    /// labels<para>query for shared instance set</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#querySharedInstanceSet">http://purl.org/query/voidext#querySharedInstanceSet</seealso>
    let querySharedInstanceSet =
        Prefixed_Name(voidext, "querySharedInstanceSet") |> PrefixedName

    /// <summary>
    ///   <para>voidext:SharedInstanceSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A shared instance set between exactly two datasets. For example, two datasets that contain the same OWL/RDFS class instances.</para>
    /// labels<para>Shared instance set</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#SharedInstanceSet">http://purl.org/query/voidext#SharedInstanceSet</seealso>
    let SharedInstanceSet = Prefixed_Name(voidext, "SharedInstanceSet") |> PrefixedName
    /// <summary>
    ///   <para>voidext:VirtualLinkSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of virtual links between two datasets. A virtual link is a connection between resources such as literals and instances with some commonality. Each of these resources is from a different RDF dataset. A resource mapping can be also considered when defining common resources between datasets. For example, the datasets uses different prefix namespaces for similar instances in a given domain scope. A virtual link can be interpreted as an intersection data point between two datasets. In addition, a virtual link is not concretely stored. The link may be physically established during a federated query execution, for example. This class must only have instances of its subclasses. It is recommendable to comment (rdfs:comment) the scope of the virtual link set.</para>
    /// labels<para>Virtual link set</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#VirtualLinkSet">http://purl.org/query/voidext#VirtualLinkSet</seealso>
    let VirtualLinkSet = Prefixed_Name(voidext, "VirtualLinkSet") |> PrefixedName
    /// <summary>
    ///   <para>voidext:intersectAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to assign exactly either two shared instance sets (voidext:SharedInstanceSet) or two link sets (void:Linkset) to compose a complex link set (voidext:ComplexLinkSet). For each void:Linkset, either the subject or the object node of its link predicate intersects an RDF node of the link predicate from the other link set. In other words, the subject xor the object of a link predicate matches the subject xor the object of the other link predicate, where xor is the exclusive or. These link predicates must be from different datasets.</para>
    /// labels<para>intersects at</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#intersectAt">http://purl.org/query/voidext#intersectAt</seealso>
    let intersectAt = Prefixed_Name(voidext, "intersectAt") |> PrefixedName

    /// <summary>
    ///   <para>voidext:LINK_SHAREDINSTANCE_SET</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/query/voidext#LINK_SHAREDINSTANCE_SET">http://purl.org/query/voidext#LINK_SHAREDINSTANCE_SET</seealso>
    let LINK_SHAREDINSTANCE_SET =
        Prefixed_Name(voidext, "LINK_SHAREDINSTANCE_SET") |> PrefixedName

    /// <summary>
    ///   <para>voidext:LinkSetIntersection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The possible intersection types between the RDF graph nodes in different void:Dataset(s) (i.e. either the subject or the object node of a link predicate). The instances of this class are exclusively voidext:OBJECT_OBJECT, voidext:OBJECT_SUBJECT, and voidext:SUBJECT_SUBJECT.</para>
    /// labels<para>Linkset intersection</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#LinkSetIntersection">http://purl.org/query/voidext#LinkSetIntersection</seealso>
    let LinkSetIntersection =
        Prefixed_Name(voidext, "LinkSetIntersection") |> PrefixedName

    /// <summary>
    ///   <para>voidext:SimpleLinkSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A simple link set must be a linkset that does not target another linkset (i.e. it has exactly one link predicate) or a set with exactly the same shared instances of the same type (i.e. class) in both datasets. The instances of this class must be also instances of either void:Linkset or voidext:SharedInstanceSet.</para>
    /// labels<para>Simple link set</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#SimpleLinkSet">http://purl.org/query/voidext#SimpleLinkSet</seealso>
    let SimpleLinkSet = Prefixed_Name(voidext, "SimpleLinkSet") |> PrefixedName
    /// <summary>
    ///   <para>voidext:MODIFIED_TARGET_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:ProvenanceStatement</para>
    ///
    /// labels<para>modified void:target domain</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#MODIFIED_TARGET_1">http://purl.org/query/voidext#MODIFIED_TARGET_1</seealso>
    let MODIFIED_TARGET_1 = Prefixed_Name(voidext, "MODIFIED_TARGET_1") |> PrefixedName
    /// <summary>
    ///   <para>voidext:SUBJECT_SUBJECT</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidext:LinkSetIntersection</para>
    ///   <para>The intersection between two void:Dataset(s) (i.e. knowledge graphs) occurs at the subject node in both datasets.</para>
    /// labels<para>Subject-subject intersection</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#SUBJECT_SUBJECT">http://purl.org/query/voidext#SUBJECT_SUBJECT</seealso>
    let SUBJECT_SUBJECT = Prefixed_Name(voidext, "SUBJECT_SUBJECT") |> PrefixedName
    /// <summary>
    ///   <para>voidext:OBJECT_OBJECT</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidext:LinkSetIntersection</para>
    ///   <para>The intersection between two void:Dataset(s) (i.e. knowledge graphs) occurs at the object node in both datasets.</para>
    /// labels<para>Object-object intersection</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#OBJECT_OBJECT">http://purl.org/query/voidext#OBJECT_OBJECT</seealso>
    let OBJECT_OBJECT = Prefixed_Name(voidext, "OBJECT_OBJECT") |> PrefixedName
    /// <summary>
    ///   <para>voidext:SUBJECT_OBJECT</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidext:LinkSetIntersection</para>
    ///   <para>The intersection between two void:Dataset(s) (i.e. knowledge graphs) occurs at the object node of one data set (graph) and the subject node of another data set (graph).</para>
    /// labels<para>Subject-object intersection</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#SUBJECT_OBJECT">http://purl.org/query/voidext#SUBJECT_OBJECT</seealso>
    let SUBJECT_OBJECT = Prefixed_Name(voidext, "SUBJECT_OBJECT") |> PrefixedName
    /// <summary>
    ///   <para>voidext:isSubsetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is subset of</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#isSubsetOf">http://purl.org/query/voidext#isSubsetOf</seealso>
    let isSubsetOf = Prefixed_Name(voidext, "isSubsetOf") |> PrefixedName

    /// <summary>
    ///   <para>voidext:hasPerformanceMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property assings the performance of the virtual link set, for example, in terms of recall and precision. The values to be assigned (property range) are represented with the ontology MEX Performance Ontology.</para>
    /// labels<para>has performance measure</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#hasPerformanceMeasure">http://purl.org/query/voidext#hasPerformanceMeasure</seealso>
    let hasPerformanceMeasure =
        Prefixed_Name(voidext, "hasPerformanceMeasure") |> PrefixedName

    /// <summary>
    ///   <para>voidext:intersectionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property assigns the intersection type of two RDF triples in different datasets (void:Dataset). In other words, if the intersection occurs at the subject xor the object node of a link predicate.</para>
    /// labels<para>intersection type</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#intersectionType">http://purl.org/query/voidext#intersectionType</seealso>
    let intersectionType = Prefixed_Name(voidext, "intersectionType") |> PrefixedName

    /// <summary>
    ///   <para>voidext:linkPredicateDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The link predicate's subject type (i.e. class), if any. Moreover, in the case of a void:Linkset that is classified as a simple link set (voidext:SimpleLinkSet), if the two datasets are linked through the link predicate's subject then the link predicate domain must be specified. Indeed, this subject matches a second resource in an external dataset. Therefore, the type of this second resource is asserted as the link predicate domain.</para>
    /// labels<para>link predicate domain</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#linkPredicateDomain">http://purl.org/query/voidext#linkPredicateDomain</seealso>
    let linkPredicateDomain =
        Prefixed_Name(voidext, "linkPredicateDomain") |> PrefixedName

    /// <summary>
    ///   <para>voidext:linkPredicateRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The link predicate's object type (i.e. class), if any. Moreover, in the case of a void:Linkset that is not classified as a simple link set, if the two datasets are linked through the link predicate's object then the link predicate range must be specified. Indeed, this object matches a second resource in an external dataset. Therefore, the type of this second resource is asserted as the link predicate range.</para>
    /// labels<para>link predicate range</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#linkPredicateRange">http://purl.org/query/voidext#linkPredicateRange</seealso>
    let linkPredicateRange =
        Prefixed_Name(voidext, "linkPredicateRange") |> PrefixedName

    /// <summary>
    ///   <para>voidext:resourceMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The preprocessing of a resource (i.e. IRI or literal) in a source void:Dataset in order
    /// to match another resource in the target void:Dataset. A resource is either the subject or the
    /// object of an RDF triple. The resource preprocessing (i.e. the resource mapping)
    /// must be defined with the SPARQL language by mainly using SPARQL built-ins for assignments
    /// (e.g. BIND), and expression and testing values (e.g. IF and FILTER). BIND is used to assign
    /// the output of a function.</para>
    /// labels<para>resource mapped with</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#resourceMapping">http://purl.org/query/voidext#resourceMapping</seealso>
    let resourceMapping = Prefixed_Name(voidext, "resourceMapping") |> PrefixedName

    /// <summary>
    ///   <para>voidext:recommendedMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If more than one mapping is defined in the different void:Linkset(s) that are part of a voidext:ComplexLinkSet, one of the resource mappings may be recommended by asserting this property. The recommended mapping is the one stated to the void:Linkset assigned as the value of this property. If no mapping is explicitly recommended, solely one of them must arbitrarily be applied to establish a virtual link. At most one mapping function can be defined either per linkset or per shared instance set.</para>
    /// labels<para>recommended mapping from</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#recommendedMapping">http://purl.org/query/voidext#recommendedMapping</seealso>
    let recommendedMapping =
        Prefixed_Name(voidext, "recommendedMapping") |> PrefixedName

    /// <summary>
    ///   <para>voidext:sharedInstanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property assings the type (i.e. class) of the shared instances from a given void:Dataset. Shared instances implies equivalent or similar instance IRIs that belong to different datasets.</para>
    /// labels<para>shared instance type</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#sharedInstanceType">http://purl.org/query/voidext#sharedInstanceType</seealso>
    let sharedInstanceType =
        Prefixed_Name(voidext, "sharedInstanceType") |> PrefixedName

    /// <summary>
    ///   <para>voidext:supportFederatedQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property should be used to explicitly assert that a void:Dataset supports SPARQL 1.1. federated queries to be able to access the dataset with the SERVICE keyword and perform federated join queries.</para>
    /// labels<para>supports SPARQL 1.1 federated query</para></remarks>
    /// <seealso href="http://purl.org/query/voidext#supportFederatedQuery">http://purl.org/query/voidext#supportFederatedQuery</seealso>
    let supportFederatedQuery =
        Prefixed_Name(voidext, "supportFederatedQuery") |> PrefixedName
