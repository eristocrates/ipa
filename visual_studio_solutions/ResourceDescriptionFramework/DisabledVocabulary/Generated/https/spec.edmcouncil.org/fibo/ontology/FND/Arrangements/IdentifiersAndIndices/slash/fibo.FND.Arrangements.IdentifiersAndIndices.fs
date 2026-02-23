namespace Fibo.FND.Arrangements.IdentifiersAndIndices.Namespace
module IdentifiersAndIndices =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/IdentifiersAndIndices.rdf") (Some @"fibo.FND.Arrangements.IdentifiersAndIndices") None
    let Index = {_prefixID with _localName = "Index"}
    let IndexingScheme = {_prefixID with _localName = "IndexingScheme"}
    let ReassignableIdentifier = {_prefixID with _localName = "ReassignableIdentifier"}
    let constructRegex = {_prefixID with _localName = "constructRegex"}
    let hasAssignmentTerminationDate = {_prefixID with _localName = "hasAssignmentTerminationDate"}
    let hasInitialAssignmentDate = {_prefixID with _localName = "hasInitialAssignmentDate"}
    let isIndexTo = {_prefixID with _localName = "isIndexTo"}
    let parseRegex = {_prefixID with _localName = "parseRegex"}