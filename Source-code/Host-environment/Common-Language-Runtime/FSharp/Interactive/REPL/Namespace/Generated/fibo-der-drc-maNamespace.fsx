#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-ma`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/" "fibo-der-drc-ma"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : account change notification obligation</para>
    ///   <para>skos:definition : obligation to notify a counterparty of any changes in account details</para>
    ///   <para>skos:example : Example text: "Either party may change its account for receiving a payment or delivery by giving notice to the other party at least five Local Business Days prior to the scheduled date for the payment or delivery to which such change applies unless such other party gives timely notice of a reasonable objection to such change." Note that the notice period is given as a fact about the general kind of obligation which is Master Agreement Change notification Obligation.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/AccountChangeNotificationObligation">fibo-der-drc-ma:AccountChangeNotificationObligation</a>
    /// </summary>
    let AccountChangeNotificationObligation =
        _prefixId.prefix "AccountChangeNotificationObligation"

    /// <summary>
    ///   <para>rdfs:label : derivative credit support agreement</para>
    ///   <para>skos:definition : addendum to the master agreement that governs the exchange of collateral between parties in derivatives transactions</para>
    ///   <para>cmns-av:explanatoryNote : Note that in the case of a derivative credit support agreement, the beneficiary actually holds the collateral and has the right to ask for additional collateral if its value falls below the threshold agreed upon per the agreement.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeCreditSupportAgreement">fibo-der-drc-ma:DerivativeCreditSupportAgreement</a>
    /// </summary>
    let DerivativeCreditSupportAgreement =
        _prefixId.prefix "DerivativeCreditSupportAgreement"

    /// <summary>
    ///   <para>rdfs:label : derivative master agreement</para>
    ///   <para>skos:definition : master agreement covering derivatives transactions to be carried out between the parties to this contract</para>
    ///   <para>skos:example : Related to conditions precedent that may apply: "Each obligation of each party under Section 2(a)(i) is subject to (1) the condition precedent that no Event of Default or Potential Event of Default with respect to the other party has occurred and is continuing, (2) the condition precedent that no Early Termination Date in respect of the relevant Transaction has occurred or been effectively designated and (3) each other applicable condition precedent specified in this Agreement. " In the above, the Obligations defined under Section 2(a)(i) of the Master Agrement is the obligation to make each payment or delivery defined in a Confirmation for a transaction carried out under this Master Agreement.skos:example : Sample preamble to one of these: "EXAMPLE BANK, a Michigan banking corporation and SAMPLECOMPANY US, INC. a Delaware corporation have entered and/or anticipate entering into one or more transactions (each a "Transaction") that are or will be governed by this Master Agreement, which includes the schedule (the "Schedule"), and the documents and other confirming evidence (each a "Confirmation") exchanged between the parties confirming those Transactions. "</para>
    ///   <para>cmns-av:explanatoryNote : The ISDA Master Agreement (Multicurrency-Cross Border version published in 1992) enables trading counterparties to include foreign exchange transactions under a global cross-product close-out netting master agreement. Because there are significant differences in market practices between the derivatives markets and the international foreign exchange spot and forward markets, parties to the ISDA frequently incorporate the ISDA FX and Currency Options Definitions and further tailor the ISDA Schedule to reflect standard market practice for the foreign exchange products.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeMasterAgreement">fibo-der-drc-ma:DerivativeMasterAgreement</a>
    /// </summary>
    let DerivativeMasterAgreement = _prefixId.prefix "DerivativeMasterAgreement"

    /// <summary>
    ///   <para>rdfs:label : master agreement early termination right</para>
    ///   <para>skos:definition : contractual right of a party to the master agreement to terminate the agreement early</para>
    ///   <para>cmns-av:explanatoryNote : This generally arises from some default event on the part of the other party.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/MasterAgreementEarlyTerminationRight">fibo-der-drc-ma:MasterAgreementEarlyTerminationRight</a>
    /// </summary>
    let MasterAgreementEarlyTerminationRight =
        _prefixId.prefix "MasterAgreementEarlyTerminationRight"
