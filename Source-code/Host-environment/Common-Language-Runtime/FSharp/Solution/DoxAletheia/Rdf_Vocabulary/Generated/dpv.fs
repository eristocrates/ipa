namespace https.w3id.org.dpv.hash

open DoxAletheia.Rdf_Vocabulary

module dpv =
    let _namespace_name = "https://w3id.org/dpv#"

    /// <summary>
    ///   <see href="https://w3id.org/dpv#rights-properties"></see>
    /// </summary>
    let ``rights-properties`` =
        Namespaced_IRI.parse _namespace_name "rights-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightExerciseRecord"></see>
    /// </summary>
    let RightExerciseRecord =
        Namespaced_IRI.parse _namespace_name "RightExerciseRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightExerciseActivity"></see>
    /// </summary>
    let RightExerciseActivity =
        Namespaced_IRI.parse _namespace_name "RightExerciseActivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#rights-classes"></see>
    /// </summary>
    let ``rights-classes`` =
        Namespaced_IRI.parse _namespace_name "rights-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-html"></see>
    /// </summary>
    let ``serialisation-html`` =
        Namespaced_IRI.parse _namespace_name "serialisation-html" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-rdf"></see>
    /// </summary>
    let ``serialisation-rdf`` =
        Namespaced_IRI.parse _namespace_name "serialisation-rdf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-jsonld"></see>
    /// </summary>
    let ``serialisation-jsonld`` =
        Namespaced_IRI.parse _namespace_name "serialisation-jsonld" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-n3"></see>
    /// </summary>
    let ``serialisation-n3`` =
        Namespaced_IRI.parse _namespace_name "serialisation-n3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#serialisation-ttl"></see>
    /// </summary>
    let ``serialisation-ttl`` =
        Namespaced_IRI.parse _namespace_name "serialisation-ttl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AILiteracy"></see>
    /// </summary>
    let AILiteracy = Namespaced_IRI.parse _namespace_name "AILiteracy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationalMeasure"></see>
    /// </summary>
    let OrganisationalMeasure =
        Namespaced_IRI.parse _namespace_name "OrganisationalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DigitalLiteracy"></see>
    /// </summary>
    let DigitalLiteracy =
        Namespaced_IRI.parse _namespace_name "DigitalLiteracy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#organisational-measures-classes"></see>
    /// </summary>
    let ``organisational-measures-classes`` =
        Namespaced_IRI.parse _namespace_name "organisational-measures-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AINotice"></see>
    /// </summary>
    let AINotice = Namespaced_IRI.parse _namespace_name "AINotice" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Notice"></see>
    /// </summary>
    let Notice = Namespaced_IRI.parse _namespace_name "Notice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcademicResearch"></see>
    /// </summary>
    let AcademicResearch =
        Namespaced_IRI.parse _namespace_name "AcademicResearch" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Purpose"></see>
    /// </summary>
    let Purpose = Namespaced_IRI.parse _namespace_name "Purpose" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ResearchAndDevelopment"></see>
    /// </summary>
    let ResearchAndDevelopment =
        Namespaced_IRI.parse _namespace_name "ResearchAndDevelopment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#purposes-classes"></see>
    /// </summary>
    let ``purposes-classes`` =
        Namespaced_IRI.parse _namespace_name "purposes-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcademicScientificOrganisation"></see>
    /// </summary>
    let AcademicScientificOrganisation =
        Namespaced_IRI.parse _namespace_name "AcademicScientificOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Organisation"></see>
    /// </summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-organisation-classes"></see>
    /// </summary>
    let ``entities-organisation-classes`` =
        Namespaced_IRI.parse _namespace_name "entities-organisation-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcceptContract"></see>
    /// </summary>
    let AcceptContract =
        Namespaced_IRI.parse _namespace_name "AcceptContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractControl"></see>
    /// </summary>
    let ContractControl =
        Namespaced_IRI.parse _namespace_name "ContractControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-control-classes"></see>
    /// </summary>
    let ``contract-control-classes`` =
        Namespaced_IRI.parse _namespace_name "contract-control-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcceptableRule"></see>
    /// </summary>
    let AcceptableRule =
        Namespaced_IRI.parse _namespace_name "AcceptableRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Rule"></see>
    /// </summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#rules-classes"></see>
    /// </summary>
    let ``rules-classes`` =
        Namespaced_IRI.parse _namespace_name "rules-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AcceptableUsePolicy"></see>
    /// </summary>
    let AcceptableUsePolicy =
        Namespaced_IRI.parse _namespace_name "AcceptableUsePolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Policy"></see>
    /// </summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Access"></see>
    /// </summary>
    let Access = Namespaced_IRI.parse _namespace_name "Access" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Processing"></see>
    /// </summary>
    let Processing = Namespaced_IRI.parse _namespace_name "Processing" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Use"></see>
    /// </summary>
    let Use = Namespaced_IRI.parse _namespace_name "Use" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-classes"></see>
    /// </summary>
    let ``processing-classes`` =
        Namespaced_IRI.parse _namespace_name "processing-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AccessControlMethod"></see>
    /// </summary>
    let AccessControlMethod =
        Namespaced_IRI.parse _namespace_name "AccessControlMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalMeasure"></see>
    /// </summary>
    let TechnicalMeasure =
        Namespaced_IRI.parse _namespace_name "TechnicalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#technical-measures-classes"></see>
    /// </summary>
    let ``technical-measures-classes`` =
        Namespaced_IRI.parse _namespace_name "technical-measures-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AccountManagement"></see>
    /// </summary>
    let AccountManagement =
        Namespaced_IRI.parse _namespace_name "AccountManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Acquire"></see>
    /// </summary>
    let Acquire = Namespaced_IRI.parse _namespace_name "Acquire" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Obtain"></see>
    /// </summary>
    let Obtain = Namespaced_IRI.parse _namespace_name "Obtain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActiveRight"></see>
    /// </summary>
    let ActiveRight =
        Namespaced_IRI.parse _namespace_name "ActiveRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Right"></see>
    /// </summary>
    let Right = Namespaced_IRI.parse _namespace_name "Right" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivelyInvolved"></see>
    /// </summary>
    let ActivelyInvolved =
        Namespaced_IRI.parse _namespace_name "ActivelyInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InvolvementStatus"></see>
    /// </summary>
    let InvolvementStatus =
        Namespaced_IRI.parse _namespace_name "InvolvementStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#status-classes"></see>
    /// </summary>
    let ``status-classes`` =
        Namespaced_IRI.parse _namespace_name "status-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityCompleted"></see>
    /// </summary>
    let ActivityCompleted =
        Namespaced_IRI.parse _namespace_name "ActivityCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityStatus"></see>
    /// </summary>
    let ActivityStatus =
        Namespaced_IRI.parse _namespace_name "ActivityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityHalted"></see>
    /// </summary>
    let ActivityHalted =
        Namespaced_IRI.parse _namespace_name "ActivityHalted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityMonitoring"></see>
    /// </summary>
    let ActivityMonitoring =
        Namespaced_IRI.parse _namespace_name "ActivityMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityNotCompleted"></see>
    /// </summary>
    let ActivityNotCompleted =
        Namespaced_IRI.parse _namespace_name "ActivityNotCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityOngoing"></see>
    /// </summary>
    let ActivityOngoing =
        Namespaced_IRI.parse _namespace_name "ActivityOngoing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityPlanned"></see>
    /// </summary>
    let ActivityPlanned =
        Namespaced_IRI.parse _namespace_name "ActivityPlanned" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ActivityProposed"></see>
    /// </summary>
    let ActivityProposed =
        Namespaced_IRI.parse _namespace_name "ActivityProposed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Status"></see>
    /// </summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Adapt"></see>
    /// </summary>
    let Adapt = Namespaced_IRI.parse _namespace_name "Adapt" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Transform"></see>
    /// </summary>
    let Transform = Namespaced_IRI.parse _namespace_name "Transform" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Adult"></see>
    /// </summary>
    let Adult = Namespaced_IRI.parse _namespace_name "Adult" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanSubject"></see>
    /// </summary>
    let HumanSubject =
        Namespaced_IRI.parse _namespace_name "HumanSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-datasubject-classes"></see>
    /// </summary>
    let ``entities-datasubject-classes`` =
        Namespaced_IRI.parse _namespace_name "entities-datasubject-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Advertising"></see>
    /// </summary>
    let Advertising =
        Namespaced_IRI.parse _namespace_name "Advertising" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Marketing"></see>
    /// </summary>
    let Marketing = Namespaced_IRI.parse _namespace_name "Marketing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AgeVerification"></see>
    /// </summary>
    let AgeVerification =
        Namespaced_IRI.parse _namespace_name "AgeVerification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Verification"></see>
    /// </summary>
    let Verification =
        Namespaced_IRI.parse _namespace_name "Verification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Aggregate"></see>
    /// </summary>
    let Aggregate = Namespaced_IRI.parse _namespace_name "Aggregate" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Alter"></see>
    /// </summary>
    let Alter = Namespaced_IRI.parse _namespace_name "Alter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AlgorithmicLogic"></see>
    /// </summary>
    let AlgorithmicLogic =
        Namespaced_IRI.parse _namespace_name "AlgorithmicLogic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingContext"></see>
    /// </summary>
    let ProcessingContext =
        Namespaced_IRI.parse _namespace_name "ProcessingContext" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-context-classes"></see>
    /// </summary>
    let ``processing-context-classes`` =
        Namespaced_IRI.parse _namespace_name "processing-context-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Align"></see>
    /// </summary>
    let Align = Namespaced_IRI.parse _namespace_name "Align" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AmbulanceProvider"></see>
    /// </summary>
    let AmbulanceProvider =
        Namespaced_IRI.parse _namespace_name "AmbulanceProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EmergencyServiceProvider"></see>
    /// </summary>
    let EmergencyServiceProvider =
        Namespaced_IRI.parse _namespace_name "EmergencyServiceProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Analyse"></see>
    /// </summary>
    let Analyse = Namespaced_IRI.parse _namespace_name "Analyse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Anonymisation"></see>
    /// </summary>
    let Anonymisation =
        Namespaced_IRI.parse _namespace_name "Anonymisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Deidentification"></see>
    /// </summary>
    let Deidentification =
        Namespaced_IRI.parse _namespace_name "Deidentification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Anonymise"></see>
    /// </summary>
    let Anonymise = Namespaced_IRI.parse _namespace_name "Anonymise" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AnonymisedData"></see>
    /// </summary>
    let AnonymisedData =
        Namespaced_IRI.parse _namespace_name "AnonymisedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonPersonalData"></see>
    /// </summary>
    let NonPersonalData =
        Namespaced_IRI.parse _namespace_name "NonPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#personal-data-classes"></see>
    /// </summary>
    let ``personal-data-classes`` =
        Namespaced_IRI.parse _namespace_name "personal-data-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Applicability"></see>
    /// </summary>
    let Applicability =
        Namespaced_IRI.parse _namespace_name "Applicability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#context-classes"></see>
    /// </summary>
    let ``context-classes`` =
        Namespaced_IRI.parse _namespace_name "context-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Applicant"></see>
    /// </summary>
    let Applicant = Namespaced_IRI.parse _namespace_name "Applicant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ApprovalProcedure"></see>
    /// </summary>
    let ApprovalProcedure =
        Namespaced_IRI.parse _namespace_name "ApprovalProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GovernanceProcedures"></see>
    /// </summary>
    let GovernanceProcedures =
        Namespaced_IRI.parse _namespace_name "GovernanceProcedures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Assess"></see>
    /// </summary>
    let Assess = Namespaced_IRI.parse _namespace_name "Assess" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Assessment"></see>
    /// </summary>
    let Assessment = Namespaced_IRI.parse _namespace_name "Assessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AssetManagementProcedures"></see>
    /// </summary>
    let AssetManagementProcedures =
        Namespaced_IRI.parse _namespace_name "AssetManagementProcedures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AssistiveAutomation"></see>
    /// </summary>
    let AssistiveAutomation =
        Namespaced_IRI.parse _namespace_name "AssistiveAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AutomationLevel"></see>
    /// </summary>
    let AutomationLevel =
        Namespaced_IRI.parse _namespace_name "AutomationLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AsylumSeeker"></see>
    /// </summary>
    let AsylumSeeker =
        Namespaced_IRI.parse _namespace_name "AsylumSeeker" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VulnerableHuman"></see>
    /// </summary>
    let VulnerableHuman =
        Namespaced_IRI.parse _namespace_name "VulnerableHuman" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AsymmetricCryptography"></see>
    /// </summary>
    let AsymmetricCryptography =
        Namespaced_IRI.parse _namespace_name "AsymmetricCryptography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CryptographicMethods"></see>
    /// </summary>
    let CryptographicMethods =
        Namespaced_IRI.parse _namespace_name "CryptographicMethods" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AsymmetricEncryption"></see>
    /// </summary>
    let AsymmetricEncryption =
        Namespaced_IRI.parse _namespace_name "AsymmetricEncryption" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Encryption"></see>
    /// </summary>
    let Encryption = Namespaced_IRI.parse _namespace_name "Encryption" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Audit"></see>
    /// </summary>
    let Audit = Namespaced_IRI.parse _namespace_name "Audit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditApproved"></see>
    /// </summary>
    let AuditApproved =
        Namespaced_IRI.parse _namespace_name "AuditApproved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditStatus"></see>
    /// </summary>
    let AuditStatus =
        Namespaced_IRI.parse _namespace_name "AuditStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditConditionallyApproved"></see>
    /// </summary>
    let AuditConditionallyApproved =
        Namespaced_IRI.parse _namespace_name "AuditConditionallyApproved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditNotRequired"></see>
    /// </summary>
    let AuditNotRequired =
        Namespaced_IRI.parse _namespace_name "AuditNotRequired" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditRejected"></see>
    /// </summary>
    let AuditRejected =
        Namespaced_IRI.parse _namespace_name "AuditRejected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditRequested"></see>
    /// </summary>
    let AuditRequested =
        Namespaced_IRI.parse _namespace_name "AuditRequested" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuditRequired"></see>
    /// </summary>
    let AuditRequired =
        Namespaced_IRI.parse _namespace_name "AuditRequired" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Authentication-ABC"></see>
    /// </summary>
    let ``Authentication-ABC`` =
        Namespaced_IRI.parse _namespace_name "Authentication-ABC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CryptographicAuthentication"></see>
    /// </summary>
    let CryptographicAuthentication =
        Namespaced_IRI.parse _namespace_name "CryptographicAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Authentication-PABC"></see>
    /// </summary>
    let ``Authentication-PABC`` =
        Namespaced_IRI.parse _namespace_name "Authentication-PABC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthenticationProtocols"></see>
    /// </summary>
    let AuthenticationProtocols =
        Namespaced_IRI.parse _namespace_name "AuthenticationProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorisationProcedure"></see>
    /// </summary>
    let AuthorisationProcedure =
        Namespaced_IRI.parse _namespace_name "AuthorisationProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityProcedure"></see>
    /// </summary>
    let SecurityProcedure =
        Namespaced_IRI.parse _namespace_name "SecurityProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorisationProtocols"></see>
    /// </summary>
    let AuthorisationProtocols =
        Namespaced_IRI.parse _namespace_name "AuthorisationProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Authority"></see>
    /// </summary>
    let Authority = Namespaced_IRI.parse _namespace_name "Authority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GovernmentalOrganisation"></see>
    /// </summary>
    let GovernmentalOrganisation =
        Namespaced_IRI.parse _namespace_name "GovernmentalOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-authority-classes"></see>
    /// </summary>
    let ``entities-authority-classes`` =
        Namespaced_IRI.parse _namespace_name "entities-authority-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorityInformed"></see>
    /// </summary>
    let AuthorityInformed =
        Namespaced_IRI.parse _namespace_name "AuthorityInformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInformedStatus"></see>
    /// </summary>
    let EntityInformedStatus =
        Namespaced_IRI.parse _namespace_name "EntityInformedStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInformed"></see>
    /// </summary>
    let EntityInformed =
        Namespaced_IRI.parse _namespace_name "EntityInformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AuthorityUninformed"></see>
    /// </summary>
    let AuthorityUninformed =
        Namespaced_IRI.parse _namespace_name "AuthorityUninformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityUninformed"></see>
    /// </summary>
    let EntityUninformed =
        Namespaced_IRI.parse _namespace_name "EntityUninformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AutomatedDecisionMaking"></see>
    /// </summary>
    let AutomatedDecisionMaking =
        Namespaced_IRI.parse _namespace_name "AutomatedDecisionMaking" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DecisionMaking"></see>
    /// </summary>
    let DecisionMaking =
        Namespaced_IRI.parse _namespace_name "DecisionMaking" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#AutomatedScoringOfIndividuals"></see>
    /// </summary>
    let AutomatedScoringOfIndividuals =
        Namespaced_IRI.parse _namespace_name "AutomatedScoringOfIndividuals" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ScoringOfIndividuals"></see>
    /// </summary>
    let ScoringOfIndividuals =
        Namespaced_IRI.parse _namespace_name "ScoringOfIndividuals" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Autonomous"></see>
    /// </summary>
    let Autonomous = Namespaced_IRI.parse _namespace_name "Autonomous" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#B2B2CContract"></see>
    /// </summary>
    let B2B2CContract =
        Namespaced_IRI.parse _namespace_name "B2B2CContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalBasis"></see>
    /// </summary>
    let LegalBasis = Namespaced_IRI.parse _namespace_name "LegalBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#B2CContract"></see>
    /// </summary>
    let B2CContract =
        Namespaced_IRI.parse _namespace_name "B2CContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#B2BContract"></see>
    /// </summary>
    let B2BContract =
        Namespaced_IRI.parse _namespace_name "B2BContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-types-classes"></see>
    /// </summary>
    let ``contract-types-classes`` =
        Namespaced_IRI.parse _namespace_name "contract-types-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractByEntityType"></see>
    /// </summary>
    let ContractByEntityType =
        Namespaced_IRI.parse _namespace_name "ContractByEntityType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#BackgroundChecks"></see>
    /// </summary>
    let BackgroundChecks =
        Namespaced_IRI.parse _namespace_name "BackgroundChecks" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#BiometricAuthentication"></see>
    /// </summary>
    let BiometricAuthentication =
        Namespaced_IRI.parse _namespace_name "BiometricAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#C2BContract"></see>
    /// </summary>
    let C2BContract =
        Namespaced_IRI.parse _namespace_name "C2BContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#C2CContract"></see>
    /// </summary>
    let C2CContract =
        Namespaced_IRI.parse _namespace_name "C2CContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotChallengeProcess"></see>
    /// </summary>
    let CannotChallengeProcess =
        Namespaced_IRI.parse _namespace_name "CannotChallengeProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityNonPermissiveInvolvement"></see>
    /// </summary>
    let EntityNonPermissiveInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityNonPermissiveInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotChallengeProcessInput"></see>
    /// </summary>
    let CannotChallengeProcessInput =
        Namespaced_IRI.parse _namespace_name "CannotChallengeProcessInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotChallengeProcessOutput"></see>
    /// </summary>
    let CannotChallengeProcessOutput =
        Namespaced_IRI.parse _namespace_name "CannotChallengeProcessOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotCorrectProcess"></see>
    /// </summary>
    let CannotCorrectProcess =
        Namespaced_IRI.parse _namespace_name "CannotCorrectProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotCorrectProcessInput"></see>
    /// </summary>
    let CannotCorrectProcessInput =
        Namespaced_IRI.parse _namespace_name "CannotCorrectProcessInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotCorrectProcessOutput"></see>
    /// </summary>
    let CannotCorrectProcessOutput =
        Namespaced_IRI.parse _namespace_name "CannotCorrectProcessOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotObjectToProcess"></see>
    /// </summary>
    let CannotObjectToProcess =
        Namespaced_IRI.parse _namespace_name "CannotObjectToProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotOptInToProcess"></see>
    /// </summary>
    let CannotOptInToProcess =
        Namespaced_IRI.parse _namespace_name "CannotOptInToProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotOptOutFromProcess"></see>
    /// </summary>
    let CannotOptOutFromProcess =
        Namespaced_IRI.parse _namespace_name "CannotOptOutFromProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotReverseProcessEffects"></see>
    /// </summary>
    let CannotReverseProcessEffects =
        Namespaced_IRI.parse _namespace_name "CannotReverseProcessEffects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotReverseProcessInput"></see>
    /// </summary>
    let CannotReverseProcessInput =
        Namespaced_IRI.parse _namespace_name "CannotReverseProcessInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotReverseProcessOutput"></see>
    /// </summary>
    let CannotReverseProcessOutput =
        Namespaced_IRI.parse _namespace_name "CannotReverseProcessOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CannotWithdrawFromProcess"></see>
    /// </summary>
    let CannotWithdrawFromProcess =
        Namespaced_IRI.parse _namespace_name "CannotWithdrawFromProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Certification"></see>
    /// </summary>
    let Certification =
        Namespaced_IRI.parse _namespace_name "Certification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CertificationSeal"></see>
    /// </summary>
    let CertificationSeal =
        Namespaced_IRI.parse _namespace_name "CertificationSeal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ChallengingProcess"></see>
    /// </summary>
    let ChallengingProcess =
        Namespaced_IRI.parse _namespace_name "ChallengingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityPermissiveInvolvement"></see>
    /// </summary>
    let EntityPermissiveInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityPermissiveInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ChallengingProcessInput"></see>
    /// </summary>
    let ChallengingProcessInput =
        Namespaced_IRI.parse _namespace_name "ChallengingProcessInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ChallengingProcessOutput"></see>
    /// </summary>
    let ChallengingProcessOutput =
        Namespaced_IRI.parse _namespace_name "ChallengingProcessOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CharityOrganisation"></see>
    /// </summary>
    let CharityOrganisation =
        Namespaced_IRI.parse _namespace_name "CharityOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalEntity"></see>
    /// </summary>
    let LegalEntity =
        Namespaced_IRI.parse _namespace_name "LegalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Child"></see>
    /// </summary>
    let Child = Namespaced_IRI.parse _namespace_name "Child" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Citizen"></see>
    /// </summary>
    let Citizen = Namespaced_IRI.parse _namespace_name "Citizen" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#City"></see>
    /// </summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#jurisdiction-classes"></see>
    /// </summary>
    let ``jurisdiction-classes`` =
        Namespaced_IRI.parse _namespace_name "jurisdiction-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Client"></see>
    /// </summary>
    let Client = Namespaced_IRI.parse _namespace_name "Client" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Customer"></see>
    /// </summary>
    let Customer = Namespaced_IRI.parse _namespace_name "Customer" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Clinic"></see>
    /// </summary>
    let Clinic = Namespaced_IRI.parse _namespace_name "Clinic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CloudLocation"></see>
    /// </summary>
    let CloudLocation =
        Namespaced_IRI.parse _namespace_name "CloudLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Location"></see>
    /// </summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RemoteLocation"></see>
    /// </summary>
    let RemoteLocation =
        Namespaced_IRI.parse _namespace_name "RemoteLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CodeOfConduct"></see>
    /// </summary>
    let CodeOfConduct =
        Namespaced_IRI.parse _namespace_name "CodeOfConduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GuidelinesPrinciple"></see>
    /// </summary>
    let GuidelinesPrinciple =
        Namespaced_IRI.parse _namespace_name "GuidelinesPrinciple" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Collect"></see>
    /// </summary>
    let Collect = Namespaced_IRI.parse _namespace_name "Collect" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CollectedData"></see>
    /// </summary>
    let CollectedData =
        Namespaced_IRI.parse _namespace_name "CollectedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CollectedPersonalData"></see>
    /// </summary>
    let CollectedPersonalData =
        Namespaced_IRI.parse _namespace_name "CollectedPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalData"></see>
    /// </summary>
    let PersonalData =
        Namespaced_IRI.parse _namespace_name "PersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CombatClimateChange"></see>
    /// </summary>
    let CombatClimateChange =
        Namespaced_IRI.parse _namespace_name "CombatClimateChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicBenefit"></see>
    /// </summary>
    let PublicBenefit =
        Namespaced_IRI.parse _namespace_name "PublicBenefit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Combine"></see>
    /// </summary>
    let Combine = Namespaced_IRI.parse _namespace_name "Combine" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommercialPurpose"></see>
    /// </summary>
    let CommercialPurpose =
        Namespaced_IRI.parse _namespace_name "CommercialPurpose" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommercialResearch"></see>
    /// </summary>
    let CommercialResearch =
        Namespaced_IRI.parse _namespace_name "CommercialResearch" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommerciallyConfidentialData"></see>
    /// </summary>
    let CommerciallyConfidentialData =
        Namespaced_IRI.parse _namespace_name "CommerciallyConfidentialData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConfidentialData"></see>
    /// </summary>
    let ConfidentialData =
        Namespaced_IRI.parse _namespace_name "ConfidentialData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommunicationForCustomerCare"></see>
    /// </summary>
    let CommunicationForCustomerCare =
        Namespaced_IRI.parse _namespace_name "CommunicationForCustomerCare" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CommunicationManagement"></see>
    /// </summary>
    let CommunicationManagement =
        Namespaced_IRI.parse _namespace_name "CommunicationManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerCare"></see>
    /// </summary>
    let CustomerCare =
        Namespaced_IRI.parse _namespace_name "CustomerCare" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CompatibilityUnknown"></see>
    /// </summary>
    let CompatibilityUnknown =
        Namespaced_IRI.parse _namespace_name "CompatibilityUnknown" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReuseCompatibility"></see>
    /// </summary>
    let ReuseCompatibility =
        Namespaced_IRI.parse _namespace_name "ReuseCompatibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceAssessment"></see>
    /// </summary>
    let ComplianceAssessment =
        Namespaced_IRI.parse _namespace_name "ComplianceAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceIndeterminate"></see>
    /// </summary>
    let ComplianceIndeterminate =
        Namespaced_IRI.parse _namespace_name "ComplianceIndeterminate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceStatus"></see>
    /// </summary>
    let ComplianceStatus =
        Namespaced_IRI.parse _namespace_name "ComplianceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceMonitoring"></see>
    /// </summary>
    let ComplianceMonitoring =
        Namespaced_IRI.parse _namespace_name "ComplianceMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceUnknown"></see>
    /// </summary>
    let ComplianceUnknown =
        Namespaced_IRI.parse _namespace_name "ComplianceUnknown" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ComplianceViolation"></see>
    /// </summary>
    let ComplianceViolation =
        Namespaced_IRI.parse _namespace_name "ComplianceViolation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Compliant"></see>
    /// </summary>
    let Compliant = Namespaced_IRI.parse _namespace_name "Compliant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConditionalAutomation"></see>
    /// </summary>
    let ConditionalAutomation =
        Namespaced_IRI.parse _namespace_name "ConditionalAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConfidentialityAgreement"></see>
    /// </summary>
    let ConfidentialityAgreement =
        Namespaced_IRI.parse _namespace_name "ConfidentialityAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalMeasure"></see>
    /// </summary>
    let LegalMeasure =
        Namespaced_IRI.parse _namespace_name "LegalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalAgreement"></see>
    /// </summary>
    let LegalAgreement =
        Namespaced_IRI.parse _namespace_name "LegalAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-measures-classes"></see>
    /// </summary>
    let ``legal-measures-classes`` =
        Namespaced_IRI.parse _namespace_name "legal-measures-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConformanceAssessment"></see>
    /// </summary>
    let ConformanceAssessment =
        Namespaced_IRI.parse _namespace_name "ConformanceAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConformanceStatus"></see>
    /// </summary>
    let ConformanceStatus =
        Namespaced_IRI.parse _namespace_name "ConformanceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Conformant"></see>
    /// </summary>
    let Conformant = Namespaced_IRI.parse _namespace_name "Conformant" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consent"></see>
    /// </summary>
    let Consent = Namespaced_IRI.parse _namespace_name "Consent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-basis-classes"></see>
    /// </summary>
    let ``legal-basis-classes`` =
        Namespaced_IRI.parse _namespace_name "legal-basis-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentControl"></see>
    /// </summary>
    let ConsentControl =
        Namespaced_IRI.parse _namespace_name "ConsentControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInvolvement"></see>
    /// </summary>
    let EntityInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-controls-classes"></see>
    /// </summary>
    let ``consent-controls-classes`` =
        Namespaced_IRI.parse _namespace_name "consent-controls-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentExpired"></see>
    /// </summary>
    let ConsentExpired =
        Namespaced_IRI.parse _namespace_name "ConsentExpired" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentStatus"></see>
    /// </summary>
    let ConsentStatus =
        Namespaced_IRI.parse _namespace_name "ConsentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentStatusInvalidForProcessing"></see>
    /// </summary>
    let ConsentStatusInvalidForProcessing =
        Namespaced_IRI.parse _namespace_name "ConsentStatusInvalidForProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-status-classes"></see>
    /// </summary>
    let ``consent-status-classes`` =
        Namespaced_IRI.parse _namespace_name "consent-status-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentGiven"></see>
    /// </summary>
    let ConsentGiven =
        Namespaced_IRI.parse _namespace_name "ConsentGiven" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentStatusValidForProcessing"></see>
    /// </summary>
    let ConsentStatusValidForProcessing =
        Namespaced_IRI.parse _namespace_name "ConsentStatusValidForProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentInvalidated"></see>
    /// </summary>
    let ConsentInvalidated =
        Namespaced_IRI.parse _namespace_name "ConsentInvalidated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentManagement"></see>
    /// </summary>
    let ConsentManagement =
        Namespaced_IRI.parse _namespace_name "ConsentManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PermissionManagement"></see>
    /// </summary>
    let PermissionManagement =
        Namespaced_IRI.parse _namespace_name "PermissionManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentNotice"></see>
    /// </summary>
    let ConsentNotice =
        Namespaced_IRI.parse _namespace_name "ConsentNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyNotice"></see>
    /// </summary>
    let PrivacyNotice =
        Namespaced_IRI.parse _namespace_name "PrivacyNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#notice-classes"></see>
    /// </summary>
    let ``notice-classes`` =
        Namespaced_IRI.parse _namespace_name "notice-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentReceipt"></see>
    /// </summary>
    let ConsentReceipt =
        Namespaced_IRI.parse _namespace_name "ConsentReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRecord"></see>
    /// </summary>
    let ConsentRecord =
        Namespaced_IRI.parse _namespace_name "ConsentRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessingRecord"></see>
    /// </summary>
    let DataProcessingRecord =
        Namespaced_IRI.parse _namespace_name "DataProcessingRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRefused"></see>
    /// </summary>
    let ConsentRefused =
        Namespaced_IRI.parse _namespace_name "ConsentRefused" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRequestDeferred"></see>
    /// </summary>
    let ConsentRequestDeferred =
        Namespaced_IRI.parse _namespace_name "ConsentRequestDeferred" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRequested"></see>
    /// </summary>
    let ConsentRequested =
        Namespaced_IRI.parse _namespace_name "ConsentRequested" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentRevoked"></see>
    /// </summary>
    let ConsentRevoked =
        Namespaced_IRI.parse _namespace_name "ConsentRevoked" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentUnknown"></see>
    /// </summary>
    let ConsentUnknown =
        Namespaced_IRI.parse _namespace_name "ConsentUnknown" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsentWithdrawn"></see>
    /// </summary>
    let ConsentWithdrawn =
        Namespaced_IRI.parse _namespace_name "ConsentWithdrawn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consequence"></see>
    /// </summary>
    let Consequence =
        Namespaced_IRI.parse _namespace_name "Consequence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskConcept"></see>
    /// </summary>
    let RiskConcept =
        Namespaced_IRI.parse _namespace_name "RiskConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#risk-classes"></see>
    /// </summary>
    let ``risk-classes`` =
        Namespaced_IRI.parse _namespace_name "risk-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsequenceAsSideEffect"></see>
    /// </summary>
    let ConsequenceAsSideEffect =
        Namespaced_IRI.parse _namespace_name "ConsequenceAsSideEffect" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsequenceOfFailure"></see>
    /// </summary>
    let ConsequenceOfFailure =
        Namespaced_IRI.parse _namespace_name "ConsequenceOfFailure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsequenceOfSuccess"></see>
    /// </summary>
    let ConsequenceOfSuccess =
        Namespaced_IRI.parse _namespace_name "ConsequenceOfSuccess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consult"></see>
    /// </summary>
    let Consult = Namespaced_IRI.parse _namespace_name "Consult" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consultation"></see>
    /// </summary>
    let Consultation =
        Namespaced_IRI.parse _namespace_name "Consultation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithAuthority"></see>
    /// </summary>
    let ConsultationWithAuthority =
        Namespaced_IRI.parse _namespace_name "ConsultationWithAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithDPO"></see>
    /// </summary>
    let ConsultationWithDPO =
        Namespaced_IRI.parse _namespace_name "ConsultationWithDPO" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithDataSubject"></see>
    /// </summary>
    let ConsultationWithDataSubject =
        Namespaced_IRI.parse _namespace_name "ConsultationWithDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsultationWithDataSubjectRepresentative"></see>
    /// </summary>
    let ConsultationWithDataSubjectRepresentative =
        Namespaced_IRI.parse _namespace_name "ConsultationWithDataSubjectRepresentative" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Consumer"></see>
    /// </summary>
    let Consumer = Namespaced_IRI.parse _namespace_name "Consumer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ConsumerStandardFormContract"></see>
    /// </summary>
    let ConsumerStandardFormContract =
        Namespaced_IRI.parse _namespace_name "ConsumerStandardFormContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StandardFormContract"></see>
    /// </summary>
    let StandardFormContract =
        Namespaced_IRI.parse _namespace_name "StandardFormContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContextuallyAnonymisedData"></see>
    /// </summary>
    let ContextuallyAnonymisedData =
        Namespaced_IRI.parse _namespace_name "ContextuallyAnonymisedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PseudonymisedData"></see>
    /// </summary>
    let PseudonymisedData =
        Namespaced_IRI.parse _namespace_name "PseudonymisedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContinuousFrequency"></see>
    /// </summary>
    let ContinuousFrequency =
        Namespaced_IRI.parse _namespace_name "ContinuousFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Frequency"></see>
    /// </summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Contract"></see>
    /// </summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractActivationStatus"></see>
    /// </summary>
    let ContractActivationStatus =
        Namespaced_IRI.parse _namespace_name "ContractActivationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractStatus"></see>
    /// </summary>
    let ContractStatus =
        Namespaced_IRI.parse _namespace_name "ContractStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-status-classes"></see>
    /// </summary>
    let ``contract-status-classes`` =
        Namespaced_IRI.parse _namespace_name "contract-status-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractActive"></see>
    /// </summary>
    let ContractActive =
        Namespaced_IRI.parse _namespace_name "ContractActive" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractAmended"></see>
    /// </summary>
    let ContractAmended =
        Namespaced_IRI.parse _namespace_name "ContractAmended" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPerformanceStatus"></see>
    /// </summary>
    let ContractPerformanceStatus =
        Namespaced_IRI.parse _namespace_name "ContractPerformanceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractAmendmentClause"></see>
    /// </summary>
    let ContractAmendmentClause =
        Namespaced_IRI.parse _namespace_name "ContractAmendmentClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClause"></see>
    /// </summary>
    let ContractualClause =
        Namespaced_IRI.parse _namespace_name "ContractualClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-clause-classes"></see>
    /// </summary>
    let ``contract-clause-classes`` =
        Namespaced_IRI.parse _namespace_name "contract-clause-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractApproved"></see>
    /// </summary>
    let ContractApproved =
        Namespaced_IRI.parse _namespace_name "ContractApproved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPreparationStatus"></see>
    /// </summary>
    let ContractPreparationStatus =
        Namespaced_IRI.parse _namespace_name "ContractPreparationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractBeingPerformed"></see>
    /// </summary>
    let ContractBeingPerformed =
        Namespaced_IRI.parse _namespace_name "ContractBeingPerformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractBreached"></see>
    /// </summary>
    let ContractBreached =
        Namespaced_IRI.parse _namespace_name "ContractBreached" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTerminationStatus"></see>
    /// </summary>
    let ContractTerminationStatus =
        Namespaced_IRI.parse _namespace_name "ContractTerminationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractByDomain"></see>
    /// </summary>
    let ContractByDomain =
        Namespaced_IRI.parse _namespace_name "ContractByDomain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractByNegotiationType"></see>
    /// </summary>
    let ContractByNegotiationType =
        Namespaced_IRI.parse _namespace_name "ContractByNegotiationType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractConfidentialityClause"></see>
    /// </summary>
    let ContractConfidentialityClause =
        Namespaced_IRI.parse _namespace_name "ContractConfidentialityClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDefinitions"></see>
    /// </summary>
    let ContractDefinitions =
        Namespaced_IRI.parse _namespace_name "ContractDefinitions" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDisputeResolutionClause"></see>
    /// </summary>
    let ContractDisputeResolutionClause =
        Namespaced_IRI.parse _namespace_name "ContractDisputeResolutionClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDisputed"></see>
    /// </summary>
    let ContractDisputed =
        Namespaced_IRI.parse _namespace_name "ContractDisputed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractDrafted"></see>
    /// </summary>
    let ContractDrafted =
        Namespaced_IRI.parse _namespace_name "ContractDrafted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractExecutionStatus"></see>
    /// </summary>
    let ContractExecutionStatus =
        Namespaced_IRI.parse _namespace_name "ContractExecutionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractExpired"></see>
    /// </summary>
    let ContractExpired =
        Namespaced_IRI.parse _namespace_name "ContractExpired" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractExtended"></see>
    /// </summary>
    let ContractExtended =
        Namespaced_IRI.parse _namespace_name "ContractExtended" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFulfilled"></see>
    /// </summary>
    let ContractFulfilled =
        Namespaced_IRI.parse _namespace_name "ContractFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFulfilmentStatus"></see>
    /// </summary>
    let ContractFulfilmentStatus =
        Namespaced_IRI.parse _namespace_name "ContractFulfilmentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFullyExecuted"></see>
    /// </summary>
    let ContractFullyExecuted =
        Namespaced_IRI.parse _namespace_name "ContractFullyExecuted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractFullySigned"></see>
    /// </summary>
    let ContractFullySigned =
        Namespaced_IRI.parse _namespace_name "ContractFullySigned" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractInactive"></see>
    /// </summary>
    let ContractInactive =
        Namespaced_IRI.parse _namespace_name "ContractInactive" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractJurisdictionClause"></see>
    /// </summary>
    let ContractJurisdictionClause =
        Namespaced_IRI.parse _namespace_name "ContractJurisdictionClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractNegotiated"></see>
    /// </summary>
    let ContractNegotiated =
        Namespaced_IRI.parse _namespace_name "ContractNegotiated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractNotFulfilled"></see>
    /// </summary>
    let ContractNotFulfilled =
        Namespaced_IRI.parse _namespace_name "ContractNotFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractOffered"></see>
    /// </summary>
    let ContractOffered =
        Namespaced_IRI.parse _namespace_name "ContractOffered" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPartiallyFulfilled"></see>
    /// </summary>
    let ContractPartiallyFulfilled =
        Namespaced_IRI.parse _namespace_name "ContractPartiallyFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPartiallySigned"></see>
    /// </summary>
    let ContractPartiallySigned =
        Namespaced_IRI.parse _namespace_name "ContractPartiallySigned" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPerformance"></see>
    /// </summary>
    let ContractPerformance =
        Namespaced_IRI.parse _namespace_name "ContractPerformance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractPreamble"></see>
    /// </summary>
    let ContractPreamble =
        Namespaced_IRI.parse _namespace_name "ContractPreamble" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractRejected"></see>
    /// </summary>
    let ContractRejected =
        Namespaced_IRI.parse _namespace_name "ContractRejected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractRenewed"></see>
    /// </summary>
    let ContractRenewed =
        Namespaced_IRI.parse _namespace_name "ContractRenewed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractSignedByParty"></see>
    /// </summary>
    let ContractSignedByParty =
        Namespaced_IRI.parse _namespace_name "ContractSignedByParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTemporarilySuspended"></see>
    /// </summary>
    let ContractTemporarilySuspended =
        Namespaced_IRI.parse _namespace_name "ContractTemporarilySuspended" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTerminated"></see>
    /// </summary>
    let ContractTerminated =
        Namespaced_IRI.parse _namespace_name "ContractTerminated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractTerminationClause"></see>
    /// </summary>
    let ContractTerminationClause =
        Namespaced_IRI.parse _namespace_name "ContractTerminationClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractUnderNegotiation"></see>
    /// </summary>
    let ContractUnderNegotiation =
        Namespaced_IRI.parse _namespace_name "ContractUnderNegotiation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractUnderReview"></see>
    /// </summary>
    let ContractUnderReview =
        Namespaced_IRI.parse _namespace_name "ContractUnderReview" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractViolated"></see>
    /// </summary>
    let ContractViolated =
        Namespaced_IRI.parse _namespace_name "ContractViolated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseFulfilled"></see>
    /// </summary>
    let ContractualClauseFulfilled =
        Namespaced_IRI.parse _namespace_name "ContractualClauseFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseFulfilmentStatus"></see>
    /// </summary>
    let ContractualClauseFulfilmentStatus =
        Namespaced_IRI.parse _namespace_name "ContractualClauseFulfilmentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseNotFulfilled"></see>
    /// </summary>
    let ContractualClauseNotFulfilled =
        Namespaced_IRI.parse _namespace_name "ContractualClauseNotFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClausePartiallyFulfilled"></see>
    /// </summary>
    let ContractualClausePartiallyFulfilled =
        Namespaced_IRI.parse _namespace_name "ContractualClausePartiallyFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualClauseViolated"></see>
    /// </summary>
    let ContractualClauseViolated =
        Namespaced_IRI.parse _namespace_name "ContractualClauseViolated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ContractualTerms"></see>
    /// </summary>
    let ContractualTerms =
        Namespaced_IRI.parse _namespace_name "ContractualTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerDataSubjectAgreement"></see>
    /// </summary>
    let ControllerDataSubjectAgreement =
        Namespaced_IRI.parse _namespace_name "ControllerDataSubjectAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectContract"></see>
    /// </summary>
    let DataSubjectContract =
        Namespaced_IRI.parse _namespace_name "DataSubjectContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerInformed"></see>
    /// </summary>
    let ControllerInformed =
        Namespaced_IRI.parse _namespace_name "ControllerInformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerProcessorAgreement"></see>
    /// </summary>
    let ControllerProcessorAgreement =
        Namespaced_IRI.parse _namespace_name "ControllerProcessorAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessorContract"></see>
    /// </summary>
    let DataProcessorContract =
        Namespaced_IRI.parse _namespace_name "DataProcessorContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ControllerUninformed"></see>
    /// </summary>
    let ControllerUninformed =
        Namespaced_IRI.parse _namespace_name "ControllerUninformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Copy"></see>
    /// </summary>
    let Copy = Namespaced_IRI.parse _namespace_name "Copy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CorrectingProcess"></see>
    /// </summary>
    let CorrectingProcess =
        Namespaced_IRI.parse _namespace_name "CorrectingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CorrectingProcessInput"></see>
    /// </summary>
    let CorrectingProcessInput =
        Namespaced_IRI.parse _namespace_name "CorrectingProcessInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CorrectingProcessOutput"></see>
    /// </summary>
    let CorrectingProcessOutput =
        Namespaced_IRI.parse _namespace_name "CorrectingProcessOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CounterMoneyLaundering"></see>
    /// </summary>
    let CounterMoneyLaundering =
        Namespaced_IRI.parse _namespace_name "CounterMoneyLaundering" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FraudPreventionAndDetection"></see>
    /// </summary>
    let FraudPreventionAndDetection =
        Namespaced_IRI.parse _namespace_name "FraudPreventionAndDetection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Counterterrorism"></see>
    /// </summary>
    let Counterterrorism =
        Namespaced_IRI.parse _namespace_name "Counterterrorism" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Jurisdiction"></see>
    /// </summary>
    let Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Jurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CredentialManagement"></see>
    /// </summary>
    let CredentialManagement =
        Namespaced_IRI.parse _namespace_name "CredentialManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CrossBorderTransfer"></see>
    /// </summary>
    let CrossBorderTransfer =
        Namespaced_IRI.parse _namespace_name "CrossBorderTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Transfer"></see>
    /// </summary>
    let Transfer = Namespaced_IRI.parse _namespace_name "Transfer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CryptographicKeyManagement"></see>
    /// </summary>
    let CryptographicKeyManagement =
        Namespaced_IRI.parse _namespace_name "CryptographicKeyManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerManagement"></see>
    /// </summary>
    let CustomerManagement =
        Namespaced_IRI.parse _namespace_name "CustomerManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerClaimsManagement"></see>
    /// </summary>
    let CustomerClaimsManagement =
        Namespaced_IRI.parse _namespace_name "CustomerClaimsManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerOrderManagement"></see>
    /// </summary>
    let CustomerOrderManagement =
        Namespaced_IRI.parse _namespace_name "CustomerOrderManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerRelationshipManagement"></see>
    /// </summary>
    let CustomerRelationshipManagement =
        Namespaced_IRI.parse _namespace_name "CustomerRelationshipManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CustomerSolvencyMonitoring"></see>
    /// </summary>
    let CustomerSolvencyMonitoring =
        Namespaced_IRI.parse _namespace_name "CustomerSolvencyMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CybersecurityAssessment"></see>
    /// </summary>
    let CybersecurityAssessment =
        Namespaced_IRI.parse _namespace_name "CybersecurityAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityAssessment"></see>
    /// </summary>
    let SecurityAssessment =
        Namespaced_IRI.parse _namespace_name "SecurityAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#CybersecurityTraining"></see>
    /// </summary>
    let CybersecurityTraining =
        Namespaced_IRI.parse _namespace_name "CybersecurityTraining" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StaffTraining"></see>
    /// </summary>
    let StaffTraining =
        Namespaced_IRI.parse _namespace_name "StaffTraining" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DPIA"></see>
    /// </summary>
    let DPIA = Namespaced_IRI.parse _namespace_name "DPIA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightsImpactAssessment"></see>
    /// </summary>
    let RightsImpactAssessment =
        Namespaced_IRI.parse _namespace_name "RightsImpactAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DashboardNotice"></see>
    /// </summary>
    let DashboardNotice =
        Namespaced_IRI.parse _namespace_name "DashboardNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataAltruism"></see>
    /// </summary>
    let DataAltruism =
        Namespaced_IRI.parse _namespace_name "DataAltruism" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBackupProtocols"></see>
    /// </summary>
    let DataBackupProtocols =
        Namespaced_IRI.parse _namespace_name "DataBackupProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachImpactAssessment"></see>
    /// </summary>
    let DataBreachImpactAssessment =
        Namespaced_IRI.parse _namespace_name "DataBreachImpactAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachNotice"></see>
    /// </summary>
    let DataBreachNotice =
        Namespaced_IRI.parse _namespace_name "DataBreachNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityIncidentNotice"></see>
    /// </summary>
    let SecurityIncidentNotice =
        Namespaced_IRI.parse _namespace_name "SecurityIncidentNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachNotification"></see>
    /// </summary>
    let DataBreachNotification =
        Namespaced_IRI.parse _namespace_name "DataBreachNotification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityIncidentNotification"></see>
    /// </summary>
    let SecurityIncidentNotification =
        Namespaced_IRI.parse _namespace_name "SecurityIncidentNotification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataBreachRecord"></see>
    /// </summary>
    let DataBreachRecord =
        Namespaced_IRI.parse _namespace_name "DataBreachRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecordsOfActivities"></see>
    /// </summary>
    let RecordsOfActivities =
        Namespaced_IRI.parse _namespace_name "RecordsOfActivities" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataController"></see>
    /// </summary>
    let DataController =
        Namespaced_IRI.parse _namespace_name "DataController" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-legalrole-classes"></see>
    /// </summary>
    let ``entities-legalrole-classes`` =
        Namespaced_IRI.parse _namespace_name "entities-legalrole-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataControllerContract"></see>
    /// </summary>
    let DataControllerContract =
        Namespaced_IRI.parse _namespace_name "DataControllerContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessingAgreement"></see>
    /// </summary>
    let DataProcessingAgreement =
        Namespaced_IRI.parse _namespace_name "DataProcessingAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataControllerDataSource"></see>
    /// </summary>
    let DataControllerDataSource =
        Namespaced_IRI.parse _namespace_name "DataControllerDataSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSource"></see>
    /// </summary>
    let DataSource = Namespaced_IRI.parse _namespace_name "DataSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataDeletionPolicy"></see>
    /// </summary>
    let DataDeletionPolicy =
        Namespaced_IRI.parse _namespace_name "DataDeletionPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessingPolicy"></see>
    /// </summary>
    let DataProcessingPolicy =
        Namespaced_IRI.parse _namespace_name "DataProcessingPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataErasurePolicy"></see>
    /// </summary>
    let DataErasurePolicy =
        Namespaced_IRI.parse _namespace_name "DataErasurePolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataExporter"></see>
    /// </summary>
    let DataExporter =
        Namespaced_IRI.parse _namespace_name "DataExporter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataGovernance"></see>
    /// </summary>
    let DataGovernance =
        Namespaced_IRI.parse _namespace_name "DataGovernance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationGovernance"></see>
    /// </summary>
    let OrganisationGovernance =
        Namespaced_IRI.parse _namespace_name "OrganisationGovernance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataHandlingClause"></see>
    /// </summary>
    let DataHandlingClause =
        Namespaced_IRI.parse _namespace_name "DataHandlingClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataImporter"></see>
    /// </summary>
    let DataImporter =
        Namespaced_IRI.parse _namespace_name "DataImporter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Recipient"></see>
    /// </summary>
    let Recipient = Namespaced_IRI.parse _namespace_name "Recipient" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInteroperabilityAssessment"></see>
    /// </summary>
    let DataInteroperabilityAssessment =
        Namespaced_IRI.parse _namespace_name "DataInteroperabilityAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInteroperabilityManagement"></see>
    /// </summary>
    let DataInteroperabilityManagement =
        Namespaced_IRI.parse _namespace_name "DataInteroperabilityManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInteroperabilityImprovement"></see>
    /// </summary>
    let DataInteroperabilityImprovement =
        Namespaced_IRI.parse _namespace_name "DataInteroperabilityImprovement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataInventoryManagement"></see>
    /// </summary>
    let DataInventoryManagement =
        Namespaced_IRI.parse _namespace_name "DataInventoryManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataJurisdictionPolicy"></see>
    /// </summary>
    let DataJurisdictionPolicy =
        Namespaced_IRI.parse _namespace_name "DataJurisdictionPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataLiteracy"></see>
    /// </summary>
    let DataLiteracy =
        Namespaced_IRI.parse _namespace_name "DataLiteracy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProcessor"></see>
    /// </summary>
    let DataProcessor =
        Namespaced_IRI.parse _namespace_name "DataProcessor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProtectionAuthority"></see>
    /// </summary>
    let DataProtectionAuthority =
        Namespaced_IRI.parse _namespace_name "DataProtectionAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProtectionOfficer"></see>
    /// </summary>
    let DataProtectionOfficer =
        Namespaced_IRI.parse _namespace_name "DataProtectionOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Representative"></see>
    /// </summary>
    let Representative =
        Namespaced_IRI.parse _namespace_name "Representative" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataProtectionTraining"></see>
    /// </summary>
    let DataProtectionTraining =
        Namespaced_IRI.parse _namespace_name "DataProtectionTraining" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataPublishedByDataSubject"></see>
    /// </summary>
    let DataPublishedByDataSubject =
        Namespaced_IRI.parse _namespace_name "DataPublishedByDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectDataSource"></see>
    /// </summary>
    let DataSubjectDataSource =
        Namespaced_IRI.parse _namespace_name "DataSubjectDataSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataQualityAssessment"></see>
    /// </summary>
    let DataQualityAssessment =
        Namespaced_IRI.parse _namespace_name "DataQualityAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataQualityManagement"></see>
    /// </summary>
    let DataQualityManagement =
        Namespaced_IRI.parse _namespace_name "DataQualityManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataQualityImprovement"></see>
    /// </summary>
    let DataQualityImprovement =
        Namespaced_IRI.parse _namespace_name "DataQualityImprovement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataRedaction"></see>
    /// </summary>
    let DataRedaction =
        Namespaced_IRI.parse _namespace_name "DataRedaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSanitisationTechnique"></see>
    /// </summary>
    let DataSanitisationTechnique =
        Namespaced_IRI.parse _namespace_name "DataSanitisationTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataRestorationPolicy"></see>
    /// </summary>
    let DataRestorationPolicy =
        Namespaced_IRI.parse _namespace_name "DataRestorationPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataReusePolicy"></see>
    /// </summary>
    let DataReusePolicy =
        Namespaced_IRI.parse _namespace_name "DataReusePolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSecurityManagement"></see>
    /// </summary>
    let DataSecurityManagement =
        Namespaced_IRI.parse _namespace_name "DataSecurityManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataStoragePolicy"></see>
    /// </summary>
    let DataStoragePolicy =
        Namespaced_IRI.parse _namespace_name "DataStoragePolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubProcessor"></see>
    /// </summary>
    let DataSubProcessor =
        Namespaced_IRI.parse _namespace_name "DataSubProcessor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubject"></see>
    /// </summary>
    let DataSubject =
        Namespaced_IRI.parse _namespace_name "DataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectInformed"></see>
    /// </summary>
    let DataSubjectInformed =
        Namespaced_IRI.parse _namespace_name "DataSubjectInformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectRight"></see>
    /// </summary>
    let DataSubjectRight =
        Namespaced_IRI.parse _namespace_name "DataSubjectRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectRightsManagement"></see>
    /// </summary>
    let DataSubjectRightsManagement =
        Namespaced_IRI.parse _namespace_name "DataSubjectRightsManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightsManagement"></see>
    /// </summary>
    let RightsManagement =
        Namespaced_IRI.parse _namespace_name "RightsManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectScale"></see>
    /// </summary>
    let DataSubjectScale =
        Namespaced_IRI.parse _namespace_name "DataSubjectScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Scale"></see>
    /// </summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-scale-classes"></see>
    /// </summary>
    let ``processing-scale-classes`` =
        Namespaced_IRI.parse _namespace_name "processing-scale-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataSubjectUninformed"></see>
    /// </summary>
    let DataSubjectUninformed =
        Namespaced_IRI.parse _namespace_name "DataSubjectUninformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferImpactAssessment"></see>
    /// </summary>
    let DataTransferImpactAssessment =
        Namespaced_IRI.parse _namespace_name "DataTransferImpactAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImpactAssessment"></see>
    /// </summary>
    let ImpactAssessment =
        Namespaced_IRI.parse _namespace_name "ImpactAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferLegalBasis"></see>
    /// </summary>
    let DataTransferLegalBasis =
        Namespaced_IRI.parse _namespace_name "DataTransferLegalBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferNotice"></see>
    /// </summary>
    let DataTransferNotice =
        Namespaced_IRI.parse _namespace_name "DataTransferNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataTransferRecord"></see>
    /// </summary>
    let DataTransferRecord =
        Namespaced_IRI.parse _namespace_name "DataTransferRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DataVolume"></see>
    /// </summary>
    let DataVolume = Namespaced_IRI.parse _namespace_name "DataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DecentralisedLocations"></see>
    /// </summary>
    let DecentralisedLocations =
        Namespaced_IRI.parse _namespace_name "DecentralisedLocations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocationFixture"></see>
    /// </summary>
    let LocationFixture =
        Namespaced_IRI.parse _namespace_name "LocationFixture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Delete"></see>
    /// </summary>
    let Delete = Namespaced_IRI.parse _namespace_name "Delete" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Remove"></see>
    /// </summary>
    let Remove = Namespaced_IRI.parse _namespace_name "Remove" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeliveryOfGoods"></see>
    /// </summary>
    let DeliveryOfGoods =
        Namespaced_IRI.parse _namespace_name "DeliveryOfGoods" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestedServiceProvision"></see>
    /// </summary>
    let RequestedServiceProvision =
        Namespaced_IRI.parse _namespace_name "RequestedServiceProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Derive"></see>
    /// </summary>
    let Derive = Namespaced_IRI.parse _namespace_name "Derive" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DerivedData"></see>
    /// </summary>
    let DerivedData =
        Namespaced_IRI.parse _namespace_name "DerivedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DerivedPersonalData"></see>
    /// </summary>
    let DerivedPersonalData =
        Namespaced_IRI.parse _namespace_name "DerivedPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DesignStandard"></see>
    /// </summary>
    let DesignStandard =
        Namespaced_IRI.parse _namespace_name "DesignStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Standard"></see>
    /// </summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Destruct"></see>
    /// </summary>
    let Destruct = Namespaced_IRI.parse _namespace_name "Destruct" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeterministicPseudonymisation"></see>
    /// </summary>
    let DeterministicPseudonymisation =
        Namespaced_IRI.parse _namespace_name "DeterministicPseudonymisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Pseudonymisation"></see>
    /// </summary>
    let Pseudonymisation =
        Namespaced_IRI.parse _namespace_name "Pseudonymisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Deterrence"></see>
    /// </summary>
    let Deterrence = Namespaced_IRI.parse _namespace_name "Deterrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnacceptableRule"></see>
    /// </summary>
    let UnacceptableRule =
        Namespaced_IRI.parse _namespace_name "UnacceptableRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeterrenceFollowed"></see>
    /// </summary>
    let DeterrenceFollowed =
        Namespaced_IRI.parse _namespace_name "DeterrenceFollowed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleFulfilmentStatus"></see>
    /// </summary>
    let RuleFulfilmentStatus =
        Namespaced_IRI.parse _namespace_name "RuleFulfilmentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleFulfilled"></see>
    /// </summary>
    let RuleFulfilled =
        Namespaced_IRI.parse _namespace_name "RuleFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeterrenceNotFollowed"></see>
    /// </summary>
    let DeterrenceNotFollowed =
        Namespaced_IRI.parse _namespace_name "DeterrenceNotFollowed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleUnfulfilled"></see>
    /// </summary>
    let RuleUnfulfilled =
        Namespaced_IRI.parse _namespace_name "RuleUnfulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DeviceNotice"></see>
    /// </summary>
    let DeviceNotice =
        Namespaced_IRI.parse _namespace_name "DeviceNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DifferentialPrivacy"></see>
    /// </summary>
    let DifferentialPrivacy =
        Namespaced_IRI.parse _namespace_name "DifferentialPrivacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DigitalRightsManagement"></see>
    /// </summary>
    let DigitalRightsManagement =
        Namespaced_IRI.parse _namespace_name "DigitalRightsManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DigitalSignatures"></see>
    /// </summary>
    let DigitalSignatures =
        Namespaced_IRI.parse _namespace_name "DigitalSignatures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DirectMarketing"></see>
    /// </summary>
    let DirectMarketing =
        Namespaced_IRI.parse _namespace_name "DirectMarketing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DisasterRecoveryProcedures"></see>
    /// </summary>
    let DisasterRecoveryProcedures =
        Namespaced_IRI.parse _namespace_name "DisasterRecoveryProcedures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Disclose"></see>
    /// </summary>
    let Disclose = Namespaced_IRI.parse _namespace_name "Disclose" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DiscloseByTransmission"></see>
    /// </summary>
    let DiscloseByTransmission =
        Namespaced_IRI.parse _namespace_name "DiscloseByTransmission" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Display"></see>
    /// </summary>
    let Display = Namespaced_IRI.parse _namespace_name "Display" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DisputeManagement"></see>
    /// </summary>
    let DisputeManagement =
        Namespaced_IRI.parse _namespace_name "DisputeManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Disseminate"></see>
    /// </summary>
    let Disseminate =
        Namespaced_IRI.parse _namespace_name "Disseminate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DistributedSystemSecurity"></see>
    /// </summary>
    let DistributedSystemSecurity =
        Namespaced_IRI.parse _namespace_name "DistributedSystemSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityMethod"></see>
    /// </summary>
    let SecurityMethod =
        Namespaced_IRI.parse _namespace_name "SecurityMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DistributionAgreement"></see>
    /// </summary>
    let DistributionAgreement =
        Namespaced_IRI.parse _namespace_name "DistributionAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DocumentRandomisedPseudonymisation"></see>
    /// </summary>
    let DocumentRandomisedPseudonymisation =
        Namespaced_IRI.parse _namespace_name "DocumentRandomisedPseudonymisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#DocumentSecurity"></see>
    /// </summary>
    let DocumentSecurity =
        Namespaced_IRI.parse _namespace_name "DocumentSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Download"></see>
    /// </summary>
    let Download = Namespaced_IRI.parse _namespace_name "Download" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Duration"></see>
    /// </summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#EULA"></see>
    /// </summary>
    let EULA = Namespaced_IRI.parse _namespace_name "EULA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LicenseAgreement"></see>
    /// </summary>
    let LicenseAgreement =
        Namespaced_IRI.parse _namespace_name "LicenseAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EconomicUnion"></see>
    /// </summary>
    let EconomicUnion =
        Namespaced_IRI.parse _namespace_name "EconomicUnion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EducationalOrganisation"></see>
    /// </summary>
    let EducationalOrganisation =
        Namespaced_IRI.parse _namespace_name "EducationalOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EducationalTraining"></see>
    /// </summary>
    let EducationalTraining =
        Namespaced_IRI.parse _namespace_name "EducationalTraining" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EffectivenessDeterminationProcedures"></see>
    /// </summary>
    let EffectivenessDeterminationProcedures =
        Namespaced_IRI.parse _namespace_name "EffectivenessDeterminationProcedures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ElderlyDataSubject"></see>
    /// </summary>
    let ElderlyDataSubject =
        Namespaced_IRI.parse _namespace_name "ElderlyDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VulnerableDataSubject"></see>
    /// </summary>
    let VulnerableDataSubject =
        Namespaced_IRI.parse _namespace_name "VulnerableDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ElderlyHuman"></see>
    /// </summary>
    let ElderlyHuman =
        Namespaced_IRI.parse _namespace_name "ElderlyHuman" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EmergencyHealthcareProvider"></see>
    /// </summary>
    let EmergencyHealthcareProvider =
        Namespaced_IRI.parse _namespace_name "EmergencyHealthcareProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Employee"></see>
    /// </summary>
    let Employee = Namespaced_IRI.parse _namespace_name "Employee" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EmploymentContract"></see>
    /// </summary>
    let EmploymentContract =
        Namespaced_IRI.parse _namespace_name "EmploymentContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EncryptionAtRest"></see>
    /// </summary>
    let EncryptionAtRest =
        Namespaced_IRI.parse _namespace_name "EncryptionAtRest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EncryptionInTransfer"></see>
    /// </summary>
    let EncryptionInTransfer =
        Namespaced_IRI.parse _namespace_name "EncryptionInTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EncryptionInUse"></see>
    /// </summary>
    let EncryptionInUse =
        Namespaced_IRI.parse _namespace_name "EncryptionInUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EndToEndEncryption"></see>
    /// </summary>
    let EndToEndEncryption =
        Namespaced_IRI.parse _namespace_name "EndToEndEncryption" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EndlessDuration"></see>
    /// </summary>
    let EndlessDuration =
        Namespaced_IRI.parse _namespace_name "EndlessDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnforceAccessControl"></see>
    /// </summary>
    let EnforceAccessControl =
        Namespaced_IRI.parse _namespace_name "EnforceAccessControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnforceSecurity"></see>
    /// </summary>
    let EnforceSecurity =
        Namespaced_IRI.parse _namespace_name "EnforceSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnterIntoContract"></see>
    /// </summary>
    let EnterIntoContract =
        Namespaced_IRI.parse _namespace_name "EnterIntoContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-classes"></see>
    /// </summary>
    let ``entities-classes`` =
        Namespaced_IRI.parse _namespace_name "entities-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityActiveInvolvement"></see>
    /// </summary>
    let EntityActiveInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityActiveInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityIntendedInvolvement"></see>
    /// </summary>
    let EntityIntendedInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityIntendedInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInvolvementStatus"></see>
    /// </summary>
    let EntityInvolvementStatus =
        Namespaced_IRI.parse _namespace_name "EntityInvolvementStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Intended"></see>
    /// </summary>
    let Intended = Namespaced_IRI.parse _namespace_name "Intended" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityInvolved"></see>
    /// </summary>
    let EntityInvolved =
        Namespaced_IRI.parse _namespace_name "EntityInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityNonInvolvement"></see>
    /// </summary>
    let EntityNonInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityNonInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityNotInvolved"></see>
    /// </summary>
    let EntityNotInvolved =
        Namespaced_IRI.parse _namespace_name "EntityNotInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityPassiveInvolvement"></see>
    /// </summary>
    let EntityPassiveInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityPassiveInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityUnintendedInvolvement"></see>
    /// </summary>
    let EntityUnintendedInvolvement =
        Namespaced_IRI.parse _namespace_name "EntityUnintendedInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Unintended"></see>
    /// </summary>
    let Unintended = Namespaced_IRI.parse _namespace_name "Unintended" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EnvironmentalProtection"></see>
    /// </summary>
    let EnvironmentalProtection =
        Namespaced_IRI.parse _namespace_name "EnvironmentalProtection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalMeasure"></see>
    /// </summary>
    let PhysicalMeasure =
        Namespaced_IRI.parse _namespace_name "PhysicalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#physical-measures-classes"></see>
    /// </summary>
    let ``physical-measures-classes`` =
        Namespaced_IRI.parse _namespace_name "physical-measures-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Erase"></see>
    /// </summary>
    let Erase = Namespaced_IRI.parse _namespace_name "Erase" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EstablishContractualAgreement"></see>
    /// </summary>
    let EstablishContractualAgreement =
        Namespaced_IRI.parse _namespace_name "EstablishContractualAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EvaluationOfIndividuals"></see>
    /// </summary>
    let EvaluationOfIndividuals =
        Namespaced_IRI.parse _namespace_name "EvaluationOfIndividuals" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EvaluationScoring"></see>
    /// </summary>
    let EvaluationScoring =
        Namespaced_IRI.parse _namespace_name "EvaluationScoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ExpectationStatus"></see>
    /// </summary>
    let ExpectationStatus =
        Namespaced_IRI.parse _namespace_name "ExpectationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Expected"></see>
    /// </summary>
    let Expected = Namespaced_IRI.parse _namespace_name "Expected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ExplicitlyExpressedConsent"></see>
    /// </summary>
    let ExplicitlyExpressedConsent =
        Namespaced_IRI.parse _namespace_name "ExplicitlyExpressedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ExpressedConsent"></see>
    /// </summary>
    let ExpressedConsent =
        Namespaced_IRI.parse _namespace_name "ExpressedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-types-classes"></see>
    /// </summary>
    let ``consent-types-classes`` =
        Namespaced_IRI.parse _namespace_name "consent-types-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Export"></see>
    /// </summary>
    let Export = Namespaced_IRI.parse _namespace_name "Export" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformedConsent"></see>
    /// </summary>
    let InformedConsent =
        Namespaced_IRI.parse _namespace_name "InformedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FRIA"></see>
    /// </summary>
    let FRIA = Namespaced_IRI.parse _namespace_name "FRIA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FederatedLocations"></see>
    /// </summary>
    let FederatedLocations =
        Namespaced_IRI.parse _namespace_name "FederatedLocations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FeeNotRequired"></see>
    /// </summary>
    let FeeNotRequired =
        Namespaced_IRI.parse _namespace_name "FeeNotRequired" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FeeRequirement"></see>
    /// </summary>
    let FeeRequirement =
        Namespaced_IRI.parse _namespace_name "FeeRequirement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FeeRequired"></see>
    /// </summary>
    let FeeRequired =
        Namespaced_IRI.parse _namespace_name "FeeRequired" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FileSystemSecurity"></see>
    /// </summary>
    let FileSystemSecurity =
        Namespaced_IRI.parse _namespace_name "FileSystemSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Filter"></see>
    /// </summary>
    let Filter = Namespaced_IRI.parse _namespace_name "Filter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FireDepartment"></see>
    /// </summary>
    let FireDepartment =
        Namespaced_IRI.parse _namespace_name "FireDepartment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedLocation"></see>
    /// </summary>
    let FixedLocation =
        Namespaced_IRI.parse _namespace_name "FixedLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedMultipleLocations"></see>
    /// </summary>
    let FixedMultipleLocations =
        Namespaced_IRI.parse _namespace_name "FixedMultipleLocations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedOccurrencesDuration"></see>
    /// </summary>
    let FixedOccurrencesDuration =
        Namespaced_IRI.parse _namespace_name "FixedOccurrencesDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FixedSingularLocation"></see>
    /// </summary>
    let FixedSingularLocation =
        Namespaced_IRI.parse _namespace_name "FixedSingularLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ForProfitOrganisation"></see>
    /// </summary>
    let ForProfitOrganisation =
        Namespaced_IRI.parse _namespace_name "ForProfitOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Format"></see>
    /// </summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Structure"></see>
    /// </summary>
    let Structure = Namespaced_IRI.parse _namespace_name "Structure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MisusePreventionAndDetection"></see>
    /// </summary>
    let MisusePreventionAndDetection =
        Namespaced_IRI.parse _namespace_name "MisusePreventionAndDetection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FulfilmentOfContractualObligation"></see>
    /// </summary>
    let FulfilmentOfContractualObligation =
        Namespaced_IRI.parse _namespace_name "FulfilmentOfContractualObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FulfilmentOfObligation"></see>
    /// </summary>
    let FulfilmentOfObligation =
        Namespaced_IRI.parse _namespace_name "FulfilmentOfObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FullAutomation"></see>
    /// </summary>
    let FullAutomation =
        Namespaced_IRI.parse _namespace_name "FullAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#FullyRandomisedPseudonymisation"></see>
    /// </summary>
    let FullyRandomisedPseudonymisation =
        Namespaced_IRI.parse _namespace_name "FullyRandomisedPseudonymisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#G2BContract"></see>
    /// </summary>
    let G2BContract =
        Namespaced_IRI.parse _namespace_name "G2BContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#G2CContract"></see>
    /// </summary>
    let G2CContract =
        Namespaced_IRI.parse _namespace_name "G2CContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#G2GContract"></see>
    /// </summary>
    let G2GContract =
        Namespaced_IRI.parse _namespace_name "G2GContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Generate"></see>
    /// </summary>
    let Generate = Namespaced_IRI.parse _namespace_name "Generate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GeneratedData"></see>
    /// </summary>
    let GeneratedData =
        Namespaced_IRI.parse _namespace_name "GeneratedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GeneratedPersonalData"></see>
    /// </summary>
    let GeneratedPersonalData =
        Namespaced_IRI.parse _namespace_name "GeneratedPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GeographicCoverage"></see>
    /// </summary>
    let GeographicCoverage =
        Namespaced_IRI.parse _namespace_name "GeographicCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GlobalScale"></see>
    /// </summary>
    let GlobalScale =
        Namespaced_IRI.parse _namespace_name "GlobalScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GraphicalNotice"></see>
    /// </summary>
    let GraphicalNotice =
        Namespaced_IRI.parse _namespace_name "GraphicalNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GuardianOfDataSubject"></see>
    /// </summary>
    let GuardianOfDataSubject =
        Namespaced_IRI.parse _namespace_name "GuardianOfDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#GuardianOfHuman"></see>
    /// </summary>
    let GuardianOfHuman =
        Namespaced_IRI.parse _namespace_name "GuardianOfHuman" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Guideline"></see>
    /// </summary>
    let Guideline = Namespaced_IRI.parse _namespace_name "Guideline" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HardwareSecurityProtocols"></see>
    /// </summary>
    let HardwareSecurityProtocols =
        Namespaced_IRI.parse _namespace_name "HardwareSecurityProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HashFunctions"></see>
    /// </summary>
    let HashFunctions =
        Namespaced_IRI.parse _namespace_name "HashFunctions" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HashMessageAuthenticationCode"></see>
    /// </summary>
    let HashMessageAuthenticationCode =
        Namespaced_IRI.parse _namespace_name "HashMessageAuthenticationCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HealthcareOrganisation"></see>
    /// </summary>
    let HealthcareOrganisation =
        Namespaced_IRI.parse _namespace_name "HealthcareOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HighAutomation"></see>
    /// </summary>
    let HighAutomation =
        Namespaced_IRI.parse _namespace_name "HighAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HomomorphicEncryption"></see>
    /// </summary>
    let HomomorphicEncryption =
        Namespaced_IRI.parse _namespace_name "HomomorphicEncryption" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Hospital"></see>
    /// </summary>
    let Hospital = Namespaced_IRI.parse _namespace_name "Hospital" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HugeDataVolume"></see>
    /// </summary>
    let HugeDataVolume =
        Namespaced_IRI.parse _namespace_name "HugeDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HugeScaleOfDataSubjects"></see>
    /// </summary>
    let HugeScaleOfDataSubjects =
        Namespaced_IRI.parse _namespace_name "HugeScaleOfDataSubjects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolved"></see>
    /// </summary>
    let HumanInvolved =
        Namespaced_IRI.parse _namespace_name "HumanInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvement"></see>
    /// </summary>
    let HumanInvolvement =
        Namespaced_IRI.parse _namespace_name "HumanInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForControl"></see>
    /// </summary>
    let HumanInvolvementForControl =
        Namespaced_IRI.parse _namespace_name "HumanInvolvementForControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForDecision"></see>
    /// </summary>
    let HumanInvolvementForDecision =
        Namespaced_IRI.parse _namespace_name "HumanInvolvementForDecision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForInput"></see>
    /// </summary>
    let HumanInvolvementForInput =
        Namespaced_IRI.parse _namespace_name "HumanInvolvementForInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForIntervention"></see>
    /// </summary>
    let HumanInvolvementForIntervention =
        Namespaced_IRI.parse _namespace_name "HumanInvolvementForIntervention" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForOversight"></see>
    /// </summary>
    let HumanInvolvementForOversight =
        Namespaced_IRI.parse _namespace_name "HumanInvolvementForOversight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanInvolvementForVerification"></see>
    /// </summary>
    let HumanInvolvementForVerification =
        Namespaced_IRI.parse _namespace_name "HumanInvolvementForVerification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanNotInvolved"></see>
    /// </summary>
    let HumanNotInvolved =
        Namespaced_IRI.parse _namespace_name "HumanNotInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HumanResourceManagement"></see>
    /// </summary>
    let HumanResourceManagement =
        Namespaced_IRI.parse _namespace_name "HumanResourceManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#HybridPublicPrivateSpace"></see>
    /// </summary>
    let HybridPublicPrivateSpace =
        Namespaced_IRI.parse _namespace_name "HybridPublicPrivateSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicSpace"></see>
    /// </summary>
    let PublicSpace =
        Namespaced_IRI.parse _namespace_name "PublicSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateSpace"></see>
    /// </summary>
    let PrivateSpace =
        Namespaced_IRI.parse _namespace_name "PrivateSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IPRManagement"></see>
    /// </summary>
    let IPRManagement =
        Namespaced_IRI.parse _namespace_name "IPRManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentifyingPersonalData"></see>
    /// </summary>
    let IdentifyingPersonalData =
        Namespaced_IRI.parse _namespace_name "IdentifyingPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentityAuthentication"></see>
    /// </summary>
    let IdentityAuthentication =
        Namespaced_IRI.parse _namespace_name "IdentityAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentityManagementMethod"></see>
    /// </summary>
    let IdentityManagementMethod =
        Namespaced_IRI.parse _namespace_name "IdentityManagementMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IdentityVerification"></see>
    /// </summary>
    let IdentityVerification =
        Namespaced_IRI.parse _namespace_name "IdentityVerification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Immigrant"></see>
    /// </summary>
    let Immigrant = Namespaced_IRI.parse _namespace_name "Immigrant" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Impact"></see>
    /// </summary>
    let Impact = Namespaced_IRI.parse _namespace_name "Impact" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskAssessment"></see>
    /// </summary>
    let RiskAssessment =
        Namespaced_IRI.parse _namespace_name "RiskAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImpliedConsent"></see>
    /// </summary>
    let ImpliedConsent =
        Namespaced_IRI.parse _namespace_name "ImpliedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Importance"></see>
    /// </summary>
    let Importance = Namespaced_IRI.parse _namespace_name "Importance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveExistingProductsAndServices"></see>
    /// </summary>
    let ImproveExistingProductsAndServices =
        Namespaced_IRI.parse _namespace_name "ImproveExistingProductsAndServices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptimisationForController"></see>
    /// </summary>
    let OptimisationForController =
        Namespaced_IRI.parse _namespace_name "OptimisationForController" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveHealthcare"></see>
    /// </summary>
    let ImproveHealthcare =
        Namespaced_IRI.parse _namespace_name "ImproveHealthcare" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveInternalCRMProcesses"></see>
    /// </summary>
    let ImproveInternalCRMProcesses =
        Namespaced_IRI.parse _namespace_name "ImproveInternalCRMProcesses" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImprovePublicServices"></see>
    /// </summary>
    let ImprovePublicServices =
        Namespaced_IRI.parse _namespace_name "ImprovePublicServices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ImproveTransportMobility"></see>
    /// </summary>
    let ImproveTransportMobility =
        Namespaced_IRI.parse _namespace_name "ImproveTransportMobility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncidentManagementProcedures"></see>
    /// </summary>
    let IncidentManagementProcedures =
        Namespaced_IRI.parse _namespace_name "IncidentManagementProcedures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncidentReportingCommunication"></see>
    /// </summary>
    let IncidentReportingCommunication =
        Namespaced_IRI.parse _namespace_name "IncidentReportingCommunication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncorrectData"></see>
    /// </summary>
    let IncorrectData =
        Namespaced_IRI.parse _namespace_name "IncorrectData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IncreaseServiceRobustness"></see>
    /// </summary>
    let IncreaseServiceRobustness =
        Namespaced_IRI.parse _namespace_name "IncreaseServiceRobustness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IndeterminateDuration"></see>
    /// </summary>
    let IndeterminateDuration =
        Namespaced_IRI.parse _namespace_name "IndeterminateDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IndustryConsortium"></see>
    /// </summary>
    let IndustryConsortium =
        Namespaced_IRI.parse _namespace_name "IndustryConsortium" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Infer"></see>
    /// </summary>
    let Infer = Namespaced_IRI.parse _namespace_name "Infer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InferredData"></see>
    /// </summary>
    let InferredData =
        Namespaced_IRI.parse _namespace_name "InferredData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InferredPersonalData"></see>
    /// </summary>
    let InferredPersonalData =
        Namespaced_IRI.parse _namespace_name "InferredPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformationAudit"></see>
    /// </summary>
    let InformationAudit =
        Namespaced_IRI.parse _namespace_name "InformationAudit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformationFlowControl"></see>
    /// </summary>
    let InformationFlowControl =
        Namespaced_IRI.parse _namespace_name "InformationFlowControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InformationSecurityPolicy"></see>
    /// </summary>
    let InformationSecurityPolicy =
        Namespaced_IRI.parse _namespace_name "InformationSecurityPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InnovativeUseOfExistingTechnology"></see>
    /// </summary>
    let InnovativeUseOfExistingTechnology =
        Namespaced_IRI.parse _namespace_name "InnovativeUseOfExistingTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InnovativeUseOfTechnology"></see>
    /// </summary>
    let InnovativeUseOfTechnology =
        Namespaced_IRI.parse _namespace_name "InnovativeUseOfTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InnovativeUseOfNewTechnologies"></see>
    /// </summary>
    let InnovativeUseOfNewTechnologies =
        Namespaced_IRI.parse _namespace_name "InnovativeUseOfNewTechnologies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IntellectualPropertyData"></see>
    /// </summary>
    let IntellectualPropertyData =
        Namespaced_IRI.parse _namespace_name "IntellectualPropertyData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IntentionStatus"></see>
    /// </summary>
    let IntentionStatus =
        Namespaced_IRI.parse _namespace_name "IntentionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InternalResourceOptimisation"></see>
    /// </summary>
    let InternalResourceOptimisation =
        Namespaced_IRI.parse _namespace_name "InternalResourceOptimisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InternationalOrganisation"></see>
    /// </summary>
    let InternationalOrganisation =
        Namespaced_IRI.parse _namespace_name "InternationalOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#IntrusionDetectionSystem"></see>
    /// </summary>
    let IntrusionDetectionSystem =
        Namespaced_IRI.parse _namespace_name "IntrusionDetectionSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#InverseJurisdiction"></see>
    /// </summary>
    let InverseJurisdiction =
        Namespaced_IRI.parse _namespace_name "InverseJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#JITNotice"></see>
    /// </summary>
    let JITNotice = Namespaced_IRI.parse _namespace_name "JITNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#JobApplicant"></see>
    /// </summary>
    let JobApplicant =
        Namespaced_IRI.parse _namespace_name "JobApplicant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#JointDataControllers"></see>
    /// </summary>
    let JointDataControllers =
        Namespaced_IRI.parse _namespace_name "JointDataControllers" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#JointDataControllersAgreement"></see>
    /// </summary>
    let JointDataControllersAgreement =
        Namespaced_IRI.parse _namespace_name "JointDataControllersAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#JudicialOrganisation"></see>
    /// </summary>
    let JudicialOrganisation =
        Namespaced_IRI.parse _namespace_name "JudicialOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Justification"></see>
    /// </summary>
    let Justification =
        Namespaced_IRI.parse _namespace_name "Justification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LargeDataVolume"></see>
    /// </summary>
    let LargeDataVolume =
        Namespaced_IRI.parse _namespace_name "LargeDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LargeScaleOfDataSubjects"></see>
    /// </summary>
    let LargeScaleOfDataSubjects =
        Namespaced_IRI.parse _namespace_name "LargeScaleOfDataSubjects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LargeScaleProcessing"></see>
    /// </summary>
    let LargeScaleProcessing =
        Namespaced_IRI.parse _namespace_name "LargeScaleProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingScale"></see>
    /// </summary>
    let ProcessingScale =
        Namespaced_IRI.parse _namespace_name "ProcessingScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Law"></see>
    /// </summary>
    let Law = Namespaced_IRI.parse _namespace_name "Law" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LawEnforcementOrganisation"></see>
    /// </summary>
    let LawEnforcementOrganisation =
        Namespaced_IRI.parse _namespace_name "LawEnforcementOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Lawful"></see>
    /// </summary>
    let Lawful = Namespaced_IRI.parse _namespace_name "Lawful" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Lawfulness"></see>
    /// </summary>
    let Lawfulness = Namespaced_IRI.parse _namespace_name "Lawfulness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LawfulnessUnknown"></see>
    /// </summary>
    let LawfulnessUnknown =
        Namespaced_IRI.parse _namespace_name "LawfulnessUnknown" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LayeredNotice"></see>
    /// </summary>
    let LayeredNotice =
        Namespaced_IRI.parse _namespace_name "LayeredNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalCompliance"></see>
    /// </summary>
    let LegalCompliance =
        Namespaced_IRI.parse _namespace_name "LegalCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalComplianceAssessment"></see>
    /// </summary>
    let LegalComplianceAssessment =
        Namespaced_IRI.parse _namespace_name "LegalComplianceAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalComplianceAudit"></see>
    /// </summary>
    let LegalComplianceAudit =
        Namespaced_IRI.parse _namespace_name "LegalComplianceAudit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalOrganisationalMeasure"></see>
    /// </summary>
    let TechnicalOrganisationalMeasure =
        Namespaced_IRI.parse _namespace_name "TechnicalOrganisationalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TOM-classes"></see>
    /// </summary>
    let ``TOM-classes`` =
        Namespaced_IRI.parse _namespace_name "TOM-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligation"></see>
    /// </summary>
    let LegalObligation =
        Namespaced_IRI.parse _namespace_name "LegalObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationCompleted"></see>
    /// </summary>
    let LegalObligationCompleted =
        Namespaced_IRI.parse _namespace_name "LegalObligationCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationStatus"></see>
    /// </summary>
    let LegalObligationStatus =
        Namespaced_IRI.parse _namespace_name "LegalObligationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-basis-status-classes"></see>
    /// </summary>
    let ``legal-basis-status-classes`` =
        Namespaced_IRI.parse _namespace_name "legal-basis-status-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationOngoing"></see>
    /// </summary>
    let LegalObligationOngoing =
        Namespaced_IRI.parse _namespace_name "LegalObligationOngoing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegalObligationPending"></see>
    /// </summary>
    let LegalObligationPending =
        Namespaced_IRI.parse _namespace_name "LegalObligationPending" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterest"></see>
    /// </summary>
    let LegitimateInterest =
        Namespaced_IRI.parse _namespace_name "LegitimateInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestAssessment"></see>
    /// </summary>
    let LegitimateInterestAssessment =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestInformed"></see>
    /// </summary>
    let LegitimateInterestInformed =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestInformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestStatus"></see>
    /// </summary>
    let LegitimateInterestStatus =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestNotObjected"></see>
    /// </summary>
    let LegitimateInterestNotObjected =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestNotObjected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestObjected"></see>
    /// </summary>
    let LegitimateInterestObjected =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestObjected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestOfController"></see>
    /// </summary>
    let LegitimateInterestOfController =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestOfController" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestOfDataSubject"></see>
    /// </summary>
    let LegitimateInterestOfDataSubject =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestOfDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestOfThirdParty"></see>
    /// </summary>
    let LegitimateInterestOfThirdParty =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestOfThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LegitimateInterestUninformed"></see>
    /// </summary>
    let LegitimateInterestUninformed =
        Namespaced_IRI.parse _namespace_name "LegitimateInterestUninformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Likelihood"></see>
    /// </summary>
    let Likelihood = Namespaced_IRI.parse _namespace_name "Likelihood" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocalEnvironmentScale"></see>
    /// </summary>
    let LocalEnvironmentScale =
        Namespaced_IRI.parse _namespace_name "LocalEnvironmentScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocalLocation"></see>
    /// </summary>
    let LocalLocation =
        Namespaced_IRI.parse _namespace_name "LocalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocationLocality"></see>
    /// </summary>
    let LocationLocality =
        Namespaced_IRI.parse _namespace_name "LocationLocality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LocalityScale"></see>
    /// </summary>
    let LocalityScale =
        Namespaced_IRI.parse _namespace_name "LocalityScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#LoggingPolicy"></see>
    /// </summary>
    let LoggingPolicy =
        Namespaced_IRI.parse _namespace_name "LoggingPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MaintainFraudDatabase"></see>
    /// </summary>
    let MaintainFraudDatabase =
        Namespaced_IRI.parse _namespace_name "MaintainFraudDatabase" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MakeAvailable"></see>
    /// </summary>
    let MakeAvailable =
        Namespaced_IRI.parse _namespace_name "MakeAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ManageConsent"></see>
    /// </summary>
    let ManageConsent =
        Namespaced_IRI.parse _namespace_name "ManageConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithdrawConsent"></see>
    /// </summary>
    let WithdrawConsent =
        Namespaced_IRI.parse _namespace_name "WithdrawConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideConsent"></see>
    /// </summary>
    let ProvideConsent =
        Namespaced_IRI.parse _namespace_name "ProvideConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReaffirmConsent"></see>
    /// </summary>
    let ReaffirmConsent =
        Namespaced_IRI.parse _namespace_name "ReaffirmConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ManagementStandard"></see>
    /// </summary>
    let ManagementStandard =
        Namespaced_IRI.parse _namespace_name "ManagementStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Match"></see>
    /// </summary>
    let Match = Namespaced_IRI.parse _namespace_name "Match" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MediumDataVolume"></see>
    /// </summary>
    let MediumDataVolume =
        Namespaced_IRI.parse _namespace_name "MediumDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MediumScaleOfDataSubjects"></see>
    /// </summary>
    let MediumScaleOfDataSubjects =
        Namespaced_IRI.parse _namespace_name "MediumScaleOfDataSubjects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MediumScaleProcessing"></see>
    /// </summary>
    let MediumScaleProcessing =
        Namespaced_IRI.parse _namespace_name "MediumScaleProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Member"></see>
    /// </summary>
    let Member = Namespaced_IRI.parse _namespace_name "Member" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MemberPartnerManagement"></see>
    /// </summary>
    let MemberPartnerManagement =
        Namespaced_IRI.parse _namespace_name "MemberPartnerManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MentallyVulnerableDataSubject"></see>
    /// </summary>
    let MentallyVulnerableDataSubject =
        Namespaced_IRI.parse _namespace_name "MentallyVulnerableDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MentallyVulnerableHuman"></see>
    /// </summary>
    let MentallyVulnerableHuman =
        Namespaced_IRI.parse _namespace_name "MentallyVulnerableHuman" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MessageAuthenticationCodes"></see>
    /// </summary>
    let MessageAuthenticationCodes =
        Namespaced_IRI.parse _namespace_name "MessageAuthenticationCodes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MetadataManagement"></see>
    /// </summary>
    let MetadataManagement =
        Namespaced_IRI.parse _namespace_name "MetadataManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MobilePlatformSecurity"></see>
    /// </summary>
    let MobilePlatformSecurity =
        Namespaced_IRI.parse _namespace_name "MobilePlatformSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Modify"></see>
    /// </summary>
    let Modify = Namespaced_IRI.parse _namespace_name "Modify" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Monitor"></see>
    /// </summary>
    let Monitor = Namespaced_IRI.parse _namespace_name "Monitor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MonitoringPolicy"></see>
    /// </summary>
    let MonitoringPolicy =
        Namespaced_IRI.parse _namespace_name "MonitoringPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MonotonicCounterPseudonymisation"></see>
    /// </summary>
    let MonotonicCounterPseudonymisation =
        Namespaced_IRI.parse _namespace_name "MonotonicCounterPseudonymisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Move"></see>
    /// </summary>
    let Move = Namespaced_IRI.parse _namespace_name "Move" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MultiFactorAuthentication"></see>
    /// </summary>
    let MultiFactorAuthentication =
        Namespaced_IRI.parse _namespace_name "MultiFactorAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#MultiNationalScale"></see>
    /// </summary>
    let MultiNationalScale =
        Namespaced_IRI.parse _namespace_name "MultiNationalScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NDA"></see>
    /// </summary>
    let NDA = Namespaced_IRI.parse _namespace_name "NDA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NationalAuthority"></see>
    /// </summary>
    let NationalAuthority =
        Namespaced_IRI.parse _namespace_name "NationalAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NationalScale"></see>
    /// </summary>
    let NationalScale =
        Namespaced_IRI.parse _namespace_name "NationalScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NaturalPerson"></see>
    /// </summary>
    let NaturalPerson =
        Namespaced_IRI.parse _namespace_name "NaturalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NearlyGlobalScale"></see>
    /// </summary>
    let NearlyGlobalScale =
        Namespaced_IRI.parse _namespace_name "NearlyGlobalScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Necessity"></see>
    /// </summary>
    let Necessity = Namespaced_IRI.parse _namespace_name "Necessity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NegotiateContract"></see>
    /// </summary>
    let NegotiateContract =
        Namespaced_IRI.parse _namespace_name "NegotiateContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NegotiatedContract"></see>
    /// </summary>
    let NegotiatedContract =
        Namespaced_IRI.parse _namespace_name "NegotiatedContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NetworkProxyRouting"></see>
    /// </summary>
    let NetworkProxyRouting =
        Namespaced_IRI.parse _namespace_name "NetworkProxyRouting" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NetworkSecurityProtocols"></see>
    /// </summary>
    let NetworkSecurityProtocols =
        Namespaced_IRI.parse _namespace_name "NetworkSecurityProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCitizen"></see>
    /// </summary>
    let NonCitizen = Namespaced_IRI.parse _namespace_name "NonCitizen" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCommercialPurpose"></see>
    /// </summary>
    let NonCommercialPurpose =
        Namespaced_IRI.parse _namespace_name "NonCommercialPurpose" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCommercialResearch"></see>
    /// </summary>
    let NonCommercialResearch =
        Namespaced_IRI.parse _namespace_name "NonCommercialResearch" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonCompliant"></see>
    /// </summary>
    let NonCompliant =
        Namespaced_IRI.parse _namespace_name "NonCompliant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonConformant"></see>
    /// </summary>
    let NonConformant =
        Namespaced_IRI.parse _namespace_name "NonConformant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonGovernmentalOrganisation"></see>
    /// </summary>
    let NonGovernmentalOrganisation =
        Namespaced_IRI.parse _namespace_name "NonGovernmentalOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonPersonalDataProcess"></see>
    /// </summary>
    let NonPersonalDataProcess =
        Namespaced_IRI.parse _namespace_name "NonPersonalDataProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Process"></see>
    /// </summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#process-classes"></see>
    /// </summary>
    let ``process-classes`` =
        Namespaced_IRI.parse _namespace_name "process-classes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonProfitOrganisation"></see>
    /// </summary>
    let NonProfitOrganisation =
        Namespaced_IRI.parse _namespace_name "NonProfitOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NonPublicDataSource"></see>
    /// </summary>
    let NonPublicDataSource =
        Namespaced_IRI.parse _namespace_name "NonPublicDataSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotApplicable"></see>
    /// </summary>
    let NotApplicable =
        Namespaced_IRI.parse _namespace_name "NotApplicable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotAutomated"></see>
    /// </summary>
    let NotAutomated =
        Namespaced_IRI.parse _namespace_name "NotAutomated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotAvailable"></see>
    /// </summary>
    let NotAvailable =
        Namespaced_IRI.parse _namespace_name "NotAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotInvolved"></see>
    /// </summary>
    let NotInvolved =
        Namespaced_IRI.parse _namespace_name "NotInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotRequired"></see>
    /// </summary>
    let NotRequired =
        Namespaced_IRI.parse _namespace_name "NotRequired" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeCommunicated"></see>
    /// </summary>
    let NoticeCommunicated =
        Namespaced_IRI.parse _namespace_name "NoticeCommunicated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeStatus"></see>
    /// </summary>
    let NoticeStatus =
        Namespaced_IRI.parse _namespace_name "NoticeStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeGenerated"></see>
    /// </summary>
    let NoticeGenerated =
        Namespaced_IRI.parse _namespace_name "NoticeGenerated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeIcon"></see>
    /// </summary>
    let NoticeIcon = Namespaced_IRI.parse _namespace_name "NoticeIcon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeLatest"></see>
    /// </summary>
    let NoticeLatest =
        Namespaced_IRI.parse _namespace_name "NoticeLatest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeLayer"></see>
    /// </summary>
    let NoticeLayer =
        Namespaced_IRI.parse _namespace_name "NoticeLayer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeStale"></see>
    /// </summary>
    let NoticeStale =
        Namespaced_IRI.parse _namespace_name "NoticeStale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeUnused"></see>
    /// </summary>
    let NoticeUnused =
        Namespaced_IRI.parse _namespace_name "NoticeUnused" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeUpdated"></see>
    /// </summary>
    let NoticeUpdated =
        Namespaced_IRI.parse _namespace_name "NoticeUpdated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NoticeUsed"></see>
    /// </summary>
    let NoticeUsed = Namespaced_IRI.parse _namespace_name "NoticeUsed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Notification"></see>
    /// </summary>
    let Notification =
        Namespaced_IRI.parse _namespace_name "Notification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationCompleted"></see>
    /// </summary>
    let NotificationCompleted =
        Namespaced_IRI.parse _namespace_name "NotificationCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationStatus"></see>
    /// </summary>
    let NotificationStatus =
        Namespaced_IRI.parse _namespace_name "NotificationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationFailed"></see>
    /// </summary>
    let NotificationFailed =
        Namespaced_IRI.parse _namespace_name "NotificationFailed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationNotNeeded"></see>
    /// </summary>
    let NotificationNotNeeded =
        Namespaced_IRI.parse _namespace_name "NotificationNotNeeded" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationOngoing"></see>
    /// </summary>
    let NotificationOngoing =
        Namespaced_IRI.parse _namespace_name "NotificationOngoing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#NotificationPlanned"></see>
    /// </summary>
    let NotificationPlanned =
        Namespaced_IRI.parse _namespace_name "NotificationPlanned" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObjectingToProcess"></see>
    /// </summary>
    let ObjectingToProcess =
        Namespaced_IRI.parse _namespace_name "ObjectingToProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Obligation"></see>
    /// </summary>
    let Obligation = Namespaced_IRI.parse _namespace_name "Obligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObligationFulfilled"></see>
    /// </summary>
    let ObligationFulfilled =
        Namespaced_IRI.parse _namespace_name "ObligationFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObligationUnfulfilled"></see>
    /// </summary>
    let ObligationUnfulfilled =
        Namespaced_IRI.parse _namespace_name "ObligationUnfulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObligationViolated"></see>
    /// </summary>
    let ObligationViolated =
        Namespaced_IRI.parse _namespace_name "ObligationViolated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RuleViolated"></see>
    /// </summary>
    let RuleViolated =
        Namespaced_IRI.parse _namespace_name "RuleViolated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Observe"></see>
    /// </summary>
    let Observe = Namespaced_IRI.parse _namespace_name "Observe" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObservedData"></see>
    /// </summary>
    let ObservedData =
        Namespaced_IRI.parse _namespace_name "ObservedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObservedPersonalData"></see>
    /// </summary>
    let ObservedPersonalData =
        Namespaced_IRI.parse _namespace_name "ObservedPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ObtainConsent"></see>
    /// </summary>
    let ObtainConsent =
        Namespaced_IRI.parse _namespace_name "ObtainConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfferContract"></see>
    /// </summary>
    let OfferContract =
        Namespaced_IRI.parse _namespace_name "OfferContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExerciseCompleted"></see>
    /// </summary>
    let OfficialAuthorityExerciseCompleted =
        Namespaced_IRI.parse _namespace_name "OfficialAuthorityExerciseCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExerciseStatus"></see>
    /// </summary>
    let OfficialAuthorityExerciseStatus =
        Namespaced_IRI.parse _namespace_name "OfficialAuthorityExerciseStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExerciseOngoing"></see>
    /// </summary>
    let OfficialAuthorityExerciseOngoing =
        Namespaced_IRI.parse _namespace_name "OfficialAuthorityExerciseOngoing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityExercisePending"></see>
    /// </summary>
    let OfficialAuthorityExercisePending =
        Namespaced_IRI.parse _namespace_name "OfficialAuthorityExercisePending" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OfficialAuthorityOfController"></see>
    /// </summary>
    let OfficialAuthorityOfController =
        Namespaced_IRI.parse _namespace_name "OfficialAuthorityOfController" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OftenFrequency"></see>
    /// </summary>
    let OftenFrequency =
        Namespaced_IRI.parse _namespace_name "OftenFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OperatingSystemSecurity"></see>
    /// </summary>
    let OperatingSystemSecurity =
        Namespaced_IRI.parse _namespace_name "OperatingSystemSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptimisationForConsumer"></see>
    /// </summary>
    let OptimisationForConsumer =
        Namespaced_IRI.parse _namespace_name "OptimisationForConsumer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceOptimisation"></see>
    /// </summary>
    let ServiceOptimisation =
        Namespaced_IRI.parse _namespace_name "ServiceOptimisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptimiseUserInterface"></see>
    /// </summary>
    let OptimiseUserInterface =
        Namespaced_IRI.parse _namespace_name "OptimiseUserInterface" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptingInToProcess"></see>
    /// </summary>
    let OptingInToProcess =
        Namespaced_IRI.parse _namespace_name "OptingInToProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OptingOutFromProcess"></see>
    /// </summary>
    let OptingOutFromProcess =
        Namespaced_IRI.parse _namespace_name "OptingOutFromProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Optional"></see>
    /// </summary>
    let Optional = Namespaced_IRI.parse _namespace_name "Optional" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#OralNotice"></see>
    /// </summary>
    let OralNotice = Namespaced_IRI.parse _namespace_name "OralNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationComplianceManagement"></see>
    /// </summary>
    let OrganisationComplianceManagement =
        Namespaced_IRI.parse _namespace_name "OrganisationComplianceManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationRiskManagement"></see>
    /// </summary>
    let OrganisationRiskManagement =
        Namespaced_IRI.parse _namespace_name "OrganisationRiskManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#OrganisationalUnit"></see>
    /// </summary>
    let OrganisationalUnit =
        Namespaced_IRI.parse _namespace_name "OrganisationalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Organise"></see>
    /// </summary>
    let Organise = Namespaced_IRI.parse _namespace_name "Organise" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#PIA"></see>
    /// </summary>
    let PIA = Namespaced_IRI.parse _namespace_name "PIA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ParentLegalEntity"></see>
    /// </summary>
    let ParentLegalEntity =
        Namespaced_IRI.parse _namespace_name "ParentLegalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ParentOfDataSubject"></see>
    /// </summary>
    let ParentOfDataSubject =
        Namespaced_IRI.parse _namespace_name "ParentOfDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ParentOfHuman"></see>
    /// </summary>
    let ParentOfHuman =
        Namespaced_IRI.parse _namespace_name "ParentOfHuman" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PartialAutomation"></see>
    /// </summary>
    let PartialAutomation =
        Namespaced_IRI.parse _namespace_name "PartialAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PartiallyCompliant"></see>
    /// </summary>
    let PartiallyCompliant =
        Namespaced_IRI.parse _namespace_name "PartiallyCompliant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Participant"></see>
    /// </summary>
    let Participant =
        Namespaced_IRI.parse _namespace_name "Participant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PassiveRight"></see>
    /// </summary>
    let PassiveRight =
        Namespaced_IRI.parse _namespace_name "PassiveRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PassivelyInvolved"></see>
    /// </summary>
    let PassivelyInvolved =
        Namespaced_IRI.parse _namespace_name "PassivelyInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PasswordAuthentication"></see>
    /// </summary>
    let PasswordAuthentication =
        Namespaced_IRI.parse _namespace_name "PasswordAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Patient"></see>
    /// </summary>
    let Patient = Namespaced_IRI.parse _namespace_name "Patient" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PaymentManagement"></see>
    /// </summary>
    let PaymentManagement =
        Namespaced_IRI.parse _namespace_name "PaymentManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceProvision"></see>
    /// </summary>
    let ServiceProvision =
        Namespaced_IRI.parse _namespace_name "ServiceProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PenetrationTestingMethods"></see>
    /// </summary>
    let PenetrationTestingMethods =
        Namespaced_IRI.parse _namespace_name "PenetrationTestingMethods" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Permission"></see>
    /// </summary>
    let Permission = Namespaced_IRI.parse _namespace_name "Permission" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PermissionNotUtilised"></see>
    /// </summary>
    let PermissionNotUtilised =
        Namespaced_IRI.parse _namespace_name "PermissionNotUtilised" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PermissionUtilised"></see>
    /// </summary>
    let PermissionUtilised =
        Namespaced_IRI.parse _namespace_name "PermissionUtilised" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalDataAudit"></see>
    /// </summary>
    let PersonalDataAudit =
        Namespaced_IRI.parse _namespace_name "PersonalDataAudit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalDataHandling"></see>
    /// </summary>
    let PersonalDataHandling =
        Namespaced_IRI.parse _namespace_name "PersonalDataHandling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalDataProcess"></see>
    /// </summary>
    let PersonalDataProcess =
        Namespaced_IRI.parse _namespace_name "PersonalDataProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalSpace"></see>
    /// </summary>
    let PersonalSpace =
        Namespaced_IRI.parse _namespace_name "PersonalSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Personalisation"></see>
    /// </summary>
    let Personalisation =
        Namespaced_IRI.parse _namespace_name "Personalisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalisedAdvertising"></see>
    /// </summary>
    let PersonalisedAdvertising =
        Namespaced_IRI.parse _namespace_name "PersonalisedAdvertising" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonalisedBenefits"></see>
    /// </summary>
    let PersonalisedBenefits =
        Namespaced_IRI.parse _namespace_name "PersonalisedBenefits" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServicePersonalisation"></see>
    /// </summary>
    let ServicePersonalisation =
        Namespaced_IRI.parse _namespace_name "ServicePersonalisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelBehaviourMonitoring"></see>
    /// </summary>
    let PersonnelBehaviourMonitoring =
        Namespaced_IRI.parse _namespace_name "PersonnelBehaviourMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelMonitoring"></see>
    /// </summary>
    let PersonnelMonitoring =
        Namespaced_IRI.parse _namespace_name "PersonnelMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelHiring"></see>
    /// </summary>
    let PersonnelHiring =
        Namespaced_IRI.parse _namespace_name "PersonnelHiring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelManagement"></see>
    /// </summary>
    let PersonnelManagement =
        Namespaced_IRI.parse _namespace_name "PersonnelManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelOffboarding"></see>
    /// </summary>
    let PersonnelOffboarding =
        Namespaced_IRI.parse _namespace_name "PersonnelOffboarding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelOnboarding"></see>
    /// </summary>
    let PersonnelOnboarding =
        Namespaced_IRI.parse _namespace_name "PersonnelOnboarding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPayment"></see>
    /// </summary>
    let PersonnelPayment =
        Namespaced_IRI.parse _namespace_name "PersonnelPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformanceEvaluation"></see>
    /// </summary>
    let PersonnelPerformanceEvaluation =
        Namespaced_IRI.parse _namespace_name "PersonnelPerformanceEvaluation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformanceManagement"></see>
    /// </summary>
    let PersonnelPerformanceManagement =
        Namespaced_IRI.parse _namespace_name "PersonnelPerformanceManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformanceMonitoring"></see>
    /// </summary>
    let PersonnelPerformanceMonitoring =
        Namespaced_IRI.parse _namespace_name "PersonnelPerformanceMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPerformancePrediction"></see>
    /// </summary>
    let PersonnelPerformancePrediction =
        Namespaced_IRI.parse _namespace_name "PersonnelPerformancePrediction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelPromotionManagement"></see>
    /// </summary>
    let PersonnelPromotionManagement =
        Namespaced_IRI.parse _namespace_name "PersonnelPromotionManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelTerminationManagement"></see>
    /// </summary>
    let PersonnelTerminationManagement =
        Namespaced_IRI.parse _namespace_name "PersonnelTerminationManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PersonnelWorkloadManagement"></see>
    /// </summary>
    let PersonnelWorkloadManagement =
        Namespaced_IRI.parse _namespace_name "PersonnelWorkloadManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalAccessControlMethod"></see>
    /// </summary>
    let PhysicalAccessControlMethod =
        Namespaced_IRI.parse _namespace_name "PhysicalAccessControlMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalAuthentication"></see>
    /// </summary>
    let PhysicalAuthentication =
        Namespaced_IRI.parse _namespace_name "PhysicalAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalAuthorisation"></see>
    /// </summary>
    let PhysicalAuthorisation =
        Namespaced_IRI.parse _namespace_name "PhysicalAuthorisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalDeviceSecurity"></see>
    /// </summary>
    let PhysicalDeviceSecurity =
        Namespaced_IRI.parse _namespace_name "PhysicalDeviceSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalInterceptionProtection"></see>
    /// </summary>
    let PhysicalInterceptionProtection =
        Namespaced_IRI.parse _namespace_name "PhysicalInterceptionProtection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalInterruptionProtection"></see>
    /// </summary>
    let PhysicalInterruptionProtection =
        Namespaced_IRI.parse _namespace_name "PhysicalInterruptionProtection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalNetworkSecurity"></see>
    /// </summary>
    let PhysicalNetworkSecurity =
        Namespaced_IRI.parse _namespace_name "PhysicalNetworkSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalSecureStorage"></see>
    /// </summary>
    let PhysicalSecureStorage =
        Namespaced_IRI.parse _namespace_name "PhysicalSecureStorage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalSupplySecurity"></see>
    /// </summary>
    let PhysicalSupplySecurity =
        Namespaced_IRI.parse _namespace_name "PhysicalSupplySecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PhysicalSurveillance"></see>
    /// </summary>
    let PhysicalSurveillance =
        Namespaced_IRI.parse _namespace_name "PhysicalSurveillance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PoliticalCampaign"></see>
    /// </summary>
    let PoliticalCampaign =
        Namespaced_IRI.parse _namespace_name "PoliticalCampaign" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PostQuantumCryptography"></see>
    /// </summary>
    let PostQuantumCryptography =
        Namespaced_IRI.parse _namespace_name "PostQuantumCryptography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PostedNotice"></see>
    /// </summary>
    let PostedNotice =
        Namespaced_IRI.parse _namespace_name "PostedNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrimaryImportance"></see>
    /// </summary>
    let PrimaryImportance =
        Namespaced_IRI.parse _namespace_name "PrimaryImportance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrimaryUse"></see>
    /// </summary>
    let PrimaryUse = Namespaced_IRI.parse _namespace_name "PrimaryUse" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Principle"></see>
    /// </summary>
    let Principle = Namespaced_IRI.parse _namespace_name "Principle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrintedNotice"></see>
    /// </summary>
    let PrintedNotice =
        Namespaced_IRI.parse _namespace_name "PrintedNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyByDefault"></see>
    /// </summary>
    let PrivacyByDefault =
        Namespaced_IRI.parse _namespace_name "PrivacyByDefault" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyByDesign"></see>
    /// </summary>
    let PrivacyByDesign =
        Namespaced_IRI.parse _namespace_name "PrivacyByDesign" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivacyPreservingProtocol"></see>
    /// </summary>
    let PrivacyPreservingProtocol =
        Namespaced_IRI.parse _namespace_name "PrivacyPreservingProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateCommunalSpace"></see>
    /// </summary>
    let PrivateCommunalSpace =
        Namespaced_IRI.parse _namespace_name "PrivateCommunalSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateInformationRetrieval"></see>
    /// </summary>
    let PrivateInformationRetrieval =
        Namespaced_IRI.parse _namespace_name "PrivateInformationRetrieval" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateLocation"></see>
    /// </summary>
    let PrivateLocation =
        Namespaced_IRI.parse _namespace_name "PrivateLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivateSectorBody"></see>
    /// </summary>
    let PrivateSectorBody =
        Namespaced_IRI.parse _namespace_name "PrivateSectorBody" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivatelyOperatedPublicSpace"></see>
    /// </summary>
    let PrivatelyOperatedPublicSpace =
        Namespaced_IRI.parse _namespace_name "PrivatelyOperatedPublicSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PubliclyAccessibleSpace"></see>
    /// </summary>
    let PubliclyAccessibleSpace =
        Namespaced_IRI.parse _namespace_name "PubliclyAccessibleSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivatelyOwnedPublicSpace"></see>
    /// </summary>
    let PrivatelyOwnedPublicSpace =
        Namespaced_IRI.parse _namespace_name "PrivatelyOwnedPublicSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PrivatelyOwnedSpace"></see>
    /// </summary>
    let PrivatelyOwnedSpace =
        Namespaced_IRI.parse _namespace_name "PrivatelyOwnedSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingCondition"></see>
    /// </summary>
    let ProcessingCondition =
        Namespaced_IRI.parse _namespace_name "ProcessingCondition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingDuration"></see>
    /// </summary>
    let ProcessingDuration =
        Namespaced_IRI.parse _namespace_name "ProcessingDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProcessingLocation"></see>
    /// </summary>
    let ProcessingLocation =
        Namespaced_IRI.parse _namespace_name "ProcessingLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProfessionalConfidentialData"></see>
    /// </summary>
    let ProfessionalConfidentialData =
        Namespaced_IRI.parse _namespace_name "ProfessionalConfidentialData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProfessionalTraining"></see>
    /// </summary>
    let ProfessionalTraining =
        Namespaced_IRI.parse _namespace_name "ProfessionalTraining" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Profiling"></see>
    /// </summary>
    let Profiling = Namespaced_IRI.parse _namespace_name "Profiling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Prohibition"></see>
    /// </summary>
    let Prohibition =
        Namespaced_IRI.parse _namespace_name "Prohibition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProhibitionUnviolated"></see>
    /// </summary>
    let ProhibitionUnviolated =
        Namespaced_IRI.parse _namespace_name "ProhibitionUnviolated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProhibitionViolated"></see>
    /// </summary>
    let ProhibitionViolated =
        Namespaced_IRI.parse _namespace_name "ProhibitionViolated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProtectionOfIPR"></see>
    /// </summary>
    let ProtectionOfIPR =
        Namespaced_IRI.parse _namespace_name "ProtectionOfIPR" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProtectionOfNationalSecurity"></see>
    /// </summary>
    let ProtectionOfNationalSecurity =
        Namespaced_IRI.parse _namespace_name "ProtectionOfNationalSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProtectionOfPublicSecurity"></see>
    /// </summary>
    let ProtectionOfPublicSecurity =
        Namespaced_IRI.parse _namespace_name "ProtectionOfPublicSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideEventRecommendations"></see>
    /// </summary>
    let ProvideEventRecommendations =
        Namespaced_IRI.parse _namespace_name "ProvideEventRecommendations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvidePersonalisedRecommendations"></see>
    /// </summary>
    let ProvidePersonalisedRecommendations =
        Namespaced_IRI.parse _namespace_name "ProvidePersonalisedRecommendations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideOfficialStatistics"></see>
    /// </summary>
    let ProvideOfficialStatistics =
        Namespaced_IRI.parse _namespace_name "ProvideOfficialStatistics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvideProductRecommendations"></see>
    /// </summary>
    let ProvideProductRecommendations =
        Namespaced_IRI.parse _namespace_name "ProvideProductRecommendations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvidedData"></see>
    /// </summary>
    let ProvidedData =
        Namespaced_IRI.parse _namespace_name "ProvidedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProvidedPersonalData"></see>
    /// </summary>
    let ProvidedPersonalData =
        Namespaced_IRI.parse _namespace_name "ProvidedPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ProviderStandardFormContract"></see>
    /// </summary>
    let ProviderStandardFormContract =
        Namespaced_IRI.parse _namespace_name "ProviderStandardFormContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Pseudonymise"></see>
    /// </summary>
    let Pseudonymise =
        Namespaced_IRI.parse _namespace_name "Pseudonymise" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicDataSource"></see>
    /// </summary>
    let PublicDataSource =
        Namespaced_IRI.parse _namespace_name "PublicDataSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterest"></see>
    /// </summary>
    let PublicInterest =
        Namespaced_IRI.parse _namespace_name "PublicInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestCompleted"></see>
    /// </summary>
    let PublicInterestCompleted =
        Namespaced_IRI.parse _namespace_name "PublicInterestCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestStatus"></see>
    /// </summary>
    let PublicInterestStatus =
        Namespaced_IRI.parse _namespace_name "PublicInterestStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestObjected"></see>
    /// </summary>
    let PublicInterestObjected =
        Namespaced_IRI.parse _namespace_name "PublicInterestObjected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestOngoing"></see>
    /// </summary>
    let PublicInterestOngoing =
        Namespaced_IRI.parse _namespace_name "PublicInterestOngoing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicInterestPending"></see>
    /// </summary>
    let PublicInterestPending =
        Namespaced_IRI.parse _namespace_name "PublicInterestPending" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicLocation"></see>
    /// </summary>
    let PublicLocation =
        Namespaced_IRI.parse _namespace_name "PublicLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicPolicyMaking"></see>
    /// </summary>
    let PublicPolicyMaking =
        Namespaced_IRI.parse _namespace_name "PublicPolicyMaking" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicRegisterOfEntities"></see>
    /// </summary>
    let PublicRegisterOfEntities =
        Namespaced_IRI.parse _namespace_name "PublicRegisterOfEntities" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicRelations"></see>
    /// </summary>
    let PublicRelations =
        Namespaced_IRI.parse _namespace_name "PublicRelations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PublicSectorBody"></see>
    /// </summary>
    let PublicSectorBody =
        Namespaced_IRI.parse _namespace_name "PublicSectorBody" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#PubliclyOwnedSpace"></see>
    /// </summary>
    let PubliclyOwnedSpace =
        Namespaced_IRI.parse _namespace_name "PubliclyOwnedSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#QuantumCryptography"></see>
    /// </summary>
    let QuantumCryptography =
        Namespaced_IRI.parse _namespace_name "QuantumCryptography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Query"></see>
    /// </summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RNGPseudonymisation"></see>
    /// </summary>
    let RNGPseudonymisation =
        Namespaced_IRI.parse _namespace_name "RNGPseudonymisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ROPA"></see>
    /// </summary>
    let ROPA = Namespaced_IRI.parse _namespace_name "ROPA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RandomLocation"></see>
    /// </summary>
    let RandomLocation =
        Namespaced_IRI.parse _namespace_name "RandomLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecertificationPolicy"></see>
    /// </summary>
    let RecertificationPolicy =
        Namespaced_IRI.parse _namespace_name "RecertificationPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecipientInformed"></see>
    /// </summary>
    let RecipientInformed =
        Namespaced_IRI.parse _namespace_name "RecipientInformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecipientUninformed"></see>
    /// </summary>
    let RecipientUninformed =
        Namespaced_IRI.parse _namespace_name "RecipientUninformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Recommendation"></see>
    /// </summary>
    let Recommendation =
        Namespaced_IRI.parse _namespace_name "Recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecommendationFollowed"></see>
    /// </summary>
    let RecommendationFollowed =
        Namespaced_IRI.parse _namespace_name "RecommendationFollowed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecommendationNotFollowed"></see>
    /// </summary>
    let RecommendationNotFollowed =
        Namespaced_IRI.parse _namespace_name "RecommendationNotFollowed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Record"></see>
    /// </summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecordManagement"></see>
    /// </summary>
    let RecordManagement =
        Namespaced_IRI.parse _namespace_name "RecordManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentAdvertising"></see>
    /// </summary>
    let RecruitmentAdvertising =
        Namespaced_IRI.parse _namespace_name "RecruitmentAdvertising" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantBackgroundCheck"></see>
    /// </summary>
    let RecruitmentApplicantBackgroundCheck =
        Namespaced_IRI.parse _namespace_name "RecruitmentApplicantBackgroundCheck" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentManagement"></see>
    /// </summary>
    let RecruitmentManagement =
        Namespaced_IRI.parse _namespace_name "RecruitmentManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantCriminalBackgroundCheck"></see>
    /// </summary>
    let RecruitmentApplicantCriminalBackgroundCheck =
        Namespaced_IRI.parse _namespace_name "RecruitmentApplicantCriminalBackgroundCheck" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantInformationAuthentication"></see>
    /// </summary>
    let RecruitmentApplicantInformationAuthentication =
        Namespaced_IRI.parse _namespace_name "RecruitmentApplicantInformationAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicantSelection"></see>
    /// </summary>
    let RecruitmentApplicantSelection =
        Namespaced_IRI.parse _namespace_name "RecruitmentApplicantSelection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicationAnalysis"></see>
    /// </summary>
    let RecruitmentApplicationAnalysis =
        Namespaced_IRI.parse _namespace_name "RecruitmentApplicationAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicationManagement"></see>
    /// </summary>
    let RecruitmentApplicationManagement =
        Namespaced_IRI.parse _namespace_name "RecruitmentApplicationManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentApplicationScreening"></see>
    /// </summary>
    let RecruitmentApplicationScreening =
        Namespaced_IRI.parse _namespace_name "RecruitmentApplicationScreening" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewAnalysis"></see>
    /// </summary>
    let RecruitmentInterviewAnalysis =
        Namespaced_IRI.parse _namespace_name "RecruitmentInterviewAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewManagement"></see>
    /// </summary>
    let RecruitmentInterviewManagement =
        Namespaced_IRI.parse _namespace_name "RecruitmentInterviewManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewAssessment"></see>
    /// </summary>
    let RecruitmentInterviewAssessment =
        Namespaced_IRI.parse _namespace_name "RecruitmentInterviewAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentInterviewScheduling"></see>
    /// </summary>
    let RecruitmentInterviewScheduling =
        Namespaced_IRI.parse _namespace_name "RecruitmentInterviewScheduling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RecruitmentTargetedAdvertising"></see>
    /// </summary>
    let RecruitmentTargetedAdvertising =
        Namespaced_IRI.parse _namespace_name "RecruitmentTargetedAdvertising" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TargetedAdvertising"></see>
    /// </summary>
    let TargetedAdvertising =
        Namespaced_IRI.parse _namespace_name "TargetedAdvertising" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Reformat"></see>
    /// </summary>
    let Reformat = Namespaced_IRI.parse _namespace_name "Reformat" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RefuseConsent"></see>
    /// </summary>
    let RefuseConsent =
        Namespaced_IRI.parse _namespace_name "RefuseConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RefuseContract"></see>
    /// </summary>
    let RefuseContract =
        Namespaced_IRI.parse _namespace_name "RefuseContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RegionalAuthority"></see>
    /// </summary>
    let RegionalAuthority =
        Namespaced_IRI.parse _namespace_name "RegionalAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RegionalScale"></see>
    /// </summary>
    let RegionalScale =
        Namespaced_IRI.parse _namespace_name "RegionalScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RegulatorySandbox"></see>
    /// </summary>
    let RegulatorySandbox =
        Namespaced_IRI.parse _namespace_name "RegulatorySandbox" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Safeguard"></see>
    /// </summary>
    let Safeguard = Namespaced_IRI.parse _namespace_name "Safeguard" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReligiousAssociations"></see>
    /// </summary>
    let ReligiousAssociations =
        Namespaced_IRI.parse _namespace_name "ReligiousAssociations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RenewedConsentGiven"></see>
    /// </summary>
    let RenewedConsentGiven =
        Namespaced_IRI.parse _namespace_name "RenewedConsentGiven" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RepairImpairments"></see>
    /// </summary>
    let RepairImpairments =
        Namespaced_IRI.parse _namespace_name "RepairImpairments" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestAccepted"></see>
    /// </summary>
    let RequestAccepted =
        Namespaced_IRI.parse _namespace_name "RequestAccepted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestStatus"></see>
    /// </summary>
    let RequestStatus =
        Namespaced_IRI.parse _namespace_name "RequestStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestAcknowledged"></see>
    /// </summary>
    let RequestAcknowledged =
        Namespaced_IRI.parse _namespace_name "RequestAcknowledged" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestActionDelayed"></see>
    /// </summary>
    let RequestActionDelayed =
        Namespaced_IRI.parse _namespace_name "RequestActionDelayed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestFulfilled"></see>
    /// </summary>
    let RequestFulfilled =
        Namespaced_IRI.parse _namespace_name "RequestFulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestInitiated"></see>
    /// </summary>
    let RequestInitiated =
        Namespaced_IRI.parse _namespace_name "RequestInitiated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestRejected"></see>
    /// </summary>
    let RequestRejected =
        Namespaced_IRI.parse _namespace_name "RequestRejected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestRequiredActionPerformed"></see>
    /// </summary>
    let RequestRequiredActionPerformed =
        Namespaced_IRI.parse _namespace_name "RequestRequiredActionPerformed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestRequiresAction"></see>
    /// </summary>
    let RequestRequiresAction =
        Namespaced_IRI.parse _namespace_name "RequestRequiresAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestStatusQuery"></see>
    /// </summary>
    let RequestStatusQuery =
        Namespaced_IRI.parse _namespace_name "RequestStatusQuery" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RequestUnfulfilled"></see>
    /// </summary>
    let RequestUnfulfilled =
        Namespaced_IRI.parse _namespace_name "RequestUnfulfilled" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Required"></see>
    /// </summary>
    let Required = Namespaced_IRI.parse _namespace_name "Required" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ResidualRisk"></see>
    /// </summary>
    let ResidualRisk =
        Namespaced_IRI.parse _namespace_name "ResidualRisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Risk"></see>
    /// </summary>
    let Risk = Namespaced_IRI.parse _namespace_name "Risk" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Restrict"></see>
    /// </summary>
    let Restrict = Namespaced_IRI.parse _namespace_name "Restrict" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Retrieve"></see>
    /// </summary>
    let Retrieve = Namespaced_IRI.parse _namespace_name "Retrieve" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReversingProcessEffects"></see>
    /// </summary>
    let ReversingProcessEffects =
        Namespaced_IRI.parse _namespace_name "ReversingProcessEffects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReversingProcessInput"></see>
    /// </summary>
    let ReversingProcessInput =
        Namespaced_IRI.parse _namespace_name "ReversingProcessInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReversingProcessOutput"></see>
    /// </summary>
    let ReversingProcessOutput =
        Namespaced_IRI.parse _namespace_name "ReversingProcessOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReviewImpactAssessment"></see>
    /// </summary>
    let ReviewImpactAssessment =
        Namespaced_IRI.parse _namespace_name "ReviewImpactAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ReviewProcedure"></see>
    /// </summary>
    let ReviewProcedure =
        Namespaced_IRI.parse _namespace_name "ReviewProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightExerciseNotice"></see>
    /// </summary>
    let RightExerciseNotice =
        Namespaced_IRI.parse _namespace_name "RightExerciseNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightNotice"></see>
    /// </summary>
    let RightNotice =
        Namespaced_IRI.parse _namespace_name "RightNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightFulfilmentNotice"></see>
    /// </summary>
    let RightFulfilmentNotice =
        Namespaced_IRI.parse _namespace_name "RightFulfilmentNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightNonFulfilmentNotice"></see>
    /// </summary>
    let RightNonFulfilmentNotice =
        Namespaced_IRI.parse _namespace_name "RightNonFulfilmentNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RightsFulfilment"></see>
    /// </summary>
    let RightsFulfilment =
        Namespaced_IRI.parse _namespace_name "RightsFulfilment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskLevel"></see>
    /// </summary>
    let RiskLevel = Namespaced_IRI.parse _namespace_name "RiskLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#RiskMitigationMeasure"></see>
    /// </summary>
    let RiskMitigationMeasure =
        Namespaced_IRI.parse _namespace_name "RiskMitigationMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SMEOrganisation"></see>
    /// </summary>
    let SMEOrganisation =
        Namespaced_IRI.parse _namespace_name "SMEOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SafeguardForDataTransfer"></see>
    /// </summary>
    let SafeguardForDataTransfer =
        Namespaced_IRI.parse _namespace_name "SafeguardForDataTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ScientificResearch"></see>
    /// </summary>
    let ScientificResearch =
        Namespaced_IRI.parse _namespace_name "ScientificResearch" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Scope"></see>
    /// </summary>
    let Scope = Namespaced_IRI.parse _namespace_name "Scope" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Screen"></see>
    /// </summary>
    let Screen = Namespaced_IRI.parse _namespace_name "Screen" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Seal"></see>
    /// </summary>
    let Seal = Namespaced_IRI.parse _namespace_name "Seal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SearchFunctionalities"></see>
    /// </summary>
    let SearchFunctionalities =
        Namespaced_IRI.parse _namespace_name "SearchFunctionalities" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecondaryImportance"></see>
    /// </summary>
    let SecondaryImportance =
        Namespaced_IRI.parse _namespace_name "SecondaryImportance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecondaryUse"></see>
    /// </summary>
    let SecondaryUse =
        Namespaced_IRI.parse _namespace_name "SecondaryUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecretSharingSchemes"></see>
    /// </summary>
    let SecretSharingSchemes =
        Namespaced_IRI.parse _namespace_name "SecretSharingSchemes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Sector"></see>
    /// </summary>
    let Sector = Namespaced_IRI.parse _namespace_name "Sector" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecureMultiPartyComputation"></see>
    /// </summary>
    let SecureMultiPartyComputation =
        Namespaced_IRI.parse _namespace_name "SecureMultiPartyComputation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecureProcessingEnvironment"></see>
    /// </summary>
    let SecureProcessingEnvironment =
        Namespaced_IRI.parse _namespace_name "SecureProcessingEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityAudit"></see>
    /// </summary>
    let SecurityAudit =
        Namespaced_IRI.parse _namespace_name "SecurityAudit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityIncidentRecord"></see>
    /// </summary>
    let SecurityIncidentRecord =
        Namespaced_IRI.parse _namespace_name "SecurityIncidentRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityKnowledgeTraining"></see>
    /// </summary>
    let SecurityKnowledgeTraining =
        Namespaced_IRI.parse _namespace_name "SecurityKnowledgeTraining" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SecurityRoleProcedures"></see>
    /// </summary>
    let SecurityRoleProcedures =
        Namespaced_IRI.parse _namespace_name "SecurityRoleProcedures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellDataToThirdParties"></see>
    /// </summary>
    let SellDataToThirdParties =
        Namespaced_IRI.parse _namespace_name "SellDataToThirdParties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellProducts"></see>
    /// </summary>
    let SellProducts =
        Namespaced_IRI.parse _namespace_name "SellProducts" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellInsightsFromData"></see>
    /// </summary>
    let SellInsightsFromData =
        Namespaced_IRI.parse _namespace_name "SellInsightsFromData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SellProductsToDataSubject"></see>
    /// </summary>
    let SellProductsToDataSubject =
        Namespaced_IRI.parse _namespace_name "SellProductsToDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SemiPrivateSpace"></see>
    /// </summary>
    let SemiPrivateSpace =
        Namespaced_IRI.parse _namespace_name "SemiPrivateSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitiveData"></see>
    /// </summary>
    let SensitiveData =
        Namespaced_IRI.parse _namespace_name "SensitiveData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitiveNonPersonalData"></see>
    /// </summary>
    let SensitiveNonPersonalData =
        Namespaced_IRI.parse _namespace_name "SensitiveNonPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitivePersonalData"></see>
    /// </summary>
    let SensitivePersonalData =
        Namespaced_IRI.parse _namespace_name "SensitivePersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SensitivityLevel"></see>
    /// </summary>
    let SensitivityLevel =
        Namespaced_IRI.parse _namespace_name "SensitivityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Severity"></see>
    /// </summary>
    let Severity = Namespaced_IRI.parse _namespace_name "Severity" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceConsumer"></see>
    /// </summary>
    let ServiceConsumer =
        Namespaced_IRI.parse _namespace_name "ServiceConsumer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceLevelAgreement"></see>
    /// </summary>
    let ServiceLevelAgreement =
        Namespaced_IRI.parse _namespace_name "ServiceLevelAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceProvider"></see>
    /// </summary>
    let ServiceProvider =
        Namespaced_IRI.parse _namespace_name "ServiceProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceRegistration"></see>
    /// </summary>
    let ServiceRegistration =
        Namespaced_IRI.parse _namespace_name "ServiceRegistration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ServiceUsageAnalytics"></see>
    /// </summary>
    let ServiceUsageAnalytics =
        Namespaced_IRI.parse _namespace_name "ServiceUsageAnalytics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Share"></see>
    /// </summary>
    let Share = Namespaced_IRI.parse _namespace_name "Share" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingleSignOn"></see>
    /// </summary>
    let SingleSignOn =
        Namespaced_IRI.parse _namespace_name "SingleSignOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingularDataVolume"></see>
    /// </summary>
    let SingularDataVolume =
        Namespaced_IRI.parse _namespace_name "SingularDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingularFrequency"></see>
    /// </summary>
    let SingularFrequency =
        Namespaced_IRI.parse _namespace_name "SingularFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SingularScaleOfDataSubjects"></see>
    /// </summary>
    let SingularScaleOfDataSubjects =
        Namespaced_IRI.parse _namespace_name "SingularScaleOfDataSubjects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SmallDataVolume"></see>
    /// </summary>
    let SmallDataVolume =
        Namespaced_IRI.parse _namespace_name "SmallDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SmallScaleOfDataSubjects"></see>
    /// </summary>
    let SmallScaleOfDataSubjects =
        Namespaced_IRI.parse _namespace_name "SmallScaleOfDataSubjects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SmallScaleProcessing"></see>
    /// </summary>
    let SmallScaleProcessing =
        Namespaced_IRI.parse _namespace_name "SmallScaleProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SocialMediaMarketing"></see>
    /// </summary>
    let SocialMediaMarketing =
        Namespaced_IRI.parse _namespace_name "SocialMediaMarketing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SpecialCategoryPersonalData"></see>
    /// </summary>
    let SpecialCategoryPersonalData =
        Namespaced_IRI.parse _namespace_name "SpecialCategoryPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SporadicDataVolume"></see>
    /// </summary>
    let SporadicDataVolume =
        Namespaced_IRI.parse _namespace_name "SporadicDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SporadicFrequency"></see>
    /// </summary>
    let SporadicFrequency =
        Namespaced_IRI.parse _namespace_name "SporadicFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SporadicScaleOfDataSubjects"></see>
    /// </summary>
    let SporadicScaleOfDataSubjects =
        Namespaced_IRI.parse _namespace_name "SporadicScaleOfDataSubjects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StandardsConformance"></see>
    /// </summary>
    let StandardsConformance =
        Namespaced_IRI.parse _namespace_name "StandardsConformance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StartupOrganisation"></see>
    /// </summary>
    let StartupOrganisation =
        Namespaced_IRI.parse _namespace_name "StartupOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StatisticalConfidentialityAgreement"></see>
    /// </summary>
    let StatisticalConfidentialityAgreement =
        Namespaced_IRI.parse _namespace_name "StatisticalConfidentialityAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StatisticallyConfidentialData"></see>
    /// </summary>
    let StatisticallyConfidentialData =
        Namespaced_IRI.parse _namespace_name "StatisticallyConfidentialData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageCondition"></see>
    /// </summary>
    let StorageCondition =
        Namespaced_IRI.parse _namespace_name "StorageCondition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageDeletion"></see>
    /// </summary>
    let StorageDeletion =
        Namespaced_IRI.parse _namespace_name "StorageDeletion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageDuration"></see>
    /// </summary>
    let StorageDuration =
        Namespaced_IRI.parse _namespace_name "StorageDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageLocation"></see>
    /// </summary>
    let StorageLocation =
        Namespaced_IRI.parse _namespace_name "StorageLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#StorageRestoration"></see>
    /// </summary>
    let StorageRestoration =
        Namespaced_IRI.parse _namespace_name "StorageRestoration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Store"></see>
    /// </summary>
    let Store = Namespaced_IRI.parse _namespace_name "Store" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Student"></see>
    /// </summary>
    let Student = Namespaced_IRI.parse _namespace_name "Student" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SubProcessorAgreement"></see>
    /// </summary>
    let SubProcessorAgreement =
        Namespaced_IRI.parse _namespace_name "SubProcessorAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Subscriber"></see>
    /// </summary>
    let Subscriber = Namespaced_IRI.parse _namespace_name "Subscriber" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SubsidiaryLegalEntity"></see>
    /// </summary>
    let SubsidiaryLegalEntity =
        Namespaced_IRI.parse _namespace_name "SubsidiaryLegalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportContractNegotiation"></see>
    /// </summary>
    let SupportContractNegotiation =
        Namespaced_IRI.parse _namespace_name "SupportContractNegotiation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportEntityDecisionMaking"></see>
    /// </summary>
    let SupportEntityDecisionMaking =
        Namespaced_IRI.parse _namespace_name "SupportEntityDecisionMaking" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportExchangeOfViews"></see>
    /// </summary>
    let SupportExchangeOfViews =
        Namespaced_IRI.parse _namespace_name "SupportExchangeOfViews" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupportInformedConsentDecision"></see>
    /// </summary>
    let SupportInformedConsentDecision =
        Namespaced_IRI.parse _namespace_name "SupportInformedConsentDecision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupraNationalAuthority"></see>
    /// </summary>
    let SupraNationalAuthority =
        Namespaced_IRI.parse _namespace_name "SupraNationalAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SupraNationalUnion"></see>
    /// </summary>
    let SupraNationalUnion =
        Namespaced_IRI.parse _namespace_name "SupraNationalUnion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SymmetricCryptography"></see>
    /// </summary>
    let SymmetricCryptography =
        Namespaced_IRI.parse _namespace_name "SymmetricCryptography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SymmetricEncryption"></see>
    /// </summary>
    let SymmetricEncryption =
        Namespaced_IRI.parse _namespace_name "SymmetricEncryption" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SyntheticData"></see>
    /// </summary>
    let SyntheticData =
        Namespaced_IRI.parse _namespace_name "SyntheticData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#SystematicMonitoring"></see>
    /// </summary>
    let SystematicMonitoring =
        Namespaced_IRI.parse _namespace_name "SystematicMonitoring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TOM-properties"></see>
    /// </summary>
    let ``TOM-properties`` =
        Namespaced_IRI.parse _namespace_name "TOM-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalServiceProvision"></see>
    /// </summary>
    let TechnicalServiceProvision =
        Namespaced_IRI.parse _namespace_name "TechnicalServiceProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TechnicalStandard"></see>
    /// </summary>
    let TechnicalStandard =
        Namespaced_IRI.parse _namespace_name "TechnicalStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Technology"></see>
    /// </summary>
    let Technology = Namespaced_IRI.parse _namespace_name "Technology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TemporalDuration"></see>
    /// </summary>
    let TemporalDuration =
        Namespaced_IRI.parse _namespace_name "TemporalDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TerminateContract"></see>
    /// </summary>
    let TerminateContract =
        Namespaced_IRI.parse _namespace_name "TerminateContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TermsOfService"></see>
    /// </summary>
    let TermsOfService =
        Namespaced_IRI.parse _namespace_name "TermsOfService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdCountry"></see>
    /// </summary>
    let ThirdCountry =
        Namespaced_IRI.parse _namespace_name "ThirdCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdParty"></see>
    /// </summary>
    let ThirdParty = Namespaced_IRI.parse _namespace_name "ThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartyAgreement"></see>
    /// </summary>
    let ThirdPartyAgreement =
        Namespaced_IRI.parse _namespace_name "ThirdPartyAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartyContract"></see>
    /// </summary>
    let ThirdPartyContract =
        Namespaced_IRI.parse _namespace_name "ThirdPartyContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartyDataSource"></see>
    /// </summary>
    let ThirdPartyDataSource =
        Namespaced_IRI.parse _namespace_name "ThirdPartyDataSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ThirdPartySecurityProcedures"></see>
    /// </summary>
    let ThirdPartySecurityProcedures =
        Namespaced_IRI.parse _namespace_name "ThirdPartySecurityProcedures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Tourist"></see>
    /// </summary>
    let Tourist = Namespaced_IRI.parse _namespace_name "Tourist" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#Tracking"></see>
    /// </summary>
    let Tracking = Namespaced_IRI.parse _namespace_name "Tracking" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrackingByFirstParty"></see>
    /// </summary>
    let TrackingByFirstParty =
        Namespaced_IRI.parse _namespace_name "TrackingByFirstParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrackingByThirdParty"></see>
    /// </summary>
    let TrackingByThirdParty =
        Namespaced_IRI.parse _namespace_name "TrackingByThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Transmit"></see>
    /// </summary>
    let Transmit = Namespaced_IRI.parse _namespace_name "Transmit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrustedComputing"></see>
    /// </summary>
    let TrustedComputing =
        Namespaced_IRI.parse _namespace_name "TrustedComputing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#TrustedExecutionEnvironment"></see>
    /// </summary>
    let TrustedExecutionEnvironment =
        Namespaced_IRI.parse _namespace_name "TrustedExecutionEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UncategorisedData"></see>
    /// </summary>
    let UncategorisedData =
        Namespaced_IRI.parse _namespace_name "UncategorisedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Unexpected"></see>
    /// </summary>
    let Unexpected = Namespaced_IRI.parse _namespace_name "Unexpected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UninformedConsent"></see>
    /// </summary>
    let UninformedConsent =
        Namespaced_IRI.parse _namespace_name "UninformedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnknownApplicability"></see>
    /// </summary>
    let UnknownApplicability =
        Namespaced_IRI.parse _namespace_name "UnknownApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Unlawful"></see>
    /// </summary>
    let Unlawful = Namespaced_IRI.parse _namespace_name "Unlawful" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnstructuredData"></see>
    /// </summary>
    let UnstructuredData =
        Namespaced_IRI.parse _namespace_name "UnstructuredData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UntilEventDuration"></see>
    /// </summary>
    let UntilEventDuration =
        Namespaced_IRI.parse _namespace_name "UntilEventDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UntilTimeDuration"></see>
    /// </summary>
    let UntilTimeDuration =
        Namespaced_IRI.parse _namespace_name "UntilTimeDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UnverifiedData"></see>
    /// </summary>
    let UnverifiedData =
        Namespaced_IRI.parse _namespace_name "UnverifiedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UsageControl"></see>
    /// </summary>
    let UsageControl =
        Namespaced_IRI.parse _namespace_name "UsageControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UseSyntheticData"></see>
    /// </summary>
    let UseSyntheticData =
        Namespaced_IRI.parse _namespace_name "UseSyntheticData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#User"></see>
    /// </summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#UserInterfacePersonalisation"></see>
    /// </summary>
    let UserInterfacePersonalisation =
        Namespaced_IRI.parse _namespace_name "UserInterfacePersonalisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VariableLocation"></see>
    /// </summary>
    let VariableLocation =
        Namespaced_IRI.parse _namespace_name "VariableLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorManagement"></see>
    /// </summary>
    let VendorManagement =
        Namespaced_IRI.parse _namespace_name "VendorManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorPayment"></see>
    /// </summary>
    let VendorPayment =
        Namespaced_IRI.parse _namespace_name "VendorPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorRecordsManagement"></see>
    /// </summary>
    let VendorRecordsManagement =
        Namespaced_IRI.parse _namespace_name "VendorRecordsManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VendorSelectionAssessment"></see>
    /// </summary>
    let VendorSelectionAssessment =
        Namespaced_IRI.parse _namespace_name "VendorSelectionAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VerifiedData"></see>
    /// </summary>
    let VerifiedData =
        Namespaced_IRI.parse _namespace_name "VerifiedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VirtualisationSecurity"></see>
    /// </summary>
    let VirtualisationSecurity =
        Namespaced_IRI.parse _namespace_name "VirtualisationSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#Visitor"></see>
    /// </summary>
    let Visitor = Namespaced_IRI.parse _namespace_name "Visitor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterest"></see>
    /// </summary>
    let VitalInterest =
        Namespaced_IRI.parse _namespace_name "VitalInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestCompleted"></see>
    /// </summary>
    let VitalInterestCompleted =
        Namespaced_IRI.parse _namespace_name "VitalInterestCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestStatus"></see>
    /// </summary>
    let VitalInterestStatus =
        Namespaced_IRI.parse _namespace_name "VitalInterestStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestObjected"></see>
    /// </summary>
    let VitalInterestObjected =
        Namespaced_IRI.parse _namespace_name "VitalInterestObjected" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestOfDataSubject"></see>
    /// </summary>
    let VitalInterestOfDataSubject =
        Namespaced_IRI.parse _namespace_name "VitalInterestOfDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestOfNaturalPerson"></see>
    /// </summary>
    let VitalInterestOfNaturalPerson =
        Namespaced_IRI.parse _namespace_name "VitalInterestOfNaturalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestOngoing"></see>
    /// </summary>
    let VitalInterestOngoing =
        Namespaced_IRI.parse _namespace_name "VitalInterestOngoing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VitalInterestPending"></see>
    /// </summary>
    let VitalInterestPending =
        Namespaced_IRI.parse _namespace_name "VitalInterestPending" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#VulnerabilityTestingMethods"></see>
    /// </summary>
    let VulnerabilityTestingMethods =
        Namespaced_IRI.parse _namespace_name "VulnerabilityTestingMethods" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WebBrowserSecurity"></see>
    /// </summary>
    let WebBrowserSecurity =
        Namespaced_IRI.parse _namespace_name "WebBrowserSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WebSecurityProtocols"></see>
    /// </summary>
    let WebSecurityProtocols =
        Namespaced_IRI.parse _namespace_name "WebSecurityProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WirelessSecurityProtocols"></see>
    /// </summary>
    let WirelessSecurityProtocols =
        Namespaced_IRI.parse _namespace_name "WirelessSecurityProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithdrawingFromProcess"></see>
    /// </summary>
    let WithdrawingFromProcess =
        Namespaced_IRI.parse _namespace_name "WithdrawingFromProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithinDevice"></see>
    /// </summary>
    let WithinDevice =
        Namespaced_IRI.parse _namespace_name "WithinDevice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithinPhysicalEnvironment"></see>
    /// </summary>
    let WithinPhysicalEnvironment =
        Namespaced_IRI.parse _namespace_name "WithinPhysicalEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#WithinVirtualEnvironment"></see>
    /// </summary>
    let WithinVirtualEnvironment =
        Namespaced_IRI.parse _namespace_name "WithinVirtualEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#ZeroKnowledgeAuthentication"></see>
    /// </summary>
    let ZeroKnowledgeAuthentication =
        Namespaced_IRI.parse _namespace_name "ZeroKnowledgeAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#consent-properties"></see>
    /// </summary>
    let ``consent-properties`` =
        Namespaced_IRI.parse _namespace_name "consent-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#context-properties"></see>
    /// </summary>
    let ``context-properties`` =
        Namespaced_IRI.parse _namespace_name "context-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#contract-properties"></see>
    /// </summary>
    let ``contract-properties`` =
        Namespaced_IRI.parse _namespace_name "contract-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-authority-properties"></see>
    /// </summary>
    let ``entities-authority-properties`` =
        Namespaced_IRI.parse _namespace_name "entities-authority-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-datasubject-properties"></see>
    /// </summary>
    let ``entities-datasubject-properties`` =
        Namespaced_IRI.parse _namespace_name "entities-datasubject-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-legalrole-properties"></see>
    /// </summary>
    let ``entities-legalrole-properties`` =
        Namespaced_IRI.parse _namespace_name "entities-legalrole-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#entities-properties"></see>
    /// </summary>
    let ``entities-properties`` =
        Namespaced_IRI.parse _namespace_name "entities-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasActiveEntity"></see>
    /// </summary>
    let hasActiveEntity =
        Namespaced_IRI.parse _namespace_name "hasActiveEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasEntity"></see>
    /// </summary>
    let hasEntity = Namespaced_IRI.parse _namespace_name "hasEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-context-properties"></see>
    /// </summary>
    let ``processing-context-properties`` =
        Namespaced_IRI.parse _namespace_name "processing-context-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasActivityStatus"></see>
    /// </summary>
    let hasActivityStatus =
        Namespaced_IRI.parse _namespace_name "hasActivityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasStatus"></see>
    /// </summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#status-properties"></see>
    /// </summary>
    let ``status-properties`` =
        Namespaced_IRI.parse _namespace_name "status-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAddress"></see>
    /// </summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAlgorithmicLogic"></see>
    /// </summary>
    let hasAlgorithmicLogic =
        Namespaced_IRI.parse _namespace_name "hasAlgorithmicLogic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasApplicability"></see>
    /// </summary>
    let hasApplicability =
        Namespaced_IRI.parse _namespace_name "hasApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasApplicableLaw"></see>
    /// </summary>
    let hasApplicableLaw =
        Namespaced_IRI.parse _namespace_name "hasApplicableLaw" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#jurisdiction-properties"></see>
    /// </summary>
    let ``jurisdiction-properties`` =
        Namespaced_IRI.parse _namespace_name "jurisdiction-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAssessment"></see>
    /// </summary>
    let hasAssessment =
        Namespaced_IRI.parse _namespace_name "hasAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasOrganisationalMeasure"></see>
    /// </summary>
    let hasOrganisationalMeasure =
        Namespaced_IRI.parse _namespace_name "hasOrganisationalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAuditStatus"></see>
    /// </summary>
    let hasAuditStatus =
        Namespaced_IRI.parse _namespace_name "hasAuditStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAuthority"></see>
    /// </summary>
    let hasAuthority =
        Namespaced_IRI.parse _namespace_name "hasAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasAutomationLevel"></see>
    /// </summary>
    let hasAutomationLevel =
        Namespaced_IRI.parse _namespace_name "hasAutomationLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasComplianceStatus"></see>
    /// </summary>
    let hasComplianceStatus =
        Namespaced_IRI.parse _namespace_name "hasComplianceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConformanceStatus"></see>
    /// </summary>
    let hasConformanceStatus =
        Namespaced_IRI.parse _namespace_name "hasConformanceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsentControl"></see>
    /// </summary>
    let hasConsentControl =
        Namespaced_IRI.parse _namespace_name "hasConsentControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsentStatus"></see>
    /// </summary>
    let hasConsentStatus =
        Namespaced_IRI.parse _namespace_name "hasConsentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsequence"></see>
    /// </summary>
    let hasConsequence =
        Namespaced_IRI.parse _namespace_name "hasConsequence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#risk-properties"></see>
    /// </summary>
    let ``risk-properties`` =
        Namespaced_IRI.parse _namespace_name "risk-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasConsequenceOn"></see>
    /// </summary>
    let hasConsequenceOn =
        Namespaced_IRI.parse _namespace_name "hasConsequenceOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContact"></see>
    /// </summary>
    let hasContact = Namespaced_IRI.parse _namespace_name "hasContact" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContext"></see>
    /// </summary>
    let hasContext = Namespaced_IRI.parse _namespace_name "hasContext" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractControl"></see>
    /// </summary>
    let hasContractControl =
        Namespaced_IRI.parse _namespace_name "hasContractControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractStatus"></see>
    /// </summary>
    let hasContractStatus =
        Namespaced_IRI.parse _namespace_name "hasContractStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractualClause"></see>
    /// </summary>
    let hasContractualClause =
        Namespaced_IRI.parse _namespace_name "hasContractualClause" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasContractualFulfilmentStatus"></see>
    /// </summary>
    let hasContractualFulfilmentStatus =
        Namespaced_IRI.parse _namespace_name "hasContractualFulfilmentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasCountry"></see>
    /// </summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLocation"></see>
    /// </summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasData"></see>
    /// </summary>
    let hasData = Namespaced_IRI.parse _namespace_name "hasData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#personal-data-properties"></see>
    /// </summary>
    let ``personal-data-properties`` =
        Namespaced_IRI.parse _namespace_name "personal-data-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataController"></see>
    /// </summary>
    let hasDataController =
        Namespaced_IRI.parse _namespace_name "hasDataController" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataExporter"></see>
    /// </summary>
    let hasDataExporter =
        Namespaced_IRI.parse _namespace_name "hasDataExporter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataImporter"></see>
    /// </summary>
    let hasDataImporter =
        Namespaced_IRI.parse _namespace_name "hasDataImporter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecipient"></see>
    /// </summary>
    let hasRecipient =
        Namespaced_IRI.parse _namespace_name "hasRecipient" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataProcessor"></see>
    /// </summary>
    let hasDataProcessor =
        Namespaced_IRI.parse _namespace_name "hasDataProcessor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataProtectionOfficer"></see>
    /// </summary>
    let hasDataProtectionOfficer =
        Namespaced_IRI.parse _namespace_name "hasDataProtectionOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRepresentative"></see>
    /// </summary>
    let hasRepresentative =
        Namespaced_IRI.parse _namespace_name "hasRepresentative" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataSource"></see>
    /// </summary>
    let hasDataSource =
        Namespaced_IRI.parse _namespace_name "hasDataSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataSubject"></see>
    /// </summary>
    let hasDataSubject =
        Namespaced_IRI.parse _namespace_name "hasDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasHumanSubject"></see>
    /// </summary>
    let hasHumanSubject =
        Namespaced_IRI.parse _namespace_name "hasHumanSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataSubjectScale"></see>
    /// </summary>
    let hasDataSubjectScale =
        Namespaced_IRI.parse _namespace_name "hasDataSubjectScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasScale"></see>
    /// </summary>
    let hasScale = Namespaced_IRI.parse _namespace_name "hasScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-scale-properties"></see>
    /// </summary>
    let ``processing-scale-properties`` =
        Namespaced_IRI.parse _namespace_name "processing-scale-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDataVolume"></see>
    /// </summary>
    let hasDataVolume =
        Namespaced_IRI.parse _namespace_name "hasDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDeterrence"></see>
    /// </summary>
    let hasDeterrence =
        Namespaced_IRI.parse _namespace_name "hasDeterrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRule"></see>
    /// </summary>
    let hasRule = Namespaced_IRI.parse _namespace_name "hasRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#rules-properties"></see>
    /// </summary>
    let ``rules-properties`` =
        Namespaced_IRI.parse _namespace_name "rules-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasDuration"></see>
    /// </summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasEntityControl"></see>
    /// </summary>
    let hasEntityControl =
        Namespaced_IRI.parse _namespace_name "hasEntityControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#EntityControl"></see>
    /// </summary>
    let EntityControl =
        Namespaced_IRI.parse _namespace_name "EntityControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasTechnicalOrganisationalMeasure"></see>
    /// </summary>
    let hasTechnicalOrganisationalMeasure =
        Namespaced_IRI.parse _namespace_name "hasTechnicalOrganisationalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasEntityInvolvement"></see>
    /// </summary>
    let hasEntityInvolvement =
        Namespaced_IRI.parse _namespace_name "hasEntityInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasExpectation"></see>
    /// </summary>
    let hasExpectation =
        Namespaced_IRI.parse _namespace_name "hasExpectation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasFee"></see>
    /// </summary>
    let hasFee = Namespaced_IRI.parse _namespace_name "hasFee" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasFrequency"></see>
    /// </summary>
    let hasFrequency =
        Namespaced_IRI.parse _namespace_name "hasFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasFulfilmentStatus"></see>
    /// </summary>
    let hasFulfilmentStatus =
        Namespaced_IRI.parse _namespace_name "hasFulfilmentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasGeographicCoverage"></see>
    /// </summary>
    let hasGeographicCoverage =
        Namespaced_IRI.parse _namespace_name "hasGeographicCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasHumanInvolvement"></see>
    /// </summary>
    let hasHumanInvolvement =
        Namespaced_IRI.parse _namespace_name "hasHumanInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasIdentifier"></see>
    /// </summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImpact"></see>
    /// </summary>
    let hasImpact = Namespaced_IRI.parse _namespace_name "hasImpact" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImpactAssessment"></see>
    /// </summary>
    let hasImpactAssessment =
        Namespaced_IRI.parse _namespace_name "hasImpactAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImpactOn"></see>
    /// </summary>
    let hasImpactOn =
        Namespaced_IRI.parse _namespace_name "hasImpactOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasImportance"></see>
    /// </summary>
    let hasImportance =
        Namespaced_IRI.parse _namespace_name "hasImportance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasIndicationMethod"></see>
    /// </summary>
    let hasIndicationMethod =
        Namespaced_IRI.parse _namespace_name "hasIndicationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#legal-basis-properties"></see>
    /// </summary>
    let ``legal-basis-properties`` =
        Namespaced_IRI.parse _namespace_name "legal-basis-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasInformedStatus"></see>
    /// </summary>
    let hasInformedStatus =
        Namespaced_IRI.parse _namespace_name "hasInformedStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasIntention"></see>
    /// </summary>
    let hasIntention =
        Namespaced_IRI.parse _namespace_name "hasIntention" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasInverseJurisdiction"></see>
    /// </summary>
    let hasInverseJurisdiction =
        Namespaced_IRI.parse _namespace_name "hasInverseJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasInvolvement"></see>
    /// </summary>
    let hasInvolvement =
        Namespaced_IRI.parse _namespace_name "hasInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasJointDataControllers"></see>
    /// </summary>
    let hasJointDataControllers =
        Namespaced_IRI.parse _namespace_name "hasJointDataControllers" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasJurisdiction"></see>
    /// </summary>
    let hasJurisdiction =
        Namespaced_IRI.parse _namespace_name "hasJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasJustification"></see>
    /// </summary>
    let hasJustification =
        Namespaced_IRI.parse _namespace_name "hasJustification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLawfulness"></see>
    /// </summary>
    let hasLawfulness =
        Namespaced_IRI.parse _namespace_name "hasLawfulness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLegalBasis"></see>
    /// </summary>
    let hasLegalBasis =
        Namespaced_IRI.parse _namespace_name "hasLegalBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLegalMeasure"></see>
    /// </summary>
    let hasLegalMeasure =
        Namespaced_IRI.parse _namespace_name "hasLegalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasLikelihood"></see>
    /// </summary>
    let hasLikelihood =
        Namespaced_IRI.parse _namespace_name "hasLikelihood" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNecessity"></see>
    /// </summary>
    let hasNecessity =
        Namespaced_IRI.parse _namespace_name "hasNecessity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNonInvolvedEntity"></see>
    /// </summary>
    let hasNonInvolvedEntity =
        Namespaced_IRI.parse _namespace_name "hasNonInvolvedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNonPersonalDataProcess"></see>
    /// </summary>
    let hasNonPersonalDataProcess =
        Namespaced_IRI.parse _namespace_name "hasNonPersonalDataProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#process-properties"></see>
    /// </summary>
    let ``process-properties`` =
        Namespaced_IRI.parse _namespace_name "process-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNotice"></see>
    /// </summary>
    let hasNotice = Namespaced_IRI.parse _namespace_name "hasNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#notice-properties"></see>
    /// </summary>
    let ``notice-properties`` =
        Namespaced_IRI.parse _namespace_name "notice-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNoticeIcon"></see>
    /// </summary>
    let hasNoticeIcon =
        Namespaced_IRI.parse _namespace_name "hasNoticeIcon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNoticeLayer"></see>
    /// </summary>
    let hasNoticeLayer =
        Namespaced_IRI.parse _namespace_name "hasNoticeLayer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNoticeStatus"></see>
    /// </summary>
    let hasNoticeStatus =
        Namespaced_IRI.parse _namespace_name "hasNoticeStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasNotificationStatus"></see>
    /// </summary>
    let hasNotificationStatus =
        Namespaced_IRI.parse _namespace_name "hasNotificationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasObligation"></see>
    /// </summary>
    let hasObligation =
        Namespaced_IRI.parse _namespace_name "hasObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasOrganisationalUnit"></see>
    /// </summary>
    let hasOrganisationalUnit =
        Namespaced_IRI.parse _namespace_name "hasOrganisationalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasOutcome"></see>
    /// </summary>
    let hasOutcome = Namespaced_IRI.parse _namespace_name "hasOutcome" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasParty"></see>
    /// </summary>
    let hasParty = Namespaced_IRI.parse _namespace_name "hasParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPassiveEntity"></see>
    /// </summary>
    let hasPassiveEntity =
        Namespaced_IRI.parse _namespace_name "hasPassiveEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPermission"></see>
    /// </summary>
    let hasPermission =
        Namespaced_IRI.parse _namespace_name "hasPermission" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPersonalData"></see>
    /// </summary>
    let hasPersonalData =
        Namespaced_IRI.parse _namespace_name "hasPersonalData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPersonalDataHandling"></see>
    /// </summary>
    let hasPersonalDataHandling =
        Namespaced_IRI.parse _namespace_name "hasPersonalDataHandling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPersonalDataProcess"></see>
    /// </summary>
    let hasPersonalDataProcess =
        Namespaced_IRI.parse _namespace_name "hasPersonalDataProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPhysicalMeasure"></see>
    /// </summary>
    let hasPhysicalMeasure =
        Namespaced_IRI.parse _namespace_name "hasPhysicalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPolicy"></see>
    /// </summary>
    let hasPolicy = Namespaced_IRI.parse _namespace_name "hasPolicy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcess"></see>
    /// </summary>
    let hasProcess = Namespaced_IRI.parse _namespace_name "hasProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcessing"></see>
    /// </summary>
    let hasProcessing =
        Namespaced_IRI.parse _namespace_name "hasProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#processing-properties"></see>
    /// </summary>
    let ``processing-properties`` =
        Namespaced_IRI.parse _namespace_name "processing-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcessingCondition"></see>
    /// </summary>
    let hasProcessingCondition =
        Namespaced_IRI.parse _namespace_name "hasProcessingCondition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProcessingScale"></see>
    /// </summary>
    let hasProcessingScale =
        Namespaced_IRI.parse _namespace_name "hasProcessingScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasProhibition"></see>
    /// </summary>
    let hasProhibition =
        Namespaced_IRI.parse _namespace_name "hasProhibition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasPurpose"></see>
    /// </summary>
    let hasPurpose = Namespaced_IRI.parse _namespace_name "hasPurpose" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#purposes-properties"></see>
    /// </summary>
    let ``purposes-properties`` =
        Namespaced_IRI.parse _namespace_name "purposes-properties" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecipientDataController"></see>
    /// </summary>
    let hasRecipientDataController =
        Namespaced_IRI.parse _namespace_name "hasRecipientDataController" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecipientThirdParty"></see>
    /// </summary>
    let hasRecipientThirdParty =
        Namespaced_IRI.parse _namespace_name "hasRecipientThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecommendation"></see>
    /// </summary>
    let hasRecommendation =
        Namespaced_IRI.parse _namespace_name "hasRecommendation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRecordOfActivity"></see>
    /// </summary>
    let hasRecordOfActivity =
        Namespaced_IRI.parse _namespace_name "hasRecordOfActivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRelationWithDataSubject"></see>
    /// </summary>
    let hasRelationWithDataSubject =
        Namespaced_IRI.parse _namespace_name "hasRelationWithDataSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRequestStatus"></see>
    /// </summary>
    let hasRequestStatus =
        Namespaced_IRI.parse _namespace_name "hasRequestStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasResidualRisk"></see>
    /// </summary>
    let hasResidualRisk =
        Namespaced_IRI.parse _namespace_name "hasResidualRisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasResponsibleEntity"></see>
    /// </summary>
    let hasResponsibleEntity =
        Namespaced_IRI.parse _namespace_name "hasResponsibleEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasReuseCompatibility"></see>
    /// </summary>
    let hasReuseCompatibility =
        Namespaced_IRI.parse _namespace_name "hasReuseCompatibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRight"></see>
    /// </summary>
    let hasRight = Namespaced_IRI.parse _namespace_name "hasRight" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRisk"></see>
    /// </summary>
    let hasRisk = Namespaced_IRI.parse _namespace_name "hasRisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRiskAssessment"></see>
    /// </summary>
    let hasRiskAssessment =
        Namespaced_IRI.parse _namespace_name "hasRiskAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasRiskLevel"></see>
    /// </summary>
    let hasRiskLevel =
        Namespaced_IRI.parse _namespace_name "hasRiskLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasScope"></see>
    /// </summary>
    let hasScope = Namespaced_IRI.parse _namespace_name "hasScope" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSector"></see>
    /// </summary>
    let hasSector = Namespaced_IRI.parse _namespace_name "hasSector" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSensitivityLevel"></see>
    /// </summary>
    let hasSensitivityLevel =
        Namespaced_IRI.parse _namespace_name "hasSensitivityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasService"></see>
    /// </summary>
    let hasService = Namespaced_IRI.parse _namespace_name "hasService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasServiceConsumer"></see>
    /// </summary>
    let hasServiceConsumer =
        Namespaced_IRI.parse _namespace_name "hasServiceConsumer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasServiceProvider"></see>
    /// </summary>
    let hasServiceProvider =
        Namespaced_IRI.parse _namespace_name "hasServiceProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSeverity"></see>
    /// </summary>
    let hasSeverity =
        Namespaced_IRI.parse _namespace_name "hasSeverity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasStorageCondition"></see>
    /// </summary>
    let hasStorageCondition =
        Namespaced_IRI.parse _namespace_name "hasStorageCondition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasSubsidiary"></see>
    /// </summary>
    let hasSubsidiary =
        Namespaced_IRI.parse _namespace_name "hasSubsidiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasTechnicalMeasure"></see>
    /// </summary>
    let hasTechnicalMeasure =
        Namespaced_IRI.parse _namespace_name "hasTechnicalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasThirdCountry"></see>
    /// </summary>
    let hasThirdCountry =
        Namespaced_IRI.parse _namespace_name "hasThirdCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasThirdParty"></see>
    /// </summary>
    let hasThirdParty =
        Namespaced_IRI.parse _namespace_name "hasThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasUncategorisedData"></see>
    /// </summary>
    let hasUncategorisedData =
        Namespaced_IRI.parse _namespace_name "hasUncategorisedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#hasUnstructuredData"></see>
    /// </summary>
    let hasUnstructuredData =
        Namespaced_IRI.parse _namespace_name "hasUnstructuredData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isAfter"></see>
    /// </summary>
    let isAfter = Namespaced_IRI.parse _namespace_name "isAfter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isApplicableFor"></see>
    /// </summary>
    let isApplicableFor =
        Namespaced_IRI.parse _namespace_name "isApplicableFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isAuthorityFor"></see>
    /// </summary>
    let isAuthorityFor =
        Namespaced_IRI.parse _namespace_name "isAuthorityFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isBefore"></see>
    /// </summary>
    let isBefore = Namespaced_IRI.parse _namespace_name "isBefore" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isDeterminedByEntity"></see>
    /// </summary>
    let isDeterminedByEntity =
        Namespaced_IRI.parse _namespace_name "isDeterminedByEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isDuring"></see>
    /// </summary>
    let isDuring = Namespaced_IRI.parse _namespace_name "isDuring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isExercisedAt"></see>
    /// </summary>
    let isExercisedAt =
        Namespaced_IRI.parse _namespace_name "isExercisedAt" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isImplementedByEntity"></see>
    /// </summary>
    let isImplementedByEntity =
        Namespaced_IRI.parse _namespace_name "isImplementedByEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isImplementedUsingTechnology"></see>
    /// </summary>
    let isImplementedUsingTechnology =
        Namespaced_IRI.parse _namespace_name "isImplementedUsingTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isIndicatedAtTime"></see>
    /// </summary>
    let isIndicatedAtTime =
        Namespaced_IRI.parse _namespace_name "isIndicatedAtTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isIndicatedBy"></see>
    /// </summary>
    let isIndicatedBy =
        Namespaced_IRI.parse _namespace_name "isIndicatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isMitigatedByMeasure"></see>
    /// </summary>
    let isMitigatedByMeasure =
        Namespaced_IRI.parse _namespace_name "isMitigatedByMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isNotApplicableFor"></see>
    /// </summary>
    let isNotApplicableFor =
        Namespaced_IRI.parse _namespace_name "isNotApplicableFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isOrganisationalUnitOf"></see>
    /// </summary>
    let isOrganisationalUnitOf =
        Namespaced_IRI.parse _namespace_name "isOrganisationalUnitOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isOutsideOfLocation"></see>
    /// </summary>
    let isOutsideOfLocation =
        Namespaced_IRI.parse _namespace_name "isOutsideOfLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isPolicyFor"></see>
    /// </summary>
    let isPolicyFor =
        Namespaced_IRI.parse _namespace_name "isPolicyFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isRepresentativeFor"></see>
    /// </summary>
    let isRepresentativeFor =
        Namespaced_IRI.parse _namespace_name "isRepresentativeFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isResidualRiskOf"></see>
    /// </summary>
    let isResidualRiskOf =
        Namespaced_IRI.parse _namespace_name "isResidualRiskOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#isSubsidiaryOf"></see>
    /// </summary>
    let isSubsidiaryOf =
        Namespaced_IRI.parse _namespace_name "isSubsidiaryOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#mitigatesRisk"></see>
    /// </summary>
    let mitigatesRisk =
        Namespaced_IRI.parse _namespace_name "mitigatesRisk" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dpv#supportsComplianceWith"></see>
    /// </summary>
    let supportsComplianceWith =
        Namespaced_IRI.parse _namespace_name "supportsComplianceWith" |> NamespacedName
