namespace https.w3id.org.iadopt.ont.slash

open DoxAletheia.Rdf_Vocabulary

module iadopt =
    let _namespace_name = "https://w3id.org/iadopt/ont/"
    /// <summary>
    ///   <see href="https://w3id.org/iadopt/ont/0.9.1"></see>
    /// </summary>
    let ``_0.9.1`` = Namespaced_IRI.parse _namespace_name "0.9.1" |> NamespacedName
    /// <summary>
    /// A Constraint limits the scope of the observation and confines the context to a particular state. It describes properties of the involved entities that are relevant to the particular observation.
    /// <see href="https://w3id.org/iadopt/ont/Constraint"></see></summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName
    /// <summary>
    /// An object or process that has a role in an observation. An Entity may play one of the following roles: ObjectOfInterest, ContextObject, Matrix. Whether the involvement of a particular entity is meaningful enough to include in the variable description depends on the specific context.
    /// <see href="https://w3id.org/iadopt/ont/Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// A type of a characteristic of the ObjectOfInterest.
    /// <see href="https://w3id.org/iadopt/ont/Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    /// A description of something observed or derived, minimally consisting of  an ObjectOfInterest and its Property.
    /// <see href="https://w3id.org/iadopt/ont/Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName

    /// <summary>
    /// A Variable has an Entity whose Property is observed.
    /// <see href="https://w3id.org/iadopt/ont/hasObjectOfInterest"></see></summary>
    let hasObjectOfInterest =
        Namespaced_IRI.parse _namespace_name "hasObjectOfInterest" |> NamespacedName

    /// <summary>
    /// A Variable has a Property that characterizes an Entity.
    /// <see href="https://w3id.org/iadopt/ont/hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    /// A Constraint constrains an Entity having a role in the Variable description.
    /// <see href="https://w3id.org/iadopt/ont/constrains"></see></summary>
    let constrains = Namespaced_IRI.parse _namespace_name "constrains" |> NamespacedName

    /// <summary>
    /// A Variable has a Constraint, that confines an Entity involved in the observation.
    /// <see href="https://w3id.org/iadopt/ont/hasConstraint"></see></summary>
    let hasConstraint =
        Namespaced_IRI.parse _namespace_name "hasConstraint" |> NamespacedName

    /// <summary>
    /// A Variable has an Entity that provides additional background information regarding the ObjectOfInterest.
    /// <see href="https://w3id.org/iadopt/ont/hasContextObject"></see></summary>
    let hasContextObject =
        Namespaced_IRI.parse _namespace_name "hasContextObject" |> NamespacedName

    /// <summary>
    /// A Variable might have an Entity in which the ObjectOfInterest is contained.
    /// <see href="https://w3id.org/iadopt/ont/hasMatrix"></see></summary>
    let hasMatrix = Namespaced_IRI.parse _namespace_name "hasMatrix" |> NamespacedName
