namespace http.spdx.org.rdf.terms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spdxterms =
    let _namespace_iri = Namespace_Iri spdxterms |> NamespaceIRI
    /// <summary>
    ///   <para>spdxterms:ListedLicense</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spdx.org/rdf/terms#ListedLicense">http://spdx.org/rdf/terms#ListedLicense</seealso>
    let ListedLicense = Prefixed_Name(spdxterms, "ListedLicense") |> PrefixedName
    /// <summary>
    ///   <para>spdxterms:checksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://spdx.org/rdf/terms#checksum">http://spdx.org/rdf/terms#checksum</seealso>
    let checksum = Prefixed_Name(spdxterms, "checksum") |> PrefixedName
