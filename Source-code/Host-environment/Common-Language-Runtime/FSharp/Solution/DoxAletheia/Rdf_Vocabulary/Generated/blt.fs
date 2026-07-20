namespace http.www.bl.uk.schemas.bibliographic.blterms.hash

open DoxAletheia

module blt =
    let _namespace_name = "http://www.bl.uk/schemas/bibliographic/blterms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A family
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// A family expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#FamilyConcept"></see></summary>
    let FamilyConcept = _prefix "FamilyConcept"
    /// <summary>
    /// An organization expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#OrganizationConcept"></see></summary>
    let OrganizationConcept = _prefix "OrganizationConcept"
    /// <summary>
    /// A person expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PersonConcept"></see></summary>
    let PersonConcept = _prefix "PersonConcept"
    /// <summary>
    /// A place expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PlaceConcept"></see></summary>
    let PlaceConcept = _prefix "PlaceConcept"
    /// <summary>
    /// An event which is the end of the publication of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEndEvent"></see></summary>
    let PublicationEndEvent = _prefix "PublicationEndEvent"
    /// <summary>
    /// An event which is the publication of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEvent"></see></summary>
    let PublicationEvent = _prefix "PublicationEvent"
    /// <summary>
    /// An event which is the start of the publication of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationStartEvent"></see></summary>
    let PublicationStartEvent = _prefix "PublicationStartEvent"
    /// <summary>
    /// A Dewey Decimal Classification number (as found in British Library cataloguing data)
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#TopicDDC"></see></summary>
    let TopicDDC = _prefix "TopicDDC"
    /// <summary>
    /// A Library of Congress Subject Heading (LCSH) (as found in British Library cataloguing data)
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#TopicLCSH"></see></summary>
    let TopicLCSH = _prefix "TopicLCSH"
    /// <summary>
    /// The BNB number associated with this resource
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#bnb"></see></summary>
    let bnb = _prefix "bnb"
    /// <summary>
    /// the inverse property of dct:contributor
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#hasContributedTo"></see></summary>
    let hasContributedTo = _prefix "hasContributedTo"
    /// <summary>
    /// the inverse property of dct:creator
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#hasCreated"></see></summary>
    let hasCreated = _prefix "hasCreated"
    /// <summary>
    /// The publication event of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#publication"></see></summary>
    let publication = _prefix "publication"
    /// <summary>
    /// The end of the publication event of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#publicationEnd"></see></summary>
    let publicationEnd = _prefix "publicationEnd"
    /// <summary>
    /// The start of the publication event of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#publicationStart"></see></summary>
    let publicationStart = _prefix "publicationStart"
