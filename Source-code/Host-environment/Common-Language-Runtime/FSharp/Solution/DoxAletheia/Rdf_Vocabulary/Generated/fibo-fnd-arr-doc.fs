namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Documents.slash

open DoxAletheia

module fibo_fnd_arr_doc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/FinancialRecord"></see>
    /// </summary>
    let FinancialRecord = _prefix "FinancialRecord"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasExpirationDate"></see>
    /// </summary>
    let hasExpirationDate = _prefix "hasExpirationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasRecord"></see>
    /// </summary>
    let hasRecord = _prefix "hasRecord"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasReportingPeriod"></see>
    /// </summary>
    let hasReportingPeriod = _prefix "hasReportingPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasTerminationDate"></see>
    /// </summary>
    let hasTerminationDate = _prefix "hasTerminationDate"
