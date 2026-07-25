namespace http.purl.org.spar.bido.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sparbido =
    let _namespace_iri = Namespace_Iri sparbido |> NamespaceIRI
    /// <summary>
    ///   <para>sparbido:bido.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/bido/bido.png">http://purl.org/spar/bido/bido.png</seealso>
    let ``bido.png`` = Prefixed_Name(sparbido, "bido.png") |> PrefixedName
    /// <summary>
    ///   <para>sparbido:2015-07-13</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/bido/2015-07-13">http://purl.org/spar/bido/2015-07-13</seealso>
    let _2015_07_13 = Prefixed_Name(sparbido, "2015-07-13") |> PrefixedName
