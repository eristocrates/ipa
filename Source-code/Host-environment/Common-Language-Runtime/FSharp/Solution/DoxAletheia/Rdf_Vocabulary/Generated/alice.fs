namespace http.example.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module alice =
    let _namespace_iri = Namespace_Iri alice |> NamespaceIRI

    /// <summary>
    ///   <para>alice:aResourceRelatedToThisLogEntry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://example.org/aResourceRelatedToThisLogEntry">http://example.org/aResourceRelatedToThisLogEntry</seealso>
    let aResourceRelatedToThisLogEntry =
        Prefixed_Name(alice, "aResourceRelatedToThisLogEntry") |> PrefixedName

    /// <summary>
    ///   <para>alice:uri/schema/FRBRentitiesRDA/Expression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://example.org/uri/schema/FRBRentitiesRDA/Expression">http://example.org/uri/schema/FRBRentitiesRDA/Expression</seealso>
    let ``uri/schema/FRBRentitiesRDA/Expression`` =
        Prefixed_Name(alice, "uri/schema/FRBRentitiesRDA/Expression") |> PrefixedName
