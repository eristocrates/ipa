namespace http.www.w3.org._1999.xhtml.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module html =
    let _namespace_iri = Namespace_Iri html |> NamespaceIRI
    /// <summary>
    ///   <para>html:vocab</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab">http://www.w3.org/1999/xhtml/vocab</seealso>
    let vocab = Prefixed_Name(html, "vocab") |> PrefixedName
