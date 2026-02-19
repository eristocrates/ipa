namespace Nepomuk.nao.v3.Namespace

module nao =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/nao#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/nepomuk/31-nao.ontology")
            (Some "nepomuk.nao.v3")
            None

    let prefLabel = { _prefixID with _localName = "prefLabel" }
    let Tag = { _prefixID with _localName = "Tag" }
    let description = { _prefixID with _localName = "description" }
    let hasTag = { _prefixID with _localName = "hasTag" }
    let identifier = { _prefixID with _localName = "identifier" }
    let numericRating = { _prefixID with _localName = "numericRating" }
    let deprecated = { _prefixID with _localName = "deprecated" }
    let lastModified = { _prefixID with _localName = "lastModified" }
    let isRelated = { _prefixID with _localName = "isRelated" }
