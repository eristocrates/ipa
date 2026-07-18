namespace http.purl.org.dcx.lrmi_vocabs.educationalAudienceRole.slash

open DoxAletheia.Rdf_Vocabulary

module lrmi_educationalAudienceRole =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/"

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/administrator"></see>
    /// </summary>
    let administrator =
        Namespaced_IRI.parse _namespace_name "administrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/generalPublic"></see>
    /// </summary>
    let generalPublic =
        Namespaced_IRI.parse _namespace_name "generalPublic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/mentor"></see>
    /// </summary>
    let mentor = Namespaced_IRI.parse _namespace_name "mentor" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/parent"></see>
    /// </summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/peerTutor"></see>
    /// </summary>
    let peerTutor = Namespaced_IRI.parse _namespace_name "peerTutor" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/student"></see>
    /// </summary>
    let student = Namespaced_IRI.parse _namespace_name "student" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/professional"></see>
    /// </summary>
    let professional =
        Namespaced_IRI.parse _namespace_name "professional" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/teacher"></see>
    /// </summary>
    let teacher = Namespaced_IRI.parse _namespace_name "teacher" |> NamespacedName
