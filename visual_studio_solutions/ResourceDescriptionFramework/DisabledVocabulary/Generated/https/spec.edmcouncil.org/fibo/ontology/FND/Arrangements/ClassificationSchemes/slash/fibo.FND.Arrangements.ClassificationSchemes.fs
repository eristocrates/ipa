namespace Fibo.FND.Arrangements.ClassificationSchemes.Namespace
module ClassificationSchemes =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/ClassificationSchemes.rdf") (Some @"fibo.FND.Arrangements.ClassificationSchemes") None
    let IndustrySectorClassificationScheme = {_prefixID with _localName = "IndustrySectorClassificationScheme"}
    let IndustrySectorClassifier = {_prefixID with _localName = "IndustrySectorClassifier"}