namespace https.w3id.org.affectedBy.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aff =
    let _namespace_iri = Namespace_Iri aff |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:affectedBy#Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/affectedBy#Quality">https://w3id.org/affectedBy#Quality</seealso>
    let Quality = Prefixed_Name(aff, "Quality") |> PrefixedName
