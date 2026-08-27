namespace http.www.w3.org.ns.legal.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module legal =
    let _namespace_iri = Namespace_Iri legal |> NamespaceIRI
    /// <summary>
    ///   <para>legal:LegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Legal Entity"</para><para>"Entità Legale"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/legal#LegalEntity">http://www.w3.org/ns/legal#LegalEntity</seealso>
    let LegalEntity = Prefixed_Name(legal, "LegalEntity") |> PrefixedName
