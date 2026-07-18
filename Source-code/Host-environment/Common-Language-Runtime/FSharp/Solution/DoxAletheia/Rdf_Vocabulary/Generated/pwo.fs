namespace http.purl.org.spar.pwo.slash

open DoxAletheia.Rdf_Vocabulary

module pwo =
    let _namespace_name = "http://purl.org/spar/pwo/"
    /// <summary>
    /// An atomic unit of a workflow, that may be characterized by a starting time and an ending time, and may be associated with one or more events.  A workflow step usually involves some input information, material or energy needed to complete the step, and some output information, material or energy produced by that step.  In the case of a publishing workflow, a step typically results in the creation of a publication entity, usually by the modification of another pre-existing publication entity, e.g. the creation of an edited paper from a rough draft, or of an HTML representation from an XML mark-up.
    /// <see href="http://purl.org/spar/pwo/Step"></see></summary>
    let Step = Namespaced_IRI.parse _namespace_name "Step" |> NamespacedName
    /// <summary>
    /// The property linking a workflow step to anything required to undertake that step.
    /// <see href="http://purl.org/spar/pwo/needs"></see></summary>
    let needs = Namespaced_IRI.parse _namespace_name "needs" |> NamespacedName
    /// <summary>
    /// The property linking a workflow step to the thing that the step produces, creates or results in.
    /// <see href="http://purl.org/spar/pwo/produces"></see></summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName
    /// <summary>
    /// An event with at least one agent that is participant in it and that is linked to a workflow execution and to a step of the related workflow description.
    /// <see href="http://purl.org/spar/pwo/Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// A sequence of connected steps, representing a sequence of publishing operations undertaken by agents. A workflow may be seen as an abstract model of real work.
    /// <see href="http://purl.org/spar/pwo/Workflow"></see></summary>
    let Workflow = Namespaced_IRI.parse _namespace_name "Workflow" |> NamespacedName

    /// <summary>
    /// The property linking a step in a workflow or a particular execution of a workflow to an action.
    /// <see href="http://purl.org/spar/pwo/involvesAction"></see></summary>
    let involvesAction =
        Namespaced_IRI.parse _namespace_name "involvesAction" |> NamespacedName

    /// <summary>
    /// A workflow that starts with a particular step.
    /// <see href="http://purl.org/spar/pwo/hasFirstStep"></see></summary>
    let hasFirstStep =
        Namespaced_IRI.parse _namespace_name "hasFirstStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/pwo/WorkflowExecution"></see>
    /// </summary>
    let WorkflowExecution =
        Namespaced_IRI.parse _namespace_name "WorkflowExecution" |> NamespacedName

    /// <summary>
    /// The property linking an event to a step in a workflow or to a particular execution of a workflow description.
    /// <see href="http://purl.org/spar/pwo/isActionInvolvedIn"></see></summary>
    let isActionInvolvedIn =
        Namespaced_IRI.parse _namespace_name "isActionInvolvedIn" |> NamespacedName

    /// <summary>
    /// This property allows to link a workflow execution to the related workflow description.
    /// <see href="http://purl.org/spar/pwo/executes"></see></summary>
    let executes = Namespaced_IRI.parse _namespace_name "executes" |> NamespacedName

    /// <summary>
    /// This property allows to link a workflow description to the related workflow execution.
    /// <see href="http://purl.org/spar/pwo/isExecutedBy"></see></summary>
    let isExecutedBy =
        Namespaced_IRI.parse _namespace_name "isExecutedBy" |> NamespacedName

    /// <summary>
    /// A property linking a step in a workflow with the step that directly precedes it.
    /// <see href="http://purl.org/spar/pwo/hasPreviousStep"></see></summary>
    let hasPreviousStep =
        Namespaced_IRI.parse _namespace_name "hasPreviousStep" |> NamespacedName

    /// <summary>
    /// The property linking a workflow to a component step.
    /// <see href="http://purl.org/spar/pwo/hasStep"></see></summary>
    let hasStep = Namespaced_IRI.parse _namespace_name "hasStep" |> NamespacedName

    /// <summary>
    /// A property linking a step in a workflow with the step that directly follows it.
    /// <see href="http://purl.org/spar/pwo/hasNextStep"></see></summary>
    let hasNextStep =
        Namespaced_IRI.parse _namespace_name "hasNextStep" |> NamespacedName

    /// <summary>
    /// The property linking a step in a workflow to the workflow of which it is a component.
    /// <see href="http://purl.org/spar/pwo/isStepOf"></see></summary>
    let isStepOf = Namespaced_IRI.parse _namespace_name "isStepOf" |> NamespacedName
    /// <summary>
    /// The property linking a thing required to undertake a workflow step to the step itself.
    /// <see href="http://purl.org/spar/pwo/isNeededBy"></see></summary>
    let isNeededBy = Namespaced_IRI.parse _namespace_name "isNeededBy" |> NamespacedName

    /// <summary>
    /// The property linking something to the workflow step that produces, creates or results in that thing.
    /// <see href="http://purl.org/spar/pwo/isProducedBy"></see></summary>
    let isProducedBy =
        Namespaced_IRI.parse _namespace_name "isProducedBy" |> NamespacedName
