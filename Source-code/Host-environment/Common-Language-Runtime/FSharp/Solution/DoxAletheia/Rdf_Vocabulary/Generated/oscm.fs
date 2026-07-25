namespace http.open_services.net.ns.cm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oscm =
    let _namespace_iri = Namespace_Iri oscm |> NamespaceIRI
    /// <summary>
    ///   <para>oscm:Approved</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:State</para>
    ///   <para>Whether or not the Change Request has been approved.</para>
    /// labels<para>approved</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Approved">http://open-services.net/ns/cm#Approved</seealso>
    let Approved = Prefixed_Name(oscm, "Approved") |> PrefixedName
    /// <summary>
    ///   <para>oscm:ChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The CM Change Request resource.</para>
    /// labels<para>ChangeRequest</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#ChangeRequest">http://open-services.net/ns/cm#ChangeRequest</seealso>
    let ChangeRequest = Prefixed_Name(oscm, "ChangeRequest") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Critical</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Severity</para>
    ///   <para>Severe problem. No workaround.</para>
    /// labels<para>Critical</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Critical">http://open-services.net/ns/cm#Critical</seealso>
    let Critical = Prefixed_Name(oscm, "Critical") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Defect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A software or product defect.</para>
    /// labels<para>Defect</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Defect">http://open-services.net/ns/cm#Defect</seealso>
    let Defect = Prefixed_Name(oscm, "Defect") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Fixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:State</para>
    ///   <para>Whether or not the Change Request has been fixed.</para>
    /// labels<para>fixed</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Fixed">http://open-services.net/ns/cm#Fixed</seealso>
    let Fixed = Prefixed_Name(oscm, "Fixed") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Defines the possible oslc_cm:priority property values.</para>
    /// labels<para>Priority</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Priority">http://open-services.net/ns/cm#Priority</seealso>
    let Priority = Prefixed_Name(oscm, "Priority") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Inprogress</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:State</para>
    ///   <para>Whether or not the Change Request in a state indicating that active work is occurring.</para>
    /// labels<para>inprogress</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Inprogress">http://open-services.net/ns/cm#Inprogress</seealso>
    let Inprogress = Prefixed_Name(oscm, "Inprogress") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Minor</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Severity</para>
    ///   <para>Minimal impact.</para>
    /// labels<para>Minor</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Minor">http://open-services.net/ns/cm#Minor</seealso>
    let Minor = Prefixed_Name(oscm, "Minor") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An executable and trackable activity.</para>
    /// labels<para>Task</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Task">http://open-services.net/ns/cm#Task</seealso>
    let Task = Prefixed_Name(oscm, "Task") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Reviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:State</para>
    ///   <para>Whether or not the Change Request has been reviewed.</para>
    /// labels<para>reviewed</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Reviewed">http://open-services.net/ns/cm#Reviewed</seealso>
    let Reviewed = Prefixed_Name(oscm, "Reviewed") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Verified</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:State</para>
    ///   <para>Whether or not the resolution or fix of the Change Request has been verified.</para>
    /// labels<para>verified</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Verified">http://open-services.net/ns/cm#Verified</seealso>
    let Verified = Prefixed_Name(oscm, "Verified") |> PrefixedName
    /// <summary>
    ///   <para>oscm:affectsPlanItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Change request affects a plan item. It is likely that
    /// the target resource will be an oslc_cm:ChangeRequest.</para>
    /// labels<para>affectsPlanItem</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#affectsPlanItem">http://open-services.net/ns/cm#affectsPlanItem</seealso>
    let affectsPlanItem = Prefixed_Name(oscm, "affectsPlanItem") |> PrefixedName
    /// <summary>
    ///   <para>oscm:affectsRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ChangeRequest affects a Requirement. It is likely
    /// that the target resource will be an oslc_rm:Requirement.</para>
    /// labels<para>affectsRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#affectsRequirement">http://open-services.net/ns/cm#affectsRequirement</seealso>
    let affectsRequirement = Prefixed_Name(oscm, "affectsRequirement") |> PrefixedName
    /// <summary>
    ///   <para>oscm:affectsTestResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Associated resource that is affected by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestResult.</para>
    /// labels<para>affectsTestResult</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#affectsTestResult">http://open-services.net/ns/cm#affectsTestResult</seealso>
    let affectsTestResult = Prefixed_Name(oscm, "affectsTestResult") |> PrefixedName

    /// <summary>
    ///   <para>oscm:blocksTestExecutionRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Associated resource that is blocked by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestExecutionRecord.</para>
    /// labels<para>blocksTestExecutionRecord</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#blocksTestExecutionRecord">http://open-services.net/ns/cm#blocksTestExecutionRecord</seealso>
    let blocksTestExecutionRecord =
        Prefixed_Name(oscm, "blocksTestExecutionRecord") |> PrefixedName

    /// <summary>
    ///   <para>oscm:closeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date at which no further activity or work is intended to be conducted.</para>
    /// labels<para>closeDate</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#closeDate">http://open-services.net/ns/cm#closeDate</seealso>
    let closeDate = Prefixed_Name(oscm, "closeDate") |> PrefixedName
    /// <summary>
    ///   <para>oscm:closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the Change Request is completely done, no further fixes or fix verification is needed.</para>
    /// labels<para>closed</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#closed">http://open-services.net/ns/cm#closed</seealso>
    let closed = Prefixed_Name(oscm, "closed") |> PrefixedName
    /// <summary>
    ///   <para>oscm:defect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>Used to report defects in testing.</para>
    /// labels<para>defect</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#defect">http://open-services.net/ns/cm#defect</seealso>
    let defect = Prefixed_Name(oscm, "defect") |> PrefixedName
    /// <summary>
    ///   <para>oscm:inProgress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the Change Request in a state indicating that active work is occurring.</para>
    /// labels<para>inProgress</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#inProgress">http://open-services.net/ns/cm#inProgress</seealso>
    let inProgress = Prefixed_Name(oscm, "inProgress") |> PrefixedName
    /// <summary>
    ///   <para>oscm:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The related parent change requests of the subject change request.</para>
    /// labels<para>parent</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#parent">http://open-services.net/ns/cm#parent</seealso>
    let parent = Prefixed_Name(oscm, "parent") |> PrefixedName
    /// <summary>
    ///   <para>oscm:planItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>Used for associating change requests into plans (project, release, sprint, etc).</para>
    /// labels<para>planItem</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#planItem">http://open-services.net/ns/cm#planItem</seealso>
    let planItem = Prefixed_Name(oscm, "planItem") |> PrefixedName

    /// <summary>
    ///   <para>oscm:relatedChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This relationship is loosely coupled, has no specific
    /// meaning, and can be used to link related change requests. It is likely
    /// that the target resource will be an oslc_cm:ChangeRequest.</para>
    /// labels<para>relatedChangeRequest</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#relatedChangeRequest">http://open-services.net/ns/cm#relatedChangeRequest</seealso>
    let relatedChangeRequest =
        Prefixed_Name(oscm, "relatedChangeRequest") |> PrefixedName

    /// <summary>
    ///   <para>oscm:relatedTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related test case resource. It is likely that the
    /// target resource will be an oslc_qm:TestCase.</para>
    /// labels<para>relatedTestCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#relatedTestCase">http://open-services.net/ns/cm#relatedTestCase</seealso>
    let relatedTestCase = Prefixed_Name(oscm, "relatedTestCase") |> PrefixedName

    /// <summary>
    ///   <para>oscm:relatedTestExecutionRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related to a test execution resource. It is likely
    /// that the target resource will be an oslc_qm:TestExecutionRecord.</para>
    /// labels<para>relatedTestExecutionRecord</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#relatedTestExecutionRecord">http://open-services.net/ns/cm#relatedTestExecutionRecord</seealso>
    let relatedTestExecutionRecord =
        Prefixed_Name(oscm, "relatedTestExecutionRecord") |> PrefixedName

    /// <summary>
    ///   <para>oscm:severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the severity or potential impact of a defect.
    /// It is likely that the target resource will be an oslc_cm:Severity.</para>
    /// labels<para>severity</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#severity">http://open-services.net/ns/cm#severity</seealso>
    let severity = Prefixed_Name(oscm, "severity") |> PrefixedName
    /// <summary>
    ///   <para>oscm:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the status of the change request.</para>
    /// labels<para>state</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#state">http://open-services.net/ns/cm#state</seealso>
    let state = Prefixed_Name(oscm, "state") |> PrefixedName
    /// <summary>
    ///   <para>oscm:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the status of the change request based
    /// on values defined by the service provider. Most often a read-only
    /// property. It is likely that the target resource will be a string corresponding to an
    /// oslc_cm:State value.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#status">http://open-services.net/ns/cm#status</seealso>
    let status = Prefixed_Name(oscm, "status") |> PrefixedName
    /// <summary>
    ///   <para>oscm:tracksChangeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tracks a change set resource. It is likely that the
    /// target resource will be an oslc_config:ChangeSet.</para>
    /// labels<para>tracksChangeSet</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#tracksChangeSet">http://open-services.net/ns/cm#tracksChangeSet</seealso>
    let tracksChangeSet = Prefixed_Name(oscm, "tracksChangeSet") |> PrefixedName
    /// <summary>
    ///   <para>oscm:tracksRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tracks the associated Requirement or Requirement
    /// ChangeSet resources. It is likely that the target resource will be an
    /// oslc_rm:Requirement.</para>
    /// labels<para>tracksRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#tracksRequirement">http://open-services.net/ns/cm#tracksRequirement</seealso>
    let tracksRequirement = Prefixed_Name(oscm, "tracksRequirement") |> PrefixedName
    /// <summary>
    ///   <para>oscm:verified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the resolution or fix of the Change Request has been verified.</para>
    /// labels<para>verified</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#verified">http://open-services.net/ns/cm#verified</seealso>
    let verified = Prefixed_Name(oscm, "verified") |> PrefixedName
    /// <summary>
    ///   <para>oscm:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Defines the possible oslc_cm:state property values.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#State">http://open-services.net/ns/cm#State</seealso>
    let State = Prefixed_Name(oscm, "State") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Priority</para>
    ///   <para>Acting on the change request can wait, but not forever.</para>
    /// labels<para>Medium</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Medium">http://open-services.net/ns/cm#Medium</seealso>
    let Medium = Prefixed_Name(oscm, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>oscm:PriorityUnassigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Priority</para>
    ///   <para>The priority of the change request is intentionally not set.</para>
    /// labels<para>PriorityUnassigned</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#PriorityUnassigned">http://open-services.net/ns/cm#PriorityUnassigned</seealso>
    let PriorityUnassigned = Prefixed_Name(oscm, "PriorityUnassigned") |> PrefixedName

    /// <summary>
    ///   <para>oscm:requirementsChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>Used for associating a change request for usage in tracking changes to a Requirements resource.</para>
    /// labels<para>requirementsChangeRequest</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#requirementsChangeRequest">http://open-services.net/ns/cm#requirementsChangeRequest</seealso>
    let requirementsChangeRequest =
        Prefixed_Name(oscm, "requirementsChangeRequest") |> PrefixedName

    /// <summary>
    ///   <para>oscm:task</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>Used for associating change requests into executable and track-able items.</para>
    /// labels<para>task</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#task">http://open-services.net/ns/cm#task</seealso>
    let task = Prefixed_Name(oscm, "task") |> PrefixedName
    /// <summary>
    ///   <para>oscm:testedByTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Test case by which this change request is tested. It is
    /// likely that the target resource will be an oslc_qm:TestCase.</para>
    /// labels<para>testedByTestCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#testedByTestCase">http://open-services.net/ns/cm#testedByTestCase</seealso>
    let testedByTestCase = Prefixed_Name(oscm, "testedByTestCase") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Defines the possible oslc_cm:severity property values.</para>
    /// labels<para>Severity</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Severity">http://open-services.net/ns/cm#Severity</seealso>
    let Severity = Prefixed_Name(oscm, "Severity") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Enhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A request for new functionality.</para>
    /// labels<para>Enhancement</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Enhancement">http://open-services.net/ns/cm#Enhancement</seealso>
    let Enhancement = Prefixed_Name(oscm, "Enhancement") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Low</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Priority</para>
    ///   <para>Action on the change request can be safely deferred.</para>
    /// labels<para>Low</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Low">http://open-services.net/ns/cm#Low</seealso>
    let Low = Prefixed_Name(oscm, "Low") |> PrefixedName
    /// <summary>
    ///   <para>oscm:High</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Priority</para>
    ///   <para>Highest priority, action on the change request highly recommended.</para>
    /// labels<para>High</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#High">http://open-services.net/ns/cm#High</seealso>
    let High = Prefixed_Name(oscm, "High") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Major</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Severity</para>
    ///   <para>Prevents function from being used. There is a workaround.</para>
    /// labels<para>Major</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Major">http://open-services.net/ns/cm#Major</seealso>
    let Major = Prefixed_Name(oscm, "Major") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Normal</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Severity</para>
    ///   <para>Affects non-critical functionality. There is a workaround.</para>
    /// labels<para>Normal</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Normal">http://open-services.net/ns/cm#Normal</seealso>
    let Normal = Prefixed_Name(oscm, "Normal") |> PrefixedName
    /// <summary>
    ///   <para>oscm:ReviewTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A request to make a change and review the change.</para>
    /// labels<para>ReviewTask</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#ReviewTask">http://open-services.net/ns/cm#ReviewTask</seealso>
    let ReviewTask = Prefixed_Name(oscm, "ReviewTask") |> PrefixedName
    /// <summary>
    ///   <para>oscm:SeverityUnassigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Severity</para>
    ///   <para>The severity of the change request is intentionally not set.</para>
    /// labels<para>SeverityUnassigned</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#SeverityUnassigned">http://open-services.net/ns/cm#SeverityUnassigned</seealso>
    let SeverityUnassigned = Prefixed_Name(oscm, "SeverityUnassigned") |> PrefixedName
    /// <summary>
    ///   <para>oscm:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to indicate the relative importance of ChangeRequests.
    /// It is likely that the target resource will be an
    /// oslc_cm:Priority.</para>
    /// labels<para>priority</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#priority">http://open-services.net/ns/cm#priority</seealso>
    let priority = Prefixed_Name(oscm, "priority") |> PrefixedName
    /// <summary>
    ///   <para>oscm:relatedTestPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related test plan resource. It is likely that the
    /// target resource will be an oslc_qm:TestPlan.</para>
    /// labels<para>relatedTestPlan</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#relatedTestPlan">http://open-services.net/ns/cm#relatedTestPlan</seealso>
    let relatedTestPlan = Prefixed_Name(oscm, "relatedTestPlan") |> PrefixedName
    /// <summary>
    ///   <para>oscm:reviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the Change Request has been reviewed.</para>
    /// labels<para>reviewed</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#reviewed">http://open-services.net/ns/cm#reviewed</seealso>
    let reviewed = Prefixed_Name(oscm, "reviewed") |> PrefixedName
    /// <summary>
    ///   <para>oscm:affectedByDefect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Change request is affected by a reported defect. It is
    /// likely that the target resource will be an oslc_cm:Defect.</para>
    /// labels<para>affectedByDefect</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#affectedByDefect">http://open-services.net/ns/cm#affectedByDefect</seealso>
    let affectedByDefect = Prefixed_Name(oscm, "affectedByDefect") |> PrefixedName
    /// <summary>
    ///   <para>oscm:approved</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the Change Request has been approved.</para>
    /// labels<para>approved</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#approved">http://open-services.net/ns/cm#approved</seealso>
    let approved = Prefixed_Name(oscm, "approved") |> PrefixedName
    /// <summary>
    ///   <para>oscm:relatedTestScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related test script resource. It is likely that the
    /// target resource will be an oslc_qm:TestScript.</para>
    /// labels<para>relatedTestScript</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#relatedTestScript">http://open-services.net/ns/cm#relatedTestScript</seealso>
    let relatedTestScript = Prefixed_Name(oscm, "relatedTestScript") |> PrefixedName
    /// <summary>
    ///   <para>oscm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>The OSLC Change Management(CM) Vocabulary</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#">http://open-services.net/ns/cm#</seealso>
    let _prefix_iri = Prefixed_Name(oscm, "") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Blocker</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:Severity</para>
    ///   <para>Severe problem. No workaround. Blocks development, test, or usage.</para>
    /// labels<para>Blocker</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Blocker">http://open-services.net/ns/cm#Blocker</seealso>
    let Blocker = Prefixed_Name(oscm, "Blocker") |> PrefixedName
    /// <summary>
    ///   <para>oscm:ChangeNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents an assignment notification of a change request. May be used also to bestow authority onto the assigned user to effect the changes.</para>
    /// labels<para>ChangeNotice</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#ChangeNotice">http://open-services.net/ns/cm#ChangeNotice</seealso>
    let ChangeNotice = Prefixed_Name(oscm, "ChangeNotice") |> PrefixedName
    /// <summary>
    ///   <para>oscm:Closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>oscm:State</para>
    ///   <para>Whether or not the Change Request is completely done, no further fixes or fix verification is needed.</para>
    /// labels<para>closed</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#Closed">http://open-services.net/ns/cm#Closed</seealso>
    let Closed = Prefixed_Name(oscm, "Closed") |> PrefixedName
    /// <summary>
    ///   <para>oscm:authorizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URI of a resource describing an agent who is responsible authorizing for and/or has authorized effort to be expended to address a set of change requests.</para>
    /// labels<para>authorizer</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#authorizer">http://open-services.net/ns/cm#authorizer</seealso>
    let authorizer = Prefixed_Name(oscm, "authorizer") |> PrefixedName
    /// <summary>
    ///   <para>oscm:fixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the Change Request has been fixed.</para>
    /// labels<para>fixed</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#fixed">http://open-services.net/ns/cm#fixed</seealso>
    let fixed_ = Prefixed_Name(oscm, "fixed") |> PrefixedName

    /// <summary>
    ///   <para>oscm:implementsRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ChangeRequest implements the associated Requirement. It is likely that the
    /// target resource will be an oslc_rm:Requirement.</para>
    /// labels<para>implementsRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/cm#implementsRequirement">http://open-services.net/ns/cm#implementsRequirement</seealso>
    let implementsRequirement =
        Prefixed_Name(oscm, "implementsRequirement") |> PrefixedName
