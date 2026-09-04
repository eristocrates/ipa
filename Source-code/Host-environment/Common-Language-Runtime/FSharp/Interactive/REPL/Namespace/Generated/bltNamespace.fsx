#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module blt =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.bl.uk/schemas/bibliographic/blterms#" "blt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A family</para>
    ///   <para>rdfs:label : Family</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#Family">blt:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:comment : A family expressed as a concept.</para>
    ///   <para>rdfs:label : Family Concept</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#FamilyConcept">blt:FamilyConcept</a>
    /// </summary>
    let FamilyConcept = _prefixId.prefix "FamilyConcept"
    /// <summary>
    ///   <para>rdfs:comment : An organization expressed as a concept.</para>
    ///   <para>rdfs:label : Organization Concept</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#OrganizationConcept">blt:OrganizationConcept</a>
    /// </summary>
    let OrganizationConcept = _prefixId.prefix "OrganizationConcept"
    /// <summary>
    ///   <para>rdfs:comment : A person expressed as a concept.</para>
    ///   <para>rdfs:label : Person Concept</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#PersonConcept">blt:PersonConcept</a>
    /// </summary>
    let PersonConcept = _prefixId.prefix "PersonConcept"
    /// <summary>
    ///   <para>rdfs:comment : A place expressed as a concept.</para>
    ///   <para>rdfs:label : Place Concept</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#PlaceConcept">blt:PlaceConcept</a>
    /// </summary>
    let PlaceConcept = _prefixId.prefix "PlaceConcept"
    /// <summary>
    ///   <para>rdfs:comment : An event which is the end of the publication of a resource.</para>
    ///   <para>rdfs:label : Publication event end</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEndEvent">blt:PublicationEndEvent</a>
    /// </summary>
    let PublicationEndEvent = _prefixId.prefix "PublicationEndEvent"
    /// <summary>
    ///   <para>rdfs:comment : An event which is the publication of a resource.</para>
    ///   <para>rdfs:label : Publication event</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEvent">blt:PublicationEvent</a>
    /// </summary>
    let PublicationEvent = _prefixId.prefix "PublicationEvent"
    /// <summary>
    ///   <para>rdfs:comment : An event which is the start of the publication of a resource.</para>
    ///   <para>rdfs:label : Publication event start</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationStartEvent">blt:PublicationStartEvent</a>
    /// </summary>
    let PublicationStartEvent = _prefixId.prefix "PublicationStartEvent"
    /// <summary>
    ///   <para>rdfs:comment : A Dewey Decimal Classification number (as found in British Library cataloguing data)</para>
    ///   <para>rdfs:label : Dewey Decimal Classification (DDC) number</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#TopicDDC">blt:TopicDDC</a>
    /// </summary>
    let TopicDDC = _prefixId.prefix "TopicDDC"
    /// <summary>
    ///   <para>rdfs:comment : A Library of Congress Subject Heading (LCSH) (as found in British Library cataloguing data)</para>
    ///   <para>rdfs:label : Library of Congress Subject Heading (LCSH)</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#TopicLCSH">blt:TopicLCSH</a>
    /// </summary>
    let TopicLCSH = _prefixId.prefix "TopicLCSH"
    /// <summary>
    ///   <para>rdfs:comment : The BNB number associated with this resource</para>
    ///   <para>rdfs:label : BNB number</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#bnb">blt:bnb</a>
    /// </summary>
    let bnb = _prefixId.prefix "bnb"
    /// <summary>
    ///   <para>rdfs:comment : the inverse property of dct:contributor</para>
    ///   <para>rdfs:label : has contributed to</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#hasContributedTo">blt:hasContributedTo</a>
    /// </summary>
    let hasContributedTo = _prefixId.prefix "hasContributedTo"
    /// <summary>
    ///   <para>rdfs:comment : the inverse property of dct:creator</para>
    ///   <para>rdfs:label : has created</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#hasCreated">blt:hasCreated</a>
    /// </summary>
    let hasCreated = _prefixId.prefix "hasCreated"
    /// <summary>
    ///   <para>rdfs:comment : The publication event of a resource.</para>
    ///   <para>rdfs:label : Publication</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#publication">blt:publication</a>
    /// </summary>
    let publication = _prefixId.prefix "publication"
    /// <summary>
    ///   <para>rdfs:comment : The end of the publication event of a resource.</para>
    ///   <para>rdfs:label : Publication end</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#publicationEnd">blt:publicationEnd</a>
    /// </summary>
    let publicationEnd = _prefixId.prefix "publicationEnd"
    /// <summary>
    ///   <para>rdfs:comment : The start of the publication event of a resource.</para>
    ///   <para>rdfs:label : Publication start</para>
    ///   <a href="http://www.bl.uk/schemas/bibliographic/blterms#publicationStart">blt:publicationStart</a>
    /// </summary>
    let publicationStart = _prefixId.prefix "publicationStart"
