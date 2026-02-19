namespace Void.Namespace

module ``void`` =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://rdfs.org/ns/void#"
            None
            (Some "void")
            None

    let ``class`` = { _prefixID with _localName = "class" }

    let classPartition = { _prefixID with _localName = "classPartition" }

    let classes = { _prefixID with _localName = "classes" }

    let dataDump = { _prefixID with _localName = "dataDump" }

    let Dataset = { _prefixID with _localName = "Dataset" }

    let DatasetDescription = { _prefixID with _localName = "DatasetDescription" }

    let distinctObjects = { _prefixID with _localName = "distinctObjects" }

    let distinctSubjects = { _prefixID with _localName = "distinctSubjects" }

    let documents = { _prefixID with _localName = "documents" }

    let entities = { _prefixID with _localName = "entities" }

    let exampleResource = { _prefixID with _localName = "exampleResource" }

    let feature = { _prefixID with _localName = "feature" }

    let inDataset = { _prefixID with _localName = "inDataset" }

    let linkPredicate = { _prefixID with _localName = "linkPredicate" }

    let Linkset = { _prefixID with _localName = "Linkset" }

    let objectsTarget = { _prefixID with _localName = "objectsTarget" }

    let openSearchDescription = { _prefixID with _localName = "openSearchDescription" }

    let properties = { _prefixID with _localName = "properties" }

    let property = { _prefixID with _localName = "property" }

    let propertyPartition = { _prefixID with _localName = "propertyPartition" }

    let rootResource = { _prefixID with _localName = "rootResource" }

    let sparqlEndpoint = { _prefixID with _localName = "sparqlEndpoint" }

    let subjectsTarget = { _prefixID with _localName = "subjectsTarget" }

    let subset = { _prefixID with _localName = "subset" }

    let target = { _prefixID with _localName = "target" }

    let TechnicalFeature = { _prefixID with _localName = "TechnicalFeature" }

    let triples = { _prefixID with _localName = "triples" }

    let uriLookupEndpoint = { _prefixID with _localName = "uriLookupEndpoint" }

    let uriRegexPattern = { _prefixID with _localName = "uriRegexPattern" }

    let uriSpace = { _prefixID with _localName = "uriSpace" }

    let vocabulary = { _prefixID with _localName = "vocabulary" }
