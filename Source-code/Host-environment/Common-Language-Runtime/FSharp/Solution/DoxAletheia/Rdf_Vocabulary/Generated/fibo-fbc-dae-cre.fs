namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.CreditEvents.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_dae_cre =
    let _namespace_iri = Namespace_Iri fibo_fbc_dae_cre |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-dae-cre:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Credit Events Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_dae_cre, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-cre:Bankruptcy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bankruptcy"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Bankruptcy">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Bankruptcy</seealso>
    let Bankruptcy = Prefixed_Name(fibo_fbc_dae_cre, "Bankruptcy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-cre:CreditEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CreditEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CreditEvent</seealso>
    let CreditEvent = Prefixed_Name(fibo_fbc_dae_cre, "CreditEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:CrossDefaultProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cross default provision"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CrossDefaultProvision">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CrossDefaultProvision</seealso>
    let CrossDefaultProvision =
        Prefixed_Name(fibo_fbc_dae_cre, "CrossDefaultProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:DefaultEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"default event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DefaultEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DefaultEvent</seealso>
    let DefaultEvent = Prefixed_Name(fibo_fbc_dae_cre, "DefaultEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:DistressedRatingsDowngrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"distressed ratings downgrade"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DistressedRatingsDowngrade">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DistressedRatingsDowngrade</seealso>
    let DistressedRatingsDowngrade =
        Prefixed_Name(fibo_fbc_dae_cre, "DistressedRatingsDowngrade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:Downgrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"downgrade"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Downgrade">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Downgrade</seealso>
    let Downgrade = Prefixed_Name(fibo_fbc_dae_cre, "Downgrade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:EntitySpecificCreditEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity-specific credit event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/EntitySpecificCreditEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/EntitySpecificCreditEvent</seealso>
    let EntitySpecificCreditEvent =
        Prefixed_Name(fibo_fbc_dae_cre, "EntitySpecificCreditEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:FailureToPay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"failure to pay"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPay">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPay</seealso>
    let FailureToPay = Prefixed_Name(fibo_fbc_dae_cre, "FailureToPay") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:FailureToPayInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"failure to pay interest"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayInterest">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayInterest</seealso>
    let FailureToPayInterest =
        Prefixed_Name(fibo_fbc_dae_cre, "FailureToPayInterest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:FailureToPayPrincipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"failure to pay principal"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayPrincipal">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayPrincipal</seealso>
    let FailureToPayPrincipal =
        Prefixed_Name(fibo_fbc_dae_cre, "FailureToPayPrincipal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:FilingForBankruptcy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"filing for bankruptcy"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FilingForBankruptcy">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FilingForBankruptcy</seealso>
    let FilingForBankruptcy =
        Prefixed_Name(fibo_fbc_dae_cre, "FilingForBankruptcy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:HardCreditEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hard credit event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/HardCreditEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/HardCreditEvent</seealso>
    let HardCreditEvent =
        Prefixed_Name(fibo_fbc_dae_cre, "HardCreditEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:InstallmentDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"installment default"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InstallmentDefault">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InstallmentDefault</seealso>
    let InstallmentDefault =
        Prefixed_Name(fibo_fbc_dae_cre, "InstallmentDefault") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:InterestObligationInLightOfDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest obligation in light of default"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InterestObligationInLightOfDefault">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InterestObligationInLightOfDefault</seealso>
    let InterestObligationInLightOfDefault =
        Prefixed_Name(fibo_fbc_dae_cre, "InterestObligationInLightOfDefault") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:MaturityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"maturity extension"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/MaturityExtension">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/MaturityExtension</seealso>
    let MaturityExtension =
        Prefixed_Name(fibo_fbc_dae_cre, "MaturityExtension") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:Moratorium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"moratorium"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Moratorium">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Moratorium</seealso>
    let Moratorium = Prefixed_Name(fibo_fbc_dae_cre, "Moratorium") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:ObligationAcceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obligation acceleration"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationAcceleration">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationAcceleration</seealso>
    let ObligationAcceleration =
        Prefixed_Name(fibo_fbc_dae_cre, "ObligationAcceleration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:ObligationDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obligation default"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationDefault">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationDefault</seealso>
    let ObligationDefault =
        Prefixed_Name(fibo_fbc_dae_cre, "ObligationDefault") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:ObligationRestructuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obligation restructuring"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationRestructuring">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationRestructuring</seealso>
    let ObligationRestructuring =
        Prefixed_Name(fibo_fbc_dae_cre, "ObligationRestructuring") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:ObligationSpecificCreditEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obligation-specific credit event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationSpecificCreditEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationSpecificCreditEvent</seealso>
    let ObligationSpecificCreditEvent =
        Prefixed_Name(fibo_fbc_dae_cre, "ObligationSpecificCreditEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:Repudiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"repudiation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Repudiation">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Repudiation</seealso>
    let Repudiation = Prefixed_Name(fibo_fbc_dae_cre, "Repudiation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:SoftCreditEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"soft credit event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/SoftCreditEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/SoftCreditEvent</seealso>
    let SoftCreditEvent =
        Prefixed_Name(fibo_fbc_dae_cre, "SoftCreditEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:WriteDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"write-down"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/WriteDown">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/WriteDown</seealso>
    let WriteDown = Prefixed_Name(fibo_fbc_dae_cre, "WriteDown") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:hasDefaultInterestCompoundingBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has default interest compounding basis"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultInterestCompoundingBasis">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultInterestCompoundingBasis</seealso>
    let hasDefaultInterestCompoundingBasis =
        Prefixed_Name(fibo_fbc_dae_cre, "hasDefaultInterestCompoundingBasis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:hasDefaultThresholdAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has default threshold amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultThresholdAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultThresholdAmount</seealso>
    let hasDefaultThresholdAmount =
        Prefixed_Name(fibo_fbc_dae_cre, "hasDefaultThresholdAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:hasGracePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has grace period"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasGracePeriod">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasGracePeriod</seealso>
    let hasGracePeriod =
        Prefixed_Name(fibo_fbc_dae_cre, "hasGracePeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:involvesMultipleEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"involves multiple events"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/involvesMultipleEvents">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/involvesMultipleEvents</seealso>
    let involvesMultipleEvents =
        Prefixed_Name(fibo_fbc_dae_cre, "involvesMultipleEvents") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:isDefaultInterestApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is default interest applicable"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isDefaultInterestApplicable">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isDefaultInterestApplicable</seealso>
    let isDefaultInterestApplicable =
        Prefixed_Name(fibo_fbc_dae_cre, "isDefaultInterestApplicable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-cre:isGracePeriodExtendable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is grace period extendable"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isGracePeriodExtendable">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isGracePeriodExtendable</seealso>
    let isGracePeriodExtendable =
        Prefixed_Name(fibo_fbc_dae_cre, "isGracePeriodExtendable") |> PrefixedName
