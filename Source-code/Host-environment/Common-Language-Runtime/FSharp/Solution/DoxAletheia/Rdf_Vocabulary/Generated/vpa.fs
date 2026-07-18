namespace https.w3id.org.vpa.hash

open DoxAletheia.Rdf_Vocabulary

module vpa =
    let _namespace_name = "https://w3id.org/vpa#"
    /// <summary>
    /// Regroups the result of a compliance check on a specific section of an applicable Requirement as registered in Documented Evicence. If needed, links this examined section to a specific Restriction.
    /// <see href="https://w3id.org/vpa#Compliance"></see></summary>
    let Compliance = Namespaced_IRI.parse _namespace_name "Compliance" |> NamespacedName

    /// <summary>
    /// Issued by an AppropriateBody, it is the summary of its formal and accredited verification process, enabling the receiver (RequestingBody) to issue a Request for a Permission to the PermittingBody.
    /// <see href="https://w3id.org/vpa#EvidenceDocument"></see></summary>
    let EvidenceDocument =
        Namespaced_IRI.parse _namespace_name "EvidenceDocument" |> NamespacedName

    /// <summary>
    /// A clearly separated part of a Request, identified clearly by its Scope(s). Each Case has an individual PermissionType as objective. A Request consists out of minimally one Case.
    /// <see href="https://w3id.org/vpa#Case"></see></summary>
    let Case = Namespaced_IRI.parse _namespace_name "Case" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vpa#Evidence"></see>
    /// </summary>
    let Evidence = Namespaced_IRI.parse _namespace_name "Evidence" |> NamespacedName
    /// <summary>
    /// Issued by a PermittingBody, it enables - mostly because of legal frameworks in place - the RequestingBody to execute the processes covered under these requirement frameworks.
    /// <see href="https://w3id.org/vpa#Permission"></see></summary>
    let Permission = Namespaced_IRI.parse _namespace_name "Permission" |> NamespacedName
    /// <summary>
    /// Issued by a Requesting Body to a PermittingBody, and supported by at least one Case, while being supported by the necessary Evidence (consisting of EvidenceDocuments), it intends to enable the reception of a Permission.
    /// <see href="https://w3id.org/vpa#Request"></see></summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName

    /// <summary>
    /// A legal/standardised collection of rules, which must be verified independently to be met in the context of a Permission Request, and of which the measure of compliance is expressed in EvidenceDocuments, with or without added Restrictions.
    /// <see href="https://w3id.org/vpa#Requirement"></see></summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    /// Issued by an Appropriate Body in connection with its (documented) evidence on a certain requirement, it contains all aspects to take into account in order to accept the Evidence as proof, enabling the scope of the Permission. It is possible that the Restriction limits the Permission in the same way.
    /// <see href="https://w3id.org/vpa#Restriction"></see></summary>
    let Restriction =
        Namespaced_IRI.parse _namespace_name "Restriction" |> NamespacedName

    /// <summary>
    /// A collection of Scopes together defining a Case. Scope is mostly the specific material object of the Case, where the Case groups them together.
    /// <see href="https://w3id.org/vpa#Scope"></see></summary>
    let Scope = Namespaced_IRI.parse _namespace_name "Scope" |> NamespacedName

    /// <summary>
    /// Accredited organization which is able to express a formal opinion on Requirements, expressing them in EvidenceDocument (mostly called Certificates), and if necessary making them dependent on Restrictions, which shall be fulfilled.
    /// <see href="https://w3id.org/vpa#AppropriateBody"></see></summary>
    let AppropriateBody =
        Namespaced_IRI.parse _namespace_name "AppropriateBody" |> NamespacedName

    /// <summary>
    /// Within its legally recognized mandate, this Body is able to receive EvidenceDocument as submitted in a Request and based upon it, issue a Permit to the RequestingBody for the activities covered by the mentioned legislation.
    /// <see href="https://w3id.org/vpa#PermittingBody"></see></summary>
    let PermittingBody =
        Namespaced_IRI.parse _namespace_name "PermittingBody" |> NamespacedName

    /// <summary>
    /// holds as a complete, independent, possibly sole part, embodies as one element of potentially more
    /// <see href="https://w3id.org/vpa#constitutedBy"></see></summary>
    let constitutedBy =
        Namespaced_IRI.parse _namespace_name "constitutedBy" |> NamespacedName

    /// <summary>
    /// Within its legally recognized role, this Body is able to express the intention to act under the condition of reception of a Permission. The intended action being covered by legal or standardized Requirements to fullfil, this Body will present all required information, as verified by the Appropriate and examined by the Permitting Bodies, to the latter in order to receive the mentioned Permission.
    /// <see href="https://w3id.org/vpa#RequestingBody"></see></summary>
    let RequestingBody =
        Namespaced_IRI.parse _namespace_name "RequestingBody" |> NamespacedName

    /// <summary>
    /// within its accredited competencies, can express an opinion whether a (legal or standardized) requirement is met. This relation must be accompanied by Evidence(Document) to formalize this opinion and eventually Restrictions if it is met only partially.
    /// <see href="https://w3id.org/vpa#certifies"></see></summary>
    let certifies = Namespaced_IRI.parse _namespace_name "certifies" |> NamespacedName

    /// <summary>
    /// The Compliance checks having been documented by the Appropriate Body in the EvidenceDocument.
    /// <see href="https://w3id.org/vpa#checkedCompliance"></see></summary>
    let checkedCompliance =
        Namespaced_IRI.parse _namespace_name "checkedCompliance" |> NamespacedName

    /// <summary>
    /// For a Compliance check, the Requirement which was (globally or in part) checked by the Appropriate Body.
    /// <see href="https://w3id.org/vpa#checkedRequirement"></see></summary>
    let checkedRequirement =
        Namespaced_IRI.parse _namespace_name "checkedRequirement" |> NamespacedName

    /// <summary>
    /// For a Compliance check, the section of the Requirement which was individually checked by the Appropriate Body. The sections in scope of the verification are registered under each Requirement itself.
    /// <see href="https://w3id.org/vpa#checkedSection"></see></summary>
    let checkedSection =
        Namespaced_IRI.parse _namespace_name "checkedSection" |> NamespacedName

    /// <summary>
    /// within the accredited competencies of the issuer of the EvidenceDocument, confirms that the evidence shown in the context of the Requirement was (not, partially or fully) fulfilled, where needed in presence of a Restriction.
    /// <see href="https://w3id.org/vpa#closes"></see></summary>
    let closes = Namespaced_IRI.parse _namespace_name "closes" |> NamespacedName
    /// <summary>
    /// holds as material content, constitutes, embodies the material components of the Scope.
    /// <see href="https://w3id.org/vpa#concerns"></see></summary>
    let concerns = Namespaced_IRI.parse _namespace_name "concerns" |> NamespacedName

    /// <summary>
    /// is part of, inherently constitutes
    /// forms a complete, independent, possibly sole part of a request
    /// <see href="https://w3id.org/vpa#constitutes"></see></summary>
    let constitutes =
        Namespaced_IRI.parse _namespace_name "constitutes" |> NamespacedName

    /// <summary>
    /// Inverse property of `vpa:concerns`. Is covered by, included in
    /// <see href="https://w3id.org/vpa#definesCase"></see></summary>
    let definesCase =
        Namespaced_IRI.parse _namespace_name "definesCase" |> NamespacedName

    /// <summary>
    /// within its accredited mandate, issues in a traceable and qualitative manner for reuse in a Permission process
    /// <see href="https://w3id.org/vpa#delivers"></see></summary>
    let delivers = Namespaced_IRI.parse _namespace_name "delivers" |> NamespacedName
    /// <summary>
    /// within its legally recognized mandate, issues, delivers in a traceable and qualitative manner, such that the receiver is able to act within the authorisation cases and its verified documentation
    /// <see href="https://w3id.org/vpa#grants"></see></summary>
    let grants = Namespaced_IRI.parse _namespace_name "grants" |> NamespacedName

    /// <summary>
    /// For the verified section of a Requirement: true when fully compliant, false in other cases (in which a clarifying Restriction is possible)
    /// <see href="https://w3id.org/vpa#isCompliant"></see></summary>
    let isCompliant =
        Namespaced_IRI.parse _namespace_name "isCompliant" |> NamespacedName

    /// <summary>
    /// transmits with the intention to be allowed to act according to a legally verified process
    /// <see href="https://w3id.org/vpa#issues"></see></summary>
    let issues = Namespaced_IRI.parse _namespace_name "issues" |> NamespacedName

    /// <summary>
    /// the detailed process which constitutes this Case's permission conditions
    /// <see href="https://w3id.org/vpa#permissionType"></see></summary>
    let permissionType =
        Namespaced_IRI.parse _namespace_name "permissionType" |> NamespacedName

    /// <summary>
    /// the process, activity, role or other scope which the Permission allows to the Requesting Body to execute or hold
    /// <see href="https://w3id.org/vpa#permits"></see></summary>
    let permits = Namespaced_IRI.parse _namespace_name "permits" |> NamespacedName
    /// <summary>
    /// belonging to, and when being respected, then also fulfilling
    /// <see href="https://w3id.org/vpa#regarding"></see></summary>
    let regarding = Namespaced_IRI.parse _namespace_name "regarding" |> NamespacedName
    /// <summary>
    /// aiming to be enabled to act as covered by the Permission and its conditions, by receiving
    /// <see href="https://w3id.org/vpa#requestFor"></see></summary>
    let requestFor = Namespaced_IRI.parse _namespace_name "requestFor" |> NamespacedName

    /// <summary>
    /// aiming to be enabled to act as covered by the Permission and its conditions, by issuing
    /// <see href="https://w3id.org/vpa#requestedIn"></see></summary>
    let requestedIn =
        Namespaced_IRI.parse _namespace_name "requestedIn" |> NamespacedName

    /// <summary>
    /// aims to be allowed to act according to a legally verified process, by receiving
    /// <see href="https://w3id.org/vpa#requests"></see></summary>
    let requests = Namespaced_IRI.parse _namespace_name "requests" |> NamespacedName
    /// <summary>
    /// section(s) of the requirement to which individual compliance can be registered by the Appropriate Body
    /// <see href="https://w3id.org/vpa#section"></see></summary>
    let section = Namespaced_IRI.parse _namespace_name "section" |> NamespacedName

    /// <summary>
    /// stating, through a collective set of evidence providing documents, a (non)compliance, instantiated as a `vpa:Compliance`
    /// <see href="https://w3id.org/vpa#statesCompliance"></see></summary>
    let statesCompliance =
        Namespaced_IRI.parse _namespace_name "statesCompliance" |> NamespacedName

    /// <summary>
    /// the status of the Request as it is being treated by the PermittingBody
    /// <see href="https://w3id.org/vpa#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// supporting, holding evidence of compliance in order to enable the Permitting Body to verify and permit
    /// <see href="https://w3id.org/vpa#submittedFor"></see></summary>
    let submittedFor =
        Namespaced_IRI.parse _namespace_name "submittedFor" |> NamespacedName

    /// <summary>
    /// The submission of a permission or evidence to a case
    /// <see href="https://w3id.org/vpa#submittedIn"></see></summary>
    let submittedIn =
        Namespaced_IRI.parse _namespace_name "submittedIn" |> NamespacedName

    /// <summary>
    /// super property for the different targets of supporting evidence: the scope, a case or the full request
    /// <see href="https://w3id.org/vpa#supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName

    /// <summary>
    /// supporting, as a collective set of evidence providing documents, a specific case, as such also supporting the request
    /// <see href="https://w3id.org/vpa#supportsCase"></see></summary>
    let supportsCase =
        Namespaced_IRI.parse _namespace_name "supportsCase" |> NamespacedName

    /// <summary>
    /// supporting, as a collective set of evidence providing documents, a specific, material scope within a case, as such also supporting the request
    /// <see href="https://w3id.org/vpa#supportsScope"></see></summary>
    let supportsScope =
        Namespaced_IRI.parse _namespace_name "supportsScope" |> NamespacedName

    /// <summary>
    /// valid during a certain time
    /// <see href="https://w3id.org/vpa#valid"></see></summary>
    let valid = Namespaced_IRI.parse _namespace_name "valid" |> NamespacedName

    /// <summary>
    /// An integer representing any sequence number of a version of an EvidenceDocument. Subsequent EvidenceDocuments SHOULD use `dcterms:isReplacedBy` and `dcterms:replaces` to indicate their relation.
    /// <see href="https://w3id.org/vpa#versionNumber"></see></summary>
    let versionNumber =
        Namespaced_IRI.parse _namespace_name "versionNumber" |> NamespacedName

    /// <summary>
    /// when taken into account in the final act to be permitted, can be accepted under the condition that the conditions of the Restriction are fully answered to
    /// <see href="https://w3id.org/vpa#withRestriction"></see></summary>
    let withRestriction =
        Namespaced_IRI.parse _namespace_name "withRestriction" |> NamespacedName
