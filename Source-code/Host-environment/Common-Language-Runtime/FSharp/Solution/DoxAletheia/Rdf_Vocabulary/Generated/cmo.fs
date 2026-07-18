namespace http.purl.org.twc.ontologies.cmo.owl.hash

open DoxAletheia.Rdf_Vocabulary

module cmo =
    let _namespace_name = "http://purl.org/twc/ontologies/cmo.owl#"
    /// <summary>
    /// The conceputal representation of anything that is a property (a thing that is inherent in an entity, like eye color) or an attribute (a thing that has been assigned, or attributed, to an entity, like name or identification number).
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Quality"></see></summary>
    let Quality = Namespaced_IRI.parse _namespace_name "Quality" |> NamespacedName
    /// <summary>
    /// A concept representing the relationship between two independent entities.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Relation"></see></summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName
    /// <summary>
    /// An abstract or general idea inferred or derived from specific instances, representing a set of those instances.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    /// Entities that describe the objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Universal"></see></summary>
    let Universal = Namespaced_IRI.parse _namespace_name "Universal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf"></see>
    /// </summary>
    let ``http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf`` =
        Namespaced_IRI.parse _namespace_name "http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf" |> NamespacedName

    /// <summary>
    /// Things in the real world can be represented by concepts. This is a link between the concepts and the things those concepts represent. Things, including sets of things, are represented by concepts.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#representedBy"></see></summary>
    let representedBy =
        Namespaced_IRI.parse _namespace_name "representedBy" |> NamespacedName

    /// <summary>
    /// Universal (natural) sets of objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#UniversalClass"></see></summary>
    let UniversalClass =
        Namespaced_IRI.parse _namespace_name "UniversalClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#UniversalQuality"></see>
    /// </summary>
    let UniversalQuality =
        Namespaced_IRI.parse _namespace_name "UniversalQuality" |> NamespacedName

    /// <summary>
    /// Relationships in reality. (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#UniversalRelation"></see></summary>
    let UniversalRelation =
        Namespaced_IRI.parse _namespace_name "UniversalRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasPrimaryConcept"></see>
    /// </summary>
    let hasPrimaryConcept =
        Namespaced_IRI.parse _namespace_name "hasPrimaryConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasQualifier"></see>
    /// </summary>
    let hasQualifier =
        Namespaced_IRI.parse _namespace_name "hasQualifier" |> NamespacedName

    /// <summary>
    /// A conceptual type can have qualities that describe it.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#hasQuality"></see></summary>
    let hasQuality = Namespaced_IRI.parse _namespace_name "hasQuality" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasRole"></see>
    /// </summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasRoleIn"></see>
    /// </summary>
    let hasRoleIn = Namespaced_IRI.parse _namespace_name "hasRoleIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRole"></see>
    /// </summary>
    let hasSourceRole =
        Namespaced_IRI.parse _namespace_name "hasSourceRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRoleIn"></see>
    /// </summary>
    let hasSourceRoleIn =
        Namespaced_IRI.parse _namespace_name "hasSourceRoleIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRole"></see>
    /// </summary>
    let hasTargetRole =
        Namespaced_IRI.parse _namespace_name "hasTargetRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRoleIn"></see>
    /// </summary>
    let hasTargetRoleIn =
        Namespaced_IRI.parse _namespace_name "hasTargetRoleIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#qualityOf"></see>
    /// </summary>
    let qualityOf = Namespaced_IRI.parse _namespace_name "qualityOf" |> NamespacedName
    /// <summary>
    /// Things in the real world can be represented by concepts. This is a link from the concepts and the things those concepts represent. Concepts represent things.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName

    /// <summary>
    /// Concepts represent universals in the world.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#representsUniversal"></see></summary>
    let representsUniversal =
        Namespaced_IRI.parse _namespace_name "representsUniversal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#valuesCanBe"></see>
    /// </summary>
    let valuesCanBe =
        Namespaced_IRI.parse _namespace_name "valuesCanBe" |> NamespacedName
