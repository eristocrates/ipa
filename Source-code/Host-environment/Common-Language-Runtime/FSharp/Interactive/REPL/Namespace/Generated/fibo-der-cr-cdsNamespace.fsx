#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-cr-cds`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/" "fibo-der-cr-cds"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : asset-backed credit default swap</para>
    ///   <para>skos:definition : credit default swap whose underlying reference obligation is an asset-backed security rather than corporate credit</para>
    ///   <para>cmns-av:abbreviation : ABCDS</para>
    ///   <para>cmns-av:explanatoryNote : In the case of an ABCDS, the buyer receives protection for defaults on asset-backed securities or tranches of securities, rather than protecting against the default of a particular issuer. Asset-backed securities are securities backed by a pool of loans or receivables, such as auto loans, home equity loans or credit cards loans.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/AssetBackedCreditDefaultSwap">fibo-der-cr-cds:AssetBackedCreditDefaultSwap</a>
    /// </summary>
    let AssetBackedCreditDefaultSwap = _prefixId.prefix "AssetBackedCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : basket credit default swap</para>
    ///   <para>skos:definition : credit default swap that references a bespoke, synthetic portfolio of underlying assets whose components have been agreed to for a specific OTC derivative by the parties to the transaction</para>
    ///   <para>cmns-av:adaptedFrom : Draft paper on Credit Default Swaps from the Federal Reserve Board, available at https://www.federalreserve.gov/econres/feds/files/2022023pap.pdf^^xsd:stringcmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketCreditDefaultSwap">fibo-der-cr-cds:BasketCreditDefaultSwap</a>
    /// </summary>
    let BasketCreditDefaultSwap = _prefixId.prefix "BasketCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : basket of credit default swaps</para>
    ///   <para>skos:definition : basket of reference obligations are credit default swap instruments</para>
    ///   <para>cmns-av:explanatoryNote : Note that the CDS Index is broken down into tranches depending on different types of credits, for example, investment grade and high yield. Tranches are defined by attachment and detachment points for the index loss distribution. It means that when default events occur the lower-level tranches absorb the loss up to the detachment point, before moving to the next senior tranche.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketOfCreditDefaultSwaps">fibo-der-cr-cds:BasketOfCreditDefaultSwaps</a>
    /// </summary>
    let BasketOfCreditDefaultSwaps = _prefixId.prefix "BasketOfCreditDefaultSwaps"
    /// <summary>
    ///   <para>rdfs:label : cash settlement method</para>
    ///   <para>skos:definition : strategy for calculating or otherwise establishing a reference final price for the contract</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The method may include an independently administered synthetic auction process that sets the reference final price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CashSettlementMethod">fibo-der-cr-cds:CashSettlementMethod</a>
    /// </summary>
    let CashSettlementMethod = _prefixId.prefix "CashSettlementMethod"
    /// <summary>
    ///   <para>rdfs:label : contingent credit default swap</para>
    ///   <para>skos:definition : credit default swap in which an additional triggering event is required</para>
    ///   <para>cmns-av:abbreviation : CCDS</para>
    ///   <para>cmns-av:explanatoryNote : In a contingent credit default swap, the trigger requires both a credit event (as in a traditional credit default swap) and another specified event. The additional specified event is usually a significant movement in an index covering equities, commodities, interest rates, or some other overall measure of the economy or relevant industry.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/ContingentCreditDefaultSwap">fibo-der-cr-cds:ContingentCreditDefaultSwap</a>
    /// </summary>
    let ContingentCreditDefaultSwap = _prefixId.prefix "ContingentCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : credit default swap</para>
    ///   <para>skos:definition : bilateral contract in which one party (protection seller) agrees to provide payment to the other party (protection buyer) should a credit event occur against the underlying, which could be a specified debt (the reference obligation), a specific debt issuer (reference entity), a basket of reference entities and/or reference obligations, or a credit index (reference index)</para>
    ///   <para>cmns-av:abbreviation : CDS</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : According to a 2022 working paper from the Federal Reserve, "credit default swaps (CDS) are, by far, the most common type of credit derivative. They are financial instruments that allow the transfer of credit risk among market participants, potentially facilitating greater efficiency in the pricing and distribution of credit risk. In its most basic form, a CDS is a contract where a 'protection buyer' agrees to make periodic payments (the CDS 'spread' or premium) over a predetermined number of years (the maturity or term of the CDS) to a 'protection seller' in exchange for a payment from the protection seller in the event of default by a 'reference entity.' CDS premiums tend to be paid quarterly and are set as a percentage of the total amount of protection bought (the 'notional amount' of the contract). CDS maturities generally range from one to ten years, with the five-year maturity being particularly common." See https://www.federalreserve.gov/econres/feds/files/2022023pap.pdf for more detail.cmns-av:explanatoryNote : Note that the effective date of the contract indicates the starting date of the credit protection defined therein.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwap">fibo-der-cr-cds:CreditDefaultSwap</a>
    /// </summary>
    let CreditDefaultSwap = _prefixId.prefix "CreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : credit default swap index</para>
    ///   <para>skos:definition : index whose underlying reference obligations are credit default swap instruments</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwapIndex">fibo-der-cr-cds:CreditDefaultSwapIndex</a>
    /// </summary>
    let CreditDefaultSwapIndex = _prefixId.prefix "CreditDefaultSwapIndex"
    /// <summary>
    ///   <para>rdfs:label : credit event notice</para>
    ///   <para>skos:definition : irrevocable written or verbal notice that states that a triggering event has occurred</para>
    ///   <para>cmns-av:explanatoryNote : Notices of certain kinds of credit events are required as a condition of a credit default swap. Such notices are sent from a notifying party (either the buyer or the seller) to the counterparty. They provide information that assists the contract parties in determining whether a triggering credit event has occurred.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditEventNotice">fibo-der-cr-cds:CreditEventNotice</a>
    /// </summary>
    let CreditEventNotice = _prefixId.prefix "CreditEventNotice"
    /// <summary>
    ///   <para>rdfs:label : credit protection terms</para>
    ///   <para>skos:definition : legal terms that define triggering events and associated conditions related to settlement</para>
    ///   <para>cmns-av:explanatoryNote : Note that there may be additional payment schedules or a more complex calculation formula required depending on the terms of the contract.</para>
    ///   <para>cmns-av:synonym : contingent leg</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditProtectionTerms">fibo-der-cr-cds:CreditProtectionTerms</a>
    /// </summary>
    let CreditProtectionTerms = _prefixId.prefix "CreditProtectionTerms"
    /// <summary>
    ///   <para>rdfs:label : deliverable asset</para>
    ///   <para>skos:definition : asset that must be delivered as a part of the process of settling a credit default swap</para>
    ///   <para>cmns-av:explanatoryNote : If the reference obligation is a bond, the deliverable asset (obligation) may be a different bond. If it is a loan, the deliverable asset may involve assigment of a loan.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligation">fibo-der-cr-cds:DeliverableObligation</a>
    /// </summary>
    let DeliverableObligation = _prefixId.prefix "DeliverableObligation"
    /// <summary>
    ///   <para>rdfs:label : deliverable obligation buyer</para>
    ///   <para>skos:definition : contract party that is obliged to purchase a deliverable obligation (asset) if a triggering event occurs, depending on the event and the contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationBuyer">fibo-der-cr-cds:DeliverableObligationBuyer</a>
    /// </summary>
    let DeliverableObligationBuyer = _prefixId.prefix "DeliverableObligationBuyer"
    /// <summary>
    ///   <para>rdfs:label : deliverable obligation seller</para>
    ///   <para>skos:definition : contract party that is obliged to sell a deliverable obligation (asset) if a triggering event occurs, depending on the event and the contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationSeller">fibo-der-cr-cds:DeliverableObligationSeller</a>
    /// </summary>
    let DeliverableObligationSeller = _prefixId.prefix "DeliverableObligationSeller"
    /// <summary>
    ///   <para>rdfs:label : escrow agent</para>
    ///   <para>skos:definition : third party that holds an asset or funds before they are formally transferred from one party to another party, per the terms of a contract, within some specified time period and/or when a triggering event occurs</para>
    ///   <para>cmns-av:explanatoryNote : Use of an escrow agent is one possible mechanism that may be used in some cases, as specified in a credit default swap contract, for delivery purposes.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/EscrowAgent">fibo-der-cr-cds:EscrowAgent</a>
    /// </summary>
    let EscrowAgent = _prefixId.prefix "EscrowAgent"
    /// <summary>
    ///   <para>rdfs:label : index credit default swap</para>
    ///   <para>skos:definition : credit default swap that references a family of standardized credit derivative indices, where the underlying reference entities are a defined basket of credit from a particular geographic region (e.g. Asia, North America, Europe), and/or credit rating level (e.g. emerging markets, high yield, investment grade)</para>
    ///   <para>cmns-av:adaptedFrom : Draft paper on Credit Default Swaps from the Federal Reserve Board, available at https://www.federalreserve.gov/econres/feds/files/2022023pap.pdf^^xsd:stringcmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Credit default indices trade in standard maturities, and the reference entities are typically the most liquid; the reference portfolio is reassessed periodically to maintain this.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexCreditDefaultSwap">fibo-der-cr-cds:IndexCreditDefaultSwap</a>
    /// </summary>
    let IndexCreditDefaultSwap = _prefixId.prefix "IndexCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : index tranche credit default swap</para>
    ///   <para>skos:definition : credit default swap that references a synthetic collateralized debt obligation (CDO) based on a credit index where each tranche references a different segment of the loss distribution of the underlying index</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Each tranche has a different priority of claims on the principal and interest flows from the collateral pool, and is traditionally portioned into rising levels of seniority.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexTrancheCreditDefaultSwap">fibo-der-cr-cds:IndexTrancheCreditDefaultSwap</a>
    /// </summary>
    let IndexTrancheCreditDefaultSwap = _prefixId.prefix "IndexTrancheCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : loan credit default swap</para>
    ///   <para>skos:definition : credit default swap whose underlying reference obligation is limited strictly to syndicated secured loans, rather than any type of corporate debt</para>
    ///   <para>cmns-av:abbreviation : LCDS</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/LoanCreditDefaultSwap">fibo-der-cr-cds:LoanCreditDefaultSwap</a>
    /// </summary>
    let LoanCreditDefaultSwap = _prefixId.prefix "LoanCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : multi-name credit default swap</para>
    ///   <para>skos:definition : credit default swap that references more than one obligation or borrower</para>
    ///   <para>cmns-av:adaptedFrom : Draft paper on Credit Default Swaps from the Federal Reserve Board, available at https://www.federalreserve.gov/econres/feds/files/2022023pap.pdf^^xsd:stringcmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For instance, a multiname contract could be written to cover defaults in a reference portfolio (such as in the case of a basket credit default swap) or, as has been increasingly common over the past couple of decades,be based on an index of commonly negotiated single-name CDS. The latter are generally called CDS indexes.</para>
    ///   <para>cmns-av:synonym : multiname credit default swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/MultiNameCreditDefaultSwap">fibo-der-cr-cds:MultiNameCreditDefaultSwap</a>
    /// </summary>
    let MultiNameCreditDefaultSwap = _prefixId.prefix "MultiNameCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : notifying party</para>
    ///   <para>skos:definition : party responsible for issuing one or more formal notices indicating that an event that is relevant to a given contract has taken place</para>
    ///   <para>cmns-av:explanatoryNote : The notifying party is the party that notifies the other party when a credit or other triggering event has occurred by means of a credit event notice. If more than one party is referenced as being the notifying party then either party may notify the other of such an occurrence.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/NotifyingParty">fibo-der-cr-cds:NotifyingParty</a>
    /// </summary>
    let NotifyingParty = _prefixId.prefix "NotifyingParty"
    /// <summary>
    ///   <para>rdfs:label : settlement auction</para>
    ///   <para>skos:definition : independently administered synthetic auction process on a set of defined deliverable obligations that sets the reference final price that can be used to facilitate cash settlement of all covered transactions following a credit event</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SettlementAuction">fibo-der-cr-cds:SettlementAuction</a>
    /// </summary>
    let SettlementAuction = _prefixId.prefix "SettlementAuction"
    /// <summary>
    ///   <para>rdfs:label : single name credit default swap</para>
    ///   <para>skos:definition : credit default swap whose underlying risk is a single reference obligation, or a single reference entity, such as a corporation or a sovereign borrower</para>
    ///   <para>cmns-av:adaptedFrom : Draft paper on Credit Default Swaps from the Federal Reserve Board, available at https://www.federalreserve.gov/econres/feds/files/2022023pap.pdf^^xsd:stringcmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SingleNameCreditDefaultSwap">fibo-der-cr-cds:SingleNameCreditDefaultSwap</a>
    /// </summary>
    let SingleNameCreditDefaultSwap = _prefixId.prefix "SingleNameCreditDefaultSwap"
    /// <summary>
    ///   <para>rdfs:label : triggering event</para>
    ///   <para>skos:definition : event that relates to or triggers some aspect of a credit default swap</para>
    ///   <para>cmns-av:explanatoryNote : A triggering event is typically a credit event, but could be anything that happens in the marketplace. For example, a weather-specific contract could be triggered by a hurricane - which wouldn't be considered a credit event per se.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/TriggeringEvent">fibo-der-cr-cds:TriggeringEvent</a>
    /// </summary>
    let TriggeringEvent = _prefixId.prefix "TriggeringEvent"
    /// <summary>
    ///   <para>rdfs:label : allows substitution</para>
    ///   <para>skos:definition : indicates whether it is possible to substitute other obligations in place of the specified deliverable obligation</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/allowsSubstitution">fibo-der-cr-cds:allowsSubstitution</a>
    /// </summary>
    let allowsSubstitution = _prefixId.prefix "allowsSubstitution"
    /// <summary>
    ///   <para>rdfs:label : has contract price</para>
    ///   <para>skos:definition : specifies a predetermined price at which the buyer purchases the credit default swap contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasContractPrice">fibo-der-cr-cds:hasContractPrice</a>
    /// </summary>
    let hasContractPrice = _prefixId.prefix "hasContractPrice"
    /// <summary>
    ///   <para>rdfs:label : has minimum quotation amount</para>
    ///   <para>skos:definition : indicates a minimum intended threshold amount of outstanding principal balance of the reference obligation for which the quote should be obtained</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasMinimumQuotationAmount">fibo-der-cr-cds:hasMinimumQuotationAmount</a>
    /// </summary>
    let hasMinimumQuotationAmount = _prefixId.prefix "hasMinimumQuotationAmount"
    /// <summary>
    ///   <para>rdfs:label : has quotation method</para>
    ///   <para>skos:definition : indicates the nature of the pricing quotations to be requested from banks and/or dealers when determining the market value of the reference obligation for purposes of cash settlement</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasQuotationMethod">fibo-der-cr-cds:hasQuotationMethod</a>
    /// </summary>
    let hasQuotationMethod = _prefixId.prefix "hasQuotationMethod"
    /// <summary>
    ///   <para>rdfs:label : has scheduled termination date</para>
    ///   <para>skos:definition : date on which credit protection is due to expire as agreed by both parties</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasScheduledTerminationDate">fibo-der-cr-cds:hasScheduledTerminationDate</a>
    /// </summary>
    let hasScheduledTerminationDate = _prefixId.prefix "hasScheduledTerminationDate"
