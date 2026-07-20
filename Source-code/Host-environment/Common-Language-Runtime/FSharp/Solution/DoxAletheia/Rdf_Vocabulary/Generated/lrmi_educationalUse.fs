namespace http.purl.org.dcx.lrmi_vocabs.educationalUse.slash

open DoxAletheia

module lrmi_educationalUse =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/educationalUse/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalUse/assessment"></see>
    /// </summary>
    let assessment = _prefix "assessment"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalUse/instruction"></see>
    /// </summary>
    let instruction = _prefix "instruction"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalUse/professionalSupport"></see>
    /// </summary>
    let professionalSupport = _prefix "professionalSupport"
