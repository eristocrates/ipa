namespace http.eulersharp.sourceforge.net._2003._03swap.sparql.hash

open DoxAletheia

module swap_sparql =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/sparql#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Endpoint"></see>
    /// </summary>
    let Endpoint = _prefix "Endpoint"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Query"></see>
    /// </summary>
    let Query = _prefix "Query"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Querying"></see>
    /// </summary>
    let Querying = _prefix "Querying"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Result"></see>
    /// </summary>
    let Result = _prefix "Result"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#SPARQL"></see>
    /// </summary>
    let SPARQL = _prefix "SPARQL"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Template"></see>
    /// </summary>
    let Template = _prefix "Template"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#TemplateBinding"></see>
    /// </summary>
    let TemplateBinding = _prefix "TemplateBinding"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#executedOn"></see>
    /// </summary>
    let executedOn = _prefix "executedOn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasBinding"></see>
    /// </summary>
    let hasBinding = _prefix "hasBinding"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasQuery"></see>
    /// </summary>
    let hasQuery = _prefix "hasQuery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasTemplate"></see>
    /// </summary>
    let hasTemplate = _prefix "hasTemplate"
