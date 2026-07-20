namespace http.eulersharp.sourceforge.net._2003._03swap.digitalProcedure.hash

open DoxAletheia

module swap_digitalProcedure =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Input"></see>
    /// </summary>
    let Input = _prefix "Input"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Procedure"></see>
    /// </summary>
    let Procedure = _prefix "Procedure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#LoggingIn"></see>
    /// </summary>
    let LoggingIn = _prefix "LoggingIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Output"></see>
    /// </summary>
    let Output = _prefix "Output"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Query"></see>
    /// </summary>
    let Query = _prefix "Query"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryLanguage"></see>
    /// </summary>
    let QueryLanguage = _prefix "QueryLanguage"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryPlan"></see>
    /// </summary>
    let QueryPlan = _prefix "QueryPlan"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Querying"></see>
    /// </summary>
    let Querying = _prefix "Querying"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Result"></see>
    /// </summary>
    let Result = _prefix "Result"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Request"></see>
    /// </summary>
    let Request = _prefix "Request"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchRequest"></see>
    /// </summary>
    let SearchRequest = _prefix "SearchRequest"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Searching"></see>
    /// </summary>
    let Searching = _prefix "Searching"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchResult"></see>
    /// </summary>
    let SearchResult = _prefix "SearchResult"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Template"></see>
    /// </summary>
    let Template = _prefix "Template"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasResult"></see>
    /// </summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingDateTime"></see>
    /// </summary>
    let hasSearchingDateTime = _prefix "hasSearchingDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingPeriod"></see>
    /// </summary>
    let hasSearchingPeriod = _prefix "hasSearchingPeriod"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSelected"></see>
    /// </summary>
    let hasSelected = _prefix "hasSelected"
    /// <summary>
    /// Used in builtin; expression syntax in the triple quoted literal:
    /// 		* "term1 term2": phrase of terms
    /// 		* term3 term4 : implicit AND of two terms
    /// 		* term3 OR term4 : explicit OR of two terms
    /// 		* -term5 : excluding the term
    /// 		* AND has higher precedence than OR.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#matchesExpression"></see></summary>
    let matchesExpression = _prefix "matchesExpression"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#resultOf"></see>
    /// </summary>
    let resultOf = _prefix "resultOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#searchingDuring"></see>
    /// </summary>
    let searchingDuring = _prefix "searchingDuring"
