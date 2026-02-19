namespace Swap.pim.qif.Namespace
module qif =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/pim/qif#" (Some "http://www.w3.org/2000/10/swap/pim/qif") (Some "swap.pim.qif") None
    let Account = {_prefixID with _localName = "Account"}
    let Bank = {_prefixID with _localName = "Bank"}
    let Cat = {_prefixID with _localName = "Cat"}
    let Classified = {_prefixID with _localName = "Classified"}
    let DocumentMetadataForm = {_prefixID with _localName = "DocumentMetadataForm"}
    let Receipt = {_prefixID with _localName = "Receipt"}
    let SplitTransaction = {_prefixID with _localName = "SplitTransaction"}
    let SupportingDocument = {_prefixID with _localName = "SupportingDocument"}
    let Transaction = {_prefixID with _localName = "Transaction"}
    let Unclassified = {_prefixID with _localName = "Unclassified"}
    let UnclassifiedIncome = {_prefixID with _localName = "UnclassifiedIncome"}
    let UnclassifiedOutgoing = {_prefixID with _localName = "UnclassifiedOutgoing"}
    let accordingTo = {_prefixID with _localName = "accordingTo"}
    let amount = {_prefixID with _localName = "amount"}
    let category = {_prefixID with _localName = "category"}
    let date = {_prefixID with _localName = "date"}
    let payee = {_prefixID with _localName = "payee"}
    let splitPart = {_prefixID with _localName = "splitPart"}
    let splitReverse = {_prefixID with _localName = "splitReverse"}
    let toAccount = {_prefixID with _localName = "toAccount"}