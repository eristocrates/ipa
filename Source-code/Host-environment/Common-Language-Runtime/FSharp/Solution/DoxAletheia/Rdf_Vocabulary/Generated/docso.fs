namespace http.purl.org.ontology.dso.hash

open DoxAletheia.Rdf_Vocabulary

module docso =
    let _namespace_name = "http://purl.org/ontology/dso#"

    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#DocumentService"></see>
    /// </summary>
    let DocumentService =
        Namespaced_IRI.parse _namespace_name "DocumentService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#Interloan"></see>
    /// </summary>
    let Interloan = Namespaced_IRI.parse _namespace_name "Interloan" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#Loan"></see>
    /// </summary>
    let Loan = Namespaced_IRI.parse _namespace_name "Loan" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#OpenAccess"></see>
    /// </summary>
    let OpenAccess = Namespaced_IRI.parse _namespace_name "OpenAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#Presentation"></see>
    /// </summary>
    let Presentation =
        Namespaced_IRI.parse _namespace_name "Presentation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#hasDocument"></see>
    /// </summary>
    let hasDocument =
        Namespaced_IRI.parse _namespace_name "hasDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/dso#hasService"></see>
    /// </summary>
    let hasService = Namespaced_IRI.parse _namespace_name "hasService" |> NamespacedName
