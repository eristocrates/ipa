namespace http.purl.org.swan._2._0.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swan =
    let _namespace_iri = Namespace_Iri swan |> NamespaceIRI

    /// <summary>
    ///   <para>swan:discourse-elements/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-elements/">http://purl.org/swan/2.0/discourse-elements/</seealso>
    let ``discourse_elements/`` =
        Prefixed_Name(swan, "discourse-elements/") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-relationships/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/">http://purl.org/swan/2.0/discourse-relationships/</seealso>
    let ``discourse_relationships/`` =
        Prefixed_Name(swan, "discourse-relationships/") |> PrefixedName

    /// <summary>
    ///   <para>swan:agents/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/swan/2.0/agents/">http://purl.org/swan/2.0/agents/</seealso>
    let ``agents/`` = Prefixed_Name(swan, "agents/") |> PrefixedName
    /// <summary>
    ///   <para>swan:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>SWAN ontology v. 2.0</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/">http://purl.org/swan/2.0/</seealso>
    let _prefix_iri = Prefixed_Name(swan, "") |> PrefixedName
