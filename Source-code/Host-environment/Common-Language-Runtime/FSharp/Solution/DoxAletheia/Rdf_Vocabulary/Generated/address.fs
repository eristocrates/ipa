namespace http.schemas.talis.com._2005.address.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module address =
    let _namespace_iri = Namespace_Iri address |> NamespaceIRI
    /// <summary>
    ///   <para>address:localityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://schemas.talis.com/2005/address/schema#localityName">http://schemas.talis.com/2005/address/schema#localityName</seealso>
    let localityName = Prefixed_Name(address, "localityName") |> PrefixedName
