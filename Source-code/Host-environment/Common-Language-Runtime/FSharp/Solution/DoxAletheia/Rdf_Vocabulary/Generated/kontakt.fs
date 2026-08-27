namespace http.richard.cyganiak.de.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module kontakt =
    let _namespace_iri = Namespace_Iri kontakt |> NamespaceIRI
    /// <summary>
    ///   <para>kontakt:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://richard.cyganiak.de/">http://richard.cyganiak.de/</seealso>
    let _prefix_iri = Prefixed_Name(kontakt, "") |> PrefixedName
    /// <summary>
    ///   <para>kontakt:foaf.rdf#cygri</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://richard.cyganiak.de/foaf.rdf#cygri">http://richard.cyganiak.de/foaf.rdf#cygri</seealso>
    let ``foaf.rdf#cygri`` = Prefixed_Name(kontakt, "foaf.rdf#cygri") |> PrefixedName
