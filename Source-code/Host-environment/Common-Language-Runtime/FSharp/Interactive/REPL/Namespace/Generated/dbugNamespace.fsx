#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dbug =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ontologi.es/doap-bugs#" "dbug"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Bug</para>
    ///   <a href="http://ontologi.es/doap-bugs#Bug">dbug:Bug</a>
    /// </summary>
    let Bug = _prefixId.prefix "Bug"
    /// <summary>
    ///   <para>rdfs:label : Enhancement</para>
    ///   <a href="http://ontologi.es/doap-bugs#Enhancement">dbug:Enhancement</a>
    /// </summary>
    let Enhancement = _prefixId.prefix "Enhancement"
    /// <summary>
    ///   <para>rdfs:comment : Provide a quick summary as an rdfs:label and a more extensive summary (if necessary) as an rdfs:comment.</para>
    ///   <para>rdfs:label : Issue</para>
    ///   <a href="http://ontologi.es/doap-bugs#Issue">dbug:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    let SEVERITY_LEVELS = _prefixId.prefix "SEVERITY_LEVELS"
    let STATUS_TYPES = _prefixId.prefix "STATUS_TYPES"
    /// <summary>
    ///   <para>rdfs:comment : An issue that in some way compromises the security of affected versions of its project.</para>
    ///   <para>rdfs:label : Security Issue</para>
    ///   <a href="http://ontologi.es/doap-bugs#SecurityIssue">dbug:SecurityIssue</a>
    /// </summary>
    let SecurityIssue = _prefixId.prefix "SecurityIssue"
    /// <summary>
    ///   <para>rdfs:label : Severity Level</para>
    ///   <a href="http://ontologi.es/doap-bugs#SeverityLevel">dbug:SeverityLevel</a>
    /// </summary>
    let SeverityLevel = _prefixId.prefix "SeverityLevel"
    /// <summary>
    ///   <para>rdfs:label : Status Type</para>
    ///   <a href="http://ontologi.es/doap-bugs#StatusType">dbug:StatusType</a>
    /// </summary>
    let StatusType = _prefixId.prefix "StatusType"
    /// <summary>
    ///   <para>rdfs:label : affects</para>
    ///   <a href="http://ontologi.es/doap-bugs#affects">dbug:affects</a>
    /// </summary>
    let affects = _prefixId.prefix "affects"
    /// <summary>
    ///   <para>rdfs:label : assignee</para>
    ///   <a href="http://ontologi.es/doap-bugs#assignee">dbug:assignee</a>
    /// </summary>
    let assignee = _prefixId.prefix "assignee"
    /// <summary>
    ///   <para>rdfs:label : blocks</para>
    ///   <a href="http://ontologi.es/doap-bugs#blocks">dbug:blocks</a>
    /// </summary>
    let blocks = _prefixId.prefix "blocks"
    /// <summary>
    ///   <para>rdfs:label : classification</para>
    ///   <a href="http://ontologi.es/doap-bugs#classification">dbug:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>rdfs:label : comment</para>
    ///   <a href="http://ontologi.es/doap-bugs#comment">dbug:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    let confirmed = _prefixId.prefix "confirmed"
    let critical = _prefixId.prefix "critical"
    let fixed_ = _prefixId.prefix "fixed"
    /// <summary>
    ///   <para>rdfs:label : fixed in</para>
    ///   <a href="http://ontologi.es/doap-bugs#fixed-in">dbug:fixed-in</a>
    /// </summary>
    let fixed_in = _prefixId.prefix "fixed-in"
    /// <summary>
    ///   <para>rdfs:label : identifier</para>
    ///   <a href="http://ontologi.es/doap-bugs#id">dbug:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    let in_progress = _prefixId.prefix "in-progress"
    let invalid = _prefixId.prefix "invalid"
    /// <summary>
    ///   <para>rdfs:label : issue</para>
    ///   <a href="http://ontologi.es/doap-bugs#issue">dbug:issue</a>
    /// </summary>
    let issue = _prefixId.prefix "issue"
    let major = _prefixId.prefix "major"
    let minor = _prefixId.prefix "minor"
    let new_ = _prefixId.prefix "new"
    /// <summary>
    ///   <para>rdfs:label : page</para>
    ///   <a href="http://ontologi.es/doap-bugs#page">dbug:page</a>
    /// </summary>
    let page = _prefixId.prefix "page"
    /// <summary>
    ///   <para>rdfs:label : reporter</para>
    ///   <a href="http://ontologi.es/doap-bugs#reporter">dbug:reporter</a>
    /// </summary>
    let reporter = _prefixId.prefix "reporter"
    /// <summary>
    ///   <para>rdfs:label : severity</para>
    ///   <a href="http://ontologi.es/doap-bugs#severity">dbug:severity</a>
    /// </summary>
    let severity = _prefixId.prefix "severity"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <a href="http://ontologi.es/doap-bugs#status">dbug:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    let third_party = _prefixId.prefix "third-party"
    let trivial = _prefixId.prefix "trivial"
    let wont_fix = _prefixId.prefix "wont-fix"
    let works_for_me = _prefixId.prefix "works-for-me"
