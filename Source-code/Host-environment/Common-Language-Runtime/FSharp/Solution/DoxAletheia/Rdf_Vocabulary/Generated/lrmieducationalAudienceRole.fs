namespace http.purl.org.dcx.lrmi_vocabs.educationalAudienceRole.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lrmieducationalAudienceRole =
    let _namespace_iri = Namespace_Iri lrmieducationalAudienceRole |> NamespaceIRI

    /// <summary>
    ///   <para>lrmieducationalAudienceRole:administrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/administrator">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/administrator</seealso>
    let administrator =
        Prefixed_Name(lrmieducationalAudienceRole, "administrator") |> PrefixedName

    /// <summary>
    ///   <para>lrmieducationalAudienceRole:mentor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/mentor">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/mentor</seealso>
    let mentor = Prefixed_Name(lrmieducationalAudienceRole, "mentor") |> PrefixedName

    /// <summary>
    ///   <para>lrmieducationalAudienceRole:generalPublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/generalPublic">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/generalPublic</seealso>
    let generalPublic =
        Prefixed_Name(lrmieducationalAudienceRole, "generalPublic") |> PrefixedName

    /// <summary>
    ///   <para>lrmieducationalAudienceRole:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/parent">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/parent</seealso>
    let parent = Prefixed_Name(lrmieducationalAudienceRole, "parent") |> PrefixedName
    /// <summary>
    ///   <para>lrmieducationalAudienceRole:student</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/student">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/student</seealso>
    let student = Prefixed_Name(lrmieducationalAudienceRole, "student") |> PrefixedName

    /// <summary>
    ///   <para>lrmieducationalAudienceRole:professional</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/professional">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/professional</seealso>
    let professional =
        Prefixed_Name(lrmieducationalAudienceRole, "professional") |> PrefixedName

    /// <summary>
    ///   <para>lrmieducationalAudienceRole:teacher</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/teacher">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/teacher</seealso>
    let teacher = Prefixed_Name(lrmieducationalAudienceRole, "teacher") |> PrefixedName
    /// <summary>
    ///   <para>lrmieducationalAudienceRole:</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/</seealso>
    let _prefix_iri = Prefixed_Name(lrmieducationalAudienceRole, "") |> PrefixedName

    /// <summary>
    ///   <para>lrmieducationalAudienceRole:peerTutor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/peerTutor">http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/peerTutor</seealso>
    let peerTutor =
        Prefixed_Name(lrmieducationalAudienceRole, "peerTutor") |> PrefixedName
