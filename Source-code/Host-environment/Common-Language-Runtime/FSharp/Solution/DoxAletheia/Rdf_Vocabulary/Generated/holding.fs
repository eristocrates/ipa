namespace http.purl.org.ontology.holding.hash

open DoxAletheia

module holding =
    let _namespace_name = "http://purl.org/ontology/holding#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Use one of bf:Agent or foaf:Agent
    /// <see href="http://purl.org/ontology/holding#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Use one of bibo:Document, foaf:Document, bf:Work or bf:Instance
    /// <see href="http://purl.org/ontology/holding#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// Use one of bf:HeldItem frbr:Item rdac:Item
    /// <see href="http://purl.org/ontology/holding#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// Relates a document to an item that contains an exemplar of the document as part.
    /// <see href="http://purl.org/ontology/holding#broaderExemplar"></see></summary>
    let broaderExemplar = _prefix "broaderExemplar"
    /// <summary>
    /// Relates an item to a document which is partly exemplified by the item.
    /// <see href="http://purl.org/ontology/holding#broaderExemplarOf"></see></summary>
    let broaderExemplarOf = _prefix "broaderExemplarOf"
    /// <summary>
    /// Relates an agent to a document and/or item that is collected by the agent.
    /// Relates a document and/or item to an agent who collects it.
    /// <see href="http://purl.org/ontology/holding#collectedBy"></see></summary>
    let collectedBy = _prefix "collectedBy"
    /// <summary>
    ///   <see href="http://purl.org/ontology/holding#collects"></see>
    /// </summary>
    let collects = _prefix "collects"
    /// <summary>
    /// Relates a document to an item that is an exemplar of the document.
    /// <see href="http://purl.org/ontology/holding#exemplar"></see></summary>
    let exemplar = _prefix "exemplar"
    /// <summary>
    /// Relates an item to the document that is exemplified by the item.
    /// <see href="http://purl.org/ontology/holding#exemplarOf"></see></summary>
    let exemplarOf = _prefix "exemplarOf"
    /// <summary>
    /// Relates an item to an agent who holds the item.
    /// <see href="http://purl.org/ontology/holding#heldBy"></see></summary>
    let heldBy = _prefix "heldBy"
    /// <summary>
    /// Relates an agent to an item which the agent holds.
    /// <see href="http://purl.org/ontology/holding#holds"></see></summary>
    let holds = _prefix "holds"
    /// <summary>
    /// A call number, shelf mark or similar label of an item
    /// <see href="http://purl.org/ontology/holding#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// Relates a document to an item that is an exemplar of a part of the document.
    /// <see href="http://purl.org/ontology/holding#narrowerExemplar"></see></summary>
    let narrowerExemplar = _prefix "narrowerExemplar"
    /// <summary>
    /// Relates an item to a document which is partly exemplified by the item.
    /// <see href="http://purl.org/ontology/holding#narrowerExemplarOf"></see></summary>
    let narrowerExemplarOf = _prefix "narrowerExemplarOf"
