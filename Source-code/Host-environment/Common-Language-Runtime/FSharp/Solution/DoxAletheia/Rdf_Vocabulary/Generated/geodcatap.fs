namespace http.data.europa.eu._930.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geodcatap =
    let _namespace_iri = Namespace_Iri geodcatap |> NamespaceIRI
    /// <summary>
    ///   <para>geodcatap:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/930/">http://data.europa.eu/930/</seealso>
    let _prefix_iri = Prefixed_Name(geodcatap, "") |> PrefixedName
