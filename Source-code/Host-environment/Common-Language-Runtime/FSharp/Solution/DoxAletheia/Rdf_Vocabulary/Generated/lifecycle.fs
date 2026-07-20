namespace http.purl.org.vocab.lifecycle.schema.hash

open DoxAletheia

module lifecycle =
    let _namespace_name = "http://purl.org/vocab/lifecycle/schema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Plays the role of StateSet proposed in http://ontologydesignpatterns.org/wiki/Submissions:Object_with_states
    /// <see href="http://purl.org/vocab/lifecycle/schema#Lifecycle"></see></summary>
    let Lifecycle = _prefix "Lifecycle"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#Task"></see>
    /// </summary>
    let Task = _prefix "Task"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#TaskGroup"></see>
    /// </summary>
    let TaskGroup = _prefix "TaskGroup"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#TaskProgress"></see>
    /// </summary>
    let TaskProgress = _prefix "TaskProgress"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#Transition"></see>
    /// </summary>
    let Transition = _prefix "Transition"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#possibleTransition"></see>
    /// </summary>
    let possibleTransition = _prefix "possibleTransition"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#possibleState"></see>
    /// </summary>
    let possibleState = _prefix "possibleState"
