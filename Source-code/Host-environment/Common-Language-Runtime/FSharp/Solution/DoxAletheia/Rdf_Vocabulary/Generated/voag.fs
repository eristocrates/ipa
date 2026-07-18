namespace http.voag.linkedmodel.org.voag.hash

open DoxAletheia.Rdf_Vocabulary

module voag =
    let _namespace_name = "http://voag.linkedmodel.org/voag#"

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernedObject"></see>
    /// </summary>
    let GovernedObject =
        Namespaced_IRI.parse _namespace_name "GovernedObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#intent"></see>
    /// </summary>
    let intent = Namespaced_IRI.parse _namespace_name "intent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VOAG-CatalogEntry"></see>
    /// </summary>
    let ``VOAG-CatalogEntry`` =
        Namespaced_IRI.parse _namespace_name "VOAG-CatalogEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#TopQuadrantAttribution"></see>
    /// </summary>
    let TopQuadrantAttribution =
        Namespaced_IRI.parse _namespace_name "TopQuadrantAttribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Accredidation"></see>
    /// </summary>
    let Accredidation =
        Namespaced_IRI.parse _namespace_name "Accredidation" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Qualifier"></see>
    /// </summary>
    let Qualifier = Namespaced_IRI.parse _namespace_name "Qualifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AdministrativeEvent"></see>
    /// </summary>
    let AdministrativeEvent =
        Namespaced_IRI.parse _namespace_name "AdministrativeEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Annually"></see>
    /// </summary>
    let Annually = Namespaced_IRI.parse _namespace_name "Annually" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ChangeFrequency"></see>
    /// </summary>
    let ChangeFrequency =
        Namespaced_IRI.parse _namespace_name "ChangeFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AppendChange"></see>
    /// </summary>
    let AppendChange =
        Namespaced_IRI.parse _namespace_name "AppendChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ChangeType"></see>
    /// </summary>
    let ChangeType = Namespaced_IRI.parse _namespace_name "ChangeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ApprovalEvent"></see>
    /// </summary>
    let ApprovalEvent =
        Namespaced_IRI.parse _namespace_name "ApprovalEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RejectionEvent"></see>
    /// </summary>
    let RejectionEvent =
        Namespaced_IRI.parse _namespace_name "RejectionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ApprovalProcess"></see>
    /// </summary>
    let ApprovalProcess =
        Namespaced_IRI.parse _namespace_name "ApprovalProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceProcess"></see>
    /// </summary>
    let GovernanceProcess =
        Namespaced_IRI.parse _namespace_name "GovernanceProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ApprovedIssue"></see>
    /// </summary>
    let ApprovedIssue =
        Namespaced_IRI.parse _namespace_name "ApprovedIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#IssueStatus"></see>
    /// </summary>
    let IssueStatus =
        Namespaced_IRI.parse _namespace_name "IssueStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AssignedRole"></see>
    /// </summary>
    let AssignedRole =
        Namespaced_IRI.parse _namespace_name "AssignedRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Attribution"></see>
    /// </summary>
    let Attribution =
        Namespaced_IRI.parse _namespace_name "Attribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#pointOfContact"></see>
    /// </summary>
    let pointOfContact =
        Namespaced_IRI.parse _namespace_name "pointOfContact" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasLogo"></see>
    /// </summary>
    let hasLogo = Namespaced_IRI.parse _namespace_name "hasLogo" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#AttributionLogo"></see>
    /// </summary>
    let AttributionLogo =
        Namespaced_IRI.parse _namespace_name "AttributionLogo" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#url"></see>
    /// </summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Logo"></see>
    /// </summary>
    let Logo = Namespaced_IRI.parse _namespace_name "Logo" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BiMonthly"></see>
    /// </summary>
    let BiMonthly = Namespaced_IRI.parse _namespace_name "BiMonthly" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BiQuarterly"></see>
    /// </summary>
    let BiQuarterly =
        Namespaced_IRI.parse _namespace_name "BiQuarterly" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BiWeekly"></see>
    /// </summary>
    let BiWeekly = Namespaced_IRI.parse _namespace_name "BiWeekly" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CC-SHAREALIKE_3PT0-US"></see>
    /// </summary>
    let ``CC-SHAREALIKE_3PT0-US`` =
        Namespaced_IRI.parse _namespace_name "CC-SHAREALIKE_3PT0-US" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#LicenseModel"></see>
    /// </summary>
    let LicenseModel =
        Namespaced_IRI.parse _namespace_name "LicenseModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCPH_CommercialUse"></see>
    /// </summary>
    let CCPH_CommercialUse =
        Namespaced_IRI.parse _namespace_name "CCPH_CommercialUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsProhibition"></see>
    /// </summary>
    let CreativeCommonsProhibition =
        Namespaced_IRI.parse _namespace_name "CreativeCommonsProhibition" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCPH_HighIncomeNationUse"></see>
    /// </summary>
    let CCPH_HighIncomeNationUse =
        Namespaced_IRI.parse _namespace_name "CCPH_HighIncomeNationUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_DerivativeWorks"></see>
    /// </summary>
    let CCP_DerivativeWorks =
        Namespaced_IRI.parse _namespace_name "CCP_DerivativeWorks" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsPermission"></see>
    /// </summary>
    let CreativeCommonsPermission =
        Namespaced_IRI.parse _namespace_name "CreativeCommonsPermission" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_Distribution"></see>
    /// </summary>
    let CCP_Distribution =
        Namespaced_IRI.parse _namespace_name "CCP_Distribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_Reproduction"></see>
    /// </summary>
    let CCP_Reproduction =
        Namespaced_IRI.parse _namespace_name "CCP_Reproduction" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCP_Sharing"></see>
    /// </summary>
    let CCP_Sharing =
        Namespaced_IRI.parse _namespace_name "CCP_Sharing" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_Attribution"></see>
    /// </summary>
    let CCR_Attribution =
        Namespaced_IRI.parse _namespace_name "CCR_Attribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsRequirement"></see>
    /// </summary>
    let CreativeCommonsRequirement =
        Namespaced_IRI.parse _namespace_name "CreativeCommonsRequirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_Copyleft"></see>
    /// </summary>
    let CCR_Copyleft =
        Namespaced_IRI.parse _namespace_name "CCR_Copyleft" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_LesserCopyleft"></see>
    /// </summary>
    let CCR_LesserCopyleft =
        Namespaced_IRI.parse _namespace_name "CCR_LesserCopyleft" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_Notice"></see>
    /// </summary>
    let CCR_Notice = Namespaced_IRI.parse _namespace_name "CCR_Notice" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_ShareAlike"></see>
    /// </summary>
    let CCR_ShareAlike =
        Namespaced_IRI.parse _namespace_name "CCR_ShareAlike" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CCR_SourceCode"></see>
    /// </summary>
    let CCR_SourceCode =
        Namespaced_IRI.parse _namespace_name "CCR_SourceCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_None"></see>
    /// </summary>
    let CL_None = Namespaced_IRI.parse _namespace_name "CL_None" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ConfidentialityLevel"></see>
    /// </summary>
    let ConfidentialityLevel =
        Namespaced_IRI.parse _namespace_name "ConfidentialityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_Restricted"></see>
    /// </summary>
    let CL_Restricted =
        Namespaced_IRI.parse _namespace_name "CL_Restricted" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_Secret"></see>
    /// </summary>
    let CL_Secret = Namespaced_IRI.parse _namespace_name "CL_Secret" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_SensitiveButUnclassified"></see>
    /// </summary>
    let CL_SensitiveButUnclassified =
        Namespaced_IRI.parse _namespace_name "CL_SensitiveButUnclassified" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_TopSecret"></see>
    /// </summary>
    let CL_TopSecret =
        Namespaced_IRI.parse _namespace_name "CL_TopSecret" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CL_Unclassified"></see>
    /// </summary>
    let CL_Unclassified =
        Namespaced_IRI.parse _namespace_name "CL_Unclassified" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Catalog"></see>
    /// </summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#EnumeratedValue"></see>
    /// </summary>
    let EnumeratedValue =
        Namespaced_IRI.parse _namespace_name "EnumeratedValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Never"></see>
    /// </summary>
    let Never = Namespaced_IRI.parse _namespace_name "Never" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Daily"></see>
    /// </summary>
    let Daily = Namespaced_IRI.parse _namespace_name "Daily" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Weekly"></see>
    /// </summary>
    let Weekly = Namespaced_IRI.parse _namespace_name "Weekly" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Monthly"></see>
    /// </summary>
    let Monthly = Namespaced_IRI.parse _namespace_name "Monthly" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Quarterly"></see>
    /// </summary>
    let Quarterly = Namespaced_IRI.parse _namespace_name "Quarterly" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#UncertainFrequency"></see>
    /// </summary>
    let UncertainFrequency =
        Namespaced_IRI.parse _namespace_name "UncertainFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ChangeManagementProcess"></see>
    /// </summary>
    let ChangeManagementProcess =
        Namespaced_IRI.parse _namespace_name "ChangeManagementProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ClosedIssue"></see>
    /// </summary>
    let ClosedIssue =
        Namespaced_IRI.parse _namespace_name "ClosedIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ConcurrenceEvent"></see>
    /// </summary>
    let ConcurrenceEvent =
        Namespaced_IRI.parse _namespace_name "ConcurrenceEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NonConcurrenceEvent"></see>
    /// </summary>
    let NonConcurrenceEvent =
        Namespaced_IRI.parse _namespace_name "NonConcurrenceEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsJurisdiction"></see>
    /// </summary>
    let CreativeCommonsJurisdiction =
        Namespaced_IRI.parse _namespace_name "CreativeCommonsJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#CreativeCommonsWork"></see>
    /// </summary>
    let CreativeCommonsWork =
        Namespaced_IRI.parse _namespace_name "CreativeCommonsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DTYPE-CatalogEntry"></see>
    /// </summary>
    let ``DTYPE-CatalogEntry`` =
        Namespaced_IRI.parse _namespace_name "DTYPE-CatalogEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#SchemaGraph"></see>
    /// </summary>
    let SchemaGraph =
        Namespaced_IRI.parse _namespace_name "SchemaGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DeferredIssue"></see>
    /// </summary>
    let DeferredIssue =
        Namespaced_IRI.parse _namespace_name "DeferredIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DeletionEvent"></see>
    /// </summary>
    let DeletionEvent =
        Namespaced_IRI.parse _namespace_name "DeletionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DesignatedGovernanceRole"></see>
    /// </summary>
    let DesignatedGovernanceRole =
        Namespaced_IRI.parse _namespace_name "DesignatedGovernanceRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceRole"></see>
    /// </summary>
    let GovernanceRole =
        Namespaced_IRI.parse _namespace_name "GovernanceRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#performedBy"></see>
    /// </summary>
    let performedBy =
        Namespaced_IRI.parse _namespace_name "performedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DisapprovedIssue"></see>
    /// </summary>
    let DisapprovedIssue =
        Namespaced_IRI.parse _namespace_name "DisapprovedIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Document"></see>
    /// </summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#DocumentationChange"></see>
    /// </summary>
    let DocumentationChange =
        Namespaced_IRI.parse _namespace_name "DocumentationChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#EarlyAdoption"></see>
    /// </summary>
    let EarlyAdoption =
        Namespaced_IRI.parse _namespace_name "EarlyAdoption" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Maturity"></see>
    /// </summary>
    let Maturity = Namespaced_IRI.parse _namespace_name "Maturity" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#startDate"></see>
    /// </summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Party"></see>
    /// </summary>
    let Party = Namespaced_IRI.parse _namespace_name "Party" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#instigatedBy"></see>
    /// </summary>
    let instigatedBy =
        Namespaced_IRI.parse _namespace_name "instigatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#eventDate"></see>
    /// </summary>
    let eventDate = Namespaced_IRI.parse _namespace_name "eventDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Experimental"></see>
    /// </summary>
    let Experimental =
        Namespaced_IRI.parse _namespace_name "Experimental" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Figure"></see>
    /// </summary>
    let Figure = Namespaced_IRI.parse _namespace_name "Figure" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#imageMap"></see>
    /// </summary>
    let imageMap = Namespaced_IRI.parse _namespace_name "imageMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GR_Authorizer"></see>
    /// </summary>
    let GR_Authorizer =
        Namespaced_IRI.parse _namespace_name "GR_Authorizer" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GR_Steward"></see>
    /// </summary>
    let GR_Steward = Namespaced_IRI.parse _namespace_name "GR_Steward" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GR_Submitter"></see>
    /// </summary>
    let GR_Submitter =
        Namespaced_IRI.parse _namespace_name "GR_Submitter" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Governance"></see>
    /// </summary>
    let Governance = Namespaced_IRI.parse _namespace_name "Governance" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#supercedes"></see>
    /// </summary>
    let supercedes = Namespaced_IRI.parse _namespace_name "supercedes" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasProtocol"></see>
    /// </summary>
    let hasProtocol =
        Namespaced_IRI.parse _namespace_name "hasProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasNormativeDocument"></see>
    /// </summary>
    let hasNormativeDocument =
        Namespaced_IRI.parse _namespace_name "hasNormativeDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasOwner"></see>
    /// </summary>
    let hasOwner = Namespaced_IRI.parse _namespace_name "hasOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasApprovalStatus"></see>
    /// </summary>
    let hasApprovalStatus =
        Namespaced_IRI.parse _namespace_name "hasApprovalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasConfidentiality"></see>
    /// </summary>
    let hasConfidentiality =
        Namespaced_IRI.parse _namespace_name "hasConfidentiality" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceEvent"></see>
    /// </summary>
    let GovernanceEvent =
        Namespaced_IRI.parse _namespace_name "GovernanceEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasGovernanceEvent"></see>
    /// </summary>
    let hasGovernanceEvent =
        Namespaced_IRI.parse _namespace_name "hasGovernanceEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernanceProtocol"></see>
    /// </summary>
    let GovernanceProtocol =
        Namespaced_IRI.parse _namespace_name "GovernanceProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isITAR"></see>
    /// </summary>
    let isITAR = Namespaced_IRI.parse _namespace_name "isITAR" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasAnticipatedChangeType"></see>
    /// </summary>
    let hasAnticipatedChangeType =
        Namespaced_IRI.parse _namespace_name "hasAnticipatedChangeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasReferenceDocument"></see>
    /// </summary>
    let hasReferenceDocument =
        Namespaced_IRI.parse _namespace_name "hasReferenceDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasApplicableDocument"></see>
    /// </summary>
    let hasApplicableDocument =
        Namespaced_IRI.parse _namespace_name "hasApplicableDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#frequencyOfChange"></see>
    /// </summary>
    let frequencyOfChange =
        Namespaced_IRI.parse _namespace_name "frequencyOfChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Issue"></see>
    /// </summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasIssue"></see>
    /// </summary>
    let hasIssue = Namespaced_IRI.parse _namespace_name "hasIssue" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isFOSS"></see>
    /// </summary>
    let isFOSS = Namespaced_IRI.parse _namespace_name "isFOSS" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Process"></see>
    /// </summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#IssueResolutionProcess"></see>
    /// </summary>
    let IssueResolutionProcess =
        Namespaced_IRI.parse _namespace_name "IssueResolutionProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasIssueResolutionProcess"></see>
    /// </summary>
    let hasIssueResolutionProcess =
        Namespaced_IRI.parse _namespace_name "hasIssueResolutionProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#StakeholderGroup"></see>
    /// </summary>
    let StakeholderGroup =
        Namespaced_IRI.parse _namespace_name "StakeholderGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isInterestOf"></see>
    /// </summary>
    let isInterestOf =
        Namespaced_IRI.parse _namespace_name "isInterestOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Organization"></see>
    /// </summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isGovernedBy"></see>
    /// </summary>
    let isGovernedBy =
        Namespaced_IRI.parse _namespace_name "isGovernedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasChangeManagementProcess"></see>
    /// </summary>
    let hasChangeManagementProcess =
        Namespaced_IRI.parse _namespace_name "hasChangeManagementProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#reviewedBy"></see>
    /// </summary>
    let reviewedBy = Namespaced_IRI.parse _namespace_name "reviewedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasApprovalProcess"></see>
    /// </summary>
    let hasApprovalProcess =
        Namespaced_IRI.parse _namespace_name "hasApprovalProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#isApprovedBy"></see>
    /// </summary>
    let isApprovedBy =
        Namespaced_IRI.parse _namespace_name "isApprovedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#mayNeedConcurrenceFrom"></see>
    /// </summary>
    let mayNeedConcurrenceFrom =
        Namespaced_IRI.parse _namespace_name "mayNeedConcurrenceFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasProcess"></see>
    /// </summary>
    let hasProcess = Namespaced_IRI.parse _namespace_name "hasProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasProvenance"></see>
    /// </summary>
    let hasProvenance =
        Namespaced_IRI.parse _namespace_name "hasProvenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasGovernance"></see>
    /// </summary>
    let hasGovernance =
        Namespaced_IRI.parse _namespace_name "hasGovernance" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Provenance"></see>
    /// </summary>
    let Provenance = Namespaced_IRI.parse _namespace_name "Provenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#normativeURL"></see>
    /// </summary>
    let normativeURL =
        Namespaced_IRI.parse _namespace_name "normativeURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#documentedAt"></see>
    /// </summary>
    let documentedAt =
        Namespaced_IRI.parse _namespace_name "documentedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#GovernedService"></see>
    /// </summary>
    let GovernedService =
        Namespaced_IRI.parse _namespace_name "GovernedService" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Graph"></see>
    /// </summary>
    let Graph = Namespaced_IRI.parse _namespace_name "Graph" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ProductLogo"></see>
    /// </summary>
    let ProductLogo =
        Namespaced_IRI.parse _namespace_name "ProductLogo" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#urlOfRDFfile"></see>
    /// </summary>
    let urlOfRDFfile =
        Namespaced_IRI.parse _namespace_name "urlOfRDFfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#curatedGraphURI"></see>
    /// </summary>
    let curatedGraphURI =
        Namespaced_IRI.parse _namespace_name "curatedGraphURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#urlOfTurtleFile"></see>
    /// </summary>
    let urlOfTurtleFile =
        Namespaced_IRI.parse _namespace_name "urlOfTurtleFile" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#downloads"></see>
    /// </summary>
    let downloads = Namespaced_IRI.parse _namespace_name "downloads" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#attributionText"></see>
    /// </summary>
    let attributionText =
        Namespaced_IRI.parse _namespace_name "attributionText" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Icon"></see>
    /// </summary>
    let Icon = Namespaced_IRI.parse _namespace_name "Icon" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#image"></see>
    /// </summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#caption"></see>
    /// </summary>
    let caption = Namespaced_IRI.parse _namespace_name "caption" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#height"></see>
    /// </summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#width"></see>
    /// </summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#InDevelopment"></see>
    /// </summary>
    let InDevelopment =
        Namespaced_IRI.parse _namespace_name "InDevelopment" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#priority"></see>
    /// </summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PriorityValue"></see>
    /// </summary>
    let PriorityValue =
        Namespaced_IRI.parse _namespace_name "PriorityValue" |> NamespacedName

    /// <summary>
    /// used to connect to the text describing disposition of something, for example, a disposition of an issue
    /// <see href="http://voag.linkedmodel.org/voag#disposition"></see></summary>
    let disposition =
        Namespaced_IRI.parse _namespace_name "disposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#userID"></see>
    /// </summary>
    let userID = Namespaced_IRI.parse _namespace_name "userID" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasStatus"></see>
    /// </summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#BoardDispositionStatus"></see>
    /// </summary>
    let BoardDispositionStatus =
        Namespaced_IRI.parse _namespace_name "BoardDispositionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#dispositionStatus"></see>
    /// </summary>
    let dispositionStatus =
        Namespaced_IRI.parse _namespace_name "dispositionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#compatibleWith"></see>
    /// </summary>
    let compatibleWith =
        Namespaced_IRI.parse _namespace_name "compatibleWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#incompatibleWith"></see>
    /// </summary>
    let incompatibleWith =
        Namespaced_IRI.parse _namespace_name "incompatibleWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#derivedFrom"></see>
    /// </summary>
    let derivedFrom =
        Namespaced_IRI.parse _namespace_name "derivedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#LinkedModelLogo-200x80"></see>
    /// </summary>
    let ``LinkedModelLogo-200x80`` =
        Namespaced_IRI.parse _namespace_name "LinkedModelLogo-200x80" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#WidelyAdopted"></see>
    /// </summary>
    let WidelyAdopted =
        Namespaced_IRI.parse _namespace_name "WidelyAdopted" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#SomeAdoption"></see>
    /// </summary>
    let SomeAdoption =
        Namespaced_IRI.parse _namespace_name "SomeAdoption" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Proposed"></see>
    /// </summary>
    let Proposed = Namespaced_IRI.parse _namespace_name "Proposed" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#UnknownMaturity"></see>
    /// </summary>
    let UnknownMaturity =
        Namespaced_IRI.parse _namespace_name "UnknownMaturity" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ModificationChange"></see>
    /// </summary>
    let ModificationChange =
        Namespaced_IRI.parse _namespace_name "ModificationChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoAttributionSpecified"></see>
    /// </summary>
    let NoAttributionSpecified =
        Namespaced_IRI.parse _namespace_name "NoAttributionSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoGovernanceSpecified"></see>
    /// </summary>
    let NoGovernanceSpecified =
        Namespaced_IRI.parse _namespace_name "NoGovernanceSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoPedigreeSpecified"></see>
    /// </summary>
    let NoPedigreeSpecified =
        Namespaced_IRI.parse _namespace_name "NoPedigreeSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Pedigree"></see>
    /// </summary>
    let Pedigree = Namespaced_IRI.parse _namespace_name "Pedigree" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NoProvenanceSpecified"></see>
    /// </summary>
    let NoProvenanceSpecified =
        Namespaced_IRI.parse _namespace_name "NoProvenanceSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#NonIssue"></see>
    /// </summary>
    let NonIssue = Namespaced_IRI.parse _namespace_name "NonIssue" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#OpenIssue"></see>
    /// </summary>
    let OpenIssue = Namespaced_IRI.parse _namespace_name "OpenIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#OrganizationLogo"></see>
    /// </summary>
    let OrganizationLogo =
        Namespaced_IRI.parse _namespace_name "OrganizationLogo" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Draft"></see>
    /// </summary>
    let PS_Draft = Namespaced_IRI.parse _namespace_name "PS_Draft" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PublicationStatus"></see>
    /// </summary>
    let PublicationStatus =
        Namespaced_IRI.parse _namespace_name "PublicationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Final"></see>
    /// </summary>
    let PS_Final = Namespaced_IRI.parse _namespace_name "PS_Final" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Interim"></see>
    /// </summary>
    let PS_Interim = Namespaced_IRI.parse _namespace_name "PS_Interim" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Obsolete"></see>
    /// </summary>
    let PS_Obsolete =
        Namespaced_IRI.parse _namespace_name "PS_Obsolete" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Review"></see>
    /// </summary>
    let PS_Review = Namespaced_IRI.parse _namespace_name "PS_Review" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PS_Unknown"></see>
    /// </summary>
    let PS_Unknown = Namespaced_IRI.parse _namespace_name "PS_Unknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_HighPriority"></see>
    /// </summary>
    let PV_HighPriority =
        Namespaced_IRI.parse _namespace_name "PV_HighPriority" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_LowPriority"></see>
    /// </summary>
    let PV_LowPriority =
        Namespaced_IRI.parse _namespace_name "PV_LowPriority" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_MediumPriority"></see>
    /// </summary>
    let PV_MediumPriority =
        Namespaced_IRI.parse _namespace_name "PV_MediumPriority" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_NotApplicable"></see>
    /// </summary>
    let PV_NotApplicable =
        Namespaced_IRI.parse _namespace_name "PV_NotApplicable" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#PV_ToBeDetermined"></see>
    /// </summary>
    let PV_ToBeDetermined =
        Namespaced_IRI.parse _namespace_name "PV_ToBeDetermined" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#usedBy"></see>
    /// </summary>
    let usedBy = Namespaced_IRI.parse _namespace_name "usedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#usage"></see>
    /// </summary>
    let usage = Namespaced_IRI.parse _namespace_name "usage" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasAccredidation"></see>
    /// </summary>
    let hasAccredidation =
        Namespaced_IRI.parse _namespace_name "hasAccredidation" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasMaturity"></see>
    /// </summary>
    let hasMaturity =
        Namespaced_IRI.parse _namespace_name "hasMaturity" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#supercededBy"></see>
    /// </summary>
    let supercededBy =
        Namespaced_IRI.parse _namespace_name "supercededBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasChangeType"></see>
    /// </summary>
    let hasChangeType =
        Namespaced_IRI.parse _namespace_name "hasChangeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasPedigree"></see>
    /// </summary>
    let hasPedigree =
        Namespaced_IRI.parse _namespace_name "hasPedigree" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RDFIcon-32X35"></see>
    /// </summary>
    let ``RDFIcon-32X35`` =
        Namespaced_IRI.parse _namespace_name "RDFIcon-32X35" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RefactoringChange"></see>
    /// </summary>
    let RefactoringChange =
        Namespaced_IRI.parse _namespace_name "RefactoringChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ResolvedIssue"></see>
    /// </summary>
    let ResolvedIssue =
        Namespaced_IRI.parse _namespace_name "ResolvedIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#RetreivalEvent"></see>
    /// </summary>
    let RetreivalEvent =
        Namespaced_IRI.parse _namespace_name "RetreivalEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ReviewEvent"></see>
    /// </summary>
    let ReviewEvent =
        Namespaced_IRI.parse _namespace_name "ReviewEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#SPARQLIcon-80X15"></see>
    /// </summary>
    let ``SPARQLIcon-80X15`` =
        Namespaced_IRI.parse _namespace_name "SPARQLIcon-80X15" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasStakeholder"></see>
    /// </summary>
    let hasStakeholder =
        Namespaced_IRI.parse _namespace_name "hasStakeholder" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#Standard"></see>
    /// </summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#TopQuadrantLogo-613x150"></see>
    /// </summary>
    let ``TopQuadrantLogo-613x150`` =
        Namespaced_IRI.parse _namespace_name "TopQuadrantLogo-613x150" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#TurtleIcon-32bX35"></see>
    /// </summary>
    let ``TurtleIcon-32bX35`` =
        Namespaced_IRI.parse _namespace_name "TurtleIcon-32bX35" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VAEM-CatalogEntry"></see>
    /// </summary>
    let ``VAEM-CatalogEntry`` =
        Namespaced_IRI.parse _namespace_name "VAEM-CatalogEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VAEM-XINA-CatalogEntry"></see>
    /// </summary>
    let ``VAEM-XINA-CatalogEntry`` =
        Namespaced_IRI.parse _namespace_name "VAEM-XINA-CatalogEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VOAG-OntologyLogo_360x110"></see>
    /// </summary>
    let ``VOAG-OntologyLogo_360x110`` =
        Namespaced_IRI.parse _namespace_name "VOAG-OntologyLogo_360x110" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#VocabGraph"></see>
    /// </summary>
    let VocabGraph = Namespaced_IRI.parse _namespace_name "VocabGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#accountableFor"></see>
    /// </summary>
    let accountableFor =
        Namespaced_IRI.parse _namespace_name "accountableFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#approves"></see>
    /// </summary>
    let approves = Namespaced_IRI.parse _namespace_name "approves" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#governs"></see>
    /// </summary>
    let governs = Namespaced_IRI.parse _namespace_name "governs" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#deprecated"></see>
    /// </summary>
    let deprecated = Namespaced_IRI.parse _namespace_name "deprecated" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#exclude"></see>
    /// </summary>
    let exclude = Namespaced_IRI.parse _namespace_name "exclude" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#givesConcurrenceFor"></see>
    /// </summary>
    let givesConcurrenceFor =
        Namespaced_IRI.parse _namespace_name "givesConcurrenceFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasCategory"></see>
    /// </summary>
    let hasCategory =
        Namespaced_IRI.parse _namespace_name "hasCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasIdentifier"></see>
    /// </summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasOntologyArchitectureDiagram"></see>
    /// </summary>
    let hasOntologyArchitectureDiagram =
        Namespaced_IRI.parse _namespace_name "hasOntologyArchitectureDiagram" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasSteward"></see>
    /// </summary>
    let hasSteward = Namespaced_IRI.parse _namespace_name "hasSteward" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#instigatingEvent"></see>
    /// </summary>
    let instigatingEvent =
        Namespaced_IRI.parse _namespace_name "instigatingEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#interestIn"></see>
    /// </summary>
    let interestIn = Namespaced_IRI.parse _namespace_name "interestIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#jurisdiction"></see>
    /// </summary>
    let jurisdiction =
        Namespaced_IRI.parse _namespace_name "jurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#legalcode"></see>
    /// </summary>
    let legalcode = Namespaced_IRI.parse _namespace_name "legalcode" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#licence"></see>
    /// </summary>
    let licence = Namespaced_IRI.parse _namespace_name "licence" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#morePermissions"></see>
    /// </summary>
    let morePermissions =
        Namespaced_IRI.parse _namespace_name "morePermissions" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#normativeReference"></see>
    /// </summary>
    let normativeReference =
        Namespaced_IRI.parse _namespace_name "normativeReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#obsoletedBy"></see>
    /// </summary>
    let obsoletedBy =
        Namespaced_IRI.parse _namespace_name "obsoletedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#ownedBy"></see>
    /// </summary>
    let ownedBy = Namespaced_IRI.parse _namespace_name "ownedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#owns"></see>
    /// </summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#participant"></see>
    /// </summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#permits"></see>
    /// </summary>
    let permits = Namespaced_IRI.parse _namespace_name "permits" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#preparedBy"></see>
    /// </summary>
    let preparedBy = Namespaced_IRI.parse _namespace_name "preparedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#prohibits"></see>
    /// </summary>
    let prohibits = Namespaced_IRI.parse _namespace_name "prohibits" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#proprietary"></see>
    /// </summary>
    let proprietary =
        Namespaced_IRI.parse _namespace_name "proprietary" |> NamespacedName

    /// <summary>
    /// This property connects two issue events. Issues connected by this property must be about the same subject
    /// <see href="http://voag.linkedmodel.org/voag#relatedIssue"></see></summary>
    let relatedIssue =
        Namespaced_IRI.parse _namespace_name "relatedIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#relatedTo"></see>
    /// </summary>
    let relatedTo = Namespaced_IRI.parse _namespace_name "relatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#releaseDate"></see>
    /// </summary>
    let releaseDate =
        Namespaced_IRI.parse _namespace_name "releaseDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#requires"></see>
    /// </summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#reviews"></see>
    /// </summary>
    let reviews = Namespaced_IRI.parse _namespace_name "reviews" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#rights"></see>
    /// </summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#submittedBy"></see>
    /// </summary>
    let submittedBy =
        Namespaced_IRI.parse _namespace_name "submittedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#supervisedBy"></see>
    /// </summary>
    let supervisedBy =
        Namespaced_IRI.parse _namespace_name "supervisedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#timestamp"></see>
    /// </summary>
    let timestamp = Namespaced_IRI.parse _namespace_name "timestamp" |> NamespacedName
    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#urlForHTML"></see>
    /// </summary>
    let urlForHTML = Namespaced_IRI.parse _namespace_name "urlForHTML" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#useGuidelines"></see>
    /// </summary>
    let useGuidelines =
        Namespaced_IRI.parse _namespace_name "useGuidelines" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#witnessTo"></see>
    /// </summary>
    let witnessTo = Namespaced_IRI.parse _namespace_name "witnessTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://voag.linkedmodel.org/voag#witnessedBy"></see>
    /// </summary>
    let witnessedBy =
        Namespaced_IRI.parse _namespace_name "witnessedBy" |> NamespacedName
