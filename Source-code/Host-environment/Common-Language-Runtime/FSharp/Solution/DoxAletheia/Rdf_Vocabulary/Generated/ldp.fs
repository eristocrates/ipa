namespace http.www.w3.org.ns.ldp.hash

open DoxAletheia.Rdf_Vocabulary

module ldp =
    let _namespace_name = "http://www.w3.org/ns/ldp#"
    /// <summary>
    /// Ascending order.
    /// <see href="http://www.w3.org/ns/ldp#Ascending"></see></summary>
    let Ascending = Namespaced_IRI.parse _namespace_name "Ascending" |> NamespacedName

    /// <summary>
    /// An LDPC that uses a predefined predicate to simply link to its contained resources.
    /// <see href="http://www.w3.org/ns/ldp#BasicContainer"></see></summary>
    let BasicContainer =
        Namespaced_IRI.parse _namespace_name "BasicContainer" |> NamespacedName

    /// <summary>
    /// A Linked Data Platform RDF Source (LDP-RS) that also conforms to additional patterns and conventions for managing membership. Readers should refer to the specification defining this ontology for the list of behaviors associated with it.
    /// <see href="http://www.w3.org/ns/ldp#Container"></see></summary>
    let Container = Namespaced_IRI.parse _namespace_name "Container" |> NamespacedName
    /// <summary>
    /// A Linked Data Platform Resource (LDPR) whose state is represented as RDF.
    /// <see href="http://www.w3.org/ns/ldp#RDFSource"></see></summary>
    let RDFSource = Namespaced_IRI.parse _namespace_name "RDFSource" |> NamespacedName
    /// <summary>
    /// Descending order.
    /// <see href="http://www.w3.org/ns/ldp#Descending"></see></summary>
    let Descending = Namespaced_IRI.parse _namespace_name "Descending" |> NamespacedName

    /// <summary>
    /// An LDPC that is similar to a LDP-DC but it allows an indirection with the ability to list as member a resource, such as a URI representing a real-world object, that is different from the resource that is created.
    /// <see href="http://www.w3.org/ns/ldp#DirectContainer"></see></summary>
    let DirectContainer =
        Namespaced_IRI.parse _namespace_name "DirectContainer" |> NamespacedName

    /// <summary>
    /// An LDPC that has the flexibility of choosing what form the membership triples take.
    /// <see href="http://www.w3.org/ns/ldp#IndirectContainer"></see></summary>
    let IndirectContainer =
        Namespaced_IRI.parse _namespace_name "IndirectContainer" |> NamespacedName

    /// <summary>
    /// Used to indicate default and typical behavior for ldp:insertedContentRelation, where the member-URI value in the membership triple added when a creation request is successful is the URI assigned to the newly created resource.
    /// <see href="http://www.w3.org/ns/ldp#MemberSubject"></see></summary>
    let MemberSubject =
        Namespaced_IRI.parse _namespace_name "MemberSubject" |> NamespacedName

    /// <summary>
    /// A Linked Data Platform Resource (LDPR) whose state is NOT represented as RDF.
    /// <see href="http://www.w3.org/ns/ldp#NonRDFSource"></see></summary>
    let NonRDFSource =
        Namespaced_IRI.parse _namespace_name "NonRDFSource" |> NamespacedName

    /// <summary>
    /// A HTTP-addressable resource whose lifecycle is managed by a LDP server.
    /// <see href="http://www.w3.org/ns/ldp#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// URI signifying that the resource is an in-sequence page resource, as defined by LDP Paging.  Typically used on Link rel='type' response headers.
    /// <see href="http://www.w3.org/ns/ldp#Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName

    /// <summary>
    /// Element in the list of sorting criteria used by the server to assign container members to pages.
    /// <see href="http://www.w3.org/ns/ldp#PageSortCriterion"></see></summary>
    let PageSortCriterion =
        Namespaced_IRI.parse _namespace_name "PageSortCriterion" |> NamespacedName

    /// <summary>
    /// URI identifying a LDPC's containment triples, for example to allow clients to express interest in receiving them.
    /// <see href="http://www.w3.org/ns/ldp#PreferContainment"></see></summary>
    let PreferContainment =
        Namespaced_IRI.parse _namespace_name "PreferContainment" |> NamespacedName

    /// <summary>
    /// Archaic alias for ldp:PreferMinimalContainer
    /// <see href="http://www.w3.org/ns/ldp#PreferEmptyContainer"></see></summary>
    let PreferEmptyContainer =
        Namespaced_IRI.parse _namespace_name "PreferEmptyContainer" |> NamespacedName

    /// <summary>
    /// URI identifying the subset of a LDPC's triples present in an empty LDPC, for example to allow clients to express interest in receiving them.  Currently this excludes containment and membership triples, but in the future other exclusions might be added.  This definition is written to automatically exclude those new classes of triples.
    /// <see href="http://www.w3.org/ns/ldp#PreferMinimalContainer"></see></summary>
    let PreferMinimalContainer =
        Namespaced_IRI.parse _namespace_name "PreferMinimalContainer" |> NamespacedName

    /// <summary>
    /// URI identifying a LDPC's membership triples, for example to allow clients to express interest in receiving them.
    /// <see href="http://www.w3.org/ns/ldp#PreferMembership"></see></summary>
    let PreferMembership =
        Namespaced_IRI.parse _namespace_name "PreferMembership" |> NamespacedName

    /// <summary>
    /// Links a resource with constraints that the server requires requests like creation and update to conform to.
    /// <see href="http://www.w3.org/ns/ldp#constrainedBy"></see></summary>
    let constrainedBy =
        Namespaced_IRI.parse _namespace_name "constrainedBy" |> NamespacedName

    /// <summary>
    /// Links a container with resources created through the container.
    /// <see href="http://www.w3.org/ns/ldp#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// Indicates which predicate is used in membership triples, and that the membership triple pattern is &lt; membership-constant-URI , object-of-hasMemberRelation, member-URI &gt;.
    /// <see href="http://www.w3.org/ns/ldp#hasMemberRelation"></see></summary>
    let hasMemberRelation =
        Namespaced_IRI.parse _namespace_name "hasMemberRelation" |> NamespacedName

    /// <summary>
    /// Indicates which triple in a creation request should be used as the member-URI value in the membership triple added when the creation request is successful.
    /// <see href="http://www.w3.org/ns/ldp#insertedContentRelation"></see></summary>
    let insertedContentRelation =
        Namespaced_IRI.parse _namespace_name "insertedContentRelation" |> NamespacedName

    /// <summary>
    /// Indicates which predicate is used in membership triples, and that the membership triple pattern is &lt; member-URI , object-of-isMemberOfRelation, membership-constant-URI &gt;.
    /// <see href="http://www.w3.org/ns/ldp#isMemberOfRelation"></see></summary>
    let isMemberOfRelation =
        Namespaced_IRI.parse _namespace_name "isMemberOfRelation" |> NamespacedName

    /// <summary>
    /// LDP servers should use this predicate as the membership predicate if there is no obvious predicate from an application vocabulary to use.
    /// <see href="http://www.w3.org/ns/ldp#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// Indicates the membership-constant-URI in a membership triple.  Depending upon the membership triple pattern a container uses, as indicated by the presence of ldp:hasMemberRelation or ldp:isMemberOfRelation, the membership-constant-URI might occupy either the subject or object position in membership triples.
    /// <see href="http://www.w3.org/ns/ldp#membershipResource"></see></summary>
    let membershipResource =
        Namespaced_IRI.parse _namespace_name "membershipResource" |> NamespacedName

    /// <summary>
    /// Link to a page sequence resource, as defined by LDP Paging.  Typically used to communicate the sorting criteria used to allocate LDPC members to pages.
    /// <see href="http://www.w3.org/ns/ldp#pageSequence"></see></summary>
    let pageSequence =
        Namespaced_IRI.parse _namespace_name "pageSequence" |> NamespacedName

    /// <summary>
    /// The collation used to order the members across pages in a page sequence when comparing strings.
    /// <see href="http://www.w3.org/ns/ldp#pageSortCollation"></see></summary>
    let pageSortCollation =
        Namespaced_IRI.parse _namespace_name "pageSortCollation" |> NamespacedName

    /// <summary>
    /// Link to the list of sorting criteria used by the server in a representation.  Typically used on Link response headers as an extension link relation URI in the rel= parameter.
    /// <see href="http://www.w3.org/ns/ldp#pageSortCriteria"></see></summary>
    let pageSortCriteria =
        Namespaced_IRI.parse _namespace_name "pageSortCriteria" |> NamespacedName

    /// <summary>
    /// The ascending/descending/etc order used to order the members across pages in a page sequence.
    /// <see href="http://www.w3.org/ns/ldp#pageSortOrder"></see></summary>
    let pageSortOrder =
        Namespaced_IRI.parse _namespace_name "pageSortOrder" |> NamespacedName

    /// <summary>
    /// Predicate used to specify the order of the members across a page sequence's in-sequence page resources; it asserts nothing about the order of members in the representation of a single page.
    /// <see href="http://www.w3.org/ns/ldp#pageSortPredicate"></see></summary>
    let pageSortPredicate =
        Namespaced_IRI.parse _namespace_name "pageSortPredicate" |> NamespacedName
