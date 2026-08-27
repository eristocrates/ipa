namespace http.example.com.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module meat =
    let _namespace_iri = Namespace_Iri meat |> NamespaceIRI
    /// <summary>
    ///   <para>meat:bfo-spec-label</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://example.com/bfo-spec-label">http://example.com/bfo-spec-label</seealso>
    let bfo_spec_label = Prefixed_Name(meat, "bfo-spec-label") |> PrefixedName
