namespace Fibo.FND.Organizations.MetadataFNDOrganizations.Namespace
module MetadataFNDOrganizations =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Organizations/MetadataFNDOrganizations.rdf") (Some @"fibo.FND.Organizations.MetadataFNDOrganizations") None
    let OrganizationsModule = {_prefixID with _localName = "OrganizationsModule"}