namespace http.data.press.net.ontology.stuff.slash

open DoxAletheia

module pns =
    let _namespace_name = "http://data.press.net/ontology/stuff/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A base class for all intangible stuff (eg love, conservatism, fashion)
    /// <see href="http://data.press.net/ontology/stuff/Intangible"></see></summary>
    let Intangible = _prefix "Intangible"
    /// <summary>
    /// Generic Stuff Class  - a base class for all domain stuff
    /// <see href="http://data.press.net/ontology/stuff/Stuff"></see></summary>
    let Stuff = _prefix "Stuff"
    /// <summary>
    /// A Location - a base class for Locations. Also a subclass of geo:SpatialThing
    /// <see href="http://data.press.net/ontology/stuff/Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// A base class for all tangible stuff (eg people, places, physical things)
    /// <see href="http://data.press.net/ontology/stuff/Tangible"></see></summary>
    let Tangible = _prefix "Tangible"
    /// <summary>
    /// An Organization - a base class for instances of organizations. Also a subclass of foaf:Organization
    /// <see href="http://data.press.net/ontology/stuff/Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// A Person - a base class for people instances. Also a subclass of foaf:Person
    /// <see href="http://data.press.net/ontology/stuff/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// String property that indicates an alias of a Stuff instance. For example 'Television' might have an alias of 'TV'.
    /// <see href="http://data.press.net/ontology/stuff/alias"></see></summary>
    let alias = _prefix "alias"
    /// <summary>
    /// String property that indicates the definitive description of a Stuff instance.
    /// <see href="http://data.press.net/ontology/stuff/comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// Property of a Person. A person's date of birth
    /// <see href="http://data.press.net/ontology/stuff/dateOfBirth"></see></summary>
    let dateOfBirth = _prefix "dateOfBirth"
    /// <summary>
    /// Property of a Person. A person's date of death
    /// <see href="http://data.press.net/ontology/stuff/dateOfDeath"></see></summary>
    let dateOfDeath = _prefix "dateOfDeath"
    /// <summary>
    /// Property that associates assets directly with domain entities, e.g. official biography, corporate logo
    /// <see href="http://data.press.net/ontology/stuff/hasAsset"></see></summary>
    let hasAsset = _prefix "hasAsset"
    /// <summary>
    /// Property that associates images with domain entities, e.g. official photograph, corporate logo
    /// <see href="http://data.press.net/ontology/stuff/hasImage"></see></summary>
    let hasImage = _prefix "hasImage"
    /// <summary>
    /// String property that indicates the definitive label of a Stuff instance. This might be the full name of a Person, Organization or something Intangible
    /// <see href="http://data.press.net/ontology/stuff/label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// String property that indicates the long name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Manchester United F.C.'
    /// <see href="http://data.press.net/ontology/stuff/longName"></see></summary>
    let longName = _prefix "longName"
    /// <summary>
    /// String property that indicates the definitive full name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label
    /// <see href="http://data.press.net/ontology/stuff/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Property that notably associates stuff together, for example Karl Lagerfeld is notably associated with Fashion
    /// <see href="http://data.press.net/ontology/stuff/notablyAssociatedWith"></see></summary>
    let notablyAssociatedWith = _prefix "notablyAssociatedWith"
    /// <summary>
    /// Property of a Location. References the parent location of this location
    /// <see href="http://data.press.net/ontology/stuff/parentLocation"></see></summary>
    let parentLocation = _prefix "parentLocation"
    /// <summary>
    /// Property of a Person. A person's place of birth
    /// <see href="http://data.press.net/ontology/stuff/placeOfBirth"></see></summary>
    let placeOfBirth = _prefix "placeOfBirth"
    /// <summary>
    /// String property that indicates the short name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Man Utd'
    /// <see href="http://data.press.net/ontology/stuff/shortName"></see></summary>
    let shortName = _prefix "shortName"
