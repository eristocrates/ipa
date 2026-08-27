namespace http.vocab.deri.ie.raul.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ieraul =
    let _namespace_iri = Namespace_Iri ieraul |> NamespaceIRI
    /// <summary>
    ///   <para>ieraul:CSIRO</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#CSIRO">http://vocab.deri.ie/raul#CSIRO</seealso>
    let CSIRO = Prefixed_Name(ieraul, "CSIRO") |> PrefixedName
    /// <summary>
    ///   <para>ieraul:DERI</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#DERI">http://vocab.deri.ie/raul#DERI</seealso>
    let DERI = Prefixed_Name(ieraul, "DERI") |> PrefixedName
    /// <summary>
    ///   <para>ieraul:LiDRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#LiDRC">http://vocab.deri.ie/raul#LiDRC</seealso>
    let LiDRC = Prefixed_Name(ieraul, "LiDRC") |> PrefixedName

    /// <summary>
    ///   <para>ieraul:Michael%20Hausenblas</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#Michael%20Hausenblas">http://vocab.deri.ie/raul#Michael%20Hausenblas</seealso>
    let ``Michael%20Hausenblas`` =
        Prefixed_Name(ieraul, "Michael%20Hausenblas") |> PrefixedName

    /// <summary>
    ///   <para>ieraul:ahaller</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#ahaller">http://vocab.deri.ie/raul#ahaller</seealso>
    let ahaller = Prefixed_Name(ieraul, "ahaller") |> PrefixedName
    /// <summary>
    ///   <para>ieraul:juum</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#juum">http://vocab.deri.ie/raul#juum</seealso>
    let juum = Prefixed_Name(ieraul, "juum") |> PrefixedName
    /// <summary>
    ///   <para>ieraul:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#rdf">http://vocab.deri.ie/raul#rdf</seealso>
    let rdf = Prefixed_Name(ieraul, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>ieraul:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/raul#ttl">http://vocab.deri.ie/raul#ttl</seealso>
    let ttl = Prefixed_Name(ieraul, "ttl") |> PrefixedName
