#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module voag =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://voag.linkedmodel.org/voag#" "voag"

    /// <summary>
    ///   <para>rdfs:label : Accredidation^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Accredidation">voag:Accredidation</a>
    /// </summary>
    let Accredidation = _prefixId.prefix "Accredidation"
    /// <summary>
    ///   <para>dce:description : An event that is associated with the admistration aspect of governance. Typically these are curation events.^^xsd:string</para>
    ///   <para>rdfs:label : Administrative Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#AdministrativeEvent">voag:AdministrativeEvent</a>
    /// </summary>
    let AdministrativeEvent = _prefixId.prefix "AdministrativeEvent"
    let Annually = _prefixId.prefix "Annually"
    let AppendChange = _prefixId.prefix "AppendChange"
    /// <summary>
    ///   <para>vaem:description : A "Governance Event".^^xsd:string</para>
    ///   <para>rdfs:label : Approval Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ApprovalEvent">voag:ApprovalEvent</a>
    /// </summary>
    let ApprovalEvent = _prefixId.prefix "ApprovalEvent"
    /// <summary>
    ///   <para>vaem:description : A "Governance Process".^^xsd:string</para>
    ///   <para>rdfs:label : Approval Process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ApprovalProcess">voag:ApprovalProcess</a>
    /// </summary>
    let ApprovalProcess = _prefixId.prefix "ApprovalProcess"
    let ApprovedIssue = _prefixId.prefix "ApprovedIssue"
    /// <summary>
    ///   <para>rdfs:label : Assigned role^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#AssignedRole">voag:AssignedRole</a>
    /// </summary>
    let AssignedRole = _prefixId.prefix "AssignedRole"
    /// <summary>
    ///   <para>dce:description : An 'Attribution' specifies how credit should be given when citing the creators of a piece of work. Attribution must use the specified attribution text and optionally use logos that are provided in the attribution details below., with the names of points of contact.^^xsd:stringdce:description : The name, url and other details of an attribution.^^xsd:string</para>
    ///   <para>rdfs:label : Attributed Source^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Attribution">voag:Attribution</a>
    /// </summary>
    let Attribution = _prefixId.prefix "Attribution"
    /// <summary>
    ///   <para>rdfs:label : Attribution logo^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#AttributionLogo">voag:AttributionLogo</a>
    /// </summary>
    let AttributionLogo = _prefixId.prefix "AttributionLogo"
    let BiMonthly = _prefixId.prefix "BiMonthly"
    let BiQuarterly = _prefixId.prefix "BiQuarterly"
    let BiWeekly = _prefixId.prefix "BiWeekly"
    let BoardDispositionStatus = _prefixId.prefix "BoardDispositionStatus"
    let CC_SHAREALIKE_3PT0_US = _prefixId.prefix "CC-SHAREALIKE_3PT0-US"
    let CCPH_CommercialUse = _prefixId.prefix "CCPH_CommercialUse"
    let CCPH_HighIncomeNationUse = _prefixId.prefix "CCPH_HighIncomeNationUse"
    let CCP_DerivativeWorks = _prefixId.prefix "CCP_DerivativeWorks"
    let CCP_Distribution = _prefixId.prefix "CCP_Distribution"
    let CCP_Reproduction = _prefixId.prefix "CCP_Reproduction"
    let CCP_Sharing = _prefixId.prefix "CCP_Sharing"
    let CCR_Attribution = _prefixId.prefix "CCR_Attribution"
    let CCR_Copyleft = _prefixId.prefix "CCR_Copyleft"
    let CCR_LesserCopyleft = _prefixId.prefix "CCR_LesserCopyleft"
    let CCR_Notice = _prefixId.prefix "CCR_Notice"
    let CCR_ShareAlike = _prefixId.prefix "CCR_ShareAlike"
    let CCR_SourceCode = _prefixId.prefix "CCR_SourceCode"
    let CL_None = _prefixId.prefix "CL_None"
    let CL_Restricted = _prefixId.prefix "CL_Restricted"
    let CL_Secret = _prefixId.prefix "CL_Secret"
    let CL_SensitiveButUnclassified = _prefixId.prefix "CL_SensitiveButUnclassified"
    let CL_TopSecret = _prefixId.prefix "CL_TopSecret"
    let CL_Unclassified = _prefixId.prefix "CL_Unclassified"
    /// <summary>
    ///   <para>vaem:description : An index to a set of resources^^xsd:string</para>
    ///   <para>rdfs:label : Catalog^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Catalog">voag:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:label : Change frequency^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ChangeFrequency">voag:ChangeFrequency</a>
    /// </summary>
    let ChangeFrequency = _prefixId.prefix "ChangeFrequency"
    /// <summary>
    ///   <para>dce:description : A "Governance Process".^^xsd:string</para>
    ///   <para>rdfs:label : Change Management Process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ChangeManagementProcess">voag:ChangeManagementProcess</a>
    /// </summary>
    let ChangeManagementProcess = _prefixId.prefix "ChangeManagementProcess"
    /// <summary>
    ///   <para>vaem:description : Change Type provides an indicator for how an artifact has or will change in the future. This indicator is important to understanding the stability of an ontology.^^xsd:string</para>
    ///   <para>rdfs:label : Change type^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ChangeType">voag:ChangeType</a>
    /// </summary>
    let ChangeType = _prefixId.prefix "ChangeType"
    let ClosedIssue = _prefixId.prefix "ClosedIssue"
    /// <summary>
    ///   <para>dce:description : A Governance Event.^^xsd:string</para>
    ///   <para>rdfs:label : Concurrence event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ConcurrenceEvent">voag:ConcurrenceEvent</a>
    /// </summary>
    let ConcurrenceEvent = _prefixId.prefix "ConcurrenceEvent"
    /// <summary>
    ///   <para>vaem:description : An enumerated codelist for values thath pertain to the security of a set of resources, or a resource. In 'lmc' an ontology can carry a property to denote its confidentiality.^^xsd:string</para>
    ///   <para>rdfs:label : Confidentiality level^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ConfidentialityLevel">voag:ConfidentialityLevel</a>
    /// </summary>
    let ConfidentialityLevel = _prefixId.prefix "ConfidentialityLevel"
    /// <summary>
    ///   <para>dce:description : the legal jurisdiction of a license</para>
    ///   <para>rdfs:label : Creative Commons Jurisdictionrdfs:label : Creative commons jurisdiction^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#CreativeCommonsJurisdiction">voag:CreativeCommonsJurisdiction</a>
    /// </summary>
    let CreativeCommonsJurisdiction = _prefixId.prefix "CreativeCommonsJurisdiction"
    /// <summary>
    ///   <para>dce:description : An action that may or may not be allowed or desired</para>
    ///   <para>rdfs:label : Creative Commons Permission</para>
    ///   <a href="http://voag.linkedmodel.org/voag#CreativeCommonsPermission">voag:CreativeCommonsPermission</a>
    /// </summary>
    let CreativeCommonsPermission = _prefixId.prefix "CreativeCommonsPermission"
    /// <summary>
    ///   <para>dce:description : something you may be asked not to do</para>
    ///   <para>rdfs:label : Creative Commons Prohibition</para>
    ///   <a href="http://voag.linkedmodel.org/voag#CreativeCommonsProhibition">voag:CreativeCommonsProhibition</a>
    /// </summary>
    let CreativeCommonsProhibition = _prefixId.prefix "CreativeCommonsProhibition"
    /// <summary>
    ///   <para>dce:description : an action that may or may not be requested of you</para>
    ///   <para>vaem:description : An action that may or may not be requested of you</para>
    ///   <para>rdfs:label : Requirement</para>
    ///   <a href="http://voag.linkedmodel.org/voag#CreativeCommonsRequirement">voag:CreativeCommonsRequirement</a>
    /// </summary>
    let CreativeCommonsRequirement = _prefixId.prefix "CreativeCommonsRequirement"
    /// <summary>
    ///   <para>dce:description : A potentially copyrightable work</para>
    ///   <para>rdfs:label : Creative Commons Workrdfs:label : Creative commons work^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#CreativeCommonsWork">voag:CreativeCommonsWork</a>
    /// </summary>
    let CreativeCommonsWork = _prefixId.prefix "CreativeCommonsWork"
    let DTYPE_CatalogEntry = _prefixId.prefix "DTYPE-CatalogEntry"
    let Daily = _prefixId.prefix "Daily"
    let DeferredIssue = _prefixId.prefix "DeferredIssue"
    /// <summary>
    ///   <para>dce:description : A "Archival Event".^^xsd:string</para>
    ///   <para>rdfs:label : Deletion Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#DeletionEvent">voag:DeletionEvent</a>
    /// </summary>
    let DeletionEvent = _prefixId.prefix "DeletionEvent"
    /// <summary>
    ///   <para>dce:description : A "Assigned Role" with the following instance(s): "Assurer", "Project Management", "Resource &amp; Process Policy", "Technical Definitions", "User", "Verifier".^^xsd:string</para>
    ///   <para>rdfs:label : Designated Governance Role^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#DesignatedGovernanceRole">voag:DesignatedGovernanceRole</a>
    /// </summary>
    let DesignatedGovernanceRole = _prefixId.prefix "DesignatedGovernanceRole"
    let DisapprovedIssue = _prefixId.prefix "DisapprovedIssue"
    /// <summary>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Document">voag:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    let DocumentationChange = _prefixId.prefix "DocumentationChange"
    let EarlyAdoption = _prefixId.prefix "EarlyAdoption"
    /// <summary>
    ///   <para>dce:description : The base class in LMC for enumerated values^^xsd:string</para>
    ///   <para>rdfs:label : Metadata Enumerated value^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#EnumeratedValue">voag:EnumeratedValue</a>
    /// </summary>
    let EnumeratedValue = _prefixId.prefix "EnumeratedValue"
    /// <summary>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Event">voag:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let Experimental = _prefixId.prefix "Experimental"
    /// <summary>
    ///   <para>vaem:description : An illustration of some kind.^^xsd:string</para>
    ///   <para>rdfs:label : Figure^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Figure">voag:Figure</a>
    /// </summary>
    let Figure = _prefixId.prefix "Figure"
    let GR_Authorizer = _prefixId.prefix "GR_Authorizer"
    let GR_Steward = _prefixId.prefix "GR_Steward"
    let GR_Submitter = _prefixId.prefix "GR_Submitter"
    /// <summary>
    ///   <para>dce:description : Governance is mainly concerned with how an artifact is provisioned and managed over its lifecycle. Governance also concerns the status tracking and processes that need to exist on information objects and services for a successful initiaitve, mission, program, or project. Such governance needs to outline the relationships between all internal and external groups involved, describe the proper flow of information regarding to all stakeholders, ensure the appropriate review of issues encountered and ensure that required approvals and direction are obtained at each appropriate stage.^^xsd:string</para>
    ///   <para>rdfs:label : Governance^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Governance">voag:Governance</a>
    /// </summary>
    let Governance = _prefixId.prefix "Governance"
    /// <summary>
    ///   <para>dce:description : A "Governance Event".^^xsd:string</para>
    ///   <para>rdfs:label : Governance Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#GovernanceEvent">voag:GovernanceEvent</a>
    /// </summary>
    let GovernanceEvent = _prefixId.prefix "GovernanceEvent"
    /// <summary>
    ///   <para>dce:description : A "Process".^^xsd:string</para>
    ///   <para>rdfs:label : Governance Process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#GovernanceProcess">voag:GovernanceProcess</a>
    /// </summary>
    let GovernanceProcess = _prefixId.prefix "GovernanceProcess"
    /// <summary>
    ///   <para>rdfs:label : Governance Protocol^^xsd:string</para>
    ///   <para>dce:description : Governance is used  to mean the processes that need to exist for a successful initiaitve, mission, program, or project. Such governance needs to outline the relationships between all internal and external groups involved, describe the proper flow of information regarding to all stakeholders, ensure the appropriate review of issues encountered and ensure that required approvals and direction for a 'GovernedEntity' is obtained at each appropriate stage.^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#GovernanceProtocol">voag:GovernanceProtocol</a>
    /// </summary>
    let GovernanceProtocol = _prefixId.prefix "GovernanceProtocol"
    /// <summary>
    ///   <para>dce:description : A "Role" with the following instance(s): "authorizer", "steward", "submitter".^^xsd:string</para>
    ///   <para>rdfs:label : Governance Role^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#GovernanceRole">voag:GovernanceRole</a>
    /// </summary>
    let GovernanceRole = _prefixId.prefix "GovernanceRole"
    /// <summary>
    ///   <para>rdfs:label : Governed Object^^xsd:string</para>
    ///   <para>vaem:description : An abstract class for all governed entities^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#GovernedObject">voag:GovernedObject</a>
    /// </summary>
    let GovernedObject = _prefixId.prefix "GovernedObject"
    /// <summary>
    ///   <para>rdfs:label : Governed service^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#GovernedService">voag:GovernedService</a>
    /// </summary>
    let GovernedService = _prefixId.prefix "GovernedService"
    /// <summary>
    ///   <para>vaem:description : A set of RDF triples in an ontology graph specified according to VOAG.^^xsd:string</para>
    ///   <para>rdfs:label : Graph^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Graph">voag:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>vaem:description : A logo of some kind^^xsd:string</para>
    ///   <para>rdfs:label : Icon^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Icon">voag:Icon</a>
    /// </summary>
    let Icon = _prefixId.prefix "Icon"
    /// <summary>
    ///   <para>vaem:description : Image is a class for figures, pictures, logos, and icons  of various kinds^^xsd:string</para>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Image">voag:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    let InDevelopment = _prefixId.prefix "InDevelopment"
    /// <summary>
    ///   <para>dce:description : captures issues such as raising of an issue related to a particular entity in a registry^^xsd:string</para>
    ///   <para>rdfs:label : Issue^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Issue">voag:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>dce:description : A "Governance Process".^^xsd:string</para>
    ///   <para>rdfs:label : Issue Resolution Process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#IssueResolutionProcess">voag:IssueResolutionProcess</a>
    /// </summary>
    let IssueResolutionProcess = _prefixId.prefix "IssueResolutionProcess"
    /// <summary>
    ///   <para>dce:description : The status of an issue: "Closed", "Deferred", "Non issue", "Open", "Resolved".^^xsd:string</para>
    ///   <para>rdfs:label : Issue Status^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#IssueStatus">voag:IssueStatus</a>
    /// </summary>
    let IssueStatus = _prefixId.prefix "IssueStatus"
    /// <summary>
    ///   <para>rdfs:label : License Model^^xsd:string</para>
    ///   <para>vaem:description : A License Model describes the licensing conditions associated with a software artifact.^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#LicenseModel">voag:LicenseModel</a>
    /// </summary>
    let LicenseModel = _prefixId.prefix "LicenseModel"
    let LinkedModelLogo_200x80 = _prefixId.prefix "LinkedModelLogo-200x80"
    /// <summary>
    ///   <para>vaem:description : Logo is ...^^xsd:string</para>
    ///   <para>rdfs:label : Logo^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Logo">voag:Logo</a>
    /// </summary>
    let Logo = _prefixId.prefix "Logo"
    /// <summary>
    ///   <para>rdfs:label : Maturity^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Maturity">voag:Maturity</a>
    /// </summary>
    let Maturity = _prefixId.prefix "Maturity"
    let ModificationChange = _prefixId.prefix "ModificationChange"
    let Monthly = _prefixId.prefix "Monthly"
    let Never = _prefixId.prefix "Never"
    let NoAttributionSpecified = _prefixId.prefix "NoAttributionSpecified"
    let NoGovernanceSpecified = _prefixId.prefix "NoGovernanceSpecified"
    let NoPedigreeSpecified = _prefixId.prefix "NoPedigreeSpecified"
    let NoProvenanceSpecified = _prefixId.prefix "NoProvenanceSpecified"
    /// <summary>
    ///   <para>dce:description : A "Governance Event".^^xsd:string</para>
    ///   <para>rdfs:label : Non-Concurrence Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#NonConcurrenceEvent">voag:NonConcurrenceEvent</a>
    /// </summary>
    let NonConcurrenceEvent = _prefixId.prefix "NonConcurrenceEvent"
    let NonIssue = _prefixId.prefix "NonIssue"
    let OpenIssue = _prefixId.prefix "OpenIssue"
    /// <summary>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Organization">voag:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>vaem:description : A logo for an organization^^xsd:string</para>
    ///   <para>rdfs:label : Organization logo^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#OrganizationLogo">voag:OrganizationLogo</a>
    /// </summary>
    let OrganizationLogo = _prefixId.prefix "OrganizationLogo"
    let PS_Draft = _prefixId.prefix "PS_Draft"
    let PS_Final = _prefixId.prefix "PS_Final"
    let PS_Interim = _prefixId.prefix "PS_Interim"
    let PS_Obsolete = _prefixId.prefix "PS_Obsolete"
    let PS_Review = _prefixId.prefix "PS_Review"
    let PS_Unknown = _prefixId.prefix "PS_Unknown"
    let PV_HighPriority = _prefixId.prefix "PV_HighPriority"
    let PV_LowPriority = _prefixId.prefix "PV_LowPriority"
    let PV_MediumPriority = _prefixId.prefix "PV_MediumPriority"
    let PV_NotApplicable = _prefixId.prefix "PV_NotApplicable"
    let PV_ToBeDetermined = _prefixId.prefix "PV_ToBeDetermined"
    /// <summary>
    ///   <para>rdfs:label : Party^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Party">voag:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    /// <summary>
    ///   <para>rdfs:label : Pedigree^^xsd:string</para>
    ///   <para>dce:description : The origin or source of something. The primary purpose of provenance is to capture the time, place, and if appropriate the person responsible, for the creation, production or provisioning of some information object.^^xsd:string</para>
    ///   <para>vaem:description : Pedigree captures aspects of an artifact that have to do with maturity, quality, salience, and accredidation.^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Pedigree">voag:Pedigree</a>
    /// </summary>
    let Pedigree = _prefixId.prefix "Pedigree"
    /// <summary>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Person">voag:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Priority value^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#PriorityValue">voag:PriorityValue</a>
    /// </summary>
    let PriorityValue = _prefixId.prefix "PriorityValue"
    /// <summary>
    ///   <para>rdfs:label : Process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Process">voag:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>vaem:description : Product logo is used for products, solutions, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Product logo^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ProductLogo">voag:ProductLogo</a>
    /// </summary>
    let ProductLogo = _prefixId.prefix "ProductLogo"
    let Proposed = _prefixId.prefix "Proposed"
    /// <summary>
    ///   <para>rdfs:label : Provenance^^xsd:string</para>
    ///   <para>dce:description : The origin or source of something. The primary purpose of provenance is to capture the time, place, and if appropriate the person responsible, for the creation, production or provisioning of some information object.^^xsd:string</para>
    ///   <para>vaem:description : Provenance specifies the origin or source of some artifact. The primary purpose of provenance is to capture the time, place, and if appropriate the person responsible, for the creation, production or provisioning of The artifact. Provenance also captures a record of how a version may have been superceded by another version of the artifact.^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Provenance">voag:Provenance</a>
    /// </summary>
    let Provenance = _prefixId.prefix "Provenance"
    /// <summary>
    ///   <para>rdfs:label : Publication Status^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#PublicationStatus">voag:PublicationStatus</a>
    /// </summary>
    let PublicationStatus = _prefixId.prefix "PublicationStatus"
    /// <summary>
    ///   <para>rdfs:label : Qualifier^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Qualifier">voag:Qualifier</a>
    /// </summary>
    let Qualifier = _prefixId.prefix "Qualifier"
    let Quarterly = _prefixId.prefix "Quarterly"
    let RDFIcon_32X35 = _prefixId.prefix "RDFIcon-32X35"
    let RefactoringChange = _prefixId.prefix "RefactoringChange"
    /// <summary>
    ///   <para>dce:description : A "Governance Event".^^xsd:string</para>
    ///   <para>rdfs:label : Rejection Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#RejectionEvent">voag:RejectionEvent</a>
    /// </summary>
    let RejectionEvent = _prefixId.prefix "RejectionEvent"
    let ResolvedIssue = _prefixId.prefix "ResolvedIssue"
    /// <summary>
    ///   <para>dce:description : A "Archival Event".^^xsd:string</para>
    ///   <para>rdfs:label : Retreival Event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#RetreivalEvent">voag:RetreivalEvent</a>
    /// </summary>
    let RetreivalEvent = _prefixId.prefix "RetreivalEvent"
    /// <summary>
    ///   <para>dce:description : A "Governance Event".^^xsd:string</para>
    ///   <para>rdfs:label : Review^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ReviewEvent">voag:ReviewEvent</a>
    /// </summary>
    let ReviewEvent = _prefixId.prefix "ReviewEvent"
    let SPARQLIcon_80X15 = _prefixId.prefix "SPARQLIcon-80X15"
    /// <summary>
    ///   <para>rdfs:label : Schema graph^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#SchemaGraph">voag:SchemaGraph</a>
    /// </summary>
    let SchemaGraph = _prefixId.prefix "SchemaGraph"
    /// <summary>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Service">voag:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    let SomeAdoption = _prefixId.prefix "SomeAdoption"
    /// <summary>
    ///   <para>dce:description : A Stakeholder Group is a party of people who have common interests and concerns.^^xsd:string</para>
    ///   <para>rdfs:label : Stakeholder Group^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#StakeholderGroup">voag:StakeholderGroup</a>
    /// </summary>
    let StakeholderGroup = _prefixId.prefix "StakeholderGroup"
    /// <summary>
    ///   <para>vaem:description : An industry, de facto or de jure standard^^xsd:string</para>
    ///   <para>rdfs:label : Standard^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#Standard">voag:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    let TopQuadrantAttribution = _prefixId.prefix "TopQuadrantAttribution"
    let TopQuadrantLogo_613x150 = _prefixId.prefix "TopQuadrantLogo-613x150"
    let TurtleIcon_32bX35 = _prefixId.prefix "TurtleIcon-32bX35"
    let UncertainFrequency = _prefixId.prefix "UncertainFrequency"
    let UnknownMaturity = _prefixId.prefix "UnknownMaturity"
    let VAEM_CatalogEntry = _prefixId.prefix "VAEM-CatalogEntry"
    let VAEM_XINA_CatalogEntry = _prefixId.prefix "VAEM-XINA-CatalogEntry"
    let VOAG_CatalogEntry = _prefixId.prefix "VOAG-CatalogEntry"
    let VOAG_OntologyLogo_360x110 = _prefixId.prefix "VOAG-OntologyLogo_360x110"
    /// <summary>
    ///   <para>rdfs:label : Vocab graph^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#VocabGraph">voag:VocabGraph</a>
    /// </summary>
    let VocabGraph = _prefixId.prefix "VocabGraph"
    let Weekly = _prefixId.prefix "Weekly"
    let WidelyAdopted = _prefixId.prefix "WidelyAdopted"
    /// <summary>
    ///   <para>dce:description : An object property used in governance that refers a resource to the party that is accountable for it.^^xsd:string</para>
    ///   <para>rdfs:label : accountable for^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#accountableFor">voag:accountableFor</a>
    /// </summary>
    let accountableFor = _prefixId.prefix "accountableFor"
    /// <summary>
    ///   <para>dce:description : An object property that specifies that a party governs the approval of a resource.^^xsd:string</para>
    ///   <para>rdfs:label : approves^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#approves">voag:approves</a>
    /// </summary>
    let approves = _prefixId.prefix "approves"
    /// <summary>
    ///   <para>rdfs:label : attribution text^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#attributionText">voag:attributionText</a>
    /// </summary>
    let attributionText = _prefixId.prefix "attributionText"
    /// <summary>
    ///   <para>dce:description : A short description, typically used on a table or a figure.^^xsd:string</para>
    ///   <para>rdfs:label : caption^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#caption">voag:caption</a>
    /// </summary>
    let caption = _prefixId.prefix "caption"
    /// <summary>
    ///   <para>rdfs:label : compatible with^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#compatibleWith">voag:compatibleWith</a>
    /// </summary>
    let compatibleWith = _prefixId.prefix "compatibleWith"
    /// <summary>
    ///   <para>dce:description : The property 'voag:curatedGraphURI' provides a means to specify the base URI of the specific version of the onotlogy that is being documented.  In each versioned graph the 'vaem:namespace' carries a URI without a version number.^^xsd:string</para>
    ///   <para>rdfs:label : curated graph URI^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#curatedGraphURI">voag:curatedGraphURI</a>
    /// </summary>
    let curatedGraphURI = _prefixId.prefix "curatedGraphURI"
    /// <summary>
    ///   <para>rdfs:label : deprecated on^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#deprecated">voag:deprecated</a>
    /// </summary>
    let deprecated = _prefixId.prefix "deprecated"
    /// <summary>
    ///   <para>rdfs:label : derived from^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#derivedFrom">voag:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    /// <summary>
    ///   <para>rdfs:comment : used to connect to the text describing disposition of something, for example, a disposition of an issue^^xsd:string</para>
    ///   <para>rdfs:label : disposition^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#disposition">voag:disposition</a>
    /// </summary>
    let disposition = _prefixId.prefix "disposition"
    /// <summary>
    ///   <para>dce:description : An object propoert that denotes the state of a governance issue.^^xsd:string</para>
    ///   <para>rdfs:label : disposition status^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#dispositionStatus">voag:dispositionStatus</a>
    /// </summary>
    let dispositionStatus = _prefixId.prefix "dispositionStatus"
    /// <summary>
    ///   <para>dce:description : The property 'vaem:documentedAt' is intended for general use as the name implies.  In some cases the property could have scalar values and in other cases may need to refer to a first class concept that holds more information about a documentation resource.  For this reason, the  type of this property is set as 'rdf:Property' and the property is rangeless.^^xsd:string</para>
    ///   <para>rdfs:label : documented at^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#documentedAt">voag:documentedAt</a>
    /// </summary>
    let documentedAt = _prefixId.prefix "documentedAt"
    /// <summary>
    ///   <para>rdfs:label : downloads^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#downloads">voag:downloads</a>
    /// </summary>
    let downloads = _prefixId.prefix "downloads"
    /// <summary>
    ///   <para>rdfs:label : end date^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#endDate">voag:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : event date^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#eventDate">voag:eventDate</a>
    /// </summary>
    let eventDate = _prefixId.prefix "eventDate"
    /// <summary>
    ///   <para>rdfs:label : exclude^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#exclude">voag:exclude</a>
    /// </summary>
    let exclude = _prefixId.prefix "exclude"
    /// <summary>
    ///   <para>rdfs:label : frequency of change^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#frequencyOfChange">voag:frequencyOfChange</a>
    /// </summary>
    let frequencyOfChange = _prefixId.prefix "frequencyOfChange"
    /// <summary>
    ///   <para>dce:description : An object property that specifies what a party may need to give consent, in the form of agreement, either written or verbally for in the approval of some govenance concern. This is the inverse property of 'mayNeedConcurrenceFrom' and, as such, may be deprecated in the future.^^xsd:string</para>
    ///   <para>rdfs:label : gives concurrence for^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#givesConcurrenceFor">voag:givesConcurrenceFor</a>
    /// </summary>
    let givesConcurrenceFor = _prefixId.prefix "givesConcurrenceFor"
    /// <summary>
    ///   <para>dce:description : A super-property of governance properties: 'approves', 'gives concurrence for', 'reviews' and 'witness to'.^^xsd:string</para>
    ///   <para>rdfs:label : governs^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#governs">voag:governs</a>
    /// </summary>
    let governs = _prefixId.prefix "governs"
    /// <summary>
    ///   <para>rdfs:label : has accredidation^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasAccredidation">voag:hasAccredidation</a>
    /// </summary>
    let hasAccredidation = _prefixId.prefix "hasAccredidation"
    /// <summary>
    ///   <para>rdfs:label : has anticipated change type^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasAnticipatedChangeType">voag:hasAnticipatedChangeType</a>
    /// </summary>
    let hasAnticipatedChangeType = _prefixId.prefix "hasAnticipatedChangeType"
    /// <summary>
    ///   <para>dce:description : A document that is of help to application of the subject matter. Documents include specifications, models, standards, guidelines, handbooks and other special publications.^^xsd:string</para>
    ///   <para>rdfs:label : has applicable document^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasApplicableDocument">voag:hasApplicableDocument</a>
    /// </summary>
    let hasApplicableDocument = _prefixId.prefix "hasApplicableDocument"
    /// <summary>
    ///   <para>dce:description : An object property that specifies a process that is used for approval in a 'Governance Protocol'.^^xsd:string</para>
    ///   <para>rdfs:label : has approval process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasApprovalProcess">voag:hasApprovalProcess</a>
    /// </summary>
    let hasApprovalProcess = _prefixId.prefix "hasApprovalProcess"
    /// <summary>
    ///   <para>dce:description : An object property that referes to an enumerated value that denotes the state of an approval.^^xsd:string</para>
    ///   <para>rdfs:label : has approval status^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasApprovalStatus">voag:hasApprovalStatus</a>
    /// </summary>
    let hasApprovalStatus = _prefixId.prefix "hasApprovalStatus"
    /// <summary>
    ///   <para>rdfs:label : has category^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasCategory">voag:hasCategory</a>
    /// </summary>
    let hasCategory = _prefixId.prefix "hasCategory"
    /// <summary>
    ///   <para>dce:description : An object property that specifies a process that is used for managing change in a 'Governance Protocol'.^^xsd:string</para>
    ///   <para>rdfs:label : has change management process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasChangeManagementProcess">voag:hasChangeManagementProcess</a>
    /// </summary>
    let hasChangeManagementProcess = _prefixId.prefix "hasChangeManagementProcess"
    /// <summary>
    ///   <para>rdfs:label : has change type^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasChangeType">voag:hasChangeType</a>
    /// </summary>
    let hasChangeType = _prefixId.prefix "hasChangeType"
    /// <summary>
    ///   <para>dce:description : An object property that specifies a level of confidentiality. Typicall the range of this property will be 'voag:Confidentiality'.^^xsd:string</para>
    ///   <para>rdfs:label : has confidentiality^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasConfidentiality">voag:hasConfidentiality</a>
    /// </summary>
    let hasConfidentiality = _prefixId.prefix "hasConfidentiality"
    /// <summary>
    ///   <para>rdfs:label : has governance^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasGovernance">voag:hasGovernance</a>
    /// </summary>
    let hasGovernance = _prefixId.prefix "hasGovernance"
    /// <summary>
    ///   <para>dce:description : An event associated with governance processes.^^xsd:string</para>
    ///   <para>rdfs:label : has governance event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasGovernanceEvent">voag:hasGovernanceEvent</a>
    /// </summary>
    let hasGovernanceEvent = _prefixId.prefix "hasGovernanceEvent"
    /// <summary>
    ///   <para>rdfs:label : has identifier^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasIdentifier">voag:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>dce:description : A pointer to an issue that exists on a subject of interest.^^xsd:string</para>
    ///   <para>rdfs:label : has issue^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasIssue">voag:hasIssue</a>
    /// </summary>
    let hasIssue = _prefixId.prefix "hasIssue"
    /// <summary>
    ///   <para>rdfs:label : has issue resolution process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasIssueResolutionProcess">voag:hasIssueResolutionProcess</a>
    /// </summary>
    let hasIssueResolutionProcess = _prefixId.prefix "hasIssueResolutionProcess"
    /// <summary>
    ///   <para>dce:description : A property to reference an image that is used as a logo.^^xsd:string</para>
    ///   <para>rdfs:label : has logo^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasLogo">voag:hasLogo</a>
    /// </summary>
    let hasLogo = _prefixId.prefix "hasLogo"
    /// <summary>
    ///   <para>rdfs:label : has maturity^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasMaturity">voag:hasMaturity</a>
    /// </summary>
    let hasMaturity = _prefixId.prefix "hasMaturity"
    /// <summary>
    ///   <para>rdfs:label : has normative document^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasNormativeDocument">voag:hasNormativeDocument</a>
    /// </summary>
    let hasNormativeDocument = _prefixId.prefix "hasNormativeDocument"

    /// <summary>
    ///   <para>rdfs:label : has ontology architecture diagram^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasOntologyArchitectureDiagram">voag:hasOntologyArchitectureDiagram</a>
    /// </summary>
    let hasOntologyArchitectureDiagram =
        _prefixId.prefix "hasOntologyArchitectureDiagram"

    /// <summary>
    ///   <para>rdfs:label : has owner^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasOwner">voag:hasOwner</a>
    /// </summary>
    let hasOwner = _prefixId.prefix "hasOwner"
    /// <summary>
    ///   <para>dce:description : A reference to a description about the pedigree of something.^^xsd:string</para>
    ///   <para>rdfs:label : has pedigree^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasPedigree">voag:hasPedigree</a>
    /// </summary>
    let hasPedigree = _prefixId.prefix "hasPedigree"
    /// <summary>
    ///   <para>dce:description : A reference to a process description.^^xsd:string</para>
    ///   <para>rdfs:label : has process^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasProcess">voag:hasProcess</a>
    /// </summary>
    let hasProcess = _prefixId.prefix "hasProcess"
    /// <summary>
    ///   <para>dce:description : A pointer to a record that holds governance information for one or more governed entities. Often governance can be shared across entities.^^xsd:string</para>
    ///   <para>rdfs:label : has protocol^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasProtocol">voag:hasProtocol</a>
    /// </summary>
    let hasProtocol = _prefixId.prefix "hasProtocol"
    /// <summary>
    ///   <para>dce:description : A pointer to a provenance record that details the source, version and time of some subject of interest.^^xsd:string</para>
    ///   <para>rdfs:label : has provenance^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasProvenance">voag:hasProvenance</a>
    /// </summary>
    let hasProvenance = _prefixId.prefix "hasProvenance"
    /// <summary>
    ///   <para>rdfs:label : has reference document^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasReferenceDocument">voag:hasReferenceDocument</a>
    /// </summary>
    let hasReferenceDocument = _prefixId.prefix "hasReferenceDocument"
    /// <summary>
    ///   <para>rdfs:label : has stakeholder^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasStakeholder">voag:hasStakeholder</a>
    /// </summary>
    let hasStakeholder = _prefixId.prefix "hasStakeholder"
    /// <summary>
    ///   <para>rdfs:label : has status^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasStatus">voag:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>dce:description : A pointer to the person that is a curator.^^xsd:string</para>
    ///   <para>rdfs:label : has steward^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasSteward">voag:hasSteward</a>
    /// </summary>
    let hasSteward = _prefixId.prefix "hasSteward"
    /// <summary>
    ///   <para>rdfs:label : has value^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#hasValue">voag:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>dce:description : Height is typically used to specify an image's height attribute.^^xsd:string</para>
    ///   <para>rdfs:label : height^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#height">voag:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:label : id^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#id">voag:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>dce:description : The property 'vaem:image' points  to an image using a URL.^^xsd:string</para>
    ///   <para>rdfs:label : image^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#image">voag:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:label : image map^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#imageMap">voag:imageMap</a>
    /// </summary>
    let imageMap = _prefixId.prefix "imageMap"
    /// <summary>
    ///   <para>rdfs:label : incompatible with^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#incompatibleWith">voag:incompatibleWith</a>
    /// </summary>
    let incompatibleWith = _prefixId.prefix "incompatibleWith"
    /// <summary>
    ///   <para>rdfs:label : instigated by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#instigatedBy">voag:instigatedBy</a>
    /// </summary>
    let instigatedBy = _prefixId.prefix "instigatedBy"
    /// <summary>
    ///   <para>rdfs:label : instigating event^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#instigatingEvent">voag:instigatingEvent</a>
    /// </summary>
    let instigatingEvent = _prefixId.prefix "instigatingEvent"
    /// <summary>
    ///   <para>rdfs:label : intent^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#intent">voag:intent</a>
    /// </summary>
    let intent = _prefixId.prefix "intent"
    /// <summary>
    ///   <para>rdfs:label : interest in^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#interestIn">voag:interestIn</a>
    /// </summary>
    let interestIn = _prefixId.prefix "interestIn"
    /// <summary>
    ///   <para>dce:description : References to which parties approve an entity.^^xsd:string</para>
    ///   <para>rdfs:label : is approved by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#isApprovedBy">voag:isApprovedBy</a>
    /// </summary>
    let isApprovedBy = _prefixId.prefix "isApprovedBy"
    /// <summary>
    ///   <para>dce:description : A boolean property to specify whether or not software is free or open source. Free and open-source software (F/OSS, FOSS) or free/libre/open-source software (FLOSS) is software that is liberally licensed to grant the right of users to use, study, change, and improve its design through the availability of its source code.^^xsd:string</para>
    ///   <para>rdfs:label : is FOSS^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#isFOSS">voag:isFOSS</a>
    /// </summary>
    let isFOSS = _prefixId.prefix "isFOSS"
    /// <summary>
    ///   <para>dce:description : A pointer to who is responsible for the governance of some entity of interest. This is a two-way reference with the inverse property 'governs'.^^xsd:string</para>
    ///   <para>rdfs:label : is governed by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#isGovernedBy">voag:isGovernedBy</a>
    /// </summary>
    let isGovernedBy = _prefixId.prefix "isGovernedBy"
    /// <summary>
    ///   <para>dce:description : International Traffic in Arms Regulations (ITAR) is a set of United States government regulations that control the export and import of defense-related articles and services on the United States Munitions List. These regulations implement the provisions of the Arms Export Control Act, and are described in Title 22 (Foreign Relations), Chapter I (Department of State), Subchapter M of the Code of Federal Regulations. The Department of State interprets and enforces ITAR. Its goal is to advance national strategic objectives and U.S. foreign policy via the trade controls. For practical purposes, ITAR regulations dictate that information and material pertaining to defense and military related technologies may only be shared with US Persons unless approval from the Department of State is received or a special exemption is used.^^xsd:string</para>
    ///   <para>rdfs:label : is ITAR^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#isITAR">voag:isITAR</a>
    /// </summary>
    let isITAR = _prefixId.prefix "isITAR"
    /// <summary>
    ///   <para>dce:description : A pointer to parties who have an interest in an entity. This is a two-way reference with the inverse property 'interestIn'.^^xsd:string</para>
    ///   <para>rdfs:label : interest of^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#isInterestOf">voag:isInterestOf</a>
    /// </summary>
    let isInterestOf = _prefixId.prefix "isInterestOf"
    /// <summary>
    ///   <para>rdfs:label : jurisdictionrdfs:label : jurisdiction^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#jurisdiction">voag:jurisdiction</a>
    /// </summary>
    let jurisdiction = _prefixId.prefix "jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : legalcode^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#legalcode">voag:legalcode</a>
    /// </summary>
    let legalcode = _prefixId.prefix "legalcode"
    /// <summary>
    ///   <para>rdfs:label : licence^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#licence">voag:licence</a>
    /// </summary>
    let licence = _prefixId.prefix "licence"
    /// <summary>
    ///   <para>dce:description : An object property that specifies that a party may need to give consent, in the form of agreement, either written or verbally to the approval of some govenance concern.^^xsd:string</para>
    ///   <para>rdfs:label : may need concurrence from^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#mayNeedConcurrenceFrom">voag:mayNeedConcurrenceFrom</a>
    /// </summary>
    let mayNeedConcurrenceFrom = _prefixId.prefix "mayNeedConcurrenceFrom"
    /// <summary>
    ///   <para>rdfs:label : more permissions^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#morePermissions">voag:morePermissions</a>
    /// </summary>
    let morePermissions = _prefixId.prefix "morePermissions"
    /// <summary>
    ///   <para>rdfs:label : normative reference^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#normativeReference">voag:normativeReference</a>
    /// </summary>
    let normativeReference = _prefixId.prefix "normativeReference"
    /// <summary>
    ///   <para>rdfs:label : normative URL^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#normativeURL">voag:normativeURL</a>
    /// </summary>
    let normativeURL = _prefixId.prefix "normativeURL"
    /// <summary>
    ///   <para>rdfs:label : obsoleted by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#obsoletedBy">voag:obsoletedBy</a>
    /// </summary>
    let obsoletedBy = _prefixId.prefix "obsoletedBy"
    /// <summary>
    ///   <para>rdfs:label : owned by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#ownedBy">voag:ownedBy</a>
    /// </summary>
    let ownedBy = _prefixId.prefix "ownedBy"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#owner">voag:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : owns^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#owns">voag:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    /// <summary>
    ///   <para>rdfs:label : participant^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#participant">voag:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>rdfs:label : performed by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#performedBy">voag:performedBy</a>
    /// </summary>
    let performedBy = _prefixId.prefix "performedBy"
    /// <summary>
    ///   <para>rdfs:label : permitsrdfs:label : permits^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#permits">voag:permits</a>
    /// </summary>
    let permits = _prefixId.prefix "permits"
    /// <summary>
    ///   <para>rdfs:label : point of contact^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#pointOfContact">voag:pointOfContact</a>
    /// </summary>
    let pointOfContact = _prefixId.prefix "pointOfContact"
    /// <summary>
    ///   <para>rdfs:label : prepared by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#preparedBy">voag:preparedBy</a>
    /// </summary>
    let preparedBy = _prefixId.prefix "preparedBy"
    /// <summary>
    ///   <para>rdfs:label : priority^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#priority">voag:priority</a>
    /// </summary>
    let priority = _prefixId.prefix "priority"
    /// <summary>
    ///   <para>rdfs:label : prohibitsrdfs:label : prohibits^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#prohibits">voag:prohibits</a>
    /// </summary>
    let prohibits = _prefixId.prefix "prohibits"
    /// <summary>
    ///   <para>dce:description : A boolean flag to indicate if an information asset is propretary.^^xsd:string</para>
    ///   <para>rdfs:label : proprietary^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#proprietary">voag:proprietary</a>
    /// </summary>
    let proprietary = _prefixId.prefix "proprietary"
    /// <summary>
    ///   <para>rdfs:comment : This property connects two issue events. Issues connected by this property must be about the same subject^^xsd:string</para>
    ///   <para>rdfs:label : related issue^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#relatedIssue">voag:relatedIssue</a>
    /// </summary>
    let relatedIssue = _prefixId.prefix "relatedIssue"
    /// <summary>
    ///   <para>rdfs:label : related to^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#relatedTo">voag:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>rdfs:label : release date^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#releaseDate">voag:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>rdfs:label : requiresrdfs:label : requires^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#requires">voag:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>dce:description : References to which parties review a data or information asset.^^xsd:string</para>
    ///   <para>rdfs:label : reviewed by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#reviewedBy">voag:reviewedBy</a>
    /// </summary>
    let reviewedBy = _prefixId.prefix "reviewedBy"
    /// <summary>
    ///   <para>rdfs:label : reviews^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#reviews">voag:reviews</a>
    /// </summary>
    let reviews = _prefixId.prefix "reviews"
    /// <summary>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#rights">voag:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#source">voag:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : start date^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#startDate">voag:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#subject">voag:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : submitted by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#submittedBy">voag:submittedBy</a>
    /// </summary>
    let submittedBy = _prefixId.prefix "submittedBy"
    /// <summary>
    ///   <para>dce:description : A pointer to one or more 'GovernedEntities' that replace this entity.^^xsd:string</para>
    ///   <para>rdfs:label : superceded by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#supercededBy">voag:supercededBy</a>
    /// </summary>
    let supercededBy = _prefixId.prefix "supercededBy"
    /// <summary>
    ///   <para>dce:description : A pointer to one or more 'GovernedEntities' that are replaced by this entity.^^xsd:string</para>
    ///   <para>rdfs:label : supercedes^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#supercedes">voag:supercedes</a>
    /// </summary>
    let supercedes = _prefixId.prefix "supercedes"
    /// <summary>
    ///   <para>rdfs:label : supervised by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#supervisedBy">voag:supervisedBy</a>
    /// </summary>
    let supervisedBy = _prefixId.prefix "supervisedBy"
    /// <summary>
    ///   <para>rdfs:label : timestamp^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#timestamp">voag:timestamp</a>
    /// </summary>
    let timestamp = _prefixId.prefix "timestamp"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#title">voag:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#url">voag:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : url for HTML^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#urlForHTML">voag:urlForHTML</a>
    /// </summary>
    let urlForHTML = _prefixId.prefix "urlForHTML"
    /// <summary>
    ///   <para>dce:description : Used to refer to a an RDF XML representation of an ontology^^xsd:string</para>
    ///   <para>rdfs:label : url address of RDF file^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#urlOfRDFfile">voag:urlOfRDFfile</a>
    /// </summary>
    let urlOfRDFfile = _prefixId.prefix "urlOfRDFfile"
    /// <summary>
    ///   <para>dce:description : Used to refer to a Turtle (N3) representation of an ontology^^xsd:string</para>
    ///   <para>rdfs:label : url of turtle file^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#urlOfTurtleFile">voag:urlOfTurtleFile</a>
    /// </summary>
    let urlOfTurtleFile = _prefixId.prefix "urlOfTurtleFile"
    /// <summary>
    ///   <para>rdfs:label : usage^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#usage">voag:usage</a>
    /// </summary>
    let usage = _prefixId.prefix "usage"
    /// <summary>
    ///   <para>rdfs:label : use guidelines^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#useGuidelines">voag:useGuidelines</a>
    /// </summary>
    let useGuidelines = _prefixId.prefix "useGuidelines"
    /// <summary>
    ///   <para>dce:description : The property 'usedBy' is a general property to record a dependency. One use is in stating how a schema or a vocabulary is used by another ontology graph.^^xsd:string</para>
    ///   <para>rdfs:label : used by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#usedBy">voag:usedBy</a>
    /// </summary>
    let usedBy = _prefixId.prefix "usedBy"
    /// <summary>
    ///   <para>rdfs:label : user ID^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#userID">voag:userID</a>
    /// </summary>
    let userID = _prefixId.prefix "userID"
    /// <summary>
    ///   <para>dce:description : Width is typically used to specify an image's width attribute.^^xsd:string</para>
    ///   <para>rdfs:label : width^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#width">voag:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:label : witness to^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#witnessTo">voag:witnessTo</a>
    /// </summary>
    let witnessTo = _prefixId.prefix "witnessTo"
    /// <summary>
    ///   <para>rdfs:label : wintnessed by^^xsd:string</para>
    ///   <a href="http://voag.linkedmodel.org/voag#witnessedBy">voag:witnessedBy</a>
    /// </summary>
    let witnessedBy = _prefixId.prefix "witnessedBy"
