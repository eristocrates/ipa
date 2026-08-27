namespace https.www.omg.org.spec.Commons.SitesAndFacilities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module SitesAndFacilities =
    let _namespace_iri = Namespace_Iri SitesAndFacilities |> NamespaceIRI
    /// <summary>
    ///   <para>SitesAndFacilities:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/SitesAndFacilities/">https://www.omg.org/spec/Commons/SitesAndFacilities/</seealso>
    let _prefix_iri = Prefixed_Name(SitesAndFacilities, "") |> PrefixedName
    /// <summary>
    ///   <para>SitesAndFacilities:Facility</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/SitesAndFacilities/Facility">https://www.omg.org/spec/Commons/SitesAndFacilities/Facility</seealso>
    let Facility = Prefixed_Name(SitesAndFacilities, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>SitesAndFacilities:Site</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/SitesAndFacilities/Site">https://www.omg.org/spec/Commons/SitesAndFacilities/Site</seealso>
    let Site = Prefixed_Name(SitesAndFacilities, "Site") |> PrefixedName

    /// <summary>
    ///   <para>SitesAndFacilities:TractIdentifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/SitesAndFacilities/TractIdentifier">https://www.omg.org/spec/Commons/SitesAndFacilities/TractIdentifier</seealso>
    let TractIdentifier =
        Prefixed_Name(SitesAndFacilities, "TractIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>SitesAndFacilities:TractOfLand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/SitesAndFacilities/TractOfLand">https://www.omg.org/spec/Commons/SitesAndFacilities/TractOfLand</seealso>
    let TractOfLand = Prefixed_Name(SitesAndFacilities, "TractOfLand") |> PrefixedName
