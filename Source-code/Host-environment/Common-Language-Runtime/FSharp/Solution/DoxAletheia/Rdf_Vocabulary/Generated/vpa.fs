namespace https.w3id.org.vpa.hash

open DoxAletheia

module vpa =
    let _namespace_name = "https://w3id.org/vpa#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Regroups the result of a compliance check on a specific section of an applicable Requirement as registered in Documented Evicence. If needed, links this examined section to a specific Restriction.
    /// <see href="https://w3id.org/vpa#Compliance"></see></summary>
    let Compliance = _prefix "Compliance"
    /// <summary>
    /// Issued by an AppropriateBody, it is the summary of its formal and accredited verification process, enabling the receiver (RequestingBody) to issue a Request for a Permission to the PermittingBody.
    /// <see href="https://w3id.org/vpa#EvidenceDocument"></see></summary>
    let EvidenceDocument = _prefix "EvidenceDocument"
    /// <summary>
    /// A clearly separated part of a Request, identified clearly by its Scope(s). Each Case has an individual PermissionType as objective. A Request consists out of minimally one Case.
    /// <see href="https://w3id.org/vpa#Case"></see></summary>
    let Case = _prefix "Case"
    /// <summary>
    ///   <see href="https://w3id.org/vpa#Evidence"></see>
    /// </summary>
    let Evidence = _prefix "Evidence"
    /// <summary>
    /// Issued by a PermittingBody, it enables - mostly because of legal frameworks in place - the RequestingBody to execute the processes covered under these requirement frameworks.
    /// <see href="https://w3id.org/vpa#Permission"></see></summary>
    let Permission = _prefix "Permission"
    /// <summary>
    /// Issued by a Requesting Body to a PermittingBody, and supported by at least one Case, while being supported by the necessary Evidence (consisting of EvidenceDocuments), it intends to enable the reception of a Permission.
    /// <see href="https://w3id.org/vpa#Request"></see></summary>
    let Request = _prefix "Request"
    /// <summary>
    /// A legal/standardised collection of rules, which must be verified independently to be met in the context of a Permission Request, and of which the measure of compliance is expressed in EvidenceDocuments, with or without added Restrictions.
    /// <see href="https://w3id.org/vpa#Requirement"></see></summary>
    let Requirement = _prefix "Requirement"
    /// <summary>
    /// Issued by an Appropriate Body in connection with its (documented) evidence on a certain requirement, it contains all aspects to take into account in order to accept the Evidence as proof, enabling the scope of the Permission. It is possible that the Restriction limits the Permission in the same way.
    /// <see href="https://w3id.org/vpa#Restriction"></see></summary>
    let Restriction = _prefix "Restriction"
    /// <summary>
    /// A collection of Scopes together defining a Case. Scope is mostly the specific material object of the Case, where the Case groups them together.
    /// <see href="https://w3id.org/vpa#Scope"></see></summary>
    let Scope = _prefix "Scope"
    /// <summary>
    /// Accredited organization which is able to express a formal opinion on Requirements, expressing them in EvidenceDocument (mostly called Certificates), and if necessary making them dependent on Restrictions, which shall be fulfilled.
    /// <see href="https://w3id.org/vpa#AppropriateBody"></see></summary>
    let AppropriateBody = _prefix "AppropriateBody"
    /// <summary>
    /// Within its legally recognized mandate, this Body is able to receive EvidenceDocument as submitted in a Request and based upon it, issue a Permit to the RequestingBody for the activities covered by the mentioned legislation.
    /// <see href="https://w3id.org/vpa#PermittingBody"></see></summary>
    let PermittingBody = _prefix "PermittingBody"
    /// <summary>
    /// holds as a complete, independent, possibly sole part, embodies as one element of potentially more
    /// <see href="https://w3id.org/vpa#constitutedBy"></see></summary>
    let constitutedBy = _prefix "constitutedBy"
    /// <summary>
    /// Within its legally recognized role, this Body is able to express the intention to act under the condition of reception of a Permission. The intended action being covered by legal or standardized Requirements to fullfil, this Body will present all required information, as verified by the Appropriate and examined by the Permitting Bodies, to the latter in order to receive the mentioned Permission.
    /// <see href="https://w3id.org/vpa#RequestingBody"></see></summary>
    let RequestingBody = _prefix "RequestingBody"
    /// <summary>
    /// within its accredited competencies, can express an opinion whether a (legal or standardized) requirement is met. This relation must be accompanied by Evidence(Document) to formalize this opinion and eventually Restrictions if it is met only partially.
    /// <see href="https://w3id.org/vpa#certifies"></see></summary>
    let certifies = _prefix "certifies"
    /// <summary>
    /// The Compliance checks having been documented by the Appropriate Body in the EvidenceDocument.
    /// <see href="https://w3id.org/vpa#checkedCompliance"></see></summary>
    let checkedCompliance = _prefix "checkedCompliance"
    /// <summary>
    /// For a Compliance check, the Requirement which was (globally or in part) checked by the Appropriate Body.
    /// <see href="https://w3id.org/vpa#checkedRequirement"></see></summary>
    let checkedRequirement = _prefix "checkedRequirement"
    /// <summary>
    /// For a Compliance check, the section of the Requirement which was individually checked by the Appropriate Body. The sections in scope of the verification are registered under each Requirement itself.
    /// <see href="https://w3id.org/vpa#checkedSection"></see></summary>
    let checkedSection = _prefix "checkedSection"
    /// <summary>
    /// within the accredited competencies of the issuer of the EvidenceDocument, confirms that the evidence shown in the context of the Requirement was (not, partially or fully) fulfilled, where needed in presence of a Restriction.
    /// <see href="https://w3id.org/vpa#closes"></see></summary>
    let closes = _prefix "closes"
    /// <summary>
    /// holds as material content, constitutes, embodies the material components of the Scope.
    /// <see href="https://w3id.org/vpa#concerns"></see></summary>
    let concerns = _prefix "concerns"
    /// <summary>
    /// is part of, inherently constitutes
    /// forms a complete, independent, possibly sole part of a request
    /// <see href="https://w3id.org/vpa#constitutes"></see></summary>
    let constitutes = _prefix "constitutes"
    /// <summary>
    /// Inverse property of `vpa:concerns`. Is covered by, included in
    /// <see href="https://w3id.org/vpa#definesCase"></see></summary>
    let definesCase = _prefix "definesCase"
    /// <summary>
    /// within its accredited mandate, issues in a traceable and qualitative manner for reuse in a Permission process
    /// <see href="https://w3id.org/vpa#delivers"></see></summary>
    let delivers = _prefix "delivers"
    /// <summary>
    /// within its legally recognized mandate, issues, delivers in a traceable and qualitative manner, such that the receiver is able to act within the authorisation cases and its verified documentation
    /// <see href="https://w3id.org/vpa#grants"></see></summary>
    let grants = _prefix "grants"
    /// <summary>
    /// For the verified section of a Requirement: true when fully compliant, false in other cases (in which a clarifying Restriction is possible)
    /// <see href="https://w3id.org/vpa#isCompliant"></see></summary>
    let isCompliant = _prefix "isCompliant"
    /// <summary>
    /// transmits with the intention to be allowed to act according to a legally verified process
    /// <see href="https://w3id.org/vpa#issues"></see></summary>
    let issues = _prefix "issues"
    /// <summary>
    /// the detailed process which constitutes this Case's permission conditions
    /// <see href="https://w3id.org/vpa#permissionType"></see></summary>
    let permissionType = _prefix "permissionType"
    /// <summary>
    /// the process, activity, role or other scope which the Permission allows to the Requesting Body to execute or hold
    /// <see href="https://w3id.org/vpa#permits"></see></summary>
    let permits = _prefix "permits"
    /// <summary>
    /// belonging to, and when being respected, then also fulfilling
    /// <see href="https://w3id.org/vpa#regarding"></see></summary>
    let regarding = _prefix "regarding"
    /// <summary>
    /// aiming to be enabled to act as covered by the Permission and its conditions, by receiving
    /// <see href="https://w3id.org/vpa#requestFor"></see></summary>
    let requestFor = _prefix "requestFor"
    /// <summary>
    /// aiming to be enabled to act as covered by the Permission and its conditions, by issuing
    /// <see href="https://w3id.org/vpa#requestedIn"></see></summary>
    let requestedIn = _prefix "requestedIn"
    /// <summary>
    /// aims to be allowed to act according to a legally verified process, by receiving
    /// <see href="https://w3id.org/vpa#requests"></see></summary>
    let requests = _prefix "requests"
    /// <summary>
    /// section(s) of the requirement to which individual compliance can be registered by the Appropriate Body
    /// <see href="https://w3id.org/vpa#section"></see></summary>
    let section = _prefix "section"
    /// <summary>
    /// stating, through a collective set of evidence providing documents, a (non)compliance, instantiated as a `vpa:Compliance`
    /// <see href="https://w3id.org/vpa#statesCompliance"></see></summary>
    let statesCompliance = _prefix "statesCompliance"
    /// <summary>
    /// the status of the Request as it is being treated by the PermittingBody
    /// <see href="https://w3id.org/vpa#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// supporting, holding evidence of compliance in order to enable the Permitting Body to verify and permit
    /// <see href="https://w3id.org/vpa#submittedFor"></see></summary>
    let submittedFor = _prefix "submittedFor"
    /// <summary>
    /// The submission of a permission or evidence to a case
    /// <see href="https://w3id.org/vpa#submittedIn"></see></summary>
    let submittedIn = _prefix "submittedIn"
    /// <summary>
    /// super property for the different targets of supporting evidence: the scope, a case or the full request
    /// <see href="https://w3id.org/vpa#supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// supporting, as a collective set of evidence providing documents, a specific case, as such also supporting the request
    /// <see href="https://w3id.org/vpa#supportsCase"></see></summary>
    let supportsCase = _prefix "supportsCase"
    /// <summary>
    /// supporting, as a collective set of evidence providing documents, a specific, material scope within a case, as such also supporting the request
    /// <see href="https://w3id.org/vpa#supportsScope"></see></summary>
    let supportsScope = _prefix "supportsScope"
    /// <summary>
    /// valid during a certain time
    /// <see href="https://w3id.org/vpa#valid"></see></summary>
    let valid = _prefix "valid"
    /// <summary>
    /// An integer representing any sequence number of a version of an EvidenceDocument. Subsequent EvidenceDocuments SHOULD use `dcterms:isReplacedBy` and `dcterms:replaces` to indicate their relation.
    /// <see href="https://w3id.org/vpa#versionNumber"></see></summary>
    let versionNumber = _prefix "versionNumber"
    /// <summary>
    /// when taken into account in the final act to be permitted, can be accepted under the condition that the conditions of the Restriction are fully answered to
    /// <see href="https://w3id.org/vpa#withRestriction"></see></summary>
    let withRestriction = _prefix "withRestriction"
