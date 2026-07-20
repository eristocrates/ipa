namespace https.w3id.org.isCharacterisedBy.hash

open DoxAletheia

module icb =
    let _namespace_name = "https://w3id.org/isCharacterisedBy#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Property is a qualifiable or quantifiable attribute, or characteristic of something. or somebody
    /// <see href="https://w3id.org/isCharacterisedBy#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// A subject of interest is an abstraction of a real world phenomena (thing, person, event, etc).
    /// <see href="https://w3id.org/isCharacterisedBy#SubjectOfInterest"></see></summary>
    let SubjectOfInterest = _prefix "SubjectOfInterest"
    /// <summary>
    /// Relationship between a SubjectOfInterest and the Property that characterises it.
    /// <see href="https://w3id.org/isCharacterisedBy#isCharacterisedBy"></see></summary>
    let isCharacterisedBy = _prefix "isCharacterisedBy"
    /// <summary>
    /// Relationship between a member and the group it belongs to.
    /// <see href="https://w3id.org/isCharacterisedBy#belongsTo"></see></summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// A reference to the unit of measure of a quantifiable aspect (attribute or characteristic).
    /// <see href="https://w3id.org/isCharacterisedBy#Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// Relationship between a Property and the SubjectOfInterest it characterises.
    /// <see href="https://w3id.org/isCharacterisedBy#characterises"></see></summary>
    let characterises = _prefix "characterises"
    /// <summary>
    /// Minimun permissible value.
    /// <see href="https://w3id.org/isCharacterisedBy#minValue"></see></summary>
    let minValue = _prefix "minValue"
    /// <summary>
    /// Relationship between a quantifiable property and a unit of measurement
    /// <see href="https://w3id.org/isCharacterisedBy#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    /// Specific value.
    /// <see href="https://w3id.org/isCharacterisedBy#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Maximum permissible value.
    /// <see href="https://w3id.org/isCharacterisedBy#maxValue"></see></summary>
    let maxValue = _prefix "maxValue"
    /// <summary>
    /// Relationship between a group and the members of such group. All the members of a group have the same charabterists or attributes.
    /// <see href="https://w3id.org/isCharacterisedBy#isGroupingOf"></see></summary>
    let isGroupingOf = _prefix "isGroupingOf"
    /// <summary>
    /// Relationship between an unit and the property of which it is a unit of measurement.
    /// <see href="https://w3id.org/isCharacterisedBy#isUnitFor"></see></summary>
    let isUnitFor = _prefix "isUnitFor"
