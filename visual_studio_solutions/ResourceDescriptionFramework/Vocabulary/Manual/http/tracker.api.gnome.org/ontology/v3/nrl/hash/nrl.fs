namespace Nepomuk.nrl.v3.Namespace

module nrl =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/nrl#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/12-nrl.ontology")
            (Some "nepomuk.nrl.v3")
            None

    let Ontology = { _prefixID with _localName = "Ontology" }
    let prefix = { _prefixID with _localName = "prefix" }
    let lastModified = { _prefixID with _localName = "lastModified" }

    let InverseFunctionalProperty =
        { _prefixID with _localName = "InverseFunctionalProperty" }

    let maxCardinality = { _prefixID with _localName = "maxCardinality" }
    let Namespace = { _prefixID with _localName = "Namespace" }
    let domainIndex = { _prefixID with _localName = "domainIndex" }
    let indexed = { _prefixID with _localName = "indexed" }
    let secondaryIndex = { _prefixID with _localName = "secondaryIndex" }
    let fulltextIndexed = { _prefixID with _localName = "fulltextIndexed" }
    let weight = { _prefixID with _localName = "weight" }
    let added = { _prefixID with _localName = "added" }
    let modified = { _prefixID with _localName = "modified" }
    let notify = { _prefixID with _localName = "notify" }
    let deprecated = { _prefixID with _localName = "deprecated" }
    let classSpecification = { _prefixID with _localName = "classSpecification" }
    let propertySpecification = { _prefixID with _localName = "propertySpecification" }
