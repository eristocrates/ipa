namespace http.www.daml.org._2001._09.countries.iso_3166_ont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module coun =
    let _namespace_iri = Namespace_Iri coun |> NamespaceIRI
    /// <summary>
    ///   <para>coun:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/2001/09/countries/iso-3166-ont#Country">http://www.daml.org/2001/09/countries/iso-3166-ont#Country</seealso>
    let Country = Prefixed_Name(coun, "Country") |> PrefixedName
    /// <summary>
    ///   <para>coun:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>daml:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/2001/09/countries/iso-3166-ont#name">http://www.daml.org/2001/09/countries/iso-3166-ont#name</seealso>
    let name = Prefixed_Name(coun, "name") |> PrefixedName
    /// <summary>
    ///   <para>coun:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>daml:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/2001/09/countries/iso-3166-ont#code">http://www.daml.org/2001/09/countries/iso-3166-ont#code</seealso>
    let code = Prefixed_Name(coun, "code") |> PrefixedName
