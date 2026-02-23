namespace Fibo.BP.Process.MetadataBPProcess.Namespace
module MetadataBPProcess =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BP/Process/MetadataBPProcess.rdf") (Some @"fibo.BP.Process.MetadataBPProcess") None
    let ProcessModule = {_prefixID with _localName = "ProcessModule"}