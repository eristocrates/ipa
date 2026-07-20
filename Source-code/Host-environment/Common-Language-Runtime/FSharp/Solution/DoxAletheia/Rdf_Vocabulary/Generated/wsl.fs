namespace http.www.wsmo.org.ns.wsmo_lite.hash

open DoxAletheia

module wsl =
    let _namespace_name = "http://www.wsmo.org/ns/wsmo-lite#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Condition"></see>
    /// </summary>
    let Condition = _prefix "Condition"
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Effect"></see>
    /// </summary>
    let Effect = _prefix "Effect"
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#FunctionalClassificationRoot"></see>
    /// </summary>
    let FunctionalClassificationRoot = _prefix "FunctionalClassificationRoot"
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#NonfunctionalParameter"></see>
    /// </summary>
    let NonfunctionalParameter = _prefix "NonfunctionalParameter"
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Ontology"></see>
    /// </summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#usesOntology"></see>
    /// </summary>
    let usesOntology = _prefix "usesOntology"
    /// <summary>
    ///   <see href="http://www.wsmo.org/ns/wsmo-lite#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
