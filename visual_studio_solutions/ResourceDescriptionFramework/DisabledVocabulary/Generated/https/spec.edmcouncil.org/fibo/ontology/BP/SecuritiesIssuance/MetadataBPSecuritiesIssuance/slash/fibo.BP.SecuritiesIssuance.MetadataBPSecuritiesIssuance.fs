namespace Fibo.BP.SecuritiesIssuance.MetadataBPSecuritiesIssuance.Namespace
module MetadataBPSecuritiesIssuance =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance.rdf") (Some @"fibo.BP.SecuritiesIssuance.MetadataBPSecuritiesIssuance") None
    let SecuritiesIssuanceModule = {_prefixID with _localName = "SecuritiesIssuanceModule"}