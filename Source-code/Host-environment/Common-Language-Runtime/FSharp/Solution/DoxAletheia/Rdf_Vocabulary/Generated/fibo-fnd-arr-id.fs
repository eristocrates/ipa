namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.IdentifiersAndIndices.slash

open DoxAletheia

module fibo_fnd_arr_id =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/Index"></see>
    /// </summary>
    let Index = _prefix "Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/isIndexTo"></see>
    /// </summary>
    let isIndexTo = _prefix "isIndexTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/IndexingScheme"></see>
    /// </summary>
    let IndexingScheme = _prefix "IndexingScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/ReassignableIdentifier"></see>
    /// </summary>
    let ReassignableIdentifier = _prefix "ReassignableIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasAssignmentTerminationDate"></see>
    /// </summary>
    let hasAssignmentTerminationDate = _prefix "hasAssignmentTerminationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasInitialAssignmentDate"></see>
    /// </summary>
    let hasInitialAssignmentDate = _prefix "hasInitialAssignmentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/constructRegex"></see>
    /// </summary>
    let constructRegex = _prefix "constructRegex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/parseRegex"></see>
    /// </summary>
    let parseRegex = _prefix "parseRegex"
