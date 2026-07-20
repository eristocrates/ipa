namespace http.iserve.kmi._open.ac.uk.ns.msm.hash

open DoxAletheia

module msm =
    let _namespace_name = "http://iserve.kmi.open.ac.uk/ns/msm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#MessageContent"></see>
    /// </summary>
    let MessageContent = _prefix "MessageContent"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#MessagePart"></see>
    /// </summary>
    let MessagePart = _prefix "MessagePart"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#Operation"></see>
    /// </summary>
    let Operation = _prefix "Operation"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasFault"></see>
    /// </summary>
    let hasFault = _prefix "hasFault"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasInput"></see>
    /// </summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasInputFault"></see>
    /// </summary>
    let hasInputFault = _prefix "hasInputFault"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasMandatoryPart"></see>
    /// </summary>
    let hasMandatoryPart = _prefix "hasMandatoryPart"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOperation"></see>
    /// </summary>
    let hasOperation = _prefix "hasOperation"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOptionalPart"></see>
    /// </summary>
    let hasOptionalPart = _prefix "hasOptionalPart"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOutput"></see>
    /// </summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasOutputFault"></see>
    /// </summary>
    let hasOutputFault = _prefix "hasOutputFault"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#hasPartTransitive"></see>
    /// </summary>
    let hasPartTransitive = _prefix "hasPartTransitive"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/msm#isGroundedIn"></see>
    /// </summary>
    let isGroundedIn = _prefix "isGroundedIn"
