namespace http.voag.linkedmodel.org.voag.hash

open DoxAletheia

module voag =
    let _namespace_name = "http://voag.linkedmodel.org/voag#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernedObject"></see>
    /// </summary>
    let GovernedObject = _prefix "GovernedObject"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#intent"></see>
    /// </summary>
    let intent = _prefix "intent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VOAG-CatalogEntry"></see>
    /// </summary>
    let ``VOAG-CatalogEntry`` = _prefix "VOAG-CatalogEntry"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#TopQuadrantAttribution"></see>
    /// </summary>
    let TopQuadrantAttribution = _prefix "TopQuadrantAttribution"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Accredidation"></see>
    /// </summary>
    let Accredidation = _prefix "Accredidation"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Qualifier"></see>
    /// </summary>
    let Qualifier = _prefix "Qualifier"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AdministrativeEvent"></see>
    /// </summary>
    let AdministrativeEvent = _prefix "AdministrativeEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Annually"></see>
    /// </summary>
    let Annually = _prefix "Annually"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ChangeFrequency"></see>
    /// </summary>
    let ChangeFrequency = _prefix "ChangeFrequency"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AppendChange"></see>
    /// </summary>
    let AppendChange = _prefix "AppendChange"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ChangeType"></see>
    /// </summary>
    let ChangeType = _prefix "ChangeType"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ApprovalEvent"></see>
    /// </summary>
    let ApprovalEvent = _prefix "ApprovalEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RejectionEvent"></see>
    /// </summary>
    let RejectionEvent = _prefix "RejectionEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ApprovalProcess"></see>
    /// </summary>
    let ApprovalProcess = _prefix "ApprovalProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceProcess"></see>
    /// </summary>
    let GovernanceProcess = _prefix "GovernanceProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ApprovedIssue"></see>
    /// </summary>
    let ApprovedIssue = _prefix "ApprovedIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#IssueStatus"></see>
    /// </summary>
    let IssueStatus = _prefix "IssueStatus"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AssignedRole"></see>
    /// </summary>
    let AssignedRole = _prefix "AssignedRole"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Attribution"></see>
    /// </summary>
    let Attribution = _prefix "Attribution"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#pointOfContact"></see>
    /// </summary>
    let pointOfContact = _prefix "pointOfContact"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasLogo"></see>
    /// </summary>
    let hasLogo = _prefix "hasLogo"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AttributionLogo"></see>
    /// </summary>
    let AttributionLogo = _prefix "AttributionLogo"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#url"></see>
    /// </summary>
    let url = _prefix "url"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Logo"></see>
    /// </summary>
    let Logo = _prefix "Logo"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BiMonthly"></see>
    /// </summary>
    let BiMonthly = _prefix "BiMonthly"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BiQuarterly"></see>
    /// </summary>
    let BiQuarterly = _prefix "BiQuarterly"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BiWeekly"></see>
    /// </summary>
    let BiWeekly = _prefix "BiWeekly"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CC-SHAREALIKE_3PT0-US"></see>
    /// </summary>
    let ``CC-SHAREALIKE_3PT0-US`` = _prefix "CC-SHAREALIKE_3PT0-US"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#LicenseModel"></see>
    /// </summary>
    let LicenseModel = _prefix "LicenseModel"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCPH_CommercialUse"></see>
    /// </summary>
    let CCPH_CommercialUse = _prefix "CCPH_CommercialUse"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsProhibition"></see>
    /// </summary>
    let CreativeCommonsProhibition = _prefix "CreativeCommonsProhibition"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCPH_HighIncomeNationUse"></see>
    /// </summary>
    let CCPH_HighIncomeNationUse = _prefix "CCPH_HighIncomeNationUse"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_DerivativeWorks"></see>
    /// </summary>
    let CCP_DerivativeWorks = _prefix "CCP_DerivativeWorks"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsPermission"></see>
    /// </summary>
    let CreativeCommonsPermission = _prefix "CreativeCommonsPermission"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_Distribution"></see>
    /// </summary>
    let CCP_Distribution = _prefix "CCP_Distribution"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_Reproduction"></see>
    /// </summary>
    let CCP_Reproduction = _prefix "CCP_Reproduction"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_Sharing"></see>
    /// </summary>
    let CCP_Sharing = _prefix "CCP_Sharing"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_Attribution"></see>
    /// </summary>
    let CCR_Attribution = _prefix "CCR_Attribution"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsRequirement"></see>
    /// </summary>
    let CreativeCommonsRequirement = _prefix "CreativeCommonsRequirement"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_Copyleft"></see>
    /// </summary>
    let CCR_Copyleft = _prefix "CCR_Copyleft"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_LesserCopyleft"></see>
    /// </summary>
    let CCR_LesserCopyleft = _prefix "CCR_LesserCopyleft"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_Notice"></see>
    /// </summary>
    let CCR_Notice = _prefix "CCR_Notice"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_ShareAlike"></see>
    /// </summary>
    let CCR_ShareAlike = _prefix "CCR_ShareAlike"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_SourceCode"></see>
    /// </summary>
    let CCR_SourceCode = _prefix "CCR_SourceCode"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_None"></see>
    /// </summary>
    let CL_None = _prefix "CL_None"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ConfidentialityLevel"></see>
    /// </summary>
    let ConfidentialityLevel = _prefix "ConfidentialityLevel"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_Restricted"></see>
    /// </summary>
    let CL_Restricted = _prefix "CL_Restricted"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_Secret"></see>
    /// </summary>
    let CL_Secret = _prefix "CL_Secret"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_SensitiveButUnclassified"></see>
    /// </summary>
    let CL_SensitiveButUnclassified = _prefix "CL_SensitiveButUnclassified"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_TopSecret"></see>
    /// </summary>
    let CL_TopSecret = _prefix "CL_TopSecret"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_Unclassified"></see>
    /// </summary>
    let CL_Unclassified = _prefix "CL_Unclassified"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Catalog"></see>
    /// </summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#EnumeratedValue"></see>
    /// </summary>
    let EnumeratedValue = _prefix "EnumeratedValue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Never"></see>
    /// </summary>
    let Never = _prefix "Never"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Daily"></see>
    /// </summary>
    let Daily = _prefix "Daily"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Weekly"></see>
    /// </summary>
    let Weekly = _prefix "Weekly"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Monthly"></see>
    /// </summary>
    let Monthly = _prefix "Monthly"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Quarterly"></see>
    /// </summary>
    let Quarterly = _prefix "Quarterly"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#UncertainFrequency"></see>
    /// </summary>
    let UncertainFrequency = _prefix "UncertainFrequency"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ChangeManagementProcess"></see>
    /// </summary>
    let ChangeManagementProcess = _prefix "ChangeManagementProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ClosedIssue"></see>
    /// </summary>
    let ClosedIssue = _prefix "ClosedIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ConcurrenceEvent"></see>
    /// </summary>
    let ConcurrenceEvent = _prefix "ConcurrenceEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NonConcurrenceEvent"></see>
    /// </summary>
    let NonConcurrenceEvent = _prefix "NonConcurrenceEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsJurisdiction"></see>
    /// </summary>
    let CreativeCommonsJurisdiction = _prefix "CreativeCommonsJurisdiction"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsWork"></see>
    /// </summary>
    let CreativeCommonsWork = _prefix "CreativeCommonsWork"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DTYPE-CatalogEntry"></see>
    /// </summary>
    let ``DTYPE-CatalogEntry`` = _prefix "DTYPE-CatalogEntry"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#SchemaGraph"></see>
    /// </summary>
    let SchemaGraph = _prefix "SchemaGraph"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DeferredIssue"></see>
    /// </summary>
    let DeferredIssue = _prefix "DeferredIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DeletionEvent"></see>
    /// </summary>
    let DeletionEvent = _prefix "DeletionEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DesignatedGovernanceRole"></see>
    /// </summary>
    let DesignatedGovernanceRole = _prefix "DesignatedGovernanceRole"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceRole"></see>
    /// </summary>
    let GovernanceRole = _prefix "GovernanceRole"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#performedBy"></see>
    /// </summary>
    let performedBy = _prefix "performedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DisapprovedIssue"></see>
    /// </summary>
    let DisapprovedIssue = _prefix "DisapprovedIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Document"></see>
    /// </summary>
    let Document = _prefix "Document"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DocumentationChange"></see>
    /// </summary>
    let DocumentationChange = _prefix "DocumentationChange"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#EarlyAdoption"></see>
    /// </summary>
    let EarlyAdoption = _prefix "EarlyAdoption"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Maturity"></see>
    /// </summary>
    let Maturity = _prefix "Maturity"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Party"></see>
    /// </summary>
    let Party = _prefix "Party"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#instigatedBy"></see>
    /// </summary>
    let instigatedBy = _prefix "instigatedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#eventDate"></see>
    /// </summary>
    let eventDate = _prefix "eventDate"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Experimental"></see>
    /// </summary>
    let Experimental = _prefix "Experimental"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Figure"></see>
    /// </summary>
    let Figure = _prefix "Figure"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#imageMap"></see>
    /// </summary>
    let imageMap = _prefix "imageMap"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GR_Authorizer"></see>
    /// </summary>
    let GR_Authorizer = _prefix "GR_Authorizer"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GR_Steward"></see>
    /// </summary>
    let GR_Steward = _prefix "GR_Steward"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GR_Submitter"></see>
    /// </summary>
    let GR_Submitter = _prefix "GR_Submitter"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Governance"></see>
    /// </summary>
    let Governance = _prefix "Governance"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#supercedes"></see>
    /// </summary>
    let supercedes = _prefix "supercedes"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasProtocol"></see>
    /// </summary>
    let hasProtocol = _prefix "hasProtocol"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasNormativeDocument"></see>
    /// </summary>
    let hasNormativeDocument = _prefix "hasNormativeDocument"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasOwner"></see>
    /// </summary>
    let hasOwner = _prefix "hasOwner"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasApprovalStatus"></see>
    /// </summary>
    let hasApprovalStatus = _prefix "hasApprovalStatus"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasConfidentiality"></see>
    /// </summary>
    let hasConfidentiality = _prefix "hasConfidentiality"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceEvent"></see>
    /// </summary>
    let GovernanceEvent = _prefix "GovernanceEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasGovernanceEvent"></see>
    /// </summary>
    let hasGovernanceEvent = _prefix "hasGovernanceEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceProtocol"></see>
    /// </summary>
    let GovernanceProtocol = _prefix "GovernanceProtocol"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isITAR"></see>
    /// </summary>
    let isITAR = _prefix "isITAR"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasAnticipatedChangeType"></see>
    /// </summary>
    let hasAnticipatedChangeType = _prefix "hasAnticipatedChangeType"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasReferenceDocument"></see>
    /// </summary>
    let hasReferenceDocument = _prefix "hasReferenceDocument"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasApplicableDocument"></see>
    /// </summary>
    let hasApplicableDocument = _prefix "hasApplicableDocument"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#frequencyOfChange"></see>
    /// </summary>
    let frequencyOfChange = _prefix "frequencyOfChange"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Issue"></see>
    /// </summary>
    let Issue = _prefix "Issue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasIssue"></see>
    /// </summary>
    let hasIssue = _prefix "hasIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isFOSS"></see>
    /// </summary>
    let isFOSS = _prefix "isFOSS"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Process"></see>
    /// </summary>
    let Process = _prefix "Process"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#IssueResolutionProcess"></see>
    /// </summary>
    let IssueResolutionProcess = _prefix "IssueResolutionProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasIssueResolutionProcess"></see>
    /// </summary>
    let hasIssueResolutionProcess = _prefix "hasIssueResolutionProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#StakeholderGroup"></see>
    /// </summary>
    let StakeholderGroup = _prefix "StakeholderGroup"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isInterestOf"></see>
    /// </summary>
    let isInterestOf = _prefix "isInterestOf"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Organization"></see>
    /// </summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isGovernedBy"></see>
    /// </summary>
    let isGovernedBy = _prefix "isGovernedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasChangeManagementProcess"></see>
    /// </summary>
    let hasChangeManagementProcess = _prefix "hasChangeManagementProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#reviewedBy"></see>
    /// </summary>
    let reviewedBy = _prefix "reviewedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasApprovalProcess"></see>
    /// </summary>
    let hasApprovalProcess = _prefix "hasApprovalProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isApprovedBy"></see>
    /// </summary>
    let isApprovedBy = _prefix "isApprovedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#mayNeedConcurrenceFrom"></see>
    /// </summary>
    let mayNeedConcurrenceFrom = _prefix "mayNeedConcurrenceFrom"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasProcess"></see>
    /// </summary>
    let hasProcess = _prefix "hasProcess"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasProvenance"></see>
    /// </summary>
    let hasProvenance = _prefix "hasProvenance"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasGovernance"></see>
    /// </summary>
    let hasGovernance = _prefix "hasGovernance"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Provenance"></see>
    /// </summary>
    let Provenance = _prefix "Provenance"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#normativeURL"></see>
    /// </summary>
    let normativeURL = _prefix "normativeURL"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#documentedAt"></see>
    /// </summary>
    let documentedAt = _prefix "documentedAt"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernedService"></see>
    /// </summary>
    let GovernedService = _prefix "GovernedService"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Graph"></see>
    /// </summary>
    let Graph = _prefix "Graph"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ProductLogo"></see>
    /// </summary>
    let ProductLogo = _prefix "ProductLogo"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#urlOfRDFfile"></see>
    /// </summary>
    let urlOfRDFfile = _prefix "urlOfRDFfile"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#curatedGraphURI"></see>
    /// </summary>
    let curatedGraphURI = _prefix "curatedGraphURI"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#urlOfTurtleFile"></see>
    /// </summary>
    let urlOfTurtleFile = _prefix "urlOfTurtleFile"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#downloads"></see>
    /// </summary>
    let downloads = _prefix "downloads"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#attributionText"></see>
    /// </summary>
    let attributionText = _prefix "attributionText"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Icon"></see>
    /// </summary>
    let Icon = _prefix "Icon"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#image"></see>
    /// </summary>
    let image = _prefix "image"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#caption"></see>
    /// </summary>
    let caption = _prefix "caption"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#height"></see>
    /// </summary>
    let height = _prefix "height"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#width"></see>
    /// </summary>
    let width = _prefix "width"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#InDevelopment"></see>
    /// </summary>
    let InDevelopment = _prefix "InDevelopment"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#priority"></see>
    /// </summary>
    let priority = _prefix "priority"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PriorityValue"></see>
    /// </summary>
    let PriorityValue = _prefix "PriorityValue"
    /// <summary>
    /// used to connect to the text describing disposition of something, for example, a disposition of an issue
    /// <see href="http://voag.linkedmodel.org/voag#disposition"></see></summary>
    let disposition = _prefix "disposition"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#userID"></see>
    /// </summary>
    let userID = _prefix "userID"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasStatus"></see>
    /// </summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BoardDispositionStatus"></see>
    /// </summary>
    let BoardDispositionStatus = _prefix "BoardDispositionStatus"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#dispositionStatus"></see>
    /// </summary>
    let dispositionStatus = _prefix "dispositionStatus"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#compatibleWith"></see>
    /// </summary>
    let compatibleWith = _prefix "compatibleWith"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#incompatibleWith"></see>
    /// </summary>
    let incompatibleWith = _prefix "incompatibleWith"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#derivedFrom"></see>
    /// </summary>
    let derivedFrom = _prefix "derivedFrom"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#LinkedModelLogo-200x80"></see>
    /// </summary>
    let ``LinkedModelLogo-200x80`` = _prefix "LinkedModelLogo-200x80"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#WidelyAdopted"></see>
    /// </summary>
    let WidelyAdopted = _prefix "WidelyAdopted"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#SomeAdoption"></see>
    /// </summary>
    let SomeAdoption = _prefix "SomeAdoption"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Proposed"></see>
    /// </summary>
    let Proposed = _prefix "Proposed"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#UnknownMaturity"></see>
    /// </summary>
    let UnknownMaturity = _prefix "UnknownMaturity"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ModificationChange"></see>
    /// </summary>
    let ModificationChange = _prefix "ModificationChange"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoAttributionSpecified"></see>
    /// </summary>
    let NoAttributionSpecified = _prefix "NoAttributionSpecified"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoGovernanceSpecified"></see>
    /// </summary>
    let NoGovernanceSpecified = _prefix "NoGovernanceSpecified"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoPedigreeSpecified"></see>
    /// </summary>
    let NoPedigreeSpecified = _prefix "NoPedigreeSpecified"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Pedigree"></see>
    /// </summary>
    let Pedigree = _prefix "Pedigree"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoProvenanceSpecified"></see>
    /// </summary>
    let NoProvenanceSpecified = _prefix "NoProvenanceSpecified"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NonIssue"></see>
    /// </summary>
    let NonIssue = _prefix "NonIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#OpenIssue"></see>
    /// </summary>
    let OpenIssue = _prefix "OpenIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#OrganizationLogo"></see>
    /// </summary>
    let OrganizationLogo = _prefix "OrganizationLogo"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Draft"></see>
    /// </summary>
    let PS_Draft = _prefix "PS_Draft"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PublicationStatus"></see>
    /// </summary>
    let PublicationStatus = _prefix "PublicationStatus"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Final"></see>
    /// </summary>
    let PS_Final = _prefix "PS_Final"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Interim"></see>
    /// </summary>
    let PS_Interim = _prefix "PS_Interim"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Obsolete"></see>
    /// </summary>
    let PS_Obsolete = _prefix "PS_Obsolete"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Review"></see>
    /// </summary>
    let PS_Review = _prefix "PS_Review"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Unknown"></see>
    /// </summary>
    let PS_Unknown = _prefix "PS_Unknown"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_HighPriority"></see>
    /// </summary>
    let PV_HighPriority = _prefix "PV_HighPriority"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_LowPriority"></see>
    /// </summary>
    let PV_LowPriority = _prefix "PV_LowPriority"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_MediumPriority"></see>
    /// </summary>
    let PV_MediumPriority = _prefix "PV_MediumPriority"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_NotApplicable"></see>
    /// </summary>
    let PV_NotApplicable = _prefix "PV_NotApplicable"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_ToBeDetermined"></see>
    /// </summary>
    let PV_ToBeDetermined = _prefix "PV_ToBeDetermined"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#usedBy"></see>
    /// </summary>
    let usedBy = _prefix "usedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#usage"></see>
    /// </summary>
    let usage = _prefix "usage"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasAccredidation"></see>
    /// </summary>
    let hasAccredidation = _prefix "hasAccredidation"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasMaturity"></see>
    /// </summary>
    let hasMaturity = _prefix "hasMaturity"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#supercededBy"></see>
    /// </summary>
    let supercededBy = _prefix "supercededBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasChangeType"></see>
    /// </summary>
    let hasChangeType = _prefix "hasChangeType"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasPedigree"></see>
    /// </summary>
    let hasPedigree = _prefix "hasPedigree"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RDFIcon-32X35"></see>
    /// </summary>
    let ``RDFIcon-32X35`` = _prefix "RDFIcon-32X35"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RefactoringChange"></see>
    /// </summary>
    let RefactoringChange = _prefix "RefactoringChange"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ResolvedIssue"></see>
    /// </summary>
    let ResolvedIssue = _prefix "ResolvedIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RetreivalEvent"></see>
    /// </summary>
    let RetreivalEvent = _prefix "RetreivalEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ReviewEvent"></see>
    /// </summary>
    let ReviewEvent = _prefix "ReviewEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#SPARQLIcon-80X15"></see>
    /// </summary>
    let ``SPARQLIcon-80X15`` = _prefix "SPARQLIcon-80X15"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasStakeholder"></see>
    /// </summary>
    let hasStakeholder = _prefix "hasStakeholder"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Standard"></see>
    /// </summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#TopQuadrantLogo-613x150"></see>
    /// </summary>
    let ``TopQuadrantLogo-613x150`` = _prefix "TopQuadrantLogo-613x150"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#TurtleIcon-32bX35"></see>
    /// </summary>
    let ``TurtleIcon-32bX35`` = _prefix "TurtleIcon-32bX35"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VAEM-CatalogEntry"></see>
    /// </summary>
    let ``VAEM-CatalogEntry`` = _prefix "VAEM-CatalogEntry"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VAEM-XINA-CatalogEntry"></see>
    /// </summary>
    let ``VAEM-XINA-CatalogEntry`` = _prefix "VAEM-XINA-CatalogEntry"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VOAG-OntologyLogo_360x110"></see>
    /// </summary>
    let ``VOAG-OntologyLogo_360x110`` = _prefix "VOAG-OntologyLogo_360x110"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VocabGraph"></see>
    /// </summary>
    let VocabGraph = _prefix "VocabGraph"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#accountableFor"></see>
    /// </summary>
    let accountableFor = _prefix "accountableFor"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#approves"></see>
    /// </summary>
    let approves = _prefix "approves"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#governs"></see>
    /// </summary>
    let governs = _prefix "governs"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#deprecated"></see>
    /// </summary>
    let deprecated = _prefix "deprecated"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#exclude"></see>
    /// </summary>
    let exclude = _prefix "exclude"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#givesConcurrenceFor"></see>
    /// </summary>
    let givesConcurrenceFor = _prefix "givesConcurrenceFor"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasCategory"></see>
    /// </summary>
    let hasCategory = _prefix "hasCategory"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasIdentifier"></see>
    /// </summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasOntologyArchitectureDiagram"></see>
    /// </summary>
    let hasOntologyArchitectureDiagram = _prefix "hasOntologyArchitectureDiagram"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasSteward"></see>
    /// </summary>
    let hasSteward = _prefix "hasSteward"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#instigatingEvent"></see>
    /// </summary>
    let instigatingEvent = _prefix "instigatingEvent"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#interestIn"></see>
    /// </summary>
    let interestIn = _prefix "interestIn"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#jurisdiction"></see>
    /// </summary>
    let jurisdiction = _prefix "jurisdiction"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#legalcode"></see>
    /// </summary>
    let legalcode = _prefix "legalcode"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#licence"></see>
    /// </summary>
    let licence = _prefix "licence"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#morePermissions"></see>
    /// </summary>
    let morePermissions = _prefix "morePermissions"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#normativeReference"></see>
    /// </summary>
    let normativeReference = _prefix "normativeReference"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#obsoletedBy"></see>
    /// </summary>
    let obsoletedBy = _prefix "obsoletedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ownedBy"></see>
    /// </summary>
    let ownedBy = _prefix "ownedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#owns"></see>
    /// </summary>
    let owns = _prefix "owns"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#participant"></see>
    /// </summary>
    let participant = _prefix "participant"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#permits"></see>
    /// </summary>
    let permits = _prefix "permits"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#preparedBy"></see>
    /// </summary>
    let preparedBy = _prefix "preparedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#prohibits"></see>
    /// </summary>
    let prohibits = _prefix "prohibits"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#proprietary"></see>
    /// </summary>
    let proprietary = _prefix "proprietary"
    /// <summary>
    /// This property connects two issue events. Issues connected by this property must be about the same subject
    /// <see href="http://voag.linkedmodel.org/voag#relatedIssue"></see></summary>
    let relatedIssue = _prefix "relatedIssue"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#relatedTo"></see>
    /// </summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#releaseDate"></see>
    /// </summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#requires"></see>
    /// </summary>
    let requires = _prefix "requires"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#reviews"></see>
    /// </summary>
    let reviews = _prefix "reviews"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#rights"></see>
    /// </summary>
    let rights = _prefix "rights"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#submittedBy"></see>
    /// </summary>
    let submittedBy = _prefix "submittedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#supervisedBy"></see>
    /// </summary>
    let supervisedBy = _prefix "supervisedBy"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#timestamp"></see>
    /// </summary>
    let timestamp = _prefix "timestamp"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#urlForHTML"></see>
    /// </summary>
    let urlForHTML = _prefix "urlForHTML"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#useGuidelines"></see>
    /// </summary>
    let useGuidelines = _prefix "useGuidelines"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#witnessTo"></see>
    /// </summary>
    let witnessTo = _prefix "witnessTo"
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#witnessedBy"></see>
    /// </summary>
    let witnessedBy = _prefix "witnessedBy"
