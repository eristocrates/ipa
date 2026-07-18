namespace https.w3id.org.todo.tododial.hash

open DoxAletheia.Rdf_Vocabulary

module tddial =
    let _namespace_name = "https://w3id.org/todo/tododial#"

    /// <summary>
    /// Establishes the DialogueProcessStep corresponding to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododial#hasDialogueProcessStep"></see></summary>
    let hasDialogueProcessStep =
        Namespaced_IRI.parse _namespace_name "hasDialogueProcessStep" |> NamespacedName

    /// <summary>
    /// Establishes the relationship between an element and its Trace.
    /// <see href="https://w3id.org/todo/tododial#hasTrace"></see></summary>
    let hasTrace = Namespaced_IRI.parse _namespace_name "hasTrace" |> NamespacedName
    /// <summary>
    /// Establishes the relationship between a Trace and the element it refers to.
    /// <see href="https://w3id.org/todo/tododial#isTraceOf"></see></summary>
    let isTraceOf = Namespaced_IRI.parse _namespace_name "isTraceOf" |> NamespacedName
