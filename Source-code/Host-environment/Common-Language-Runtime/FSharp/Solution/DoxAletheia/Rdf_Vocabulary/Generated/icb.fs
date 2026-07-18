namespace https.w3id.org.isCharacterisedBy.hash

open DoxAletheia.Rdf_Vocabulary

module icb =
    let _namespace_name = "https://w3id.org/isCharacterisedBy#"
    /// <summary>
    /// Property is a qualifiable or quantifiable attribute, or characteristic of something. or somebody
    /// <see href="https://w3id.org/isCharacterisedBy#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    /// A subject of interest is an abstraction of a real world phenomena (thing, person, event, etc).
    /// <see href="https://w3id.org/isCharacterisedBy#SubjectOfInterest"></see></summary>
    let SubjectOfInterest =
        Namespaced_IRI.parse _namespace_name "SubjectOfInterest" |> NamespacedName

    /// <summary>
    /// Relationship between a SubjectOfInterest and the Property that characterises it.
    /// <see href="https://w3id.org/isCharacterisedBy#isCharacterisedBy"></see></summary>
    let isCharacterisedBy =
        Namespaced_IRI.parse _namespace_name "isCharacterisedBy" |> NamespacedName

    /// <summary>
    /// Relationship between a member and the group it belongs to.
    /// <see href="https://w3id.org/isCharacterisedBy#belongsTo"></see></summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    /// A reference to the unit of measure of a quantifiable aspect (attribute or characteristic).
    /// <see href="https://w3id.org/isCharacterisedBy#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// Relationship between a Property and the SubjectOfInterest it characterises.
    /// <see href="https://w3id.org/isCharacterisedBy#characterises"></see></summary>
    let characterises =
        Namespaced_IRI.parse _namespace_name "characterises" |> NamespacedName

    /// <summary>
    /// Minimun permissible value.
    /// <see href="https://w3id.org/isCharacterisedBy#minValue"></see></summary>
    let minValue = Namespaced_IRI.parse _namespace_name "minValue" |> NamespacedName
    /// <summary>
    /// Relationship between a quantifiable property and a unit of measurement
    /// <see href="https://w3id.org/isCharacterisedBy#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName
    /// <summary>
    /// Specific value.
    /// <see href="https://w3id.org/isCharacterisedBy#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// Maximum permissible value.
    /// <see href="https://w3id.org/isCharacterisedBy#maxValue"></see></summary>
    let maxValue = Namespaced_IRI.parse _namespace_name "maxValue" |> NamespacedName

    /// <summary>
    /// Relationship between a group and the members of such group. All the members of a group have the same charabterists or attributes.
    /// <see href="https://w3id.org/isCharacterisedBy#isGroupingOf"></see></summary>
    let isGroupingOf =
        Namespaced_IRI.parse _namespace_name "isGroupingOf" |> NamespacedName

    /// <summary>
    /// Relationship between an unit and the property of which it is a unit of measurement.
    /// <see href="https://w3id.org/isCharacterisedBy#isUnitFor"></see></summary>
    let isUnitFor = Namespaced_IRI.parse _namespace_name "isUnitFor" |> NamespacedName
