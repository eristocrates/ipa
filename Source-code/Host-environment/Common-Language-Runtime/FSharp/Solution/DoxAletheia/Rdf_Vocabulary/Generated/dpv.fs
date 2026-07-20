namespace https.w3id.org.dpv.hash

open DoxAletheia

module dpv =
    let _namespace_name = "https://w3id.org/dpv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#rights-properties"></see>
    /// </summary>
    let ``rights-properties`` = _prefix "rights-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightExerciseRecord"></see>
    /// </summary>
    let RightExerciseRecord = _prefix "RightExerciseRecord"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightExerciseActivity"></see>
    /// </summary>
    let RightExerciseActivity = _prefix "RightExerciseActivity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#rights-classes"></see>
    /// </summary>
    let ``rights-classes`` = _prefix "rights-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-html"></see>
    /// </summary>
    let ``serialisation-html`` = _prefix "serialisation-html"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-rdf"></see>
    /// </summary>
    let ``serialisation-rdf`` = _prefix "serialisation-rdf"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-jsonld"></see>
    /// </summary>
    let ``serialisation-jsonld`` = _prefix "serialisation-jsonld"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-n3"></see>
    /// </summary>
    let ``serialisation-n3`` = _prefix "serialisation-n3"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-ttl"></see>
    /// </summary>
    let ``serialisation-ttl`` = _prefix "serialisation-ttl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AILiteracy"></see>
    /// </summary>
    let AILiteracy = _prefix "AILiteracy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationalMeasure"></see>
    /// </summary>
    let OrganisationalMeasure = _prefix "OrganisationalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DigitalLiteracy"></see>
    /// </summary>
    let DigitalLiteracy = _prefix "DigitalLiteracy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#organisational-measures-classes"></see>
    /// </summary>
    let ``organisational-measures-classes`` = _prefix "organisational-measures-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AINotice"></see>
    /// </summary>
    let AINotice = _prefix "AINotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Notice"></see>
    /// </summary>
    let Notice = _prefix "Notice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcademicResearch"></see>
    /// </summary>
    let AcademicResearch = _prefix "AcademicResearch"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Purpose"></see>
    /// </summary>
    let Purpose = _prefix "Purpose"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ResearchAndDevelopment"></see>
    /// </summary>
    let ResearchAndDevelopment = _prefix "ResearchAndDevelopment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#purposes-classes"></see>
    /// </summary>
    let ``purposes-classes`` = _prefix "purposes-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcademicScientificOrganisation"></see>
    /// </summary>
    let AcademicScientificOrganisation = _prefix "AcademicScientificOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Organisation"></see>
    /// </summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-organisation-classes"></see>
    /// </summary>
    let ``entities-organisation-classes`` = _prefix "entities-organisation-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcceptContract"></see>
    /// </summary>
    let AcceptContract = _prefix "AcceptContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractControl"></see>
    /// </summary>
    let ContractControl = _prefix "ContractControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-control-classes"></see>
    /// </summary>
    let ``contract-control-classes`` = _prefix "contract-control-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcceptableRule"></see>
    /// </summary>
    let AcceptableRule = _prefix "AcceptableRule"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Rule"></see>
    /// </summary>
    let Rule = _prefix "Rule"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#rules-classes"></see>
    /// </summary>
    let ``rules-classes`` = _prefix "rules-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcceptableUsePolicy"></see>
    /// </summary>
    let AcceptableUsePolicy = _prefix "AcceptableUsePolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Policy"></see>
    /// </summary>
    let Policy = _prefix "Policy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Access"></see>
    /// </summary>
    let Access = _prefix "Access"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Processing"></see>
    /// </summary>
    let Processing = _prefix "Processing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Use"></see>
    /// </summary>
    let Use = _prefix "Use"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-classes"></see>
    /// </summary>
    let ``processing-classes`` = _prefix "processing-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AccessControlMethod"></see>
    /// </summary>
    let AccessControlMethod = _prefix "AccessControlMethod"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalMeasure"></see>
    /// </summary>
    let TechnicalMeasure = _prefix "TechnicalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#technical-measures-classes"></see>
    /// </summary>
    let ``technical-measures-classes`` = _prefix "technical-measures-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AccountManagement"></see>
    /// </summary>
    let AccountManagement = _prefix "AccountManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Acquire"></see>
    /// </summary>
    let Acquire = _prefix "Acquire"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Obtain"></see>
    /// </summary>
    let Obtain = _prefix "Obtain"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActiveRight"></see>
    /// </summary>
    let ActiveRight = _prefix "ActiveRight"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Right"></see>
    /// </summary>
    let Right = _prefix "Right"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivelyInvolved"></see>
    /// </summary>
    let ActivelyInvolved = _prefix "ActivelyInvolved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InvolvementStatus"></see>
    /// </summary>
    let InvolvementStatus = _prefix "InvolvementStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#status-classes"></see>
    /// </summary>
    let ``status-classes`` = _prefix "status-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityCompleted"></see>
    /// </summary>
    let ActivityCompleted = _prefix "ActivityCompleted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityStatus"></see>
    /// </summary>
    let ActivityStatus = _prefix "ActivityStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityHalted"></see>
    /// </summary>
    let ActivityHalted = _prefix "ActivityHalted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityMonitoring"></see>
    /// </summary>
    let ActivityMonitoring = _prefix "ActivityMonitoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityNotCompleted"></see>
    /// </summary>
    let ActivityNotCompleted = _prefix "ActivityNotCompleted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityOngoing"></see>
    /// </summary>
    let ActivityOngoing = _prefix "ActivityOngoing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityPlanned"></see>
    /// </summary>
    let ActivityPlanned = _prefix "ActivityPlanned"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityProposed"></see>
    /// </summary>
    let ActivityProposed = _prefix "ActivityProposed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Status"></see>
    /// </summary>
    let Status = _prefix "Status"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Adapt"></see>
    /// </summary>
    let Adapt = _prefix "Adapt"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Transform"></see>
    /// </summary>
    let Transform = _prefix "Transform"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Adult"></see>
    /// </summary>
    let Adult = _prefix "Adult"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanSubject"></see>
    /// </summary>
    let HumanSubject = _prefix "HumanSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-datasubject-classes"></see>
    /// </summary>
    let ``entities-datasubject-classes`` = _prefix "entities-datasubject-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Advertising"></see>
    /// </summary>
    let Advertising = _prefix "Advertising"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Marketing"></see>
    /// </summary>
    let Marketing = _prefix "Marketing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AgeVerification"></see>
    /// </summary>
    let AgeVerification = _prefix "AgeVerification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Verification"></see>
    /// </summary>
    let Verification = _prefix "Verification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Aggregate"></see>
    /// </summary>
    let Aggregate = _prefix "Aggregate"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Alter"></see>
    /// </summary>
    let Alter = _prefix "Alter"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AlgorithmicLogic"></see>
    /// </summary>
    let AlgorithmicLogic = _prefix "AlgorithmicLogic"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingContext"></see>
    /// </summary>
    let ProcessingContext = _prefix "ProcessingContext"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-context-classes"></see>
    /// </summary>
    let ``processing-context-classes`` = _prefix "processing-context-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Align"></see>
    /// </summary>
    let Align = _prefix "Align"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AmbulanceProvider"></see>
    /// </summary>
    let AmbulanceProvider = _prefix "AmbulanceProvider"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EmergencyServiceProvider"></see>
    /// </summary>
    let EmergencyServiceProvider = _prefix "EmergencyServiceProvider"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Analyse"></see>
    /// </summary>
    let Analyse = _prefix "Analyse"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Anonymisation"></see>
    /// </summary>
    let Anonymisation = _prefix "Anonymisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Deidentification"></see>
    /// </summary>
    let Deidentification = _prefix "Deidentification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Anonymise"></see>
    /// </summary>
    let Anonymise = _prefix "Anonymise"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AnonymisedData"></see>
    /// </summary>
    let AnonymisedData = _prefix "AnonymisedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonPersonalData"></see>
    /// </summary>
    let NonPersonalData = _prefix "NonPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#personal-data-classes"></see>
    /// </summary>
    let ``personal-data-classes`` = _prefix "personal-data-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Applicability"></see>
    /// </summary>
    let Applicability = _prefix "Applicability"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#context-classes"></see>
    /// </summary>
    let ``context-classes`` = _prefix "context-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Applicant"></see>
    /// </summary>
    let Applicant = _prefix "Applicant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ApprovalProcedure"></see>
    /// </summary>
    let ApprovalProcedure = _prefix "ApprovalProcedure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GovernanceProcedures"></see>
    /// </summary>
    let GovernanceProcedures = _prefix "GovernanceProcedures"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Assess"></see>
    /// </summary>
    let Assess = _prefix "Assess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Assessment"></see>
    /// </summary>
    let Assessment = _prefix "Assessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AssetManagementProcedures"></see>
    /// </summary>
    let AssetManagementProcedures = _prefix "AssetManagementProcedures"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AssistiveAutomation"></see>
    /// </summary>
    let AssistiveAutomation = _prefix "AssistiveAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AutomationLevel"></see>
    /// </summary>
    let AutomationLevel = _prefix "AutomationLevel"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AsylumSeeker"></see>
    /// </summary>
    let AsylumSeeker = _prefix "AsylumSeeker"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VulnerableHuman"></see>
    /// </summary>
    let VulnerableHuman = _prefix "VulnerableHuman"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AsymmetricCryptography"></see>
    /// </summary>
    let AsymmetricCryptography = _prefix "AsymmetricCryptography"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CryptographicMethods"></see>
    /// </summary>
    let CryptographicMethods = _prefix "CryptographicMethods"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AsymmetricEncryption"></see>
    /// </summary>
    let AsymmetricEncryption = _prefix "AsymmetricEncryption"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Encryption"></see>
    /// </summary>
    let Encryption = _prefix "Encryption"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Audit"></see>
    /// </summary>
    let Audit = _prefix "Audit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditApproved"></see>
    /// </summary>
    let AuditApproved = _prefix "AuditApproved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditStatus"></see>
    /// </summary>
    let AuditStatus = _prefix "AuditStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditConditionallyApproved"></see>
    /// </summary>
    let AuditConditionallyApproved = _prefix "AuditConditionallyApproved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditNotRequired"></see>
    /// </summary>
    let AuditNotRequired = _prefix "AuditNotRequired"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditRejected"></see>
    /// </summary>
    let AuditRejected = _prefix "AuditRejected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditRequested"></see>
    /// </summary>
    let AuditRequested = _prefix "AuditRequested"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditRequired"></see>
    /// </summary>
    let AuditRequired = _prefix "AuditRequired"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Authentication-ABC"></see>
    /// </summary>
    let ``Authentication-ABC`` = _prefix "Authentication-ABC"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CryptographicAuthentication"></see>
    /// </summary>
    let CryptographicAuthentication = _prefix "CryptographicAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Authentication-PABC"></see>
    /// </summary>
    let ``Authentication-PABC`` = _prefix "Authentication-PABC"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthenticationProtocols"></see>
    /// </summary>
    let AuthenticationProtocols = _prefix "AuthenticationProtocols"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorisationProcedure"></see>
    /// </summary>
    let AuthorisationProcedure = _prefix "AuthorisationProcedure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityProcedure"></see>
    /// </summary>
    let SecurityProcedure = _prefix "SecurityProcedure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorisationProtocols"></see>
    /// </summary>
    let AuthorisationProtocols = _prefix "AuthorisationProtocols"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Authority"></see>
    /// </summary>
    let Authority = _prefix "Authority"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GovernmentalOrganisation"></see>
    /// </summary>
    let GovernmentalOrganisation = _prefix "GovernmentalOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-authority-classes"></see>
    /// </summary>
    let ``entities-authority-classes`` = _prefix "entities-authority-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorityInformed"></see>
    /// </summary>
    let AuthorityInformed = _prefix "AuthorityInformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInformedStatus"></see>
    /// </summary>
    let EntityInformedStatus = _prefix "EntityInformedStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInformed"></see>
    /// </summary>
    let EntityInformed = _prefix "EntityInformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorityUninformed"></see>
    /// </summary>
    let AuthorityUninformed = _prefix "AuthorityUninformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityUninformed"></see>
    /// </summary>
    let EntityUninformed = _prefix "EntityUninformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AutomatedDecisionMaking"></see>
    /// </summary>
    let AutomatedDecisionMaking = _prefix "AutomatedDecisionMaking"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DecisionMaking"></see>
    /// </summary>
    let DecisionMaking = _prefix "DecisionMaking"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#AutomatedScoringOfIndividuals"></see>
    /// </summary>
    let AutomatedScoringOfIndividuals = _prefix "AutomatedScoringOfIndividuals"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ScoringOfIndividuals"></see>
    /// </summary>
    let ScoringOfIndividuals = _prefix "ScoringOfIndividuals"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Autonomous"></see>
    /// </summary>
    let Autonomous = _prefix "Autonomous"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#B2B2CContract"></see>
    /// </summary>
    let B2B2CContract = _prefix "B2B2CContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalBasis"></see>
    /// </summary>
    let LegalBasis = _prefix "LegalBasis"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#B2CContract"></see>
    /// </summary>
    let B2CContract = _prefix "B2CContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#B2BContract"></see>
    /// </summary>
    let B2BContract = _prefix "B2BContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-types-classes"></see>
    /// </summary>
    let ``contract-types-classes`` = _prefix "contract-types-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractByEntityType"></see>
    /// </summary>
    let ContractByEntityType = _prefix "ContractByEntityType"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#BackgroundChecks"></see>
    /// </summary>
    let BackgroundChecks = _prefix "BackgroundChecks"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#BiometricAuthentication"></see>
    /// </summary>
    let BiometricAuthentication = _prefix "BiometricAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#C2BContract"></see>
    /// </summary>
    let C2BContract = _prefix "C2BContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#C2CContract"></see>
    /// </summary>
    let C2CContract = _prefix "C2CContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotChallengeProcess"></see>
    /// </summary>
    let CannotChallengeProcess = _prefix "CannotChallengeProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityNonPermissiveInvolvement"></see>
    /// </summary>
    let EntityNonPermissiveInvolvement = _prefix "EntityNonPermissiveInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotChallengeProcessInput"></see>
    /// </summary>
    let CannotChallengeProcessInput = _prefix "CannotChallengeProcessInput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotChallengeProcessOutput"></see>
    /// </summary>
    let CannotChallengeProcessOutput = _prefix "CannotChallengeProcessOutput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotCorrectProcess"></see>
    /// </summary>
    let CannotCorrectProcess = _prefix "CannotCorrectProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotCorrectProcessInput"></see>
    /// </summary>
    let CannotCorrectProcessInput = _prefix "CannotCorrectProcessInput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotCorrectProcessOutput"></see>
    /// </summary>
    let CannotCorrectProcessOutput = _prefix "CannotCorrectProcessOutput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotObjectToProcess"></see>
    /// </summary>
    let CannotObjectToProcess = _prefix "CannotObjectToProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotOptInToProcess"></see>
    /// </summary>
    let CannotOptInToProcess = _prefix "CannotOptInToProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotOptOutFromProcess"></see>
    /// </summary>
    let CannotOptOutFromProcess = _prefix "CannotOptOutFromProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotReverseProcessEffects"></see>
    /// </summary>
    let CannotReverseProcessEffects = _prefix "CannotReverseProcessEffects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotReverseProcessInput"></see>
    /// </summary>
    let CannotReverseProcessInput = _prefix "CannotReverseProcessInput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotReverseProcessOutput"></see>
    /// </summary>
    let CannotReverseProcessOutput = _prefix "CannotReverseProcessOutput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotWithdrawFromProcess"></see>
    /// </summary>
    let CannotWithdrawFromProcess = _prefix "CannotWithdrawFromProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Certification"></see>
    /// </summary>
    let Certification = _prefix "Certification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CertificationSeal"></see>
    /// </summary>
    let CertificationSeal = _prefix "CertificationSeal"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ChallengingProcess"></see>
    /// </summary>
    let ChallengingProcess = _prefix "ChallengingProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityPermissiveInvolvement"></see>
    /// </summary>
    let EntityPermissiveInvolvement = _prefix "EntityPermissiveInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ChallengingProcessInput"></see>
    /// </summary>
    let ChallengingProcessInput = _prefix "ChallengingProcessInput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ChallengingProcessOutput"></see>
    /// </summary>
    let ChallengingProcessOutput = _prefix "ChallengingProcessOutput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CharityOrganisation"></see>
    /// </summary>
    let CharityOrganisation = _prefix "CharityOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalEntity"></see>
    /// </summary>
    let LegalEntity = _prefix "LegalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Child"></see>
    /// </summary>
    let Child = _prefix "Child"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Citizen"></see>
    /// </summary>
    let Citizen = _prefix "Citizen"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#City"></see>
    /// </summary>
    let City = _prefix "City"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#jurisdiction-classes"></see>
    /// </summary>
    let ``jurisdiction-classes`` = _prefix "jurisdiction-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Client"></see>
    /// </summary>
    let Client = _prefix "Client"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Customer"></see>
    /// </summary>
    let Customer = _prefix "Customer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Clinic"></see>
    /// </summary>
    let Clinic = _prefix "Clinic"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CloudLocation"></see>
    /// </summary>
    let CloudLocation = _prefix "CloudLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RemoteLocation"></see>
    /// </summary>
    let RemoteLocation = _prefix "RemoteLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CodeOfConduct"></see>
    /// </summary>
    let CodeOfConduct = _prefix "CodeOfConduct"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GuidelinesPrinciple"></see>
    /// </summary>
    let GuidelinesPrinciple = _prefix "GuidelinesPrinciple"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Collect"></see>
    /// </summary>
    let Collect = _prefix "Collect"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CollectedData"></see>
    /// </summary>
    let CollectedData = _prefix "CollectedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CollectedPersonalData"></see>
    /// </summary>
    let CollectedPersonalData = _prefix "CollectedPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalData"></see>
    /// </summary>
    let PersonalData = _prefix "PersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CombatClimateChange"></see>
    /// </summary>
    let CombatClimateChange = _prefix "CombatClimateChange"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicBenefit"></see>
    /// </summary>
    let PublicBenefit = _prefix "PublicBenefit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Combine"></see>
    /// </summary>
    let Combine = _prefix "Combine"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommercialPurpose"></see>
    /// </summary>
    let CommercialPurpose = _prefix "CommercialPurpose"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommercialResearch"></see>
    /// </summary>
    let CommercialResearch = _prefix "CommercialResearch"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommerciallyConfidentialData"></see>
    /// </summary>
    let CommerciallyConfidentialData = _prefix "CommerciallyConfidentialData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConfidentialData"></see>
    /// </summary>
    let ConfidentialData = _prefix "ConfidentialData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommunicationForCustomerCare"></see>
    /// </summary>
    let CommunicationForCustomerCare = _prefix "CommunicationForCustomerCare"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommunicationManagement"></see>
    /// </summary>
    let CommunicationManagement = _prefix "CommunicationManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerCare"></see>
    /// </summary>
    let CustomerCare = _prefix "CustomerCare"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CompatibilityUnknown"></see>
    /// </summary>
    let CompatibilityUnknown = _prefix "CompatibilityUnknown"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReuseCompatibility"></see>
    /// </summary>
    let ReuseCompatibility = _prefix "ReuseCompatibility"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceAssessment"></see>
    /// </summary>
    let ComplianceAssessment = _prefix "ComplianceAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceIndeterminate"></see>
    /// </summary>
    let ComplianceIndeterminate = _prefix "ComplianceIndeterminate"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceStatus"></see>
    /// </summary>
    let ComplianceStatus = _prefix "ComplianceStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceMonitoring"></see>
    /// </summary>
    let ComplianceMonitoring = _prefix "ComplianceMonitoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceUnknown"></see>
    /// </summary>
    let ComplianceUnknown = _prefix "ComplianceUnknown"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceViolation"></see>
    /// </summary>
    let ComplianceViolation = _prefix "ComplianceViolation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Compliant"></see>
    /// </summary>
    let Compliant = _prefix "Compliant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConditionalAutomation"></see>
    /// </summary>
    let ConditionalAutomation = _prefix "ConditionalAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConfidentialityAgreement"></see>
    /// </summary>
    let ConfidentialityAgreement = _prefix "ConfidentialityAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalMeasure"></see>
    /// </summary>
    let LegalMeasure = _prefix "LegalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalAgreement"></see>
    /// </summary>
    let LegalAgreement = _prefix "LegalAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-measures-classes"></see>
    /// </summary>
    let ``legal-measures-classes`` = _prefix "legal-measures-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConformanceAssessment"></see>
    /// </summary>
    let ConformanceAssessment = _prefix "ConformanceAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConformanceStatus"></see>
    /// </summary>
    let ConformanceStatus = _prefix "ConformanceStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Conformant"></see>
    /// </summary>
    let Conformant = _prefix "Conformant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consent"></see>
    /// </summary>
    let Consent = _prefix "Consent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-basis-classes"></see>
    /// </summary>
    let ``legal-basis-classes`` = _prefix "legal-basis-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentControl"></see>
    /// </summary>
    let ConsentControl = _prefix "ConsentControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInvolvement"></see>
    /// </summary>
    let EntityInvolvement = _prefix "EntityInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-controls-classes"></see>
    /// </summary>
    let ``consent-controls-classes`` = _prefix "consent-controls-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentExpired"></see>
    /// </summary>
    let ConsentExpired = _prefix "ConsentExpired"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentStatus"></see>
    /// </summary>
    let ConsentStatus = _prefix "ConsentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentStatusInvalidForProcessing"></see>
    /// </summary>
    let ConsentStatusInvalidForProcessing = _prefix "ConsentStatusInvalidForProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-status-classes"></see>
    /// </summary>
    let ``consent-status-classes`` = _prefix "consent-status-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentGiven"></see>
    /// </summary>
    let ConsentGiven = _prefix "ConsentGiven"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentStatusValidForProcessing"></see>
    /// </summary>
    let ConsentStatusValidForProcessing = _prefix "ConsentStatusValidForProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentInvalidated"></see>
    /// </summary>
    let ConsentInvalidated = _prefix "ConsentInvalidated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentManagement"></see>
    /// </summary>
    let ConsentManagement = _prefix "ConsentManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PermissionManagement"></see>
    /// </summary>
    let PermissionManagement = _prefix "PermissionManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentNotice"></see>
    /// </summary>
    let ConsentNotice = _prefix "ConsentNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyNotice"></see>
    /// </summary>
    let PrivacyNotice = _prefix "PrivacyNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#notice-classes"></see>
    /// </summary>
    let ``notice-classes`` = _prefix "notice-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentReceipt"></see>
    /// </summary>
    let ConsentReceipt = _prefix "ConsentReceipt"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRecord"></see>
    /// </summary>
    let ConsentRecord = _prefix "ConsentRecord"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessingRecord"></see>
    /// </summary>
    let DataProcessingRecord = _prefix "DataProcessingRecord"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRefused"></see>
    /// </summary>
    let ConsentRefused = _prefix "ConsentRefused"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRequestDeferred"></see>
    /// </summary>
    let ConsentRequestDeferred = _prefix "ConsentRequestDeferred"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRequested"></see>
    /// </summary>
    let ConsentRequested = _prefix "ConsentRequested"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRevoked"></see>
    /// </summary>
    let ConsentRevoked = _prefix "ConsentRevoked"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentUnknown"></see>
    /// </summary>
    let ConsentUnknown = _prefix "ConsentUnknown"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentWithdrawn"></see>
    /// </summary>
    let ConsentWithdrawn = _prefix "ConsentWithdrawn"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consequence"></see>
    /// </summary>
    let Consequence = _prefix "Consequence"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskConcept"></see>
    /// </summary>
    let RiskConcept = _prefix "RiskConcept"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#risk-classes"></see>
    /// </summary>
    let ``risk-classes`` = _prefix "risk-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsequenceAsSideEffect"></see>
    /// </summary>
    let ConsequenceAsSideEffect = _prefix "ConsequenceAsSideEffect"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsequenceOfFailure"></see>
    /// </summary>
    let ConsequenceOfFailure = _prefix "ConsequenceOfFailure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsequenceOfSuccess"></see>
    /// </summary>
    let ConsequenceOfSuccess = _prefix "ConsequenceOfSuccess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consult"></see>
    /// </summary>
    let Consult = _prefix "Consult"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consultation"></see>
    /// </summary>
    let Consultation = _prefix "Consultation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithAuthority"></see>
    /// </summary>
    let ConsultationWithAuthority = _prefix "ConsultationWithAuthority"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithDPO"></see>
    /// </summary>
    let ConsultationWithDPO = _prefix "ConsultationWithDPO"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithDataSubject"></see>
    /// </summary>
    let ConsultationWithDataSubject = _prefix "ConsultationWithDataSubject"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithDataSubjectRepresentative"></see>
    /// </summary>
    let ConsultationWithDataSubjectRepresentative =
        _prefix "ConsultationWithDataSubjectRepresentative"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consumer"></see>
    /// </summary>
    let Consumer = _prefix "Consumer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsumerStandardFormContract"></see>
    /// </summary>
    let ConsumerStandardFormContract = _prefix "ConsumerStandardFormContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StandardFormContract"></see>
    /// </summary>
    let StandardFormContract = _prefix "StandardFormContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContextuallyAnonymisedData"></see>
    /// </summary>
    let ContextuallyAnonymisedData = _prefix "ContextuallyAnonymisedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PseudonymisedData"></see>
    /// </summary>
    let PseudonymisedData = _prefix "PseudonymisedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContinuousFrequency"></see>
    /// </summary>
    let ContinuousFrequency = _prefix "ContinuousFrequency"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Frequency"></see>
    /// </summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Contract"></see>
    /// </summary>
    let Contract = _prefix "Contract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractActivationStatus"></see>
    /// </summary>
    let ContractActivationStatus = _prefix "ContractActivationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractStatus"></see>
    /// </summary>
    let ContractStatus = _prefix "ContractStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-status-classes"></see>
    /// </summary>
    let ``contract-status-classes`` = _prefix "contract-status-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractActive"></see>
    /// </summary>
    let ContractActive = _prefix "ContractActive"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractAmended"></see>
    /// </summary>
    let ContractAmended = _prefix "ContractAmended"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPerformanceStatus"></see>
    /// </summary>
    let ContractPerformanceStatus = _prefix "ContractPerformanceStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractAmendmentClause"></see>
    /// </summary>
    let ContractAmendmentClause = _prefix "ContractAmendmentClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClause"></see>
    /// </summary>
    let ContractualClause = _prefix "ContractualClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-clause-classes"></see>
    /// </summary>
    let ``contract-clause-classes`` = _prefix "contract-clause-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractApproved"></see>
    /// </summary>
    let ContractApproved = _prefix "ContractApproved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPreparationStatus"></see>
    /// </summary>
    let ContractPreparationStatus = _prefix "ContractPreparationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractBeingPerformed"></see>
    /// </summary>
    let ContractBeingPerformed = _prefix "ContractBeingPerformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractBreached"></see>
    /// </summary>
    let ContractBreached = _prefix "ContractBreached"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTerminationStatus"></see>
    /// </summary>
    let ContractTerminationStatus = _prefix "ContractTerminationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractByDomain"></see>
    /// </summary>
    let ContractByDomain = _prefix "ContractByDomain"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractByNegotiationType"></see>
    /// </summary>
    let ContractByNegotiationType = _prefix "ContractByNegotiationType"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractConfidentialityClause"></see>
    /// </summary>
    let ContractConfidentialityClause = _prefix "ContractConfidentialityClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDefinitions"></see>
    /// </summary>
    let ContractDefinitions = _prefix "ContractDefinitions"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDisputeResolutionClause"></see>
    /// </summary>
    let ContractDisputeResolutionClause = _prefix "ContractDisputeResolutionClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDisputed"></see>
    /// </summary>
    let ContractDisputed = _prefix "ContractDisputed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDrafted"></see>
    /// </summary>
    let ContractDrafted = _prefix "ContractDrafted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractExecutionStatus"></see>
    /// </summary>
    let ContractExecutionStatus = _prefix "ContractExecutionStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractExpired"></see>
    /// </summary>
    let ContractExpired = _prefix "ContractExpired"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractExtended"></see>
    /// </summary>
    let ContractExtended = _prefix "ContractExtended"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFulfilled"></see>
    /// </summary>
    let ContractFulfilled = _prefix "ContractFulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFulfilmentStatus"></see>
    /// </summary>
    let ContractFulfilmentStatus = _prefix "ContractFulfilmentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFullyExecuted"></see>
    /// </summary>
    let ContractFullyExecuted = _prefix "ContractFullyExecuted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFullySigned"></see>
    /// </summary>
    let ContractFullySigned = _prefix "ContractFullySigned"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractInactive"></see>
    /// </summary>
    let ContractInactive = _prefix "ContractInactive"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractJurisdictionClause"></see>
    /// </summary>
    let ContractJurisdictionClause = _prefix "ContractJurisdictionClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractNegotiated"></see>
    /// </summary>
    let ContractNegotiated = _prefix "ContractNegotiated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractNotFulfilled"></see>
    /// </summary>
    let ContractNotFulfilled = _prefix "ContractNotFulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractOffered"></see>
    /// </summary>
    let ContractOffered = _prefix "ContractOffered"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPartiallyFulfilled"></see>
    /// </summary>
    let ContractPartiallyFulfilled = _prefix "ContractPartiallyFulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPartiallySigned"></see>
    /// </summary>
    let ContractPartiallySigned = _prefix "ContractPartiallySigned"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPerformance"></see>
    /// </summary>
    let ContractPerformance = _prefix "ContractPerformance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPreamble"></see>
    /// </summary>
    let ContractPreamble = _prefix "ContractPreamble"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractRejected"></see>
    /// </summary>
    let ContractRejected = _prefix "ContractRejected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractRenewed"></see>
    /// </summary>
    let ContractRenewed = _prefix "ContractRenewed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractSignedByParty"></see>
    /// </summary>
    let ContractSignedByParty = _prefix "ContractSignedByParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTemporarilySuspended"></see>
    /// </summary>
    let ContractTemporarilySuspended = _prefix "ContractTemporarilySuspended"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTerminated"></see>
    /// </summary>
    let ContractTerminated = _prefix "ContractTerminated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTerminationClause"></see>
    /// </summary>
    let ContractTerminationClause = _prefix "ContractTerminationClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractUnderNegotiation"></see>
    /// </summary>
    let ContractUnderNegotiation = _prefix "ContractUnderNegotiation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractUnderReview"></see>
    /// </summary>
    let ContractUnderReview = _prefix "ContractUnderReview"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractViolated"></see>
    /// </summary>
    let ContractViolated = _prefix "ContractViolated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseFulfilled"></see>
    /// </summary>
    let ContractualClauseFulfilled = _prefix "ContractualClauseFulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseFulfilmentStatus"></see>
    /// </summary>
    let ContractualClauseFulfilmentStatus = _prefix "ContractualClauseFulfilmentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseNotFulfilled"></see>
    /// </summary>
    let ContractualClauseNotFulfilled = _prefix "ContractualClauseNotFulfilled"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClausePartiallyFulfilled"></see>
    /// </summary>
    let ContractualClausePartiallyFulfilled =
        _prefix "ContractualClausePartiallyFulfilled"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseViolated"></see>
    /// </summary>
    let ContractualClauseViolated = _prefix "ContractualClauseViolated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualTerms"></see>
    /// </summary>
    let ContractualTerms = _prefix "ContractualTerms"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerDataSubjectAgreement"></see>
    /// </summary>
    let ControllerDataSubjectAgreement = _prefix "ControllerDataSubjectAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectContract"></see>
    /// </summary>
    let DataSubjectContract = _prefix "DataSubjectContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerInformed"></see>
    /// </summary>
    let ControllerInformed = _prefix "ControllerInformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerProcessorAgreement"></see>
    /// </summary>
    let ControllerProcessorAgreement = _prefix "ControllerProcessorAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessorContract"></see>
    /// </summary>
    let DataProcessorContract = _prefix "DataProcessorContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerUninformed"></see>
    /// </summary>
    let ControllerUninformed = _prefix "ControllerUninformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Copy"></see>
    /// </summary>
    let Copy = _prefix "Copy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CorrectingProcess"></see>
    /// </summary>
    let CorrectingProcess = _prefix "CorrectingProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CorrectingProcessInput"></see>
    /// </summary>
    let CorrectingProcessInput = _prefix "CorrectingProcessInput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CorrectingProcessOutput"></see>
    /// </summary>
    let CorrectingProcessOutput = _prefix "CorrectingProcessOutput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CounterMoneyLaundering"></see>
    /// </summary>
    let CounterMoneyLaundering = _prefix "CounterMoneyLaundering"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FraudPreventionAndDetection"></see>
    /// </summary>
    let FraudPreventionAndDetection = _prefix "FraudPreventionAndDetection"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Counterterrorism"></see>
    /// </summary>
    let Counterterrorism = _prefix "Counterterrorism"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Jurisdiction"></see>
    /// </summary>
    let Jurisdiction = _prefix "Jurisdiction"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CredentialManagement"></see>
    /// </summary>
    let CredentialManagement = _prefix "CredentialManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CrossBorderTransfer"></see>
    /// </summary>
    let CrossBorderTransfer = _prefix "CrossBorderTransfer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Transfer"></see>
    /// </summary>
    let Transfer = _prefix "Transfer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CryptographicKeyManagement"></see>
    /// </summary>
    let CryptographicKeyManagement = _prefix "CryptographicKeyManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerManagement"></see>
    /// </summary>
    let CustomerManagement = _prefix "CustomerManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerClaimsManagement"></see>
    /// </summary>
    let CustomerClaimsManagement = _prefix "CustomerClaimsManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerOrderManagement"></see>
    /// </summary>
    let CustomerOrderManagement = _prefix "CustomerOrderManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerRelationshipManagement"></see>
    /// </summary>
    let CustomerRelationshipManagement = _prefix "CustomerRelationshipManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerSolvencyMonitoring"></see>
    /// </summary>
    let CustomerSolvencyMonitoring = _prefix "CustomerSolvencyMonitoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CybersecurityAssessment"></see>
    /// </summary>
    let CybersecurityAssessment = _prefix "CybersecurityAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityAssessment"></see>
    /// </summary>
    let SecurityAssessment = _prefix "SecurityAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#CybersecurityTraining"></see>
    /// </summary>
    let CybersecurityTraining = _prefix "CybersecurityTraining"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StaffTraining"></see>
    /// </summary>
    let StaffTraining = _prefix "StaffTraining"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DPIA"></see>
    /// </summary>
    let DPIA = _prefix "DPIA"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightsImpactAssessment"></see>
    /// </summary>
    let RightsImpactAssessment = _prefix "RightsImpactAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DashboardNotice"></see>
    /// </summary>
    let DashboardNotice = _prefix "DashboardNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataAltruism"></see>
    /// </summary>
    let DataAltruism = _prefix "DataAltruism"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBackupProtocols"></see>
    /// </summary>
    let DataBackupProtocols = _prefix "DataBackupProtocols"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachImpactAssessment"></see>
    /// </summary>
    let DataBreachImpactAssessment = _prefix "DataBreachImpactAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachNotice"></see>
    /// </summary>
    let DataBreachNotice = _prefix "DataBreachNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityIncidentNotice"></see>
    /// </summary>
    let SecurityIncidentNotice = _prefix "SecurityIncidentNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachNotification"></see>
    /// </summary>
    let DataBreachNotification = _prefix "DataBreachNotification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityIncidentNotification"></see>
    /// </summary>
    let SecurityIncidentNotification = _prefix "SecurityIncidentNotification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachRecord"></see>
    /// </summary>
    let DataBreachRecord = _prefix "DataBreachRecord"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecordsOfActivities"></see>
    /// </summary>
    let RecordsOfActivities = _prefix "RecordsOfActivities"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataController"></see>
    /// </summary>
    let DataController = _prefix "DataController"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-legalrole-classes"></see>
    /// </summary>
    let ``entities-legalrole-classes`` = _prefix "entities-legalrole-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataControllerContract"></see>
    /// </summary>
    let DataControllerContract = _prefix "DataControllerContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessingAgreement"></see>
    /// </summary>
    let DataProcessingAgreement = _prefix "DataProcessingAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataControllerDataSource"></see>
    /// </summary>
    let DataControllerDataSource = _prefix "DataControllerDataSource"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSource"></see>
    /// </summary>
    let DataSource = _prefix "DataSource"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataDeletionPolicy"></see>
    /// </summary>
    let DataDeletionPolicy = _prefix "DataDeletionPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessingPolicy"></see>
    /// </summary>
    let DataProcessingPolicy = _prefix "DataProcessingPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataErasurePolicy"></see>
    /// </summary>
    let DataErasurePolicy = _prefix "DataErasurePolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataExporter"></see>
    /// </summary>
    let DataExporter = _prefix "DataExporter"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataGovernance"></see>
    /// </summary>
    let DataGovernance = _prefix "DataGovernance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationGovernance"></see>
    /// </summary>
    let OrganisationGovernance = _prefix "OrganisationGovernance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataHandlingClause"></see>
    /// </summary>
    let DataHandlingClause = _prefix "DataHandlingClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataImporter"></see>
    /// </summary>
    let DataImporter = _prefix "DataImporter"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Recipient"></see>
    /// </summary>
    let Recipient = _prefix "Recipient"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInteroperabilityAssessment"></see>
    /// </summary>
    let DataInteroperabilityAssessment = _prefix "DataInteroperabilityAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInteroperabilityManagement"></see>
    /// </summary>
    let DataInteroperabilityManagement = _prefix "DataInteroperabilityManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInteroperabilityImprovement"></see>
    /// </summary>
    let DataInteroperabilityImprovement = _prefix "DataInteroperabilityImprovement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInventoryManagement"></see>
    /// </summary>
    let DataInventoryManagement = _prefix "DataInventoryManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataJurisdictionPolicy"></see>
    /// </summary>
    let DataJurisdictionPolicy = _prefix "DataJurisdictionPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataLiteracy"></see>
    /// </summary>
    let DataLiteracy = _prefix "DataLiteracy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessor"></see>
    /// </summary>
    let DataProcessor = _prefix "DataProcessor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProtectionAuthority"></see>
    /// </summary>
    let DataProtectionAuthority = _prefix "DataProtectionAuthority"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProtectionOfficer"></see>
    /// </summary>
    let DataProtectionOfficer = _prefix "DataProtectionOfficer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Representative"></see>
    /// </summary>
    let Representative = _prefix "Representative"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProtectionTraining"></see>
    /// </summary>
    let DataProtectionTraining = _prefix "DataProtectionTraining"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataPublishedByDataSubject"></see>
    /// </summary>
    let DataPublishedByDataSubject = _prefix "DataPublishedByDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectDataSource"></see>
    /// </summary>
    let DataSubjectDataSource = _prefix "DataSubjectDataSource"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataQualityAssessment"></see>
    /// </summary>
    let DataQualityAssessment = _prefix "DataQualityAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataQualityManagement"></see>
    /// </summary>
    let DataQualityManagement = _prefix "DataQualityManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataQualityImprovement"></see>
    /// </summary>
    let DataQualityImprovement = _prefix "DataQualityImprovement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataRedaction"></see>
    /// </summary>
    let DataRedaction = _prefix "DataRedaction"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSanitisationTechnique"></see>
    /// </summary>
    let DataSanitisationTechnique = _prefix "DataSanitisationTechnique"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataRestorationPolicy"></see>
    /// </summary>
    let DataRestorationPolicy = _prefix "DataRestorationPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataReusePolicy"></see>
    /// </summary>
    let DataReusePolicy = _prefix "DataReusePolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSecurityManagement"></see>
    /// </summary>
    let DataSecurityManagement = _prefix "DataSecurityManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataStoragePolicy"></see>
    /// </summary>
    let DataStoragePolicy = _prefix "DataStoragePolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubProcessor"></see>
    /// </summary>
    let DataSubProcessor = _prefix "DataSubProcessor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubject"></see>
    /// </summary>
    let DataSubject = _prefix "DataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectInformed"></see>
    /// </summary>
    let DataSubjectInformed = _prefix "DataSubjectInformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectRight"></see>
    /// </summary>
    let DataSubjectRight = _prefix "DataSubjectRight"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectRightsManagement"></see>
    /// </summary>
    let DataSubjectRightsManagement = _prefix "DataSubjectRightsManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightsManagement"></see>
    /// </summary>
    let RightsManagement = _prefix "RightsManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectScale"></see>
    /// </summary>
    let DataSubjectScale = _prefix "DataSubjectScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Scale"></see>
    /// </summary>
    let Scale = _prefix "Scale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-scale-classes"></see>
    /// </summary>
    let ``processing-scale-classes`` = _prefix "processing-scale-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectUninformed"></see>
    /// </summary>
    let DataSubjectUninformed = _prefix "DataSubjectUninformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferImpactAssessment"></see>
    /// </summary>
    let DataTransferImpactAssessment = _prefix "DataTransferImpactAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImpactAssessment"></see>
    /// </summary>
    let ImpactAssessment = _prefix "ImpactAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferLegalBasis"></see>
    /// </summary>
    let DataTransferLegalBasis = _prefix "DataTransferLegalBasis"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferNotice"></see>
    /// </summary>
    let DataTransferNotice = _prefix "DataTransferNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferRecord"></see>
    /// </summary>
    let DataTransferRecord = _prefix "DataTransferRecord"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataVolume"></see>
    /// </summary>
    let DataVolume = _prefix "DataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DecentralisedLocations"></see>
    /// </summary>
    let DecentralisedLocations = _prefix "DecentralisedLocations"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocationFixture"></see>
    /// </summary>
    let LocationFixture = _prefix "LocationFixture"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Delete"></see>
    /// </summary>
    let Delete = _prefix "Delete"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Remove"></see>
    /// </summary>
    let Remove = _prefix "Remove"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeliveryOfGoods"></see>
    /// </summary>
    let DeliveryOfGoods = _prefix "DeliveryOfGoods"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestedServiceProvision"></see>
    /// </summary>
    let RequestedServiceProvision = _prefix "RequestedServiceProvision"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Derive"></see>
    /// </summary>
    let Derive = _prefix "Derive"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DerivedData"></see>
    /// </summary>
    let DerivedData = _prefix "DerivedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DerivedPersonalData"></see>
    /// </summary>
    let DerivedPersonalData = _prefix "DerivedPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DesignStandard"></see>
    /// </summary>
    let DesignStandard = _prefix "DesignStandard"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Standard"></see>
    /// </summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Destruct"></see>
    /// </summary>
    let Destruct = _prefix "Destruct"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeterministicPseudonymisation"></see>
    /// </summary>
    let DeterministicPseudonymisation = _prefix "DeterministicPseudonymisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Pseudonymisation"></see>
    /// </summary>
    let Pseudonymisation = _prefix "Pseudonymisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Deterrence"></see>
    /// </summary>
    let Deterrence = _prefix "Deterrence"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnacceptableRule"></see>
    /// </summary>
    let UnacceptableRule = _prefix "UnacceptableRule"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeterrenceFollowed"></see>
    /// </summary>
    let DeterrenceFollowed = _prefix "DeterrenceFollowed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleFulfilmentStatus"></see>
    /// </summary>
    let RuleFulfilmentStatus = _prefix "RuleFulfilmentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleFulfilled"></see>
    /// </summary>
    let RuleFulfilled = _prefix "RuleFulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeterrenceNotFollowed"></see>
    /// </summary>
    let DeterrenceNotFollowed = _prefix "DeterrenceNotFollowed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleUnfulfilled"></see>
    /// </summary>
    let RuleUnfulfilled = _prefix "RuleUnfulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeviceNotice"></see>
    /// </summary>
    let DeviceNotice = _prefix "DeviceNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DifferentialPrivacy"></see>
    /// </summary>
    let DifferentialPrivacy = _prefix "DifferentialPrivacy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DigitalRightsManagement"></see>
    /// </summary>
    let DigitalRightsManagement = _prefix "DigitalRightsManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DigitalSignatures"></see>
    /// </summary>
    let DigitalSignatures = _prefix "DigitalSignatures"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DirectMarketing"></see>
    /// </summary>
    let DirectMarketing = _prefix "DirectMarketing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DisasterRecoveryProcedures"></see>
    /// </summary>
    let DisasterRecoveryProcedures = _prefix "DisasterRecoveryProcedures"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Disclose"></see>
    /// </summary>
    let Disclose = _prefix "Disclose"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DiscloseByTransmission"></see>
    /// </summary>
    let DiscloseByTransmission = _prefix "DiscloseByTransmission"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Display"></see>
    /// </summary>
    let Display = _prefix "Display"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DisputeManagement"></see>
    /// </summary>
    let DisputeManagement = _prefix "DisputeManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Disseminate"></see>
    /// </summary>
    let Disseminate = _prefix "Disseminate"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DistributedSystemSecurity"></see>
    /// </summary>
    let DistributedSystemSecurity = _prefix "DistributedSystemSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityMethod"></see>
    /// </summary>
    let SecurityMethod = _prefix "SecurityMethod"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#DistributionAgreement"></see>
    /// </summary>
    let DistributionAgreement = _prefix "DistributionAgreement"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DocumentRandomisedPseudonymisation"></see>
    /// </summary>
    let DocumentRandomisedPseudonymisation =
        _prefix "DocumentRandomisedPseudonymisation"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DocumentSecurity"></see>
    /// </summary>
    let DocumentSecurity = _prefix "DocumentSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Download"></see>
    /// </summary>
    let Download = _prefix "Download"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Duration"></see>
    /// </summary>
    let Duration = _prefix "Duration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EULA"></see>
    /// </summary>
    let EULA = _prefix "EULA"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LicenseAgreement"></see>
    /// </summary>
    let LicenseAgreement = _prefix "LicenseAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EconomicUnion"></see>
    /// </summary>
    let EconomicUnion = _prefix "EconomicUnion"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EducationalOrganisation"></see>
    /// </summary>
    let EducationalOrganisation = _prefix "EducationalOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EducationalTraining"></see>
    /// </summary>
    let EducationalTraining = _prefix "EducationalTraining"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EffectivenessDeterminationProcedures"></see>
    /// </summary>
    let EffectivenessDeterminationProcedures =
        _prefix "EffectivenessDeterminationProcedures"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ElderlyDataSubject"></see>
    /// </summary>
    let ElderlyDataSubject = _prefix "ElderlyDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VulnerableDataSubject"></see>
    /// </summary>
    let VulnerableDataSubject = _prefix "VulnerableDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ElderlyHuman"></see>
    /// </summary>
    let ElderlyHuman = _prefix "ElderlyHuman"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EmergencyHealthcareProvider"></see>
    /// </summary>
    let EmergencyHealthcareProvider = _prefix "EmergencyHealthcareProvider"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Employee"></see>
    /// </summary>
    let Employee = _prefix "Employee"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EmploymentContract"></see>
    /// </summary>
    let EmploymentContract = _prefix "EmploymentContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EncryptionAtRest"></see>
    /// </summary>
    let EncryptionAtRest = _prefix "EncryptionAtRest"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EncryptionInTransfer"></see>
    /// </summary>
    let EncryptionInTransfer = _prefix "EncryptionInTransfer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EncryptionInUse"></see>
    /// </summary>
    let EncryptionInUse = _prefix "EncryptionInUse"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EndToEndEncryption"></see>
    /// </summary>
    let EndToEndEncryption = _prefix "EndToEndEncryption"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EndlessDuration"></see>
    /// </summary>
    let EndlessDuration = _prefix "EndlessDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnforceAccessControl"></see>
    /// </summary>
    let EnforceAccessControl = _prefix "EnforceAccessControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnforceSecurity"></see>
    /// </summary>
    let EnforceSecurity = _prefix "EnforceSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnterIntoContract"></see>
    /// </summary>
    let EnterIntoContract = _prefix "EnterIntoContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-classes"></see>
    /// </summary>
    let ``entities-classes`` = _prefix "entities-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityActiveInvolvement"></see>
    /// </summary>
    let EntityActiveInvolvement = _prefix "EntityActiveInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityIntendedInvolvement"></see>
    /// </summary>
    let EntityIntendedInvolvement = _prefix "EntityIntendedInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInvolvementStatus"></see>
    /// </summary>
    let EntityInvolvementStatus = _prefix "EntityInvolvementStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Intended"></see>
    /// </summary>
    let Intended = _prefix "Intended"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInvolved"></see>
    /// </summary>
    let EntityInvolved = _prefix "EntityInvolved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityNonInvolvement"></see>
    /// </summary>
    let EntityNonInvolvement = _prefix "EntityNonInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityNotInvolved"></see>
    /// </summary>
    let EntityNotInvolved = _prefix "EntityNotInvolved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityPassiveInvolvement"></see>
    /// </summary>
    let EntityPassiveInvolvement = _prefix "EntityPassiveInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityUnintendedInvolvement"></see>
    /// </summary>
    let EntityUnintendedInvolvement = _prefix "EntityUnintendedInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Unintended"></see>
    /// </summary>
    let Unintended = _prefix "Unintended"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnvironmentalProtection"></see>
    /// </summary>
    let EnvironmentalProtection = _prefix "EnvironmentalProtection"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalMeasure"></see>
    /// </summary>
    let PhysicalMeasure = _prefix "PhysicalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#physical-measures-classes"></see>
    /// </summary>
    let ``physical-measures-classes`` = _prefix "physical-measures-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Erase"></see>
    /// </summary>
    let Erase = _prefix "Erase"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EstablishContractualAgreement"></see>
    /// </summary>
    let EstablishContractualAgreement = _prefix "EstablishContractualAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EvaluationOfIndividuals"></see>
    /// </summary>
    let EvaluationOfIndividuals = _prefix "EvaluationOfIndividuals"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EvaluationScoring"></see>
    /// </summary>
    let EvaluationScoring = _prefix "EvaluationScoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ExpectationStatus"></see>
    /// </summary>
    let ExpectationStatus = _prefix "ExpectationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Expected"></see>
    /// </summary>
    let Expected = _prefix "Expected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ExplicitlyExpressedConsent"></see>
    /// </summary>
    let ExplicitlyExpressedConsent = _prefix "ExplicitlyExpressedConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ExpressedConsent"></see>
    /// </summary>
    let ExpressedConsent = _prefix "ExpressedConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-types-classes"></see>
    /// </summary>
    let ``consent-types-classes`` = _prefix "consent-types-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Export"></see>
    /// </summary>
    let Export = _prefix "Export"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformedConsent"></see>
    /// </summary>
    let InformedConsent = _prefix "InformedConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FRIA"></see>
    /// </summary>
    let FRIA = _prefix "FRIA"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FederatedLocations"></see>
    /// </summary>
    let FederatedLocations = _prefix "FederatedLocations"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FeeNotRequired"></see>
    /// </summary>
    let FeeNotRequired = _prefix "FeeNotRequired"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FeeRequirement"></see>
    /// </summary>
    let FeeRequirement = _prefix "FeeRequirement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FeeRequired"></see>
    /// </summary>
    let FeeRequired = _prefix "FeeRequired"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FileSystemSecurity"></see>
    /// </summary>
    let FileSystemSecurity = _prefix "FileSystemSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Filter"></see>
    /// </summary>
    let Filter = _prefix "Filter"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FireDepartment"></see>
    /// </summary>
    let FireDepartment = _prefix "FireDepartment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedLocation"></see>
    /// </summary>
    let FixedLocation = _prefix "FixedLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedMultipleLocations"></see>
    /// </summary>
    let FixedMultipleLocations = _prefix "FixedMultipleLocations"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedOccurrencesDuration"></see>
    /// </summary>
    let FixedOccurrencesDuration = _prefix "FixedOccurrencesDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedSingularLocation"></see>
    /// </summary>
    let FixedSingularLocation = _prefix "FixedSingularLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ForProfitOrganisation"></see>
    /// </summary>
    let ForProfitOrganisation = _prefix "ForProfitOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Format"></see>
    /// </summary>
    let Format = _prefix "Format"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Structure"></see>
    /// </summary>
    let Structure = _prefix "Structure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MisusePreventionAndDetection"></see>
    /// </summary>
    let MisusePreventionAndDetection = _prefix "MisusePreventionAndDetection"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FulfilmentOfContractualObligation"></see>
    /// </summary>
    let FulfilmentOfContractualObligation = _prefix "FulfilmentOfContractualObligation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FulfilmentOfObligation"></see>
    /// </summary>
    let FulfilmentOfObligation = _prefix "FulfilmentOfObligation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FullAutomation"></see>
    /// </summary>
    let FullAutomation = _prefix "FullAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#FullyRandomisedPseudonymisation"></see>
    /// </summary>
    let FullyRandomisedPseudonymisation = _prefix "FullyRandomisedPseudonymisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#G2BContract"></see>
    /// </summary>
    let G2BContract = _prefix "G2BContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#G2CContract"></see>
    /// </summary>
    let G2CContract = _prefix "G2CContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#G2GContract"></see>
    /// </summary>
    let G2GContract = _prefix "G2GContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Generate"></see>
    /// </summary>
    let Generate = _prefix "Generate"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GeneratedData"></see>
    /// </summary>
    let GeneratedData = _prefix "GeneratedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GeneratedPersonalData"></see>
    /// </summary>
    let GeneratedPersonalData = _prefix "GeneratedPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GeographicCoverage"></see>
    /// </summary>
    let GeographicCoverage = _prefix "GeographicCoverage"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GlobalScale"></see>
    /// </summary>
    let GlobalScale = _prefix "GlobalScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GraphicalNotice"></see>
    /// </summary>
    let GraphicalNotice = _prefix "GraphicalNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GuardianOfDataSubject"></see>
    /// </summary>
    let GuardianOfDataSubject = _prefix "GuardianOfDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#GuardianOfHuman"></see>
    /// </summary>
    let GuardianOfHuman = _prefix "GuardianOfHuman"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Guideline"></see>
    /// </summary>
    let Guideline = _prefix "Guideline"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HardwareSecurityProtocols"></see>
    /// </summary>
    let HardwareSecurityProtocols = _prefix "HardwareSecurityProtocols"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HashFunctions"></see>
    /// </summary>
    let HashFunctions = _prefix "HashFunctions"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HashMessageAuthenticationCode"></see>
    /// </summary>
    let HashMessageAuthenticationCode = _prefix "HashMessageAuthenticationCode"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HealthcareOrganisation"></see>
    /// </summary>
    let HealthcareOrganisation = _prefix "HealthcareOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HighAutomation"></see>
    /// </summary>
    let HighAutomation = _prefix "HighAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HomomorphicEncryption"></see>
    /// </summary>
    let HomomorphicEncryption = _prefix "HomomorphicEncryption"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Hospital"></see>
    /// </summary>
    let Hospital = _prefix "Hospital"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HugeDataVolume"></see>
    /// </summary>
    let HugeDataVolume = _prefix "HugeDataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HugeScaleOfDataSubjects"></see>
    /// </summary>
    let HugeScaleOfDataSubjects = _prefix "HugeScaleOfDataSubjects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolved"></see>
    /// </summary>
    let HumanInvolved = _prefix "HumanInvolved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvement"></see>
    /// </summary>
    let HumanInvolvement = _prefix "HumanInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForControl"></see>
    /// </summary>
    let HumanInvolvementForControl = _prefix "HumanInvolvementForControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForDecision"></see>
    /// </summary>
    let HumanInvolvementForDecision = _prefix "HumanInvolvementForDecision"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForInput"></see>
    /// </summary>
    let HumanInvolvementForInput = _prefix "HumanInvolvementForInput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForIntervention"></see>
    /// </summary>
    let HumanInvolvementForIntervention = _prefix "HumanInvolvementForIntervention"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForOversight"></see>
    /// </summary>
    let HumanInvolvementForOversight = _prefix "HumanInvolvementForOversight"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForVerification"></see>
    /// </summary>
    let HumanInvolvementForVerification = _prefix "HumanInvolvementForVerification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanNotInvolved"></see>
    /// </summary>
    let HumanNotInvolved = _prefix "HumanNotInvolved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanResourceManagement"></see>
    /// </summary>
    let HumanResourceManagement = _prefix "HumanResourceManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#HybridPublicPrivateSpace"></see>
    /// </summary>
    let HybridPublicPrivateSpace = _prefix "HybridPublicPrivateSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicSpace"></see>
    /// </summary>
    let PublicSpace = _prefix "PublicSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateSpace"></see>
    /// </summary>
    let PrivateSpace = _prefix "PrivateSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IPRManagement"></see>
    /// </summary>
    let IPRManagement = _prefix "IPRManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentifyingPersonalData"></see>
    /// </summary>
    let IdentifyingPersonalData = _prefix "IdentifyingPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentityAuthentication"></see>
    /// </summary>
    let IdentityAuthentication = _prefix "IdentityAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentityManagementMethod"></see>
    /// </summary>
    let IdentityManagementMethod = _prefix "IdentityManagementMethod"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentityVerification"></see>
    /// </summary>
    let IdentityVerification = _prefix "IdentityVerification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Immigrant"></see>
    /// </summary>
    let Immigrant = _prefix "Immigrant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Impact"></see>
    /// </summary>
    let Impact = _prefix "Impact"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskAssessment"></see>
    /// </summary>
    let RiskAssessment = _prefix "RiskAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImpliedConsent"></see>
    /// </summary>
    let ImpliedConsent = _prefix "ImpliedConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Importance"></see>
    /// </summary>
    let Importance = _prefix "Importance"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveExistingProductsAndServices"></see>
    /// </summary>
    let ImproveExistingProductsAndServices =
        _prefix "ImproveExistingProductsAndServices"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptimisationForController"></see>
    /// </summary>
    let OptimisationForController = _prefix "OptimisationForController"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveHealthcare"></see>
    /// </summary>
    let ImproveHealthcare = _prefix "ImproveHealthcare"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveInternalCRMProcesses"></see>
    /// </summary>
    let ImproveInternalCRMProcesses = _prefix "ImproveInternalCRMProcesses"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImprovePublicServices"></see>
    /// </summary>
    let ImprovePublicServices = _prefix "ImprovePublicServices"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveTransportMobility"></see>
    /// </summary>
    let ImproveTransportMobility = _prefix "ImproveTransportMobility"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncidentManagementProcedures"></see>
    /// </summary>
    let IncidentManagementProcedures = _prefix "IncidentManagementProcedures"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncidentReportingCommunication"></see>
    /// </summary>
    let IncidentReportingCommunication = _prefix "IncidentReportingCommunication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncorrectData"></see>
    /// </summary>
    let IncorrectData = _prefix "IncorrectData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncreaseServiceRobustness"></see>
    /// </summary>
    let IncreaseServiceRobustness = _prefix "IncreaseServiceRobustness"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IndeterminateDuration"></see>
    /// </summary>
    let IndeterminateDuration = _prefix "IndeterminateDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IndustryConsortium"></see>
    /// </summary>
    let IndustryConsortium = _prefix "IndustryConsortium"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Infer"></see>
    /// </summary>
    let Infer = _prefix "Infer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InferredData"></see>
    /// </summary>
    let InferredData = _prefix "InferredData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InferredPersonalData"></see>
    /// </summary>
    let InferredPersonalData = _prefix "InferredPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformationAudit"></see>
    /// </summary>
    let InformationAudit = _prefix "InformationAudit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformationFlowControl"></see>
    /// </summary>
    let InformationFlowControl = _prefix "InformationFlowControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformationSecurityPolicy"></see>
    /// </summary>
    let InformationSecurityPolicy = _prefix "InformationSecurityPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InnovativeUseOfExistingTechnology"></see>
    /// </summary>
    let InnovativeUseOfExistingTechnology = _prefix "InnovativeUseOfExistingTechnology"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InnovativeUseOfTechnology"></see>
    /// </summary>
    let InnovativeUseOfTechnology = _prefix "InnovativeUseOfTechnology"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InnovativeUseOfNewTechnologies"></see>
    /// </summary>
    let InnovativeUseOfNewTechnologies = _prefix "InnovativeUseOfNewTechnologies"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IntellectualPropertyData"></see>
    /// </summary>
    let IntellectualPropertyData = _prefix "IntellectualPropertyData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IntentionStatus"></see>
    /// </summary>
    let IntentionStatus = _prefix "IntentionStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InternalResourceOptimisation"></see>
    /// </summary>
    let InternalResourceOptimisation = _prefix "InternalResourceOptimisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InternationalOrganisation"></see>
    /// </summary>
    let InternationalOrganisation = _prefix "InternationalOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#IntrusionDetectionSystem"></see>
    /// </summary>
    let IntrusionDetectionSystem = _prefix "IntrusionDetectionSystem"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#InverseJurisdiction"></see>
    /// </summary>
    let InverseJurisdiction = _prefix "InverseJurisdiction"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#JITNotice"></see>
    /// </summary>
    let JITNotice = _prefix "JITNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#JobApplicant"></see>
    /// </summary>
    let JobApplicant = _prefix "JobApplicant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#JointDataControllers"></see>
    /// </summary>
    let JointDataControllers = _prefix "JointDataControllers"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#JointDataControllersAgreement"></see>
    /// </summary>
    let JointDataControllersAgreement = _prefix "JointDataControllersAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#JudicialOrganisation"></see>
    /// </summary>
    let JudicialOrganisation = _prefix "JudicialOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Justification"></see>
    /// </summary>
    let Justification = _prefix "Justification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LargeDataVolume"></see>
    /// </summary>
    let LargeDataVolume = _prefix "LargeDataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LargeScaleOfDataSubjects"></see>
    /// </summary>
    let LargeScaleOfDataSubjects = _prefix "LargeScaleOfDataSubjects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LargeScaleProcessing"></see>
    /// </summary>
    let LargeScaleProcessing = _prefix "LargeScaleProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingScale"></see>
    /// </summary>
    let ProcessingScale = _prefix "ProcessingScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Law"></see>
    /// </summary>
    let Law = _prefix "Law"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LawEnforcementOrganisation"></see>
    /// </summary>
    let LawEnforcementOrganisation = _prefix "LawEnforcementOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Lawful"></see>
    /// </summary>
    let Lawful = _prefix "Lawful"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Lawfulness"></see>
    /// </summary>
    let Lawfulness = _prefix "Lawfulness"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LawfulnessUnknown"></see>
    /// </summary>
    let LawfulnessUnknown = _prefix "LawfulnessUnknown"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LayeredNotice"></see>
    /// </summary>
    let LayeredNotice = _prefix "LayeredNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalCompliance"></see>
    /// </summary>
    let LegalCompliance = _prefix "LegalCompliance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalComplianceAssessment"></see>
    /// </summary>
    let LegalComplianceAssessment = _prefix "LegalComplianceAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalComplianceAudit"></see>
    /// </summary>
    let LegalComplianceAudit = _prefix "LegalComplianceAudit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalOrganisationalMeasure"></see>
    /// </summary>
    let TechnicalOrganisationalMeasure = _prefix "TechnicalOrganisationalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TOM-classes"></see>
    /// </summary>
    let ``TOM-classes`` = _prefix "TOM-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligation"></see>
    /// </summary>
    let LegalObligation = _prefix "LegalObligation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationCompleted"></see>
    /// </summary>
    let LegalObligationCompleted = _prefix "LegalObligationCompleted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationStatus"></see>
    /// </summary>
    let LegalObligationStatus = _prefix "LegalObligationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-basis-status-classes"></see>
    /// </summary>
    let ``legal-basis-status-classes`` = _prefix "legal-basis-status-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationOngoing"></see>
    /// </summary>
    let LegalObligationOngoing = _prefix "LegalObligationOngoing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationPending"></see>
    /// </summary>
    let LegalObligationPending = _prefix "LegalObligationPending"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterest"></see>
    /// </summary>
    let LegitimateInterest = _prefix "LegitimateInterest"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestAssessment"></see>
    /// </summary>
    let LegitimateInterestAssessment = _prefix "LegitimateInterestAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestInformed"></see>
    /// </summary>
    let LegitimateInterestInformed = _prefix "LegitimateInterestInformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestStatus"></see>
    /// </summary>
    let LegitimateInterestStatus = _prefix "LegitimateInterestStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestNotObjected"></see>
    /// </summary>
    let LegitimateInterestNotObjected = _prefix "LegitimateInterestNotObjected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestObjected"></see>
    /// </summary>
    let LegitimateInterestObjected = _prefix "LegitimateInterestObjected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestOfController"></see>
    /// </summary>
    let LegitimateInterestOfController = _prefix "LegitimateInterestOfController"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestOfDataSubject"></see>
    /// </summary>
    let LegitimateInterestOfDataSubject = _prefix "LegitimateInterestOfDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestOfThirdParty"></see>
    /// </summary>
    let LegitimateInterestOfThirdParty = _prefix "LegitimateInterestOfThirdParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestUninformed"></see>
    /// </summary>
    let LegitimateInterestUninformed = _prefix "LegitimateInterestUninformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Likelihood"></see>
    /// </summary>
    let Likelihood = _prefix "Likelihood"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocalEnvironmentScale"></see>
    /// </summary>
    let LocalEnvironmentScale = _prefix "LocalEnvironmentScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocalLocation"></see>
    /// </summary>
    let LocalLocation = _prefix "LocalLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocationLocality"></see>
    /// </summary>
    let LocationLocality = _prefix "LocationLocality"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocalityScale"></see>
    /// </summary>
    let LocalityScale = _prefix "LocalityScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#LoggingPolicy"></see>
    /// </summary>
    let LoggingPolicy = _prefix "LoggingPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MaintainFraudDatabase"></see>
    /// </summary>
    let MaintainFraudDatabase = _prefix "MaintainFraudDatabase"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MakeAvailable"></see>
    /// </summary>
    let MakeAvailable = _prefix "MakeAvailable"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ManageConsent"></see>
    /// </summary>
    let ManageConsent = _prefix "ManageConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithdrawConsent"></see>
    /// </summary>
    let WithdrawConsent = _prefix "WithdrawConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideConsent"></see>
    /// </summary>
    let ProvideConsent = _prefix "ProvideConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReaffirmConsent"></see>
    /// </summary>
    let ReaffirmConsent = _prefix "ReaffirmConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ManagementStandard"></see>
    /// </summary>
    let ManagementStandard = _prefix "ManagementStandard"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Match"></see>
    /// </summary>
    let Match = _prefix "Match"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MediumDataVolume"></see>
    /// </summary>
    let MediumDataVolume = _prefix "MediumDataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MediumScaleOfDataSubjects"></see>
    /// </summary>
    let MediumScaleOfDataSubjects = _prefix "MediumScaleOfDataSubjects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MediumScaleProcessing"></see>
    /// </summary>
    let MediumScaleProcessing = _prefix "MediumScaleProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Member"></see>
    /// </summary>
    let Member = _prefix "Member"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MemberPartnerManagement"></see>
    /// </summary>
    let MemberPartnerManagement = _prefix "MemberPartnerManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MentallyVulnerableDataSubject"></see>
    /// </summary>
    let MentallyVulnerableDataSubject = _prefix "MentallyVulnerableDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MentallyVulnerableHuman"></see>
    /// </summary>
    let MentallyVulnerableHuman = _prefix "MentallyVulnerableHuman"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MessageAuthenticationCodes"></see>
    /// </summary>
    let MessageAuthenticationCodes = _prefix "MessageAuthenticationCodes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MetadataManagement"></see>
    /// </summary>
    let MetadataManagement = _prefix "MetadataManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MobilePlatformSecurity"></see>
    /// </summary>
    let MobilePlatformSecurity = _prefix "MobilePlatformSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Modify"></see>
    /// </summary>
    let Modify = _prefix "Modify"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Monitor"></see>
    /// </summary>
    let Monitor = _prefix "Monitor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MonitoringPolicy"></see>
    /// </summary>
    let MonitoringPolicy = _prefix "MonitoringPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MonotonicCounterPseudonymisation"></see>
    /// </summary>
    let MonotonicCounterPseudonymisation = _prefix "MonotonicCounterPseudonymisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Move"></see>
    /// </summary>
    let Move = _prefix "Move"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MultiFactorAuthentication"></see>
    /// </summary>
    let MultiFactorAuthentication = _prefix "MultiFactorAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#MultiNationalScale"></see>
    /// </summary>
    let MultiNationalScale = _prefix "MultiNationalScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NDA"></see>
    /// </summary>
    let NDA = _prefix "NDA"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NationalAuthority"></see>
    /// </summary>
    let NationalAuthority = _prefix "NationalAuthority"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NationalScale"></see>
    /// </summary>
    let NationalScale = _prefix "NationalScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NaturalPerson"></see>
    /// </summary>
    let NaturalPerson = _prefix "NaturalPerson"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NearlyGlobalScale"></see>
    /// </summary>
    let NearlyGlobalScale = _prefix "NearlyGlobalScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Necessity"></see>
    /// </summary>
    let Necessity = _prefix "Necessity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NegotiateContract"></see>
    /// </summary>
    let NegotiateContract = _prefix "NegotiateContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NegotiatedContract"></see>
    /// </summary>
    let NegotiatedContract = _prefix "NegotiatedContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NetworkProxyRouting"></see>
    /// </summary>
    let NetworkProxyRouting = _prefix "NetworkProxyRouting"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NetworkSecurityProtocols"></see>
    /// </summary>
    let NetworkSecurityProtocols = _prefix "NetworkSecurityProtocols"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCitizen"></see>
    /// </summary>
    let NonCitizen = _prefix "NonCitizen"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCommercialPurpose"></see>
    /// </summary>
    let NonCommercialPurpose = _prefix "NonCommercialPurpose"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCommercialResearch"></see>
    /// </summary>
    let NonCommercialResearch = _prefix "NonCommercialResearch"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCompliant"></see>
    /// </summary>
    let NonCompliant = _prefix "NonCompliant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonConformant"></see>
    /// </summary>
    let NonConformant = _prefix "NonConformant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonGovernmentalOrganisation"></see>
    /// </summary>
    let NonGovernmentalOrganisation = _prefix "NonGovernmentalOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonPersonalDataProcess"></see>
    /// </summary>
    let NonPersonalDataProcess = _prefix "NonPersonalDataProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Process"></see>
    /// </summary>
    let Process = _prefix "Process"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#process-classes"></see>
    /// </summary>
    let ``process-classes`` = _prefix "process-classes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonProfitOrganisation"></see>
    /// </summary>
    let NonProfitOrganisation = _prefix "NonProfitOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonPublicDataSource"></see>
    /// </summary>
    let NonPublicDataSource = _prefix "NonPublicDataSource"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotApplicable"></see>
    /// </summary>
    let NotApplicable = _prefix "NotApplicable"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotAutomated"></see>
    /// </summary>
    let NotAutomated = _prefix "NotAutomated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotAvailable"></see>
    /// </summary>
    let NotAvailable = _prefix "NotAvailable"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotInvolved"></see>
    /// </summary>
    let NotInvolved = _prefix "NotInvolved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotRequired"></see>
    /// </summary>
    let NotRequired = _prefix "NotRequired"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeCommunicated"></see>
    /// </summary>
    let NoticeCommunicated = _prefix "NoticeCommunicated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeStatus"></see>
    /// </summary>
    let NoticeStatus = _prefix "NoticeStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeGenerated"></see>
    /// </summary>
    let NoticeGenerated = _prefix "NoticeGenerated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeIcon"></see>
    /// </summary>
    let NoticeIcon = _prefix "NoticeIcon"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeLatest"></see>
    /// </summary>
    let NoticeLatest = _prefix "NoticeLatest"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeLayer"></see>
    /// </summary>
    let NoticeLayer = _prefix "NoticeLayer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeStale"></see>
    /// </summary>
    let NoticeStale = _prefix "NoticeStale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeUnused"></see>
    /// </summary>
    let NoticeUnused = _prefix "NoticeUnused"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeUpdated"></see>
    /// </summary>
    let NoticeUpdated = _prefix "NoticeUpdated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeUsed"></see>
    /// </summary>
    let NoticeUsed = _prefix "NoticeUsed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Notification"></see>
    /// </summary>
    let Notification = _prefix "Notification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationCompleted"></see>
    /// </summary>
    let NotificationCompleted = _prefix "NotificationCompleted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationStatus"></see>
    /// </summary>
    let NotificationStatus = _prefix "NotificationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationFailed"></see>
    /// </summary>
    let NotificationFailed = _prefix "NotificationFailed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationNotNeeded"></see>
    /// </summary>
    let NotificationNotNeeded = _prefix "NotificationNotNeeded"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationOngoing"></see>
    /// </summary>
    let NotificationOngoing = _prefix "NotificationOngoing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationPlanned"></see>
    /// </summary>
    let NotificationPlanned = _prefix "NotificationPlanned"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObjectingToProcess"></see>
    /// </summary>
    let ObjectingToProcess = _prefix "ObjectingToProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Obligation"></see>
    /// </summary>
    let Obligation = _prefix "Obligation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObligationFulfilled"></see>
    /// </summary>
    let ObligationFulfilled = _prefix "ObligationFulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObligationUnfulfilled"></see>
    /// </summary>
    let ObligationUnfulfilled = _prefix "ObligationUnfulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObligationViolated"></see>
    /// </summary>
    let ObligationViolated = _prefix "ObligationViolated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleViolated"></see>
    /// </summary>
    let RuleViolated = _prefix "RuleViolated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Observe"></see>
    /// </summary>
    let Observe = _prefix "Observe"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObservedData"></see>
    /// </summary>
    let ObservedData = _prefix "ObservedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObservedPersonalData"></see>
    /// </summary>
    let ObservedPersonalData = _prefix "ObservedPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObtainConsent"></see>
    /// </summary>
    let ObtainConsent = _prefix "ObtainConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfferContract"></see>
    /// </summary>
    let OfferContract = _prefix "OfferContract"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExerciseCompleted"></see>
    /// </summary>
    let OfficialAuthorityExerciseCompleted =
        _prefix "OfficialAuthorityExerciseCompleted"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExerciseStatus"></see>
    /// </summary>
    let OfficialAuthorityExerciseStatus = _prefix "OfficialAuthorityExerciseStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExerciseOngoing"></see>
    /// </summary>
    let OfficialAuthorityExerciseOngoing = _prefix "OfficialAuthorityExerciseOngoing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExercisePending"></see>
    /// </summary>
    let OfficialAuthorityExercisePending = _prefix "OfficialAuthorityExercisePending"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityOfController"></see>
    /// </summary>
    let OfficialAuthorityOfController = _prefix "OfficialAuthorityOfController"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OftenFrequency"></see>
    /// </summary>
    let OftenFrequency = _prefix "OftenFrequency"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OperatingSystemSecurity"></see>
    /// </summary>
    let OperatingSystemSecurity = _prefix "OperatingSystemSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptimisationForConsumer"></see>
    /// </summary>
    let OptimisationForConsumer = _prefix "OptimisationForConsumer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceOptimisation"></see>
    /// </summary>
    let ServiceOptimisation = _prefix "ServiceOptimisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptimiseUserInterface"></see>
    /// </summary>
    let OptimiseUserInterface = _prefix "OptimiseUserInterface"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptingInToProcess"></see>
    /// </summary>
    let OptingInToProcess = _prefix "OptingInToProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptingOutFromProcess"></see>
    /// </summary>
    let OptingOutFromProcess = _prefix "OptingOutFromProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Optional"></see>
    /// </summary>
    let Optional = _prefix "Optional"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OralNotice"></see>
    /// </summary>
    let OralNotice = _prefix "OralNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationComplianceManagement"></see>
    /// </summary>
    let OrganisationComplianceManagement = _prefix "OrganisationComplianceManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationRiskManagement"></see>
    /// </summary>
    let OrganisationRiskManagement = _prefix "OrganisationRiskManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationalUnit"></see>
    /// </summary>
    let OrganisationalUnit = _prefix "OrganisationalUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Organise"></see>
    /// </summary>
    let Organise = _prefix "Organise"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PIA"></see>
    /// </summary>
    let PIA = _prefix "PIA"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ParentLegalEntity"></see>
    /// </summary>
    let ParentLegalEntity = _prefix "ParentLegalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ParentOfDataSubject"></see>
    /// </summary>
    let ParentOfDataSubject = _prefix "ParentOfDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ParentOfHuman"></see>
    /// </summary>
    let ParentOfHuman = _prefix "ParentOfHuman"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PartialAutomation"></see>
    /// </summary>
    let PartialAutomation = _prefix "PartialAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PartiallyCompliant"></see>
    /// </summary>
    let PartiallyCompliant = _prefix "PartiallyCompliant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Participant"></see>
    /// </summary>
    let Participant = _prefix "Participant"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PassiveRight"></see>
    /// </summary>
    let PassiveRight = _prefix "PassiveRight"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PassivelyInvolved"></see>
    /// </summary>
    let PassivelyInvolved = _prefix "PassivelyInvolved"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PasswordAuthentication"></see>
    /// </summary>
    let PasswordAuthentication = _prefix "PasswordAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Patient"></see>
    /// </summary>
    let Patient = _prefix "Patient"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PaymentManagement"></see>
    /// </summary>
    let PaymentManagement = _prefix "PaymentManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceProvision"></see>
    /// </summary>
    let ServiceProvision = _prefix "ServiceProvision"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PenetrationTestingMethods"></see>
    /// </summary>
    let PenetrationTestingMethods = _prefix "PenetrationTestingMethods"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Permission"></see>
    /// </summary>
    let Permission = _prefix "Permission"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PermissionNotUtilised"></see>
    /// </summary>
    let PermissionNotUtilised = _prefix "PermissionNotUtilised"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PermissionUtilised"></see>
    /// </summary>
    let PermissionUtilised = _prefix "PermissionUtilised"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalDataAudit"></see>
    /// </summary>
    let PersonalDataAudit = _prefix "PersonalDataAudit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalDataHandling"></see>
    /// </summary>
    let PersonalDataHandling = _prefix "PersonalDataHandling"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalDataProcess"></see>
    /// </summary>
    let PersonalDataProcess = _prefix "PersonalDataProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalSpace"></see>
    /// </summary>
    let PersonalSpace = _prefix "PersonalSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Personalisation"></see>
    /// </summary>
    let Personalisation = _prefix "Personalisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalisedAdvertising"></see>
    /// </summary>
    let PersonalisedAdvertising = _prefix "PersonalisedAdvertising"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalisedBenefits"></see>
    /// </summary>
    let PersonalisedBenefits = _prefix "PersonalisedBenefits"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServicePersonalisation"></see>
    /// </summary>
    let ServicePersonalisation = _prefix "ServicePersonalisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelBehaviourMonitoring"></see>
    /// </summary>
    let PersonnelBehaviourMonitoring = _prefix "PersonnelBehaviourMonitoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelMonitoring"></see>
    /// </summary>
    let PersonnelMonitoring = _prefix "PersonnelMonitoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelHiring"></see>
    /// </summary>
    let PersonnelHiring = _prefix "PersonnelHiring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelManagement"></see>
    /// </summary>
    let PersonnelManagement = _prefix "PersonnelManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelOffboarding"></see>
    /// </summary>
    let PersonnelOffboarding = _prefix "PersonnelOffboarding"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelOnboarding"></see>
    /// </summary>
    let PersonnelOnboarding = _prefix "PersonnelOnboarding"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPayment"></see>
    /// </summary>
    let PersonnelPayment = _prefix "PersonnelPayment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformanceEvaluation"></see>
    /// </summary>
    let PersonnelPerformanceEvaluation = _prefix "PersonnelPerformanceEvaluation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformanceManagement"></see>
    /// </summary>
    let PersonnelPerformanceManagement = _prefix "PersonnelPerformanceManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformanceMonitoring"></see>
    /// </summary>
    let PersonnelPerformanceMonitoring = _prefix "PersonnelPerformanceMonitoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformancePrediction"></see>
    /// </summary>
    let PersonnelPerformancePrediction = _prefix "PersonnelPerformancePrediction"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPromotionManagement"></see>
    /// </summary>
    let PersonnelPromotionManagement = _prefix "PersonnelPromotionManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelTerminationManagement"></see>
    /// </summary>
    let PersonnelTerminationManagement = _prefix "PersonnelTerminationManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelWorkloadManagement"></see>
    /// </summary>
    let PersonnelWorkloadManagement = _prefix "PersonnelWorkloadManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalAccessControlMethod"></see>
    /// </summary>
    let PhysicalAccessControlMethod = _prefix "PhysicalAccessControlMethod"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalAuthentication"></see>
    /// </summary>
    let PhysicalAuthentication = _prefix "PhysicalAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalAuthorisation"></see>
    /// </summary>
    let PhysicalAuthorisation = _prefix "PhysicalAuthorisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalDeviceSecurity"></see>
    /// </summary>
    let PhysicalDeviceSecurity = _prefix "PhysicalDeviceSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalInterceptionProtection"></see>
    /// </summary>
    let PhysicalInterceptionProtection = _prefix "PhysicalInterceptionProtection"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalInterruptionProtection"></see>
    /// </summary>
    let PhysicalInterruptionProtection = _prefix "PhysicalInterruptionProtection"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalNetworkSecurity"></see>
    /// </summary>
    let PhysicalNetworkSecurity = _prefix "PhysicalNetworkSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalSecureStorage"></see>
    /// </summary>
    let PhysicalSecureStorage = _prefix "PhysicalSecureStorage"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalSupplySecurity"></see>
    /// </summary>
    let PhysicalSupplySecurity = _prefix "PhysicalSupplySecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalSurveillance"></see>
    /// </summary>
    let PhysicalSurveillance = _prefix "PhysicalSurveillance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PoliticalCampaign"></see>
    /// </summary>
    let PoliticalCampaign = _prefix "PoliticalCampaign"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PostQuantumCryptography"></see>
    /// </summary>
    let PostQuantumCryptography = _prefix "PostQuantumCryptography"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PostedNotice"></see>
    /// </summary>
    let PostedNotice = _prefix "PostedNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrimaryImportance"></see>
    /// </summary>
    let PrimaryImportance = _prefix "PrimaryImportance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrimaryUse"></see>
    /// </summary>
    let PrimaryUse = _prefix "PrimaryUse"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Principle"></see>
    /// </summary>
    let Principle = _prefix "Principle"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrintedNotice"></see>
    /// </summary>
    let PrintedNotice = _prefix "PrintedNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyByDefault"></see>
    /// </summary>
    let PrivacyByDefault = _prefix "PrivacyByDefault"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyByDesign"></see>
    /// </summary>
    let PrivacyByDesign = _prefix "PrivacyByDesign"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyPreservingProtocol"></see>
    /// </summary>
    let PrivacyPreservingProtocol = _prefix "PrivacyPreservingProtocol"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateCommunalSpace"></see>
    /// </summary>
    let PrivateCommunalSpace = _prefix "PrivateCommunalSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateInformationRetrieval"></see>
    /// </summary>
    let PrivateInformationRetrieval = _prefix "PrivateInformationRetrieval"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateLocation"></see>
    /// </summary>
    let PrivateLocation = _prefix "PrivateLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateSectorBody"></see>
    /// </summary>
    let PrivateSectorBody = _prefix "PrivateSectorBody"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivatelyOperatedPublicSpace"></see>
    /// </summary>
    let PrivatelyOperatedPublicSpace = _prefix "PrivatelyOperatedPublicSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PubliclyAccessibleSpace"></see>
    /// </summary>
    let PubliclyAccessibleSpace = _prefix "PubliclyAccessibleSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivatelyOwnedPublicSpace"></see>
    /// </summary>
    let PrivatelyOwnedPublicSpace = _prefix "PrivatelyOwnedPublicSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivatelyOwnedSpace"></see>
    /// </summary>
    let PrivatelyOwnedSpace = _prefix "PrivatelyOwnedSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingCondition"></see>
    /// </summary>
    let ProcessingCondition = _prefix "ProcessingCondition"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingDuration"></see>
    /// </summary>
    let ProcessingDuration = _prefix "ProcessingDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingLocation"></see>
    /// </summary>
    let ProcessingLocation = _prefix "ProcessingLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProfessionalConfidentialData"></see>
    /// </summary>
    let ProfessionalConfidentialData = _prefix "ProfessionalConfidentialData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProfessionalTraining"></see>
    /// </summary>
    let ProfessionalTraining = _prefix "ProfessionalTraining"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Profiling"></see>
    /// </summary>
    let Profiling = _prefix "Profiling"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Prohibition"></see>
    /// </summary>
    let Prohibition = _prefix "Prohibition"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProhibitionUnviolated"></see>
    /// </summary>
    let ProhibitionUnviolated = _prefix "ProhibitionUnviolated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProhibitionViolated"></see>
    /// </summary>
    let ProhibitionViolated = _prefix "ProhibitionViolated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProtectionOfIPR"></see>
    /// </summary>
    let ProtectionOfIPR = _prefix "ProtectionOfIPR"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProtectionOfNationalSecurity"></see>
    /// </summary>
    let ProtectionOfNationalSecurity = _prefix "ProtectionOfNationalSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProtectionOfPublicSecurity"></see>
    /// </summary>
    let ProtectionOfPublicSecurity = _prefix "ProtectionOfPublicSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideEventRecommendations"></see>
    /// </summary>
    let ProvideEventRecommendations = _prefix "ProvideEventRecommendations"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvidePersonalisedRecommendations"></see>
    /// </summary>
    let ProvidePersonalisedRecommendations =
        _prefix "ProvidePersonalisedRecommendations"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideOfficialStatistics"></see>
    /// </summary>
    let ProvideOfficialStatistics = _prefix "ProvideOfficialStatistics"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideProductRecommendations"></see>
    /// </summary>
    let ProvideProductRecommendations = _prefix "ProvideProductRecommendations"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvidedData"></see>
    /// </summary>
    let ProvidedData = _prefix "ProvidedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvidedPersonalData"></see>
    /// </summary>
    let ProvidedPersonalData = _prefix "ProvidedPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProviderStandardFormContract"></see>
    /// </summary>
    let ProviderStandardFormContract = _prefix "ProviderStandardFormContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Pseudonymise"></see>
    /// </summary>
    let Pseudonymise = _prefix "Pseudonymise"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicDataSource"></see>
    /// </summary>
    let PublicDataSource = _prefix "PublicDataSource"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterest"></see>
    /// </summary>
    let PublicInterest = _prefix "PublicInterest"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestCompleted"></see>
    /// </summary>
    let PublicInterestCompleted = _prefix "PublicInterestCompleted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestStatus"></see>
    /// </summary>
    let PublicInterestStatus = _prefix "PublicInterestStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestObjected"></see>
    /// </summary>
    let PublicInterestObjected = _prefix "PublicInterestObjected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestOngoing"></see>
    /// </summary>
    let PublicInterestOngoing = _prefix "PublicInterestOngoing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestPending"></see>
    /// </summary>
    let PublicInterestPending = _prefix "PublicInterestPending"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicLocation"></see>
    /// </summary>
    let PublicLocation = _prefix "PublicLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicPolicyMaking"></see>
    /// </summary>
    let PublicPolicyMaking = _prefix "PublicPolicyMaking"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicRegisterOfEntities"></see>
    /// </summary>
    let PublicRegisterOfEntities = _prefix "PublicRegisterOfEntities"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicRelations"></see>
    /// </summary>
    let PublicRelations = _prefix "PublicRelations"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicSectorBody"></see>
    /// </summary>
    let PublicSectorBody = _prefix "PublicSectorBody"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PubliclyOwnedSpace"></see>
    /// </summary>
    let PubliclyOwnedSpace = _prefix "PubliclyOwnedSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#QuantumCryptography"></see>
    /// </summary>
    let QuantumCryptography = _prefix "QuantumCryptography"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Query"></see>
    /// </summary>
    let Query = _prefix "Query"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RNGPseudonymisation"></see>
    /// </summary>
    let RNGPseudonymisation = _prefix "RNGPseudonymisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ROPA"></see>
    /// </summary>
    let ROPA = _prefix "ROPA"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RandomLocation"></see>
    /// </summary>
    let RandomLocation = _prefix "RandomLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecertificationPolicy"></see>
    /// </summary>
    let RecertificationPolicy = _prefix "RecertificationPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecipientInformed"></see>
    /// </summary>
    let RecipientInformed = _prefix "RecipientInformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecipientUninformed"></see>
    /// </summary>
    let RecipientUninformed = _prefix "RecipientUninformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Recommendation"></see>
    /// </summary>
    let Recommendation = _prefix "Recommendation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecommendationFollowed"></see>
    /// </summary>
    let RecommendationFollowed = _prefix "RecommendationFollowed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecommendationNotFollowed"></see>
    /// </summary>
    let RecommendationNotFollowed = _prefix "RecommendationNotFollowed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Record"></see>
    /// </summary>
    let Record = _prefix "Record"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecordManagement"></see>
    /// </summary>
    let RecordManagement = _prefix "RecordManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentAdvertising"></see>
    /// </summary>
    let RecruitmentAdvertising = _prefix "RecruitmentAdvertising"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantBackgroundCheck"></see>
    /// </summary>
    let RecruitmentApplicantBackgroundCheck =
        _prefix "RecruitmentApplicantBackgroundCheck"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentManagement"></see>
    /// </summary>
    let RecruitmentManagement = _prefix "RecruitmentManagement"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantCriminalBackgroundCheck"></see>
    /// </summary>
    let RecruitmentApplicantCriminalBackgroundCheck =
        _prefix "RecruitmentApplicantCriminalBackgroundCheck"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantInformationAuthentication"></see>
    /// </summary>
    let RecruitmentApplicantInformationAuthentication =
        _prefix "RecruitmentApplicantInformationAuthentication"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantSelection"></see>
    /// </summary>
    let RecruitmentApplicantSelection = _prefix "RecruitmentApplicantSelection"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicationAnalysis"></see>
    /// </summary>
    let RecruitmentApplicationAnalysis = _prefix "RecruitmentApplicationAnalysis"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicationManagement"></see>
    /// </summary>
    let RecruitmentApplicationManagement = _prefix "RecruitmentApplicationManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicationScreening"></see>
    /// </summary>
    let RecruitmentApplicationScreening = _prefix "RecruitmentApplicationScreening"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewAnalysis"></see>
    /// </summary>
    let RecruitmentInterviewAnalysis = _prefix "RecruitmentInterviewAnalysis"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewManagement"></see>
    /// </summary>
    let RecruitmentInterviewManagement = _prefix "RecruitmentInterviewManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewAssessment"></see>
    /// </summary>
    let RecruitmentInterviewAssessment = _prefix "RecruitmentInterviewAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewScheduling"></see>
    /// </summary>
    let RecruitmentInterviewScheduling = _prefix "RecruitmentInterviewScheduling"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentTargetedAdvertising"></see>
    /// </summary>
    let RecruitmentTargetedAdvertising = _prefix "RecruitmentTargetedAdvertising"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TargetedAdvertising"></see>
    /// </summary>
    let TargetedAdvertising = _prefix "TargetedAdvertising"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Reformat"></see>
    /// </summary>
    let Reformat = _prefix "Reformat"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RefuseConsent"></see>
    /// </summary>
    let RefuseConsent = _prefix "RefuseConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RefuseContract"></see>
    /// </summary>
    let RefuseContract = _prefix "RefuseContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RegionalAuthority"></see>
    /// </summary>
    let RegionalAuthority = _prefix "RegionalAuthority"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RegionalScale"></see>
    /// </summary>
    let RegionalScale = _prefix "RegionalScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RegulatorySandbox"></see>
    /// </summary>
    let RegulatorySandbox = _prefix "RegulatorySandbox"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Safeguard"></see>
    /// </summary>
    let Safeguard = _prefix "Safeguard"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReligiousAssociations"></see>
    /// </summary>
    let ReligiousAssociations = _prefix "ReligiousAssociations"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RenewedConsentGiven"></see>
    /// </summary>
    let RenewedConsentGiven = _prefix "RenewedConsentGiven"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RepairImpairments"></see>
    /// </summary>
    let RepairImpairments = _prefix "RepairImpairments"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestAccepted"></see>
    /// </summary>
    let RequestAccepted = _prefix "RequestAccepted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestStatus"></see>
    /// </summary>
    let RequestStatus = _prefix "RequestStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestAcknowledged"></see>
    /// </summary>
    let RequestAcknowledged = _prefix "RequestAcknowledged"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestActionDelayed"></see>
    /// </summary>
    let RequestActionDelayed = _prefix "RequestActionDelayed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestFulfilled"></see>
    /// </summary>
    let RequestFulfilled = _prefix "RequestFulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestInitiated"></see>
    /// </summary>
    let RequestInitiated = _prefix "RequestInitiated"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestRejected"></see>
    /// </summary>
    let RequestRejected = _prefix "RequestRejected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestRequiredActionPerformed"></see>
    /// </summary>
    let RequestRequiredActionPerformed = _prefix "RequestRequiredActionPerformed"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestRequiresAction"></see>
    /// </summary>
    let RequestRequiresAction = _prefix "RequestRequiresAction"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestStatusQuery"></see>
    /// </summary>
    let RequestStatusQuery = _prefix "RequestStatusQuery"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestUnfulfilled"></see>
    /// </summary>
    let RequestUnfulfilled = _prefix "RequestUnfulfilled"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Required"></see>
    /// </summary>
    let Required = _prefix "Required"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ResidualRisk"></see>
    /// </summary>
    let ResidualRisk = _prefix "ResidualRisk"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Risk"></see>
    /// </summary>
    let Risk = _prefix "Risk"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Restrict"></see>
    /// </summary>
    let Restrict = _prefix "Restrict"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Retrieve"></see>
    /// </summary>
    let Retrieve = _prefix "Retrieve"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReversingProcessEffects"></see>
    /// </summary>
    let ReversingProcessEffects = _prefix "ReversingProcessEffects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReversingProcessInput"></see>
    /// </summary>
    let ReversingProcessInput = _prefix "ReversingProcessInput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReversingProcessOutput"></see>
    /// </summary>
    let ReversingProcessOutput = _prefix "ReversingProcessOutput"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReviewImpactAssessment"></see>
    /// </summary>
    let ReviewImpactAssessment = _prefix "ReviewImpactAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReviewProcedure"></see>
    /// </summary>
    let ReviewProcedure = _prefix "ReviewProcedure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightExerciseNotice"></see>
    /// </summary>
    let RightExerciseNotice = _prefix "RightExerciseNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightNotice"></see>
    /// </summary>
    let RightNotice = _prefix "RightNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightFulfilmentNotice"></see>
    /// </summary>
    let RightFulfilmentNotice = _prefix "RightFulfilmentNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightNonFulfilmentNotice"></see>
    /// </summary>
    let RightNonFulfilmentNotice = _prefix "RightNonFulfilmentNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightsFulfilment"></see>
    /// </summary>
    let RightsFulfilment = _prefix "RightsFulfilment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskLevel"></see>
    /// </summary>
    let RiskLevel = _prefix "RiskLevel"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskMitigationMeasure"></see>
    /// </summary>
    let RiskMitigationMeasure = _prefix "RiskMitigationMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SMEOrganisation"></see>
    /// </summary>
    let SMEOrganisation = _prefix "SMEOrganisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SafeguardForDataTransfer"></see>
    /// </summary>
    let SafeguardForDataTransfer = _prefix "SafeguardForDataTransfer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ScientificResearch"></see>
    /// </summary>
    let ScientificResearch = _prefix "ScientificResearch"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Scope"></see>
    /// </summary>
    let Scope = _prefix "Scope"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Screen"></see>
    /// </summary>
    let Screen = _prefix "Screen"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Seal"></see>
    /// </summary>
    let Seal = _prefix "Seal"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SearchFunctionalities"></see>
    /// </summary>
    let SearchFunctionalities = _prefix "SearchFunctionalities"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecondaryImportance"></see>
    /// </summary>
    let SecondaryImportance = _prefix "SecondaryImportance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecondaryUse"></see>
    /// </summary>
    let SecondaryUse = _prefix "SecondaryUse"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecretSharingSchemes"></see>
    /// </summary>
    let SecretSharingSchemes = _prefix "SecretSharingSchemes"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Sector"></see>
    /// </summary>
    let Sector = _prefix "Sector"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecureMultiPartyComputation"></see>
    /// </summary>
    let SecureMultiPartyComputation = _prefix "SecureMultiPartyComputation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecureProcessingEnvironment"></see>
    /// </summary>
    let SecureProcessingEnvironment = _prefix "SecureProcessingEnvironment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityAudit"></see>
    /// </summary>
    let SecurityAudit = _prefix "SecurityAudit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityIncidentRecord"></see>
    /// </summary>
    let SecurityIncidentRecord = _prefix "SecurityIncidentRecord"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityKnowledgeTraining"></see>
    /// </summary>
    let SecurityKnowledgeTraining = _prefix "SecurityKnowledgeTraining"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityRoleProcedures"></see>
    /// </summary>
    let SecurityRoleProcedures = _prefix "SecurityRoleProcedures"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellDataToThirdParties"></see>
    /// </summary>
    let SellDataToThirdParties = _prefix "SellDataToThirdParties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellProducts"></see>
    /// </summary>
    let SellProducts = _prefix "SellProducts"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellInsightsFromData"></see>
    /// </summary>
    let SellInsightsFromData = _prefix "SellInsightsFromData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellProductsToDataSubject"></see>
    /// </summary>
    let SellProductsToDataSubject = _prefix "SellProductsToDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SemiPrivateSpace"></see>
    /// </summary>
    let SemiPrivateSpace = _prefix "SemiPrivateSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitiveData"></see>
    /// </summary>
    let SensitiveData = _prefix "SensitiveData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitiveNonPersonalData"></see>
    /// </summary>
    let SensitiveNonPersonalData = _prefix "SensitiveNonPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitivePersonalData"></see>
    /// </summary>
    let SensitivePersonalData = _prefix "SensitivePersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitivityLevel"></see>
    /// </summary>
    let SensitivityLevel = _prefix "SensitivityLevel"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Severity"></see>
    /// </summary>
    let Severity = _prefix "Severity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceConsumer"></see>
    /// </summary>
    let ServiceConsumer = _prefix "ServiceConsumer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceLevelAgreement"></see>
    /// </summary>
    let ServiceLevelAgreement = _prefix "ServiceLevelAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceProvider"></see>
    /// </summary>
    let ServiceProvider = _prefix "ServiceProvider"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceRegistration"></see>
    /// </summary>
    let ServiceRegistration = _prefix "ServiceRegistration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceUsageAnalytics"></see>
    /// </summary>
    let ServiceUsageAnalytics = _prefix "ServiceUsageAnalytics"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Share"></see>
    /// </summary>
    let Share = _prefix "Share"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingleSignOn"></see>
    /// </summary>
    let SingleSignOn = _prefix "SingleSignOn"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingularDataVolume"></see>
    /// </summary>
    let SingularDataVolume = _prefix "SingularDataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingularFrequency"></see>
    /// </summary>
    let SingularFrequency = _prefix "SingularFrequency"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingularScaleOfDataSubjects"></see>
    /// </summary>
    let SingularScaleOfDataSubjects = _prefix "SingularScaleOfDataSubjects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SmallDataVolume"></see>
    /// </summary>
    let SmallDataVolume = _prefix "SmallDataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SmallScaleOfDataSubjects"></see>
    /// </summary>
    let SmallScaleOfDataSubjects = _prefix "SmallScaleOfDataSubjects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SmallScaleProcessing"></see>
    /// </summary>
    let SmallScaleProcessing = _prefix "SmallScaleProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SocialMediaMarketing"></see>
    /// </summary>
    let SocialMediaMarketing = _prefix "SocialMediaMarketing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SpecialCategoryPersonalData"></see>
    /// </summary>
    let SpecialCategoryPersonalData = _prefix "SpecialCategoryPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SporadicDataVolume"></see>
    /// </summary>
    let SporadicDataVolume = _prefix "SporadicDataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SporadicFrequency"></see>
    /// </summary>
    let SporadicFrequency = _prefix "SporadicFrequency"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SporadicScaleOfDataSubjects"></see>
    /// </summary>
    let SporadicScaleOfDataSubjects = _prefix "SporadicScaleOfDataSubjects"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StandardsConformance"></see>
    /// </summary>
    let StandardsConformance = _prefix "StandardsConformance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StartupOrganisation"></see>
    /// </summary>
    let StartupOrganisation = _prefix "StartupOrganisation"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StatisticalConfidentialityAgreement"></see>
    /// </summary>
    let StatisticalConfidentialityAgreement =
        _prefix "StatisticalConfidentialityAgreement"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StatisticallyConfidentialData"></see>
    /// </summary>
    let StatisticallyConfidentialData = _prefix "StatisticallyConfidentialData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageCondition"></see>
    /// </summary>
    let StorageCondition = _prefix "StorageCondition"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageDeletion"></see>
    /// </summary>
    let StorageDeletion = _prefix "StorageDeletion"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageDuration"></see>
    /// </summary>
    let StorageDuration = _prefix "StorageDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageLocation"></see>
    /// </summary>
    let StorageLocation = _prefix "StorageLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageRestoration"></see>
    /// </summary>
    let StorageRestoration = _prefix "StorageRestoration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Store"></see>
    /// </summary>
    let Store = _prefix "Store"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Student"></see>
    /// </summary>
    let Student = _prefix "Student"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SubProcessorAgreement"></see>
    /// </summary>
    let SubProcessorAgreement = _prefix "SubProcessorAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Subscriber"></see>
    /// </summary>
    let Subscriber = _prefix "Subscriber"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SubsidiaryLegalEntity"></see>
    /// </summary>
    let SubsidiaryLegalEntity = _prefix "SubsidiaryLegalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportContractNegotiation"></see>
    /// </summary>
    let SupportContractNegotiation = _prefix "SupportContractNegotiation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportEntityDecisionMaking"></see>
    /// </summary>
    let SupportEntityDecisionMaking = _prefix "SupportEntityDecisionMaking"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportExchangeOfViews"></see>
    /// </summary>
    let SupportExchangeOfViews = _prefix "SupportExchangeOfViews"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportInformedConsentDecision"></see>
    /// </summary>
    let SupportInformedConsentDecision = _prefix "SupportInformedConsentDecision"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupraNationalAuthority"></see>
    /// </summary>
    let SupraNationalAuthority = _prefix "SupraNationalAuthority"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupraNationalUnion"></see>
    /// </summary>
    let SupraNationalUnion = _prefix "SupraNationalUnion"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SymmetricCryptography"></see>
    /// </summary>
    let SymmetricCryptography = _prefix "SymmetricCryptography"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SymmetricEncryption"></see>
    /// </summary>
    let SymmetricEncryption = _prefix "SymmetricEncryption"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SyntheticData"></see>
    /// </summary>
    let SyntheticData = _prefix "SyntheticData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#SystematicMonitoring"></see>
    /// </summary>
    let SystematicMonitoring = _prefix "SystematicMonitoring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TOM-properties"></see>
    /// </summary>
    let ``TOM-properties`` = _prefix "TOM-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalServiceProvision"></see>
    /// </summary>
    let TechnicalServiceProvision = _prefix "TechnicalServiceProvision"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalStandard"></see>
    /// </summary>
    let TechnicalStandard = _prefix "TechnicalStandard"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Technology"></see>
    /// </summary>
    let Technology = _prefix "Technology"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TemporalDuration"></see>
    /// </summary>
    let TemporalDuration = _prefix "TemporalDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TerminateContract"></see>
    /// </summary>
    let TerminateContract = _prefix "TerminateContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TermsOfService"></see>
    /// </summary>
    let TermsOfService = _prefix "TermsOfService"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdCountry"></see>
    /// </summary>
    let ThirdCountry = _prefix "ThirdCountry"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdParty"></see>
    /// </summary>
    let ThirdParty = _prefix "ThirdParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartyAgreement"></see>
    /// </summary>
    let ThirdPartyAgreement = _prefix "ThirdPartyAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartyContract"></see>
    /// </summary>
    let ThirdPartyContract = _prefix "ThirdPartyContract"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartyDataSource"></see>
    /// </summary>
    let ThirdPartyDataSource = _prefix "ThirdPartyDataSource"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartySecurityProcedures"></see>
    /// </summary>
    let ThirdPartySecurityProcedures = _prefix "ThirdPartySecurityProcedures"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Tourist"></see>
    /// </summary>
    let Tourist = _prefix "Tourist"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Tracking"></see>
    /// </summary>
    let Tracking = _prefix "Tracking"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrackingByFirstParty"></see>
    /// </summary>
    let TrackingByFirstParty = _prefix "TrackingByFirstParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrackingByThirdParty"></see>
    /// </summary>
    let TrackingByThirdParty = _prefix "TrackingByThirdParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Transmit"></see>
    /// </summary>
    let Transmit = _prefix "Transmit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrustedComputing"></see>
    /// </summary>
    let TrustedComputing = _prefix "TrustedComputing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrustedExecutionEnvironment"></see>
    /// </summary>
    let TrustedExecutionEnvironment = _prefix "TrustedExecutionEnvironment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UncategorisedData"></see>
    /// </summary>
    let UncategorisedData = _prefix "UncategorisedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Unexpected"></see>
    /// </summary>
    let Unexpected = _prefix "Unexpected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UninformedConsent"></see>
    /// </summary>
    let UninformedConsent = _prefix "UninformedConsent"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnknownApplicability"></see>
    /// </summary>
    let UnknownApplicability = _prefix "UnknownApplicability"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Unlawful"></see>
    /// </summary>
    let Unlawful = _prefix "Unlawful"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnstructuredData"></see>
    /// </summary>
    let UnstructuredData = _prefix "UnstructuredData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UntilEventDuration"></see>
    /// </summary>
    let UntilEventDuration = _prefix "UntilEventDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UntilTimeDuration"></see>
    /// </summary>
    let UntilTimeDuration = _prefix "UntilTimeDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnverifiedData"></see>
    /// </summary>
    let UnverifiedData = _prefix "UnverifiedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UsageControl"></see>
    /// </summary>
    let UsageControl = _prefix "UsageControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UseSyntheticData"></see>
    /// </summary>
    let UseSyntheticData = _prefix "UseSyntheticData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#User"></see>
    /// </summary>
    let User = _prefix "User"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#UserInterfacePersonalisation"></see>
    /// </summary>
    let UserInterfacePersonalisation = _prefix "UserInterfacePersonalisation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VariableLocation"></see>
    /// </summary>
    let VariableLocation = _prefix "VariableLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorManagement"></see>
    /// </summary>
    let VendorManagement = _prefix "VendorManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorPayment"></see>
    /// </summary>
    let VendorPayment = _prefix "VendorPayment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorRecordsManagement"></see>
    /// </summary>
    let VendorRecordsManagement = _prefix "VendorRecordsManagement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorSelectionAssessment"></see>
    /// </summary>
    let VendorSelectionAssessment = _prefix "VendorSelectionAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VerifiedData"></see>
    /// </summary>
    let VerifiedData = _prefix "VerifiedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VirtualisationSecurity"></see>
    /// </summary>
    let VirtualisationSecurity = _prefix "VirtualisationSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Visitor"></see>
    /// </summary>
    let Visitor = _prefix "Visitor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterest"></see>
    /// </summary>
    let VitalInterest = _prefix "VitalInterest"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestCompleted"></see>
    /// </summary>
    let VitalInterestCompleted = _prefix "VitalInterestCompleted"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestStatus"></see>
    /// </summary>
    let VitalInterestStatus = _prefix "VitalInterestStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestObjected"></see>
    /// </summary>
    let VitalInterestObjected = _prefix "VitalInterestObjected"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestOfDataSubject"></see>
    /// </summary>
    let VitalInterestOfDataSubject = _prefix "VitalInterestOfDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestOfNaturalPerson"></see>
    /// </summary>
    let VitalInterestOfNaturalPerson = _prefix "VitalInterestOfNaturalPerson"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestOngoing"></see>
    /// </summary>
    let VitalInterestOngoing = _prefix "VitalInterestOngoing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestPending"></see>
    /// </summary>
    let VitalInterestPending = _prefix "VitalInterestPending"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#VulnerabilityTestingMethods"></see>
    /// </summary>
    let VulnerabilityTestingMethods = _prefix "VulnerabilityTestingMethods"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WebBrowserSecurity"></see>
    /// </summary>
    let WebBrowserSecurity = _prefix "WebBrowserSecurity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WebSecurityProtocols"></see>
    /// </summary>
    let WebSecurityProtocols = _prefix "WebSecurityProtocols"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WirelessSecurityProtocols"></see>
    /// </summary>
    let WirelessSecurityProtocols = _prefix "WirelessSecurityProtocols"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithdrawingFromProcess"></see>
    /// </summary>
    let WithdrawingFromProcess = _prefix "WithdrawingFromProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithinDevice"></see>
    /// </summary>
    let WithinDevice = _prefix "WithinDevice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithinPhysicalEnvironment"></see>
    /// </summary>
    let WithinPhysicalEnvironment = _prefix "WithinPhysicalEnvironment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithinVirtualEnvironment"></see>
    /// </summary>
    let WithinVirtualEnvironment = _prefix "WithinVirtualEnvironment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#ZeroKnowledgeAuthentication"></see>
    /// </summary>
    let ZeroKnowledgeAuthentication = _prefix "ZeroKnowledgeAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-properties"></see>
    /// </summary>
    let ``consent-properties`` = _prefix "consent-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#context-properties"></see>
    /// </summary>
    let ``context-properties`` = _prefix "context-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-properties"></see>
    /// </summary>
    let ``contract-properties`` = _prefix "contract-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-authority-properties"></see>
    /// </summary>
    let ``entities-authority-properties`` = _prefix "entities-authority-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-datasubject-properties"></see>
    /// </summary>
    let ``entities-datasubject-properties`` = _prefix "entities-datasubject-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-legalrole-properties"></see>
    /// </summary>
    let ``entities-legalrole-properties`` = _prefix "entities-legalrole-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-properties"></see>
    /// </summary>
    let ``entities-properties`` = _prefix "entities-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasActiveEntity"></see>
    /// </summary>
    let hasActiveEntity = _prefix "hasActiveEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasEntity"></see>
    /// </summary>
    let hasEntity = _prefix "hasEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-context-properties"></see>
    /// </summary>
    let ``processing-context-properties`` = _prefix "processing-context-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasActivityStatus"></see>
    /// </summary>
    let hasActivityStatus = _prefix "hasActivityStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasStatus"></see>
    /// </summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#status-properties"></see>
    /// </summary>
    let ``status-properties`` = _prefix "status-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAddress"></see>
    /// </summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAlgorithmicLogic"></see>
    /// </summary>
    let hasAlgorithmicLogic = _prefix "hasAlgorithmicLogic"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasApplicability"></see>
    /// </summary>
    let hasApplicability = _prefix "hasApplicability"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasApplicableLaw"></see>
    /// </summary>
    let hasApplicableLaw = _prefix "hasApplicableLaw"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#jurisdiction-properties"></see>
    /// </summary>
    let ``jurisdiction-properties`` = _prefix "jurisdiction-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAssessment"></see>
    /// </summary>
    let hasAssessment = _prefix "hasAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasOrganisationalMeasure"></see>
    /// </summary>
    let hasOrganisationalMeasure = _prefix "hasOrganisationalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAuditStatus"></see>
    /// </summary>
    let hasAuditStatus = _prefix "hasAuditStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAuthority"></see>
    /// </summary>
    let hasAuthority = _prefix "hasAuthority"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAutomationLevel"></see>
    /// </summary>
    let hasAutomationLevel = _prefix "hasAutomationLevel"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasComplianceStatus"></see>
    /// </summary>
    let hasComplianceStatus = _prefix "hasComplianceStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConformanceStatus"></see>
    /// </summary>
    let hasConformanceStatus = _prefix "hasConformanceStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsentControl"></see>
    /// </summary>
    let hasConsentControl = _prefix "hasConsentControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsentStatus"></see>
    /// </summary>
    let hasConsentStatus = _prefix "hasConsentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsequence"></see>
    /// </summary>
    let hasConsequence = _prefix "hasConsequence"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#risk-properties"></see>
    /// </summary>
    let ``risk-properties`` = _prefix "risk-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsequenceOn"></see>
    /// </summary>
    let hasConsequenceOn = _prefix "hasConsequenceOn"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContact"></see>
    /// </summary>
    let hasContact = _prefix "hasContact"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContext"></see>
    /// </summary>
    let hasContext = _prefix "hasContext"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractControl"></see>
    /// </summary>
    let hasContractControl = _prefix "hasContractControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractStatus"></see>
    /// </summary>
    let hasContractStatus = _prefix "hasContractStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractualClause"></see>
    /// </summary>
    let hasContractualClause = _prefix "hasContractualClause"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractualFulfilmentStatus"></see>
    /// </summary>
    let hasContractualFulfilmentStatus = _prefix "hasContractualFulfilmentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasCountry"></see>
    /// </summary>
    let hasCountry = _prefix "hasCountry"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLocation"></see>
    /// </summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasData"></see>
    /// </summary>
    let hasData = _prefix "hasData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#personal-data-properties"></see>
    /// </summary>
    let ``personal-data-properties`` = _prefix "personal-data-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataController"></see>
    /// </summary>
    let hasDataController = _prefix "hasDataController"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataExporter"></see>
    /// </summary>
    let hasDataExporter = _prefix "hasDataExporter"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataImporter"></see>
    /// </summary>
    let hasDataImporter = _prefix "hasDataImporter"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecipient"></see>
    /// </summary>
    let hasRecipient = _prefix "hasRecipient"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataProcessor"></see>
    /// </summary>
    let hasDataProcessor = _prefix "hasDataProcessor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataProtectionOfficer"></see>
    /// </summary>
    let hasDataProtectionOfficer = _prefix "hasDataProtectionOfficer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRepresentative"></see>
    /// </summary>
    let hasRepresentative = _prefix "hasRepresentative"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataSource"></see>
    /// </summary>
    let hasDataSource = _prefix "hasDataSource"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataSubject"></see>
    /// </summary>
    let hasDataSubject = _prefix "hasDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasHumanSubject"></see>
    /// </summary>
    let hasHumanSubject = _prefix "hasHumanSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataSubjectScale"></see>
    /// </summary>
    let hasDataSubjectScale = _prefix "hasDataSubjectScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasScale"></see>
    /// </summary>
    let hasScale = _prefix "hasScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-scale-properties"></see>
    /// </summary>
    let ``processing-scale-properties`` = _prefix "processing-scale-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataVolume"></see>
    /// </summary>
    let hasDataVolume = _prefix "hasDataVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDeterrence"></see>
    /// </summary>
    let hasDeterrence = _prefix "hasDeterrence"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRule"></see>
    /// </summary>
    let hasRule = _prefix "hasRule"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#rules-properties"></see>
    /// </summary>
    let ``rules-properties`` = _prefix "rules-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDuration"></see>
    /// </summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasEntityControl"></see>
    /// </summary>
    let hasEntityControl = _prefix "hasEntityControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityControl"></see>
    /// </summary>
    let EntityControl = _prefix "EntityControl"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasTechnicalOrganisationalMeasure"></see>
    /// </summary>
    let hasTechnicalOrganisationalMeasure = _prefix "hasTechnicalOrganisationalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasEntityInvolvement"></see>
    /// </summary>
    let hasEntityInvolvement = _prefix "hasEntityInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasExpectation"></see>
    /// </summary>
    let hasExpectation = _prefix "hasExpectation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasFee"></see>
    /// </summary>
    let hasFee = _prefix "hasFee"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasFrequency"></see>
    /// </summary>
    let hasFrequency = _prefix "hasFrequency"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasFulfilmentStatus"></see>
    /// </summary>
    let hasFulfilmentStatus = _prefix "hasFulfilmentStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasGeographicCoverage"></see>
    /// </summary>
    let hasGeographicCoverage = _prefix "hasGeographicCoverage"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasHumanInvolvement"></see>
    /// </summary>
    let hasHumanInvolvement = _prefix "hasHumanInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasIdentifier"></see>
    /// </summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImpact"></see>
    /// </summary>
    let hasImpact = _prefix "hasImpact"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImpactAssessment"></see>
    /// </summary>
    let hasImpactAssessment = _prefix "hasImpactAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImpactOn"></see>
    /// </summary>
    let hasImpactOn = _prefix "hasImpactOn"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImportance"></see>
    /// </summary>
    let hasImportance = _prefix "hasImportance"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasIndicationMethod"></see>
    /// </summary>
    let hasIndicationMethod = _prefix "hasIndicationMethod"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-basis-properties"></see>
    /// </summary>
    let ``legal-basis-properties`` = _prefix "legal-basis-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasInformedStatus"></see>
    /// </summary>
    let hasInformedStatus = _prefix "hasInformedStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasIntention"></see>
    /// </summary>
    let hasIntention = _prefix "hasIntention"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasInverseJurisdiction"></see>
    /// </summary>
    let hasInverseJurisdiction = _prefix "hasInverseJurisdiction"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasInvolvement"></see>
    /// </summary>
    let hasInvolvement = _prefix "hasInvolvement"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasJointDataControllers"></see>
    /// </summary>
    let hasJointDataControllers = _prefix "hasJointDataControllers"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasJurisdiction"></see>
    /// </summary>
    let hasJurisdiction = _prefix "hasJurisdiction"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasJustification"></see>
    /// </summary>
    let hasJustification = _prefix "hasJustification"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLawfulness"></see>
    /// </summary>
    let hasLawfulness = _prefix "hasLawfulness"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLegalBasis"></see>
    /// </summary>
    let hasLegalBasis = _prefix "hasLegalBasis"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLegalMeasure"></see>
    /// </summary>
    let hasLegalMeasure = _prefix "hasLegalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLikelihood"></see>
    /// </summary>
    let hasLikelihood = _prefix "hasLikelihood"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNecessity"></see>
    /// </summary>
    let hasNecessity = _prefix "hasNecessity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNonInvolvedEntity"></see>
    /// </summary>
    let hasNonInvolvedEntity = _prefix "hasNonInvolvedEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNonPersonalDataProcess"></see>
    /// </summary>
    let hasNonPersonalDataProcess = _prefix "hasNonPersonalDataProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#process-properties"></see>
    /// </summary>
    let ``process-properties`` = _prefix "process-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNotice"></see>
    /// </summary>
    let hasNotice = _prefix "hasNotice"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#notice-properties"></see>
    /// </summary>
    let ``notice-properties`` = _prefix "notice-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNoticeIcon"></see>
    /// </summary>
    let hasNoticeIcon = _prefix "hasNoticeIcon"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNoticeLayer"></see>
    /// </summary>
    let hasNoticeLayer = _prefix "hasNoticeLayer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNoticeStatus"></see>
    /// </summary>
    let hasNoticeStatus = _prefix "hasNoticeStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNotificationStatus"></see>
    /// </summary>
    let hasNotificationStatus = _prefix "hasNotificationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasObligation"></see>
    /// </summary>
    let hasObligation = _prefix "hasObligation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasOrganisationalUnit"></see>
    /// </summary>
    let hasOrganisationalUnit = _prefix "hasOrganisationalUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasOutcome"></see>
    /// </summary>
    let hasOutcome = _prefix "hasOutcome"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasParty"></see>
    /// </summary>
    let hasParty = _prefix "hasParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPassiveEntity"></see>
    /// </summary>
    let hasPassiveEntity = _prefix "hasPassiveEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPermission"></see>
    /// </summary>
    let hasPermission = _prefix "hasPermission"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPersonalData"></see>
    /// </summary>
    let hasPersonalData = _prefix "hasPersonalData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPersonalDataHandling"></see>
    /// </summary>
    let hasPersonalDataHandling = _prefix "hasPersonalDataHandling"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPersonalDataProcess"></see>
    /// </summary>
    let hasPersonalDataProcess = _prefix "hasPersonalDataProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPhysicalMeasure"></see>
    /// </summary>
    let hasPhysicalMeasure = _prefix "hasPhysicalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPolicy"></see>
    /// </summary>
    let hasPolicy = _prefix "hasPolicy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcess"></see>
    /// </summary>
    let hasProcess = _prefix "hasProcess"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcessing"></see>
    /// </summary>
    let hasProcessing = _prefix "hasProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-properties"></see>
    /// </summary>
    let ``processing-properties`` = _prefix "processing-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcessingCondition"></see>
    /// </summary>
    let hasProcessingCondition = _prefix "hasProcessingCondition"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcessingScale"></see>
    /// </summary>
    let hasProcessingScale = _prefix "hasProcessingScale"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProhibition"></see>
    /// </summary>
    let hasProhibition = _prefix "hasProhibition"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPurpose"></see>
    /// </summary>
    let hasPurpose = _prefix "hasPurpose"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#purposes-properties"></see>
    /// </summary>
    let ``purposes-properties`` = _prefix "purposes-properties"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecipientDataController"></see>
    /// </summary>
    let hasRecipientDataController = _prefix "hasRecipientDataController"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecipientThirdParty"></see>
    /// </summary>
    let hasRecipientThirdParty = _prefix "hasRecipientThirdParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecommendation"></see>
    /// </summary>
    let hasRecommendation = _prefix "hasRecommendation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecordOfActivity"></see>
    /// </summary>
    let hasRecordOfActivity = _prefix "hasRecordOfActivity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRelationWithDataSubject"></see>
    /// </summary>
    let hasRelationWithDataSubject = _prefix "hasRelationWithDataSubject"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRequestStatus"></see>
    /// </summary>
    let hasRequestStatus = _prefix "hasRequestStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasResidualRisk"></see>
    /// </summary>
    let hasResidualRisk = _prefix "hasResidualRisk"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasResponsibleEntity"></see>
    /// </summary>
    let hasResponsibleEntity = _prefix "hasResponsibleEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasReuseCompatibility"></see>
    /// </summary>
    let hasReuseCompatibility = _prefix "hasReuseCompatibility"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRight"></see>
    /// </summary>
    let hasRight = _prefix "hasRight"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRisk"></see>
    /// </summary>
    let hasRisk = _prefix "hasRisk"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRiskAssessment"></see>
    /// </summary>
    let hasRiskAssessment = _prefix "hasRiskAssessment"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRiskLevel"></see>
    /// </summary>
    let hasRiskLevel = _prefix "hasRiskLevel"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasScope"></see>
    /// </summary>
    let hasScope = _prefix "hasScope"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSector"></see>
    /// </summary>
    let hasSector = _prefix "hasSector"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSensitivityLevel"></see>
    /// </summary>
    let hasSensitivityLevel = _prefix "hasSensitivityLevel"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasService"></see>
    /// </summary>
    let hasService = _prefix "hasService"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasServiceConsumer"></see>
    /// </summary>
    let hasServiceConsumer = _prefix "hasServiceConsumer"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasServiceProvider"></see>
    /// </summary>
    let hasServiceProvider = _prefix "hasServiceProvider"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSeverity"></see>
    /// </summary>
    let hasSeverity = _prefix "hasSeverity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasStorageCondition"></see>
    /// </summary>
    let hasStorageCondition = _prefix "hasStorageCondition"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSubsidiary"></see>
    /// </summary>
    let hasSubsidiary = _prefix "hasSubsidiary"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasTechnicalMeasure"></see>
    /// </summary>
    let hasTechnicalMeasure = _prefix "hasTechnicalMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasThirdCountry"></see>
    /// </summary>
    let hasThirdCountry = _prefix "hasThirdCountry"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasThirdParty"></see>
    /// </summary>
    let hasThirdParty = _prefix "hasThirdParty"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasUncategorisedData"></see>
    /// </summary>
    let hasUncategorisedData = _prefix "hasUncategorisedData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasUnstructuredData"></see>
    /// </summary>
    let hasUnstructuredData = _prefix "hasUnstructuredData"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isAfter"></see>
    /// </summary>
    let isAfter = _prefix "isAfter"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isApplicableFor"></see>
    /// </summary>
    let isApplicableFor = _prefix "isApplicableFor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isAuthorityFor"></see>
    /// </summary>
    let isAuthorityFor = _prefix "isAuthorityFor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isBefore"></see>
    /// </summary>
    let isBefore = _prefix "isBefore"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isDeterminedByEntity"></see>
    /// </summary>
    let isDeterminedByEntity = _prefix "isDeterminedByEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isDuring"></see>
    /// </summary>
    let isDuring = _prefix "isDuring"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isExercisedAt"></see>
    /// </summary>
    let isExercisedAt = _prefix "isExercisedAt"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isImplementedByEntity"></see>
    /// </summary>
    let isImplementedByEntity = _prefix "isImplementedByEntity"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isImplementedUsingTechnology"></see>
    /// </summary>
    let isImplementedUsingTechnology = _prefix "isImplementedUsingTechnology"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isIndicatedAtTime"></see>
    /// </summary>
    let isIndicatedAtTime = _prefix "isIndicatedAtTime"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isIndicatedBy"></see>
    /// </summary>
    let isIndicatedBy = _prefix "isIndicatedBy"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isMitigatedByMeasure"></see>
    /// </summary>
    let isMitigatedByMeasure = _prefix "isMitigatedByMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isNotApplicableFor"></see>
    /// </summary>
    let isNotApplicableFor = _prefix "isNotApplicableFor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isOrganisationalUnitOf"></see>
    /// </summary>
    let isOrganisationalUnitOf = _prefix "isOrganisationalUnitOf"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isOutsideOfLocation"></see>
    /// </summary>
    let isOutsideOfLocation = _prefix "isOutsideOfLocation"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isPolicyFor"></see>
    /// </summary>
    let isPolicyFor = _prefix "isPolicyFor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isRepresentativeFor"></see>
    /// </summary>
    let isRepresentativeFor = _prefix "isRepresentativeFor"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isResidualRiskOf"></see>
    /// </summary>
    let isResidualRiskOf = _prefix "isResidualRiskOf"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#isSubsidiaryOf"></see>
    /// </summary>
    let isSubsidiaryOf = _prefix "isSubsidiaryOf"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#mitigatesRisk"></see>
    /// </summary>
    let mitigatesRisk = _prefix "mitigatesRisk"
    /// <summary>
    ///   <see href="https://w3id.org/dpv#supportsComplianceWith"></see>
    /// </summary>
    let supportsComplianceWith = _prefix "supportsComplianceWith"
