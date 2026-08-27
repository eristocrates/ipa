namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.ACTUSTaxonomy.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_actus_acv =
    let _namespace_iri = Namespace_Iri fibo_actus_acv |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-actus-acv:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"ACTUS Controlled Vocabulary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_actus_acv, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS contract type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType</seealso>
    let ACTUSContractType =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Annuity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - annuity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Annuity">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Annuity</seealso>
    let ACTUSContractType_Annuity =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Annuity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-BondWithWarrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - bond with warrant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BondWithWarrant">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BondWithWarrant</seealso>
    let ACTUSContractType_BondWithWarrant =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-BondWithWarrant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-BoundaryControlledSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - boundary controlled switch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BoundaryControlledSwitch">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-BoundaryControlledSwitch</seealso>
    let ACTUSContractType_BoundaryControlledSwitch =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-BoundaryControlledSwitch") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-CallMoney</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS contract type - call money"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CallMoney">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CallMoney</seealso>
    let ACTUSContractType_CallMoney =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-CallMoney") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-CapFloorOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - cap floor option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CapFloorOption">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CapFloorOption</seealso>
    let ACTUSContractType_CapFloorOption =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-CapFloorOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Cash</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS contract type - cash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Cash">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Cash</seealso>
    let ACTUSContractType_Cash =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Cash") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Collateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - collateral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Collateral">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Collateral</seealso>
    let ACTUSContractType_Collateral =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Collateral") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Commodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - commodity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Commodity">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Commodity</seealso>
    let ACTUSContractType_Commodity =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Commodity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-ConvertibleNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - convertible note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ConvertibleNote">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ConvertibleNote</seealso>
    let ACTUSContractType_ConvertibleNote =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-ConvertibleNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-CreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - credit default swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditDefaultSwap</seealso>
    let ACTUSContractType_CreditDefaultSwap =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-CreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-CreditLinkedNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - credit linked note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditLinkedNote">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-CreditLinkedNote</seealso>
    let ACTUSContractType_CreditLinkedNote =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-CreditLinkedNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-ExoticAnnuity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - exotic annuity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticAnnuity">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticAnnuity</seealso>
    let ACTUSContractType_ExoticAnnuity =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-ExoticAnnuity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-ExoticLinearAmortizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - exotic linear amortizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticLinearAmortizer">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticLinearAmortizer</seealso>
    let ACTUSContractType_ExoticLinearAmortizer =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-ExoticLinearAmortizer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-ExoticNegativeAmortizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - exotic negative amortizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticNegativeAmortizer">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticNegativeAmortizer</seealso>
    let ACTUSContractType_ExoticNegativeAmortizer =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-ExoticNegativeAmortizer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-ExoticOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - exotic option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticOption">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ExoticOption</seealso>
    let ACTUSContractType_ExoticOption =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-ExoticOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-ForeignExchangeOutright</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - foreign exchange outright"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ForeignExchangeOutright">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-ForeignExchangeOutright</seealso>
    let ACTUSContractType_ForeignExchangeOutright =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-ForeignExchangeOutright") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Future</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - future"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Future">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Future</seealso>
    let ACTUSContractType_Future =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Future") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Guarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - guarantee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Guarantee">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Guarantee</seealso>
    let ACTUSContractType_Guarantee =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Guarantee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-LinearAmortizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - linear amortizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-LinearAmortizer">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-LinearAmortizer</seealso>
    let ACTUSContractType_LinearAmortizer =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-LinearAmortizer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Margining</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - margining"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Margining">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Margining</seealso>
    let ACTUSContractType_Margining =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Margining") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-NegativeAmortizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - negative amortizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-NegativeAmortizer">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-NegativeAmortizer</seealso>
    let ACTUSContractType_NegativeAmortizer =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-NegativeAmortizer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Option</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Option">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Option</seealso>
    let ACTUSContractType_Option =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Option") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-PerpetualBond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - perpetual bond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PerpetualBond">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PerpetualBond</seealso>
    let ACTUSContractType_PerpetualBond =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-PerpetualBond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-PlainVanillaSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - plain vanilla swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PlainVanillaSwap">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PlainVanillaSwap</seealso>
    let ACTUSContractType_PlainVanillaSwap =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-PlainVanillaSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-PrincipalAtMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - principal at maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PrincipalAtMaturity">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-PrincipalAtMaturity</seealso>
    let ACTUSContractType_PrincipalAtMaturity =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-PrincipalAtMaturity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-RepurchaseAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - repurchase agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-RepurchaseAgreement">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-RepurchaseAgreement</seealso>
    let ACTUSContractType_RepurchaseAgreement =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-RepurchaseAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-SecuritizationCreditRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - securitization credit risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationCreditRisk">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationCreditRisk</seealso>
    let ACTUSContractType_SecuritizationCreditRisk =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-SecuritizationCreditRisk") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-SecuritizationMarketRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - securitization market risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationMarketRisk">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-SecuritizationMarketRisk</seealso>
    let ACTUSContractType_SecuritizationMarketRisk =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-SecuritizationMarketRisk") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Stock</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - stock"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Stock">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Stock</seealso>
    let ACTUSContractType_Stock =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Stock") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-Swap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///
    /// labels<para>"ACTUS contract type - swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Swap">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-Swap</seealso>
    let ACTUSContractType_Swap =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-Swap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-TotalReturnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - total return swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-TotalReturnSwap">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-TotalReturnSwap</seealso>
    let ACTUSContractType_TotalReturnSwap =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-TotalReturnSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:ACTUSContractType-UndefinedMaturityProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:ACTUSContractType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract type - undefined maturity profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-UndefinedMaturityProfile">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/ACTUSContractType-UndefinedMaturityProfile</seealso>
    let ACTUSContractType_UndefinedMaturityProfile =
        Prefixed_Name(fibo_actus_acv, "ACTUSContractType-UndefinedMaturityProfile") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"algorithmic contract category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory</seealso>
    let AlgorithmicContractCategory =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractCategory") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory-Asymmetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory</para>
    ///
    /// labels<para>"algorithmic contract category - asymmetric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Asymmetric">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Asymmetric</seealso>
    let AlgorithmicContractCategory_Asymmetric =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractCategory-Asymmetric") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory-CreditEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory</para>
    ///
    /// labels<para>"algorithmic contract category - credit enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-CreditEnhancement">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-CreditEnhancement</seealso>
    let AlgorithmicContractCategory_CreditEnhancement =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractCategory-CreditEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory-FixedIncome</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"algorithmic contract category - fixed income"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-FixedIncome">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-FixedIncome</seealso>
    let AlgorithmicContractCategory_FixedIncome =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractCategory-FixedIncome") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory-Ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"algorithmic contract category - ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Ownership">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Ownership</seealso>
    let AlgorithmicContractCategory_Ownership =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractCategory-Ownership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory-Securitization</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"algorithmic contract category - securitization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Securitization">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Securitization</seealso>
    let AlgorithmicContractCategory_Securitization =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractCategory-Securitization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory-Symmetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:AlgorithmicContractCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"algorithmic contract category - symmetric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Symmetric">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractCategory-Symmetric</seealso>
    let AlgorithmicContractCategory_Symmetric =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractCategory-Symmetric") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"algorithmic contract family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily</seealso>
    let AlgorithmicContractFamily =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractFamily") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractFamily-Basic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:AlgorithmicContractFamily</para>
    ///
    /// labels<para>"algorithmic contract family - basic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily-Basic">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily-Basic</seealso>
    let AlgorithmicContractFamily_Basic =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractFamily-Basic") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractFamily-Combined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-acv:AlgorithmicContractFamily</para>
    ///
    /// labels<para>"algorithmic contract family - combined"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily-Combined">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily-Combined</seealso>
    let AlgorithmicContractFamily_Combined =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractFamily-Combined") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractFamily-CreditEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-acv:AlgorithmicContractFamily</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"algorithmic contract family - credit enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily-CreditEnhancement">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractFamily-CreditEnhancement</seealso>
    let AlgorithmicContractFamily_CreditEnhancement =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractFamily-CreditEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:AlgorithmicContractTypesClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>Classifiers:ClassificationScheme</para>
    ///   <para>CodesAndCodeSets:CodeSet</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Algorithmic Contract Types classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractTypesClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/AlgorithmicContractTypesClassificationScheme</seealso>
    let AlgorithmicContractTypesClassificationScheme =
        Prefixed_Name(fibo_actus_acv, "AlgorithmicContractTypesClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-acv:hasCoverageDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has coverage description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/hasCoverageDescription">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/hasCoverageDescription</seealso>
    let hasCoverageDescription =
        Prefixed_Name(fibo_actus_acv, "hasCoverageDescription") |> PrefixedName
