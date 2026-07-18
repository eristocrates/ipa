namespace http.open_services.net.ns.cm.hash

open DoxAletheia.Rdf_Vocabulary

module cm =
    let _namespace_name = "http://open-services.net/ns/cm#"
    /// <summary>
    /// Whether or not the Change Request has been approved.
    /// <see href="http://open-services.net/ns/cm#Approved"></see></summary>
    let Approved = Namespaced_IRI.parse _namespace_name "Approved" |> NamespacedName
    /// <summary>
    /// Defines the possible oslc_cm:state property values.
    /// <see href="http://open-services.net/ns/cm#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// Severe problem. No workaround. Blocks development, test, or usage.
    /// <see href="http://open-services.net/ns/cm#Blocker"></see></summary>
    let Blocker = Namespaced_IRI.parse _namespace_name "Blocker" |> NamespacedName
    /// <summary>
    /// Defines the possible oslc_cm:severity property values.
    /// <see href="http://open-services.net/ns/cm#Severity"></see></summary>
    let Severity = Namespaced_IRI.parse _namespace_name "Severity" |> NamespacedName

    /// <summary>
    /// Represents an assignment notification of a change request. May be used also to bestow authority onto the assigned user to effect the changes.
    /// <see href="http://open-services.net/ns/cm#ChangeNotice"></see></summary>
    let ChangeNotice =
        Namespaced_IRI.parse _namespace_name "ChangeNotice" |> NamespacedName

    /// <summary>
    /// The CM Change Request resource.
    /// <see href="http://open-services.net/ns/cm#ChangeRequest"></see></summary>
    let ChangeRequest =
        Namespaced_IRI.parse _namespace_name "ChangeRequest" |> NamespacedName

    /// <summary>
    /// Whether or not the Change Request is completely done, no further fixes or fix verification is needed.
    /// <see href="http://open-services.net/ns/cm#Closed"></see></summary>
    let Closed = Namespaced_IRI.parse _namespace_name "Closed" |> NamespacedName
    /// <summary>
    /// Severe problem. No workaround.
    /// <see href="http://open-services.net/ns/cm#Critical"></see></summary>
    let Critical = Namespaced_IRI.parse _namespace_name "Critical" |> NamespacedName
    /// <summary>
    /// A software or product defect.
    /// <see href="http://open-services.net/ns/cm#Defect"></see></summary>
    let Defect = Namespaced_IRI.parse _namespace_name "Defect" |> NamespacedName

    /// <summary>
    /// A request for new functionality.
    /// <see href="http://open-services.net/ns/cm#Enhancement"></see></summary>
    let Enhancement =
        Namespaced_IRI.parse _namespace_name "Enhancement" |> NamespacedName

    /// <summary>
    /// Whether or not the Change Request has been fixed.
    /// <see href="http://open-services.net/ns/cm#Fixed"></see></summary>
    let Fixed = Namespaced_IRI.parse _namespace_name "Fixed" |> NamespacedName
    /// <summary>
    /// Highest priority, action on the change request highly recommended.
    /// <see href="http://open-services.net/ns/cm#High"></see></summary>
    let High = Namespaced_IRI.parse _namespace_name "High" |> NamespacedName
    /// <summary>
    /// Defines the possible oslc_cm:priority property values.
    /// <see href="http://open-services.net/ns/cm#Priority"></see></summary>
    let Priority = Namespaced_IRI.parse _namespace_name "Priority" |> NamespacedName
    /// <summary>
    /// Whether or not the Change Request in a state indicating that active work is occurring.
    /// <see href="http://open-services.net/ns/cm#Inprogress"></see></summary>
    let Inprogress = Namespaced_IRI.parse _namespace_name "Inprogress" |> NamespacedName
    /// <summary>
    /// Action on the change request can be safely deferred.
    /// <see href="http://open-services.net/ns/cm#Low"></see></summary>
    let Low = Namespaced_IRI.parse _namespace_name "Low" |> NamespacedName
    /// <summary>
    /// Prevents function from being used. There is a workaround.
    /// <see href="http://open-services.net/ns/cm#Major"></see></summary>
    let Major = Namespaced_IRI.parse _namespace_name "Major" |> NamespacedName
    /// <summary>
    /// Acting on the change request can wait, but not forever.
    /// <see href="http://open-services.net/ns/cm#Medium"></see></summary>
    let Medium = Namespaced_IRI.parse _namespace_name "Medium" |> NamespacedName
    /// <summary>
    /// Minimal impact.
    /// <see href="http://open-services.net/ns/cm#Minor"></see></summary>
    let Minor = Namespaced_IRI.parse _namespace_name "Minor" |> NamespacedName
    /// <summary>
    /// Affects non-critical functionality. There is a workaround.
    /// <see href="http://open-services.net/ns/cm#Normal"></see></summary>
    let Normal = Namespaced_IRI.parse _namespace_name "Normal" |> NamespacedName

    /// <summary>
    /// The priority of the change request is intentionally not set.
    /// <see href="http://open-services.net/ns/cm#PriorityUnassigned"></see></summary>
    let PriorityUnassigned =
        Namespaced_IRI.parse _namespace_name "PriorityUnassigned" |> NamespacedName

    /// <summary>
    /// A request to make a change and review the change.
    /// <see href="http://open-services.net/ns/cm#ReviewTask"></see></summary>
    let ReviewTask = Namespaced_IRI.parse _namespace_name "ReviewTask" |> NamespacedName
    /// <summary>
    /// An executable and trackable activity.
    /// <see href="http://open-services.net/ns/cm#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName
    /// <summary>
    /// Whether or not the Change Request has been reviewed.
    /// <see href="http://open-services.net/ns/cm#Reviewed"></see></summary>
    let Reviewed = Namespaced_IRI.parse _namespace_name "Reviewed" |> NamespacedName

    /// <summary>
    /// The severity of the change request is intentionally not set.
    /// <see href="http://open-services.net/ns/cm#SeverityUnassigned"></see></summary>
    let SeverityUnassigned =
        Namespaced_IRI.parse _namespace_name "SeverityUnassigned" |> NamespacedName

    /// <summary>
    /// Whether or not the resolution or fix of the Change Request has been verified.
    /// <see href="http://open-services.net/ns/cm#Verified"></see></summary>
    let Verified = Namespaced_IRI.parse _namespace_name "Verified" |> NamespacedName

    /// <summary>
    /// Change request is affected by a reported defect. It is
    /// likely that the target resource will be an oslc_cm:Defect.
    /// <see href="http://open-services.net/ns/cm#affectedByDefect"></see></summary>
    let affectedByDefect =
        Namespaced_IRI.parse _namespace_name "affectedByDefect" |> NamespacedName

    /// <summary>
    /// Change request affects a plan item. It is likely that
    /// the target resource will be an oslc_cm:ChangeRequest.
    /// <see href="http://open-services.net/ns/cm#affectsPlanItem"></see></summary>
    let affectsPlanItem =
        Namespaced_IRI.parse _namespace_name "affectsPlanItem" |> NamespacedName

    /// <summary>
    /// The ChangeRequest affects a Requirement. It is likely
    /// that the target resource will be an oslc_rm:Requirement.
    /// <see href="http://open-services.net/ns/cm#affectsRequirement"></see></summary>
    let affectsRequirement =
        Namespaced_IRI.parse _namespace_name "affectsRequirement" |> NamespacedName

    /// <summary>
    /// Associated resource that is affected by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestResult.
    /// <see href="http://open-services.net/ns/cm#affectsTestResult"></see></summary>
    let affectsTestResult =
        Namespaced_IRI.parse _namespace_name "affectsTestResult" |> NamespacedName

    /// <summary>
    /// Whether or not the Change Request has been approved.
    /// <see href="http://open-services.net/ns/cm#approved"></see></summary>
    let approved = Namespaced_IRI.parse _namespace_name "approved" |> NamespacedName
    /// <summary>
    /// The URI of a resource describing an agent who is responsible authorizing for and/or has authorized effort to be expended to address a set of change requests.
    /// <see href="http://open-services.net/ns/cm#authorizer"></see></summary>
    let authorizer = Namespaced_IRI.parse _namespace_name "authorizer" |> NamespacedName

    /// <summary>
    /// Associated resource that is blocked by this Change
    /// Request. It is likely that the target resource will be an
    /// oslc_qm:TestExecutionRecord.
    /// <see href="http://open-services.net/ns/cm#blocksTestExecutionRecord"></see></summary>
    let blocksTestExecutionRecord =
        Namespaced_IRI.parse _namespace_name "blocksTestExecutionRecord" |> NamespacedName

    /// <summary>
    /// The date at which no further activity or work is intended to be conducted.
    /// <see href="http://open-services.net/ns/cm#closeDate"></see></summary>
    let closeDate = Namespaced_IRI.parse _namespace_name "closeDate" |> NamespacedName
    /// <summary>
    /// Whether or not the Change Request is completely done, no further fixes or fix verification is needed.
    /// <see href="http://open-services.net/ns/cm#closed"></see></summary>
    let closed = Namespaced_IRI.parse _namespace_name "closed" |> NamespacedName
    /// <summary>
    /// Used to report defects in testing.
    /// <see href="http://open-services.net/ns/cm#defect"></see></summary>
    let defect = Namespaced_IRI.parse _namespace_name "defect" |> NamespacedName
    /// <summary>
    /// Whether or not the Change Request has been fixed.
    /// <see href="http://open-services.net/ns/cm#fixed"></see></summary>
    let fixed_ = Namespaced_IRI.parse _namespace_name "fixed" |> NamespacedName

    /// <summary>
    /// The ChangeRequest implements the associated Requirement. It is likely that the
    /// target resource will be an oslc_rm:Requirement.
    /// <see href="http://open-services.net/ns/cm#implementsRequirement"></see></summary>
    let implementsRequirement =
        Namespaced_IRI.parse _namespace_name "implementsRequirement" |> NamespacedName

    /// <summary>
    /// Whether or not the Change Request in a state indicating that active work is occurring.
    /// <see href="http://open-services.net/ns/cm#inProgress"></see></summary>
    let inProgress = Namespaced_IRI.parse _namespace_name "inProgress" |> NamespacedName
    /// <summary>
    /// The related parent change requests of the subject change request.
    /// <see href="http://open-services.net/ns/cm#parent"></see></summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName
    /// <summary>
    /// Used for associating change requests into plans (project, release, sprint, etc).
    /// <see href="http://open-services.net/ns/cm#planItem"></see></summary>
    let planItem = Namespaced_IRI.parse _namespace_name "planItem" |> NamespacedName
    /// <summary>
    /// Used to indicate the relative importance of ChangeRequests.
    /// It is likely that the target resource will be an
    /// oslc_cm:Priority.
    /// <see href="http://open-services.net/ns/cm#priority"></see></summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName

    /// <summary>
    /// This relationship is loosely coupled, has no specific
    /// meaning, and can be used to link related change requests. It is likely
    /// that the target resource will be an oslc_cm:ChangeRequest.
    /// <see href="http://open-services.net/ns/cm#relatedChangeRequest"></see></summary>
    let relatedChangeRequest =
        Namespaced_IRI.parse _namespace_name "relatedChangeRequest" |> NamespacedName

    /// <summary>
    /// Related test case resource. It is likely that the
    /// target resource will be an oslc_qm:TestCase.
    /// <see href="http://open-services.net/ns/cm#relatedTestCase"></see></summary>
    let relatedTestCase =
        Namespaced_IRI.parse _namespace_name "relatedTestCase" |> NamespacedName

    /// <summary>
    /// Related to a test execution resource. It is likely
    /// that the target resource will be an oslc_qm:TestExecutionRecord.
    /// <see href="http://open-services.net/ns/cm#relatedTestExecutionRecord"></see></summary>
    let relatedTestExecutionRecord =
        Namespaced_IRI.parse _namespace_name "relatedTestExecutionRecord" |> NamespacedName

    /// <summary>
    /// Related test plan resource. It is likely that the
    /// target resource will be an oslc_qm:TestPlan.
    /// <see href="http://open-services.net/ns/cm#relatedTestPlan"></see></summary>
    let relatedTestPlan =
        Namespaced_IRI.parse _namespace_name "relatedTestPlan" |> NamespacedName

    /// <summary>
    /// Related test script resource. It is likely that the
    /// target resource will be an oslc_qm:TestScript.
    /// <see href="http://open-services.net/ns/cm#relatedTestScript"></see></summary>
    let relatedTestScript =
        Namespaced_IRI.parse _namespace_name "relatedTestScript" |> NamespacedName

    /// <summary>
    /// Used for associating a change request for usage in tracking changes to a Requirements resource.
    /// <see href="http://open-services.net/ns/cm#requirementsChangeRequest"></see></summary>
    let requirementsChangeRequest =
        Namespaced_IRI.parse _namespace_name "requirementsChangeRequest" |> NamespacedName

    /// <summary>
    /// Whether or not the Change Request has been reviewed.
    /// <see href="http://open-services.net/ns/cm#reviewed"></see></summary>
    let reviewed = Namespaced_IRI.parse _namespace_name "reviewed" |> NamespacedName
    /// <summary>
    /// Used to indicate the severity or potential impact of a defect.
    /// It is likely that the target resource will be an oslc_cm:Severity.
    /// <see href="http://open-services.net/ns/cm#severity"></see></summary>
    let severity = Namespaced_IRI.parse _namespace_name "severity" |> NamespacedName
    /// <summary>
    /// Used to indicate the status of the change request.
    /// <see href="http://open-services.net/ns/cm#state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName
    /// <summary>
    /// Used to indicate the status of the change request based
    /// on values defined by the service provider. Most often a read-only
    /// property. It is likely that the target resource will be a string corresponding to an
    /// oslc_cm:State value.
    /// <see href="http://open-services.net/ns/cm#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// Used for associating change requests into executable and track-able items.
    /// <see href="http://open-services.net/ns/cm#task"></see></summary>
    let task = Namespaced_IRI.parse _namespace_name "task" |> NamespacedName

    /// <summary>
    /// Test case by which this change request is tested. It is
    /// likely that the target resource will be an oslc_qm:TestCase.
    /// <see href="http://open-services.net/ns/cm#testedByTestCase"></see></summary>
    let testedByTestCase =
        Namespaced_IRI.parse _namespace_name "testedByTestCase" |> NamespacedName

    /// <summary>
    /// Tracks a change set resource. It is likely that the
    /// target resource will be an oslc_config:ChangeSet.
    /// <see href="http://open-services.net/ns/cm#tracksChangeSet"></see></summary>
    let tracksChangeSet =
        Namespaced_IRI.parse _namespace_name "tracksChangeSet" |> NamespacedName

    /// <summary>
    /// Tracks the associated Requirement or Requirement
    /// ChangeSet resources. It is likely that the target resource will be an
    /// oslc_rm:Requirement.
    /// <see href="http://open-services.net/ns/cm#tracksRequirement"></see></summary>
    let tracksRequirement =
        Namespaced_IRI.parse _namespace_name "tracksRequirement" |> NamespacedName

    /// <summary>
    /// Whether or not the resolution or fix of the Change Request has been verified.
    /// <see href="http://open-services.net/ns/cm#verified"></see></summary>
    let verified = Namespaced_IRI.parse _namespace_name "verified" |> NamespacedName
