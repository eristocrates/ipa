namespace http.proton.semanticweb.org.protonsys.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module psys =
    let _namespace_iri = Namespace_Iri psys |> NamespaceIRI
    /// <summary>
    ///   <para>psys:transitiveOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://proton.semanticweb.org/protonsys#transitiveOver">http://proton.semanticweb.org/protonsys#transitiveOver</seealso>
    let transitiveOver = Prefixed_Name(psys, "transitiveOver") |> PrefixedName
