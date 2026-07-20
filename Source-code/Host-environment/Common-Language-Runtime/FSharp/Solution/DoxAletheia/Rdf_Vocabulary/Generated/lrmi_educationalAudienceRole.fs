namespace http.purl.org.dcx.lrmi_vocabs.educationalAudienceRole.slash

open DoxAletheia

module lrmi_educationalAudienceRole =
    let _namespace_name = "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/administrator"></see>
    /// </summary>
    let administrator = _prefix "administrator"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/generalPublic"></see>
    /// </summary>
    let generalPublic = _prefix "generalPublic"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/mentor"></see>
    /// </summary>
    let mentor = _prefix "mentor"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/parent"></see>
    /// </summary>
    let parent = _prefix "parent"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/peerTutor"></see>
    /// </summary>
    let peerTutor = _prefix "peerTutor"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/student"></see>
    /// </summary>
    let student = _prefix "student"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/professional"></see>
    /// </summary>
    let professional = _prefix "professional"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/teacher"></see>
    /// </summary>
    let teacher = _prefix "teacher"
