namespace Fibo.FND.Accounting.MetadataFNDAccounting.Namespace
module MetadataFNDAccounting =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Accounting/MetadataFNDAccounting.rdf") (Some @"fibo.FND.Accounting.MetadataFNDAccounting") None
    let AccountingModule = {_prefixID with _localName = "AccountingModule"}