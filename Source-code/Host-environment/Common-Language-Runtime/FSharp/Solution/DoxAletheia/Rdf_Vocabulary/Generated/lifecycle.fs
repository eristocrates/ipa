namespace http.purl.org.vocab.lifecycle.schema.hash

open DoxAletheia.Rdf_Vocabulary

module lifecycle =
    let _namespace_name = "http://purl.org/vocab/lifecycle/schema#"
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// Plays the role of StateSet proposed in http://ontologydesignpatterns.org/wiki/Submissions:Object_with_states
    /// <see href="http://purl.org/vocab/lifecycle/schema#Lifecycle"></see></summary>
    let Lifecycle = Namespaced_IRI.parse _namespace_name "Lifecycle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#Task"></see>
    /// </summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#TaskGroup"></see>
    /// </summary>
    let TaskGroup = Namespaced_IRI.parse _namespace_name "TaskGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#TaskProgress"></see>
    /// </summary>
    let TaskProgress =
        Namespaced_IRI.parse _namespace_name "TaskProgress" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#Transition"></see>
    /// </summary>
    let Transition = Namespaced_IRI.parse _namespace_name "Transition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#possibleTransition"></see>
    /// </summary>
    let possibleTransition =
        Namespaced_IRI.parse _namespace_name "possibleTransition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/lifecycle/schema#possibleState"></see>
    /// </summary>
    let possibleState =
        Namespaced_IRI.parse _namespace_name "possibleState" |> NamespacedName
