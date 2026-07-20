namespace http.open_services.net.ns.cm.hash

open DoxAletheia

module cm =
    let _namespace_name = "http://open-services.net/ns/cm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Whether or not the Change Request has been approved.
    /// <see href="http://open-services.net/ns/cm#Approved"></see></summary>
    let Approved = _prefix "Approved"
    /// <summary>
    /// Defines the possible oslc_cm:state property values.
    /// <see href="http://open-services.net/ns/cm#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// Severe problem. No workaround. Blocks development, test, or usage.
    /// <see href="http://open-services.net/ns/cm#Blocker"></see></summary>
    let Blocker = _prefix "Blocker"
    /// <summary>
    /// Defines the possible oslc_cm:severity property values.
    /// <see href="http://open-services.net/ns/cm#Severity"></see></summary>
    let Severity = _prefix "Severity"
    /// <summary>
    /// Represents an assignment notification of a change request. May be used also to bestow authority onto the assigned user to effect the changes.
    /// <see href="http://open-services.net/ns/cm#ChangeNotice"></see></summary>
    let ChangeNotice = _prefix "ChangeNotice"
    /// <summary>
    /// The CM Change Request resource.
    /// <see href="http://open-services.net/ns/cm#ChangeRequest"></see></summary>
    let ChangeRequest = _prefix "ChangeRequest"
    /// <summary>
    /// Whether or not the Change Request is completely done, no further fixes or fix verification is needed.
    /// <see href="http://open-services.net/ns/cm#Closed"></see></summary>
    let Closed = _prefix "Closed"
    /// <summary>
    /// Severe problem. No workaround.
    /// <see href="http://open-services.net/ns/cm#Critical"></see></summary>
    let Critical = _prefix "Critical"
    /// <summary>
    /// A software or product defect.
    /// <see href="http://open-services.net/ns/cm#Defect"></see></summary>
    let Defect = _prefix "Defect"
    /// <summary>
    /// A request for new functionality.
    /// <see href="http://open-services.net/ns/cm#Enhancement"></see></summary>
    let Enhancement = _prefix "Enhancement"
    /// <summary>
    /// Whether or not the Change Request has been fixed.
    /// <see href="http://open-services.net/ns/cm#Fixed"></see></summary>
    let Fixed = _prefix "Fixed"
    /// <summary>
    /// Highest priority, action on the change request highly recommended.
    /// <see href="http://open-services.net/ns/cm#High"></see></summary>
    let High = _prefix "High"
    /// <summary>
    /// Defines the possible oslc_cm:priority property values.
    /// <see href="http://open-services.net/ns/cm#Priority"></see></summary>
    let Priority = _prefix "Priority"
    /// <summary>
    /// Whether or not the Change Request in a state indicating that active work is occurring.
    /// <see href="http://open-services.net/ns/cm#Inprogress"></see></summary>
    let Inprogress = _prefix "Inprogress"
    /// <summary>
    /// Action on the change request can be safely deferred.
    /// <see href="http://open-services.net/ns/cm#Low"></see></summary>
    let Low = _prefix "Low"
    /// <summary>
    /// Prevents function from being used. There is a workaround.
    /// <see href="http://open-services.net/ns/cm#Major"></see></summary>
    let Major = _prefix "Major"
    /// <summary>
    /// Acting on the change request can wait, but not forever.
    /// <see href="http://open-services.net/ns/cm#Medium"></see></summary>
    let Medium = _prefix "Medium"
    /// <summary>
    /// Minimal impact.
    /// <see href="http://open-services.net/ns/cm#Minor"></see></summary>
    let Minor = _prefix "Minor"
    /// <summary>
    /// Affects non-critical functionality. There is a workaround.
    /// <see href="http://open-services.net/ns/cm#Normal"></see></summary>
    let Normal = _prefix "Normal"
    /// <summary>
    /// The priority of the change request is intentionally not set.
    /// <see href="http://open-services.net/ns/cm#PriorityUnassigned"></see></summary>
    let PriorityUnassigned = _prefix "PriorityUnassigned"
    /// <summary>
    /// A request to make a change and review the change.
    /// <see href="http://open-services.net/ns/cm#ReviewTask"></see></summary>
    let ReviewTask = _prefix "ReviewTask"
    /// <summary>
    /// An executable and trackable activity.
    /// <see href="http://open-services.net/ns/cm#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// Whether or not the Change Request has been reviewed.
    /// <see href="http://open-services.net/ns/cm#Reviewed"></see></summary>
    let Reviewed = _prefix "Reviewed"
    /// <summary>
    /// The severity of the change request is intentionally not set.
    /// <see href="http://open-services.net/ns/cm#SeverityUnassigned"></see></summary>
    let SeverityUnassigned = _prefix "SeverityUnassigned"
    /// <summary>
    /// Whether or not the resolution or fix of the Change Request has been verified.
    /// <see href="http://open-services.net/ns/cm#Verified"></see></summary>
    let Verified = _prefix "Verified"
    /// <summary>
    /// Change request is affected by a reported defect. It is
    /// likely that the target resource will be an oslc_cm:Defect.
    /// <see href="http://open-services.net/ns/cm#affectedByDefect"></see></summary>
    let affectedByDefect = _prefix "affectedByDefect"
    /// <summary>
    /// Change request affects a plan item. It is likely that
    /// the target resource will be an oslc_cm:ChangeRequest.
    /// <see href="http://open-services.net/ns/cm#affectsPlanItem"></see></summary>
    let affectsPlanItem = _prefix "affectsPlanItem"
    /// <summary>
    /// The ChangeRequest affects a Requirement. It is likely
    /// that the target resource will be an oslc_rm:Requirement.
    /// <see href="http://open-services.net/ns/cm#affectsRequirement"></see></summary>
    let affectsRequirement = _prefix "affectsRequirement"
    /// <summary>
    /// Associated resource that is affected by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestResult.
    /// <see href="http://open-services.net/ns/cm#affectsTestResult"></see></summary>
    let affectsTestResult = _prefix "affectsTestResult"
    /// <summary>
    /// Whether or not the Change Request has been approved.
    /// <see href="http://open-services.net/ns/cm#approved"></see></summary>
    let approved = _prefix "approved"
    /// <summary>
    /// The URI of a resource describing an agent who is responsible authorizing for and/or has authorized effort to be expended to address a set of change requests.
    /// <see href="http://open-services.net/ns/cm#authorizer"></see></summary>
    let authorizer = _prefix "authorizer"
    /// <summary>
    /// Associated resource that is blocked by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestExecutionRecord.
    /// <see href="http://open-services.net/ns/cm#blocksTestExecutionRecord"></see></summary>
    let blocksTestExecutionRecord = _prefix "blocksTestExecutionRecord"
    /// <summary>
    /// The date at which no further activity or work is intended to be conducted.
    /// <see href="http://open-services.net/ns/cm#closeDate"></see></summary>
    let closeDate = _prefix "closeDate"
    /// <summary>
    /// Whether or not the Change Request is completely done, no further fixes or fix verification is needed.
    /// <see href="http://open-services.net/ns/cm#closed"></see></summary>
    let closed = _prefix "closed"
    /// <summary>
    /// Used to report defects in testing.
    /// <see href="http://open-services.net/ns/cm#defect"></see></summary>
    let defect = _prefix "defect"
    /// <summary>
    /// Whether or not the Change Request has been fixed.
    /// <see href="http://open-services.net/ns/cm#fixed"></see></summary>
    let fixed_ = _prefix "fixed"
    /// <summary>
    /// The ChangeRequest implements the associated Requirement. It is likely that the
    /// target resource will be an oslc_rm:Requirement.
    /// <see href="http://open-services.net/ns/cm#implementsRequirement"></see></summary>
    let implementsRequirement = _prefix "implementsRequirement"
    /// <summary>
    /// Whether or not the Change Request in a state indicating that active work is occurring.
    /// <see href="http://open-services.net/ns/cm#inProgress"></see></summary>
    let inProgress = _prefix "inProgress"
    /// <summary>
    /// The related parent change requests of the subject change request.
    /// <see href="http://open-services.net/ns/cm#parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// Used for associating change requests into plans (project, release, sprint, etc).
    /// <see href="http://open-services.net/ns/cm#planItem"></see></summary>
    let planItem = _prefix "planItem"
    /// <summary>
    /// Used to indicate the relative importance of ChangeRequests.
    /// It is likely that the target resource will be an
    /// oslc_cm:Priority.
    /// <see href="http://open-services.net/ns/cm#priority"></see></summary>
    let priority = _prefix "priority"
    /// <summary>
    /// This relationship is loosely coupled, has no specific
    /// meaning, and can be used to link related change requests. It is likely
    /// that the target resource will be an oslc_cm:ChangeRequest.
    /// <see href="http://open-services.net/ns/cm#relatedChangeRequest"></see></summary>
    let relatedChangeRequest = _prefix "relatedChangeRequest"
    /// <summary>
    /// Related test case resource. It is likely that the
    /// target resource will be an oslc_qm:TestCase.
    /// <see href="http://open-services.net/ns/cm#relatedTestCase"></see></summary>
    let relatedTestCase = _prefix "relatedTestCase"
    /// <summary>
    /// Related to a test execution resource. It is likely
    /// that the target resource will be an oslc_qm:TestExecutionRecord.
    /// <see href="http://open-services.net/ns/cm#relatedTestExecutionRecord"></see></summary>
    let relatedTestExecutionRecord = _prefix "relatedTestExecutionRecord"
    /// <summary>
    /// Related test plan resource. It is likely that the
    /// target resource will be an oslc_qm:TestPlan.
    /// <see href="http://open-services.net/ns/cm#relatedTestPlan"></see></summary>
    let relatedTestPlan = _prefix "relatedTestPlan"
    /// <summary>
    /// Related test script resource. It is likely that the
    /// target resource will be an oslc_qm:TestScript.
    /// <see href="http://open-services.net/ns/cm#relatedTestScript"></see></summary>
    let relatedTestScript = _prefix "relatedTestScript"
    /// <summary>
    /// Used for associating a change request for usage in tracking changes to a Requirements resource.
    /// <see href="http://open-services.net/ns/cm#requirementsChangeRequest"></see></summary>
    let requirementsChangeRequest = _prefix "requirementsChangeRequest"
    /// <summary>
    /// Whether or not the Change Request has been reviewed.
    /// <see href="http://open-services.net/ns/cm#reviewed"></see></summary>
    let reviewed = _prefix "reviewed"
    /// <summary>
    /// Used to indicate the severity or potential impact of a defect.
    /// It is likely that the target resource will be an oslc_cm:Severity.
    /// <see href="http://open-services.net/ns/cm#severity"></see></summary>
    let severity = _prefix "severity"
    /// <summary>
    /// Used to indicate the status of the change request.
    /// <see href="http://open-services.net/ns/cm#state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// Used to indicate the status of the change request based
    /// on values defined by the service provider. Most often a read-only
    /// property. It is likely that the target resource will be a string corresponding to an
    /// oslc_cm:State value.
    /// <see href="http://open-services.net/ns/cm#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// Used for associating change requests into executable and track-able items.
    /// <see href="http://open-services.net/ns/cm#task"></see></summary>
    let task = _prefix "task"
    /// <summary>
    /// Test case by which this change request is tested. It is
    /// likely that the target resource will be an oslc_qm:TestCase.
    /// <see href="http://open-services.net/ns/cm#testedByTestCase"></see></summary>
    let testedByTestCase = _prefix "testedByTestCase"
    /// <summary>
    /// Tracks a change set resource. It is likely that the
    /// target resource will be an oslc_config:ChangeSet.
    /// <see href="http://open-services.net/ns/cm#tracksChangeSet"></see></summary>
    let tracksChangeSet = _prefix "tracksChangeSet"
    /// <summary>
    /// Tracks the associated Requirement or Requirement
    /// ChangeSet resources. It is likely that the target resource will be an
    /// oslc_rm:Requirement.
    /// <see href="http://open-services.net/ns/cm#tracksRequirement"></see></summary>
    let tracksRequirement = _prefix "tracksRequirement"
    /// <summary>
    /// Whether or not the resolution or fix of the Change Request has been verified.
    /// <see href="http://open-services.net/ns/cm#verified"></see></summary>
    let verified = _prefix "verified"
