namespace Fibo.SEC.Securities.Baskets.Namespace
module Baskets =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/Baskets.rdf") (Some @"fibo.SEC.Securities.Baskets") None
    let BasketOfIndices = {_prefixID with _localName = "BasketOfIndices"}
    let BasketOfIndicesConstituent = {_prefixID with _localName = "BasketOfIndicesConstituent"}
    let BasketOfSecurities = {_prefixID with _localName = "BasketOfSecurities"}
    let MixedBasket = {_prefixID with _localName = "MixedBasket"}
    let SecuritiesBasketConstituent = {_prefixID with _localName = "SecuritiesBasketConstituent"}