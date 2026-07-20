namespace http.purl.org.net.wf_invocation.hash

open DoxAletheia

module wf_invoc =
    let _namespace_name = "http://purl.org/net/wf-invocation#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Specialization of p-plan:Step in order to be able to assert domain specific properties. A wf-invoc:Step refers to those p-plan:Steps related to the scientific workflow invocation.
    /// <see href="http://purl.org/net/wf-invocation#Step"></see></summary>
    let Step = _prefix "Step"
    /// <summary>
    /// Specialization of p-plan:Variable in order to be able to assert specific properties. A wf-invoc:Variable refers to those p-plan:Variables related to the scientific workflow invocation.
    /// <see href="http://purl.org/net/wf-invocation#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    ///   <see href="http://purl.org/net/wf-invocation#hasCodeBinding"></see>
    /// </summary>
    let hasCodeBinding = _prefix "hasCodeBinding"
    /// <summary>
    /// Data property used to link a wf-invoc:Step with any particular metadata that will be used in the execution of the Step (e.g., environment requirements, memory, etc.)
    /// <see href="http://purl.org/net/wf-invocation#hasCustomData"></see></summary>
    let hasCustomData = _prefix "hasCustomData"
    /// <summary>
    /// Data property used to bind a wf-invoc:Variable with the path or URL where the data is available for the execution.
    /// <see href="http://purl.org/net/wf-invocation#hasDataBinding"></see></summary>
    let hasDataBinding = _prefix "hasDataBinding"
    /// <summary>
    /// Data property used to link a wf-invoc:Step with the Literal representing the invocation line of the current Step.
    /// <see href="http://purl.org/net/wf-invocation#hasInvocationLine"></see></summary>
    let hasInvocationLine = _prefix "hasInvocationLine"
