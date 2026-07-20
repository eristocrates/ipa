namespace http.purl.org.ontology.dso.hash

open DoxAletheia

module docso =
    let _namespace_name = "http://purl.org/ontology/dso#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#DocumentService"></see>
    /// </summary>
    let DocumentService = _prefix "DocumentService"
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#Interloan"></see>
    /// </summary>
    let Interloan = _prefix "Interloan"
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#Loan"></see>
    /// </summary>
    let Loan = _prefix "Loan"
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#OpenAccess"></see>
    /// </summary>
    let OpenAccess = _prefix "OpenAccess"
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#Presentation"></see>
    /// </summary>
    let Presentation = _prefix "Presentation"
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#hasDocument"></see>
    /// </summary>
    let hasDocument = _prefix "hasDocument"
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#hasService"></see>
    /// </summary>
    let hasService = _prefix "hasService"
