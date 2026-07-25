namespace http.ontologi.es.doap_bugs.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module doabug =
    let _namespace_iri = Namespace_Iri doabug |> NamespaceIRI
    /// <summary>
    ///   <para>doabug:Bug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bug</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#Bug">http://ontologi.es/doap-bugs#Bug</seealso>
    let Bug = Prefixed_Name(doabug, "Bug") |> PrefixedName
    /// <summary>
    ///   <para>doabug:SEVERITY_LEVELS</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Please use these unless you have an important requirement to use your own severity level scheme. If you do design your own scheme, use skos:closeMatch, skos:exactMatch and so on to link to the definitions here.</para>
    /// labels<para>Built-in Severity Levels</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#SEVERITY_LEVELS">http://ontologi.es/doap-bugs#SEVERITY_LEVELS</seealso>
    let SEVERITY_LEVELS = Prefixed_Name(doabug, "SEVERITY_LEVELS") |> PrefixedName
    /// <summary>
    ///   <para>doabug:SeverityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Severity Level</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#SeverityLevel">http://ontologi.es/doap-bugs#SeverityLevel</seealso>
    let SeverityLevel = Prefixed_Name(doabug, "SeverityLevel") |> PrefixedName
    /// <summary>
    ///   <para>doabug:assignee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>assignee</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#assignee">http://ontologi.es/doap-bugs#assignee</seealso>
    let assignee = Prefixed_Name(doabug, "assignee") |> PrefixedName
    /// <summary>
    ///   <para>doabug:major</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:SeverityLevel</para>
    ///
    /// labels<para>major</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#major">http://ontologi.es/doap-bugs#major</seealso>
    let major = Prefixed_Name(doabug, "major") |> PrefixedName
    /// <summary>
    ///   <para>doabug:minor</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:SeverityLevel</para>
    ///
    /// labels<para>minor</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#minor">http://ontologi.es/doap-bugs#minor</seealso>
    let minor = Prefixed_Name(doabug, "minor") |> PrefixedName
    /// <summary>
    ///   <para>doabug:Enhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Enhancement</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#Enhancement">http://ontologi.es/doap-bugs#Enhancement</seealso>
    let Enhancement = Prefixed_Name(doabug, "Enhancement") |> PrefixedName
    /// <summary>
    ///   <para>doabug:SecurityIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An issue that in some way compromises the security of affected versions of its project.</para>
    /// labels<para>Security Issue</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#SecurityIssue">http://ontologi.es/doap-bugs#SecurityIssue</seealso>
    let SecurityIssue = Prefixed_Name(doabug, "SecurityIssue") |> PrefixedName
    /// <summary>
    ///   <para>doabug:affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>affects</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#affects">http://ontologi.es/doap-bugs#affects</seealso>
    let affects = Prefixed_Name(doabug, "affects") |> PrefixedName
    /// <summary>
    ///   <para>doabug:confirmed</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>confirmed</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#confirmed">http://ontologi.es/doap-bugs#confirmed</seealso>
    let confirmed = Prefixed_Name(doabug, "confirmed") |> PrefixedName
    /// <summary>
    ///   <para>doabug:StatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Status Type</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#StatusType">http://ontologi.es/doap-bugs#StatusType</seealso>
    let StatusType = Prefixed_Name(doabug, "StatusType") |> PrefixedName
    /// <summary>
    ///   <para>doabug:blocks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>blocks</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#blocks">http://ontologi.es/doap-bugs#blocks</seealso>
    let blocks = Prefixed_Name(doabug, "blocks") |> PrefixedName
    /// <summary>
    ///   <para>doabug:critical</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:SeverityLevel</para>
    ///
    /// labels<para>critical</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#critical">http://ontologi.es/doap-bugs#critical</seealso>
    let critical = Prefixed_Name(doabug, "critical") |> PrefixedName
    /// <summary>
    ///   <para>doabug:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#id">http://ontologi.es/doap-bugs#id</seealso>
    let id = Prefixed_Name(doabug, "id") |> PrefixedName
    /// <summary>
    ///   <para>doabug:issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>issue</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#issue">http://ontologi.es/doap-bugs#issue</seealso>
    let issue = Prefixed_Name(doabug, "issue") |> PrefixedName
    /// <summary>
    ///   <para>doabug:new</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>new</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#new">http://ontologi.es/doap-bugs#new</seealso>
    let new_ = Prefixed_Name(doabug, "new") |> PrefixedName
    /// <summary>
    ///   <para>doabug:reporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reporter</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#reporter">http://ontologi.es/doap-bugs#reporter</seealso>
    let reporter = Prefixed_Name(doabug, "reporter") |> PrefixedName
    /// <summary>
    ///   <para>doabug:third-party</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>third-party</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#third-party">http://ontologi.es/doap-bugs#third-party</seealso>
    let third_party = Prefixed_Name(doabug, "third-party") |> PrefixedName
    /// <summary>
    ///   <para>doabug:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#comment">http://ontologi.es/doap-bugs#comment</seealso>
    let comment = Prefixed_Name(doabug, "comment") |> PrefixedName
    /// <summary>
    ///   <para>doabug:page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>page</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#page">http://ontologi.es/doap-bugs#page</seealso>
    let page = Prefixed_Name(doabug, "page") |> PrefixedName
    /// <summary>
    ///   <para>doabug:trivial</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:SeverityLevel</para>
    ///
    /// labels<para>trivial</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#trivial">http://ontologi.es/doap-bugs#trivial</seealso>
    let trivial = Prefixed_Name(doabug, "trivial") |> PrefixedName
    /// <summary>
    ///   <para>doabug:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>EvoOnt BOM is way too overcomplicated. Let's subclass it...</para>
    /// labels<para>DOAP Bugs</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#">http://ontologi.es/doap-bugs#</seealso>
    let _prefix_iri = Prefixed_Name(doabug, "") |> PrefixedName
    /// <summary>
    ///   <para>doabug:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide a quick summary as an rdfs:label and a more extensive summary (if necessary) as an rdfs:comment.</para>
    /// labels<para>Issue</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#Issue">http://ontologi.es/doap-bugs#Issue</seealso>
    let Issue = Prefixed_Name(doabug, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>doabug:STATUS_TYPES</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Please use these unless you have an important requirement to use your own status scheme. If you do design your own scheme, use skos:closeMatch, skos:exactMatch and so on to link to the definitions here.</para>
    /// labels<para>Built-in Status Types</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#STATUS_TYPES">http://ontologi.es/doap-bugs#STATUS_TYPES</seealso>
    let STATUS_TYPES = Prefixed_Name(doabug, "STATUS_TYPES") |> PrefixedName
    /// <summary>
    ///   <para>doabug:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>classification</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#classification">http://ontologi.es/doap-bugs#classification</seealso>
    let classification = Prefixed_Name(doabug, "classification") |> PrefixedName
    /// <summary>
    ///   <para>doabug:fixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>fixed</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#fixed">http://ontologi.es/doap-bugs#fixed</seealso>
    let fixed_ = Prefixed_Name(doabug, "fixed") |> PrefixedName
    /// <summary>
    ///   <para>doabug:fixed-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>fixed in</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#fixed-in">http://ontologi.es/doap-bugs#fixed-in</seealso>
    let fixed_in = Prefixed_Name(doabug, "fixed-in") |> PrefixedName
    /// <summary>
    ///   <para>doabug:in-progress</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>in progress</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#in-progress">http://ontologi.es/doap-bugs#in-progress</seealso>
    let in_progress = Prefixed_Name(doabug, "in-progress") |> PrefixedName
    /// <summary>
    ///   <para>doabug:invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>invalid</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#invalid">http://ontologi.es/doap-bugs#invalid</seealso>
    let invalid = Prefixed_Name(doabug, "invalid") |> PrefixedName
    /// <summary>
    ///   <para>doabug:severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>severity</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#severity">http://ontologi.es/doap-bugs#severity</seealso>
    let severity = Prefixed_Name(doabug, "severity") |> PrefixedName
    /// <summary>
    ///   <para>doabug:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>status</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#status">http://ontologi.es/doap-bugs#status</seealso>
    let status = Prefixed_Name(doabug, "status") |> PrefixedName
    /// <summary>
    ///   <para>doabug:wont-fix</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>won't fix</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#wont-fix">http://ontologi.es/doap-bugs#wont-fix</seealso>
    let wont_fix = Prefixed_Name(doabug, "wont-fix") |> PrefixedName
    /// <summary>
    ///   <para>doabug:works-for-me</para>
    /// </summary>
    /// <remarks>
    ///   <para>doabug:StatusType</para>
    ///
    /// labels<para>works for me</para></remarks>
    /// <seealso href="http://ontologi.es/doap-bugs#works-for-me">http://ontologi.es/doap-bugs#works-for-me</seealso>
    let works_for_me = Prefixed_Name(doabug, "works-for-me") |> PrefixedName
