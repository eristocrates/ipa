namespace https.www.omg.org.spec.Commons.RegulatoryAgencies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module RegulatoryAgencies =
    let _namespace_iri = Namespace_Iri RegulatoryAgencies |> NamespaceIRI
    /// <summary>
    ///   <para>RegulatoryAgencies:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/">https://www.omg.org/spec/Commons/RegulatoryAgencies/</seealso>
    let _prefix_iri = Prefixed_Name(RegulatoryAgencies, "") |> PrefixedName
    /// <summary>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/Jurisdiction">https://www.omg.org/spec/Commons/RegulatoryAgencies/Jurisdiction</seealso>
    let Jurisdiction = Prefixed_Name(RegulatoryAgencies, "Jurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/RegulatoryAgency">https://www.omg.org/spec/Commons/RegulatoryAgencies/RegulatoryAgency</seealso>
    let RegulatoryAgency =
        Prefixed_Name(RegulatoryAgencies, "RegulatoryAgency") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:RegulatoryReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/RegulatoryReport">https://www.omg.org/spec/Commons/RegulatoryAgencies/RegulatoryReport</seealso>
    let RegulatoryReport =
        Prefixed_Name(RegulatoryAgencies, "RegulatoryReport") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:governs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/governs">https://www.omg.org/spec/Commons/RegulatoryAgencies/governs</seealso>
    let governs = Prefixed_Name(RegulatoryAgencies, "governs") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:hasJurisdiction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/hasJurisdiction">https://www.omg.org/spec/Commons/RegulatoryAgencies/hasJurisdiction</seealso>
    let hasJurisdiction =
        Prefixed_Name(RegulatoryAgencies, "hasJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:hasReach</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/hasReach">https://www.omg.org/spec/Commons/RegulatoryAgencies/hasReach</seealso>
    let hasReach = Prefixed_Name(RegulatoryAgencies, "hasReach") |> PrefixedName
    /// <summary>
    ///   <para>RegulatoryAgencies:isGovernedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isGovernedBy">https://www.omg.org/spec/Commons/RegulatoryAgencies/isGovernedBy</seealso>
    let isGovernedBy = Prefixed_Name(RegulatoryAgencies, "isGovernedBy") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:isJurisdictionOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isJurisdictionOf">https://www.omg.org/spec/Commons/RegulatoryAgencies/isJurisdictionOf</seealso>
    let isJurisdictionOf =
        Prefixed_Name(RegulatoryAgencies, "isJurisdictionOf") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:isOrganizedIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isOrganizedIn">https://www.omg.org/spec/Commons/RegulatoryAgencies/isOrganizedIn</seealso>
    let isOrganizedIn =
        Prefixed_Name(RegulatoryAgencies, "isOrganizedIn") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:isRecognizedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isRecognizedIn">https://www.omg.org/spec/Commons/RegulatoryAgencies/isRecognizedIn</seealso>
    let isRecognizedIn =
        Prefixed_Name(RegulatoryAgencies, "isRecognizedIn") |> PrefixedName

    /// <summary>
    ///   <para>RegulatoryAgencies:isRegulatedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isRegulatedBy">https://www.omg.org/spec/Commons/RegulatoryAgencies/isRegulatedBy</seealso>
    let isRegulatedBy =
        Prefixed_Name(RegulatoryAgencies, "isRegulatedBy") |> PrefixedName
