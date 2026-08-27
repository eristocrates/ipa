namespace http.data.europa.eu.s1n.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module statdcatap =
    let _namespace_iri = Namespace_Iri statdcatap |> NamespaceIRI
    /// <summary>
    ///   <para>statdcatap:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/s1n/">http://data.europa.eu/s1n/</seealso>
    let _prefix_iri = Prefixed_Name(statdcatap, "") |> PrefixedName
