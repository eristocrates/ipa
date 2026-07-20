namespace https.w3id.org.dsv.hash

open DoxAletheia

module dsv =
    let _namespace_name = "https://w3id.org/dsv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An Application Profile identifies classes and properties from vocabularies, and class profiles and property profiles from Application profiles that are re-used in a certain usage context. It also allows specification editors to further adjust the description of re-used classes and properties for that usage context without the need to explicitly create subclasses and subproperties.
    /// <see href="https://w3id.org/dsv#ApplicationProfile"></see></summary>
    let ApplicationProfile = _prefix "ApplicationProfile"

    /// <summary>
    /// An Application Profile Specification Document contains human-readable version of an Application Profile.
    /// <see href="https://w3id.org/dsv#ApplicationProfileSpecificationDocument"></see></summary>
    let ApplicationProfileSpecificationDocument =
        _prefix "ApplicationProfileSpecificationDocument"

    /// <summary>
    /// Profile of a class. Allows specification editors to specify profile specific names, definitions and usage notes.
    /// <see href="https://w3id.org/dsv#ClassProfile"></see></summary>
    let ClassProfile = _prefix "ClassProfile"
    /// <summary>
    /// Term profile. Allows profile editors to specify context dependent information such as label, definition, usage note, cardinalities, etc. for Class profiles and Property profiles.
    /// <see href="https://w3id.org/dsv#TermProfile"></see></summary>
    let TermProfile = _prefix "TermProfile"
    /// <summary>
    ///   <see href="https://w3id.org/dsv#DatatypePropertyProfile"></see>
    /// </summary>
    let DatatypePropertyProfile = _prefix "DatatypePropertyProfile"
    /// <summary>
    /// Profile of a property allows specification editors to specify profile specific name, definition, usage note, domain, range and cardinality.
    /// <see href="https://w3id.org/dsv#PropertyProfile"></see></summary>
    let PropertyProfile = _prefix "PropertyProfile"
    /// <summary>
    /// Invalid Term Profile is a profile, which breaks profile compliance rules. This may be for a good reason such as temporary, to be propagated upstream, inconsistency.
    /// <see href="https://w3id.org/dsv#InvalidTermProfile"></see></summary>
    let InvalidTermProfile = _prefix "InvalidTermProfile"
    /// <summary>
    ///   <see href="https://w3id.org/dsv#ObjectPropertyProfile"></see>
    /// </summary>
    let ObjectPropertyProfile = _prefix "ObjectPropertyProfile"
    /// <summary>
    /// Specifies, which values of which properties of which resources are reused for the current Profile.
    /// E.g. reuse of profile name, reuse of class name, reuse of profile definition, reuse of profile usage note, etc.
    /// <see href="https://w3id.org/dsv#PropertyValueReuse"></see></summary>
    let PropertyValueReuse = _prefix "PropertyValueReuse"
    /// <summary>
    /// A Vocabulary Specification Document is a human-readable representation of a Vocabulary.
    /// <see href="https://w3id.org/dsv#VocabularySpecificationDocument"></see></summary>
    let VocabularySpecificationDocument = _prefix "VocabularySpecificationDocument"
    /// <summary>
    ///   <see href="https://w3id.org/dsv#cardinality"></see>
    /// </summary>
    let cardinality = _prefix "cardinality"
    /// <summary>
    /// The profiled class.
    /// <see href="https://w3id.org/dsv#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// Class role, e.g. Mandatory, Supportive, etc.
    /// <see href="https://w3id.org/dsv#classRole"></see></summary>
    let classRole = _prefix "classRole"
    /// <summary>
    ///   <see href="https://w3id.org/dsv#datatype"></see>
    /// </summary>
    let datatype = _prefix "datatype"
    /// <summary>
    /// Class profile, which is the domain of the property profile.
    /// <see href="https://w3id.org/dsv#domain"></see></summary>
    let domain = _prefix "domain"
    /// <summary>
    /// Link to an external documentation of this resource. Profiles of this resource should preferably link to this URL for documentation.
    /// <see href="https://w3id.org/dsv#externalDocumentation"></see></summary>
    let externalDocumentation = _prefix "externalDocumentation"
    /// <summary>
    /// Specifies a parent profile of the current profile.
    /// <see href="https://w3id.org/dsv#profileOf"></see></summary>
    let profileOf = _prefix "profileOf"
    /// <summary>
    /// The property profiled by the property profile.
    /// <see href="https://w3id.org/dsv#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// Class profile, which is the range of the object property profile.
    /// <see href="https://w3id.org/dsv#range"></see></summary>
    let range = _prefix "range"
    /// <summary>
    /// Requirement level of the property, typically mandatory, recommended or optional.
    /// <see href="https://w3id.org/dsv#requirementLevel"></see></summary>
    let requirementLevel = _prefix "requirementLevel"
    /// <summary>
    /// The Resource on which there is a property with a value for reuse.
    /// <see href="https://w3id.org/dsv#reusedFromResource"></see></summary>
    let reusedFromResource = _prefix "reusedFromResource"
    /// <summary>
    ///   <see href="https://w3id.org/dsv#reusedProperty"></see>
    /// </summary>
    let reusedProperty = _prefix "reusedProperty"
    /// <summary>
    /// Points to definitions of Property value reuse for this Profile.
    /// <see href="https://w3id.org/dsv#reusesPropertyValue"></see></summary>
    let reusesPropertyValue = _prefix "reusesPropertyValue"
    /// <summary>
    /// Specifies a profile specialized by this profile.
    /// <see href="https://w3id.org/dsv#specializes"></see></summary>
    let specializes = _prefix "specializes"
