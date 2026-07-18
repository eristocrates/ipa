namespace https.w3id.org.dsv.hash

open DoxAletheia.Rdf_Vocabulary

module dsv =
    let _namespace_name = "https://w3id.org/dsv#"

    /// <summary>
    /// An Application Profile identifies classes and properties from vocabularies, and class profiles and property profiles from Application profiles that are re-used in a certain usage context. It also allows specification editors to further adjust the description of re-used classes and properties for that usage context without the need to explicitly create subclasses and subproperties.
    /// <see href="https://w3id.org/dsv#ApplicationProfile"></see></summary>
    let ApplicationProfile =
        Namespaced_IRI.parse _namespace_name "ApplicationProfile" |> NamespacedName

    /// <summary>
    /// An Application Profile Specification Document contains human-readable version of an Application Profile.
    /// <see href="https://w3id.org/dsv#ApplicationProfileSpecificationDocument"></see></summary>
    let ApplicationProfileSpecificationDocument =
        Namespaced_IRI.parse _namespace_name "ApplicationProfileSpecificationDocument" |> NamespacedName

    /// <summary>
    /// Profile of a class. Allows specification editors to specify profile specific names, definitions and usage notes.
    /// <see href="https://w3id.org/dsv#ClassProfile"></see></summary>
    let ClassProfile =
        Namespaced_IRI.parse _namespace_name "ClassProfile" |> NamespacedName

    /// <summary>
    /// Term profile. Allows profile editors to specify context dependent information such as label, definition, usage note, cardinalities, etc. for Class profiles and Property profiles.
    /// <see href="https://w3id.org/dsv#TermProfile"></see></summary>
    let TermProfile =
        Namespaced_IRI.parse _namespace_name "TermProfile" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsv#DatatypePropertyProfile"></see>
    /// </summary>
    let DatatypePropertyProfile =
        Namespaced_IRI.parse _namespace_name "DatatypePropertyProfile" |> NamespacedName

    /// <summary>
    /// Profile of a property allows specification editors to specify profile specific name, definition, usage note, domain, range and cardinality.
    /// <see href="https://w3id.org/dsv#PropertyProfile"></see></summary>
    let PropertyProfile =
        Namespaced_IRI.parse _namespace_name "PropertyProfile" |> NamespacedName

    /// <summary>
    /// Invalid Term Profile is a profile, which breaks profile compliance rules. This may be for a good reason such as temporary, to be propagated upstream, inconsistency.
    /// <see href="https://w3id.org/dsv#InvalidTermProfile"></see></summary>
    let InvalidTermProfile =
        Namespaced_IRI.parse _namespace_name "InvalidTermProfile" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsv#ObjectPropertyProfile"></see>
    /// </summary>
    let ObjectPropertyProfile =
        Namespaced_IRI.parse _namespace_name "ObjectPropertyProfile" |> NamespacedName

    /// <summary>
    /// Specifies, which values of which properties of which resources are reused for the current Profile.
    /// E.g. reuse of profile name, reuse of class name, reuse of profile definition, reuse of profile usage note, etc.
    /// <see href="https://w3id.org/dsv#PropertyValueReuse"></see></summary>
    let PropertyValueReuse =
        Namespaced_IRI.parse _namespace_name "PropertyValueReuse" |> NamespacedName

    /// <summary>
    /// A Vocabulary Specification Document is a human-readable representation of a Vocabulary.
    /// <see href="https://w3id.org/dsv#VocabularySpecificationDocument"></see></summary>
    let VocabularySpecificationDocument =
        Namespaced_IRI.parse _namespace_name "VocabularySpecificationDocument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsv#cardinality"></see>
    /// </summary>
    let cardinality =
        Namespaced_IRI.parse _namespace_name "cardinality" |> NamespacedName

    /// <summary>
    /// The profiled class.
    /// <see href="https://w3id.org/dsv#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// Class role, e.g. Mandatory, Supportive, etc.
    /// <see href="https://w3id.org/dsv#classRole"></see></summary>
    let classRole = Namespaced_IRI.parse _namespace_name "classRole" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dsv#datatype"></see>
    /// </summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName
    /// <summary>
    /// Class profile, which is the domain of the property profile.
    /// <see href="https://w3id.org/dsv#domain"></see></summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName

    /// <summary>
    /// Link to an external documentation of this resource. Profiles of this resource should preferably link to this URL for documentation.
    /// <see href="https://w3id.org/dsv#externalDocumentation"></see></summary>
    let externalDocumentation =
        Namespaced_IRI.parse _namespace_name "externalDocumentation" |> NamespacedName

    /// <summary>
    /// Specifies a parent profile of the current profile.
    /// <see href="https://w3id.org/dsv#profileOf"></see></summary>
    let profileOf = Namespaced_IRI.parse _namespace_name "profileOf" |> NamespacedName
    /// <summary>
    /// The property profiled by the property profile.
    /// <see href="https://w3id.org/dsv#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName
    /// <summary>
    /// Class profile, which is the range of the object property profile.
    /// <see href="https://w3id.org/dsv#range"></see></summary>
    let range = Namespaced_IRI.parse _namespace_name "range" |> NamespacedName

    /// <summary>
    /// Requirement level of the property, typically mandatory, recommended or optional.
    /// <see href="https://w3id.org/dsv#requirementLevel"></see></summary>
    let requirementLevel =
        Namespaced_IRI.parse _namespace_name "requirementLevel" |> NamespacedName

    /// <summary>
    /// The Resource on which there is a property with a value for reuse.
    /// <see href="https://w3id.org/dsv#reusedFromResource"></see></summary>
    let reusedFromResource =
        Namespaced_IRI.parse _namespace_name "reusedFromResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dsv#reusedProperty"></see>
    /// </summary>
    let reusedProperty =
        Namespaced_IRI.parse _namespace_name "reusedProperty" |> NamespacedName

    /// <summary>
    /// Points to definitions of Property value reuse for this Profile.
    /// <see href="https://w3id.org/dsv#reusesPropertyValue"></see></summary>
    let reusesPropertyValue =
        Namespaced_IRI.parse _namespace_name "reusesPropertyValue" |> NamespacedName

    /// <summary>
    /// Specifies a profile specialized by this profile.
    /// <see href="https://w3id.org/dsv#specializes"></see></summary>
    let specializes =
        Namespaced_IRI.parse _namespace_name "specializes" |> NamespacedName
