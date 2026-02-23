namespace Fibo.SEC.Equities.DepositaryReceipts.Namespace
module DepositaryReceipts =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Equities/DepositaryReceipts.rdf") (Some @"fibo.SEC.Equities.DepositaryReceipts") None
    let AmericanDepositaryReceipt = {_prefixID with _localName = "AmericanDepositaryReceipt"}
    let AmericanDepositaryReceiptLevel = {_prefixID with _localName = "AmericanDepositaryReceiptLevel"}
    let AmericanDepositaryReceiptLevelScheme = {_prefixID with _localName = "AmericanDepositaryReceiptLevelScheme"}
    let ChineseDepositaryReceipt = {_prefixID with _localName = "ChineseDepositaryReceipt"}
    let DepositaryReceipt = {_prefixID with _localName = "DepositaryReceipt"}
    let EuropeanDepositaryReceipt = {_prefixID with _localName = "EuropeanDepositaryReceipt"}
    let GlobalDepositaryReceipt = {_prefixID with _localName = "GlobalDepositaryReceipt"}
    let HongKongDepositaryReceipt = {_prefixID with _localName = "HongKongDepositaryReceipt"}
    let IndianDepositoryReceipt = {_prefixID with _localName = "IndianDepositoryReceipt"}
    let JapaneseDepositaryReceipt = {_prefixID with _localName = "JapaneseDepositaryReceipt"}
    let LevelIAmericanDepositaryReceipt = {_prefixID with _localName = "LevelIAmericanDepositaryReceipt"}
    let LevelIIAmericanDepositaryReceipt = {_prefixID with _localName = "LevelIIAmericanDepositaryReceipt"}
    let LevelIIIAmericanDepositaryReceipt = {_prefixID with _localName = "LevelIIIAmericanDepositaryReceipt"}
    let LuxembourgDepositaryReceipt = {_prefixID with _localName = "LuxembourgDepositaryReceipt"}
    let OffshoreDepositaryReceipt = {_prefixID with _localName = "OffshoreDepositaryReceipt"}
    let ParticipatoryNote = {_prefixID with _localName = "ParticipatoryNote"}
    let PrivatelyPlacedDepositaryReceipt = {_prefixID with _localName = "PrivatelyPlacedDepositaryReceipt"}
    let SponsoredDepositaryReceipt = {_prefixID with _localName = "SponsoredDepositaryReceipt"}
    let UnsponsoredDepositaryReceipt = {_prefixID with _localName = "UnsponsoredDepositaryReceipt"}
    let hasMultiplier = {_prefixID with _localName = "hasMultiplier"}
    let hasNumberOfDepositaryReceiptsIssued = {_prefixID with _localName = "hasNumberOfDepositaryReceiptsIssued"}
    let hasTradedSecurity = {_prefixID with _localName = "hasTradedSecurity"}
    let hasTradedShare = {_prefixID with _localName = "hasTradedShare"}