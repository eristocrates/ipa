#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslc_cm =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/cm#" "oslc_cm"

    let _namespaceIri = _prefixId.prefix ""
    let Approved = _prefixId.prefix "Approved"
    let Blocker = _prefixId.prefix "Blocker"
    /// <summary>
    ///   <para>rdfs:label : ChangeNotice^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an assignment notification of a change request. May be used also to bestow authority onto the assigned user to effect the changes.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#ChangeNotice">oslc_cm:ChangeNotice</a>
    /// </summary>
    let ChangeNotice = _prefixId.prefix "ChangeNotice"
    /// <summary>
    ///   <para>rdfs:label : ChangeRequest^^xsd:string</para>
    ///   <para>rdfs:comment : The CM Change Request resource.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#ChangeRequest">oslc_cm:ChangeRequest</a>
    /// </summary>
    let ChangeRequest = _prefixId.prefix "ChangeRequest"
    let Closed = _prefixId.prefix "Closed"
    let Critical = _prefixId.prefix "Critical"
    /// <summary>
    ///   <para>rdfs:label : Defect^^xsd:string</para>
    ///   <para>rdfs:comment : A software or product defect.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#Defect">oslc_cm:Defect</a>
    /// </summary>
    let Defect = _prefixId.prefix "Defect"
    /// <summary>
    ///   <para>rdfs:label : Enhancement^^xsd:string</para>
    ///   <para>rdfs:comment : A request for new functionality.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#Enhancement">oslc_cm:Enhancement</a>
    /// </summary>
    let Enhancement = _prefixId.prefix "Enhancement"
    let Fixed = _prefixId.prefix "Fixed"
    let High = _prefixId.prefix "High"
    let Inprogress = _prefixId.prefix "Inprogress"
    let Low = _prefixId.prefix "Low"
    let Major = _prefixId.prefix "Major"
    let Medium = _prefixId.prefix "Medium"
    let Minor = _prefixId.prefix "Minor"
    let Normal = _prefixId.prefix "Normal"
    /// <summary>
    ///   <para>rdfs:label : Priority^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the possible oslc_cm:priority property values.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#Priority">oslc_cm:Priority</a>
    /// </summary>
    let Priority = _prefixId.prefix "Priority"
    let PriorityUnassigned = _prefixId.prefix "PriorityUnassigned"
    /// <summary>
    ///   <para>rdfs:label : ReviewTask^^xsd:string</para>
    ///   <para>rdfs:comment : A request to make a change and review the change.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#ReviewTask">oslc_cm:ReviewTask</a>
    /// </summary>
    let ReviewTask = _prefixId.prefix "ReviewTask"
    let Reviewed = _prefixId.prefix "Reviewed"
    /// <summary>
    ///   <para>rdfs:label : Severity^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the possible oslc_cm:severity property values.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#Severity">oslc_cm:Severity</a>
    /// </summary>
    let Severity = _prefixId.prefix "Severity"
    let SeverityUnassigned = _prefixId.prefix "SeverityUnassigned"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the possible oslc_cm:state property values.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#State">oslc_cm:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Task^^xsd:string</para>
    ///   <para>rdfs:comment : An executable and trackable activity.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#Task">oslc_cm:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    let Verified = _prefixId.prefix "Verified"
    /// <summary>
    ///   <para>rdfs:label : affectedByDefect^^xsd:string</para>
    ///   <para>rdfs:comment : Change request is affected by a reported defect. It is
    /// likely that the target resource will be an oslc_cm:Defect.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#affectedByDefect">oslc_cm:affectedByDefect</a>
    /// </summary>
    let affectedByDefect = _prefixId.prefix "affectedByDefect"
    /// <summary>
    ///   <para>rdfs:label : affectsPlanItem^^xsd:string</para>
    ///   <para>rdfs:comment : Change request affects a plan item. It is likely that
    /// the target resource will be an oslc_cm:ChangeRequest.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#affectsPlanItem">oslc_cm:affectsPlanItem</a>
    /// </summary>
    let affectsPlanItem = _prefixId.prefix "affectsPlanItem"
    /// <summary>
    ///   <para>rdfs:label : affectsRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The ChangeRequest affects a Requirement. It is likely
    /// that the target resource will be an oslc_rm:Requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#affectsRequirement">oslc_cm:affectsRequirement</a>
    /// </summary>
    let affectsRequirement = _prefixId.prefix "affectsRequirement"
    /// <summary>
    ///   <para>rdfs:label : affectsTestResult^^xsd:string</para>
    ///   <para>rdfs:comment : Associated resource that is affected by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestResult.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#affectsTestResult">oslc_cm:affectsTestResult</a>
    /// </summary>
    let affectsTestResult = _prefixId.prefix "affectsTestResult"
    /// <summary>
    ///   <para>rdfs:label : approved^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the Change Request has been approved.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#approved">oslc_cm:approved</a>
    /// </summary>
    let approved = _prefixId.prefix "approved"
    /// <summary>
    ///   <para>rdfs:label : authorizer^^xsd:string</para>
    ///   <para>rdfs:comment : The URI of a resource describing an agent who is responsible authorizing for and/or has authorized effort to be expended to address a set of change requests.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#authorizer">oslc_cm:authorizer</a>
    /// </summary>
    let authorizer = _prefixId.prefix "authorizer"
    /// <summary>
    ///   <para>rdfs:label : blocksTestExecutionRecord^^xsd:string</para>
    ///   <para>rdfs:comment : Associated resource that is blocked by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestExecutionRecord.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#blocksTestExecutionRecord">oslc_cm:blocksTestExecutionRecord</a>
    /// </summary>
    let blocksTestExecutionRecord = _prefixId.prefix "blocksTestExecutionRecord"
    /// <summary>
    ///   <para>rdfs:label : closeDate^^xsd:string</para>
    ///   <para>rdfs:comment : The date at which no further activity or work is intended to be conducted.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#closeDate">oslc_cm:closeDate</a>
    /// </summary>
    let closeDate = _prefixId.prefix "closeDate"
    /// <summary>
    ///   <para>rdfs:label : closed^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the Change Request is completely done, no further fixes or fix verification is needed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#closed">oslc_cm:closed</a>
    /// </summary>
    let closed = _prefixId.prefix "closed"
    let defect = _prefixId.prefix "defect"
    /// <summary>
    ///   <para>rdfs:label : fixed^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the Change Request has been fixed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#fixed">oslc_cm:fixed</a>
    /// </summary>
    let fixed_ = _prefixId.prefix "fixed"
    /// <summary>
    ///   <para>rdfs:label : implementsRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The ChangeRequest implements the associated Requirement. It is likely that the
    /// target resource will be an oslc_rm:Requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#implementsRequirement">oslc_cm:implementsRequirement</a>
    /// </summary>
    let implementsRequirement = _prefixId.prefix "implementsRequirement"
    /// <summary>
    ///   <para>rdfs:label : inProgress^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the Change Request in a state indicating that active work is occurring.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#inProgress">oslc_cm:inProgress</a>
    /// </summary>
    let inProgress = _prefixId.prefix "inProgress"
    /// <summary>
    ///   <para>rdfs:label : parent^^xsd:string</para>
    ///   <para>rdfs:comment : The related parent change requests of the subject change request.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#parent">oslc_cm:parent</a>
    /// </summary>
    let parent = _prefixId.prefix "parent"
    let planItem = _prefixId.prefix "planItem"
    /// <summary>
    ///   <para>rdfs:label : priority^^xsd:string</para>
    ///   <para>rdfs:comment : Used to indicate the relative importance of ChangeRequests.
    /// It is likely that the target resource will be an
    /// oslc_cm:Priority.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#priority">oslc_cm:priority</a>
    /// </summary>
    let priority = _prefixId.prefix "priority"
    /// <summary>
    ///   <para>rdfs:label : relatedChangeRequest^^xsd:string</para>
    ///   <para>rdfs:comment : This relationship is loosely coupled, has no specific
    /// meaning, and can be used to link related change requests. It is likely
    /// that the target resource will be an oslc_cm:ChangeRequest.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#relatedChangeRequest">oslc_cm:relatedChangeRequest</a>
    /// </summary>
    let relatedChangeRequest = _prefixId.prefix "relatedChangeRequest"
    /// <summary>
    ///   <para>rdfs:label : relatedTestCase^^xsd:string</para>
    ///   <para>rdfs:comment : Related test case resource. It is likely that the
    /// target resource will be an oslc_qm:TestCase.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#relatedTestCase">oslc_cm:relatedTestCase</a>
    /// </summary>
    let relatedTestCase = _prefixId.prefix "relatedTestCase"
    /// <summary>
    ///   <para>rdfs:label : relatedTestExecutionRecord^^xsd:string</para>
    ///   <para>rdfs:comment : Related to a test execution resource. It is likely
    /// that the target resource will be an oslc_qm:TestExecutionRecord.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#relatedTestExecutionRecord">oslc_cm:relatedTestExecutionRecord</a>
    /// </summary>
    let relatedTestExecutionRecord = _prefixId.prefix "relatedTestExecutionRecord"
    /// <summary>
    ///   <para>rdfs:label : relatedTestPlan^^xsd:string</para>
    ///   <para>rdfs:comment : Related test plan resource. It is likely that the
    /// target resource will be an oslc_qm:TestPlan.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#relatedTestPlan">oslc_cm:relatedTestPlan</a>
    /// </summary>
    let relatedTestPlan = _prefixId.prefix "relatedTestPlan"
    /// <summary>
    ///   <para>rdfs:label : relatedTestScript^^xsd:string</para>
    ///   <para>rdfs:comment : Related test script resource. It is likely that the
    /// target resource will be an oslc_qm:TestScript.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#relatedTestScript">oslc_cm:relatedTestScript</a>
    /// </summary>
    let relatedTestScript = _prefixId.prefix "relatedTestScript"
    let requirementsChangeRequest = _prefixId.prefix "requirementsChangeRequest"
    /// <summary>
    ///   <para>rdfs:label : reviewed^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the Change Request has been reviewed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#reviewed">oslc_cm:reviewed</a>
    /// </summary>
    let reviewed = _prefixId.prefix "reviewed"
    /// <summary>
    ///   <para>rdfs:label : severity^^xsd:string</para>
    ///   <para>rdfs:comment : Used to indicate the severity or potential impact of a defect.
    /// It is likely that the target resource will be an oslc_cm:Severity.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#severity">oslc_cm:severity</a>
    /// </summary>
    let severity = _prefixId.prefix "severity"
    /// <summary>
    ///   <para>rdfs:label : state^^xsd:string</para>
    ///   <para>rdfs:comment : Used to indicate the status of the change request.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#state">oslc_cm:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>rdfs:comment : Used to indicate the status of the change request based
    /// on values defined by the service provider. Most often a read-only
    /// property. It is likely that the target resource will be a string corresponding to an
    /// oslc_cm:State value.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#status">oslc_cm:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    let task = _prefixId.prefix "task"
    /// <summary>
    ///   <para>rdfs:label : testedByTestCase^^xsd:string</para>
    ///   <para>rdfs:comment : Test case by which this change request is tested. It is
    /// likely that the target resource will be an oslc_qm:TestCase.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#testedByTestCase">oslc_cm:testedByTestCase</a>
    /// </summary>
    let testedByTestCase = _prefixId.prefix "testedByTestCase"
    /// <summary>
    ///   <para>rdfs:label : tracksChangeSet^^xsd:string</para>
    ///   <para>rdfs:comment : Tracks a change set resource. It is likely that the
    /// target resource will be an oslc_config:ChangeSet.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#tracksChangeSet">oslc_cm:tracksChangeSet</a>
    /// </summary>
    let tracksChangeSet = _prefixId.prefix "tracksChangeSet"
    /// <summary>
    ///   <para>rdfs:label : tracksRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : Tracks the associated Requirement or Requirement
    /// ChangeSet resources. It is likely that the target resource will be an
    /// oslc_rm:Requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#tracksRequirement">oslc_cm:tracksRequirement</a>
    /// </summary>
    let tracksRequirement = _prefixId.prefix "tracksRequirement"
    /// <summary>
    ///   <para>rdfs:label : verified^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the resolution or fix of the Change Request has been verified.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/cm#verified">oslc_cm:verified</a>
    /// </summary>
    let verified = _prefixId.prefix "verified"
