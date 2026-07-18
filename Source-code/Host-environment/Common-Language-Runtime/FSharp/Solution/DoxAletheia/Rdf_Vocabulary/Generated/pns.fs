namespace http.data.press.net.ontology.stuff.slash

open DoxAletheia.Rdf_Vocabulary

module pns =
    let _namespace_name = "http://data.press.net/ontology/stuff/"
    /// <summary>
    /// A base class for all intangible stuff (eg love, conservatism, fashion)
    /// <see href="http://data.press.net/ontology/stuff/Intangible"></see></summary>
    let Intangible = Namespaced_IRI.parse _namespace_name "Intangible" |> NamespacedName
    /// <summary>
    /// Generic Stuff Class  - a base class for all domain stuff
    /// <see href="http://data.press.net/ontology/stuff/Stuff"></see></summary>
    let Stuff = Namespaced_IRI.parse _namespace_name "Stuff" |> NamespacedName
    /// <summary>
    /// A Location - a base class for Locations. Also a subclass of geo:SpatialThing
    /// <see href="http://data.press.net/ontology/stuff/Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// A base class for all tangible stuff (eg people, places, physical things)
    /// <see href="http://data.press.net/ontology/stuff/Tangible"></see></summary>
    let Tangible = Namespaced_IRI.parse _namespace_name "Tangible" |> NamespacedName

    /// <summary>
    /// An Organization - a base class for instances of organizations. Also a subclass of foaf:Organization
    /// <see href="http://data.press.net/ontology/stuff/Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// A Person - a base class for people instances. Also a subclass of foaf:Person
    /// <see href="http://data.press.net/ontology/stuff/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// String property that indicates an alias of a Stuff instance. For example 'Television' might have an alias of 'TV'.
    /// <see href="http://data.press.net/ontology/stuff/alias"></see></summary>
    let alias = Namespaced_IRI.parse _namespace_name "alias" |> NamespacedName
    /// <summary>
    /// String property that indicates the definitive description of a Stuff instance.
    /// <see href="http://data.press.net/ontology/stuff/comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName

    /// <summary>
    /// Property of a Person. A person's date of birth
    /// <see href="http://data.press.net/ontology/stuff/dateOfBirth"></see></summary>
    let dateOfBirth =
        Namespaced_IRI.parse _namespace_name "dateOfBirth" |> NamespacedName

    /// <summary>
    /// Property of a Person. A person's date of death
    /// <see href="http://data.press.net/ontology/stuff/dateOfDeath"></see></summary>
    let dateOfDeath =
        Namespaced_IRI.parse _namespace_name "dateOfDeath" |> NamespacedName

    /// <summary>
    /// Property that associates assets directly with domain entities, e.g. official biography, corporate logo
    /// <see href="http://data.press.net/ontology/stuff/hasAsset"></see></summary>
    let hasAsset = Namespaced_IRI.parse _namespace_name "hasAsset" |> NamespacedName
    /// <summary>
    /// Property that associates images with domain entities, e.g. official photograph, corporate logo
    /// <see href="http://data.press.net/ontology/stuff/hasImage"></see></summary>
    let hasImage = Namespaced_IRI.parse _namespace_name "hasImage" |> NamespacedName
    /// <summary>
    /// String property that indicates the definitive label of a Stuff instance. This might be the full name of a Person, Organization or something Intangible
    /// <see href="http://data.press.net/ontology/stuff/label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// String property that indicates the long name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Manchester United F.C.'
    /// <see href="http://data.press.net/ontology/stuff/longName"></see></summary>
    let longName = Namespaced_IRI.parse _namespace_name "longName" |> NamespacedName
    /// <summary>
    /// String property that indicates the definitive full name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label
    /// <see href="http://data.press.net/ontology/stuff/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// Property that notably associates stuff together, for example Karl Lagerfeld is notably associated with Fashion
    /// <see href="http://data.press.net/ontology/stuff/notablyAssociatedWith"></see></summary>
    let notablyAssociatedWith =
        Namespaced_IRI.parse _namespace_name "notablyAssociatedWith" |> NamespacedName

    /// <summary>
    /// Property of a Location. References the parent location of this location
    /// <see href="http://data.press.net/ontology/stuff/parentLocation"></see></summary>
    let parentLocation =
        Namespaced_IRI.parse _namespace_name "parentLocation" |> NamespacedName

    /// <summary>
    /// Property of a Person. A person's place of birth
    /// <see href="http://data.press.net/ontology/stuff/placeOfBirth"></see></summary>
    let placeOfBirth =
        Namespaced_IRI.parse _namespace_name "placeOfBirth" |> NamespacedName

    /// <summary>
    /// String property that indicates the short name of a Person or Organization via foaf:Agent. Also infers Stuff label via pns:label. For example 'Man Utd'
    /// <see href="http://data.press.net/ontology/stuff/shortName"></see></summary>
    let shortName = Namespaced_IRI.parse _namespace_name "shortName" |> NamespacedName
