namespace http.www.w3.org._2006._03.wn.wn20.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wn20 =
    let _namespace_iri = Namespace_Iri wn20 |> NamespaceIRI

    /// <summary>
    ///   <para>wn20:instances/synset-staff-noun-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/instances/synset-staff-noun-1">http://www.w3.org/2006/03/wn/wn20/instances/synset-staff-noun-1</seealso>
    let ``instances/synset_staff_noun_1`` =
        Prefixed_Name(wn20, "instances/synset-staff-noun-1") |> PrefixedName
