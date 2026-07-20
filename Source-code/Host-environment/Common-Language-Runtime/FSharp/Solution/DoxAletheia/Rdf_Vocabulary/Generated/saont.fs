namespace https.w3id.org.sao.hash

open DoxAletheia

module saont =
    let _namespace_name = "https://w3id.org/sao#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A plan which describes a specification of the information that should be collected, so as to support accountability of systems.
    /// <see href="https://w3id.org/sao#AccountabilityPlan"></see></summary>
    let AccountabilityPlan = _prefix "AccountabilityPlan"
    /// <summary>
    /// A planned step which is deemed to be important for accountability purposes and produces AccountableResult.
    /// <see href="https://w3id.org/sao#AccountableAction"></see></summary>
    let AccountableAction = _prefix "AccountableAction"
    /// <summary>
    /// An agent (typically a human)  that can be held accountable for his/her actions.
    /// <see href="https://w3id.org/sao#AccountableAgent"></see></summary>
    let AccountableAgent = _prefix "AccountableAgent"
    /// <summary>
    /// A member of the collection of type Information Realization. Information Realizations may have multiple Information Elements.  Information Element describes in more detail a specific type of information contained by the Information Realization collection.
    /// <see href="https://w3id.org/sao#InformationElement"></see></summary>
    let InformationElement = _prefix "InformationElement"
    /// <summary>
    /// An accountable object models an abstract representation of a thing that should be documented for accountability. This may reference the whole system, its logical part, or associated process.  For example, a larger system may be described as a group of sub-systems or a single system may be broken down into a number of layers/components (e.g., a decision logic layer).
    /// <see href="https://w3id.org/sao#AccountableObject"></see></summary>
    let AccountableObject = _prefix "AccountableObject"
    /// <summary>
    /// An output variable which is produced by an Accountable Action, for example,  a decision made by a human or a specification produced by a team. The variable is part of the accountability plan and has a corresponding InformationRealization collection in the execution trace.
    /// <see href="https://w3id.org/sao#AccountableResult"></see></summary>
    let AccountableResult = _prefix "AccountableResult"
    /// <summary>
    /// A collection of pieces of information (InformationElements) which corresponds to a variable of type  AccountableResult. The collection represents the actual piece of provenance information documenting a specific AccountableResult during a single plan execution.
    /// <see href="https://w3id.org/sao#InformationRealization"></see></summary>
    let InformationRealization = _prefix "InformationRealization"
    /// <summary>
    /// A system that the collected accountability information is about.
    /// <see href="https://w3id.org/sao#System"></see></summary>
    let System = _prefix "System"
    /// <summary>
    /// Inverse of is accountable for
    /// <see href="https://w3id.org/sao#hasAccountableAgent"></see></summary>
    let hasAccountableAgent = _prefix "hasAccountableAgent"
    /// <summary>
    /// A relation that links accountable agents to entities they are accountable for.
    /// <see href="https://w3id.org/sao#isAccountableFor"></see></summary>
    let isAccountableFor = _prefix "isAccountableFor"
    /// <summary>
    ///   <see href="https://w3id.org/sao#hasRelatedAccountableResult"></see>
    /// </summary>
    let hasRelatedAccountableResult = _prefix "hasRelatedAccountableResult"
    /// <summary>
    /// A relation which describes the information described by an accountable result relates to an accountable object.
    /// <see href="https://w3id.org/sao#relatesToAccountableObject"></see></summary>
    let relatesToAccountableObject = _prefix "relatesToAccountableObject"
    /// <summary>
    /// Inverse of specified for system.
    /// <see href="https://w3id.org/sao#hasSpecifiedAccountabiltyPlan"></see></summary>
    let hasSpecifiedAccountabiltyPlan = _prefix "hasSpecifiedAccountabiltyPlan"
    /// <summary>
    /// A relation that links the accountability plan to the system it was specified for.
    /// <see href="https://w3id.org/sao#specifiedForSystem"></see></summary>
    let specifiedForSystem = _prefix "specifiedForSystem"
    /// <summary>
    /// A relation which describes that an accountable object have some effect on the system's accountability.
    /// <see href="https://w3id.org/sao#impacts"></see></summary>
    let impacts = _prefix "impacts"
    /// <summary>
    /// Inverse of impacts.
    /// <see href="https://w3id.org/sao#isImpactedBy"></see></summary>
    let isImpactedBy = _prefix "isImpactedBy"
