namespace https.w3id.org.todo.tododial.hash

open DoxAletheia

module tddial =
    let _namespace_name = "https://w3id.org/todo/tododial#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Establishes the DialogueProcessStep corresponding to a DialogueTrace.
    /// <see href="https://w3id.org/todo/tododial#hasDialogueProcessStep"></see></summary>
    let hasDialogueProcessStep = _prefix "hasDialogueProcessStep"
    /// <summary>
    /// Establishes the relationship between an element and its Trace.
    /// <see href="https://w3id.org/todo/tododial#hasTrace"></see></summary>
    let hasTrace = _prefix "hasTrace"
    /// <summary>
    /// Establishes the relationship between a Trace and the element it refers to.
    /// <see href="https://w3id.org/todo/tododial#isTraceOf"></see></summary>
    let isTraceOf = _prefix "isTraceOf"
