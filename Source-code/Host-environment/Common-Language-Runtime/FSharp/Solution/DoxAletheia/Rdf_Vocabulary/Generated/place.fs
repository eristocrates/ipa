namespace http.purl.org.ontology.places.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module place =
    let _namespace_iri = Namespace_Iri place |> NamespaceIRI
    /// <summary>
    ///   <para>place:#michael</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/places/#michael">http://purl.org/ontology/places/#michael</seealso>
    let ``_#michael`` = Prefixed_Name(place, "#michael") |> PrefixedName
    /// <summary>
    ///   <para>place:#rob</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/places/#rob">http://purl.org/ontology/places/#rob</seealso>
    let ``_#rob`` = Prefixed_Name(place, "#rob") |> PrefixedName
    /// <summary>
    ///   <para>place:#tom</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/places/#tom">http://purl.org/ontology/places/#tom</seealso>
    let ``_#tom`` = Prefixed_Name(place, "#tom") |> PrefixedName
    /// <summary>
    ///   <para>place:road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/places/road">http://purl.org/ontology/places/road</seealso>
    let road = Prefixed_Name(place, "road") |> PrefixedName
