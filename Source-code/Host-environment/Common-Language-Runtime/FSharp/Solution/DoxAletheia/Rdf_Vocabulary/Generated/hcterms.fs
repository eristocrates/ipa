namespace http.purl.org.uF.hCard.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hcterms =
    let _namespace_iri = Namespace_Iri hcterms |> NamespaceIRI
    /// <summary>
    ///   <para>hcterms:hasCard</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/uF/hCard/terms/hasCard">http://purl.org/uF/hCard/terms/hasCard</seealso>
    let hasCard = Prefixed_Name(hcterms, "hasCard") |> PrefixedName
