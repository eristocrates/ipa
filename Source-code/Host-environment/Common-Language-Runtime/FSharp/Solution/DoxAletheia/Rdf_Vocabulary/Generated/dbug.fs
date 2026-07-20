namespace http.ontologi.es.doap_bugs.hash

open DoxAletheia

module dbug =
    let _namespace_name = "http://ontologi.es/doap-bugs#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#Bug"></see>
    /// </summary>
    let Bug = _prefix "Bug"
    /// <summary>
    /// Provide a quick summary as an rdfs:label and a more extensive summary (if necessary) as an rdfs:comment.
    /// <see href="http://ontologi.es/doap-bugs#Issue"></see></summary>
    let Issue = _prefix "Issue"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#Enhancement"></see>
    /// </summary>
    let Enhancement = _prefix "Enhancement"
    /// <summary>
    /// Please use these unless you have an important requirement to use your own severity level scheme. If you do design your own scheme, use skos:closeMatch, skos:exactMatch and so on to link to the definitions here.
    /// <see href="http://ontologi.es/doap-bugs#SEVERITY_LEVELS"></see></summary>
    let SEVERITY_LEVELS = _prefix "SEVERITY_LEVELS"
    /// <summary>
    /// Please use these unless you have an important requirement to use your own status scheme. If you do design your own scheme, use skos:closeMatch, skos:exactMatch and so on to link to the definitions here.
    /// <see href="http://ontologi.es/doap-bugs#STATUS_TYPES"></see></summary>
    let STATUS_TYPES = _prefix "STATUS_TYPES"
    /// <summary>
    /// An issue that in some way compromises the security of affected versions of its project.
    /// <see href="http://ontologi.es/doap-bugs#SecurityIssue"></see></summary>
    let SecurityIssue = _prefix "SecurityIssue"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#SeverityLevel"></see>
    /// </summary>
    let SeverityLevel = _prefix "SeverityLevel"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#StatusType"></see>
    /// </summary>
    let StatusType = _prefix "StatusType"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#affects"></see>
    /// </summary>
    let affects = _prefix "affects"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#assignee"></see>
    /// </summary>
    let assignee = _prefix "assignee"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#blocks"></see>
    /// </summary>
    let blocks = _prefix "blocks"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#classification"></see>
    /// </summary>
    let classification = _prefix "classification"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#comment"></see>
    /// </summary>
    let comment = _prefix "comment"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#confirmed"></see>
    /// </summary>
    let confirmed = _prefix "confirmed"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#critical"></see>
    /// </summary>
    let critical = _prefix "critical"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#fixed"></see>
    /// </summary>
    let fixed_ = _prefix "fixed"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#fixed-in"></see>
    /// </summary>
    let ``fixed-in`` = _prefix "fixed-in"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#in-progress"></see>
    /// </summary>
    let ``in-progress`` = _prefix "in-progress"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#invalid"></see>
    /// </summary>
    let invalid = _prefix "invalid"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#issue"></see>
    /// </summary>
    let issue = _prefix "issue"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#major"></see>
    /// </summary>
    let major = _prefix "major"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#minor"></see>
    /// </summary>
    let minor = _prefix "minor"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#new"></see>
    /// </summary>
    let new_ = _prefix "new"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#page"></see>
    /// </summary>
    let page = _prefix "page"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#reporter"></see>
    /// </summary>
    let reporter = _prefix "reporter"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#severity"></see>
    /// </summary>
    let severity = _prefix "severity"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#third-party"></see>
    /// </summary>
    let ``third-party`` = _prefix "third-party"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#trivial"></see>
    /// </summary>
    let trivial = _prefix "trivial"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#wont-fix"></see>
    /// </summary>
    let ``wont-fix`` = _prefix "wont-fix"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-bugs#works-for-me"></see>
    /// </summary>
    let ``works-for-me`` = _prefix "works-for-me"
