namespace http.purl.org.net.wf_invocation.hash

open DoxAletheia.Rdf_Vocabulary

module wf_invoc =
    let _namespace_name = "http://purl.org/net/wf-invocation#"
    /// <summary>
    /// Specialization of p-plan:Step in order to be able to assert domain specific properties. A wf-invoc:Step refers to those p-plan:Steps related to the scientific workflow invocation.
    /// <see href="http://purl.org/net/wf-invocation#Step"></see></summary>
    let Step = Namespaced_IRI.parse _namespace_name "Step" |> NamespacedName
    /// <summary>
    /// Specialization of p-plan:Variable in order to be able to assert specific properties. A wf-invoc:Variable refers to those p-plan:Variables related to the scientific workflow invocation.
    /// <see href="http://purl.org/net/wf-invocation#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/wf-invocation#hasCodeBinding"></see>
    /// </summary>
    let hasCodeBinding =
        Namespaced_IRI.parse _namespace_name "hasCodeBinding" |> NamespacedName

    /// <summary>
    /// Data property used to link a wf-invoc:Step with any particular metadata that will be used in the execution of the Step (e.g., environment requirements, memory, etc.)
    /// <see href="http://purl.org/net/wf-invocation#hasCustomData"></see></summary>
    let hasCustomData =
        Namespaced_IRI.parse _namespace_name "hasCustomData" |> NamespacedName

    /// <summary>
    /// Data property used to bind a wf-invoc:Variable with the path or URL where the data is available for the execution.
    /// <see href="http://purl.org/net/wf-invocation#hasDataBinding"></see></summary>
    let hasDataBinding =
        Namespaced_IRI.parse _namespace_name "hasDataBinding" |> NamespacedName

    /// <summary>
    /// Data property used to link a wf-invoc:Step with the Literal representing the invocation line of the current Step.
    /// <see href="http://purl.org/net/wf-invocation#hasInvocationLine"></see></summary>
    let hasInvocationLine =
        Namespaced_IRI.parse _namespace_name "hasInvocationLine" |> NamespacedName
