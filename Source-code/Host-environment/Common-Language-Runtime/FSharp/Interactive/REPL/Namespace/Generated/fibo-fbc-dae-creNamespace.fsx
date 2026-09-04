#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-dae-cre`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/" "fibo-fbc-dae-cre"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : bankruptcy</para>
    ///   <para>skos:definition : credit event involving a change in state or condition in which a party becomes insolvent</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Banking Terms, Sixth Edition, 2012^^xsd:stringcmns-av:adaptedFrom : https://thelawdictionary.org/bankruptcy/^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Bankruptcy">fibo-fbc-dae-cre:Bankruptcy</a>
    /// </summary>
    let Bankruptcy = _prefixId.prefix "Bankruptcy"
    /// <summary>
    ///   <para>rdfs:label : credit event</para>
    ///   <para>skos:definition : event signifying a sudden change in credit standing, such as bankruptcy or a violation of a bond indenture or loan agreement, that raises doubts about the party's ability to meet current or future obligations</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CreditEvent">fibo-fbc-dae-cre:CreditEvent</a>
    /// </summary>
    let CreditEvent = _prefixId.prefix "CreditEvent"
    /// <summary>
    ///   <para>rdfs:label : cross default provision</para>
    ///   <para>skos:definition : contract provision that triggers a default under one contract if the borrower defaults on another related obligation^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Cross default provisions are commonly found in loans, bond indentures, syndicated loans, and other instruments such as certain master agreements (e.g., derivatives transactions master agreements).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CrossDefaultProvision">fibo-fbc-dae-cre:CrossDefaultProvision</a>
    /// </summary>
    let CrossDefaultProvision = _prefixId.prefix "CrossDefaultProvision"
    /// <summary>
    ///   <para>rdfs:label : default event</para>
    ///   <para>skos:definition : credit event representing a failure to meet a contractual obligation, such as failure to repay a debt including interest or principal on a loan or security</para>
    ///   <para>cmns-av:explanatoryNote : A default can occur when a borrower is unable to make timely payments, misses payments, or avoids or stops making payments, typically with respect to a single transaction. A default has adverse effects on the borrower's credit and ability to borrow in the future, and allows the creditor to demand immediate repayment of the obligation in full.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DefaultEvent">fibo-fbc-dae-cre:DefaultEvent</a>
    /// </summary>
    let DefaultEvent = _prefixId.prefix "DefaultEvent"
    /// <summary>
    ///   <para>rdfs:label : distressed ratings downgrade</para>
    ///   <para>skos:definition : credit event triggered when the credit rating of an obligation is downgraded to a distressed debt level</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DistressedRatingsDowngrade">fibo-fbc-dae-cre:DistressedRatingsDowngrade</a>
    /// </summary>
    let DistressedRatingsDowngrade = _prefixId.prefix "DistressedRatingsDowngrade"
    /// <summary>
    ///   <para>rdfs:label : downgrade</para>
    ///   <para>skos:definition : credit event triggered when the credit rating of a party or obligation is lowered</para>
    ///   <para>skos:example : On October 17, 2013, Dagong Global Credit Rating downgraded the United States from A to A- and maintained a negative outlook on the country's credit.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Downgrade">fibo-fbc-dae-cre:Downgrade</a>
    /// </summary>
    let Downgrade = _prefixId.prefix "Downgrade"
    /// <summary>
    ///   <para>rdfs:label : entity-specific credit event</para>
    ///   <para>skos:definition : credit event that applies to a given legal person</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/EntitySpecificCreditEvent">fibo-fbc-dae-cre:EntitySpecificCreditEvent</a>
    /// </summary>
    let EntitySpecificCreditEvent = _prefixId.prefix "EntitySpecificCreditEvent"
    /// <summary>
    ///   <para>rdfs:label : failure to pay</para>
    ///   <para>skos:definition : default event that is triggered following any applicable grace period in which a payment obligation is missed</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPay">fibo-fbc-dae-cre:FailureToPay</a>
    /// </summary>
    let FailureToPay = _prefixId.prefix "FailureToPay"
    /// <summary>
    ///   <para>rdfs:label : failure to pay interest</para>
    ///   <para>skos:definition : default event that where either an expected interest payment is missed altogether or the amount paid is less than the required amount</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayInterest">fibo-fbc-dae-cre:FailureToPayInterest</a>
    /// </summary>
    let FailureToPayInterest = _prefixId.prefix "FailureToPayInterest"
    /// <summary>
    ///   <para>rdfs:label : failure to pay principal</para>
    ///   <para>skos:definition : default event that where either an expected principal payment is missed altogether or the amount paid is less than the required amount</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayPrincipal">fibo-fbc-dae-cre:FailureToPayPrincipal</a>
    /// </summary>
    let FailureToPayPrincipal = _prefixId.prefix "FailureToPayPrincipal"
    /// <summary>
    ///   <para>rdfs:label : filing for bankruptcy</para>
    ///   <para>skos:definition : credit event that involves a request to a court to be recognized as bankrupt</para>
    ///   <para>cmns-av:explanatoryNote : The bankruptcy process is initiated via a petition filed by the debtor or on behalf of creditors. The debtor's assets may be used to repay a portion of outstanding debt as specified by the court or a court-appointed individual.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FilingForBankruptcy">fibo-fbc-dae-cre:FilingForBankruptcy</a>
    /// </summary>
    let FilingForBankruptcy = _prefixId.prefix "FilingForBankruptcy"
    /// <summary>
    ///   <para>rdfs:label : hard credit event</para>
    ///   <para>skos:definition : default event that is not repairable</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/HardCreditEvent">fibo-fbc-dae-cre:HardCreditEvent</a>
    /// </summary>
    let HardCreditEvent = _prefixId.prefix "HardCreditEvent"
    /// <summary>
    ///   <para>rdfs:label : installment default</para>
    ///   <para>skos:definition : default event involving non-payment of several installment payments as scheduled in the terms of the agreement, or non-payment of a call by the beneficial owner</para>
    ///   <para>cmns-av:explanatoryNote : The latter may result in a court action by the issuer or the sale of the securities to recover costs and/or a forfeit of partially paid securities.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InstallmentDefault">fibo-fbc-dae-cre:InstallmentDefault</a>
    /// </summary>
    let InstallmentDefault = _prefixId.prefix "InstallmentDefault"

    /// <summary>
    ///   <para>rdfs:label : interest obligation in light of default</para>
    ///   <para>skos:definition : obligation in respect of default(s) in the performance of any payment obligation</para>
    ///   <para>skos:example : Prior to the occurrence or effective designation of an early termination date in respect of the relevant transaction, a party that defaults in the performance of any payment obligation will, to the extent permitted by law (and in the case of an ISDA Master Agreement is subject to Section 6(c)), be required to pay interest (before as well as after judgment) on the overdue amount to the other party on demand in the same currency as such overdue amount, for the period from (and including) the original due date for payment to (but excluding) the date of actual payment, at the default rate. Such interest will be calculated on the basis of daily compounding and the actual number of days elapsed.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InterestObligationInLightOfDefault">fibo-fbc-dae-cre:InterestObligationInLightOfDefault</a>
    /// </summary>
    let InterestObligationInLightOfDefault =
        _prefixId.prefix "InterestObligationInLightOfDefault"

    /// <summary>
    ///   <para>rdfs:label : maturity extension</para>
    ///   <para>skos:definition : credit event involving extension of payments beyond the original maturity date of the obligation</para>
    ///   <para>cmns-av:explanatoryNote : As stipulated in the terms and conditions for a bond, for example, the issuer or the bondholder may prolong the maturity date. After extension, the security may differ from original issue (new rate or maturity date). May be subject to bondholder's approval.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/MaturityExtension">fibo-fbc-dae-cre:MaturityExtension</a>
    /// </summary>
    let MaturityExtension = _prefixId.prefix "MaturityExtension"
    /// <summary>
    ///   <para>rdfs:label : moratorium</para>
    ///   <para>skos:definition : entity-specific credit event involving a temporary suspension of payments until related issues are resolved</para>
    ///   <para>cmns-av:explanatoryNote : A moratorium may be a legally-mandated hiatus in debt collection as a part of a bankruptcy process.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Moratorium">fibo-fbc-dae-cre:Moratorium</a>
    /// </summary>
    let Moratorium = _prefixId.prefix "Moratorium"
    /// <summary>
    ///   <para>rdfs:label : obligation acceleration</para>
    ///   <para>skos:definition : credit event triggered when one or more reference obligations become immediately due and payable as a result of a default or covenant breach on the reference entity's other debt instruments, subject to a materiality threshold</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationAcceleration">fibo-fbc-dae-cre:ObligationAcceleration</a>
    /// </summary>
    let ObligationAcceleration = _prefixId.prefix "ObligationAcceleration"
    /// <summary>
    ///   <para>rdfs:label : obligation default</para>
    ///   <para>skos:definition : credit event triggered as a result of an obligation-specific default</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationDefault">fibo-fbc-dae-cre:ObligationDefault</a>
    /// </summary>
    let ObligationDefault = _prefixId.prefix "ObligationDefault"
    /// <summary>
    ///   <para>rdfs:label : obligation restructuring</para>
    ///   <para>skos:definition : credit event that materially impacts an obligation, such as an interest rate reduction, principal reduction, deferral of interest or principal, change in priority ranking, or change in currency or composition of payment</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationRestructuring">fibo-fbc-dae-cre:ObligationRestructuring</a>
    /// </summary>
    let ObligationRestructuring = _prefixId.prefix "ObligationRestructuring"
    /// <summary>
    ///   <para>rdfs:label : obligation-specific credit event</para>
    ///   <para>skos:definition : credit event that relates to an individual credit agreement or debt instrument (reference obligation)</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationSpecificCreditEvent">fibo-fbc-dae-cre:ObligationSpecificCreditEvent</a>
    /// </summary>
    let ObligationSpecificCreditEvent = _prefixId.prefix "ObligationSpecificCreditEvent"
    /// <summary>
    ///   <para>rdfs:label : repudiation</para>
    ///   <para>skos:definition : credit event involving the refusal to honor the terms of a contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Repudiation">fibo-fbc-dae-cre:Repudiation</a>
    /// </summary>
    let Repudiation = _prefixId.prefix "Repudiation"
    /// <summary>
    ///   <para>rdfs:label : soft credit event</para>
    ///   <para>skos:definition : default event that is repairable</para>
    ///   <para>cmns-av:explanatoryNote : If the default is not repaired within a grace period, then a failure to repair (failure to pay) credit event is triggered, potentially as a hard default.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/SoftCreditEvent">fibo-fbc-dae-cre:SoftCreditEvent</a>
    /// </summary>
    let SoftCreditEvent = _prefixId.prefix "SoftCreditEvent"
    /// <summary>
    ///   <para>rdfs:label : write-down</para>
    ///   <para>skos:definition : obligation-specific credit event whereby the book value of the obligation, such as the outstanding principal amount, is reduced</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/WriteDown">fibo-fbc-dae-cre:WriteDown</a>
    /// </summary>
    let WriteDown = _prefixId.prefix "WriteDown"

    /// <summary>
    ///   <para>rdfs:label : has default interest compounding basis</para>
    ///   <para>skos:definition : indicates the basis on which default interest is to be calculated, as a period of time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultInterestCompoundingBasis">fibo-fbc-dae-cre:hasDefaultInterestCompoundingBasis</a>
    /// </summary>
    let hasDefaultInterestCompoundingBasis =
        _prefixId.prefix "hasDefaultInterestCompoundingBasis"

    /// <summary>
    ///   <para>rdfs:label : has default threshold amount</para>
    ///   <para>skos:definition : specifies an amount of money that triggers a failure to pay, repudiation/moratorium or restructuring event</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultThresholdAmount">fibo-fbc-dae-cre:hasDefaultThresholdAmount</a>
    /// </summary>
    let hasDefaultThresholdAmount = _prefixId.prefix "hasDefaultThresholdAmount"
    /// <summary>
    ///   <para>rdfs:label : has grace period</para>
    ///   <para>skos:definition : window following any payment due date during which a party must fulfill its obligations before a failure to pay credit event occurs</para>
    ///   <para>cmns-av:explanatoryNote : Note that this may be a period denominated in business days or calendar days.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasGracePeriod">fibo-fbc-dae-cre:hasGracePeriod</a>
    /// </summary>
    let hasGracePeriod = _prefixId.prefix "hasGracePeriod"
    /// <summary>
    ///   <para>rdfs:label : involves multiple events</para>
    ///   <para>skos:definition : indicates that the restructuring spans more than one credit event</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/involvesMultipleEvents">fibo-fbc-dae-cre:involvesMultipleEvents</a>
    /// </summary>
    let involvesMultipleEvents = _prefixId.prefix "involvesMultipleEvents"
    /// <summary>
    ///   <para>rdfs:label : is default interest applicable</para>
    ///   <para>skos:definition : indicates whether a party that defaults in the performance of any payment obligation is, to the extent permitted by law and the applicable agreement, required to pay interest (before as well as after judgment) on the overdue amount to the other party on demand in the same currency as such overdue amount, for the period from (and including) the original due date for payment to (but excluding) the date of actual payment</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isDefaultInterestApplicable">fibo-fbc-dae-cre:isDefaultInterestApplicable</a>
    /// </summary>
    let isDefaultInterestApplicable = _prefixId.prefix "isDefaultInterestApplicable"
    /// <summary>
    ///   <para>rdfs:label : is grace period extendable</para>
    ///   <para>skos:definition : indicates whether or not the grace period may be extended, which may be jurisdiction specific</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isGracePeriodExtendable">fibo-fbc-dae-cre:isGracePeriodExtendable</a>
    /// </summary>
    let isGracePeriodExtendable = _prefixId.prefix "isGracePeriodExtendable"
