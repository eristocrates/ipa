namespace http.eulersharp.sourceforge.net._2003._03swap.sparqlAnalysisTemplate.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapsparqlAnalysisTemplate =
    let _namespace_iri = Namespace_Iri swapsparqlAnalysisTemplate |> NamespaceIRI
    /// <summary>
    ///   <para>swapsparqlAnalysisTemplate:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#</seealso>
    let _prefix_iri = Prefixed_Name(swapsparqlAnalysisTemplate, "") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysisTemplate:AnalysisResultBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"analysis result binding"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#AnalysisResultBinding">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#AnalysisResultBinding</seealso>
    let AnalysisResultBinding =
        Prefixed_Name(swapsparqlAnalysisTemplate, "AnalysisResultBinding") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysisTemplate:ClinicalAnalysisQueryTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"clinical analysis SPARQL query template"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplate">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplate</seealso>
    let ClinicalAnalysisQueryTemplate =
        Prefixed_Name(swapsparqlAnalysisTemplate, "ClinicalAnalysisQueryTemplate") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysisTemplate:ClinicalAnalysisQueryTemplateBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"clinical analysis SPARQL query template binding"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplateBinding">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisQueryTemplateBinding</seealso>
    let ClinicalAnalysisQueryTemplateBinding =
        Prefixed_Name(swapsparqlAnalysisTemplate, "ClinicalAnalysisQueryTemplateBinding") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysisTemplate:ClinicalAnalysisResultBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"clinical analysis result binding"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisResultBinding">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#ClinicalAnalysisResultBinding</seealso>
    let ClinicalAnalysisResultBinding =
        Prefixed_Name(swapsparqlAnalysisTemplate, "ClinicalAnalysisResultBinding") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysisTemplate:resultBindingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#resultBindingOf">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#resultBindingOf</seealso>
    let resultBindingOf =
        Prefixed_Name(swapsparqlAnalysisTemplate, "resultBindingOf") |> PrefixedName
