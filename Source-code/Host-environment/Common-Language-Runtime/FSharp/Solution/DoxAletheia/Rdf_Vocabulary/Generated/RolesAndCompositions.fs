namespace https.www.omg.org.spec.Commons.RolesAndCompositions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module RolesAndCompositions =
    let _namespace_iri = Namespace_Iri RolesAndCompositions |> NamespaceIRI
    /// <summary>
    ///   <para>RolesAndCompositions:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/">https://www.omg.org/spec/Commons/RolesAndCompositions/</seealso>
    let _prefix_iri = Prefixed_Name(RolesAndCompositions, "") |> PrefixedName

    /// <summary>
    ///   <para>RolesAndCompositions:FunctionalRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/FunctionalRole">https://www.omg.org/spec/Commons/RolesAndCompositions/FunctionalRole</seealso>
    let FunctionalRole =
        Prefixed_Name(RolesAndCompositions, "FunctionalRole") |> PrefixedName

    /// <summary>
    ///   <para>RolesAndCompositions:Role</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/Role">https://www.omg.org/spec/Commons/RolesAndCompositions/Role</seealso>
    let Role = Prefixed_Name(RolesAndCompositions, "Role") |> PrefixedName
    /// <summary>
    ///   <para>RolesAndCompositions:hasRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/hasRole">https://www.omg.org/spec/Commons/RolesAndCompositions/hasRole</seealso>
    let hasRole = Prefixed_Name(RolesAndCompositions, "hasRole") |> PrefixedName

    /// <summary>
    ///   <para>RolesAndCompositions:isManifestedIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/isManifestedIn">https://www.omg.org/spec/Commons/RolesAndCompositions/isManifestedIn</seealso>
    let isManifestedIn =
        Prefixed_Name(RolesAndCompositions, "isManifestedIn") |> PrefixedName

    /// <summary>
    ///   <para>RolesAndCompositions:isPlayedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/isPlayedBy">https://www.omg.org/spec/Commons/RolesAndCompositions/isPlayedBy</seealso>
    let isPlayedBy = Prefixed_Name(RolesAndCompositions, "isPlayedBy") |> PrefixedName

    /// <summary>
    ///   <para>RolesAndCompositions:isRegulatedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/isRegulatedBy">https://www.omg.org/spec/Commons/RolesAndCompositions/isRegulatedBy</seealso>
    let isRegulatedBy =
        Prefixed_Name(RolesAndCompositions, "isRegulatedBy") |> PrefixedName

    /// <summary>
    ///   <para>RolesAndCompositions:manifests</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/manifests">https://www.omg.org/spec/Commons/RolesAndCompositions/manifests</seealso>
    let manifests = Prefixed_Name(RolesAndCompositions, "manifests") |> PrefixedName
    /// <summary>
    ///   <para>RolesAndCompositions:playsRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/RolesAndCompositions/playsRole">https://www.omg.org/spec/Commons/RolesAndCompositions/playsRole</seealso>
    let playsRole = Prefixed_Name(RolesAndCompositions, "playsRole") |> PrefixedName
