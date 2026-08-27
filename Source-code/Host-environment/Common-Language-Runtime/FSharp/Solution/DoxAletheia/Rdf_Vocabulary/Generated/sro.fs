namespace http.salt.semanticauthoring.org.ontologies.sro.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sro =
    let _namespace_iri = Namespace_Iri sro |> NamespaceIRI
    /// <summary>
    ///   <para>sro:Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Abstract">http://salt.semanticauthoring.org/ontologies/sro#Abstract</seealso>
    let Abstract = Prefixed_Name(sro, "Abstract") |> PrefixedName
    /// <summary>
    ///   <para>sro:Background</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Background">http://salt.semanticauthoring.org/ontologies/sro#Background</seealso>
    let Background = Prefixed_Name(sro, "Background") |> PrefixedName
    /// <summary>
    ///   <para>sro:Conclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Conclusion">http://salt.semanticauthoring.org/ontologies/sro#Conclusion</seealso>
    let Conclusion = Prefixed_Name(sro, "Conclusion") |> PrefixedName
    /// <summary>
    ///   <para>sro:Contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Contribution">http://salt.semanticauthoring.org/ontologies/sro#Contribution</seealso>
    let Contribution = Prefixed_Name(sro, "Contribution") |> PrefixedName
    /// <summary>
    ///   <para>sro:Discussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Discussion">http://salt.semanticauthoring.org/ontologies/sro#Discussion</seealso>
    let Discussion = Prefixed_Name(sro, "Discussion") |> PrefixedName
    /// <summary>
    ///   <para>sro:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Evaluation">http://salt.semanticauthoring.org/ontologies/sro#Evaluation</seealso>
    let Evaluation = Prefixed_Name(sro, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>sro:Motivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Motivation">http://salt.semanticauthoring.org/ontologies/sro#Motivation</seealso>
    let Motivation = Prefixed_Name(sro, "Motivation") |> PrefixedName
    /// <summary>
    ///   <para>sro:Scenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sro#Scenario">http://salt.semanticauthoring.org/ontologies/sro#Scenario</seealso>
    let Scenario = Prefixed_Name(sro, "Scenario") |> PrefixedName
