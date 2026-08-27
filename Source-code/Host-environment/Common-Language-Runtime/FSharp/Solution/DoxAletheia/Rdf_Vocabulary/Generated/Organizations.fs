namespace https.www.omg.org.spec.Commons.Organizations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module Organizations =
    let _namespace_iri = Namespace_Iri Organizations |> NamespaceIRI
    /// <summary>
    ///   <para>Organizations:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/">https://www.omg.org/spec/Commons/Organizations/</seealso>
    let _prefix_iri = Prefixed_Name(Organizations, "") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:FormalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/FormalOrganization">https://www.omg.org/spec/Commons/Organizations/FormalOrganization</seealso>
    let FormalOrganization =
        Prefixed_Name(Organizations, "FormalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:LegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/LegalEntity">https://www.omg.org/spec/Commons/Organizations/LegalEntity</seealso>
    let LegalEntity = Prefixed_Name(Organizations, "LegalEntity") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:LegalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/LegalPerson">https://www.omg.org/spec/Commons/Organizations/LegalPerson</seealso>
    let LegalPerson = Prefixed_Name(Organizations, "LegalPerson") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:MemberBearingOrganization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/MemberBearingOrganization">https://www.omg.org/spec/Commons/Organizations/MemberBearingOrganization</seealso>
    let MemberBearingOrganization =
        Prefixed_Name(Organizations, "MemberBearingOrganization") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:Membership</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/Membership">https://www.omg.org/spec/Commons/Organizations/Membership</seealso>
    let Membership = Prefixed_Name(Organizations, "Membership") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/Organization">https://www.omg.org/spec/Commons/Organizations/Organization</seealso>
    let Organization = Prefixed_Name(Organizations, "Organization") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:OrganizationIdentificationScheme</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/OrganizationIdentificationScheme">https://www.omg.org/spec/Commons/Organizations/OrganizationIdentificationScheme</seealso>
    let OrganizationIdentificationScheme =
        Prefixed_Name(Organizations, "OrganizationIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:OrganizationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/OrganizationIdentifier">https://www.omg.org/spec/Commons/Organizations/OrganizationIdentifier</seealso>
    let OrganizationIdentifier =
        Prefixed_Name(Organizations, "OrganizationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:OrganizationMember</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/OrganizationMember">https://www.omg.org/spec/Commons/Organizations/OrganizationMember</seealso>
    let OrganizationMember =
        Prefixed_Name(Organizations, "OrganizationMember") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:OrganizationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/OrganizationName">https://www.omg.org/spec/Commons/Organizations/OrganizationName</seealso>
    let OrganizationName =
        Prefixed_Name(Organizations, "OrganizationName") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:OrganizationSubUnitIdentifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/OrganizationSubUnitIdentifier">https://www.omg.org/spec/Commons/Organizations/OrganizationSubUnitIdentifier</seealso>
    let OrganizationSubUnitIdentifier =
        Prefixed_Name(Organizations, "OrganizationSubUnitIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:OrganizationalSubUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/OrganizationalSubUnit">https://www.omg.org/spec/Commons/Organizations/OrganizationalSubUnit</seealso>
    let OrganizationalSubUnit =
        Prefixed_Name(Organizations, "OrganizationalSubUnit") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/Service">https://www.omg.org/spec/Commons/Organizations/Service</seealso>
    let Service = Prefixed_Name(Organizations, "Service") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/ServiceProvider">https://www.omg.org/spec/Commons/Organizations/ServiceProvider</seealso>
    let ServiceProvider =
        Prefixed_Name(Organizations, "ServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:designates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/designates">https://www.omg.org/spec/Commons/Organizations/designates</seealso>
    let designates = Prefixed_Name(Organizations, "designates") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:hasMembership</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/hasMembership">https://www.omg.org/spec/Commons/Organizations/hasMembership</seealso>
    let hasMembership = Prefixed_Name(Organizations, "hasMembership") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:hasOrganizationMember</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/hasOrganizationMember">https://www.omg.org/spec/Commons/Organizations/hasOrganizationMember</seealso>
    let hasOrganizationMember =
        Prefixed_Name(Organizations, "hasOrganizationMember") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:hasWebsite</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/hasWebsite">https://www.omg.org/spec/Commons/Organizations/hasWebsite</seealso>
    let hasWebsite = Prefixed_Name(Organizations, "hasWebsite") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:isDesignatedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/isDesignatedBy">https://www.omg.org/spec/Commons/Organizations/isDesignatedBy</seealso>
    let isDesignatedBy = Prefixed_Name(Organizations, "isDesignatedBy") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:isDomiciledIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/isDomiciledIn">https://www.omg.org/spec/Commons/Organizations/isDomiciledIn</seealso>
    let isDomiciledIn = Prefixed_Name(Organizations, "isDomiciledIn") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:isManagedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/isManagedBy">https://www.omg.org/spec/Commons/Organizations/isManagedBy</seealso>
    let isManagedBy = Prefixed_Name(Organizations, "isManagedBy") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:isMembershipPartyIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/isMembershipPartyIn">https://www.omg.org/spec/Commons/Organizations/isMembershipPartyIn</seealso>
    let isMembershipPartyIn =
        Prefixed_Name(Organizations, "isMembershipPartyIn") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:isOrganizationMember</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/isOrganizationMember">https://www.omg.org/spec/Commons/Organizations/isOrganizationMember</seealso>
    let isOrganizationMember =
        Prefixed_Name(Organizations, "isOrganizationMember") |> PrefixedName

    /// <summary>
    ///   <para>Organizations:isProvidedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/isProvidedBy">https://www.omg.org/spec/Commons/Organizations/isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(Organizations, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:manages</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/manages">https://www.omg.org/spec/Commons/Organizations/manages</seealso>
    let manages = Prefixed_Name(Organizations, "manages") |> PrefixedName
    /// <summary>
    ///   <para>Organizations:provides</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Organizations/provides">https://www.omg.org/spec/Commons/Organizations/provides</seealso>
    let provides = Prefixed_Name(Organizations, "provides") |> PrefixedName
