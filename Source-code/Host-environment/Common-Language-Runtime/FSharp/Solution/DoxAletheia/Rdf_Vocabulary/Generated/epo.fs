namespace http.data.europa.eu.a4g.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module epo =
    let _namespace_iri = Namespace_Iri epo |> NamespaceIRI
    /// <summary>
    ///   <para>epo:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A voluntary, deliberate, and legally binding agreement between two or more competent parties. Additional information: This includes concession contracts. (WG approval 01/06/2018)"</para>
    /// labels<para>"Contract"</para></remarks>
    /// <seealso href="http://data.europa.eu/a4g/ontology#Contract">http://data.europa.eu/a4g/ontology#Contract</seealso>
    let Contract = Prefixed_Name(epo, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>epo:bindsContractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Binds Contractor"</para></remarks>
    /// <seealso href="http://data.europa.eu/a4g/ontology#bindsContractor">http://data.europa.eu/a4g/ontology#bindsContractor</seealso>
    let bindsContractor = Prefixed_Name(epo, "bindsContractor") |> PrefixedName
