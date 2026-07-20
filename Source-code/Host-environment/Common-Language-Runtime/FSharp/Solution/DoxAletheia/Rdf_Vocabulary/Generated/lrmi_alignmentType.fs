namespace http.purl.org.dcx.lrmi_vocabs.alignmentType.slash

open DoxAletheia

module lrmi_alignmentType =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/alignmentType/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/assesses"></see>
    /// </summary>
    let assesses = _prefix "assesses"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/complexityLevel"></see>
    /// </summary>
    let complexityLevel = _prefix "complexityLevel"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalLevel"></see>
    /// </summary>
    let educationalLevel = _prefix "educationalLevel"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalSubject"></see>
    /// </summary>
    let educationalSubject = _prefix "educationalSubject"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/prerequisite"></see>
    /// </summary>
    let prerequisite = _prefix "prerequisite"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/readingLevel"></see>
    /// </summary>
    let readingLevel = _prefix "readingLevel"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/teaches"></see>
    /// </summary>
    let teaches = _prefix "teaches"
