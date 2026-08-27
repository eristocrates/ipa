namespace http.data.europa.eu.r5r.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcatap =
    let _namespace_iri = Namespace_Iri dcatap |> NamespaceIRI
    /// <summary>
    ///   <para>dcatap:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/r5r/">http://data.europa.eu/r5r/</seealso>
    let _prefix_iri = Prefixed_Name(dcatap, "") |> PrefixedName
