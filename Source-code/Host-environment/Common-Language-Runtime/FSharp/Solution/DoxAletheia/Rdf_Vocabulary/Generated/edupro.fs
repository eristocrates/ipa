namespace http.ns.inria.fr.semed.eduprogression.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module edupro =
    let _namespace_iri = Namespace_Iri edupro |> NamespaceIRI
    /// <summary>
    ///   <para>edupro:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression#">http://ns.inria.fr/semed/eduprogression#</seealso>
    let _prefix_iri = Prefixed_Name(edupro, "") |> PrefixedName
