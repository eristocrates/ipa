namespace http.purl.org.dcx.lrmi_vocabs.alignmentType.slash

open DoxAletheia.Rdf_Vocabulary

module lrmi_alignmentType =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/alignmentType/"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/assesses"></see>
    /// </summary>
    let assesses = Namespaced_IRI.parse _namespace_name "assesses" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/complexityLevel"></see>
    /// </summary>
    let complexityLevel =
        Namespaced_IRI.parse _namespace_name "complexityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalLevel"></see>
    /// </summary>
    let educationalLevel =
        Namespaced_IRI.parse _namespace_name "educationalLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalSubject"></see>
    /// </summary>
    let educationalSubject =
        Namespaced_IRI.parse _namespace_name "educationalSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/prerequisite"></see>
    /// </summary>
    let prerequisite =
        Namespaced_IRI.parse _namespace_name "prerequisite" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/readingLevel"></see>
    /// </summary>
    let readingLevel =
        Namespaced_IRI.parse _namespace_name "readingLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/alignmentType/teaches"></see>
    /// </summary>
    let teaches = Namespaced_IRI.parse _namespace_name "teaches" |> NamespacedName
