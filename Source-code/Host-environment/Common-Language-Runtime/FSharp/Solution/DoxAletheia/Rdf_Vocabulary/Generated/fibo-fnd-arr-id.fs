namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.IdentifiersAndIndices.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_id =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/Index"></see>
    /// </summary>
    let Index = Namespaced_IRI.parse _namespace_name "Index" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/isIndexTo"></see>
    /// </summary>
    let isIndexTo = Namespaced_IRI.parse _namespace_name "isIndexTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/IndexingScheme"></see>
    /// </summary>
    let IndexingScheme =
        Namespaced_IRI.parse _namespace_name "IndexingScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/ReassignableIdentifier"></see>
    /// </summary>
    let ReassignableIdentifier =
        Namespaced_IRI.parse _namespace_name "ReassignableIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasAssignmentTerminationDate"></see>
    /// </summary>
    let hasAssignmentTerminationDate =
        Namespaced_IRI.parse _namespace_name "hasAssignmentTerminationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasInitialAssignmentDate"></see>
    /// </summary>
    let hasInitialAssignmentDate =
        Namespaced_IRI.parse _namespace_name "hasInitialAssignmentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/constructRegex"></see>
    /// </summary>
    let constructRegex =
        Namespaced_IRI.parse _namespace_name "constructRegex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/parseRegex"></see>
    /// </summary>
    let parseRegex = Namespaced_IRI.parse _namespace_name "parseRegex" |> NamespacedName
