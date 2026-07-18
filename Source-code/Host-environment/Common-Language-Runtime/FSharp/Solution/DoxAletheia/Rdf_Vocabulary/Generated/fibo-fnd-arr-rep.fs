namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Reporting.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_rep =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Report"></see>
    /// </summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedBy"></see>
    /// </summary>
    let isSubmittedBy =
        Namespaced_IRI.parse _namespace_name "isSubmittedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Submitter"></see>
    /// </summary>
    let Submitter = Namespaced_IRI.parse _namespace_name "Submitter" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDateTime"></see>
    /// </summary>
    let hasReportDateTime =
        Namespaced_IRI.parse _namespace_name "hasReportDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDate"></see>
    /// </summary>
    let hasReportDate =
        Namespaced_IRI.parse _namespace_name "hasReportDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedTo"></see>
    /// </summary>
    let isSubmittedTo =
        Namespaced_IRI.parse _namespace_name "isSubmittedTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isReportedTo"></see>
    /// </summary>
    let isReportedTo =
        Namespaced_IRI.parse _namespace_name "isReportedTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/ReportingParty"></see>
    /// </summary>
    let ReportingParty =
        Namespaced_IRI.parse _namespace_name "ReportingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Request"></see>
    /// </summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDateTime"></see>
    /// </summary>
    let hasRequestDateTime =
        Namespaced_IRI.parse _namespace_name "hasRequestDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDate"></see>
    /// </summary>
    let hasRequestDate =
        Namespaced_IRI.parse _namespace_name "hasRequestDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedBy"></see>
    /// </summary>
    let isRequestedBy =
        Namespaced_IRI.parse _namespace_name "isRequestedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Requester"></see>
    /// </summary>
    let Requester = Namespaced_IRI.parse _namespace_name "Requester" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedOf"></see>
    /// </summary>
    let isRequestedOf =
        Namespaced_IRI.parse _namespace_name "isRequestedOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/RequestActivity"></see>
    /// </summary>
    let RequestActivity =
        Namespaced_IRI.parse _namespace_name "RequestActivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/requests"></see>
    /// </summary>
    let requests = Namespaced_IRI.parse _namespace_name "requests" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/submits"></see>
    /// </summary>
    let submits = Namespaced_IRI.parse _namespace_name "submits" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/reportsOn"></see>
    /// </summary>
    let reportsOn = Namespaced_IRI.parse _namespace_name "reportsOn" |> NamespacedName
