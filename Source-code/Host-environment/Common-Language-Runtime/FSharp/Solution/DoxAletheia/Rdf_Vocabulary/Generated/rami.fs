namespace https.w3id.org.i40.rami.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rami =
    let _namespace_iri = Namespace_Iri rami |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:i40/rami/RAMIHierarchyLevel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/i40/rami/RAMIHierarchyLevel">https://w3id.org/i40/rami/RAMIHierarchyLevel</seealso>
    let RAMIHierarchyLevel = Prefixed_Name(rami, "RAMIHierarchyLevel") |> PrefixedName
