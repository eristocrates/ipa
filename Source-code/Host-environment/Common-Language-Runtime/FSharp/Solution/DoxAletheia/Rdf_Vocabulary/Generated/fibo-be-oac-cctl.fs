namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.CorporateControl.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_oac_cctl =
    let _namespace_iri = Namespace_Iri fibo_be_oac_cctl |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-oac-cctl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Corporate Control Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_oac_cctl, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-cctl:Affiliate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"affiliate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliate">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliate</seealso>
    let Affiliate = Prefixed_Name(fibo_be_oac_cctl, "Affiliate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-cctl:Affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"affiliation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliation">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliation</seealso>
    let Affiliation = Prefixed_Name(fibo_be_oac_cctl, "Affiliation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:ControlledAffiliate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlled affiliate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControlledAffiliate">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControlledAffiliate</seealso>
    let ControlledAffiliate =
        Prefixed_Name(fibo_be_oac_cctl, "ControlledAffiliate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:ControllingAffiliate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlling affiliate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControllingAffiliate">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControllingAffiliate</seealso>
    let ControllingAffiliate =
        Prefixed_Name(fibo_be_oac_cctl, "ControllingAffiliate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:DomesticUltimateParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"domestic ultimate parent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/DomesticUltimateParent">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/DomesticUltimateParent</seealso>
    let DomesticUltimateParent =
        Prefixed_Name(fibo_be_oac_cctl, "DomesticUltimateParent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:GlobalUltimateParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"global ultimate parent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/GlobalUltimateParent">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/GlobalUltimateParent</seealso>
    let GlobalUltimateParent =
        Prefixed_Name(fibo_be_oac_cctl, "GlobalUltimateParent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:JointVenturePartner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"joint venture partner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/JointVenturePartner">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/JointVenturePartner</seealso>
    let JointVenturePartner =
        Prefixed_Name(fibo_be_oac_cctl, "JointVenturePartner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:SignificantShareholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"significant shareholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/SignificantShareholder">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/SignificantShareholder</seealso>
    let SignificantShareholder =
        Prefixed_Name(fibo_be_oac_cctl, "SignificantShareholder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:Subsidiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"subsidiary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Subsidiary">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Subsidiary</seealso>
    let Subsidiary = Prefixed_Name(fibo_be_oac_cctl, "Subsidiary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:TotalControllingInterestParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"total controlling interest party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/TotalControllingInterestParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/TotalControllingInterestParty</seealso>
    let TotalControllingInterestParty =
        Prefixed_Name(fibo_be_oac_cctl, "TotalControllingInterestParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:VotingShareholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"voting shareholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/VotingShareholder">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/VotingShareholder</seealso>
    let VotingShareholder =
        Prefixed_Name(fibo_be_oac_cctl, "VotingShareholder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:hasAffiliate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has affiliate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasAffiliate">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasAffiliate</seealso>
    let hasAffiliate = Prefixed_Name(fibo_be_oac_cctl, "hasAffiliate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:hasControllingAffiliate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has controlling affiliate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasControllingAffiliate">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasControllingAffiliate</seealso>
    let hasControllingAffiliate =
        Prefixed_Name(fibo_be_oac_cctl, "hasControllingAffiliate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:hasDomesticUltimateParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has domestic ultimate parent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasDomesticUltimateParent">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasDomesticUltimateParent</seealso>
    let hasDomesticUltimateParent =
        Prefixed_Name(fibo_be_oac_cctl, "hasDomesticUltimateParent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:hasGlobalUltimateParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has global ultimate parent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasGlobalUltimateParent">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasGlobalUltimateParent</seealso>
    let hasGlobalUltimateParent =
        Prefixed_Name(fibo_be_oac_cctl, "hasGlobalUltimateParent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:hasSubsidiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has subsidiary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasSubsidiary">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasSubsidiary</seealso>
    let hasSubsidiary = Prefixed_Name(fibo_be_oac_cctl, "hasSubsidiary") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-cctl:isAffiliateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is affiliate of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isAffiliateOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isAffiliateOf</seealso>
    let isAffiliateOf = Prefixed_Name(fibo_be_oac_cctl, "isAffiliateOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:isControllingAffiliateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is controlling affiliate of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isControllingAffiliateOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isControllingAffiliateOf</seealso>
    let isControllingAffiliateOf =
        Prefixed_Name(fibo_be_oac_cctl, "isControllingAffiliateOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:isParentCompanyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is parent company of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isParentCompanyOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isParentCompanyOf</seealso>
    let isParentCompanyOf =
        Prefixed_Name(fibo_be_oac_cctl, "isParentCompanyOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:isSubsidiaryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subsidiary of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isSubsidiaryOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isSubsidiaryOf</seealso>
    let isSubsidiaryOf =
        Prefixed_Name(fibo_be_oac_cctl, "isSubsidiaryOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cctl:isWhollyOwnedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is wholly owned by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isWhollyOwnedBy">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isWhollyOwnedBy</seealso>
    let isWhollyOwnedBy =
        Prefixed_Name(fibo_be_oac_cctl, "isWhollyOwnedBy") |> PrefixedName
