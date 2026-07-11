namespace Nepomuk.nie.v3.Namespace

module nie =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/nie#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/nepomuk/30-nie.ontology")
            (Some "nepomuk.nie.v3")
            None

    let DataObject = { _prefixID with _localName = "DataObject" }
    let DataSource = { _prefixID with _localName = "DataSource" }
    let InformationElement = { _prefixID with _localName = "InformationElement" }
    let title = { _prefixID with _localName = "title" }
    let url = { _prefixID with _localName = "url" }

    let informationElementDate =
        { _prefixID with _localName = "informationElementDate" }

    let contentLastModified = { _prefixID with _localName = "contentLastModified" }
    let lastModified = { _prefixID with _localName = "lastModified" }
    let subject = { _prefixID with _localName = "subject" }
    let mimeType = { _prefixID with _localName = "mimeType" }
    let byteSize = { _prefixID with _localName = "byteSize" }
    let language = { _prefixID with _localName = "language" }
    let plainTextContent = { _prefixID with _localName = "plainTextContent" }
    let legal = { _prefixID with _localName = "legal" }
    let relatedTo = { _prefixID with _localName = "relatedTo" }
    let generator = { _prefixID with _localName = "generator" }
    let description = { _prefixID with _localName = "description" }
    let disclaimer = { _prefixID with _localName = "disclaimer" }
    let dataSource = { _prefixID with _localName = "dataSource" }
    let depends = { _prefixID with _localName = "depends" }
    let links = { _prefixID with _localName = "links" }
    let copyright = { _prefixID with _localName = "copyright" }
    let comment = { _prefixID with _localName = "comment" }
    let interpretedAs = { _prefixID with _localName = "interpretedAs" }
    let isStoredAs = { _prefixID with _localName = "isStoredAs" }
    let version = { _prefixID with _localName = "version" }
    let contentCreated = { _prefixID with _localName = "contentCreated" }
    let created = { _prefixID with _localName = "created" }
    let contentAccessed = { _prefixID with _localName = "contentAccessed" }
    let lastRefreshed = { _prefixID with _localName = "lastRefreshed" }
    let license = { _prefixID with _localName = "license" }
    let identifier = { _prefixID with _localName = "identifier" }
    let keyword = { _prefixID with _localName = "keyword" }
    let hasLogicalPart = { _prefixID with _localName = "hasLogicalPart" }
    let hasPart = { _prefixID with _localName = "hasPart" }
    let isPartOf = { _prefixID with _localName = "isPartOf" }
    let licenseType = { _prefixID with _localName = "licenseType" }
    let characterSet = { _prefixID with _localName = "characterSet" }
    let isLogicalPartOf = { _prefixID with _localName = "isLogicalPartOf" }
    let contentSize = { _prefixID with _localName = "contentSize" }
    let rootElementOf = { _prefixID with _localName = "rootElementOf" }
    let usageCounter = { _prefixID with _localName = "usageCounter" }
