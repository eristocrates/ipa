namespace https.w3id.org.vocab.olca.hash

open DoxAletheia

module olca =
    let _namespace_name = "https://w3id.org/vocab/olca#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A loose coupling of a property to possible or expected class it can describe. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:domain or some owl:Restriction constraint.
    /// <see href="https://w3id.org/vocab/olca#domainIncludes"></see></summary>
    let domainIncludes = _prefix "domainIncludes"
    /// <summary>
    /// A loose coupling of a property to possible or expected values. This annotation is to be used when one does not want to enforce formally the coupling by rdfs:range or some owl:Restriction constraint.
    /// <see href="https://w3id.org/vocab/olca#rangeIncludes"></see></summary>
    let rangeIncludes = _prefix "rangeIncludes"
    /// <summary>
    /// A loose coupling of a class to possible or expected properties. This annotation is to be used when one does not want to enforce formally the coupling using rdfs:range or some owl:Restriction.
    /// <see href="https://w3id.org/vocab/olca#expectedProperty"></see></summary>
    let expectedProperty = _prefix "expectedProperty"
    /// <summary>
    /// A loose similarity of classes, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentClass.
    /// <see href="https://w3id.org/vocab/olca#similarClass"></see></summary>
    let similarClass = _prefix "similarClass"
    /// <summary>
    /// A loose similary of properties, typically across ontologies . This annotation is to be used when one does not want to enforce formally the coupling by owl:equivalentProperty.
    /// <see href="https://w3id.org/vocab/olca#similarProperty"></see></summary>
    let similarProperty = _prefix "similarProperty"
