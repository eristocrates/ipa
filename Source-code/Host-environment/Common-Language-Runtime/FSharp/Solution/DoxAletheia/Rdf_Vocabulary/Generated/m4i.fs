namespace http.w3id.org.nfdi4ing.metadata4ing.hash

open DoxAletheia.Rdf_Vocabulary

module m4i =
    let _namespace_name = "http://w3id.org/nfdi4ing/metadata4ing#"

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProcessingStep"></see>
    /// </summary>
    let ProcessingStep =
        Namespaced_IRI.parse _namespace_name "ProcessingStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ContactPerson"></see>
    /// </summary>
    let ContactPerson =
        Namespaced_IRI.parse _namespace_name "ContactPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#DataCollector"></see>
    /// </summary>
    let DataCollector =
        Namespaced_IRI.parse _namespace_name "DataCollector" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#DataCurator"></see>
    /// </summary>
    let DataCurator =
        Namespaced_IRI.parse _namespace_name "DataCurator" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#DataManager"></see>
    /// </summary>
    let DataManager =
        Namespaced_IRI.parse _namespace_name "DataManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Distributor"></see>
    /// </summary>
    let Distributor =
        Namespaced_IRI.parse _namespace_name "Distributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Editor"></see>
    /// </summary>
    let Editor = Namespaced_IRI.parse _namespace_name "Editor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#HostingInstitution"></see>
    /// </summary>
    let HostingInstitution =
        Namespaced_IRI.parse _namespace_name "HostingInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Method"></see>
    /// </summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#NumericalAssignment"></see>
    /// </summary>
    let NumericalAssignment =
        Namespaced_IRI.parse _namespace_name "NumericalAssignment" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#NumericalVariable"></see>
    /// </summary>
    let NumericalVariable =
        Namespaced_IRI.parse _namespace_name "NumericalVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Other"></see>
    /// </summary>
    let Other = Namespaced_IRI.parse _namespace_name "Other" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Producer"></see>
    /// </summary>
    let Producer = Namespaced_IRI.parse _namespace_name "Producer" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProjectLeader"></see>
    /// </summary>
    let ProjectLeader =
        Namespaced_IRI.parse _namespace_name "ProjectLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProjectManager"></see>
    /// </summary>
    let ProjectManager =
        Namespaced_IRI.parse _namespace_name "ProjectManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ProjectMember"></see>
    /// </summary>
    let ProjectMember =
        Namespaced_IRI.parse _namespace_name "ProjectMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RegistrationAgency"></see>
    /// </summary>
    let RegistrationAgency =
        Namespaced_IRI.parse _namespace_name "RegistrationAgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RegistrationAuthority"></see>
    /// </summary>
    let RegistrationAuthority =
        Namespaced_IRI.parse _namespace_name "RegistrationAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RelatedPerson"></see>
    /// </summary>
    let RelatedPerson =
        Namespaced_IRI.parse _namespace_name "RelatedPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#ResearchGroup"></see>
    /// </summary>
    let ResearchGroup =
        Namespaced_IRI.parse _namespace_name "ResearchGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Researcher"></see>
    /// </summary>
    let Researcher = Namespaced_IRI.parse _namespace_name "Researcher" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#RightsHolder"></see>
    /// </summary>
    let RightsHolder =
        Namespaced_IRI.parse _namespace_name "RightsHolder" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Sponsor"></see>
    /// </summary>
    let Sponsor = Namespaced_IRI.parse _namespace_name "Sponsor" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Supervisor"></see>
    /// </summary>
    let Supervisor = Namespaced_IRI.parse _namespace_name "Supervisor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#TextVariable"></see>
    /// </summary>
    let TextVariable =
        Namespaced_IRI.parse _namespace_name "TextVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#Tool"></see>
    /// </summary>
    let Tool = Namespaced_IRI.parse _namespace_name "Tool" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#UncertaintyDeclaration"></see>
    /// </summary>
    let UncertaintyDeclaration =
        Namespaced_IRI.parse _namespace_name "UncertaintyDeclaration" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#UsageInstruction"></see>
    /// </summary>
    let UsageInstruction =
        Namespaced_IRI.parse _namespace_name "UsageInstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#WorkPackageLeader"></see>
    /// </summary>
    let WorkPackageLeader =
        Namespaced_IRI.parse _namespace_name "WorkPackageLeader" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#endOfProject"></see>
    /// </summary>
    let endOfProject =
        Namespaced_IRI.parse _namespace_name "endOfProject" |> NamespacedName

    /// <summary>
    /// redundant information: applicable unit can be deduced from quantity kind. If one wants to enforce the use of a specific unit, use a SHACL constraint.
    /// <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleUnit"></see></summary>
    let hasAdmissibleUnit =
        Namespaced_IRI.parse _namespace_name "hasAdmissibleUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleValue"></see>
    /// </summary>
    let hasAdmissibleValue =
        Namespaced_IRI.parse _namespace_name "hasAdmissibleValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignedValue"></see>
    /// </summary>
    let hasAssignedValue =
        Namespaced_IRI.parse _namespace_name "hasAssignedValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignmentTimestamp"></see>
    /// </summary>
    let hasAssignmentTimestamp =
        Namespaced_IRI.parse _namespace_name "hasAssignmentTimestamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasCoverageInterval"></see>
    /// </summary>
    let hasCoverageInterval =
        Namespaced_IRI.parse _namespace_name "hasCoverageInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasUncertaintyDeclaration"></see>
    /// </summary>
    let hasUncertaintyDeclaration =
        Namespaced_IRI.parse _namespace_name "hasUncertaintyDeclaration" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentCreated"></see>
    /// </summary>
    let hasDateAssignmentCreated =
        Namespaced_IRI.parse _namespace_name "hasDateAssignmentCreated" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentDeleted"></see>
    /// </summary>
    let hasDateAssignmentDeleted =
        Namespaced_IRI.parse _namespace_name "hasDateAssignmentDeleted" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentModified"></see>
    /// </summary>
    let hasDateAssignmentModified =
        Namespaced_IRI.parse _namespace_name "hasDateAssignmentModified" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidFrom"></see>
    /// </summary>
    let hasDateAssignmentValidFrom =
        Namespaced_IRI.parse _namespace_name "hasDateAssignmentValidFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidUntil"></see>
    /// </summary>
    let hasDateAssignmentValidUntil =
        Namespaced_IRI.parse _namespace_name "hasDateAssignmentValidUntil" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasEmployedTool"></see>
    /// </summary>
    let hasEmployedTool =
        Namespaced_IRI.parse _namespace_name "hasEmployedTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#isEmployedToolIn"></see>
    /// </summary>
    let isEmployedToolIn =
        Namespaced_IRI.parse _namespace_name "isEmployedToolIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasExpandedUnc"></see>
    /// </summary>
    let hasExpandedUnc =
        Namespaced_IRI.parse _namespace_name "hasExpandedUnc" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasKindOfQuantity"></see>
    /// </summary>
    let hasKindOfQuantity =
        Namespaced_IRI.parse _namespace_name "hasKindOfQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasMaximumValue"></see>
    /// </summary>
    let hasMaximumValue =
        Namespaced_IRI.parse _namespace_name "hasMaximumValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasMinimumValue"></see>
    /// </summary>
    let hasMinimumValue =
        Namespaced_IRI.parse _namespace_name "hasMinimumValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasNumericalValue"></see>
    /// </summary>
    let hasNumericalValue =
        Namespaced_IRI.parse _namespace_name "hasNumericalValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasParameter"></see>
    /// </summary>
    let hasParameter =
        Namespaced_IRI.parse _namespace_name "hasParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasRorId"></see>
    /// </summary>
    let hasRorId = Namespaced_IRI.parse _namespace_name "hasRorId" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#identifier"></see>
    /// </summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasRuntimeAssignment"></see>
    /// </summary>
    let hasRuntimeAssignment =
        Namespaced_IRI.parse _namespace_name "hasRuntimeAssignment" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasStepSize"></see>
    /// </summary>
    let hasStepSize =
        Namespaced_IRI.parse _namespace_name "hasStepSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasStringValue"></see>
    /// </summary>
    let hasStringValue =
        Namespaced_IRI.parse _namespace_name "hasStringValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasSymbol"></see>
    /// </summary>
    let hasSymbol = Namespaced_IRI.parse _namespace_name "hasSymbol" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasUnit"></see>
    /// </summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasVariable"></see>
    /// </summary>
    let hasVariable =
        Namespaced_IRI.parse _namespace_name "hasVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#hasVariableDescription"></see>
    /// </summary>
    let hasVariableDescription =
        Namespaced_IRI.parse _namespace_name "hasVariableDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#implementedByTool"></see>
    /// </summary>
    let implementedByTool =
        Namespaced_IRI.parse _namespace_name "implementedByTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#implementsMethod"></see>
    /// </summary>
    let implementsMethod =
        Namespaced_IRI.parse _namespace_name "implementsMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#inProject"></see>
    /// </summary>
    let inProject = Namespaced_IRI.parse _namespace_name "inProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#projectParticipant"></see>
    /// </summary>
    let projectParticipant =
        Namespaced_IRI.parse _namespace_name "projectParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#investigates"></see>
    /// </summary>
    let investigates =
        Namespaced_IRI.parse _namespace_name "investigates" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#investigatesProperty"></see>
    /// </summary>
    let investigatesProperty =
        Namespaced_IRI.parse _namespace_name "investigatesProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#orcidId"></see>
    /// </summary>
    let orcidId = Namespaced_IRI.parse _namespace_name "orcidId" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#projectReferenceID"></see>
    /// </summary>
    let projectReferenceID =
        Namespaced_IRI.parse _namespace_name "projectReferenceID" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#realizesMethod"></see>
    /// </summary>
    let realizesMethod =
        Namespaced_IRI.parse _namespace_name "realizesMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#representsVariable"></see>
    /// </summary>
    let representsVariable =
        Namespaced_IRI.parse _namespace_name "representsVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/nfdi4ing/metadata4ing#startOfProject"></see>
    /// </summary>
    let startOfProject =
        Namespaced_IRI.parse _namespace_name "startOfProject" |> NamespacedName
