#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lcy =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/vocab/lifecycle/schema#" "lcy"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : Action</para>
    ///   <para>rdfs:comment : Represents an instance of a task taking place against a given resource</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#Action">lcy:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    let Completed = _prefixId.prefix "Completed"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : Lifecycle</para>
    ///   <para>rdfs:comment : A lifecycle is a series of states connected by allowable transitions. It may be used to describe the lifecycle of business objects or equally the lifecycle of a butterfly.</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#Lifecycle">lcy:Lifecycle</a>
    /// </summary>
    let Lifecycle = _prefixId.prefix "Lifecycle"
    let OnHold = _prefixId.prefix "OnHold"
    let Started = _prefixId.prefix "Started"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : A state describes one possible state that a resource can be in at a given time. Resources may be in one state in a given lifecycle at any given time, states are considered mutually exclusive within a lifecycle.</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#State">lcy:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : Task</para>
    ///   <para>rdfs:comment : Represents a task in a workflow</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#Task">lcy:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : Task Group</para>
    ///   <para>rdfs:comment : Represents a collection of tasks grouped together for convenience</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#TaskGroup">lcy:TaskGroup</a>
    /// </summary>
    let TaskGroup = _prefixId.prefix "TaskGroup"
    let TaskProgress = _prefixId.prefix "TaskProgress"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : Transition</para>
    ///   <para>rdfs:comment : A transition describes the way in which a resource moves from one state to another state and may also describe the tasks required to make that transition.</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#Transition">lcy:Transition</a>
    /// </summary>
    let Transition = _prefixId.prefix "Transition"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : completed</para>
    ///   <para>rdfs:comment : This uses a boolean to represent if an action has been completed. This is a simple alternative to the taskProgress property.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#completed">lcy:completed</a>
    /// </summary>
    let completed = _prefixId.prefix "completed"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : mandatory</para>
    ///   <para>rdfs:comment : Sepcifies if a task is mandatory or optional.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#mandatory">lcy:mandatory</a>
    /// </summary>
    let mandatory = _prefixId.prefix "mandatory"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : next</para>
    ///   <para>rdfs:comment : provides a simple ordering relationship to allow tasks to be ordered in user interfaces.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#next">lcy:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : possible state</para>
    ///   <para>rdfs:comment : The possible state property is used to identify the states that occur within a given lifecycle and are thus the possible states of a resource going through that lifecycle.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#possibleState">lcy:possibleState</a>
    /// </summary>
    let possibleState = _prefixId.prefix "possibleState"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : possible transition</para>
    ///   <para>rdfs:comment : When in a state there may be many possible transitions.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#possibleTransition">lcy:possibleTransition</a>
    /// </summary>
    let possibleTransition = _prefixId.prefix "possibleTransition"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : resource</para>
    ///   <para>rdfs:comment : The resource on which the action being taken. This is a resource that is being processed through a lifecycle.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#resource">lcy:resource</a>
    /// </summary>
    let resource = _prefixId.prefix "resource"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : resulting state</para>
    ///   <para>rdfs:comment : Once a transition is completed the state of the resource should change to the state specified as the resulting state.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#resultingState">lcy:resultingState</a>
    /// </summary>
    let resultingState = _prefixId.prefix "resultingState"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : state</para>
    ///   <para>rdfs:comment : The state property relates any resource with the state that it is currently in.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#state">lcy:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : state of</para>
    ///   <para>rdfs:comment : The 'state of' property is the inverse of the state property, relating a state to all of the resources currently in that state.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#stateOf">lcy:stateOf</a>
    /// </summary>
    let stateOf = _prefixId.prefix "stateOf"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : task</para>
    ///   <para>rdfs:comment : A task related to this transition.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#task">lcy:task</a>
    /// </summary>
    let task = _prefixId.prefix "task"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : task group</para>
    ///   <para>rdfs:comment : A task group related to this transition.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#taskGroup">lcy:taskGroup</a>
    /// </summary>
    let taskGroup = _prefixId.prefix "taskGroup"
    /// <summary>
    ///   <para>dcterms:issued : 2008-06-03^^xsd:string</para>
    ///   <para>rdfs:label : task progress</para>
    ///   <para>rdfs:comment : The current progress on this task. Some resources are defined in this ontology for this, but you are free to define your own.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/lifecycle/schema#taskProgress">lcy:taskProgress</a>
    /// </summary>
    let taskProgress = _prefixId.prefix "taskProgress"
