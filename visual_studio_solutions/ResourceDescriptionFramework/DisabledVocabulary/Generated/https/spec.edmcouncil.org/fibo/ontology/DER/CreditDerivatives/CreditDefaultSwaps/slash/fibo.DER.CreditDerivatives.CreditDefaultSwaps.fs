namespace Fibo.DER.CreditDerivatives.CreditDefaultSwaps.Namespace
module CreditDefaultSwaps =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/DER/CreditDerivatives/CreditDefaultSwaps.rdf") (Some @"fibo.DER.CreditDerivatives.CreditDefaultSwaps") None
    let AssetBackedCreditDefaultSwap = {_prefixID with _localName = "AssetBackedCreditDefaultSwap"}
    let BasketCreditDefaultSwap = {_prefixID with _localName = "BasketCreditDefaultSwap"}
    let BasketOfCreditDefaultSwaps = {_prefixID with _localName = "BasketOfCreditDefaultSwaps"}
    let CashSettlementMethod = {_prefixID with _localName = "CashSettlementMethod"}
    let ContingentCreditDefaultSwap = {_prefixID with _localName = "ContingentCreditDefaultSwap"}
    let CreditDefaultSwap = {_prefixID with _localName = "CreditDefaultSwap"}
    let CreditDefaultSwapIndex = {_prefixID with _localName = "CreditDefaultSwapIndex"}
    let CreditEventNotice = {_prefixID with _localName = "CreditEventNotice"}
    let CreditProtectionTerms = {_prefixID with _localName = "CreditProtectionTerms"}
    let DeliverableObligation = {_prefixID with _localName = "DeliverableObligation"}
    let DeliverableObligationBuyer = {_prefixID with _localName = "DeliverableObligationBuyer"}
    let DeliverableObligationSeller = {_prefixID with _localName = "DeliverableObligationSeller"}
    let EscrowAgent = {_prefixID with _localName = "EscrowAgent"}
    let IndexCreditDefaultSwap = {_prefixID with _localName = "IndexCreditDefaultSwap"}
    let IndexTrancheCreditDefaultSwap = {_prefixID with _localName = "IndexTrancheCreditDefaultSwap"}
    let LoanCreditDefaultSwap = {_prefixID with _localName = "LoanCreditDefaultSwap"}
    let MultiNameCreditDefaultSwap = {_prefixID with _localName = "MultiNameCreditDefaultSwap"}
    let NotifyingParty = {_prefixID with _localName = "NotifyingParty"}
    let SettlementAuction = {_prefixID with _localName = "SettlementAuction"}
    let SingleNameCreditDefaultSwap = {_prefixID with _localName = "SingleNameCreditDefaultSwap"}
    let TriggeringEvent = {_prefixID with _localName = "TriggeringEvent"}
    let allowsSubstitution = {_prefixID with _localName = "allowsSubstitution"}
    let hasContractPrice = {_prefixID with _localName = "hasContractPrice"}
    let hasMinimumQuotationAmount = {_prefixID with _localName = "hasMinimumQuotationAmount"}
    let hasQuotationMethod = {_prefixID with _localName = "hasQuotationMethod"}
    let hasScheduledTerminationDate = {_prefixID with _localName = "hasScheduledTerminationDate"}