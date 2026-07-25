namespace http.www.bl.uk.schemas.bibliographic.blterms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module blt =
    let _namespace_iri = Namespace_Iri blt |> NamespaceIRI
    /// <summary>
    ///   <para>blt:FamilyConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A family expressed as a concept.</para>
    /// labels<para>Family Concept</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#FamilyConcept">http://www.bl.uk/schemas/bibliographic/blterms#FamilyConcept</seealso>
    let FamilyConcept = Prefixed_Name(blt, "FamilyConcept") |> PrefixedName
    /// <summary>
    ///   <para>blt:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A family</para>
    /// labels<para>Family</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#Family">http://www.bl.uk/schemas/bibliographic/blterms#Family</seealso>
    let Family = Prefixed_Name(blt, "Family") |> PrefixedName
    /// <summary>
    ///   <para>blt:PersonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A person expressed as a concept.</para>
    /// labels<para>Person Concept</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#PersonConcept">http://www.bl.uk/schemas/bibliographic/blterms#PersonConcept</seealso>
    let PersonConcept = Prefixed_Name(blt, "PersonConcept") |> PrefixedName
    /// <summary>
    ///   <para>blt:PlaceConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A place expressed as a concept.</para>
    /// labels<para>Place Concept</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#PlaceConcept">http://www.bl.uk/schemas/bibliographic/blterms#PlaceConcept</seealso>
    let PlaceConcept = Prefixed_Name(blt, "PlaceConcept") |> PrefixedName
    /// <summary>
    ///   <para>blt:OrganizationConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An organization expressed as a concept.</para>
    /// labels<para>Organization Concept</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#OrganizationConcept">http://www.bl.uk/schemas/bibliographic/blterms#OrganizationConcept</seealso>
    let OrganizationConcept = Prefixed_Name(blt, "OrganizationConcept") |> PrefixedName
    /// <summary>
    ///   <para>blt:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#">http://www.bl.uk/schemas/bibliographic/blterms#</seealso>
    let _prefix_iri = Prefixed_Name(blt, "") |> PrefixedName
    /// <summary>
    ///   <para>blt:PublicationEndEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An event which is the end of the publication of a resource.</para>
    /// labels<para>Publication event end</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEndEvent">http://www.bl.uk/schemas/bibliographic/blterms#PublicationEndEvent</seealso>
    let PublicationEndEvent = Prefixed_Name(blt, "PublicationEndEvent") |> PrefixedName
    /// <summary>
    ///   <para>blt:TopicDDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A Dewey Decimal Classification number (as found in British Library cataloguing data)</para>
    /// labels<para>Dewey Decimal Classification (DDC) number</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#TopicDDC">http://www.bl.uk/schemas/bibliographic/blterms#TopicDDC</seealso>
    let TopicDDC = Prefixed_Name(blt, "TopicDDC") |> PrefixedName
    /// <summary>
    ///   <para>blt:hasContributedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>the inverse property of dct:contributor</para>
    /// labels<para>has contributed to</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#hasContributedTo">http://www.bl.uk/schemas/bibliographic/blterms#hasContributedTo</seealso>
    let hasContributedTo = Prefixed_Name(blt, "hasContributedTo") |> PrefixedName
    /// <summary>
    ///   <para>blt:hasCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>the inverse property of dct:creator</para>
    /// labels<para>has created</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#hasCreated">http://www.bl.uk/schemas/bibliographic/blterms#hasCreated</seealso>
    let hasCreated = Prefixed_Name(blt, "hasCreated") |> PrefixedName
    /// <summary>
    ///   <para>blt:publicationEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The end of the publication event of a resource.</para>
    /// labels<para>Publication end</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#publicationEnd">http://www.bl.uk/schemas/bibliographic/blterms#publicationEnd</seealso>
    let publicationEnd = Prefixed_Name(blt, "publicationEnd") |> PrefixedName

    /// <summary>
    ///   <para>blt:PublicationStartEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An event which is the start of the publication of a resource.</para>
    /// labels<para>Publication event start</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationStartEvent">http://www.bl.uk/schemas/bibliographic/blterms#PublicationStartEvent</seealso>
    let PublicationStartEvent =
        Prefixed_Name(blt, "PublicationStartEvent") |> PrefixedName

    /// <summary>
    ///   <para>blt:bnb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The BNB number associated with this resource</para>
    /// labels<para>BNB number</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#bnb">http://www.bl.uk/schemas/bibliographic/blterms#bnb</seealso>
    let bnb = Prefixed_Name(blt, "bnb") |> PrefixedName
    /// <summary>
    ///   <para>blt:publicationStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The start of the publication event of a resource.</para>
    /// labels<para>Publication start</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#publicationStart">http://www.bl.uk/schemas/bibliographic/blterms#publicationStart</seealso>
    let publicationStart = Prefixed_Name(blt, "publicationStart") |> PrefixedName
    /// <summary>
    ///   <para>blt:publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The publication event of a resource.</para>
    /// labels<para>Publication</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#publication">http://www.bl.uk/schemas/bibliographic/blterms#publication</seealso>
    let publication = Prefixed_Name(blt, "publication") |> PrefixedName
    /// <summary>
    ///   <para>blt:PublicationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An event which is the publication of a resource.</para>
    /// labels<para>Publication event</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEvent">http://www.bl.uk/schemas/bibliographic/blterms#PublicationEvent</seealso>
    let PublicationEvent = Prefixed_Name(blt, "PublicationEvent") |> PrefixedName
    /// <summary>
    ///   <para>blt:TopicLCSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A Library of Congress Subject Heading (LCSH) (as found in British Library cataloguing data)</para>
    /// labels<para>Library of Congress Subject Heading (LCSH)</para></remarks>
    /// <seealso href="http://www.bl.uk/schemas/bibliographic/blterms#TopicLCSH">http://www.bl.uk/schemas/bibliographic/blterms#TopicLCSH</seealso>
    let TopicLCSH = Prefixed_Name(blt, "TopicLCSH") |> PrefixedName
