namespace https.www.omg.org.spec.Commons.Locations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module Locations =
    let _namespace_iri = Namespace_Iri Locations |> NamespaceIRI
    /// <summary>
    ///   <para>Locations:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/">https://www.omg.org/spec/Commons/Locations/</seealso>
    let _prefix_iri = Prefixed_Name(Locations, "") |> PrefixedName
    /// <summary>
    ///   <para>Locations:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/Address">https://www.omg.org/spec/Commons/Locations/Address</seealso>
    let Address = Prefixed_Name(Locations, "Address") |> PrefixedName
    /// <summary>
    ///   <para>Locations:BusinessCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/BusinessCenter">https://www.omg.org/spec/Commons/Locations/BusinessCenter</seealso>
    let BusinessCenter = Prefixed_Name(Locations, "BusinessCenter") |> PrefixedName
    /// <summary>
    ///   <para>Locations:Country</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/Country">https://www.omg.org/spec/Commons/Locations/Country</seealso>
    let Country = Prefixed_Name(Locations, "Country") |> PrefixedName

    /// <summary>
    ///   <para>Locations:CountrySubdivision</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/CountrySubdivision">https://www.omg.org/spec/Commons/Locations/CountrySubdivision</seealso>
    let CountrySubdivision =
        Prefixed_Name(Locations, "CountrySubdivision") |> PrefixedName

    /// <summary>
    ///   <para>Locations:FederalCapitalArea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/FederalCapitalArea">https://www.omg.org/spec/Commons/Locations/FederalCapitalArea</seealso>
    let FederalCapitalArea =
        Prefixed_Name(Locations, "FederalCapitalArea") |> PrefixedName

    /// <summary>
    ///   <para>Locations:FederalState</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/FederalState">https://www.omg.org/spec/Commons/Locations/FederalState</seealso>
    let FederalState = Prefixed_Name(Locations, "FederalState") |> PrefixedName

    /// <summary>
    ///   <para>Locations:GeographicCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/GeographicCoordinate">https://www.omg.org/spec/Commons/Locations/GeographicCoordinate</seealso>
    let GeographicCoordinate =
        Prefixed_Name(Locations, "GeographicCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>Locations:GeographicRegion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/GeographicRegion">https://www.omg.org/spec/Commons/Locations/GeographicRegion</seealso>
    let GeographicRegion = Prefixed_Name(Locations, "GeographicRegion") |> PrefixedName

    /// <summary>
    ///   <para>Locations:GeographicRegionIdentifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/GeographicRegionIdentifier">https://www.omg.org/spec/Commons/Locations/GeographicRegionIdentifier</seealso>
    let GeographicRegionIdentifier =
        Prefixed_Name(Locations, "GeographicRegionIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>Locations:GeopoliticalEntity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/GeopoliticalEntity">https://www.omg.org/spec/Commons/Locations/GeopoliticalEntity</seealso>
    let GeopoliticalEntity =
        Prefixed_Name(Locations, "GeopoliticalEntity") |> PrefixedName

    /// <summary>
    ///   <para>Locations:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/Location">https://www.omg.org/spec/Commons/Locations/Location</seealso>
    let Location = Prefixed_Name(Locations, "Location") |> PrefixedName
    /// <summary>
    ///   <para>Locations:Municipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/Municipality">https://www.omg.org/spec/Commons/Locations/Municipality</seealso>
    let Municipality = Prefixed_Name(Locations, "Municipality") |> PrefixedName
    /// <summary>
    ///   <para>Locations:PhysicalLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/PhysicalLocation">https://www.omg.org/spec/Commons/Locations/PhysicalLocation</seealso>
    let PhysicalLocation = Prefixed_Name(Locations, "PhysicalLocation") |> PrefixedName
    /// <summary>
    ///   <para>Locations:VirtualLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/VirtualLocation">https://www.omg.org/spec/Commons/Locations/VirtualLocation</seealso>
    let VirtualLocation = Prefixed_Name(Locations, "VirtualLocation") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasAddress">https://www.omg.org/spec/Commons/Locations/hasAddress</seealso>
    let hasAddress = Prefixed_Name(Locations, "hasAddress") |> PrefixedName

    /// <summary>
    ///   <para>Locations:hasBusinessCenter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasBusinessCenter">https://www.omg.org/spec/Commons/Locations/hasBusinessCenter</seealso>
    let hasBusinessCenter =
        Prefixed_Name(Locations, "hasBusinessCenter") |> PrefixedName

    /// <summary>
    ///   <para>Locations:hasCityName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasCityName">https://www.omg.org/spec/Commons/Locations/hasCityName</seealso>
    let hasCityName = Prefixed_Name(Locations, "hasCityName") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasCountry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasCountry">https://www.omg.org/spec/Commons/Locations/hasCountry</seealso>
    let hasCountry = Prefixed_Name(Locations, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasCoverageArea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasCoverageArea">https://www.omg.org/spec/Commons/Locations/hasCoverageArea</seealso>
    let hasCoverageArea = Prefixed_Name(Locations, "hasCoverageArea") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasLatitude">https://www.omg.org/spec/Commons/Locations/hasLatitude</seealso>
    let hasLatitude = Prefixed_Name(Locations, "hasLatitude") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasLocation">https://www.omg.org/spec/Commons/Locations/hasLocation</seealso>
    let hasLocation = Prefixed_Name(Locations, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasLongitude">https://www.omg.org/spec/Commons/Locations/hasLongitude</seealso>
    let hasLongitude = Prefixed_Name(Locations, "hasLongitude") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasMunicipality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasMunicipality">https://www.omg.org/spec/Commons/Locations/hasMunicipality</seealso>
    let hasMunicipality = Prefixed_Name(Locations, "hasMunicipality") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasRegion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasRegion">https://www.omg.org/spec/Commons/Locations/hasRegion</seealso>
    let hasRegion = Prefixed_Name(Locations, "hasRegion") |> PrefixedName
    /// <summary>
    ///   <para>Locations:hasSubdivision</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/hasSubdivision">https://www.omg.org/spec/Commons/Locations/hasSubdivision</seealso>
    let hasSubdivision = Prefixed_Name(Locations, "hasSubdivision") |> PrefixedName
    /// <summary>
    ///   <para>Locations:isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/isLocatedIn">https://www.omg.org/spec/Commons/Locations/isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(Locations, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>Locations:isSubregionOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Locations/isSubregionOf">https://www.omg.org/spec/Commons/Locations/isSubregionOf</seealso>
    let isSubregionOf = Prefixed_Name(Locations, "isSubregionOf") |> PrefixedName
