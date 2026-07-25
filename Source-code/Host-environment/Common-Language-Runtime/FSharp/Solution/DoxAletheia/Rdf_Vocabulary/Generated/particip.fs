namespace http.purl.org.vocab.participation.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module particip =
    let _namespace_iri = Namespace_Iri particip |> NamespaceIRI
    /// <summary>
    ///   <para>particip:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/participation/schema#">http://purl.org/vocab/participation/schema#</seealso>
    let _prefix_iri = Prefixed_Name(particip, "") |> PrefixedName
