namespace Fibo.SEC.Debt.MetadataSECDebt.Namespace
module MetadataSECDebt =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Debt/MetadataSECDebt.rdf") (Some @"fibo.SEC.Debt.MetadataSECDebt") None
    let DebtModule = {_prefixID with _localName = "DebtModule"}