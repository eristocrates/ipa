namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.Contracts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_agr_ctr =
    let _namespace_iri = Namespace_Iri fibo_fnd_agr_ctr |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Contracts Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_agr_ctr, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:AssignableContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assignable contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/AssignableContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/AssignableContract</seealso>
    let AssignableContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "AssignableContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:BilateralContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bilateral contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralContract</seealso>
    let BilateralContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "BilateralContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:BilateralNettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bilateral netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralNettingProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralNettingProvision</seealso>
    let BilateralNettingProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "BilateralNettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:BreachOfContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"breach of contract"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfContract</seealso>
    let BreachOfContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "BreachOfContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:BreachOfCovenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"breach of covenant"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfCovenant">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfCovenant</seealso>
    let BreachOfCovenant =
        Prefixed_Name(fibo_fnd_agr_ctr, "BreachOfCovenant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:CloseOutNettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"close-out netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CloseOutNettingProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CloseOutNettingProvision</seealso>
    let CloseOutNettingProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "CloseOutNettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:CollateralAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collateral agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CollateralAgreement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CollateralAgreement</seealso>
    let CollateralAgreement =
        Prefixed_Name(fibo_fnd_agr_ctr, "CollateralAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ConditionPrecedent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"condition precedent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ConditionPrecedent">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ConditionPrecedent</seealso>
    let ConditionPrecedent =
        Prefixed_Name(fibo_fnd_agr_ctr, "ConditionPrecedent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Contract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Contract</seealso>
    let Contract = Prefixed_Name(fibo_fnd_agr_ctr, "Contract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractDocument">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractDocument</seealso>
    let ContractDocument =
        Prefixed_Name(fibo_fnd_agr_ctr, "ContractDocument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractMilestone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract milestone"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractMilestone">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractMilestone</seealso>
    let ContractMilestone =
        Prefixed_Name(fibo_fnd_agr_ctr, "ContractMilestone") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractParty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractParty</seealso>
    let ContractParty = Prefixed_Name(fibo_fnd_agr_ctr, "ContractParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractPrincipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract principal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractPrincipal">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractPrincipal</seealso>
    let ContractPrincipal =
        Prefixed_Name(fibo_fnd_agr_ctr, "ContractPrincipal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract third party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractThirdParty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractThirdParty</seealso>
    let ContractThirdParty =
        Prefixed_Name(fibo_fnd_agr_ctr, "ContractThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractualCommitment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual commitment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualCommitment">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualCommitment</seealso>
    let ContractualCommitment =
        Prefixed_Name(fibo_fnd_agr_ctr, "ContractualCommitment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractualDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualDefinition">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualDefinition</seealso>
    let ContractualDefinition =
        Prefixed_Name(fibo_fnd_agr_ctr, "ContractualDefinition") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ContractualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualElement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualElement</seealso>
    let ContractualElement =
        Prefixed_Name(fibo_fnd_agr_ctr, "ContractualElement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:Counterparty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"counterparty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Counterparty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Counterparty</seealso>
    let Counterparty = Prefixed_Name(fibo_fnd_agr_ctr, "Counterparty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:DisclosureProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disclosure provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/DisclosureProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/DisclosureProvision</seealso>
    let DisclosureProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "DisclosureProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:EarlyTerminationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"early termination provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/EarlyTerminationProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/EarlyTerminationProvision</seealso>
    let EarlyTerminationProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "EarlyTerminationProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:ExtensionProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"extension provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ExtensionProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ExtensionProvision</seealso>
    let ExtensionProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "ExtensionProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:MasterAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"master agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MasterAgreement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MasterAgreement</seealso>
    let MasterAgreement =
        Prefixed_Name(fibo_fnd_agr_ctr, "MasterAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:MilestoneEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"milestone event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneEvent">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneEvent</seealso>
    let MilestoneEvent =
        Prefixed_Name(fibo_fnd_agr_ctr, "MilestoneEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:MilestoneSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"milestone schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneSchedule">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneSchedule</seealso>
    let MilestoneSchedule =
        Prefixed_Name(fibo_fnd_agr_ctr, "MilestoneSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:MultilateralContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multilateral contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralContract</seealso>
    let MultilateralContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "MultilateralContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:MultilateralNettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multilateral netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralNettingProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralNettingProvision</seealso>
    let MultilateralNettingProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "MultilateralNettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:MutualContractualAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MutualContractualAgreement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MutualContractualAgreement</seealso>
    let MutualContractualAgreement =
        Prefixed_Name(fibo_fnd_agr_ctr, "MutualContractualAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:NettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NettingProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NettingProvision</seealso>
    let NettingProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "NettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:NonBindingTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-binding term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonBindingTerm">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonBindingTerm</seealso>
    let NonBindingTerm =
        Prefixed_Name(fibo_fnd_agr_ctr, "NonBindingTerm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:NonTransferableContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-transferable contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonTransferableContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonTransferableContract</seealso>
    let NonTransferableContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "NonTransferableContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:NotificationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notification provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NotificationProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NotificationProvision</seealso>
    let NotificationProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "NotificationProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:NovateableContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"novateable contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovateableContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovateableContract</seealso>
    let NovateableContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "NovateableContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:NovationNettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"novation netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovationNettingProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovationNettingProvision</seealso>
    let NovationNettingProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "NovationNettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:PaymentNettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/PaymentNettingProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/PaymentNettingProvision</seealso>
    let PaymentNettingProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "PaymentNettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"representation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Representation">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Representation</seealso>
    let Representation =
        Prefixed_Name(fibo_fnd_agr_ctr, "Representation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:SettlementNettingProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"settlement netting provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/SettlementNettingProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/SettlementNettingProvision</seealso>
    let SettlementNettingProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "SettlementNettingProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:TermSheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"term sheet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TermSheet">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TermSheet</seealso>
    let TermSheet = Prefixed_Name(fibo_fnd_agr_ctr, "TermSheet") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:TerminationProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"termination provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TerminationProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TerminationProvision</seealso>
    let TerminationProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "TerminationProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:TransferableContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transferable contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TransferableContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TransferableContract</seealso>
    let TransferableContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "TransferableContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:UnilateralContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unilateral contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UnilateralContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UnilateralContract</seealso>
    let UnilateralContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "UnilateralContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:UseOfProceedsProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"use of proceeds provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UseOfProceedsProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UseOfProceedsProvision</seealso>
    let UseOfProceedsProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "UseOfProceedsProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:VerbalContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"verbal contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/VerbalContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/VerbalContract</seealso>
    let VerbalContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "VerbalContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:Warranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"warranty"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Warranty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Warranty</seealso>
    let Warranty = Prefixed_Name(fibo_fnd_agr_ctr, "Warranty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:WrittenContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"written contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/WrittenContract">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/WrittenContract</seealso>
    let WrittenContract =
        Prefixed_Name(fibo_fnd_agr_ctr, "WrittenContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:definesTermsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"defines terms for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/definesTermsFor">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/definesTermsFor</seealso>
    let definesTermsFor =
        Prefixed_Name(fibo_fnd_agr_ctr, "definesTermsFor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasBeneficiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has beneficiary"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasBeneficiary">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasBeneficiary</seealso>
    let hasBeneficiary =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasBeneficiary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasContractDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has contract duration"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractDuration">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractDuration</seealso>
    let hasContractDuration =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasContractDuration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasContractParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has contract party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractParty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractParty</seealso>
    let hasContractParty =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasContractParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasContractualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has contractual element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractualElement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractualElement</seealso>
    let hasContractualElement =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasContractualElement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasCounterparty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has counterparty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasCounterparty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasCounterparty</seealso>
    let hasCounterparty =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasCounterparty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasEarlyTerminationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has early termination date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEarlyTerminationDate">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEarlyTerminationDate</seealso>
    let hasEarlyTerminationDate =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasEarlyTerminationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasEffectiveDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has effective date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDate">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDate</seealso>
    let hasEffectiveDate =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasEffectiveDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasEffectiveDateTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has effective date time stamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDateTimeStamp">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDateTimeStamp</seealso>
    let hasEffectiveDateTimeStamp =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasEffectiveDateTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasExecutionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has execution date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDate">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDate</seealso>
    let hasExecutionDate =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasExecutionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasExecutionDateTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has execution date time stamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDateTimeStamp">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDateTimeStamp</seealso>
    let hasExecutionDateTimeStamp =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasExecutionDateTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasExtendablePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has extendable period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtendablePeriod">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtendablePeriod</seealso>
    let hasExtendablePeriod =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasExtendablePeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasExtensionProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has extension provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtensionProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtensionProvision</seealso>
    let hasExtensionProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasExtensionProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasGoverningJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has governing jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasGoverningJurisdiction">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasGoverningJurisdiction</seealso>
    let hasGoverningJurisdiction =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasGoverningJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasLegalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has legal description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasLegalDescription">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasLegalDescription</seealso>
    let hasLegalDescription =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasLegalDescription") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasMilestoneProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has milestone provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasMilestoneProvision">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasMilestoneProvision</seealso>
    let hasMilestoneProvision =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasMilestoneProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasNonBindingTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has non-binding term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasNonBindingTerm">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasNonBindingTerm</seealso>
    let hasNonBindingTerm =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasNonBindingTerm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasPrincipalParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasPrincipalParty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasPrincipalParty</seealso>
    let hasPrincipalParty =
        Prefixed_Name(fibo_fnd_agr_ctr, "hasPrincipalParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has term"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasTerm">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasTerm</seealso>
    let hasTerm = Prefixed_Name(fibo_fnd_agr_ctr, "hasTerm") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:hasThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has third party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasThirdParty">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasThirdParty</seealso>
    let hasThirdParty = Prefixed_Name(fibo_fnd_agr_ctr, "hasThirdParty") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isAssignable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is assignable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isAssignable">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isAssignable</seealso>
    let isAssignable = Prefixed_Name(fibo_fnd_agr_ctr, "isAssignable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isBeneficiaryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is beneficiary of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isBeneficiaryOf">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isBeneficiaryOf</seealso>
    let isBeneficiaryOf =
        Prefixed_Name(fibo_fnd_agr_ctr, "isBeneficiaryOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isEvidenceFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is evidence for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidenceFor">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidenceFor</seealso>
    let isEvidenceFor = Prefixed_Name(fibo_fnd_agr_ctr, "isEvidenceFor") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isEvidencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is evidenced by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidencedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidencedBy</seealso>
    let isEvidencedBy = Prefixed_Name(fibo_fnd_agr_ctr, "isEvidencedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isNettingAutomatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is netting automatic"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isNettingAutomatic">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isNettingAutomatic</seealso>
    let isNettingAutomatic =
        Prefixed_Name(fibo_fnd_agr_ctr, "isNettingAutomatic") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isPrimaryContractFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is primary contract for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isPrimaryContractFor">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isPrimaryContractFor</seealso>
    let isPrimaryContractFor =
        Prefixed_Name(fibo_fnd_agr_ctr, "isPrimaryContractFor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isQualifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is qualified by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isQualifiedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isQualifiedBy</seealso>
    let isQualifiedBy = Prefixed_Name(fibo_fnd_agr_ctr, "isQualifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:isSubordinateTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is subordinate to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isSubordinateTo">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isSubordinateTo</seealso>
    let isSubordinateTo =
        Prefixed_Name(fibo_fnd_agr_ctr, "isSubordinateTo") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:qualifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"qualifies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/qualifies">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/qualifies</seealso>
    let qualifies = Prefixed_Name(fibo_fnd_agr_ctr, "qualifies") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-agr-ctr:supersedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"supersedes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/supersedes">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/supersedes</seealso>
    let supersedes = Prefixed_Name(fibo_fnd_agr_ctr, "supersedes") |> PrefixedName
