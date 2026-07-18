namespace http.w3id.org.CEON.ontology.plan.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_plan =
    let _namespace_name = "http://w3id.org/CEON/ontology/plan/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/plan/0.1/"></see>
    /// </summary>
    let ``_0.1/`` = Namespaced_IRI.parse _namespace_name "0.1/" |> NamespacedName

    /// <summary>
    /// A Description is a SocialObject that represents a conceptualization.
    /// For example, a Plan is a Description of some actions to be executed by agents in a certain way, with certain parameters etc. Descriptions 'define' or 'use' concepts, and can be 'satisfied' by situations.
    /// <see href="http://w3id.org/CEON/ontology/plan/Description"></see></summary>
    let Description =
        Namespaced_IRI.parse _namespace_name "Description" |> NamespacedName

    /// <summary>
    /// A Description having an explicit goal, to be achieved by executing the plan.
    /// <see href="http://w3id.org/CEON/ontology/plan/Plan"></see></summary>
    let Plan = Namespaced_IRI.parse _namespace_name "Plan" |> NamespacedName

    /// <summary>
    /// Plan executions are situations that proactively satisfy a plan. Subplan executions are proper parts of the whole plan execution.
    /// <see href="http://w3id.org/CEON/ontology/plan/PlanExecution"></see></summary>
    let PlanExecution =
        Namespaced_IRI.parse _namespace_name "PlanExecution" |> NamespacedName

    /// <summary>
    /// A relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan.
    /// <see href="http://w3id.org/CEON/ontology/plan/satisfiesPlan"></see></summary>
    let satisfiesPlan =
        Namespaced_IRI.parse _namespace_name "satisfiesPlan" |> NamespacedName

    /// <summary>
    /// The situation after the execution takes place, i.e. the state of affairs after the process event, such as the product being assembled, or the material being recycled.
    /// <see href="http://w3id.org/CEON/ontology/plan/followsExecution"></see></summary>
    let followsExecution =
        Namespaced_IRI.parse _namespace_name "followsExecution" |> NamespacedName

    /// <summary>
    /// The situation before the process event takes place, i.e. the state of affairs before the execution, such as the state of the set of components before they are assembled into a product item, or the material state before being recycled.
    /// <see href="http://w3id.org/CEON/ontology/plan/precedesExecution"></see></summary>
    let precedesExecution =
        Namespaced_IRI.parse _namespace_name "precedesExecution" |> NamespacedName

    /// <summary>
    /// A plan can have specific executions.
    /// <see href="http://w3id.org/CEON/ontology/plan/hasPlanExecution"></see></summary>
    let hasPlanExecution =
        Namespaced_IRI.parse _namespace_name "hasPlanExecution" |> NamespacedName

    /// <summary>
    /// Represents the time at which something takes place.
    /// <see href="http://w3id.org/CEON/ontology/plan/occursAtTime"></see></summary>
    let occursAtTime =
        Namespaced_IRI.parse _namespace_name "occursAtTime" |> NamespacedName
