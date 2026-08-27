namespace https.spec.edmcouncil.org.fibo.ontology.CAE.CorporateEvents.CorporateActions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_cae_ce_act =
    let _namespace_iri = Namespace_Iri fibo_cae_ce_act |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-cae-ce-act:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Corporate Actions Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_cae_ce_act, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-cae-ce-act:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Action">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Action</seealso>
    let Action = Prefixed_Name(fibo_cae_ce_act, "Action") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:ActionClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassificationScheme</seealso>
    let ActionClassificationScheme =
        Prefixed_Name(fibo_cae_ce_act, "ActionClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:ActionClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action classifier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassifier">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassifier</seealso>
    let ActionClassifier =
        Prefixed_Name(fibo_cae_ce_act, "ActionClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:ActionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action status"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionStatus">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionStatus</seealso>
    let ActionStatus = Prefixed_Name(fibo_cae_ce_act, "ActionStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:BusinessStrategyClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business strategy classifier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/BusinessStrategyClassifier">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/BusinessStrategyClassifier</seealso>
    let BusinessStrategyClassifier =
        Prefixed_Name(fibo_cae_ce_act, "BusinessStrategyClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:ChangeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"change action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ChangeAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ChangeAction</seealso>
    let ChangeAction = Prefixed_Name(fibo_cae_ce_act, "ChangeAction") |> PrefixedName
    /// <summary>
    ///   <para>fibo-cae-ce-act:ClassAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"class action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ClassAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ClassAction</seealso>
    let ClassAction = Prefixed_Name(fibo_cae_ce_act, "ClassAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:ConsentSolicitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consent solicitation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ConsentSolicitation">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ConsentSolicitation</seealso>
    let ConsentSolicitation =
        Prefixed_Name(fibo_cae_ce_act, "ConsentSolicitation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:CorporateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporate action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/CorporateAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/CorporateAction</seealso>
    let CorporateAction =
        Prefixed_Name(fibo_cae_ce_act, "CorporateAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:DisclosureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disclosure action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/DisclosureAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/DisclosureAction</seealso>
    let DisclosureAction =
        Prefixed_Name(fibo_cae_ce_act, "DisclosureAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:Divestiture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"divestiture"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Divestiture">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Divestiture</seealso>
    let Divestiture = Prefixed_Name(fibo_cae_ce_act, "Divestiture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:IncomeOrientedClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"income-oriented classifier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/IncomeOrientedClassifier">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/IncomeOrientedClassifier</seealso>
    let IncomeOrientedClassifier =
        Prefixed_Name(fibo_cae_ce_act, "IncomeOrientedClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:LegalFormChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal form change"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/LegalFormChange">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/LegalFormChange</seealso>
    let LegalFormChange =
        Prefixed_Name(fibo_cae_ce_act, "LegalFormChange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:Liquidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"liquidation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Liquidation">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Liquidation</seealso>
    let Liquidation = Prefixed_Name(fibo_cae_ce_act, "Liquidation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:MandatoryCorporateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mandatory corporate action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryCorporateAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryCorporateAction</seealso>
    let MandatoryCorporateAction =
        Prefixed_Name(fibo_cae_ce_act, "MandatoryCorporateAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:MandatoryWithChoiceCorporateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mandatory with choice corporate action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryWithChoiceCorporateAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryWithChoiceCorporateAction</seealso>
    let MandatoryWithChoiceCorporateAction =
        Prefixed_Name(fibo_cae_ce_act, "MandatoryWithChoiceCorporateAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:MarketAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MarketAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MarketAction</seealso>
    let MarketAction = Prefixed_Name(fibo_cae_ce_act, "MarketAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:MergerAcquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"merger / acquisition"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MergerAcquisition">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MergerAcquisition</seealso>
    let MergerAcquisition =
        Prefixed_Name(fibo_cae_ce_act, "MergerAcquisition") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:Notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notification"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Notification">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Notification</seealso>
    let Notification = Prefixed_Name(fibo_cae_ce_act, "Notification") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:OrganizationAddressChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organization address change"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationAddressChange">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationAddressChange</seealso>
    let OrganizationAddressChange =
        Prefixed_Name(fibo_cae_ce_act, "OrganizationAddressChange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:OrganizationNameChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organization name change"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationNameChange">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationNameChange</seealso>
    let OrganizationNameChange =
        Prefixed_Name(fibo_cae_ce_act, "OrganizationNameChange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:PriorityIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"priority issue"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/PriorityIssue">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/PriorityIssue</seealso>
    let PriorityIssue = Prefixed_Name(fibo_cae_ce_act, "PriorityIssue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:RegulatoryAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulatory action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/RegulatoryAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/RegulatoryAction</seealso>
    let RegulatoryAction =
        Prefixed_Name(fibo_cae_ce_act, "RegulatoryAction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:SpinOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spin off"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/SpinOff">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/SpinOff</seealso>
    let SpinOff = Prefixed_Name(fibo_cae_ce_act, "SpinOff") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-act:VoluntaryCorporateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"voluntary corporate action"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/VoluntaryCorporateAction">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/VoluntaryCorporateAction</seealso>
    let VoluntaryCorporateAction =
        Prefixed_Name(fibo_cae_ce_act, "VoluntaryCorporateAction") |> PrefixedName
