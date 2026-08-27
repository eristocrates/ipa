namespace http.w3id.org.CEON.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon =
    let _namespace_iri = Namespace_Iri ceon |> NamespaceIRI

    /// <summary>
    ///   <para>ceon:ontology/location/Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/location/Location">http://w3id.org/CEON/ontology/location/Location</seealso>
    let ``ontology/location/Location`` =
        Prefixed_Name(ceon, "ontology/location/Location") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/location/hasCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/location/hasCity">http://w3id.org/CEON/ontology/location/hasCity</seealso>
    let ``ontology/location/hasCity`` =
        Prefixed_Name(ceon, "ontology/location/hasCity") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/location/hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/location/hasCountry">http://w3id.org/CEON/ontology/location/hasCountry</seealso>
    let ``ontology/location/hasCountry`` =
        Prefixed_Name(ceon, "ontology/location/hasCountry") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/location/hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/location/hasLocation">http://w3id.org/CEON/ontology/location/hasLocation</seealso>
    let ``ontology/location/hasLocation`` =
        Prefixed_Name(ceon, "ontology/location/hasLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/location/hasPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/location/hasPostalCode">http://w3id.org/CEON/ontology/location/hasPostalCode</seealso>
    let ``ontology/location/hasPostalCode`` =
        Prefixed_Name(ceon, "ontology/location/hasPostalCode") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/location/hasStreetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/location/hasStreetAddress">http://w3id.org/CEON/ontology/location/hasStreetAddress</seealso>
    let ``ontology/location/hasStreetAddress`` =
        Prefixed_Name(ceon, "ontology/location/hasStreetAddress") |> PrefixedName
