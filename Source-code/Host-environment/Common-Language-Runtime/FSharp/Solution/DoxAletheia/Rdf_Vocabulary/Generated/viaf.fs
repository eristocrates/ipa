namespace http.viaf.org.viaf.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module viaf =
    let _namespace_iri = Namespace_Iri viaf |> NamespaceIRI
    /// <summary>
    ///   <para>viaf:136069274</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Organization</para>
    ///
    /// labels<para>"OCLC Research"</para></remarks>
    /// <seealso href="http://viaf.org/viaf/136069274">http://viaf.org/viaf/136069274</seealso>
    let _136069274 = Prefixed_Name(viaf, "136069274") |> PrefixedName
