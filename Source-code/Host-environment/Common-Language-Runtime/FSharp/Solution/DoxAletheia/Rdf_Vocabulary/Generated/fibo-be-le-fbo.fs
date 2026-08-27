namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.FormalBusinessOrganizations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_le_fbo =
    let _namespace_iri = Namespace_Iri fibo_be_le_fbo |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-le-fbo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Formal Business Organizations Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_le_fbo, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-le-fbo:Branch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"branch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Branch">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Branch</seealso>
    let Branch = Prefixed_Name(fibo_be_le_fbo, "Branch") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-le-fbo:Division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"division"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Division">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Division</seealso>
    let Division = Prefixed_Name(fibo_be_le_fbo, "Division") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-le-fbo:JointVenture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"joint venture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/JointVenture">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/JointVenture</seealso>
    let JointVenture = Prefixed_Name(fibo_be_le_fbo, "JointVenture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:NonGovernmentalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-governmental organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NonGovernmentalOrganization">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NonGovernmentalOrganization</seealso>
    let NonGovernmentalOrganization =
        Prefixed_Name(fibo_be_le_fbo, "NonGovernmentalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:NotForProfitOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"not for profit organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NotForProfitOrganization">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NotForProfitOrganization</seealso>
    let NotForProfitOrganization =
        Prefixed_Name(fibo_be_le_fbo, "NotForProfitOrganization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:OrganizationCoveringAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organization covering agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/OrganizationCoveringAgreement">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/OrganizationCoveringAgreement</seealso>
    let OrganizationCoveringAgreement =
        Prefixed_Name(fibo_be_le_fbo, "OrganizationCoveringAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:ValueAddedTaxIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"value-added tax identification number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/ValueAddedTaxIdentificationNumber">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/ValueAddedTaxIdentificationNumber</seealso>
    let ValueAddedTaxIdentificationNumber =
        Prefixed_Name(fibo_be_le_fbo, "ValueAddedTaxIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:hasEquity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has equity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasEquity">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasEquity</seealso>
    let hasEquity = Prefixed_Name(fibo_be_le_fbo, "hasEquity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:hasHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasHeadquartersAddress</seealso>
    let hasHeadquartersAddress =
        Prefixed_Name(fibo_be_le_fbo, "hasHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:hasOperatingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has operating address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasOperatingAddress">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasOperatingAddress</seealso>
    let hasOperatingAddress =
        Prefixed_Name(fibo_be_le_fbo, "hasOperatingAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-fbo:hasRegisteredAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has registered address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasRegisteredAddress">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasRegisteredAddress</seealso>
    let hasRegisteredAddress =
        Prefixed_Name(fibo_be_le_fbo, "hasRegisteredAddress") |> PrefixedName
