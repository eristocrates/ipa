namespace http.purl.org.query.voidext.hash

open DoxAletheia

module voidext =
    let _namespace_name = "http://purl.org/query/voidext#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// It is a complex virtual link set. A complex link set is composed of exactly two link sets xor two shared instance sets where xor is the exclusive or. For example, two link sets that intersects at some graph node (e.g. the object nodes of link predicates).
    /// <see href="http://purl.org/query/voidext#ComplexLinkSet"></see></summary>
    let ComplexLinkSet = _prefix "ComplexLinkSet"
    /// <summary>
    /// This property must only assign one standard SPARQL query per category (i.e. subclass) of VirtualLinkSet to retrieve the formal definition of linkset (i.e. query projection) as presented in the voidext specification.
    /// <see href="http://purl.org/query/voidext#queryLinkset"></see></summary>
    let queryLinkset = _prefix "queryLinkset"
    /// <summary>
    /// This property must only assign one standard SPARQL query per category (i.e. subclass) of VirtualLinkSet to retrieve the formal definition of shared instance set (i.e. query projection) as presented in the voidext specification.
    /// <see href="http://purl.org/query/voidext#querySharedInstanceSet"></see></summary>
    let querySharedInstanceSet = _prefix "querySharedInstanceSet"
    /// <summary>
    /// A set of virtual links between two datasets. A virtual link is a connection between resources such as literals and instances with some commonality. Each of these resources is from a different RDF dataset. A resource mapping can be also considered when defining common resources between datasets. For example, the datasets uses different prefix namespaces for similar instances in a given domain scope. A virtual link can be interpreted as an intersection data point between two datasets. In addition, a virtual link is not concretely stored. The link may be physically established during a federated query execution, for example. This class must only have instances of its subclasses. It is recommendable to comment (rdfs:comment) the scope of the virtual link set.
    /// <see href="http://purl.org/query/voidext#VirtualLinkSet"></see></summary>
    let VirtualLinkSet = _prefix "VirtualLinkSet"
    /// <summary>
    /// A shared instance set between exactly two datasets. For example, two datasets that contain the same OWL/RDFS class instances.
    /// <see href="http://purl.org/query/voidext#SharedInstanceSet"></see></summary>
    let SharedInstanceSet = _prefix "SharedInstanceSet"
    /// <summary>
    /// This property is used to assign exactly either two shared instance sets (voidext:SharedInstanceSet) or two link sets (void:Linkset) to compose a complex link set (voidext:ComplexLinkSet). For each void:Linkset, either the subject or the object node of its link predicate intersects an RDF node of the link predicate from the other link set. In other words, the subject xor the object of a link predicate matches the subject xor the object of the other link predicate, where xor is the exclusive or. These link predicates must be from different datasets.
    /// <see href="http://purl.org/query/voidext#intersectAt"></see></summary>
    let intersectAt = _prefix "intersectAt"
    /// <summary>
    /// A simple link set must be a linkset that does not target another linkset (i.e. it has exactly one link predicate) or a set with exactly the same shared instances of the same type (i.e. class) in both datasets. The instances of this class must be also instances of either void:Linkset or voidext:SharedInstanceSet.
    /// <see href="http://purl.org/query/voidext#SimpleLinkSet"></see></summary>
    let SimpleLinkSet = _prefix "SimpleLinkSet"
    /// <summary>
    ///   <see href="http://purl.org/query/voidext#LINK_SHAREDINSTANCE_SET"></see>
    /// </summary>
    let LINK_SHAREDINSTANCE_SET = _prefix "LINK_SHAREDINSTANCE_SET"
    /// <summary>
    /// The possible intersection types between the RDF graph nodes in different void:Dataset(s) (i.e. either the subject or the object node of a link predicate). The instances of this class are exclusively voidext:OBJECT_OBJECT, voidext:OBJECT_SUBJECT, and voidext:SUBJECT_SUBJECT.
    /// <see href="http://purl.org/query/voidext#LinkSetIntersection"></see></summary>
    let LinkSetIntersection = _prefix "LinkSetIntersection"
    /// <summary>
    ///   <see href="http://purl.org/query/voidext#MODIFIED_TARGET_1"></see>
    /// </summary>
    let MODIFIED_TARGET_1 = _prefix "MODIFIED_TARGET_1"
    /// <summary>
    /// The intersection between two void:Dataset(s) (i.e. knowledge graphs) occurs at the object node in both datasets.
    /// <see href="http://purl.org/query/voidext#OBJECT_OBJECT"></see></summary>
    let OBJECT_OBJECT = _prefix "OBJECT_OBJECT"
    /// <summary>
    /// The intersection between two void:Dataset(s) (i.e. knowledge graphs) occurs at the object node of one data set (graph) and the subject node of another data set (graph).
    /// <see href="http://purl.org/query/voidext#SUBJECT_OBJECT"></see></summary>
    let SUBJECT_OBJECT = _prefix "SUBJECT_OBJECT"
    /// <summary>
    /// The intersection between two void:Dataset(s) (i.e. knowledge graphs) occurs at the subject node in both datasets.
    /// <see href="http://purl.org/query/voidext#SUBJECT_SUBJECT"></see></summary>
    let SUBJECT_SUBJECT = _prefix "SUBJECT_SUBJECT"
    /// <summary>
    ///   <see href="http://purl.org/query/voidext#isSubsetOf"></see>
    /// </summary>
    let isSubsetOf = _prefix "isSubsetOf"
    /// <summary>
    /// This property assings the performance of the virtual link set, for example, in terms of recall and precision. The values to be assigned (property range) are represented with the ontology MEX Performance Ontology.
    /// <see href="http://purl.org/query/voidext#hasPerformanceMeasure"></see></summary>
    let hasPerformanceMeasure = _prefix "hasPerformanceMeasure"
    /// <summary>
    /// This property assigns the intersection type of two RDF triples in different datasets (void:Dataset). In other words, if the intersection occurs at the subject xor the object node of a link predicate.
    /// <see href="http://purl.org/query/voidext#intersectionType"></see></summary>
    let intersectionType = _prefix "intersectionType"
    /// <summary>
    /// The link predicate's subject type (i.e. class), if any. Moreover, in the case of a void:Linkset that is classified as a simple link set (voidext:SimpleLinkSet), if the two datasets are linked through the link predicate's subject then the link predicate domain must be specified. Indeed, this subject matches a second resource in an external dataset. Therefore, the type of this second resource is asserted as the link predicate domain.
    /// <see href="http://purl.org/query/voidext#linkPredicateDomain"></see></summary>
    let linkPredicateDomain = _prefix "linkPredicateDomain"
    /// <summary>
    /// The link predicate's object type (i.e. class), if any. Moreover, in the case of a void:Linkset that is not classified as a simple link set, if the two datasets are linked through the link predicate's object then the link predicate range must be specified. Indeed, this object matches a second resource in an external dataset. Therefore, the type of this second resource is asserted as the link predicate range.
    /// <see href="http://purl.org/query/voidext#linkPredicateRange"></see></summary>
    let linkPredicateRange = _prefix "linkPredicateRange"
    /// <summary>
    /// If more than one mapping is defined in the different void:Linkset(s) that are part of a voidext:ComplexLinkSet, one of the resource mappings may be recommended by asserting this property. The recommended mapping is the one stated to the void:Linkset assigned as the value of this property. If no mapping is explicitly recommended, solely one of them must arbitrarily be applied to establish a virtual link. At most one mapping function can be defined either per linkset or per shared instance set.
    /// <see href="http://purl.org/query/voidext#recommendedMapping"></see></summary>
    let recommendedMapping = _prefix "recommendedMapping"
    /// <summary>
    /// The preprocessing of a resource (i.e. IRI or literal) in a source void:Dataset in order
    /// to match another resource in the target void:Dataset. A resource is either the subject or the
    /// object of an RDF triple. The resource preprocessing (i.e. the resource mapping)
    /// must be defined with the SPARQL language by mainly using SPARQL built-ins for assignments
    /// (e.g. BIND), and expression and testing values (e.g. IF and FILTER). BIND is used to assign
    /// the output of a function.
    /// <see href="http://purl.org/query/voidext#resourceMapping"></see></summary>
    let resourceMapping = _prefix "resourceMapping"
    /// <summary>
    /// This property assings the type (i.e. class) of the shared instances from a given void:Dataset. Shared instances implies equivalent or similar instance IRIs that belong to different datasets.
    /// <see href="http://purl.org/query/voidext#sharedInstanceType"></see></summary>
    let sharedInstanceType = _prefix "sharedInstanceType"
    /// <summary>
    /// This property should be used to explicitly assert that a void:Dataset supports SPARQL 1.1. federated queries to be able to access the dataset with the SERVICE keyword and perform federated join queries.
    /// <see href="http://purl.org/query/voidext#supportFederatedQuery"></see></summary>
    let supportFederatedQuery = _prefix "supportFederatedQuery"
