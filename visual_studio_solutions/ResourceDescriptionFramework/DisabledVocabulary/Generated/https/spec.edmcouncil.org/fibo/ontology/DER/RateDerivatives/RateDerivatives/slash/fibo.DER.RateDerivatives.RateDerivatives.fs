namespace Fibo.DER.RateDerivatives.RateDerivatives.Namespace
module RateDerivatives =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/DER/RateDerivatives/RateDerivatives.rdf") (Some @"fibo.DER.RateDerivatives.RateDerivatives") None
    let EconomicRateBasedDerivativeInstrument = {_prefixID with _localName = "EconomicRateBasedDerivativeInstrument"}
    let EconomicRateObservable = {_prefixID with _localName = "EconomicRateObservable"}
    let ForeignExchangeRateObservable = {_prefixID with _localName = "ForeignExchangeRateObservable"}
    let ForwardRateAgreement = {_prefixID with _localName = "ForwardRateAgreement"}
    let InterestRateDerivativeInstrument = {_prefixID with _localName = "InterestRateDerivativeInstrument"}
    let InterestRateObservable = {_prefixID with _localName = "InterestRateObservable"}
    let RateBasedDerivativeInstrument = {_prefixID with _localName = "RateBasedDerivativeInstrument"}
    let RateBasedObservable = {_prefixID with _localName = "RateBasedObservable"}