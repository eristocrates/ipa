namespace https.w3id.org.vocab.olca.hash

open DoxAletheia.Rdf_Vocabulary

module olca =
    let _namespace_name = "https://w3id.org/vocab/olca#"

    /// <summary>
    /// A loose coupling of a property to possible or expected class it can describe. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:domain or some owl:Restriction constraint.
    /// <see href="https://w3id.org/vocab/olca#domainIncludes"></see></summary>
    let domainIncludes =
        Namespaced_IRI.parse _namespace_name "domainIncludes" |> NamespacedName

    /// <summary>
    /// A loose coupling of a property to possible or expected values. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:range or some owl:Restriction constraint.
    /// <see href="https://w3id.org/vocab/olca#rangeIncludes"></see></summary>
    let rangeIncludes =
        Namespaced_IRI.parse _namespace_name "rangeIncludes" |> NamespacedName

    /// <summary>
    /// A loose coupling of a class to possible or expected properties. This annotation is to be used when one does not want to enforce formally the coupling using rdfs:range or some owl:Restriction.
    /// <see href="https://w3id.org/vocab/olca#expectedProperty"></see></summary>
    let expectedProperty =
        Namespaced_IRI.parse _namespace_name "expectedProperty" |> NamespacedName

    /// <summary>
    /// A loose similarity of classes, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentClass.
    /// <see href="https://w3id.org/vocab/olca#similarClass"></see></summary>
    let similarClass =
        Namespaced_IRI.parse _namespace_name "similarClass" |> NamespacedName

    /// <summary>
    /// A loose similary of properties, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentProperty.
    /// <see href="https://w3id.org/vocab/olca#similarProperty"></see></summary>
    let similarProperty =
        Namespaced_IRI.parse _namespace_name "similarProperty" |> NamespacedName
