#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ldp =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/ldp#" "ldp"
    let _namespaceIri = _prefixId.prefix ""
    let Ascending = _prefixId.prefix "Ascending"
    /// <summary>
    ///   <para>rdfs:label : BasicContainer^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An LDPC that uses a predefined predicate to simply link to its contained resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#BasicContainer">ldp:BasicContainer</a>
    /// </summary>
    let BasicContainer = _prefixId.prefix "BasicContainer"
    /// <summary>
    ///   <para>rdfs:label : Container^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A Linked Data Platform RDF Source (LDP-RS) that also conforms to additional patterns and conventions for managing membership. Readers should refer to the specification defining this ontology for the list of behaviors associated with it.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#Container">ldp:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    let Descending = _prefixId.prefix "Descending"
    /// <summary>
    ///   <para>rdfs:label : DirectContainer^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An LDPC that is similar to a LDP-DC but it allows an indirection with the ability to list as member a resource, such as a URI representing a real-world object, that is different from the resource that is created.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#DirectContainer">ldp:DirectContainer</a>
    /// </summary>
    let DirectContainer = _prefixId.prefix "DirectContainer"
    /// <summary>
    ///   <para>rdfs:label : IndirectContainer^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An LDPC that has the flexibility of choosing what form the membership triples take.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#IndirectContainer">ldp:IndirectContainer</a>
    /// </summary>
    let IndirectContainer = _prefixId.prefix "IndirectContainer"
    let MemberSubject = _prefixId.prefix "MemberSubject"
    /// <summary>
    ///   <para>rdfs:label : NonRDFSource^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A Linked Data Platform Resource (LDPR) whose state is NOT represented as RDF.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#NonRDFSource">ldp:NonRDFSource</a>
    /// </summary>
    let NonRDFSource = _prefixId.prefix "NonRDFSource"
    /// <summary>
    ///   <para>rdfs:label : Page^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : URI signifying that the resource is an in-sequence page resource, as defined by LDP Paging.  Typically used on Link rel='type' response headers.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#Page">ldp:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:label : PageSortCriterion^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Element in the list of sorting criteria used by the server to assign container members to pages.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#PageSortCriterion">ldp:PageSortCriterion</a>
    /// </summary>
    let PageSortCriterion = _prefixId.prefix "PageSortCriterion"
    let PreferContainment = _prefixId.prefix "PreferContainment"
    let PreferEmptyContainer = _prefixId.prefix "PreferEmptyContainer"
    let PreferMembership = _prefixId.prefix "PreferMembership"
    let PreferMinimalContainer = _prefixId.prefix "PreferMinimalContainer"
    /// <summary>
    ///   <para>rdfs:label : RDFSource^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A Linked Data Platform Resource (LDPR) whose state is represented as RDF.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#RDFSource">ldp:RDFSource</a>
    /// </summary>
    let RDFSource = _prefixId.prefix "RDFSource"
    /// <summary>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A HTTP-addressable resource whose lifecycle is managed by a LDP server.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#Resource">ldp:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : constrainedBy^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a resource with constraints that the server requires requests like creation and update to conform to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#constrainedBy">ldp:constrainedBy</a>
    /// </summary>
    let constrainedBy = _prefixId.prefix "constrainedBy"
    /// <summary>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a container with resources created through the container.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#contains">ldp:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : hasMemberRelation^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which predicate is used in membership triples, and that the membership triple pattern is &lt; membership-constant-URI , object-of-hasMemberRelation, member-URI &gt;.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#hasMemberRelation">ldp:hasMemberRelation</a>
    /// </summary>
    let hasMemberRelation = _prefixId.prefix "hasMemberRelation"
    /// <summary>
    ///   <para>rdfs:label : insertedContentRelation^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which triple in a creation request should be used as the member-URI value in the membership triple added when the creation request is successful.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#insertedContentRelation">ldp:insertedContentRelation</a>
    /// </summary>
    let insertedContentRelation = _prefixId.prefix "insertedContentRelation"
    /// <summary>
    ///   <para>rdfs:label : isMemmberOfRelation^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which predicate is used in membership triples, and that the membership triple pattern is &lt; member-URI , object-of-isMemberOfRelation, membership-constant-URI &gt;.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#isMemberOfRelation">ldp:isMemberOfRelation</a>
    /// </summary>
    let isMemberOfRelation = _prefixId.prefix "isMemberOfRelation"
    /// <summary>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : LDP servers should use this predicate as the membership predicate if there is no obvious predicate from an application vocabulary to use.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#member">ldp:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : membershipResource^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the membership-constant-URI in a membership triple.  Depending upon the membership triple pattern a container uses, as indicated by the presence of ldp:hasMemberRelation or ldp:isMemberOfRelation, the membership-constant-URI might occupy either the subject or object position in membership triples.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#membershipResource">ldp:membershipResource</a>
    /// </summary>
    let membershipResource = _prefixId.prefix "membershipResource"
    /// <summary>
    ///   <para>rdfs:label : Page^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Link to a page sequence resource, as defined by LDP Paging.  Typically used to communicate the sorting criteria used to allocate LDPC members to pages.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#pageSequence">ldp:pageSequence</a>
    /// </summary>
    let pageSequence = _prefixId.prefix "pageSequence"
    /// <summary>
    ///   <para>rdfs:label : pageSortCollation^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The collation used to order the members across pages in a page sequence when comparing strings.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#pageSortCollation">ldp:pageSortCollation</a>
    /// </summary>
    let pageSortCollation = _prefixId.prefix "pageSortCollation"
    /// <summary>
    ///   <para>rdfs:label : pageSortCriteria^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Link to the list of sorting criteria used by the server in a representation.  Typically used on Link response headers as an extension link relation URI in the rel= parameter.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#pageSortCriteria">ldp:pageSortCriteria</a>
    /// </summary>
    let pageSortCriteria = _prefixId.prefix "pageSortCriteria"
    /// <summary>
    ///   <para>rdfs:label : pageSortOrder^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The ascending/descending/etc order used to order the members across pages in a page sequence.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#pageSortOrder">ldp:pageSortOrder</a>
    /// </summary>
    let pageSortOrder = _prefixId.prefix "pageSortOrder"
    /// <summary>
    ///   <para>rdfs:label : pageSortPredicate^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Predicate used to specify the order of the members across a page sequence's in-sequence page resources; it asserts nothing about the order of members in the representation of a single page.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ldp#pageSortPredicate">ldp:pageSortPredicate</a>
    /// </summary>
    let pageSortPredicate = _prefixId.prefix "pageSortPredicate"
