namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Documents.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_doc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/FinancialRecord"></see>
    /// </summary>
    let FinancialRecord =
        Namespaced_IRI.parse _namespace_name "FinancialRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasExpirationDate"></see>
    /// </summary>
    let hasExpirationDate =
        Namespaced_IRI.parse _namespace_name "hasExpirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasRecord"></see>
    /// </summary>
    let hasRecord = Namespaced_IRI.parse _namespace_name "hasRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasReportingPeriod"></see>
    /// </summary>
    let hasReportingPeriod =
        Namespaced_IRI.parse _namespace_name "hasReportingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasTerminationDate"></see>
    /// </summary>
    let hasTerminationDate =
        Namespaced_IRI.parse _namespace_name "hasTerminationDate" |> NamespacedName
