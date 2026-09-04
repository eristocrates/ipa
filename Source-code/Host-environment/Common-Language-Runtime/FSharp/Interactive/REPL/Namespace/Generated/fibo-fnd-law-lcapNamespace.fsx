#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-law-lcap`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/" "fibo-fnd-law-lcap"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : claim</para>
    ///   <para>skos:definition : demand or assertion made by one party on another, based on facts that, taken together, give rise to a legally enforceable right or judicial action^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Claims arise from the existence of a formal commitment between the parties or as implicitly agreed upon through the operation of law or constitution.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Claim">fibo-fnd-law-lcap:Claim</a>
    /// </summary>
    let Claim = _prefixId.prefix "Claim"
    /// <summary>
    ///   <para>rdfs:label : contingent obligation</para>
    ///   <para>skos:definition : obligation that depends on a future event or the performance of an action^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentObligation">fibo-fnd-law-lcap:ContingentObligation</a>
    /// </summary>
    let ContingentObligation = _prefixId.prefix "ContingentObligation"
    /// <summary>
    ///   <para>rdfs:label : contingent right</para>
    ///   <para>skos:definition : right that depends on a future event or the performance of an action^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Contingent means that the interest, claim, or right is conditional, realized only when and if something occurs.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentRight">fibo-fnd-law-lcap:ContingentRight</a>
    /// </summary>
    let ContingentRight = _prefixId.prefix "ContingentRight"
    /// <summary>
    ///   <para>rdfs:label : contractual capability</para>
    ///   <para>skos:definition : the capacity to enter into legally binding contracts^^xsd:string</para>
    ///   <para>skos:editorialNote : This is the capacity which defines Contractually Capable Entity (sometimes labeled as 'Legal Entity') as distinct from 'Legal Person'. In the latter case the liabilities incurred in the contract accrue also to the Legal Person. In the case of contractual capability, the entity has the authority to enter into contracts, whether or not the liabilities accrue to that same entity (which they do if it is also a Legal Person). For Legal Entities which are not Legal Persons, the liability unwinds to some legal person within the structure of the entity, for example a General Partner or a Trustee.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualCapability">fibo-fnd-law-lcap:ContractualCapability</a>
    /// </summary>
    let ContractualCapability = _prefixId.prefix "ContractualCapability"
    /// <summary>
    ///   <para>rdfs:label : contractual interest^^xsd:string</para>
    ///   <para>skos:definition : legally enforceable benefit or entitlement arising from a contract, agreement, or instrument, in which an entity holds specified rights or obligations related to the performance, use, or benefit of something, without necessarily holding ownership^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Contractual interest may include rights to income, access, use, or participation, and is governed by the terms and conditions of the underlying contract. It may be transferable or limited, and can coexist with or be independent of ownership rights.^^xsd:stringcmns-av:explanatoryNote : Contractual interests differ from ownership interests in terms of (1) the source of rights, which are specified in an agreement or contract in the case of contractual interests, and in terms of title or equity with respect to ownership, (2) control, which is typically limited at best in the case of contractual interest, and (3) transferability, which depends on the terms of the contract. Examples of contractual interest include fund units, leaseholds, annuities, and rights to certain services, whereas shares, real estate, and assets of a trust reflect ownership interest.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualInterest">fibo-fnd-law-lcap:ContractualInterest</a>
    /// </summary>
    let ContractualInterest = _prefixId.prefix "ContractualInterest"
    /// <summary>
    ///   <para>rdfs:label : contractual obligation^^xsd:string</para>
    ///   <para>skos:definition : legally binding obligation that arises from the terms of a contract^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Contractual obligations require a party to perform or refrain from performing specific actions, and failure to meet an obligation can result in legal consequences.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualObligation">fibo-fnd-law-lcap:ContractualObligation</a>
    /// </summary>
    let ContractualObligation = _prefixId.prefix "ContractualObligation"
    /// <summary>
    ///   <para>rdfs:label : contractual option^^xsd:string</para>
    ///   <para>skos:definition : contractual right that may be exercised at some point in the future, such as an option to extend a contract, or other available but not obligatory rights as defined in the contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualOption">fibo-fnd-law-lcap:ContractualOption</a>
    /// </summary>
    let ContractualOption = _prefixId.prefix "ContractualOption"
    /// <summary>
    ///   <para>rdfs:label : contractual right^^xsd:string</para>
    ///   <para>skos:definition : legally enforceable benefit or entitlement granted to a party within a binding agreement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Contractual rights are established by the terms of a contract, which can be explicit (written) or implied by law, industry standards, or consistent practices.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualRight">fibo-fnd-law-lcap:ContractualRight</a>
    /// </summary>
    let ContractualRight = _prefixId.prefix "ContractualRight"
    /// <summary>
    ///   <para>rdfs:label : delegated legal authority^^xsd:string</para>
    ///   <para>skos:definition : institutionalized and legal power inherent in a particular job, function, or position that is meant to enable its holder to successfully carry out his or her responsibilities, where such power has been delegated through some formal means^^xsd:string</para>
    ///   <para>skos:scopeNote : This specifically means the authority to make legally binding commitments.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is always accompanied by an equal responsibility for one's actions or a failure to act.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DelegatedLegalAuthority">fibo-fnd-law-lcap:DelegatedLegalAuthority</a>
    /// </summary>
    let DelegatedLegalAuthority = _prefixId.prefix "DelegatedLegalAuthority"
    /// <summary>
    ///   <para>rdfs:label : delivery obligation</para>
    ///   <para>skos:definition : obligation to deliver something in order to satisfy a claim or debt</para>
    ///   <para>cmns-av:explanatoryNote : A delivery obligation is the responsibility of one party to deliver goods, services, instruments, money, or other specified items to another party, typically as outlined in an agreement. Failure to do so may result in breach of contract if the obligation is specified as such, which may have further legal ramifications.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DeliveryObligation">fibo-fnd-law-lcap:DeliveryObligation</a>
    /// </summary>
    let DeliveryObligation = _prefixId.prefix "DeliveryObligation"
    /// <summary>
    ///   <para>rdfs:label : duty^^xsd:string</para>
    ///   <para>skos:definition : some obligation which exists and is imposed on some individual^^xsd:string</para>
    ///   <para>skos:editorialNote : This can also be thought of as an obligation - not in the sense in which an obligation and a right are the converse aspects of one another, but in and of itself, independent of the perspective from which it is considered. Examples include statutory obligations, reporting obligations and so on.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Duty">fibo-fnd-law-lcap:Duty</a>
    /// </summary>
    let Duty = _prefixId.prefix "Duty"
    /// <summary>
    ///   <para>rdfs:label : legal capacity^^xsd:string</para>
    ///   <para>skos:definition : the capability to carry out certain actions or to have certain rights together with the resources to do so^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalCapacity">fibo-fnd-law-lcap:LegalCapacity</a>
    /// </summary>
    let LegalCapacity = _prefixId.prefix "LegalCapacity"
    /// <summary>
    ///   <para>rdfs:label : legal construct^^xsd:string</para>
    ///   <para>skos:definition : something which is conferred by way of law or contract, such as a right^^xsd:string</para>
    ///   <para>skos:editorialNote : Obligations are an aspect of this category of thing, as are rights.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalConstruct">fibo-fnd-law-lcap:LegalConstruct</a>
    /// </summary>
    let LegalConstruct = _prefixId.prefix "LegalConstruct"
    /// <summary>
    ///   <para>rdfs:label : legal obligation^^xsd:string</para>
    ///   <para>skos:definition : an obligation or duty that is enforceable by a court^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalObligation">fibo-fnd-law-lcap:LegalObligation</a>
    /// </summary>
    let LegalObligation = _prefixId.prefix "LegalObligation"
    /// <summary>
    ///   <para>rdfs:label : legal right^^xsd:string</para>
    ///   <para>skos:definition : personal right, privilege, or benefit that a government, contract, or law provides or protects, making an individual or entity eligible to receive something^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A legal right, if challenged, may be supported in court as recognizable and enforceable in law, statutes, regulations, or other legislative actions.^^xsd:stringcmns-av:explanatoryNote : This entitlement creates a corresponding obligation for the provider to deliver that benefit.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalRight">fibo-fnd-law-lcap:LegalRight</a>
    /// </summary>
    let LegalRight = _prefixId.prefix "LegalRight"
    /// <summary>
    ///   <para>rdfs:label : liability capacity</para>
    ///   <para>skos:definition : the ability to be sued at law^^xsd:string</para>
    ///   <para>skos:editorialNote : Note that for the purposes of this model, this is distinct from culpability (the ability to commit criminal acts). That would be a separate and analogous term but with grounding in criminal rather than civil law.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LiabilityCapacity">fibo-fnd-law-lcap:LiabilityCapacity</a>
    /// </summary>
    let LiabilityCapacity = _prefixId.prefix "LiabilityCapacity"
    /// <summary>
    ///   <para>rdfs:label : license^^xsd:string</para>
    ///   <para>skos:definition : grant of permission needed to do something^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economics Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that in some cases, a license may also be considered an agreement or contract, depending on the specifics of the license and jurisdiction.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/License">fibo-fnd-law-lcap:License</a>
    /// </summary>
    let License = _prefixId.prefix "License"
    /// <summary>
    ///   <para>rdfs:label : license identifier^^xsd:string</para>
    ///   <para>skos:definition : an identifier associated with a license^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LicenseIdentifier">fibo-fnd-law-lcap:LicenseIdentifier</a>
    /// </summary>
    let LicenseIdentifier = _prefixId.prefix "LicenseIdentifier"
    /// <summary>
    ///   <para>rdfs:label : licensee^^xsd:string</para>
    ///   <para>skos:definition : a party to whom a license has been granted^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economics Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensee">fibo-fnd-law-lcap:Licensee</a>
    /// </summary>
    let Licensee = _prefixId.prefix "Licensee"
    /// <summary>
    ///   <para>rdfs:label : licensor^^xsd:string</para>
    ///   <para>skos:definition : a party who grants a license^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economics Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensor">fibo-fnd-law-lcap:Licensor</a>
    /// </summary>
    let Licensor = _prefixId.prefix "Licensor"
    /// <summary>
    ///   <para>rdfs:label : litigation capacity^^xsd:string</para>
    ///   <para>skos:definition : the legal capacity to pursue a litigation action in law^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LitigationCapacity">fibo-fnd-law-lcap:LitigationCapacity</a>
    /// </summary>
    let LitigationCapacity = _prefixId.prefix "LitigationCapacity"
    /// <summary>
    ///   <para>rdfs:label : notification obligation</para>
    ///   <para>skos:definition : requirement for one party to formally inform another party (or parties) about specific events, actions, or changes as outlined in the agreement</para>
    ///   <para>cmns-av:explanatoryNote : Common triggering events include breaches, changes in circumstances, delays, or other kinds of events that may have a material impact on the agreement.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/NotificationObligation">fibo-fnd-law-lcap:NotificationObligation</a>
    /// </summary>
    let NotificationObligation = _prefixId.prefix "NotificationObligation"
    /// <summary>
    ///   <para>rdfs:label : policy^^xsd:string</para>
    ///   <para>skos:definition : system of principles, rules and guidelines, adopted by an organization to guide decision making with respect to particular situations and implemented via procedures or protocols to achieve stated goals^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Policy">fibo-fnd-law-lcap:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:label : regulation^^xsd:string</para>
    ///   <para>skos:definition : a rule used to carry out a law^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Many government agencies issue regulations to administer laws.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Regulation">fibo-fnd-law-lcap:Regulation</a>
    /// </summary>
    let Regulation = _prefixId.prefix "Regulation"
    /// <summary>
    ///   <para>rdfs:label : reporting policy^^xsd:string</para>
    ///   <para>skos:definition : policy specifying principles, rules and/or guidelines regarding some aspect of reporting^^xsd:string</para>
    ///   <para>skos:example : For example a policy for how frequently a given kind of report is produced.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ReportingPolicy">fibo-fnd-law-lcap:ReportingPolicy</a>
    /// </summary>
    let ReportingPolicy = _prefixId.prefix "ReportingPolicy"
    /// <summary>
    ///   <para>rdfs:label : right^^xsd:string</para>
    ///   <para>skos:definition : entitlement to perform certain actions (or not), or to be in certain states (or not); or entitlement that requires others to perform certain actions or be in certain states (or not)^^xsd:string</para>
    ///   <para>skos:example : Examples include contractual rights, legal rights, human rights, political rights, and so forth.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Rights dominate modern understandings of what actions are permissible and which institutions are just. Rights structure the form of governments, the content of laws, and the shape of morality as many now see it. To accept a set of rights is to approve a distribution of freedom and authority, and so to endorse a certain view of what may, must, and must not be done. According to the Hohfeldian incidents (Wesley Hohfeld (1879-1918)), rights are complex and consist of four major components: privilege, claim, power, and immunity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Right">fibo-fnd-law-lcap:Right</a>
    /// </summary>
    let Right = _prefixId.prefix "Right"
    /// <summary>
    ///   <para>rdfs:label : signatory capacity^^xsd:string</para>
    ///   <para>skos:definition : the capacity of some natural person to sign agreements on the part of some organization or legal person^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/SignatoryCapacity">fibo-fnd-law-lcap:SignatoryCapacity</a>
    /// </summary>
    let SignatoryCapacity = _prefixId.prefix "SignatoryCapacity"
    /// <summary>
    ///   <para>rdfs:label : has capacity^^xsd:string</para>
    ///   <para>skos:definition : identifies an individual or organization that has some ability and availability to carry out certain actions, or has certain rights or obligations^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasCapacity">fibo-fnd-law-lcap:hasCapacity</a>
    /// </summary>
    let hasCapacity = _prefixId.prefix "hasCapacity"
    /// <summary>
    ///   <para>rdfs:label : has fractional interest^^xsd:string</para>
    ///   <para>skos:definition : has proportionate, non-exclusive entitlement to^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Fractional interest may be expressed as a percentage, ratio, or unit count, and typically arises in contexts where multiple parties share contractual claims to income, usage, ownership, or participation. It does not imply full control or sole ownership, and may be subject to limitations specified in the underlying legal framework.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasFractionalInterest">fibo-fnd-law-lcap:hasFractionalInterest</a>
    /// </summary>
    let hasFractionalInterest = _prefixId.prefix "hasFractionalInterest"
    /// <summary>
    ///   <para>rdfs:label : implements^^xsd:string</para>
    ///   <para>skos:definition : carries out or puts into effect, fulfills^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implements">fibo-fnd-law-lcap:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:label : implies^^xsd:string</para>
    ///   <para>skos:definition : strongly suggests or involves as a logical consequence based on some set of observations, facts, or events^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implies">fibo-fnd-law-lcap:implies</a>
    /// </summary>
    let implies = _prefixId.prefix "implies"
    /// <summary>
    ///   <para>rdfs:label : is capacity of^^xsd:string</para>
    ///   <para>skos:definition : identifies an individual or organization on which a given legal capacity has been conferred^^xsd:string</para>
    ///   <para>skos:scopeNote : This includes capacities specific to duties at law (such as those for corporate officers) as well as the ability or capacity to incur liability.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isCapacityOf">fibo-fnd-law-lcap:isCapacityOf</a>
    /// </summary>
    let isCapacityOf = _prefixId.prefix "isCapacityOf"
    /// <summary>
    ///   <para>rdfs:label : is conferred on^^xsd:string</para>
    ///   <para>skos:definition : indicates a party to which some benefit or right has been granted^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isConferredOn">fibo-fnd-law-lcap:isConferredOn</a>
    /// </summary>
    let isConferredOn = _prefixId.prefix "isConferredOn"
    /// <summary>
    ///   <para>rdfs:label : is implemented by^^xsd:string</para>
    ///   <para>skos:definition : indicates something that is carried out, incorporated or put into effect by^^xsd:string</para>
    ///   <para>skos:example : A regulation may be implemented by or more corporate policies. Such policies, in turn, may be implemented via various systems, executed by humans and/or automation, that can be audited for compliance purposes.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImplementedBy">fibo-fnd-law-lcap:isImplementedBy</a>
    /// </summary>
    let isImplementedBy = _prefixId.prefix "isImplementedBy"
    /// <summary>
    ///   <para>rdfs:label : is implied by^^xsd:string</para>
    ///   <para>skos:definition : indicates something that is strongly suggested by something else, such as a logical consequence based on some set of observations, facts, or events^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImpliedBy">fibo-fnd-law-lcap:isImpliedBy</a>
    /// </summary>
    let isImpliedBy = _prefixId.prefix "isImpliedBy"
    /// <summary>
    ///   <para>rdfs:label : is licensed by^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that has issued a particular license to some other party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isLicensedBy">fibo-fnd-law-lcap:isLicensedBy</a>
    /// </summary>
    let isLicensedBy = _prefixId.prefix "isLicensedBy"
    /// <summary>
    ///   <para>rdfs:label : is predicated on</para>
    ///   <para>skos:definition : depends on an assumption or requirement stated in^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isPredicatedOn">fibo-fnd-law-lcap:isPredicatedOn</a>
    /// </summary>
    let isPredicatedOn = _prefixId.prefix "isPredicatedOn"
    /// <summary>
    ///   <para>rdfs:label : licenses^^xsd:string</para>
    ///   <para>skos:definition : issues a license required in order to perform some task, provide some service, exercise some privilege, or pursue some line of business or occupation to some party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/licenses">fibo-fnd-law-lcap:licenses</a>
    /// </summary>
    let licenses = _prefixId.prefix "licenses"
