namespace https.w3id.org.fr.def.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fr =
    let _namespace_iri = Namespace_Iri fr |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:fr/def/core#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/fr/def/core#">https://w3id.org/fr/def/core#</seealso>
    let _prefix_iri = Prefixed_Name(fr, "") |> PrefixedName
