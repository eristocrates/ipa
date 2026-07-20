namespace http.www.linklion.org.ontology.hash

open DoxAletheia

module llont =
    let _namespace_name = "http://www.linklion.org/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#Algorithm"></see>
    /// </summary>
    let Algorithm = _prefix "Algorithm"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#parameters"></see>
    /// </summary>
    let parameters = _prefix "parameters"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#LDFrameworkVersion"></see>
    /// </summary>
    let LDFrameworkVersion = _prefix "LDFrameworkVersion"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#LDFramework"></see>
    /// </summary>
    let LDFramework = _prefix "LDFramework"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#Link"></see>
    /// </summary>
    let Link = _prefix "Link"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#Mapping"></see>
    /// </summary>
    let Mapping = _prefix "Mapping"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#storedAt"></see>
    /// </summary>
    let storedAt = _prefix "storedAt"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#hasSource"></see>
    /// </summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    ///   <see href="http://www.linklion.org/ontology#hasTarget"></see>
    /// </summary>
    let hasTarget = _prefix "hasTarget"
