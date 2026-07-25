namespace https.w3id.org.CEMontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cem =
    let _namespace_iri = Namespace_Iri cem |> NamespaceIRI
    /// <summary>
    ///   <para>cem:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/CEMontology/">https://w3id.org/CEMontology/</seealso>
    let _prefix_iri = Prefixed_Name(cem, "") |> PrefixedName
