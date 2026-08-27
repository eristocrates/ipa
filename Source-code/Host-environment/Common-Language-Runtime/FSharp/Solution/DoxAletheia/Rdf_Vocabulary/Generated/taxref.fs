namespace http.taxref.mnhn.fr.lod.taxon.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module taxref =
    let _namespace_iri = Namespace_Iri taxref |> NamespaceIRI
    /// <summary>
    ///   <para>taxref-ld:taxon/349525</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biota"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxon/349525">http://taxref.mnhn.fr/lod/taxon/349525</seealso>
    let _349525 = Prefixed_Name(taxref, "349525") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:taxon/60878</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/taxon/60878">http://taxref.mnhn.fr/lod/taxon/60878</seealso>
    let _60878 = Prefixed_Name(taxref, "60878") |> PrefixedName
