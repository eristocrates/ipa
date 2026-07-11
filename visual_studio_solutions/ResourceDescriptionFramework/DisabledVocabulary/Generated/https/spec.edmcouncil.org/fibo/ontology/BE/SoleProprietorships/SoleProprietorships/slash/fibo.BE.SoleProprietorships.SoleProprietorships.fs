namespace Fibo.BE.SoleProprietorships.SoleProprietorships.Namespace
module SoleProprietorships =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/SoleProprietorships/SoleProprietorships.rdf") (Some @"fibo.BE.SoleProprietorships.SoleProprietorships") None
    let SoleProprietor = {_prefixID with _localName = "SoleProprietor"}
    let SoleProprietorship = {_prefixID with _localName = "SoleProprietorship"}