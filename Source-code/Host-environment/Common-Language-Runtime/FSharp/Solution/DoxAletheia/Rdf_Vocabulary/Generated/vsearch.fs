namespace http.purl.org.vsearch.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vsearch =
    let _namespace_iri = Namespace_Iri vsearch |> NamespaceIRI
    /// <summary>
    ///   <para>vsearch:ResultTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A result term.</para>
    /// labels<para>result term</para></remarks>
    /// <seealso href="http://purl.org/vsearch/ResultTerm">http://purl.org/vsearch/ResultTerm</seealso>
    let ResultTerm = Prefixed_Name(vsearch, "ResultTerm") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:hasRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The rank for a result term.</para>
    /// labels<para>has rank</para></remarks>
    /// <seealso href="http://purl.org/vsearch/hasRank">http://purl.org/vsearch/hasRank</seealso>
    let hasRank = Prefixed_Name(vsearch, "hasRank") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:rankValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The rank value of a term's ranking.</para>
    /// labels<para>rank value</para></remarks>
    /// <seealso href="http://purl.org/vsearch/rankValue">http://purl.org/vsearch/rankValue</seealso>
    let rankValue = Prefixed_Name(vsearch, "rankValue") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:doQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A query that an entity executes.</para>
    /// labels<para>do query</para></remarks>
    /// <seealso href="http://purl.org/vsearch/doQuery">http://purl.org/vsearch/doQuery</seealso>
    let doQuery = Prefixed_Name(vsearch, "doQuery") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The keyword of the query.</para>
    /// labels<para>keyword</para></remarks>
    /// <seealso href="http://purl.org/vsearch/keyword">http://purl.org/vsearch/keyword</seealso>
    let keyword = Prefixed_Name(vsearch, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:hasResultTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A result term for a query.</para>
    /// labels<para>has result term</para></remarks>
    /// <seealso href="http://purl.org/vsearch/hasResultTerm">http://purl.org/vsearch/hasResultTerm</seealso>
    let hasResultTerm = Prefixed_Name(vsearch, "hasResultTerm") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The language of the query keyword.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://purl.org/vsearch/language">http://purl.org/vsearch/language</seealso>
    let language = Prefixed_Name(vsearch, "language") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:termURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The URI of the result term.</para>
    /// labels<para>term URI</para></remarks>
    /// <seealso href="http://purl.org/vsearch/termURI">http://purl.org/vsearch/termURI</seealso>
    let termURI = Prefixed_Name(vsearch, "termURI") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vsearch/">http://purl.org/vsearch/</seealso>
    let _prefix_iri = Prefixed_Name(vsearch, "") |> PrefixedName
    /// <summary>
    ///   <para>vsearch:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A query.</para>
    /// labels<para>query</para></remarks>
    /// <seealso href="http://purl.org/vsearch/Query">http://purl.org/vsearch/Query</seealso>
    let Query = Prefixed_Name(vsearch, "Query") |> PrefixedName
