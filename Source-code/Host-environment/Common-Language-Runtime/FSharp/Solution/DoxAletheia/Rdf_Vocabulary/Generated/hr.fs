namespace http.iserve.kmi._open.ac.uk.ns.hrests.hash

open DoxAletheia

module hr =
    let _namespace_name = "http://iserve.kmi.open.ac.uk/ns/hrests#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#AuthenticationCredential"></see>
    /// </summary>
    let AuthenticationCredential = _prefix "AuthenticationCredential"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#MediaType"></see>
    /// </summary>
    let MediaType = _prefix "MediaType"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#OutputFormatParameter"></see>
    /// </summary>
    let OutputFormatParameter = _prefix "OutputFormatParameter"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#URITemplate"></see>
    /// </summary>
    let URITemplate = _prefix "URITemplate"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#acceptsContentType"></see>
    /// </summary>
    let acceptsContentType = _prefix "acceptsContentType"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#automaticallyExtractedDescription"></see>
    /// </summary>
    let automaticallyExtractedDescription = _prefix "automaticallyExtractedDescription"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#hasAddress"></see>
    /// </summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#hasComment"></see>
    /// </summary>
    let hasComment = _prefix "hasComment"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#hasMethod"></see>
    /// </summary>
    let hasMethod = _prefix "hasMethod"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#Method"></see>
    /// </summary>
    let Method = _prefix "Method"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#isGroundedIn"></see>
    /// </summary>
    let isGroundedIn = _prefix "isGroundedIn"
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#producesContentType"></see>
    /// </summary>
    let producesContentType = _prefix "producesContentType"
