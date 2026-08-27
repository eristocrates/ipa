namespace http.purl.org.vocab.lifecycle.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lifecycle =
    let _namespace_iri = Namespace_Iri lifecycle |> NamespaceIRI
    /// <summary>
    ///   <para>lifecycle:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#">http://purl.org/vocab/lifecycle/schema#</seealso>
    let _prefix_iri = Prefixed_Name(lifecycle, "") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents an instance of a task taking place against a given resource"</para>
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#Action">http://purl.org/vocab/lifecycle/schema#Action</seealso>
    let Action = Prefixed_Name(lifecycle, "Action") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:Completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Description</para>
    ///   <para>lifecycle:TaskProgress</para>
    ///   <para>"Represents that an individual task has been completed."</para>
    /// labels<para>"Completed"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#Completed">http://purl.org/vocab/lifecycle/schema#Completed</seealso>
    let Completed = Prefixed_Name(lifecycle, "Completed") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:Lifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A lifecycle is a series of states connected by allowable transitions. It may be used to describe the lifecycle of business objects or equally the lifecycle of a butterfly."</para>
    /// labels<para>"Lifecycle"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#Lifecycle">http://purl.org/vocab/lifecycle/schema#Lifecycle</seealso>
    let Lifecycle = Prefixed_Name(lifecycle, "Lifecycle") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:Lifecyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#Lifecyle">http://purl.org/vocab/lifecycle/schema#Lifecyle</seealso>
    let Lifecyle = Prefixed_Name(lifecycle, "Lifecyle") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:OnHold</para>
    /// </summary>
    /// <remarks>
    ///   <para>lifecycle:TaskProgress</para>
    ///   <para>rdfs:Description</para>
    ///   <para>"Represents that an individual task has been placed on hold."</para>
    /// labels<para>"On Hold"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#OnHold">http://purl.org/vocab/lifecycle/schema#OnHold</seealso>
    let OnHold = Prefixed_Name(lifecycle, "OnHold") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:Started</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Description</para>
    ///   <para>lifecycle:TaskProgress</para>
    ///   <para>"Represents that an individual task has been started."</para>
    /// labels<para>"Started"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#Started">http://purl.org/vocab/lifecycle/schema#Started</seealso>
    let Started = Prefixed_Name(lifecycle, "Started") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A state describes one possible state that a resource can be in at a given time. Resources may be in one state in a given lifecycle at any given time, states are considered mutually exclusive within a lifecycle."</para>
    /// labels<para>"State"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#State">http://purl.org/vocab/lifecycle/schema#State</seealso>
    let State = Prefixed_Name(lifecycle, "State") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a task in a workflow"</para>
    /// labels<para>"Task"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#Task">http://purl.org/vocab/lifecycle/schema#Task</seealso>
    let Task = Prefixed_Name(lifecycle, "Task") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:TaskGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a collection of tasks grouped together for convenience"</para>
    /// labels<para>"Task Group"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#TaskGroup">http://purl.org/vocab/lifecycle/schema#TaskGroup</seealso>
    let TaskGroup = Prefixed_Name(lifecycle, "TaskGroup") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:TaskProgress</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#TaskProgress">http://purl.org/vocab/lifecycle/schema#TaskProgress</seealso>
    let TaskProgress = Prefixed_Name(lifecycle, "TaskProgress") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:Transition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A transition describes the way in which a resource moves from one state to another state and may also describe the tasks required to make that transition."</para>
    /// labels<para>"Transition"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#Transition">http://purl.org/vocab/lifecycle/schema#Transition</seealso>
    let Transition = Prefixed_Name(lifecycle, "Transition") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This uses a boolean to represent if an action has been completed. This is a simple alternative to the taskProgress property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"completed"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#completed">http://purl.org/vocab/lifecycle/schema#completed</seealso>
    let completed = Prefixed_Name(lifecycle, "completed") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:mandatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Sepcifies if a task is mandatory or optional."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mandatory"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#mandatory">http://purl.org/vocab/lifecycle/schema#mandatory</seealso>
    let mandatory = Prefixed_Name(lifecycle, "mandatory") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"provides a simple ordering relationship to allow tasks to be ordered in user interfaces."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"next"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#next">http://purl.org/vocab/lifecycle/schema#next</seealso>
    let next = Prefixed_Name(lifecycle, "next") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:possibleState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The possible state property is used to identify the states that occur within a given lifecycle and are thus the possible states of a resource going through that lifecycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possible state"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#possibleState">http://purl.org/vocab/lifecycle/schema#possibleState</seealso>
    let possibleState = Prefixed_Name(lifecycle, "possibleState") |> PrefixedName

    /// <summary>
    ///   <para>lifecycle:possibleTransition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"When in a state there may be many possible transitions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"possible transition"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#possibleTransition">http://purl.org/vocab/lifecycle/schema#possibleTransition</seealso>
    let possibleTransition =
        Prefixed_Name(lifecycle, "possibleTransition") |> PrefixedName

    /// <summary>
    ///   <para>lifecycle:resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The resource on which the action being taken. This is a resource that is being processed through a lifecycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#resource">http://purl.org/vocab/lifecycle/schema#resource</seealso>
    let resource = Prefixed_Name(lifecycle, "resource") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:resultingState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Once a transition is completed the state of the resource should change to the state specified as the resulting state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resulting state"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#resultingState">http://purl.org/vocab/lifecycle/schema#resultingState</seealso>
    let resultingState = Prefixed_Name(lifecycle, "resultingState") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The state property relates any resource with the state that it is currently in."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"state"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#state">http://purl.org/vocab/lifecycle/schema#state</seealso>
    let state = Prefixed_Name(lifecycle, "state") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:stateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The 'state of' property is the inverse of the state property, relating a state to all of the resources currently in that state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"state of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#stateOf">http://purl.org/vocab/lifecycle/schema#stateOf</seealso>
    let stateOf = Prefixed_Name(lifecycle, "stateOf") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:task</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"A task related to this transition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"task"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#task">http://purl.org/vocab/lifecycle/schema#task</seealso>
    let task = Prefixed_Name(lifecycle, "task") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:taskGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A task group related to this transition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"task group"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#taskGroup">http://purl.org/vocab/lifecycle/schema#taskGroup</seealso>
    let taskGroup = Prefixed_Name(lifecycle, "taskGroup") |> PrefixedName
    /// <summary>
    ///   <para>lifecycle:taskProgress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The current progress on this task. Some resources are defined in this ontology for this, but you are free to define your own."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"task progress"</para></remarks>
    /// <seealso href="http://purl.org/vocab/lifecycle/schema#taskProgress">http://purl.org/vocab/lifecycle/schema#taskProgress</seealso>
    let taskProgress = Prefixed_Name(lifecycle, "taskProgress") |> PrefixedName
