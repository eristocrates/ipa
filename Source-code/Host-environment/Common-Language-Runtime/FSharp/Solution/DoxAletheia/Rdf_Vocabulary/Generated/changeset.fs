namespace http.purl.org.vocab.changeset.schema.hash

open DoxAletheia.Rdf_Vocabulary

module changeset =
    let _namespace_name = "http://purl.org/vocab/changeset/schema#"
    /// <summary>
    ///   <see href="http://purl.org/vocab/changeset/schema#ChangeSet"></see>
    /// </summary>
    let ChangeSet = Namespaced_IRI.parse _namespace_name "ChangeSet" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/changeset/schema#statement"></see>
    /// </summary>
    let statement = Namespaced_IRI.parse _namespace_name "statement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/changeset/schema#previousChangeSet"></see>
    /// </summary>
    let previousChangeSet =
        Namespaced_IRI.parse _namespace_name "previousChangeSet" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/changeset/schema#subjectOfChange"></see>
    /// </summary>
    let subjectOfChange =
        Namespaced_IRI.parse _namespace_name "subjectOfChange" |> NamespacedName

    /// <summary>
    ///
    ///       The date should be in W3CDTF format
    ///
    /// <see href="http://purl.org/vocab/changeset/schema#createdDate"></see></summary>
    let createdDate =
        Namespaced_IRI.parse _namespace_name "createdDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/changeset/schema#creatorName"></see>
    /// </summary>
    let creatorName =
        Namespaced_IRI.parse _namespace_name "creatorName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/changeset/schema#changeReason"></see>
    /// </summary>
    let changeReason =
        Namespaced_IRI.parse _namespace_name "changeReason" |> NamespacedName

    /// <summary>
    ///
    ///       By convention the subject of the triple being added should be the same as the subjectOfChange
    ///
    /// <see href="http://purl.org/vocab/changeset/schema#addition"></see></summary>
    let addition = Namespaced_IRI.parse _namespace_name "addition" |> NamespacedName

    /// <summary>
    ///
    ///       This property can be used to build a history of changes to a particular resource description. The first
    ///       ChangeSet in the history will have no precedingChangeSet property. Each subsequent ChangeSet added
    ///       to the history references the preceding one resulting in a singly-linked list of changes.  Care must be taken
    ///       not to introduce cycles in the history.
    ///
    ///
    ///       In systems that assume a closed world, the most recent ChangeSet for a particular resource description
    ///       can be discovered by looking for the ChangeSet that is not the value of a precedingChangeSet property.
    ///       Conversely, the earliest ChangeSet is the one that is not the subject of a precedingChangeSet property.
    ///
    /// <see href="http://purl.org/vocab/changeset/schema#precedingChangeSet"></see></summary>
    let precedingChangeSet =
        Namespaced_IRI.parse _namespace_name "precedingChangeSet" |> NamespacedName

    /// <summary>
    ///
    ///       By convention the subject of the triple being removed should be the same as the subjectOfChange
    ///
    /// <see href="http://purl.org/vocab/changeset/schema#removal"></see></summary>
    let removal = Namespaced_IRI.parse _namespace_name "removal" |> NamespacedName
