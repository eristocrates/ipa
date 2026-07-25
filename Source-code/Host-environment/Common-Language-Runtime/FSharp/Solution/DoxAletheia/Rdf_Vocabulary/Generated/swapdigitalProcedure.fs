namespace http.eulersharp.sourceforge.net._2003._03swap.digitalProcedure.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapdigitalProcedure =
    let _namespace_iri = Namespace_Iri swapdigitalProcedure |> NamespaceIRI
    /// <summary>
    ///   <para>swapdigitalProcedure:QueryPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>query plan</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryPlan">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryPlan</seealso>
    let QueryPlan = Prefixed_Name(swapdigitalProcedure, "QueryPlan") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer request</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Request">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Request</seealso>
    let Request = Prefixed_Name(swapdigitalProcedure, "Request") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:SearchRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital search request</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchRequest">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchRequest</seealso>
    let SearchRequest =
        Prefixed_Name(swapdigitalProcedure, "SearchRequest") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:SearchResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital search result</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchResult">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#SearchResult</seealso>
    let SearchResult =
        Prefixed_Name(swapdigitalProcedure, "SearchResult") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#</seealso>
    let _prefix_iri = Prefixed_Name(swapdigitalProcedure, "") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:LoggingIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>logging in</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#LoggingIn">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#LoggingIn</seealso>
    let LoggingIn = Prefixed_Name(swapdigitalProcedure, "LoggingIn") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer procedure</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Procedure">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Procedure</seealso>
    let Procedure = Prefixed_Name(swapdigitalProcedure, "Procedure") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer output</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Output">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Output</seealso>
    let Output = Prefixed_Name(swapdigitalProcedure, "Output") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Query">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Query</seealso>
    let Query = Prefixed_Name(swapdigitalProcedure, "Query") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:QueryLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital query language</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryLanguage">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#QueryLanguage</seealso>
    let QueryLanguage =
        Prefixed_Name(swapdigitalProcedure, "QueryLanguage") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:Querying</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital querying</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Querying">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Querying</seealso>
    let Querying = Prefixed_Name(swapdigitalProcedure, "Querying") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital result</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Result">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Result</seealso>
    let Result = Prefixed_Name(swapdigitalProcedure, "Result") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:Searching</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital searching</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Searching">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Searching</seealso>
    let Searching = Prefixed_Name(swapdigitalProcedure, "Searching") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:Template</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital template</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Template">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Template</seealso>
    let Template = Prefixed_Name(swapdigitalProcedure, "Template") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasResult">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasResult</seealso>
    let hasResult = Prefixed_Name(swapdigitalProcedure, "hasResult") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:hasSearchingDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has searching date time</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingDateTime">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingDateTime</seealso>
    let hasSearchingDateTime =
        Prefixed_Name(swapdigitalProcedure, "hasSearchingDateTime") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:hasSearchingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has searching period</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingPeriod">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSearchingPeriod</seealso>
    let hasSearchingPeriod =
        Prefixed_Name(swapdigitalProcedure, "hasSearchingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:matchesExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used in builtin; expression syntax in the triple quoted literal:
    /// 		* "term1 term2": phrase of terms
    /// 		* term3 term4 : implicit AND of two terms
    /// 		* term3 OR term4 : explicit OR of two terms
    /// 		* -term5 : excluding the term
    /// 		* AND has higher precedence than OR.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#matchesExpression">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#matchesExpression</seealso>
    let matchesExpression =
        Prefixed_Name(swapdigitalProcedure, "matchesExpression") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:hasSelected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSelected">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#hasSelected</seealso>
    let hasSelected = Prefixed_Name(swapdigitalProcedure, "hasSelected") |> PrefixedName
    /// <summary>
    ///   <para>swapdigitalProcedure:resultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#resultOf">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#resultOf</seealso>
    let resultOf = Prefixed_Name(swapdigitalProcedure, "resultOf") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:searchingDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>searching during</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#searchingDuring">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#searchingDuring</seealso>
    let searchingDuring =
        Prefixed_Name(swapdigitalProcedure, "searchingDuring") |> PrefixedName

    /// <summary>
    ///   <para>swapdigitalProcedure:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer input</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Input">http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#Input</seealso>
    let Input = Prefixed_Name(swapdigitalProcedure, "Input") |> PrefixedName
