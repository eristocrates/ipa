namespace http.purl.org.twc.ontologies.cmo.owl.hash

open DoxAletheia

module cmo =
    let _namespace_name = "http://purl.org/twc/ontologies/cmo.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The conceputal representation of anything that is a property (a thing that is inherent in an entity, like eye color) or an attribute (a thing that has been assigned, or attributed, to an entity, like name or identification number).
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Quality"></see></summary>
    let Quality = _prefix "Quality"
    /// <summary>
    /// A concept representing the relationship between two independent entities.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Relation"></see></summary>
    let Relation = _prefix "Relation"
    /// <summary>
    /// An abstract or general idea inferred or derived from specific instances, representing a set of those instances.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// Entities that describe the objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#Universal"></see></summary>
    let Universal = _prefix "Universal"

    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf"></see>
    /// </summary>
    let ``http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf`` =
        _prefix "http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf"

    /// <summary>
    /// Things in the real world can be represented by concepts. This is a link between the concepts and the things those concepts represent. Things, including sets of things, are represented by concepts.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#representedBy"></see></summary>
    let representedBy = _prefix "representedBy"
    /// <summary>
    /// Universal (natural) sets of objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#UniversalClass"></see></summary>
    let UniversalClass = _prefix "UniversalClass"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#UniversalQuality"></see>
    /// </summary>
    let UniversalQuality = _prefix "UniversalQuality"
    /// <summary>
    /// Relationships in reality. (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#UniversalRelation"></see></summary>
    let UniversalRelation = _prefix "UniversalRelation"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasPrimaryConcept"></see>
    /// </summary>
    let hasPrimaryConcept = _prefix "hasPrimaryConcept"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasQualifier"></see>
    /// </summary>
    let hasQualifier = _prefix "hasQualifier"
    /// <summary>
    /// A conceptual type can have qualities that describe it.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#hasQuality"></see></summary>
    let hasQuality = _prefix "hasQuality"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasRole"></see>
    /// </summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasRoleIn"></see>
    /// </summary>
    let hasRoleIn = _prefix "hasRoleIn"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRole"></see>
    /// </summary>
    let hasSourceRole = _prefix "hasSourceRole"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRoleIn"></see>
    /// </summary>
    let hasSourceRoleIn = _prefix "hasSourceRoleIn"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRole"></see>
    /// </summary>
    let hasTargetRole = _prefix "hasTargetRole"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRoleIn"></see>
    /// </summary>
    let hasTargetRoleIn = _prefix "hasTargetRoleIn"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#qualityOf"></see>
    /// </summary>
    let qualityOf = _prefix "qualityOf"
    /// <summary>
    /// Things in the real world can be represented by concepts. This is a link from the concepts and the things those concepts represent. Concepts represent things.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#represents"></see></summary>
    let represents = _prefix "represents"
    /// <summary>
    /// Concepts represent universals in the world.
    /// <see href="http://purl.org/twc/ontologies/cmo.owl#representsUniversal"></see></summary>
    let representsUniversal = _prefix "representsUniversal"
    /// <summary>
    ///   <see href="http://purl.org/twc/ontologies/cmo.owl#valuesCanBe"></see>
    /// </summary>
    let valuesCanBe = _prefix "valuesCanBe"
