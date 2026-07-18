namespace http.www.bl.uk.schemas.bibliographic.blterms.hash

open DoxAletheia.Rdf_Vocabulary

module blt =
    let _namespace_name = "http://www.bl.uk/schemas/bibliographic/blterms#"
    /// <summary>
    /// A family
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName

    /// <summary>
    /// A family expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#FamilyConcept"></see></summary>
    let FamilyConcept =
        Namespaced_IRI.parse _namespace_name "FamilyConcept" |> NamespacedName

    /// <summary>
    /// An organization expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#OrganizationConcept"></see></summary>
    let OrganizationConcept =
        Namespaced_IRI.parse _namespace_name "OrganizationConcept" |> NamespacedName

    /// <summary>
    /// A person expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PersonConcept"></see></summary>
    let PersonConcept =
        Namespaced_IRI.parse _namespace_name "PersonConcept" |> NamespacedName

    /// <summary>
    /// A place expressed as a concept.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PlaceConcept"></see></summary>
    let PlaceConcept =
        Namespaced_IRI.parse _namespace_name "PlaceConcept" |> NamespacedName

    /// <summary>
    /// An event which is the end of the publication of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEndEvent"></see></summary>
    let PublicationEndEvent =
        Namespaced_IRI.parse _namespace_name "PublicationEndEvent" |> NamespacedName

    /// <summary>
    /// An event which is the publication of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationEvent"></see></summary>
    let PublicationEvent =
        Namespaced_IRI.parse _namespace_name "PublicationEvent" |> NamespacedName

    /// <summary>
    /// An event which is the start of the publication of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#PublicationStartEvent"></see></summary>
    let PublicationStartEvent =
        Namespaced_IRI.parse _namespace_name "PublicationStartEvent" |> NamespacedName

    /// <summary>
    /// A Dewey Decimal Classification number (as found in British Library cataloguing data)
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#TopicDDC"></see></summary>
    let TopicDDC = Namespaced_IRI.parse _namespace_name "TopicDDC" |> NamespacedName
    /// <summary>
    /// A Library of Congress Subject Heading (LCSH) (as found in British Library cataloguing data)
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#TopicLCSH"></see></summary>
    let TopicLCSH = Namespaced_IRI.parse _namespace_name "TopicLCSH" |> NamespacedName
    /// <summary>
    /// The BNB number associated with this resource
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#bnb"></see></summary>
    let bnb = Namespaced_IRI.parse _namespace_name "bnb" |> NamespacedName

    /// <summary>
    /// the inverse property of dct:contributor
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#hasContributedTo"></see></summary>
    let hasContributedTo =
        Namespaced_IRI.parse _namespace_name "hasContributedTo" |> NamespacedName

    /// <summary>
    /// the inverse property of dct:creator
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#hasCreated"></see></summary>
    let hasCreated = Namespaced_IRI.parse _namespace_name "hasCreated" |> NamespacedName

    /// <summary>
    /// The publication event of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#publication"></see></summary>
    let publication =
        Namespaced_IRI.parse _namespace_name "publication" |> NamespacedName

    /// <summary>
    /// The end of the publication event of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#publicationEnd"></see></summary>
    let publicationEnd =
        Namespaced_IRI.parse _namespace_name "publicationEnd" |> NamespacedName

    /// <summary>
    /// The start of the publication event of a resource.
    /// <see href="http://www.bl.uk/schemas/bibliographic/blterms#publicationStart"></see></summary>
    let publicationStart =
        Namespaced_IRI.parse _namespace_name "publicationStart" |> NamespacedName
