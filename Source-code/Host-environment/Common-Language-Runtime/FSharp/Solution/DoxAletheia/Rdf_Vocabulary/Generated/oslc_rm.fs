namespace http.open_services.net.ns.rm.hash

open DoxAletheia.Rdf_Vocabulary

module oslc_rm =
    let _namespace_name = "http://open-services.net/ns/rm#"

    /// <summary>
    /// Statement of need.
    /// <see href="http://open-services.net/ns/rm#Requirement"></see></summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    /// Collection of requirements. A collection uses zero or more requirements.
    /// <see href="http://open-services.net/ns/rm#RequirementCollection"></see></summary>
    let RequirementCollection =
        Namespaced_IRI.parse _namespace_name "RequirementCollection" |> NamespacedName

    /// <summary>
    /// Expresses an affects relationship between entities, where the object entity in some way affects the subject entity. For example, a requirement is affected by a defect.
    /// <see href="http://open-services.net/ns/rm#affectedBy"></see></summary>
    let affectedBy = Namespaced_IRI.parse _namespace_name "affectedBy" |> NamespacedName

    /// <summary>
    /// Expresses a constraining relationship between entities, where the object entity constrains the subject entity. For example, a functional requirement is constrained by a safety requirement.
    /// <see href="http://open-services.net/ns/rm#constrainedBy"></see></summary>
    let constrainedBy =
        Namespaced_IRI.parse _namespace_name "constrainedBy" |> NamespacedName

    /// <summary>
    /// Expresses a constraining relationship between entities, where the subject entity constrains the object entity. For example, a safety requirement constrains a functional requirement.
    /// <see href="http://open-services.net/ns/rm#constrains"></see></summary>
    let constrains = Namespaced_IRI.parse _namespace_name "constrains" |> NamespacedName

    /// <summary>
    /// Expresses a decomposition relationship between entities, where the object entity decomposes the subject entity. For example, a system requirement is decomposed into a collection of system requirements.
    /// <see href="http://open-services.net/ns/rm#decomposedBy"></see></summary>
    let decomposedBy =
        Namespaced_IRI.parse _namespace_name "decomposedBy" |> NamespacedName

    /// <summary>
    /// Expresses a decomposition relationship between entities, where the subject entity decomposes the object entity. For example, a collection of system requirements decompose a system requirement.
    /// <see href="http://open-services.net/ns/rm#decomposes"></see></summary>
    let decomposes = Namespaced_IRI.parse _namespace_name "decomposes" |> NamespacedName

    /// <summary>
    /// Expresses an elaboration relationship between entities, where the object entity elaborates the subject entity. For example, a requirement is elaborated by a model element.
    /// <see href="http://open-services.net/ns/rm#elaboratedBy"></see></summary>
    let elaboratedBy =
        Namespaced_IRI.parse _namespace_name "elaboratedBy" |> NamespacedName

    /// <summary>
    /// Expresses an elaboration relationship between entities, where the subject entity elaborates the object entity. For example, a model element elaborates a requirement.
    /// <see href="http://open-services.net/ns/rm#elaborates"></see></summary>
    let elaborates = Namespaced_IRI.parse _namespace_name "elaborates" |> NamespacedName

    /// <summary>
    /// Expresses an implementation relationship between entities, where the object entity is a necessary or desirable aspect of an implementation of the subject entity.
    /// <see href="http://open-services.net/ns/rm#implementedBy"></see></summary>
    let implementedBy =
        Namespaced_IRI.parse _namespace_name "implementedBy" |> NamespacedName

    /// <summary>
    /// The subject is satisfied by the object. For example, a user requirement is satisfied by a system requirement.
    /// <see href="http://open-services.net/ns/rm#satisfiedBy"></see></summary>
    let satisfiedBy =
        Namespaced_IRI.parse _namespace_name "satisfiedBy" |> NamespacedName

    /// <summary>
    /// Expresses a relationship between entities, where the subject entity satisfies the object entity. For example, a system requirement satisfies a user requirement.
    /// <see href="http://open-services.net/ns/rm#satisfies"></see></summary>
    let satisfies = Namespaced_IRI.parse _namespace_name "satisfies" |> NamespacedName

    /// <summary>
    /// Expresses a specification relationship between entities, where the object entity further clarifies or specifies the subject entity. For example, a requirement is specified by a model element.
    /// <see href="http://open-services.net/ns/rm#specifiedBy"></see></summary>
    let specifiedBy =
        Namespaced_IRI.parse _namespace_name "specifiedBy" |> NamespacedName

    /// <summary>
    /// Expresses a specification relationship between entities, where the subject entity further clarifies or specifies the object entity. For example, a model element specifies a requirement.
    /// <see href="http://open-services.net/ns/rm#specifies"></see></summary>
    let specifies = Namespaced_IRI.parse _namespace_name "specifies" |> NamespacedName
    /// <summary>
    /// Expresses a tracking relationship between entities, where the object entity in some way tracks or governs the evolution of the subject entity. For example, a requirement may be said to be tracked by a change request, in that it governs the changes to a requirement according to some process machinery.
    /// <see href="http://open-services.net/ns/rm#trackedBy"></see></summary>
    let trackedBy = Namespaced_IRI.parse _namespace_name "trackedBy" |> NamespacedName
    /// <summary>
    /// Expresses a use relationship between entities, where the object entity is used by the subject entity. For example, a requirement collection may use a requirement.
    /// <see href="http://open-services.net/ns/rm#uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName

    /// <summary>
    /// Expresses a validation relationship between entities, where the object entity in some way validates the subject entity. For example, a requirement collection may be said to be validated by a test plan.
    /// <see href="http://open-services.net/ns/rm#validatedBy"></see></summary>
    let validatedBy =
        Namespaced_IRI.parse _namespace_name "validatedBy" |> NamespacedName
