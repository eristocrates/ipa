namespace http.ontologi.es.doap_bugs.hash

open DoxAletheia.Rdf_Vocabulary

module dbug =
    let _namespace_name = "http://ontologi.es/doap-bugs#"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#Bug"></see>
    /// </summary>
    let Bug = Namespaced_IRI.parse _namespace_name "Bug" |> NamespacedName
    /// <summary>
    /// Provide a quick summary as an rdfs:label and a more extensive summary (if necessary) as an rdfs:comment.
    /// <see href="http://ontologi.es/doap-bugs#Issue"></see></summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#Enhancement"></see>
    /// </summary>
    let Enhancement =
        Namespaced_IRI.parse _namespace_name "Enhancement" |> NamespacedName

    /// <summary>
    /// Please use these unless you have an important requirement to use your own severity level scheme. If you do design your own scheme, use skos:closeMatch, skos:exactMatch and so on to link to the definitions here.
    /// <see href="http://ontologi.es/doap-bugs#SEVERITY_LEVELS"></see></summary>
    let SEVERITY_LEVELS =
        Namespaced_IRI.parse _namespace_name "SEVERITY_LEVELS" |> NamespacedName

    /// <summary>
    /// Please use these unless you have an important requirement to use your own status scheme. If you do design your own scheme, use skos:closeMatch, skos:exactMatch and so on to link to the definitions here.
    /// <see href="http://ontologi.es/doap-bugs#STATUS_TYPES"></see></summary>
    let STATUS_TYPES =
        Namespaced_IRI.parse _namespace_name "STATUS_TYPES" |> NamespacedName

    /// <summary>
    /// An issue that in some way compromises the security of affected versions of its project.
    /// <see href="http://ontologi.es/doap-bugs#SecurityIssue"></see></summary>
    let SecurityIssue =
        Namespaced_IRI.parse _namespace_name "SecurityIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#SeverityLevel"></see>
    /// </summary>
    let SeverityLevel =
        Namespaced_IRI.parse _namespace_name "SeverityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#StatusType"></see>
    /// </summary>
    let StatusType = Namespaced_IRI.parse _namespace_name "StatusType" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#affects"></see>
    /// </summary>
    let affects = Namespaced_IRI.parse _namespace_name "affects" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#assignee"></see>
    /// </summary>
    let assignee = Namespaced_IRI.parse _namespace_name "assignee" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#blocks"></see>
    /// </summary>
    let blocks = Namespaced_IRI.parse _namespace_name "blocks" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#classification"></see>
    /// </summary>
    let classification =
        Namespaced_IRI.parse _namespace_name "classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#comment"></see>
    /// </summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#confirmed"></see>
    /// </summary>
    let confirmed = Namespaced_IRI.parse _namespace_name "confirmed" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#critical"></see>
    /// </summary>
    let critical = Namespaced_IRI.parse _namespace_name "critical" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#fixed"></see>
    /// </summary>
    let fixed_ = Namespaced_IRI.parse _namespace_name "fixed" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#fixed-in"></see>
    /// </summary>
    let ``fixed-in`` = Namespaced_IRI.parse _namespace_name "fixed-in" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#in-progress"></see>
    /// </summary>
    let ``in-progress`` =
        Namespaced_IRI.parse _namespace_name "in-progress" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#invalid"></see>
    /// </summary>
    let invalid = Namespaced_IRI.parse _namespace_name "invalid" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#issue"></see>
    /// </summary>
    let issue = Namespaced_IRI.parse _namespace_name "issue" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#major"></see>
    /// </summary>
    let major = Namespaced_IRI.parse _namespace_name "major" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#minor"></see>
    /// </summary>
    let minor = Namespaced_IRI.parse _namespace_name "minor" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#new"></see>
    /// </summary>
    let new_ = Namespaced_IRI.parse _namespace_name "new" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#page"></see>
    /// </summary>
    let page = Namespaced_IRI.parse _namespace_name "page" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#reporter"></see>
    /// </summary>
    let reporter = Namespaced_IRI.parse _namespace_name "reporter" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#severity"></see>
    /// </summary>
    let severity = Namespaced_IRI.parse _namespace_name "severity" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#third-party"></see>
    /// </summary>
    let ``third-party`` =
        Namespaced_IRI.parse _namespace_name "third-party" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#trivial"></see>
    /// </summary>
    let trivial = Namespaced_IRI.parse _namespace_name "trivial" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#wont-fix"></see>
    /// </summary>
    let ``wont-fix`` = Namespaced_IRI.parse _namespace_name "wont-fix" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#works-for-me"></see>
    /// </summary>
    let ``works-for-me`` =
        Namespaced_IRI.parse _namespace_name "works-for-me" |> NamespacedName
