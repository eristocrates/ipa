namespace http.eulersharp.sourceforge.net._2003._03swap.sparql.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapsparql =
    let _namespace_iri = Namespace_Iri swapsparql |> NamespaceIRI
    /// <summary>
    ///   <para>swapsparql:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SPARQL query</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Query">http://eulersharp.sourceforge.net/2003/03swap/sparql#Query</seealso>
    let Query = Prefixed_Name(swapsparql, "Query") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SPARQL result</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Result">http://eulersharp.sourceforge.net/2003/03swap/sparql#Result</seealso>
    let Result = Prefixed_Name(swapsparql, "Result") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:Template</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SPARQL query template</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Template">http://eulersharp.sourceforge.net/2003/03swap/sparql#Template</seealso>
    let Template = Prefixed_Name(swapsparql, "Template") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:TemplateBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SPARQL query template binding</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#TemplateBinding">http://eulersharp.sourceforge.net/2003/03swap/sparql#TemplateBinding</seealso>
    let TemplateBinding = Prefixed_Name(swapsparql, "TemplateBinding") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:hasBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasBinding">http://eulersharp.sourceforge.net/2003/03swap/sparql#hasBinding</seealso>
    let hasBinding = Prefixed_Name(swapsparql, "hasBinding") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:hasQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasQuery">http://eulersharp.sourceforge.net/2003/03swap/sparql#hasQuery</seealso>
    let hasQuery = Prefixed_Name(swapsparql, "hasQuery") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#">http://eulersharp.sourceforge.net/2003/03swap/sparql#</seealso>
    let _prefix_iri = Prefixed_Name(swapsparql, "") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:Endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SPARQL endpoint</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Endpoint">http://eulersharp.sourceforge.net/2003/03swap/sparql#Endpoint</seealso>
    let Endpoint = Prefixed_Name(swapsparql, "Endpoint") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:Querying</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SPARQL querying</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#Querying">http://eulersharp.sourceforge.net/2003/03swap/sparql#Querying</seealso>
    let Querying = Prefixed_Name(swapsparql, "Querying") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:SPARQL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SPARQL</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#SPARQL">http://eulersharp.sourceforge.net/2003/03swap/sparql#SPARQL</seealso>
    let SPARQL = Prefixed_Name(swapsparql, "SPARQL") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:executedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#executedOn">http://eulersharp.sourceforge.net/2003/03swap/sparql#executedOn</seealso>
    let executedOn = Prefixed_Name(swapsparql, "executedOn") |> PrefixedName
    /// <summary>
    ///   <para>swapsparql:hasTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/sparql#hasTemplate">http://eulersharp.sourceforge.net/2003/03swap/sparql#hasTemplate</seealso>
    let hasTemplate = Prefixed_Name(swapsparql, "hasTemplate") |> PrefixedName
