namespace http.www.lingvoj.org.olca.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module olca =
    let _namespace_iri = Namespace_Iri olca |> NamespaceIRI
    /// <summary>
    ///   <para>olca:domainIncludes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.lingvoj.org/olca#domainIncludes">http://www.lingvoj.org/olca#domainIncludes</seealso>
    let domainIncludes = Prefixed_Name(olca, "domainIncludes") |> PrefixedName
    /// <summary>
    ///   <para>olca:rangeIncludes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.lingvoj.org/olca#rangeIncludes">http://www.lingvoj.org/olca#rangeIncludes</seealso>
    let rangeIncludes = Prefixed_Name(olca, "rangeIncludes") |> PrefixedName
