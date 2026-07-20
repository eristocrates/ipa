namespace http.w3id.org.nfdi4ing.metadata4ing.hash

open DoxAletheia

module m4i =
    let _namespace_name = "http://w3id.org/nfdi4ing/metadata4ing#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProcessingStep"></see>
    /// </summary>
    let ProcessingStep = _prefix "ProcessingStep"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ContactPerson"></see>
    /// </summary>
    let ContactPerson = _prefix "ContactPerson"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#DataCollector"></see>
    /// </summary>
    let DataCollector = _prefix "DataCollector"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#DataCurator"></see>
    /// </summary>
    let DataCurator = _prefix "DataCurator"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#DataManager"></see>
    /// </summary>
    let DataManager = _prefix "DataManager"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Distributor"></see>
    /// </summary>
    let Distributor = _prefix "Distributor"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Editor"></see>
    /// </summary>
    let Editor = _prefix "Editor"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#HostingInstitution"></see>
    /// </summary>
    let HostingInstitution = _prefix "HostingInstitution"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Method"></see>
    /// </summary>
    let Method = _prefix "Method"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#NumericalAssignment"></see>
    /// </summary>
    let NumericalAssignment = _prefix "NumericalAssignment"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#NumericalVariable"></see>
    /// </summary>
    let NumericalVariable = _prefix "NumericalVariable"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Other"></see>
    /// </summary>
    let Other = _prefix "Other"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Producer"></see>
    /// </summary>
    let Producer = _prefix "Producer"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProjectLeader"></see>
    /// </summary>
    let ProjectLeader = _prefix "ProjectLeader"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProjectManager"></see>
    /// </summary>
    let ProjectManager = _prefix "ProjectManager"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProjectMember"></see>
    /// </summary>
    let ProjectMember = _prefix "ProjectMember"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RegistrationAgency"></see>
    /// </summary>
    let RegistrationAgency = _prefix "RegistrationAgency"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RegistrationAuthority"></see>
    /// </summary>
    let RegistrationAuthority = _prefix "RegistrationAuthority"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RelatedPerson"></see>
    /// </summary>
    let RelatedPerson = _prefix "RelatedPerson"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ResearchGroup"></see>
    /// </summary>
    let ResearchGroup = _prefix "ResearchGroup"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Researcher"></see>
    /// </summary>
    let Researcher = _prefix "Researcher"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RightsHolder"></see>
    /// </summary>
    let RightsHolder = _prefix "RightsHolder"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Sponsor"></see>
    /// </summary>
    let Sponsor = _prefix "Sponsor"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Supervisor"></see>
    /// </summary>
    let Supervisor = _prefix "Supervisor"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#TextVariable"></see>
    /// </summary>
    let TextVariable = _prefix "TextVariable"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Tool"></see>
    /// </summary>
    let Tool = _prefix "Tool"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#UncertaintyDeclaration"></see>
    /// </summary>
    let UncertaintyDeclaration = _prefix "UncertaintyDeclaration"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#UsageInstruction"></see>
    /// </summary>
    let UsageInstruction = _prefix "UsageInstruction"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#WorkPackageLeader"></see>
    /// </summary>
    let WorkPackageLeader = _prefix "WorkPackageLeader"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#endOfProject"></see>
    /// </summary>
    let endOfProject = _prefix "endOfProject"
    /// <summary>
    /// redundant information: applicable unit can be deduced from quantity kind. If one wants to enforce the use of a specific unit, use a SHACL constraint.
    /// <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleUnit"></see></summary>
    let hasAdmissibleUnit = _prefix "hasAdmissibleUnit"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleValue"></see>
    /// </summary>
    let hasAdmissibleValue = _prefix "hasAdmissibleValue"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignedValue"></see>
    /// </summary>
    let hasAssignedValue = _prefix "hasAssignedValue"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignmentTimestamp"></see>
    /// </summary>
    let hasAssignmentTimestamp = _prefix "hasAssignmentTimestamp"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasCoverageInterval"></see>
    /// </summary>
    let hasCoverageInterval = _prefix "hasCoverageInterval"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasUncertaintyDeclaration"></see>
    /// </summary>
    let hasUncertaintyDeclaration = _prefix "hasUncertaintyDeclaration"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentCreated"></see>
    /// </summary>
    let hasDateAssignmentCreated = _prefix "hasDateAssignmentCreated"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentDeleted"></see>
    /// </summary>
    let hasDateAssignmentDeleted = _prefix "hasDateAssignmentDeleted"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentModified"></see>
    /// </summary>
    let hasDateAssignmentModified = _prefix "hasDateAssignmentModified"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidFrom"></see>
    /// </summary>
    let hasDateAssignmentValidFrom = _prefix "hasDateAssignmentValidFrom"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidUntil"></see>
    /// </summary>
    let hasDateAssignmentValidUntil = _prefix "hasDateAssignmentValidUntil"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasEmployedTool"></see>
    /// </summary>
    let hasEmployedTool = _prefix "hasEmployedTool"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#isEmployedToolIn"></see>
    /// </summary>
    let isEmployedToolIn = _prefix "isEmployedToolIn"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasExpandedUnc"></see>
    /// </summary>
    let hasExpandedUnc = _prefix "hasExpandedUnc"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasKindOfQuantity"></see>
    /// </summary>
    let hasKindOfQuantity = _prefix "hasKindOfQuantity"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasMaximumValue"></see>
    /// </summary>
    let hasMaximumValue = _prefix "hasMaximumValue"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasMinimumValue"></see>
    /// </summary>
    let hasMinimumValue = _prefix "hasMinimumValue"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasNumericalValue"></see>
    /// </summary>
    let hasNumericalValue = _prefix "hasNumericalValue"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasParameter"></see>
    /// </summary>
    let hasParameter = _prefix "hasParameter"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasRorId"></see>
    /// </summary>
    let hasRorId = _prefix "hasRorId"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#identifier"></see>
    /// </summary>
    let identifier = _prefix "identifier"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasRuntimeAssignment"></see>
    /// </summary>
    let hasRuntimeAssignment = _prefix "hasRuntimeAssignment"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasStepSize"></see>
    /// </summary>
    let hasStepSize = _prefix "hasStepSize"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasStringValue"></see>
    /// </summary>
    let hasStringValue = _prefix "hasStringValue"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasSymbol"></see>
    /// </summary>
    let hasSymbol = _prefix "hasSymbol"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasUnit"></see>
    /// </summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasVariable"></see>
    /// </summary>
    let hasVariable = _prefix "hasVariable"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasVariableDescription"></see>
    /// </summary>
    let hasVariableDescription = _prefix "hasVariableDescription"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#implementedByTool"></see>
    /// </summary>
    let implementedByTool = _prefix "implementedByTool"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#implementsMethod"></see>
    /// </summary>
    let implementsMethod = _prefix "implementsMethod"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#inProject"></see>
    /// </summary>
    let inProject = _prefix "inProject"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#projectParticipant"></see>
    /// </summary>
    let projectParticipant = _prefix "projectParticipant"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#investigates"></see>
    /// </summary>
    let investigates = _prefix "investigates"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#investigatesProperty"></see>
    /// </summary>
    let investigatesProperty = _prefix "investigatesProperty"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#orcidId"></see>
    /// </summary>
    let orcidId = _prefix "orcidId"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#projectReferenceID"></see>
    /// </summary>
    let projectReferenceID = _prefix "projectReferenceID"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#realizesMethod"></see>
    /// </summary>
    let realizesMethod = _prefix "realizesMethod"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#representsVariable"></see>
    /// </summary>
    let representsVariable = _prefix "representsVariable"
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#startOfProject"></see>
    /// </summary>
    let startOfProject = _prefix "startOfProject"
