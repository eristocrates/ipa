#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-org`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Organizations/" "cmns-org"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : capability^^xsd:string</para>
    ///   <para>skos:definition : ability to perform a specific function or achieve a particular outcome^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Business Architecture Core Metamodel, https://www.omg.org/spec/BACM^^xsd:stringcmns-av:adaptedFrom : The TOGAF Standard, https://pubs.opengroup.org/togaf-standard/business-architecture/business-capability-planning.html^^xsd:stringcmns-av:adaptedFrom : Value Delivery Modeling Language Specification, https://www.omg.org/spec/VDML^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Capabilities are described in terms of outcomes as well as the roles involved in achieving those outcomes. The ability for an organization to perform or provide some capability may involve people with particular skills and knowledge, intellectual property, defined practices, operating facilities, tools and equipment.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/Capability">cmns-org:Capability</a>
    /// </summary>
    let Capability = _prefixId.prefix "Capability"
    /// <summary>
    ///   <para>rdfs:label : capacity^^xsd:string</para>
    ///   <para>skos:definition : maximum extent to which something or someone can perform a function or produce an output under specified conditions^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In contrast with capability, the concept of capacity is constrained by upper limits on resources including time and within some context, in addition to having the ability to do so if circumstances allow.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/Capacity">cmns-org:Capacity</a>
    /// </summary>
    let Capacity = _prefixId.prefix "Capacity"
    /// <summary>
    ///   <para>rdfs:label : formal organisationrdfs:label : formal organization</para>
    ///   <para>skos:definition : organization that is recognized in some legal jurisdiction, with associated rights and responsibilities^^xsd:string</para>
    ///   <para>skos:example : Examples include a corporation, charity, government or church.^^xsd:string</para>
    ///   <para>skos:prefLabel : formal organization^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.w3.org/TR/vocab-org/#class-formalorganization^^xsd:anyURI</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/FormalOrganization">cmns-org:FormalOrganization</a>
    /// </summary>
    let FormalOrganization = _prefixId.prefix "FormalOrganization"
    /// <summary>
    ///   <para>rdfs:label : informal organisationrdfs:label : informal organization</para>
    ///   <para>skos:definition : group of individuals who come together for a common purpose without forming a legal entity^^xsd:string</para>
    ///   <para>skos:prefLabel : informal organization^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A bridge club with officers and a bank account can be classified as an informal organization, but it depends on how the club is structured and whether it has taken steps to formalize its existence. If the bridge club has officers and a bank account but has not incorporated or registered as a legal entity (like a nonprofit organization or a corporation), it would be considered an informal organization. The officers manage the club's affairs, and the bank account is likely opened under the names of the officers or with the designation 'on behalf of the bridge club'.^^xsd:stringcmns-av:explanatoryNote : There is usually no formal registration with governmental authorities, and the group operates based on mutual agreement among its members rather than a formal legal structure.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/InformalOrganization">cmns-org:InformalOrganization</a>
    /// </summary>
    let InformalOrganization = _prefixId.prefix "InformalOrganization"
    /// <summary>
    ///   <para>rdfs:label : legal entity^^xsd:string</para>
    ///   <para>skos:definition : legal person that is a partnership, corporation, or other organization having the capacity to negotiate contracts, assume financial obligations, and pay off debts, organized under the laws of some jurisdiction^^xsd:string</para>
    ///   <para>skos:scopeNote : The term 'legal entity' includes, but is not limited to, unique parties that are legally or financially responsible for the performance of financial transactions or have the legal right in their jurisdiction to enter independently into legal contracts, regardless of whether they are incorporated or constituted in some other way (e.g. trust, partnership, contractual). It excludes natural persons, but includes governmental organizations and supranationals.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 17442, Financial services - Legal Entity Identifier (LEI), first edition, 2012-06-01, section 3.1^^xsd:string</para>
    ///   <para>cmns-av:synonym : artificial person^^xsd:stringcmns-av:synonym : juridical entity^^xsd:stringcmns-av:synonym : juridical person^^xsd:stringcmns-av:synonym : juristic person^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/LegalEntity">cmns-org:LegalEntity</a>
    /// </summary>
    let LegalEntity = _prefixId.prefix "LegalEntity"
    /// <summary>
    ///   <para>rdfs:label : legal person</para>
    ///   <para>skos:definition : party that is recognized as having rights and obligations under the law, including but not limited to the right to sue and be sued, enter into contracts, own property, and incur financial and other obligations^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : To have legal personality means to be capable of having legal rights and duties within a certain legal system, such as to enter into contracts, sue, and be sued. Legal personality is a prerequisite to legal capacity, the ability of any legal person to amend (enter into, transfer, etc.) rights and obligations.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/LegalPerson">cmns-org:LegalPerson</a>
    /// </summary>
    let LegalPerson = _prefixId.prefix "LegalPerson"
    /// <summary>
    ///   <para>rdfs:label : member-bearing organization^^xsd:string</para>
    ///   <para>skos:definition : role of a group or organization that has members that are people or other organizations^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/MemberBearingOrganization">cmns-org:MemberBearingOrganization</a>
    /// </summary>
    let MemberBearingOrganization = _prefixId.prefix "MemberBearingOrganization"
    /// <summary>
    ///   <para>rdfs:label : membership</para>
    ///   <para>skos:definition : situation, corresponding to an n-ary relation, in which some group or organization has at least one member (person or organization) for some period of time^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/Membership">cmns-org:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>rdfs:label : organisationrdfs:label : organization</para>
    ///   <para>skos:definition : framework of authority within which a person, persons, or groups of people act, or are designated to act, towards some purpose, such as to meet a need or pursue collective goals^^xsd:string</para>
    ///   <para>skos:example : This may be a business entity, government, international organization, not-for-profit, academic institution, or other unincorporated and/or informal social organization.^^xsd:string</para>
    ///   <para>skos:prefLabel : organization^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 6523-1:1998 Information technology — Structure for the identification of organizations and organization parts — Part 1: Identification of organization identification schemes, https://www.iso.org/obp/ui/#iso:std:iso-iec:6523:-1:ed-1:v1:en^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/Organization">cmns-org:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"

    /// <summary>
    ///   <para>rdfs:label : organization identification scheme^^xsd:string</para>
    ///   <para>skos:definition : identification scheme dedicated to the unique identification of organizations^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 6523-1:1998 Information technology — Structure for the identification of organizations and organization parts — Part 1: Identification of organization identification schemes, https://www.iso.org/obp/ui/#iso:std:iso-iec:6523:-1:ed-1:v1:en^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/OrganizationIdentificationScheme">cmns-org:OrganizationIdentificationScheme</a>
    /// </summary>
    let OrganizationIdentificationScheme =
        _prefixId.prefix "OrganizationIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : organisation identifierrdfs:label : organization identifier</para>
    ///   <para>skos:definition : identifier assigned to an organization within an organization identification scheme, and unique within that scheme^^xsd:string</para>
    ///   <para>skos:prefLabel : organization identifier^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 6523-1:1998 Information technology — Structure for the identification of organizations and organization parts — Part 1: Identification of organization identification schemes, https://www.iso.org/obp/ui/#iso:std:iso-iec:6523:-1:ed-1:v1:en^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/OrganizationIdentifier">cmns-org:OrganizationIdentifier</a>
    /// </summary>
    let OrganizationIdentifier = _prefixId.prefix "OrganizationIdentifier"
    /// <summary>
    ///   <para>rdfs:label : organisation memberrdfs:label : organization member</para>
    ///   <para>skos:definition : party (person or organization) that has a membership role with respect to some organization^^xsd:string</para>
    ///   <para>skos:prefLabel : organization member^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/OrganizationMember">cmns-org:OrganizationMember</a>
    /// </summary>
    let OrganizationMember = _prefixId.prefix "OrganizationMember"
    /// <summary>
    ///   <para>rdfs:label : organisation namerdfs:label : organization name</para>
    ///   <para>skos:definition : designation by which some organization is known in some context^^xsd:string</para>
    ///   <para>skos:prefLabel : organization name^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/OrganizationName">cmns-org:OrganizationName</a>
    /// </summary>
    let OrganizationName = _prefixId.prefix "OrganizationName"
    /// <summary>
    ///   <para>rdfs:label : organisation sub-unit identifierrdfs:label : organization sub-unit identifier</para>
    ///   <para>skos:definition : identifier allocated to a particular organizational sub-unit^^xsd:string</para>
    ///   <para>skos:prefLabel : organization sub-unit identifier^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : OPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 6523-1:1998 Information technology — Structure for the identification of organizations and organization parts — Part 1: Identification of organization identification schemes, https://www.iso.org/obp/ui/#iso:std:iso-iec:6523:-1:ed-1:v1:en^^xsd:string</para>
    ///   <para>cmns-av:synonym : organization part identifier^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/OrganizationSubUnitIdentifier">cmns-org:OrganizationSubUnitIdentifier</a>
    /// </summary>
    let OrganizationSubUnitIdentifier = _prefixId.prefix "OrganizationSubUnitIdentifier"
    /// <summary>
    ///   <para>rdfs:label : organisational sub-unitrdfs:label : organizational sub-unit</para>
    ///   <para>skos:definition : any department or other entity within a larger organization that only has full recognition within the context of that organization, but requires identification for some purpose^^xsd:string</para>
    ///   <para>skos:prefLabel : organizational sub-unit^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 6523-1:1998 Information technology — Structure for the identification of organizations and organization parts — Part 1: Identification of organization identification schemes, https://www.iso.org/obp/ui/#iso:std:iso-iec:6523:-1:ed-1:v1:en^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In other words, it is not a legal entity in its own right.^^xsd:string</para>
    ///   <para>cmns-av:synonym : organization part^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/OrganizationalSubUnit">cmns-org:OrganizationalSubUnit</a>
    /// </summary>
    let OrganizationalSubUnit = _prefixId.prefix "OrganizationalSubUnit"
    /// <summary>
    ///   <para>rdfs:label : service^^xsd:string</para>
    ///   <para>skos:definition : intangible activity performed by some party for the benefit of another party^^xsd:string</para>
    ///   <para>skos:example : Services include intangible products, such as accounting, banking, cleaning, consultancy, education, insurance, expertise, medical treatment, or transportation services.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Sometimes services are difficult to identify because they are closely associated with a good; such as the combination of a diagnosis with the administration of a medicine. No transfer of possession or ownership takes place when services are sold, and they (1) cannot be stored or transported, (2) are instantly perishable, and (3) come into existence at the time they are bought and consumed.^^xsd:stringcmns-av:explanatoryNote : The OECD defines services as outputs produced to order and which cannot be traded separately from their production; ownership rights cannot be established over services and by the time their production is completed they must have been provided to the consumers. As an exception to this rule there is a group of industries, generally classified as service industries, some of whose outputs have characteristics of goods, i.e. those concerned with the provision, storage, communication and dissemination of information, advice and entertainment in the broadest sense of those terms; the products of these industries, where ownership rights can be established, may be classified either as goods or services depending on the medium by which these outputs are supplied.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/Service">cmns-org:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : service provider^^xsd:string</para>
    ///   <para>skos:definition : role of an agent that provides some service, including but not limited to commercial or professional services^^xsd:string</para>
    ///   <para>skos:example : Example services may include consulting, financial, legal, real estate, education, communications, registration, regulatory, manufacturing, storage, processing, or other services.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/ServiceProvider">cmns-org:ServiceProvider</a>
    /// </summary>
    let ServiceProvider = _prefixId.prefix "ServiceProvider"
    /// <summary>
    ///   <para>rdfs:label : designates^^xsd:string</para>
    ///   <para>skos:definition : appoints someone officially^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This property is intended to cover assigning a job or role to someone, selecting or designating someone to fill an office or a position, and fixing or setting by authority or by mutual agreement.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/designates">cmns-org:designates</a>
    /// </summary>
    let designates = _prefixId.prefix "designates"
    /// <summary>
    ///   <para>rdfs:label : has membership^^xsd:string</para>
    ///   <para>skos:definition : identifies the organization acting in the role of having members in an organizational membership situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/hasMembership">cmns-org:hasMembership</a>
    /// </summary>
    let hasMembership = _prefixId.prefix "hasMembership"
    /// <summary>
    ///   <para>rdfs:label : has organization member^^xsd:string</para>
    ///   <para>skos:definition : indicates the party acting in the role of the member in an organizational membership situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/hasOrganizationMember">cmns-org:hasOrganizationMember</a>
    /// </summary>
    let hasOrganizationMember = _prefixId.prefix "hasOrganizationMember"
    /// <summary>
    ///   <para>rdfs:label : has sub-unit^^xsd:string</para>
    ///   <para>skos:definition : relates an organization to a part of that organization^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/hasSubUnit">cmns-org:hasSubUnit</a>
    /// </summary>
    let hasSubUnit = _prefixId.prefix "hasSubUnit"
    /// <summary>
    ///   <para>rdfs:label : has URL^^xsd:string</para>
    ///   <para>skos:definition : links something to a web resource that specifies its location on a computer network and a method for retrieving it^^xsd:string</para>
    ///   <para>cmns-av:synonym : has uniform resource locator^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/hasURL">cmns-org:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>rdfs:label : has website^^xsd:string</para>
    ///   <para>skos:definition : links something to a page or set of related web pages located under a single domain name, typically produced by a single person or organization^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Web Design and Applications involve the standards for building and Rendering Web pages, including HTML, CSS, SVG, device APIs, and other technologies for Web Applications ('WebApps'). HTML (the Hypertext Markup Language) and CSS (Cascading Style Sheets) are two of the core technologies for building Web pages. HTML provides the structure of the page, CSS the (visual and aural) layout, for a variety of devices and services.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/hasWebsite">cmns-org:hasWebsite</a>
    /// </summary>
    let hasWebsite = _prefixId.prefix "hasWebsite"
    /// <summary>
    ///   <para>rdfs:label : is designated by^^xsd:string</para>
    ///   <para>skos:definition : indicates the role of the party that has assigned or appointed someone to an office or position^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isDesignatedBy">cmns-org:isDesignatedBy</a>
    /// </summary>
    let isDesignatedBy = _prefixId.prefix "isDesignatedBy"
    /// <summary>
    ///   <para>rdfs:label : is domiciled in^^xsd:string</para>
    ///   <para>skos:definition : indicates the principal place where an entity conducts business within some country, such as where its headquarters is located^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Corporate domicile refers to a place where a company's affairs are discharged. It is also typically the legal home of a corporation within a country because the place is considered by law as the center of corporate affairs. In cases where a business has incorporated in one location for convenience, such as for taxation, legal, or regulatory purposes, but operates primarily in one or more other locations, domicile refers to the operational location(s) rather than legal location. Many companies in the US have incorporated in the State of Delaware, for example, but do not have operational facilities in Delaware (or only have small offices there).^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isDomiciledIn">cmns-org:isDomiciledIn</a>
    /// </summary>
    let isDomiciledIn = _prefixId.prefix "isDomiciledIn"
    /// <summary>
    ///   <para>rdfs:label : is managed by^^xsd:string</para>
    ///   <para>skos:definition : indicates the role of a party that directs the affairs or administration of something or someone^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isManagedBy">cmns-org:isManagedBy</a>
    /// </summary>
    let isManagedBy = _prefixId.prefix "isManagedBy"
    /// <summary>
    ///   <para>rdfs:label : is membership party in^^xsd:string</para>
    ///   <para>skos:definition : indicates the membership situation in which the party plays the role of having members^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isMembershipPartyIn">cmns-org:isMembershipPartyIn</a>
    /// </summary>
    let isMembershipPartyIn = _prefixId.prefix "isMembershipPartyIn"
    /// <summary>
    ///   <para>rdfs:label : is organization member^^xsd:string</para>
    ///   <para>skos:definition : indicates the context of membership in which the party plays the role of an organization member^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isOrganizationMember">cmns-org:isOrganizationMember</a>
    /// </summary>
    let isOrganizationMember = _prefixId.prefix "isOrganizationMember"
    /// <summary>
    ///   <para>rdfs:label : is provided by^^xsd:string</para>
    ///   <para>skos:definition : is made available by^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isProvidedBy">cmns-org:isProvidedBy</a>
    /// </summary>
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    /// <summary>
    ///   <para>rdfs:label : is provided to^^xsd:string</para>
    ///   <para>skos:definition : is made available to^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isProvidedTo">cmns-org:isProvidedTo</a>
    /// </summary>
    let isProvidedTo = _prefixId.prefix "isProvidedTo"
    /// <summary>
    ///   <para>rdfs:label : is sub-unit of^^xsd:string</para>
    ///   <para>skos:definition : relates a part of an organization to the larger entity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/isSubUnitOf">cmns-org:isSubUnitOf</a>
    /// </summary>
    let isSubUnitOf = _prefixId.prefix "isSubUnitOf"
    /// <summary>
    ///   <para>rdfs:label : manages^^xsd:string</para>
    ///   <para>skos:definition : relates a party role to something or someone that it directs or administers in some way^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/manages">cmns-org:manages</a>
    /// </summary>
    let manages = _prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:label : provides^^xsd:string</para>
    ///   <para>skos:definition : makes available^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Organizations/provides">cmns-org:provides</a>
    /// </summary>
    let provides = _prefixId.prefix "provides"
