namespace http.purl.org.ontology.holding.hash

open DoxAletheia.Rdf_Vocabulary

module holding =
    let _namespace_name = "http://purl.org/ontology/holding#"
    /// <summary>
    /// Use one of bf:Agent or foaf:Agent
    /// <see href="http://purl.org/ontology/holding#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// Use one of bibo:Document, foaf:Document, bf:Work or bf:Instance
    /// <see href="http://purl.org/ontology/holding#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// Use one of bf:HeldItem frbr:Item rdac:Item
    /// <see href="http://purl.org/ontology/holding#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    /// Relates a document to an item that contains an exemplar of the document as part.
    /// <see href="http://purl.org/ontology/holding#broaderExemplar"></see></summary>
    let broaderExemplar =
        Namespaced_IRI.parse _namespace_name "broaderExemplar" |> NamespacedName

    /// <summary>
    /// Relates an item to a document which is partly exemplified by the item.
    /// <see href="http://purl.org/ontology/holding#broaderExemplarOf"></see></summary>
    let broaderExemplarOf =
        Namespaced_IRI.parse _namespace_name "broaderExemplarOf" |> NamespacedName

    /// <summary>
    /// Relates an agent to a document and/or item that is collected by the agent.
    /// Relates a document and/or item to an agent who collects it.
    /// <see href="http://purl.org/ontology/holding#collectedBy"></see></summary>
    let collectedBy =
        Namespaced_IRI.parse _namespace_name "collectedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/holding#collects"></see>
    /// </summary>
    let collects = Namespaced_IRI.parse _namespace_name "collects" |> NamespacedName
    /// <summary>
    /// Relates a document to an item that is an exemplar of the document.
    /// <see href="http://purl.org/ontology/holding#exemplar"></see></summary>
    let exemplar = Namespaced_IRI.parse _namespace_name "exemplar" |> NamespacedName
    /// <summary>
    /// Relates an item to the document that is exemplified by the item.
    /// <see href="http://purl.org/ontology/holding#exemplarOf"></see></summary>
    let exemplarOf = Namespaced_IRI.parse _namespace_name "exemplarOf" |> NamespacedName
    /// <summary>
    /// Relates an item to an agent who holds the item.
    /// <see href="http://purl.org/ontology/holding#heldBy"></see></summary>
    let heldBy = Namespaced_IRI.parse _namespace_name "heldBy" |> NamespacedName
    /// <summary>
    /// Relates an agent to an item which the agent holds.
    /// <see href="http://purl.org/ontology/holding#holds"></see></summary>
    let holds = Namespaced_IRI.parse _namespace_name "holds" |> NamespacedName
    /// <summary>
    /// A call number, shelf mark or similar label of an item
    /// <see href="http://purl.org/ontology/holding#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName

    /// <summary>
    /// Relates a document to an item that is an exemplar of a part of the document.
    /// <see href="http://purl.org/ontology/holding#narrowerExemplar"></see></summary>
    let narrowerExemplar =
        Namespaced_IRI.parse _namespace_name "narrowerExemplar" |> NamespacedName

    /// <summary>
    /// Relates an item to a document which is partly exemplified by the item.
    /// <see href="http://purl.org/ontology/holding#narrowerExemplarOf"></see></summary>
    let narrowerExemplarOf =
        Namespaced_IRI.parse _namespace_name "narrowerExemplarOf" |> NamespacedName
