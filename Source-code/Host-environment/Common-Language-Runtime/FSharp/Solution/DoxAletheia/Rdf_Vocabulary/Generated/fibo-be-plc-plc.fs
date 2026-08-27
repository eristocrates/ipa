namespace https.spec.edmcouncil.org.fibo.ontology.BE.PrivateLimitedCompanies.PrivateLimitedCompanies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_plc_plc =
    let _namespace_iri = Namespace_Iri fibo_be_plc_plc |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-plc-plc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Private Limited Companies Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_plc_plc, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:LimitedLiabilityCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited liability company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompany">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompany</seealso>
    let LimitedLiabilityCompany =
        Prefixed_Name(fibo_be_plc_plc, "LimitedLiabilityCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:LimitedLiabilityCompanyMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited liability company member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyMember">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyMember</seealso>
    let LimitedLiabilityCompanyMember =
        Prefixed_Name(fibo_be_plc_plc, "LimitedLiabilityCompanyMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:LimitedLiabilityCompanyTaxedAsACorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited liability company taxed as a corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyTaxedAsACorporation">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyTaxedAsACorporation</seealso>
    let LimitedLiabilityCompanyTaxedAsACorporation =
        Prefixed_Name(fibo_be_plc_plc, "LimitedLiabilityCompanyTaxedAsACorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:ManagerManagedLimitedLiabilityCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"manager-managed limited liability company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagerManagedLimitedLiabilityCompany">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagerManagedLimitedLiabilityCompany</seealso>
    let ManagerManagedLimitedLiabilityCompany =
        Prefixed_Name(fibo_be_plc_plc, "ManagerManagedLimitedLiabilityCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:ManagingMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"managing member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagingMember">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagingMember</seealso>
    let ManagingMember =
        Prefixed_Name(fibo_be_plc_plc, "ManagingMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private company with limited liability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateCompanyWithLimitedLiability">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateCompanyWithLimitedLiability</seealso>
    let PrivateCompanyWithLimitedLiability =
        Prefixed_Name(fibo_be_plc_plc, "PrivateCompanyWithLimitedLiability") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:PrivateLimitedCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private limited company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateLimitedCompany">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateLimitedCompany</seealso>
    let PrivateLimitedCompany =
        Prefixed_Name(fibo_be_plc_plc, "PrivateLimitedCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:hasManagingMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has managing member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/hasManagingMember">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/hasManagingMember</seealso>
    let hasManagingMember =
        Prefixed_Name(fibo_be_plc_plc, "hasManagingMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-plc-plc:isManagingMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is managing member of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/isManagingMemberOf">https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/isManagingMemberOf</seealso>
    let isManagingMemberOf =
        Prefixed_Name(fibo_be_plc_plc, "isManagingMemberOf") |> PrefixedName
