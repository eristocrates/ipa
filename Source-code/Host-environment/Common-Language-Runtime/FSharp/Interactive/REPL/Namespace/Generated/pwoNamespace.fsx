#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pwo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/pwo/" "pwo"
    /// <summary>
    ///   <para>rdfs:comment : An event with at least one agent that is participant in it and that is linked to a workflow execution and to a step of the related workflow description.^^xsd:string</para>
    ///   <para>rdfs:label : action^^xsd:string</para>
    ///   <a href="http://purl.org/spar/pwo/Action">pwo:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:comment : An atomic unit of a workflow, that may be characterized by a starting time and an ending time, and may be associated with one or more events.  A workflow step usually involves some input information, material or energy needed to complete the step, and some output information, material or energy produced by that step.  In the case of a publishing workflow, a step typically results in the creation of a publication entity, usually by the modification of another pre-existing publication entity, e.g. the creation of an edited paper from a rough draft, or of an HTML representation from an XML mark-up.</para>
    ///   <para>rdfs:label : step</para>
    ///   <a href="http://purl.org/spar/pwo/Step">pwo:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>rdfs:comment : A sequence of connected steps, representing a sequence of publishing operations undertaken by agents. A workflow may be seen as an abstract model of real work.</para>
    ///   <para>rdfs:label : workflow</para>
    ///   <a href="http://purl.org/spar/pwo/Workflow">pwo:Workflow</a>
    /// </summary>
    let Workflow = _prefixId.prefix "Workflow"
    let WorkflowExecution = _prefixId.prefix "WorkflowExecution"
    /// <summary>
    ///   <para>rdfs:comment : This property allows to link a workflow execution to the related workflow description.</para>
    ///   <para>rdfs:label : executes</para>
    ///   <a href="http://purl.org/spar/pwo/executes">pwo:executes</a>
    /// </summary>
    let executes = _prefixId.prefix "executes"
    /// <summary>
    ///   <para>rdfs:comment : A workflow that starts with a particular step.</para>
    ///   <para>rdfs:label : has first step</para>
    ///   <a href="http://purl.org/spar/pwo/hasFirstStep">pwo:hasFirstStep</a>
    /// </summary>
    let hasFirstStep = _prefixId.prefix "hasFirstStep"
    /// <summary>
    ///   <para>rdfs:comment : A property linking a step in a workflow with the step that directly follows it.</para>
    ///   <para>rdfs:label : has next step</para>
    ///   <a href="http://purl.org/spar/pwo/hasNextStep">pwo:hasNextStep</a>
    /// </summary>
    let hasNextStep = _prefixId.prefix "hasNextStep"
    /// <summary>
    ///   <para>rdfs:comment : A property linking a step in a workflow with the step that directly precedes it.</para>
    ///   <para>rdfs:label : has previous step</para>
    ///   <a href="http://purl.org/spar/pwo/hasPreviousStep">pwo:hasPreviousStep</a>
    /// </summary>
    let hasPreviousStep = _prefixId.prefix "hasPreviousStep"
    /// <summary>
    ///   <para>rdfs:comment : The property linking a workflow to a component step.</para>
    ///   <para>rdfs:label : has step</para>
    ///   <a href="http://purl.org/spar/pwo/hasStep">pwo:hasStep</a>
    /// </summary>
    let hasStep = _prefixId.prefix "hasStep"
    /// <summary>
    ///   <para>rdfs:comment : The property linking a step in a workflow or a particular execution of a workflow to an action.</para>
    ///   <para>rdfs:label : involves action</para>
    ///   <a href="http://purl.org/spar/pwo/involvesAction">pwo:involvesAction</a>
    /// </summary>
    let involvesAction = _prefixId.prefix "involvesAction"
    /// <summary>
    ///   <para>rdfs:comment : The property linking an event to a step in a workflow or to a particular execution of a workflow description.</para>
    ///   <para>rdfs:label : is action involved in step</para>
    ///   <a href="http://purl.org/spar/pwo/isActionInvolvedIn">pwo:isActionInvolvedIn</a>
    /// </summary>
    let isActionInvolvedIn = _prefixId.prefix "isActionInvolvedIn"
    /// <summary>
    ///   <para>rdfs:comment : This property allows to link a workflow description to the related workflow execution.^^xsd:string</para>
    ///   <para>rdfs:label : is executed by^^xsd:string</para>
    ///   <a href="http://purl.org/spar/pwo/isExecutedBy">pwo:isExecutedBy</a>
    /// </summary>
    let isExecutedBy = _prefixId.prefix "isExecutedBy"
    /// <summary>
    ///   <para>rdfs:comment : The property linking a thing required to undertake a workflow step to the step itself.</para>
    ///   <para>rdfs:label : is needed by</para>
    ///   <a href="http://purl.org/spar/pwo/isNeededBy">pwo:isNeededBy</a>
    /// </summary>
    let isNeededBy = _prefixId.prefix "isNeededBy"
    /// <summary>
    ///   <para>rdfs:comment : The property linking something to the workflow step that produces, creates or results in that thing.</para>
    ///   <para>rdfs:label : is produced by</para>
    ///   <a href="http://purl.org/spar/pwo/isProducedBy">pwo:isProducedBy</a>
    /// </summary>
    let isProducedBy = _prefixId.prefix "isProducedBy"
    /// <summary>
    ///   <para>rdfs:comment : The property linking a step in a workflow to the workflow of which it is a component.</para>
    ///   <para>rdfs:label : is step of</para>
    ///   <a href="http://purl.org/spar/pwo/isStepOf">pwo:isStepOf</a>
    /// </summary>
    let isStepOf = _prefixId.prefix "isStepOf"
    /// <summary>
    ///   <para>rdfs:comment : The property linking a workflow step to anything required to undertake that step.</para>
    ///   <para>rdfs:label : needs</para>
    ///   <a href="http://purl.org/spar/pwo/needs">pwo:needs</a>
    /// </summary>
    let needs = _prefixId.prefix "needs"
    /// <summary>
    ///   <para>rdfs:comment : The property linking a workflow step to the thing that the step produces, creates or results in.</para>
    ///   <para>rdfs:label : produces</para>
    ///   <a href="http://purl.org/spar/pwo/produces">pwo:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
