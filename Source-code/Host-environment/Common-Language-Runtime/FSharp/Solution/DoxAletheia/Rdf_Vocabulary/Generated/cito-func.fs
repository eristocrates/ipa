namespace http.www.essepuntato.it._2013._03.cito_functions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cito_func =
    let _namespace_iri = Namespace_Iri cito_func |> NamespaceIRI

    /// <summary>
    ///   <para>cito-func:NegativeRhetoricalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class defining the set of citation types having a negative rhetorical function.</para>
    /// labels<para>negative rhetorical function</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/03/cito-functions/NegativeRhetoricalFunction">http://www.essepuntato.it/2013/03/cito-functions/NegativeRhetoricalFunction</seealso>
    let NegativeRhetoricalFunction =
        Prefixed_Name(cito_func, "NegativeRhetoricalFunction") |> PrefixedName

    /// <summary>
    ///   <para>cito-func:RhetoricalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class defining the set of citation types having a particular rhetorical function.</para>
    /// labels<para>rhetorical function</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/03/cito-functions/RhetoricalFunction">http://www.essepuntato.it/2013/03/cito-functions/RhetoricalFunction</seealso>
    let RhetoricalFunction =
        Prefixed_Name(cito_func, "RhetoricalFunction") |> PrefixedName

    /// <summary>
    ///   <para>cito-func:PositiveRhetoricalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class defining the set of citation types having a positive rhetorical function.</para>
    /// labels<para>positive rhetorical function</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/03/cito-functions/PositiveRhetoricalFunction">http://www.essepuntato.it/2013/03/cito-functions/PositiveRhetoricalFunction</seealso>
    let PositiveRhetoricalFunction =
        Prefixed_Name(cito_func, "PositiveRhetoricalFunction") |> PrefixedName

    /// <summary>
    ///   <para>cito-func:FactualFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class defining the set of citation types having a factual function.</para>
    /// labels<para>factual function</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/03/cito-functions/FactualFunction">http://www.essepuntato.it/2013/03/cito-functions/FactualFunction</seealso>
    let FactualFunction = Prefixed_Name(cito_func, "FactualFunction") |> PrefixedName
    /// <summary>
    ///   <para>cito-func:CitationFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class defining the set of citation types having a particular function.</para>
    /// labels<para>citation function</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/03/cito-functions/CitationFunction">http://www.essepuntato.it/2013/03/cito-functions/CitationFunction</seealso>
    let CitationFunction = Prefixed_Name(cito_func, "CitationFunction") |> PrefixedName

    /// <summary>
    ///   <para>cito-func:NeutralRhetoricalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class defining the set of citation types having a neutral rhetorical function.</para>
    /// labels<para>neutral rhetorical function</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2013/03/cito-functions/NeutralRhetoricalFunction">http://www.essepuntato.it/2013/03/cito-functions/NeutralRhetoricalFunction</seealso>
    let NeutralRhetoricalFunction =
        Prefixed_Name(cito_func, "NeutralRhetoricalFunction") |> PrefixedName
