namespace http.www.w3.org.ns.ldp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ldp =
    let _namespace_iri = Namespace_Iri ldp |> NamespaceIRI
    /// <summary>
    ///   <para>ldp:BasicContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An LDPC that uses a predefined predicate to simply link to its contained resources.</para>
    /// labels<para>BasicContainer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#BasicContainer">http://www.w3.org/ns/ldp#BasicContainer</seealso>
    let BasicContainer = Prefixed_Name(ldp, "BasicContainer") |> PrefixedName
    /// <summary>
    ///   <para>ldp:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Linked Data Platform RDF Source (LDP-RS) that also conforms to additional patterns and conventions for managing membership. Readers should refer to the specification defining this ontology for the list of behaviors associated with it.</para>
    /// labels<para>Container</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#Container">http://www.w3.org/ns/ldp#Container</seealso>
    let Container = Prefixed_Name(ldp, "Container") |> PrefixedName
    /// <summary>
    ///   <para>ldp:Descending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Individual</para>
    ///   <para>Descending order.</para>
    /// labels<para>Descending</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#Descending">http://www.w3.org/ns/ldp#Descending</seealso>
    let Descending = Prefixed_Name(ldp, "Descending") |> PrefixedName
    /// <summary>
    ///   <para>ldp:IndirectContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An LDPC that has the flexibility of choosing what form the membership triples take.</para>
    /// labels<para>IndirectContainer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#IndirectContainer">http://www.w3.org/ns/ldp#IndirectContainer</seealso>
    let IndirectContainer = Prefixed_Name(ldp, "IndirectContainer") |> PrefixedName
    /// <summary>
    ///   <para>ldp:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A HTTP-addressable resource whose lifecycle is managed by a LDP server.</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#Resource">http://www.w3.org/ns/ldp#Resource</seealso>
    let Resource = Prefixed_Name(ldp, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>ldp:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>URI signifying that the resource is an in-sequence page resource, as defined by LDP Paging.  Typically used on Link rel='type' response headers.</para>
    /// labels<para>Page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#Page">http://www.w3.org/ns/ldp#Page</seealso>
    let Page = Prefixed_Name(ldp, "Page") |> PrefixedName
    /// <summary>
    ///   <para>ldp:PreferContainment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Individual</para>
    ///   <para>URI identifying a LDPC's containment triples, for example to allow clients to express interest in receiving them.</para>
    /// labels<para>PreferContainment</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#PreferContainment">http://www.w3.org/ns/ldp#PreferContainment</seealso>
    let PreferContainment = Prefixed_Name(ldp, "PreferContainment") |> PrefixedName

    /// <summary>
    ///   <para>ldp:PreferMinimalContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Individual</para>
    ///   <para>URI identifying the subset of a LDPC's triples present in an empty LDPC, for example to allow clients to express interest in receiving them.  Currently this excludes containment and membership triples, but in the future other exclusions might be added.  This definition is written to automatically exclude those new classes of triples.</para>
    /// labels<para>PreferMinimalContainer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#PreferMinimalContainer">http://www.w3.org/ns/ldp#PreferMinimalContainer</seealso>
    let PreferMinimalContainer =
        Prefixed_Name(ldp, "PreferMinimalContainer") |> PrefixedName

    /// <summary>
    ///   <para>ldp:PreferMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Individual</para>
    ///   <para>URI identifying a LDPC's membership triples, for example to allow clients to express interest in receiving them.</para>
    /// labels<para>PreferMembership</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#PreferMembership">http://www.w3.org/ns/ldp#PreferMembership</seealso>
    let PreferMembership = Prefixed_Name(ldp, "PreferMembership") |> PrefixedName
    /// <summary>
    ///   <para>ldp:isMemberOfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates which predicate is used in membership triples, and that the membership triple pattern is &lt; member-URI , object-of-isMemberOfRelation, membership-constant-URI &gt;.</para>
    /// labels<para>isMemmberOfRelation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#isMemberOfRelation">http://www.w3.org/ns/ldp#isMemberOfRelation</seealso>
    let isMemberOfRelation = Prefixed_Name(ldp, "isMemberOfRelation") |> PrefixedName
    /// <summary>
    ///   <para>ldp:pageSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Link to a page sequence resource, as defined by LDP Paging.  Typically used to communicate the sorting criteria used to allocate LDPC members to pages.</para>
    /// labels<para>Page</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#pageSequence">http://www.w3.org/ns/ldp#pageSequence</seealso>
    let pageSequence = Prefixed_Name(ldp, "pageSequence") |> PrefixedName
    /// <summary>
    ///   <para>ldp:pageSortCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Link to the list of sorting criteria used by the server in a representation.  Typically used on Link response headers as an extension link relation URI in the rel= parameter.</para>
    /// labels<para>pageSortCriteria</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#pageSortCriteria">http://www.w3.org/ns/ldp#pageSortCriteria</seealso>
    let pageSortCriteria = Prefixed_Name(ldp, "pageSortCriteria") |> PrefixedName
    /// <summary>
    ///   <para>ldp:Ascending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Individual</para>
    ///   <para>Ascending order.</para>
    /// labels<para>Ascending</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#Ascending">http://www.w3.org/ns/ldp#Ascending</seealso>
    let Ascending = Prefixed_Name(ldp, "Ascending") |> PrefixedName
    /// <summary>
    ///   <para>ldp:RDFSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Linked Data Platform Resource (LDPR) whose state is represented as RDF.</para>
    /// labels<para>RDFSource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#RDFSource">http://www.w3.org/ns/ldp#RDFSource</seealso>
    let RDFSource = Prefixed_Name(ldp, "RDFSource") |> PrefixedName
    /// <summary>
    ///   <para>ldp:DirectContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An LDPC that is similar to a LDP-DC but it allows an indirection with the ability to list as member a resource, such as a URI representing a real-world object, that is different from the resource that is created.</para>
    /// labels<para>DirectContainer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#DirectContainer">http://www.w3.org/ns/ldp#DirectContainer</seealso>
    let DirectContainer = Prefixed_Name(ldp, "DirectContainer") |> PrefixedName
    /// <summary>
    ///   <para>ldp:NonRDFSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Linked Data Platform Resource (LDPR) whose state is NOT represented as RDF.</para>
    /// labels<para>NonRDFSource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#NonRDFSource">http://www.w3.org/ns/ldp#NonRDFSource</seealso>
    let NonRDFSource = Prefixed_Name(ldp, "NonRDFSource") |> PrefixedName
    /// <summary>
    ///   <para>ldp:MemberSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Individual</para>
    ///   <para>Used to indicate default and typical behavior for ldp:insertedContentRelation, where the member-URI value in the membership triple added when a creation request is successful is the URI assigned to the newly created resource.</para>
    /// labels<para>MemberSubject</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#MemberSubject">http://www.w3.org/ns/ldp#MemberSubject</seealso>
    let MemberSubject = Prefixed_Name(ldp, "MemberSubject") |> PrefixedName
    /// <summary>
    ///   <para>ldp:PageSortCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Element in the list of sorting criteria used by the server to assign container members to pages.</para>
    /// labels<para>PageSortCriterion</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#PageSortCriterion">http://www.w3.org/ns/ldp#PageSortCriterion</seealso>
    let PageSortCriterion = Prefixed_Name(ldp, "PageSortCriterion") |> PrefixedName

    /// <summary>
    ///   <para>ldp:PreferEmptyContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Individual</para>
    ///   <para>Archaic alias for ldp:PreferMinimalContainer</para>
    /// labels<para>PreferEmptyContainer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#PreferEmptyContainer">http://www.w3.org/ns/ldp#PreferEmptyContainer</seealso>
    let PreferEmptyContainer =
        Prefixed_Name(ldp, "PreferEmptyContainer") |> PrefixedName

    /// <summary>
    ///   <para>ldp:hasMemberRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates which predicate is used in membership triples, and that the membership triple pattern is &lt; membership-constant-URI , object-of-hasMemberRelation, member-URI &gt;.</para>
    /// labels<para>hasMemberRelation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#hasMemberRelation">http://www.w3.org/ns/ldp#hasMemberRelation</seealso>
    let hasMemberRelation = Prefixed_Name(ldp, "hasMemberRelation") |> PrefixedName
    /// <summary>
    ///   <para>ldp:membershipResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the membership-constant-URI in a membership triple.  Depending upon the membership triple pattern a container uses, as indicated by the presence of ldp:hasMemberRelation or ldp:isMemberOfRelation, the membership-constant-URI might occupy either the subject or object position in membership triples.</para>
    /// labels<para>membershipResource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#membershipResource">http://www.w3.org/ns/ldp#membershipResource</seealso>
    let membershipResource = Prefixed_Name(ldp, "membershipResource") |> PrefixedName
    /// <summary>
    ///   <para>ldp:pageSortCollation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The collation used to order the members across pages in a page sequence when comparing strings.</para>
    /// labels<para>pageSortCollation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#pageSortCollation">http://www.w3.org/ns/ldp#pageSortCollation</seealso>
    let pageSortCollation = Prefixed_Name(ldp, "pageSortCollation") |> PrefixedName
    /// <summary>
    ///   <para>ldp:pageSortOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ascending/descending/etc order used to order the members across pages in a page sequence.</para>
    /// labels<para>pageSortOrder</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#pageSortOrder">http://www.w3.org/ns/ldp#pageSortOrder</seealso>
    let pageSortOrder = Prefixed_Name(ldp, "pageSortOrder") |> PrefixedName
    /// <summary>
    ///   <para>ldp:constrainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a resource with constraints that the server requires requests like creation and update to conform to.</para>
    /// labels<para>constrainedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#constrainedBy">http://www.w3.org/ns/ldp#constrainedBy</seealso>
    let constrainedBy = Prefixed_Name(ldp, "constrainedBy") |> PrefixedName
    /// <summary>
    ///   <para>ldp:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a container with resources created through the container.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#contains">http://www.w3.org/ns/ldp#contains</seealso>
    let contains = Prefixed_Name(ldp, "contains") |> PrefixedName

    /// <summary>
    ///   <para>ldp:insertedContentRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates which triple in a creation request should be used as the member-URI value in the membership triple added when the creation request is successful.</para>
    /// labels<para>insertedContentRelation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#insertedContentRelation">http://www.w3.org/ns/ldp#insertedContentRelation</seealso>
    let insertedContentRelation =
        Prefixed_Name(ldp, "insertedContentRelation") |> PrefixedName

    /// <summary>
    ///   <para>ldp:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>LDP servers should use this predicate as the membership predicate if there is no obvious predicate from an application vocabulary to use.</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#member">http://www.w3.org/ns/ldp#member</seealso>
    let member_ = Prefixed_Name(ldp, "member") |> PrefixedName
    /// <summary>
    ///   <para>ldp:pageSortPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Predicate used to specify the order of the members across a page sequence's in-sequence page resources; it asserts nothing about the order of members in the representation of a single page.</para>
    /// labels<para>pageSortPredicate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#pageSortPredicate">http://www.w3.org/ns/ldp#pageSortPredicate</seealso>
    let pageSortPredicate = Prefixed_Name(ldp, "pageSortPredicate") |> PrefixedName
    /// <summary>
    ///   <para>ldp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology provides an informal representation of the concepts and terms as defined in the LDP specification.  Consult the LDP specification for normative reference.</para>
    /// labels<para>W3C Linked Data Platform (LDP)</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ldp#">http://www.w3.org/ns/ldp#</seealso>
    let _prefix_iri = Prefixed_Name(ldp, "") |> PrefixedName
