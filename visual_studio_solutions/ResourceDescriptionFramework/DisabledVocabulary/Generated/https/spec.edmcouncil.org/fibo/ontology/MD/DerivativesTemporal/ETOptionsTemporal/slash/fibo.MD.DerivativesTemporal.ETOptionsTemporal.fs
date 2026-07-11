namespace Fibo.MD.DerivativesTemporal.ETOptionsTemporal.Namespace
module ETOptionsTemporal =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/ETOptionsTemporal/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/MD/DerivativesTemporal/ETOptionsTemporal.rdf") (Some @"fibo.MD.DerivativesTemporal.ETOptionsTemporal") None
    let Delta = {_prefixID with _localName = "Delta"}
    let OptionDailySettlementPrice = {_prefixID with _localName = "OptionDailySettlementPrice"}
    let OptionTheoreticalValue = {_prefixID with _localName = "OptionTheoreticalValue"}
    let OptionsGreek = {_prefixID with _localName = "OptionsGreek"}
    let OptionsTheta = {_prefixID with _localName = "OptionsTheta"}
    let OptionsVega = {_prefixID with _localName = "OptionsVega"}