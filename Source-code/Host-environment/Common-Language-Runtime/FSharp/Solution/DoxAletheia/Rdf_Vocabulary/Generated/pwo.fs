namespace http.purl.org.spar.pwo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pwo =
    let _namespace_iri = Namespace_Iri pwo |> NamespaceIRI
    /// <summary>
    ///   <para>pwo:hasFirstStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A workflow that starts with a particular step.</para>
    /// labels<para>has first step</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/hasFirstStep">http://purl.org/spar/pwo/hasFirstStep</seealso>
    let hasFirstStep = Prefixed_Name(pwo, "hasFirstStep") |> PrefixedName
    /// <summary>
    ///   <para>pwo:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An atomic unit of a workflow, that may be characterized by a starting time and an ending time, and may be associated with one or more events.  A workflow step usually involves some input information, material or energy needed to complete the step, and some output information, material or energy produced by that step.  In the case of a publishing workflow, a step typically results in the creation of a publication entity, usually by the modification of another pre-existing publication entity, e.g. the creation of an edited paper from a rough draft, or of an HTML representation from an XML mark-up.</para>
    /// labels<para>step</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/Step">http://purl.org/spar/pwo/Step</seealso>
    let Step = Prefixed_Name(pwo, "Step") |> PrefixedName
    /// <summary>
    ///   <para>pwo:needs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property linking a workflow step to anything required to undertake that step.</para>
    /// labels<para>needs</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/needs">http://purl.org/spar/pwo/needs</seealso>
    let needs = Prefixed_Name(pwo, "needs") |> PrefixedName
    /// <summary>
    ///   <para>pwo:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property linking a workflow step to the thing that the step produces, creates or results in.</para>
    /// labels<para>produces</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/produces">http://purl.org/spar/pwo/produces</seealso>
    let produces = Prefixed_Name(pwo, "produces") |> PrefixedName
    /// <summary>
    ///   <para>pwo:Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sequence of connected steps, representing a sequence of publishing operations undertaken by agents. A workflow may be seen as an abstract model of real work.</para>
    /// labels<para>workflow</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/Workflow">http://purl.org/spar/pwo/Workflow</seealso>
    let Workflow = Prefixed_Name(pwo, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>pwo:involvesAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property linking a step in a workflow or a particular execution of a workflow to an action.</para>
    /// labels<para>involves action</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/involvesAction">http://purl.org/spar/pwo/involvesAction</seealso>
    let involvesAction = Prefixed_Name(pwo, "involvesAction") |> PrefixedName
    /// <summary>
    ///   <para>pwo:WorkflowExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/pwo/WorkflowExecution">http://purl.org/spar/pwo/WorkflowExecution</seealso>
    let WorkflowExecution = Prefixed_Name(pwo, "WorkflowExecution") |> PrefixedName
    /// <summary>
    ///   <para>pwo:isActionInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property linking an event to a step in a workflow or to a particular execution of a workflow description.</para>
    /// labels<para>is action involved in step</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/isActionInvolvedIn">http://purl.org/spar/pwo/isActionInvolvedIn</seealso>
    let isActionInvolvedIn = Prefixed_Name(pwo, "isActionInvolvedIn") |> PrefixedName
    /// <summary>
    ///   <para>pwo:isExecutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property allows to link a workflow description to the related workflow execution.</para>
    /// labels<para>is executed by</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/isExecutedBy">http://purl.org/spar/pwo/isExecutedBy</seealso>
    let isExecutedBy = Prefixed_Name(pwo, "isExecutedBy") |> PrefixedName
    /// <summary>
    ///   <para>pwo:executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property allows to link a workflow execution to the related workflow description.</para>
    /// labels<para>executes</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/executes">http://purl.org/spar/pwo/executes</seealso>
    let executes = Prefixed_Name(pwo, "executes") |> PrefixedName
    /// <summary>
    ///   <para>pwo:hasPreviousStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property linking a step in a workflow with the step that directly precedes it.</para>
    /// labels<para>has previous step</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/hasPreviousStep">http://purl.org/spar/pwo/hasPreviousStep</seealso>
    let hasPreviousStep = Prefixed_Name(pwo, "hasPreviousStep") |> PrefixedName
    /// <summary>
    ///   <para>pwo:hasStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property linking a workflow to a component step.</para>
    /// labels<para>has step</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/hasStep">http://purl.org/spar/pwo/hasStep</seealso>
    let hasStep = Prefixed_Name(pwo, "hasStep") |> PrefixedName
    /// <summary>
    ///   <para>pwo:hasNextStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property linking a step in a workflow with the step that directly follows it.</para>
    /// labels<para>has next step</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/hasNextStep">http://purl.org/spar/pwo/hasNextStep</seealso>
    let hasNextStep = Prefixed_Name(pwo, "hasNextStep") |> PrefixedName
    /// <summary>
    ///   <para>pwo:isNeededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property linking a thing required to undertake a workflow step to the step itself.</para>
    /// labels<para>is needed by</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/isNeededBy">http://purl.org/spar/pwo/isNeededBy</seealso>
    let isNeededBy = Prefixed_Name(pwo, "isNeededBy") |> PrefixedName
    /// <summary>
    ///   <para>pwo:isStepOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The property linking a step in a workflow to the workflow of which it is a component.</para>
    /// labels<para>is step of</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/isStepOf">http://purl.org/spar/pwo/isStepOf</seealso>
    let isStepOf = Prefixed_Name(pwo, "isStepOf") |> PrefixedName
    /// <summary>
    ///   <para>pwo:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property linking something to the workflow step that produces, creates or results in that thing.</para>
    /// labels<para>is produced by</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/isProducedBy">http://purl.org/spar/pwo/isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(pwo, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>pwo:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event with at least one agent that is participant in it and that is linked to a workflow execution and to a step of the related workflow description.</para>
    /// labels<para>action</para></remarks>
    /// <seealso href="http://purl.org/spar/pwo/Action">http://purl.org/spar/pwo/Action</seealso>
    let Action = Prefixed_Name(pwo, "Action") |> PrefixedName
