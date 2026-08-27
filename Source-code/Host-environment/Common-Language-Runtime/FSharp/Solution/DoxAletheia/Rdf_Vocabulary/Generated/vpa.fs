namespace https.w3id.org.vpa.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vpa =
    let _namespace_iri = Namespace_Iri vpa |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:vpa#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vpa#">https://w3id.org/vpa#</seealso>
    let _prefix_iri = Prefixed_Name(vpa, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#AppropriateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Accredited organization which is able to express a formal opinion on Requirements, expressing them in EvidenceDocument (mostly called Certificates), and if necessary making them dependent on Restrictions, which shall be fulfilled."</para>
    /// labels<para>"Appropriate Body"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#AppropriateBody">https://w3id.org/vpa#AppropriateBody</seealso>
    let AppropriateBody = Prefixed_Name(vpa, "AppropriateBody") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A clearly separated part of a Request, identified clearly by its Scope(s). Each Case has an individual PermissionType as objective. A Request consists out of minimally one Case."</para>
    /// labels<para>"Case"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Case">https://w3id.org/vpa#Case</seealso>
    let Case = Prefixed_Name(vpa, "Case") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Compliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroups the result of a compliance check on a specific section of an applicable Requirement as registered in Documented Evicence. If needed, links this examined section to a specific Restriction."</para>
    /// labels<para>"Compliance"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Compliance">https://w3id.org/vpa#Compliance</seealso>
    let Compliance = Prefixed_Name(vpa, "Compliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Evidence"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Evidence">https://w3id.org/vpa#Evidence</seealso>
    let Evidence = Prefixed_Name(vpa, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#EvidenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Issued by an AppropriateBody, it is the summary of its formal and accredited verification process, enabling the receiver (RequestingBody) to issue a Request for a Permission to the PermittingBody."</para>
    /// labels<para>"Documented Evidence"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#EvidenceDocument">https://w3id.org/vpa#EvidenceDocument</seealso>
    let EvidenceDocument = Prefixed_Name(vpa, "EvidenceDocument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Issued by a PermittingBody, it enables - mostly because of legal frameworks in place - the RequestingBody to execute the processes covered under these requirement frameworks."</para>
    /// labels<para>"Permission"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Permission">https://w3id.org/vpa#Permission</seealso>
    let Permission = Prefixed_Name(vpa, "Permission") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#PermittingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Within its legally recognized mandate, this Body is able to receive EvidenceDocument as submitted in a Request and based upon it, issue a Permit to the RequestingBody for the activities covered by the mentioned legislation."</para>
    /// labels<para>"Permitting Body"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#PermittingBody">https://w3id.org/vpa#PermittingBody</seealso>
    let PermittingBody = Prefixed_Name(vpa, "PermittingBody") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Issued by a Requesting Body to a PermittingBody, and supported by at least one Case, while being supported by the necessary Evidence (consisting of EvidenceDocuments), it intends to enable the reception of a Permission."</para>
    /// labels<para>"Request"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Request">https://w3id.org/vpa#Request</seealso>
    let Request = Prefixed_Name(vpa, "Request") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#RequestingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Within its legally recognized role, this Body is able to express the intention to act under the condition of reception of a Permission. The intended action being covered by legal or standardized Requirements to fullfil, this Body will present all required information, as verified by the Appropriate and examined by the Permitting Bodies, to the latter in order to receive the mentioned Permission."</para>
    /// labels<para>"Requesting Body"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#RequestingBody">https://w3id.org/vpa#RequestingBody</seealso>
    let RequestingBody = Prefixed_Name(vpa, "RequestingBody") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A legal/standardised collection of rules, which must be verified independently to be met in the context of a Permission Request, and of which the measure of compliance is expressed in EvidenceDocuments, with or without added Restrictions."</para>
    /// labels<para>"Requirement"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Requirement">https://w3id.org/vpa#Requirement</seealso>
    let Requirement = Prefixed_Name(vpa, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Issued by an Appropriate Body in connection with its (documented) evidence on a certain requirement, it contains all aspects to take into account in order to accept the Evidence as proof, enabling the scope of the Permission. It is possible that the Restriction limits the Permission in the same way."</para>
    /// labels<para>"Restriction"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Restriction">https://w3id.org/vpa#Restriction</seealso>
    let Restriction = Prefixed_Name(vpa, "Restriction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#Scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of Scopes together defining a Case. Scope is mostly the specific material object of the Case, where the Case groups them together."</para>
    /// labels<para>"Scope"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#Scope">https://w3id.org/vpa#Scope</seealso>
    let Scope = Prefixed_Name(vpa, "Scope") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#certifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"within its accredited competencies, can express an opinion whether a (legal or standardized) requirement is met. This relation must be accompanied by Evidence(Document) to formalize this opinion and eventually Restrictions if it is met only partially."</para>
    /// labels<para>"certifies"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#certifies">https://w3id.org/vpa#certifies</seealso>
    let certifies = Prefixed_Name(vpa, "certifies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#checkedCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Compliance checks having been documented by the Appropriate Body in the EvidenceDocument."</para>
    /// labels<para>"checked compliance"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#checkedCompliance">https://w3id.org/vpa#checkedCompliance</seealso>
    let checkedCompliance = Prefixed_Name(vpa, "checkedCompliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#checkedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For a Compliance check, the Requirement which was (globally or in part) checked by the Appropriate Body."</para>
    /// labels<para>"checked requirement"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#checkedRequirement">https://w3id.org/vpa#checkedRequirement</seealso>
    let checkedRequirement = Prefixed_Name(vpa, "checkedRequirement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#checkedSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For a Compliance check, the section of the Requirement which was individually checked by the Appropriate Body. The sections in scope of the verification are registered under each Requirement itself."</para>
    /// labels<para>"checked section"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#checkedSection">https://w3id.org/vpa#checkedSection</seealso>
    let checkedSection = Prefixed_Name(vpa, "checkedSection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#closes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"within the accredited competencies of the issuer of the EvidenceDocument, confirms that the evidence shown in the context of the Requirement was (not, partially or fully) fulfilled, where needed in presence of a Restriction."</para>
    /// labels<para>"closes"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#closes">https://w3id.org/vpa#closes</seealso>
    let closes = Prefixed_Name(vpa, "closes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#concerns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"holds as material content, constitutes, embodies the material components of the Scope."</para>
    /// labels<para>"concerns"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#concerns">https://w3id.org/vpa#concerns</seealso>
    let concerns = Prefixed_Name(vpa, "concerns") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#constitutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"holds as a complete, independent, possibly sole part, embodies as one element of potentially more"</para>
    /// labels<para>"constituted by"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#constitutedBy">https://w3id.org/vpa#constitutedBy</seealso>
    let constitutedBy = Prefixed_Name(vpa, "constitutedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#constitutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"forms a complete, independent, possibly sole part of a request"</para>
    ///   <para>"is part of, inherently constitutes"</para>
    /// labels<para>"constitutes"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#constitutes">https://w3id.org/vpa#constitutes</seealso>
    let constitutes = Prefixed_Name(vpa, "constitutes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#definesCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of `vpa:concerns`. Is covered by, included in"</para>
    /// labels<para>"defines case"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#definesCase">https://w3id.org/vpa#definesCase</seealso>
    let definesCase = Prefixed_Name(vpa, "definesCase") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#delivers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"within its accredited mandate, issues in a traceable and qualitative manner for reuse in a Permission process"</para>
    /// labels<para>"delivers"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#delivers">https://w3id.org/vpa#delivers</seealso>
    let delivers = Prefixed_Name(vpa, "delivers") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#grants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"within its legally recognized mandate, issues, delivers in a traceable and qualitative manner, such that the receiver is able to act within the authorisation cases and its verified documentation"</para>
    /// labels<para>"grants"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#grants">https://w3id.org/vpa#grants</seealso>
    let grants = Prefixed_Name(vpa, "grants") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#isCompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"For the verified section of a Requirement: true when fully compliant, false in other cases (in which a clarifying Restriction is possible)"</para>
    /// labels<para>"is compliant"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#isCompliant">https://w3id.org/vpa#isCompliant</seealso>
    let isCompliant = Prefixed_Name(vpa, "isCompliant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#issues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"transmits with the intention to be allowed to act according to a legally verified process"</para>
    /// labels<para>"issues"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#issues">https://w3id.org/vpa#issues</seealso>
    let issues = Prefixed_Name(vpa, "issues") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#permissionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the detailed process which constitutes this Case's permission conditions"</para>
    /// labels<para>"permission type"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#permissionType">https://w3id.org/vpa#permissionType</seealso>
    let permissionType = Prefixed_Name(vpa, "permissionType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#permits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the process, activity, role or other scope which the Permission allows to the Requesting Body to execute or hold"</para>
    /// labels<para>"permits"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#permits">https://w3id.org/vpa#permits</seealso>
    let permits = Prefixed_Name(vpa, "permits") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#regarding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"belonging to, and when being respected, then also fulfilling"</para>
    /// labels<para>"regarding"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#regarding">https://w3id.org/vpa#regarding</seealso>
    let regarding = Prefixed_Name(vpa, "regarding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#requestFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"aiming to be enabled to act as covered by the Permission and its conditions, by receiving"</para>
    /// labels<para>"request for"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#requestFor">https://w3id.org/vpa#requestFor</seealso>
    let requestFor = Prefixed_Name(vpa, "requestFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#requestedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"aiming to be enabled to act as covered by the Permission and its conditions, by issuing"</para>
    /// labels<para>"requested in"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#requestedIn">https://w3id.org/vpa#requestedIn</seealso>
    let requestedIn = Prefixed_Name(vpa, "requestedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#requests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"aims to be allowed to act according to a legally verified process, by receiving"</para>
    /// labels<para>"requests"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#requests">https://w3id.org/vpa#requests</seealso>
    let requests = Prefixed_Name(vpa, "requests") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"section(s) of the requirement to which individual compliance can be registered by the Appropriate Body"</para>
    /// labels<para>"sections"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#section">https://w3id.org/vpa#section</seealso>
    let section = Prefixed_Name(vpa, "section") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#statesCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"stating, through a collective set of evidence providing documents, a (non)compliance, instantiated as a `vpa:Compliance`"</para>
    /// labels<para>"states compliance"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#statesCompliance">https://w3id.org/vpa#statesCompliance</seealso>
    let statesCompliance = Prefixed_Name(vpa, "statesCompliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the status of the Request as it is being treated by the PermittingBody"</para>
    /// labels<para>"status"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#status">https://w3id.org/vpa#status</seealso>
    let status = Prefixed_Name(vpa, "status") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#submittedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"supporting, holding evidence of compliance in order to enable the Permitting Body to verify and permit"</para>
    /// labels<para>"submitted for"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#submittedFor">https://w3id.org/vpa#submittedFor</seealso>
    let submittedFor = Prefixed_Name(vpa, "submittedFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#submittedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The submission of a permission or evidence to a case"</para>
    /// labels<para>"submitted in"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#submittedIn">https://w3id.org/vpa#submittedIn</seealso>
    let submittedIn = Prefixed_Name(vpa, "submittedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"super property for the different targets of supporting evidence: the scope, a case or the full request"</para>
    /// labels<para>"supports"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#supports">https://w3id.org/vpa#supports</seealso>
    let supports = Prefixed_Name(vpa, "supports") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#supportsCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"supporting, as a collective set of evidence providing documents, a specific case, as such also supporting the request"</para>
    /// labels<para>"supports case"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#supportsCase">https://w3id.org/vpa#supportsCase</seealso>
    let supportsCase = Prefixed_Name(vpa, "supportsCase") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#supportsScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"supporting, as a collective set of evidence providing documents, a specific, material scope within a case, as such also supporting the request"</para>
    /// labels<para>"supports scope"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#supportsScope">https://w3id.org/vpa#supportsScope</seealso>
    let supportsScope = Prefixed_Name(vpa, "supportsScope") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#valid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"valid during a certain time"</para>
    /// labels<para>"valid"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#valid">https://w3id.org/vpa#valid</seealso>
    let valid = Prefixed_Name(vpa, "valid") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#versionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An integer representing any sequence number of a version of an EvidenceDocument. Subsequent EvidenceDocuments SHOULD use `dcterms:isReplacedBy` and `dcterms:replaces` to indicate their relation."</para>
    /// labels<para>"version number"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#versionNumber">https://w3id.org/vpa#versionNumber</seealso>
    let versionNumber = Prefixed_Name(vpa, "versionNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vpa#withRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"when taken into account in the final act to be permitted, can be accepted under the condition that the conditions of the Restriction are fully answered to"</para>
    /// labels<para>"with restriction"</para></remarks>
    /// <seealso href="https://w3id.org/vpa#withRestriction">https://w3id.org/vpa#withRestriction</seealso>
    let withRestriction = Prefixed_Name(vpa, "withRestriction") |> PrefixedName
