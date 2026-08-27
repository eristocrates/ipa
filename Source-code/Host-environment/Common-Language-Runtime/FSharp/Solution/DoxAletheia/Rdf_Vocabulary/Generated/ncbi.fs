namespace https.www.ncbi.nlm.nih.gov.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ncbi =
    let _namespace_iri = Namespace_Iri ncbi |> NamespaceIRI
    /// <summary>
    ///   <para>ncbi:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.ncbi.nlm.nih.gov/">https://www.ncbi.nlm.nih.gov/</seealso>
    let _prefix_iri = Prefixed_Name(ncbi, "") |> PrefixedName
    /// <summary>
    ///   <para>ncbi:gene</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.ncbi.nlm.nih.gov/gene">https://www.ncbi.nlm.nih.gov/gene</seealso>
    let gene = Prefixed_Name(ncbi, "gene") |> PrefixedName
