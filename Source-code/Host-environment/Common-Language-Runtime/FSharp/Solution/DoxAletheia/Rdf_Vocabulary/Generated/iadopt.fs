namespace https.w3id.org.iadopt.ont.slash

open DoxAletheia

module iadopt =
    let _namespace_name = "https://w3id.org/iadopt/ont/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/iadopt/ont/0.9.1"></see>
    /// </summary>
    let ``_0.9.1`` = _prefix "0.9.1"
    /// <summary>
    /// A Constraint limits the scope of the observation and confines the context to a particular state. It describes properties of the involved entities that are relevant to the particular observation.
    /// <see href="https://w3id.org/iadopt/ont/Constraint"></see></summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    /// An object or process that has a role in an observation. An Entity may play one of the following roles: ObjectOfInterest, ContextObject, Matrix. Whether the involvement of a particular entity is meaningful enough to include in the variable description depends on the specific context.
    /// <see href="https://w3id.org/iadopt/ont/Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// A type of a characteristic of the ObjectOfInterest.
    /// <see href="https://w3id.org/iadopt/ont/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// A description of something observed or derived, minimally consisting of  an ObjectOfInterest and its Property.
    /// <see href="https://w3id.org/iadopt/ont/Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    /// A Variable has an Entity whose Property is observed.
    /// <see href="https://w3id.org/iadopt/ont/hasObjectOfInterest"></see></summary>
    let hasObjectOfInterest = _prefix "hasObjectOfInterest"
    /// <summary>
    /// A Variable has a Property that characterizes an Entity.
    /// <see href="https://w3id.org/iadopt/ont/hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// A Constraint constrains an Entity having a role in the Variable description.
    /// <see href="https://w3id.org/iadopt/ont/constrains"></see></summary>
    let constrains = _prefix "constrains"
    /// <summary>
    /// A Variable has a Constraint, that confines an Entity involved in the observation.
    /// <see href="https://w3id.org/iadopt/ont/hasConstraint"></see></summary>
    let hasConstraint = _prefix "hasConstraint"
    /// <summary>
    /// A Variable has an Entity that provides additional background information regarding the ObjectOfInterest.
    /// <see href="https://w3id.org/iadopt/ont/hasContextObject"></see></summary>
    let hasContextObject = _prefix "hasContextObject"
    /// <summary>
    /// A Variable might have an Entity in which the ObjectOfInterest is contained.
    /// <see href="https://w3id.org/iadopt/ont/hasMatrix"></see></summary>
    let hasMatrix = _prefix "hasMatrix"
