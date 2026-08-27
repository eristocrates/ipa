namespace http.dublincore.org.dcx.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcx =
    let _namespace_iri = Namespace_Iri dcx |> NamespaceIRI
    /// <summary>
    ///   <para>dcx:lrmi-terms/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dublincore.org/dcx/lrmi-terms/">http://dublincore.org/dcx/lrmi-terms/</seealso>
    let ``lrmi_terms/`` = Prefixed_Name(dcx, "lrmi-terms/") |> PrefixedName
