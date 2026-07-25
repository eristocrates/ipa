namespace http.eulersharp.sourceforge.net._2003._03swap.sparqlAnalysis.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapsparqlAnalysis =
    let _namespace_iri = Namespace_Iri swapsparqlAnalysis |> NamespaceIRI
    /// <summary>
    ///   <para>swapsparqlAnalysis:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#</seealso>
    let _prefix_iri = Prefixed_Name(swapsparqlAnalysis, "") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:AnalysisQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>analysis SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#AnalysisQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#AnalysisQuery</seealso>
    let AnalysisQuery =
        Prefixed_Name(swapsparqlAnalysis, "AnalysisQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:CancelledClinicalAnalysisQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>cancelled clinical analysis SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CancelledClinicalAnalysisQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CancelledClinicalAnalysisQuery</seealso>
    let CancelledClinicalAnalysisQuery =
        Prefixed_Name(swapsparqlAnalysis, "CancelledClinicalAnalysisQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:ClinicalAnalysisQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>clinical analysis SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisQuery</seealso>
    let ClinicalAnalysisQuery =
        Prefixed_Name(swapsparqlAnalysis, "ClinicalAnalysisQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:hasDataSetQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataSetQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataSetQuery</seealso>
    let hasDataSetQuery =
        Prefixed_Name(swapsparqlAnalysis, "hasDataSetQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:ClinicalDataSetQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>clinical data set SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataSetQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataSetQuery</seealso>
    let ClinicalDataSetQuery =
        Prefixed_Name(swapsparqlAnalysis, "ClinicalDataSetQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:ClinicalAnalysisResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>clinical analysis result</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisResult">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalAnalysisResult</seealso>
    let ClinicalAnalysisResult =
        Prefixed_Name(swapsparqlAnalysis, "ClinicalAnalysisResult") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:ClinicalDataRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataRepository">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#ClinicalDataRepository</seealso>
    let ClinicalDataRepository =
        Prefixed_Name(swapsparqlAnalysis, "ClinicalDataRepository") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:DataRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataRepository">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataRepository</seealso>
    let DataRepository =
        Prefixed_Name(swapsparqlAnalysis, "DataRepository") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:DataSetQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>data set SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataSetQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#DataSetQuery</seealso>
    let DataSetQuery = Prefixed_Name(swapsparqlAnalysis, "DataSetQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:CompletedClinicalAnalysisQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>completed clinical analysis SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CompletedClinicalAnalysisQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#CompletedClinicalAnalysisQuery</seealso>
    let CompletedClinicalAnalysisQuery =
        Prefixed_Name(swapsparqlAnalysis, "CompletedClinicalAnalysisQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:InvalidClinicalAnalysisResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>invalid clinical analysis result</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalAnalysisResult">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalAnalysisResult</seealso>
    let InvalidClinicalAnalysisResult =
        Prefixed_Name(swapsparqlAnalysis, "InvalidClinicalAnalysisResult") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:InvalidClinicalDataSetQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>invalid clinical data set SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalDataSetQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#InvalidClinicalDataSetQuery</seealso>
    let InvalidClinicalDataSetQuery =
        Prefixed_Name(swapsparqlAnalysis, "InvalidClinicalDataSetQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:SubmittedClinicalAnalysisQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>submitted clinical analysis SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#SubmittedClinicalAnalysisQuery">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#SubmittedClinicalAnalysisQuery</seealso>
    let SubmittedClinicalAnalysisQuery =
        Prefixed_Name(swapsparqlAnalysis, "SubmittedClinicalAnalysisQuery") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:dataRepositoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataRepositoryOf">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataRepositoryOf</seealso>
    let dataRepositoryOf =
        Prefixed_Name(swapsparqlAnalysis, "dataRepositoryOf") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:hasDataRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataRepository">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#hasDataRepository</seealso>
    let hasDataRepository =
        Prefixed_Name(swapsparqlAnalysis, "hasDataRepository") |> PrefixedName

    /// <summary>
    ///   <para>swapsparqlAnalysis:dataSetQueryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataSetQueryOf">http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#dataSetQueryOf</seealso>
    let dataSetQueryOf =
        Prefixed_Name(swapsparqlAnalysis, "dataSetQueryOf") |> PrefixedName
