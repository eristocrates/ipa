namespace http.purl.org.dcx.lrmi_vocabs.educationalUse.slash

open DoxAletheia.Rdf_Vocabulary

module lrmi_educationalUse =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/educationalUse/"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalUse/assessment"></see>
    /// </summary>
    let assessment = Namespaced_IRI.parse _namespace_name "assessment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalUse/instruction"></see>
    /// </summary>
    let instruction =
        Namespaced_IRI.parse _namespace_name "instruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalUse/professionalSupport"></see>
    /// </summary>
    let professionalSupport =
        Namespaced_IRI.parse _namespace_name "professionalSupport" |> NamespacedName
