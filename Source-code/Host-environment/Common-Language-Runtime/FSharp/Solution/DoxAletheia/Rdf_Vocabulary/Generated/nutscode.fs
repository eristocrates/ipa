namespace http.data.europa.eu.nuts.code.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nutscode =
    let _namespace_iri = Namespace_Iri nutscode |> NamespaceIRI
    /// <summary>
    ///   <para>nutscode:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A NUTS code (Nomenclature of territorial units for statistics)."</para>
    /// labels<para>"NutsResource"</para></remarks>
    /// <seealso href="http://data.europa.eu/nuts/code/">http://data.europa.eu/nuts/code/</seealso>
    let _prefix_iri = Prefixed_Name(nutscode, "") |> PrefixedName
