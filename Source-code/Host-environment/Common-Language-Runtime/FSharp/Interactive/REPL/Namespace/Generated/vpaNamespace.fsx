#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vpa =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/vpa#" "vpa"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Appropriate Body</para>
    ///   <para>rdfs:comment : Accredited organization which is able to express a formal opinion on Requirements, expressing them in EvidenceDocument (mostly called Certificates), and if necessary making them dependent on Restrictions, which shall be fulfilled.</para>
    ///   <a href="https://w3id.org/vpa#AppropriateBody">vpa:AppropriateBody</a>
    /// </summary>
    let AppropriateBody = _prefixId.prefix "AppropriateBody"
    /// <summary>
    ///   <para>rdfs:label : Case</para>
    ///   <para>rdfs:comment : A clearly separated part of a Request, identified clearly by its Scope(s). Each Case has an individual PermissionType as objective. A Request consists out of minimally one Case.</para>
    ///   <a href="https://w3id.org/vpa#Case">vpa:Case</a>
    /// </summary>
    let Case = _prefixId.prefix "Case"
    /// <summary>
    ///   <para>rdfs:label : Compliance</para>
    ///   <para>rdfs:comment : Regroups the result of a compliance check on a specific section of an applicable Requirement as registered in Documented Evicence. If needed, links this examined section to a specific Restriction.</para>
    ///   <a href="https://w3id.org/vpa#Compliance">vpa:Compliance</a>
    /// </summary>
    let Compliance = _prefixId.prefix "Compliance"
    /// <summary>
    ///   <para>rdfs:label : Evidence</para>
    ///   <a href="https://w3id.org/vpa#Evidence">vpa:Evidence</a>
    /// </summary>
    let Evidence = _prefixId.prefix "Evidence"
    /// <summary>
    ///   <para>rdfs:label : Documented Evidence</para>
    ///   <para>rdfs:comment : Issued by an AppropriateBody, it is the summary of its formal and accredited verification process, enabling the receiver (RequestingBody) to issue a Request for a Permission to the PermittingBody.</para>
    ///   <a href="https://w3id.org/vpa#EvidenceDocument">vpa:EvidenceDocument</a>
    /// </summary>
    let EvidenceDocument = _prefixId.prefix "EvidenceDocument"
    /// <summary>
    ///   <para>rdfs:label : Permission</para>
    ///   <para>rdfs:comment : Issued by a PermittingBody, it enables - mostly because of legal frameworks in place - the RequestingBody to execute the processes covered under these requirement frameworks.</para>
    ///   <a href="https://w3id.org/vpa#Permission">vpa:Permission</a>
    /// </summary>
    let Permission = _prefixId.prefix "Permission"
    /// <summary>
    ///   <para>rdfs:label : Permitting Body</para>
    ///   <para>rdfs:comment : Within its legally recognized mandate, this Body is able to receive EvidenceDocument as submitted in a Request and based upon it, issue a Permit to the RequestingBody for the activities covered by the mentioned legislation.</para>
    ///   <a href="https://w3id.org/vpa#PermittingBody">vpa:PermittingBody</a>
    /// </summary>
    let PermittingBody = _prefixId.prefix "PermittingBody"
    /// <summary>
    ///   <para>rdfs:label : Request</para>
    ///   <para>rdfs:comment : Issued by a Requesting Body to a PermittingBody, and supported by at least one Case, while being supported by the necessary Evidence (consisting of EvidenceDocuments), it intends to enable the reception of a Permission.</para>
    ///   <a href="https://w3id.org/vpa#Request">vpa:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>rdfs:label : Requesting Body</para>
    ///   <para>rdfs:comment : Within its legally recognized role, this Body is able to express the intention to act under the condition of reception of a Permission. The intended action being covered by legal or standardized Requirements to fullfil, this Body will present all required information, as verified by the Appropriate and examined by the Permitting Bodies, to the latter in order to receive the mentioned Permission.</para>
    ///   <a href="https://w3id.org/vpa#RequestingBody">vpa:RequestingBody</a>
    /// </summary>
    let RequestingBody = _prefixId.prefix "RequestingBody"
    /// <summary>
    ///   <para>skos:editorialNote : ERA has the list of TSIs as instances of this class to be released as reference data in RDF</para>
    ///   <para>rdfs:label : Requirement</para>
    ///   <para>rdfs:comment : A legal/standardised collection of rules, which must be verified independently to be met in the context of a Permission Request, and of which the measure of compliance is expressed in EvidenceDocuments, with or without added Restrictions.</para>
    ///   <a href="https://w3id.org/vpa#Requirement">vpa:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
    /// <summary>
    ///   <para>rdfs:label : Restriction</para>
    ///   <para>rdfs:comment : Issued by an Appropriate Body in connection with its (documented) evidence on a certain requirement, it contains all aspects to take into account in order to accept the Evidence as proof, enabling the scope of the Permission. It is possible that the Restriction limits the Permission in the same way.</para>
    ///   <a href="https://w3id.org/vpa#Restriction">vpa:Restriction</a>
    /// </summary>
    let Restriction = _prefixId.prefix "Restriction"
    /// <summary>
    ///   <para>rdfs:label : Scope</para>
    ///   <para>rdfs:comment : A collection of Scopes together defining a Case. Scope is mostly the specific material object of the Case, where the Case groups them together.</para>
    ///   <a href="https://w3id.org/vpa#Scope">vpa:Scope</a>
    /// </summary>
    let Scope = _prefixId.prefix "Scope"
    /// <summary>
    ///   <para>rdfs:label : certifies</para>
    ///   <para>rdfs:comment : within its accredited competencies, can express an opinion whether a (legal or standardized) requirement is met. This relation must be accompanied by Evidence(Document) to formalize this opinion and eventually Restrictions if it is met only partially.</para>
    ///   <a href="https://w3id.org/vpa#certifies">vpa:certifies</a>
    /// </summary>
    let certifies = _prefixId.prefix "certifies"
    /// <summary>
    ///   <para>skos:editorialNote : Use `statesCompliance` for the relation Evidence -- Compliance`</para>
    ///   <para>rdfs:label : checked compliance</para>
    ///   <para>rdfs:comment : The Compliance checks having been documented by the Appropriate Body in the EvidenceDocument.</para>
    ///   <a href="https://w3id.org/vpa#checkedCompliance">vpa:checkedCompliance</a>
    /// </summary>
    let checkedCompliance = _prefixId.prefix "checkedCompliance"
    /// <summary>
    ///   <para>rdfs:label : checked requirement</para>
    ///   <para>rdfs:comment : For a Compliance check, the Requirement which was (globally or in part) checked by the Appropriate Body.</para>
    ///   <a href="https://w3id.org/vpa#checkedRequirement">vpa:checkedRequirement</a>
    /// </summary>
    let checkedRequirement = _prefixId.prefix "checkedRequirement"
    /// <summary>
    ///   <para>rdfs:label : checked section</para>
    ///   <para>rdfs:comment : For a Compliance check, the section of the Requirement which was individually checked by the Appropriate Body. The sections in scope of the verification are registered under each Requirement itself.</para>
    ///   <a href="https://w3id.org/vpa#checkedSection">vpa:checkedSection</a>
    /// </summary>
    let checkedSection = _prefixId.prefix "checkedSection"
    /// <summary>
    ///   <para>rdfs:label : closes</para>
    ///   <para>rdfs:comment : within the accredited competencies of the issuer of the EvidenceDocument, confirms that the evidence shown in the context of the Requirement was (not, partially or fully) fulfilled, where needed in presence of a Restriction.</para>
    ///   <a href="https://w3id.org/vpa#closes">vpa:closes</a>
    /// </summary>
    let closes = _prefixId.prefix "closes"
    /// <summary>
    ///   <para>rdfs:label : concerns</para>
    ///   <para>rdfs:comment : holds as material content, constitutes, embodies the material components of the Scope.</para>
    ///   <a href="https://w3id.org/vpa#concerns">vpa:concerns</a>
    /// </summary>
    let concerns = _prefixId.prefix "concerns"
    /// <summary>
    ///   <para>rdfs:label : constituted by</para>
    ///   <para>rdfs:comment : holds as a complete, independent, possibly sole part, embodies as one element of potentially more</para>
    ///   <a href="https://w3id.org/vpa#constitutedBy">vpa:constitutedBy</a>
    /// </summary>
    let constitutedBy = _prefixId.prefix "constitutedBy"
    /// <summary>
    ///   <para>rdfs:label : constitutes</para>
    ///   <para>rdfs:comment : is part of, inherently constitutesrdfs:comment : forms a complete, independent, possibly sole part of a request</para>
    ///   <a href="https://w3id.org/vpa#constitutes">vpa:constitutes</a>
    /// </summary>
    let constitutes = _prefixId.prefix "constitutes"
    /// <summary>
    ///   <para>rdfs:label : defines case</para>
    ///   <para>rdfs:comment : Inverse property of `vpa:concerns`. Is covered by, included in</para>
    ///   <a href="https://w3id.org/vpa#definesCase">vpa:definesCase</a>
    /// </summary>
    let definesCase = _prefixId.prefix "definesCase"
    /// <summary>
    ///   <para>rdfs:label : delivers</para>
    ///   <para>rdfs:comment : within its accredited mandate, issues in a traceable and qualitative manner for reuse in a Permission process</para>
    ///   <a href="https://w3id.org/vpa#delivers">vpa:delivers</a>
    /// </summary>
    let delivers = _prefixId.prefix "delivers"
    /// <summary>
    ///   <para>rdfs:label : grants</para>
    ///   <para>rdfs:comment : within its legally recognized mandate, issues, delivers in a traceable and qualitative manner, such that the receiver is able to act within the authorisation cases and its verified documentation</para>
    ///   <a href="https://w3id.org/vpa#grants">vpa:grants</a>
    /// </summary>
    let grants = _prefixId.prefix "grants"
    /// <summary>
    ///   <para>rdfs:label : is compliant</para>
    ///   <para>rdfs:comment : For the verified section of a Requirement: true when fully compliant, false in other cases (in which a clarifying Restriction is possible)</para>
    ///   <a href="https://w3id.org/vpa#isCompliant">vpa:isCompliant</a>
    /// </summary>
    let isCompliant = _prefixId.prefix "isCompliant"
    /// <summary>
    ///   <para>rdfs:label : issues</para>
    ///   <para>rdfs:comment : transmits with the intention to be allowed to act according to a legally verified process</para>
    ///   <a href="https://w3id.org/vpa#issues">vpa:issues</a>
    /// </summary>
    let issues = _prefixId.prefix "issues"
    /// <summary>
    ///   <para>rdfs:label : permission type</para>
    ///   <para>rdfs:comment : the detailed process which constitutes this Case's permission conditions</para>
    ///   <a href="https://w3id.org/vpa#permissionType">vpa:permissionType</a>
    /// </summary>
    let permissionType = _prefixId.prefix "permissionType"
    /// <summary>
    ///   <para>skos:example : For an ECM Certificate, vpa:permits will link to the OrganisationalRole 'ECM'
    ///                       </para>
    ///   <para>rdfs:label : permits</para>
    ///   <para>rdfs:comment : the process, activity, role or other scope which the Permission allows to the Requesting Body to execute or hold</para>
    ///   <a href="https://w3id.org/vpa#permits">vpa:permits</a>
    /// </summary>
    let permits = _prefixId.prefix "permits"
    /// <summary>
    ///   <para>skos:scopeNote : The linked requirement URI must remain consistent with the Compliance check, if both are used. This property should be used if no trace of a Compliance check is present, apart from the checked Requirement itself.</para>
    ///   <para>rdfs:label : regarding</para>
    ///   <para>rdfs:comment : belonging to, and when being respected, then also fulfilling</para>
    ///   <a href="https://w3id.org/vpa#regarding">vpa:regarding</a>
    /// </summary>
    let regarding = _prefixId.prefix "regarding"
    /// <summary>
    ///   <para>rdfs:label : request for</para>
    ///   <para>rdfs:comment : aiming to be enabled to act as covered by the Permission and its conditions, by receiving</para>
    ///   <a href="https://w3id.org/vpa#requestFor">vpa:requestFor</a>
    /// </summary>
    let requestFor = _prefixId.prefix "requestFor"
    /// <summary>
    ///   <para>rdfs:label : requested in</para>
    ///   <para>rdfs:comment : aiming to be enabled to act as covered by the Permission and its conditions, by issuing</para>
    ///   <a href="https://w3id.org/vpa#requestedIn">vpa:requestedIn</a>
    /// </summary>
    let requestedIn = _prefixId.prefix "requestedIn"
    /// <summary>
    ///   <para>rdfs:label : requests</para>
    ///   <para>rdfs:comment : aims to be allowed to act according to a legally verified process, by receiving</para>
    ///   <a href="https://w3id.org/vpa#requests">vpa:requests</a>
    /// </summary>
    let requests = _prefixId.prefix "requests"
    /// <summary>
    ///   <para>rdfs:label : sections</para>
    ///   <para>rdfs:comment : section(s) of the requirement to which individual compliance can be registered by the Appropriate Body</para>
    ///   <a href="https://w3id.org/vpa#section">vpa:section</a>
    /// </summary>
    let section = _prefixId.prefix "section"
    /// <summary>
    ///   <para>rdfs:label : states compliance</para>
    ///   <para>rdfs:comment : stating, through a collective set of evidence providing documents, a (non)compliance, instantiated as a `vpa:Compliance`</para>
    ///   <a href="https://w3id.org/vpa#statesCompliance">vpa:statesCompliance</a>
    /// </summary>
    let statesCompliance = _prefixId.prefix "statesCompliance"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:comment : the status of the Request as it is being treated by the PermittingBody</para>
    ///   <a href="https://w3id.org/vpa#status">vpa:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>skos:altLabel : supports Request</para>
    ///   <para>rdfs:label : submitted for</para>
    ///   <para>rdfs:comment : supporting, holding evidence of compliance in order to enable the Permitting Body to verify and permit</para>
    ///   <a href="https://w3id.org/vpa#submittedFor">vpa:submittedFor</a>
    /// </summary>
    let submittedFor = _prefixId.prefix "submittedFor"
    /// <summary>
    ///   <para>rdfs:label : submitted in</para>
    ///   <para>rdfs:comment : The submission of a permission or evidence to a case</para>
    ///   <a href="https://w3id.org/vpa#submittedIn">vpa:submittedIn</a>
    /// </summary>
    let submittedIn = _prefixId.prefix "submittedIn"
    /// <summary>
    ///   <para>rdfs:label : supports</para>
    ///   <para>rdfs:comment : super property for the different targets of supporting evidence: the scope, a case or the full request</para>
    ///   <a href="https://w3id.org/vpa#supports">vpa:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : supports case</para>
    ///   <para>rdfs:comment : supporting, as a collective set of evidence providing documents, a specific case, as such also supporting the request</para>
    ///   <a href="https://w3id.org/vpa#supportsCase">vpa:supportsCase</a>
    /// </summary>
    let supportsCase = _prefixId.prefix "supportsCase"
    /// <summary>
    ///   <para>rdfs:label : supports scope</para>
    ///   <para>rdfs:comment : supporting, as a collective set of evidence providing documents, a specific, material scope within a case, as such also supporting the request</para>
    ///   <a href="https://w3id.org/vpa#supportsScope">vpa:supportsScope</a>
    /// </summary>
    let supportsScope = _prefixId.prefix "supportsScope"
    /// <summary>
    ///   <para>skos:scopeNote : The validity of Evidence should be based on the validity limits of the EvidenceDocuments it is constitutedBy.
    /// The validity of a Permission (checked e.g. with SHACL) should also be consistent with the validity of the underlying Evidence.</para>
    ///   <para>rdfs:label : valid</para>
    ///   <para>rdfs:comment : valid during a certain time</para>
    ///   <a href="https://w3id.org/vpa#valid">vpa:valid</a>
    /// </summary>
    let valid = _prefixId.prefix "valid"
    /// <summary>
    ///   <para>rdfs:label : version number</para>
    ///   <para>rdfs:comment : An integer representing any sequence number of a version of an EvidenceDocument. Subsequent EvidenceDocuments SHOULD use `dcterms:isReplacedBy` and `dcterms:replaces` to indicate their relation.</para>
    ///   <a href="https://w3id.org/vpa#versionNumber">vpa:versionNumber</a>
    /// </summary>
    let versionNumber = _prefixId.prefix "versionNumber"
    /// <summary>
    ///   <para>skos:scopeNote : Only Compliance checks and specific EvidenceDocuments are precise enough to form the basis of a Restriction. Therefore, Evidence itself cannot directly link to a Restriction</para>
    ///   <para>rdfs:label : with restriction</para>
    ///   <para>rdfs:comment : when taken into account in the final act to be permitted, can be accepted under the condition that the conditions of the Restriction are fully answered to</para>
    ///   <a href="https://w3id.org/vpa#withRestriction">vpa:withRestriction</a>
    /// </summary>
    let withRestriction = _prefixId.prefix "withRestriction"
