namespace http.dati.gov.it.onto.dcatapit.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcatapit =
    let _namespace_iri = Namespace_Iri dcatapit |> NamespaceIRI
    /// <summary>
    ///   <para>dcatapit:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.gov.it/onto/dcatapit#Agent">http://dati.gov.it/onto/dcatapit#Agent</seealso>
    let Agent = Prefixed_Name(dcatapit, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>dcatapit:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.gov.it/onto/dcatapit#Organization">http://dati.gov.it/onto/dcatapit#Organization</seealso>
    let Organization = Prefixed_Name(dcatapit, "Organization") |> PrefixedName
