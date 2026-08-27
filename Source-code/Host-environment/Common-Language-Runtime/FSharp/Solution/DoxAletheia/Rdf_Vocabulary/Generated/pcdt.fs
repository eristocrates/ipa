namespace http.purl.org.procurement.public_contracts_datatypes.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pcdt =
    let _namespace_iri = Namespace_Iri pcdt |> NamespaceIRI
    /// <summary>
    ///   <para>pcdt:percentage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts-datatypes#percentage">http://purl.org/procurement/public-contracts-datatypes#percentage</seealso>
    let percentage = Prefixed_Name(pcdt, "percentage") |> PrefixedName
