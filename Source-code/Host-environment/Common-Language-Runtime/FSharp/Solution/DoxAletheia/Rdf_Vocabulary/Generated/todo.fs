namespace https.w3id.org.todo.hash

open DoxAletheia

module todo =
    let _namespace_name = "https://w3id.org/todo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Establishes the relationship between an Action and its Trace
    /// <see href="https://w3id.org/todo#hasActionTrace"></see></summary>
    let hasActionTrace = _prefix "hasActionTrace"
    /// <summary>
    /// Establishes the relationship between an ActionTrace and the Action it refers to.
    /// <see href="https://w3id.org/todo#isActionTraceOf"></see></summary>
    let isActionTraceOf = _prefix "isActionTraceOf"
    /// <summary>
    /// Establishes a relation between a SecondaryDialogue and the information (ActionTrace/ArgumentTrace/WorldElementTrace) that has been obtained thanks to it.
    /// <see href="https://w3id.org/todo#hasObtained"></see></summary>
    let hasObtained = _prefix "hasObtained"
    /// <summary>
    /// Establishes a relation between a Trace (ActionTrace/ArgumentTrace/WorldElementTrace) and the SecondaryDialogue performed to obtain said Trace.
    /// <see href="https://w3id.org/todo#obtainedThrough"></see></summary>
    let obtainedThrough = _prefix "obtainedThrough"
