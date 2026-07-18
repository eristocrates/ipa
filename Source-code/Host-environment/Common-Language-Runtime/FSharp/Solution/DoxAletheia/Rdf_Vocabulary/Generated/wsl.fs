namespace http.www.wsmo.org.ns.wsmo_lite.hash

open DoxAletheia.Rdf_Vocabulary

module wsl =
    let _namespace_name = "http://www.wsmo.org/ns/wsmo-lite#"
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Condition"></see>
    /// </summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Effect"></see>
    /// </summary>
    let Effect = Namespaced_IRI.parse _namespace_name "Effect" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#FunctionalClassificationRoot"></see>
    /// </summary>
    let FunctionalClassificationRoot =
        Namespaced_IRI.parse _namespace_name "FunctionalClassificationRoot" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#NonfunctionalParameter"></see>
    /// </summary>
    let NonfunctionalParameter =
        Namespaced_IRI.parse _namespace_name "NonfunctionalParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Ontology"></see>
    /// </summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#usesOntology"></see>
    /// </summary>
    let usesOntology =
        Namespaced_IRI.parse _namespace_name "usesOntology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
