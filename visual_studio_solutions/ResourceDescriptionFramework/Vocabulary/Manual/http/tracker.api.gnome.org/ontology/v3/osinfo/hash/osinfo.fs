namespace Nepomuk.osinfo.v3.Namespace

module osinfo =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://tracker.api.gnome.org/ontology/v3/osinfo#"
            (Some "https://gitlab.gnome.org/GNOME/tinysparql/-/raw/main/src/ontologies/nepomuk/93-osinfo.ontology")
            (Some "nepomuk.osinfo.v3")
            None

    let id = { _prefixID with _localName = "id" }
    let mediaId = { _prefixID with _localName = "mediaId" }
    let language = { _prefixID with _localName = "language" }
    let Installer = { _prefixID with _localName = "Installer" }
