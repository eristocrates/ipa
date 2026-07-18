namespace http.eulersharp.sourceforge.net._2003._03swap.digitalProcedure.hash

open DoxAletheia.Rdf_Vocabulary

module swap_digitalProcedure =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Input"></see>
    /// </summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Procedure"></see>
    /// </summary>
    let Procedure = Namespaced_IRI.parse _namespace_name "Procedure" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#LoggingIn"></see>
    /// </summary>
    let LoggingIn = Namespaced_IRI.parse _namespace_name "LoggingIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Output"></see>
    /// </summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Query"></see>
    /// </summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryLanguage"></see>
    /// </summary>
    let QueryLanguage =
        Namespaced_IRI.parse _namespace_name "QueryLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryPlan"></see>
    /// </summary>
    let QueryPlan = Namespaced_IRI.parse _namespace_name "QueryPlan" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Querying"></see>
    /// </summary>
    let Querying = Namespaced_IRI.parse _namespace_name "Querying" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Result"></see>
    /// </summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Request"></see>
    /// </summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchRequest"></see>
    /// </summary>
    let SearchRequest =
        Namespaced_IRI.parse _namespace_name "SearchRequest" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Searching"></see>
    /// </summary>
    let Searching = Namespaced_IRI.parse _namespace_name "Searching" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchResult"></see>
    /// </summary>
    let SearchResult =
        Namespaced_IRI.parse _namespace_name "SearchResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Template"></see>
    /// </summary>
    let Template = Namespaced_IRI.parse _namespace_name "Template" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasResult"></see>
    /// </summary>
    let hasResult = Namespaced_IRI.parse _namespace_name "hasResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingDateTime"></see>
    /// </summary>
    let hasSearchingDateTime =
        Namespaced_IRI.parse _namespace_name "hasSearchingDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingPeriod"></see>
    /// </summary>
    let hasSearchingPeriod =
        Namespaced_IRI.parse _namespace_name "hasSearchingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSelected"></see>
    /// </summary>
    let hasSelected =
        Namespaced_IRI.parse _namespace_name "hasSelected" |> NamespacedName

    /// <summary>
    /// Used in builtin; expression syntax in the triple quoted literal:
    /// 		* "term1 term2": phrase of terms
    /// 		* term3 term4 : implicit AND of two terms
    /// 		* term3 OR term4 : explicit OR of two terms
    /// 		* -term5 : excluding the term
    /// 		* AND has higher precedence than OR.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#matchesExpression"></see></summary>
    let matchesExpression =
        Namespaced_IRI.parse _namespace_name "matchesExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#resultOf"></see>
    /// </summary>
    let resultOf = Namespaced_IRI.parse _namespace_name "resultOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#searchingDuring"></see>
    /// </summary>
    let searchingDuring =
        Namespaced_IRI.parse _namespace_name "searchingDuring" |> NamespacedName
