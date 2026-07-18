namespace http.iserve.kmi._open.ac.uk.ns.hrests.hash

open DoxAletheia.Rdf_Vocabulary

module hr =
    let _namespace_name = "http://iserve.kmi.open.ac.uk/ns/hrests#"

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#AuthenticationCredential"></see>
    /// </summary>
    let AuthenticationCredential =
        Namespaced_IRI.parse _namespace_name "AuthenticationCredential" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#MediaType"></see>
    /// </summary>
    let MediaType = Namespaced_IRI.parse _namespace_name "MediaType" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#OutputFormatParameter"></see>
    /// </summary>
    let OutputFormatParameter =
        Namespaced_IRI.parse _namespace_name "OutputFormatParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#URITemplate"></see>
    /// </summary>
    let URITemplate =
        Namespaced_IRI.parse _namespace_name "URITemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#acceptsContentType"></see>
    /// </summary>
    let acceptsContentType =
        Namespaced_IRI.parse _namespace_name "acceptsContentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#automaticallyExtractedDescription"></see>
    /// </summary>
    let automaticallyExtractedDescription =
        Namespaced_IRI.parse _namespace_name "automaticallyExtractedDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#hasAddress"></see>
    /// </summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#hasComment"></see>
    /// </summary>
    let hasComment = Namespaced_IRI.parse _namespace_name "hasComment" |> NamespacedName
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#hasMethod"></see>
    /// </summary>
    let hasMethod = Namespaced_IRI.parse _namespace_name "hasMethod" |> NamespacedName
    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#Method"></see>
    /// </summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#isGroundedIn"></see>
    /// </summary>
    let isGroundedIn =
        Namespaced_IRI.parse _namespace_name "isGroundedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://iserve.kmi.open.ac.uk/ns/hrests#producesContentType"></see>
    /// </summary>
    let producesContentType =
        Namespaced_IRI.parse _namespace_name "producesContentType" |> NamespacedName
