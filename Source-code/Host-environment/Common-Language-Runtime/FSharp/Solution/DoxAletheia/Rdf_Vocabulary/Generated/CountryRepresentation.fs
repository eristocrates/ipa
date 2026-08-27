namespace https.www.omg.org.spec.LCC.Countries.CountryRepresentation.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module CountryRepresentation =
    let _namespace_iri = Namespace_Iri CountryRepresentation |> NamespaceIRI
    /// <summary>
    ///   <para>CountryRepresentation:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/</seealso>
    let _prefix_iri = Prefixed_Name(CountryRepresentation, "") |> PrefixedName
    /// <summary>
    ///   <para>CountryRepresentation:Alpha2Code</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Alpha2Code">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Alpha2Code</seealso>
    let Alpha2Code = Prefixed_Name(CountryRepresentation, "Alpha2Code") |> PrefixedName
    /// <summary>
    ///   <para>CountryRepresentation:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Continent">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Continent</seealso>
    let Continent = Prefixed_Name(CountryRepresentation, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>CountryRepresentation:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Country">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Country</seealso>
    let Country = Prefixed_Name(CountryRepresentation, "Country") |> PrefixedName

    /// <summary>
    ///   <para>CountryRepresentation:CountrySubdivision</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/CountrySubdivision">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/CountrySubdivision</seealso>
    let CountrySubdivision =
        Prefixed_Name(CountryRepresentation, "CountrySubdivision") |> PrefixedName

    /// <summary>
    ///   <para>CountryRepresentation:GeographicRegion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/GeographicRegion">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/GeographicRegion</seealso>
    let GeographicRegion =
        Prefixed_Name(CountryRepresentation, "GeographicRegion") |> PrefixedName

    /// <summary>
    ///   <para>CountryRepresentation:Region</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Region">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Region</seealso>
    let Region = Prefixed_Name(CountryRepresentation, "Region") |> PrefixedName

    /// <summary>
    ///   <para>CountryRepresentation:hasEnglishShortName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasEnglishShortName">https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasEnglishShortName</seealso>
    let hasEnglishShortName =
        Prefixed_Name(CountryRepresentation, "hasEnglishShortName") |> PrefixedName
