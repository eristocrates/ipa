namespace Fibo.SEC.Funds.MetadataSECFunds.Namespace
module MetadataSECFunds =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Funds/MetadataSECFunds.rdf") (Some @"fibo.SEC.Funds.MetadataSECFunds") None
    let FundsModule = {_prefixID with _localName = "FundsModule"}