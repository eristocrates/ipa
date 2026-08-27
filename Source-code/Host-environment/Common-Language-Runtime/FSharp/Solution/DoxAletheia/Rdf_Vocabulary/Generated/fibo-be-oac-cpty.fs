namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.ControlParties.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_oac_cpty =
    let _namespace_iri = Namespace_Iri fibo_be_oac_cpty |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-oac-cpty:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Control Parties Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_oac_cpty, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:ContractualControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ContractualControl">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ContractualControl</seealso>
    let ContractualControl =
        Prefixed_Name(fibo_be_oac_cpty, "ContractualControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:ControlledParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlled party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControlledParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControlledParty</seealso>
    let ControlledParty =
        Prefixed_Name(fibo_be_oac_cpty, "ControlledParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:ControllingAlliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlling alliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControllingAlliance">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControllingAlliance</seealso>
    let ControllingAlliance =
        Prefixed_Name(fibo_be_oac_cpty, "ControllingAlliance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:CourtAppointedControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"court appointed control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/CourtAppointedControl">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/CourtAppointedControl</seealso>
    let CourtAppointedControl =
        Prefixed_Name(fibo_be_oac_cpty, "CourtAppointedControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:DeFactoControllingInterestParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"de facto controlling interest party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeFactoControllingInterestParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeFactoControllingInterestParty</seealso>
    let DeFactoControllingInterestParty =
        Prefixed_Name(fibo_be_oac_cpty, "DeFactoControllingInterestParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:DeJureControllingInterestParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"de jure controlling interest party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeJureControllingInterestParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeJureControllingInterestParty</seealso>
    let DeJureControllingInterestParty =
        Prefixed_Name(fibo_be_oac_cpty, "DeJureControllingInterestParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:EntityControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/EntityControllingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/EntityControllingParty</seealso>
    let EntityControllingParty =
        Prefixed_Name(fibo_be_oac_cpty, "EntityControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:InfluenceBasedDeFactoControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"influence-based de facto control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControl">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControl</seealso>
    let InfluenceBasedDeFactoControl =
        Prefixed_Name(fibo_be_oac_cpty, "InfluenceBasedDeFactoControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:InfluenceBasedDeFactoControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"influence-based de facto controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControllingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControllingParty</seealso>
    let InfluenceBasedDeFactoControllingParty =
        Prefixed_Name(fibo_be_oac_cpty, "InfluenceBasedDeFactoControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:InvestmentBasedDeFactoControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment-based de facto control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControl">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControl</seealso>
    let InvestmentBasedDeFactoControl =
        Prefixed_Name(fibo_be_oac_cpty, "InvestmentBasedDeFactoControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:InvestmentBasedDeFactoControllingInterestParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment-based de facto controlling interest party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControllingInterestParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControllingInterestParty</seealso>
    let InvestmentBasedDeFactoControllingInterestParty =
        Prefixed_Name(fibo_be_oac_cpty, "InvestmentBasedDeFactoControllingInterestParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:JointControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"joint controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/JointControllingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/JointControllingParty</seealso>
    let JointControllingParty =
        Prefixed_Name(fibo_be_oac_cpty, "JointControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:MajorityControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"majority controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/MajorityControllingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/MajorityControllingParty</seealso>
    let MajorityControllingParty =
        Prefixed_Name(fibo_be_oac_cpty, "MajorityControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:Receiver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"receiver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/Receiver">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/Receiver</seealso>
    let Receiver = Prefixed_Name(fibo_be_oac_cpty, "Receiver") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:SoleControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sole controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/SoleControllingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/SoleControllingParty</seealso>
    let SoleControllingParty =
        Prefixed_Name(fibo_be_oac_cpty, "SoleControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:TotalOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"total owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/TotalOwner">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/TotalOwner</seealso>
    let TotalOwner = Prefixed_Name(fibo_be_oac_cpty, "TotalOwner") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-cpty:advises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"advises"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/advises">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/advises</seealso>
    let advises = Prefixed_Name(fibo_be_oac_cpty, "advises") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:hasControllingOrganizationMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has controlling organization member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasControllingOrganizationMember">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasControllingOrganizationMember</seealso>
    let hasControllingOrganizationMember =
        Prefixed_Name(fibo_be_oac_cpty, "hasControllingOrganizationMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:hasMajorityControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has majority controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasMajorityControllingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasMajorityControllingParty</seealso>
    let hasMajorityControllingParty =
        Prefixed_Name(fibo_be_oac_cpty, "hasMajorityControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:isAdvisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has advisor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isAdvisedBy">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isAdvisedBy</seealso>
    let isAdvisedBy = Prefixed_Name(fibo_be_oac_cpty, "isAdvisedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:isBasedOnInvestmentEquity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is based on investment equity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isBasedOnInvestmentEquity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isBasedOnInvestmentEquity</seealso>
    let isBasedOnInvestmentEquity =
        Prefixed_Name(fibo_be_oac_cpty, "isBasedOnInvestmentEquity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cpty:isControllingMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is controlling member of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isControllingMemberOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isControllingMemberOf</seealso>
    let isControllingMemberOf =
        Prefixed_Name(fibo_be_oac_cpty, "isControllingMemberOf") |> PrefixedName
