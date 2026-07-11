namespace Fibo.FND.Parties.Parties.Namespace
module Parties =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Parties/Parties.rdf") (Some @"fibo.FND.Parties.Parties") None
    let PartyRoleIdentificationScheme = {_prefixID with _localName = "PartyRoleIdentificationScheme"}
    let PartyRoleIdentifier = {_prefixID with _localName = "PartyRoleIdentifier"}
    let TaxIdentificationScheme = {_prefixID with _localName = "TaxIdentificationScheme"}
    let TaxIdentifier = {_prefixID with _localName = "TaxIdentifier"}
    let hasMailingAddress = {_prefixID with _localName = "hasMailingAddress"}