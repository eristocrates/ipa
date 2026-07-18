namespace http.www.linklion.org.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module llont =
    let _namespace_name = "http://www.linklion.org/ontology#"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#Algorithm"></see>
    /// </summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#parameters"></see>
    /// </summary>
    let parameters = Namespaced_IRI.parse _namespace_name "parameters" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#LDFrameworkVersion"></see>
    /// </summary>
    let LDFrameworkVersion =
        Namespaced_IRI.parse _namespace_name "LDFrameworkVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#LDFramework"></see>
    /// </summary>
    let LDFramework =
        Namespaced_IRI.parse _namespace_name "LDFramework" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#Link"></see>
    /// </summary>
    let Link = Namespaced_IRI.parse _namespace_name "Link" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#Mapping"></see>
    /// </summary>
    let Mapping = Namespaced_IRI.parse _namespace_name "Mapping" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#storedAt"></see>
    /// </summary>
    let storedAt = Namespaced_IRI.parse _namespace_name "storedAt" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#hasSource"></see>
    /// </summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#hasTarget"></see>
    /// </summary>
    let hasTarget = Namespaced_IRI.parse _namespace_name "hasTarget" |> NamespacedName
