namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Reporting.slash

open DoxAletheia

module fibo_fnd_arr_rep =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Report"></see>
    /// </summary>
    let Report = _prefix "Report"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedBy"></see>
    /// </summary>
    let isSubmittedBy = _prefix "isSubmittedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Submitter"></see>
    /// </summary>
    let Submitter = _prefix "Submitter"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDateTime"></see>
    /// </summary>
    let hasReportDateTime = _prefix "hasReportDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDate"></see>
    /// </summary>
    let hasReportDate = _prefix "hasReportDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedTo"></see>
    /// </summary>
    let isSubmittedTo = _prefix "isSubmittedTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isReportedTo"></see>
    /// </summary>
    let isReportedTo = _prefix "isReportedTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/ReportingParty"></see>
    /// </summary>
    let ReportingParty = _prefix "ReportingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Request"></see>
    /// </summary>
    let Request = _prefix "Request"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDateTime"></see>
    /// </summary>
    let hasRequestDateTime = _prefix "hasRequestDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDate"></see>
    /// </summary>
    let hasRequestDate = _prefix "hasRequestDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedBy"></see>
    /// </summary>
    let isRequestedBy = _prefix "isRequestedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Requester"></see>
    /// </summary>
    let Requester = _prefix "Requester"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedOf"></see>
    /// </summary>
    let isRequestedOf = _prefix "isRequestedOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/RequestActivity"></see>
    /// </summary>
    let RequestActivity = _prefix "RequestActivity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/requests"></see>
    /// </summary>
    let requests = _prefix "requests"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/submits"></see>
    /// </summary>
    let submits = _prefix "submits"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/reportsOn"></see>
    /// </summary>
    let reportsOn = _prefix "reportsOn"
