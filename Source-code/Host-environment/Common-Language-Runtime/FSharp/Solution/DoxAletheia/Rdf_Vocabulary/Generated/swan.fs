namespace http.purl.org.swan._2._0.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swan =
    let _namespace_iri = Namespace_Iri swan |> NamespaceIRI
    /// <summary>
    ///   <para>swan:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"SWAN ontology v. 2.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/">http://purl.org/swan/2.0/</seealso>
    let _prefix_iri = Prefixed_Name(swan, "") |> PrefixedName
    /// <summary>
    ///   <para>swan:agents/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/swan/2.0/agents/">http://purl.org/swan/2.0/agents/</seealso>
    let ``agents/`` = Prefixed_Name(swan, "agents/") |> PrefixedName
    /// <summary>
    ///   <para>swan:foaf-essential/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/swan/2.0/foaf-essential/">http://purl.org/swan/2.0/foaf-essential/</seealso>
    let ``foaf_essential/`` = Prefixed_Name(swan, "foaf-essential/") |> PrefixedName
