namespace https.w3id.org.amv.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3amv =
    let _namespace_iri = Namespace_Iri w3amv |> NamespaceIRI
    /// <summary>
    ///   <para>w3amv:1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/amv/1.0">https://w3id.org/amv/1.0</seealso>
    let ``_1.0`` = Prefixed_Name(w3amv, "1.0") |> PrefixedName
