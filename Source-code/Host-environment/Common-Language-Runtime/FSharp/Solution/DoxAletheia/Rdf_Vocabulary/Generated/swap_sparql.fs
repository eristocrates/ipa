namespace http.eulersharp.sourceforge.net._2003._03swap.sparql.hash

open DoxAletheia.Rdf_Vocabulary

module swap_sparql =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/sparql#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Endpoint"></see>
    /// </summary>
    let Endpoint = Namespaced_IRI.parse _namespace_name "Endpoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Query"></see>
    /// </summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Querying"></see>
    /// </summary>
    let Querying = Namespaced_IRI.parse _namespace_name "Querying" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Result"></see>
    /// </summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#SPARQL"></see>
    /// </summary>
    let SPARQL = Namespaced_IRI.parse _namespace_name "SPARQL" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Template"></see>
    /// </summary>
    let Template = Namespaced_IRI.parse _namespace_name "Template" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#TemplateBinding"></see>
    /// </summary>
    let TemplateBinding =
        Namespaced_IRI.parse _namespace_name "TemplateBinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#executedOn"></see>
    /// </summary>
    let executedOn = Namespaced_IRI.parse _namespace_name "executedOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasBinding"></see>
    /// </summary>
    let hasBinding = Namespaced_IRI.parse _namespace_name "hasBinding" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasQuery"></see>
    /// </summary>
    let hasQuery = Namespaced_IRI.parse _namespace_name "hasQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasTemplate"></see>
    /// </summary>
    let hasTemplate =
        Namespaced_IRI.parse _namespace_name "hasTemplate" |> NamespacedName
