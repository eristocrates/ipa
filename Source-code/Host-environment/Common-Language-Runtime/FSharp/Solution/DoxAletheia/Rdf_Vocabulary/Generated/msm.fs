namespace http.iserve.kmi._open.ac.uk.ns.msm.hash

open DoxAletheia.Rdf_Vocabulary

module msm =
    let _namespace_name = "http://iserve.kmi.open.ac.uk/ns/msm#"

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#MessageContent"></see>
    /// </summary>
    let MessageContent =
        Namespaced_IRI.parse _namespace_name "MessageContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#MessagePart"></see>
    /// </summary>
    let MessagePart =
        Namespaced_IRI.parse _namespace_name "MessagePart" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#Operation"></see>
    /// </summary>
    let Operation = Namespaced_IRI.parse _namespace_name "Operation" |> NamespacedName
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasFault"></see>
    /// </summary>
    let hasFault = Namespaced_IRI.parse _namespace_name "hasFault" |> NamespacedName
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasInput"></see>
    /// </summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasInputFault"></see>
    /// </summary>
    let hasInputFault =
        Namespaced_IRI.parse _namespace_name "hasInputFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasMandatoryPart"></see>
    /// </summary>
    let hasMandatoryPart =
        Namespaced_IRI.parse _namespace_name "hasMandatoryPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasPart"></see>
    /// </summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOperation"></see>
    /// </summary>
    let hasOperation =
        Namespaced_IRI.parse _namespace_name "hasOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOptionalPart"></see>
    /// </summary>
    let hasOptionalPart =
        Namespaced_IRI.parse _namespace_name "hasOptionalPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOutput"></see>
    /// </summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOutputFault"></see>
    /// </summary>
    let hasOutputFault =
        Namespaced_IRI.parse _namespace_name "hasOutputFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasPartTransitive"></see>
    /// </summary>
    let hasPartTransitive =
        Namespaced_IRI.parse _namespace_name "hasPartTransitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#isGroundedIn"></see>
    /// </summary>
    let isGroundedIn =
        Namespaced_IRI.parse _namespace_name "isGroundedIn" |> NamespacedName
