#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rov =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/regorg#" "rov"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Registered Organization</para>
    ///   <para>rdfs:comment : rov:RegisteredOrganization is the key class for the Registered Organization vocabulary and represents
    ///     an organization that is legally registered. In many countries there is a single registry although in others, such
    ///     as Spain and Germany, multiple registries exist. A Registered Organization is able to trade, is legally liable for
    ///     its actions, accounts, tax affairs etc. Legal entity status is conferred by the act of registration cf.
    ///     org:FormalOrganization that applies to any legal entity, including those created by other legal means.
    ///     This makes registered organizations distinct from the broader concept of organizations, groups or, in
    ///     some jurisdictions, sole traders. Many organizations exist that are not legal entities yet to the outside world
    ///     they have staff, hierarchies, locations etc. Other organizations exist that are an umbrella for several legal entities
    ///     (universities are often good examples of this). This vocabulary is concerned solely with registered organizations.
    ///     In RDF, Registered Organization is a sub class of the Organization Ontology's org:FormalOrganization which is itself a
    ///     sub class of the more general 'Agent' class found in FOAF and Dublin Core that does encompass organizations,
    ///     natural persons, groups etc. - i.e. an Agent is any entity that is able to carry out actions.&lt;/p&gt;</para>
    ///   <para>dcterms:identifier : rov:RegisteredOrganization^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/regorg#RegisteredOrganization">rov:RegisteredOrganization</a>
    /// </summary>
    let RegisteredOrganization = _prefixId.prefix "RegisteredOrganization"
    /// <summary>
    ///   <para>rdfs:label : registered organization</para>
    ///   <para>rdfs:comment : The has registered organization relationship can be used to link any dcterms:Agent (equivalent class foaf:Agent) to a Registered Organization that in some way acts as a registered legal entity for it. This is useful, for example, where an organization includes one or more legal entities, or where a natural person is also registered as a legal entity. rov:hasRegisteredOrganization has a range of rov:RegisteredOrganization.</para>
    ///   <para>dcterms:identifier : rov:hasRegisteredOrganization^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/regorg#hasRegisteredOrganization">rov:hasRegisteredOrganization</a>
    /// </summary>
    let hasRegisteredOrganization = _prefixId.prefix "hasRegisteredOrganization"
    /// <summary>
    ///   <para>rdfs:label : legal name</para>
    ///   <para>rdfs:comment : The legal name of the business. A business might have more than one legal name, particularly in countries with more than one official language. In such cases the language of the string should be identified.</para>
    ///   <para>dcterms:identifier : rov:legalName^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/regorg#legalName">rov:legalName</a>
    /// </summary>
    let legalName = _prefixId.prefix "legalName"
    /// <summary>
    ///   <para>rdfs:label : company activity</para>
    ///   <para>rdfs:comment : The activity of a company should be recorded using a controlled vocabulary expressed as a SKOS concept scheme. Several such vocabularies exist, many of which map to the UN's ISIC codes. Where a particular controlled vocabulary is in use within a given context, such as SIC codes in the UK, it is acceptable to use these, however, the preferred choice for European interoperability is NACE. rov:orgActivity is a sub class of org:classification which has a range of skos:Concept.</para>
    ///   <para>dcterms:identifier : rov:orgActivity^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/regorg#orgActivity">rov:orgActivity</a>
    /// </summary>
    let orgActivity = _prefixId.prefix "orgActivity"
    /// <summary>
    ///   <para>rdfs:label : company status</para>
    ///   <para>rdfs:comment : Terms like insolvent, bankrupt and in receivership are likely to have different legal implications in different jurisdictions. Best Practice for recording various other status levels is to use the relevant jurisdiction's terms and to do so in a consistent manner using a SKOS Concept Scheme. rov:orgStatus is a sub class of org:classification which has a range of skos:Concept.</para>
    ///   <para>dcterms:identifier : rov:orgStatus^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/regorg#orgStatus">rov:orgStatus</a>
    /// </summary>
    let orgStatus = _prefixId.prefix "orgStatus"
    /// <summary>
    ///   <para>rdfs:label : company type</para>
    ///   <para>rdfs:comment : This property records the type of organization. Familiar types are SA, PLC, LLC, GmbH etc. Each jurisdiction will have a limited set of recognized company types and these should be used in a consistent manner using a SKOS Concept Scheme. rov:orgType is a sub class of org:classification which has a range of skos:Concept.</para>
    ///   <para>dcterms:identifier : rov:orgType^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/regorg#orgType">rov:orgType</a>
    /// </summary>
    let orgType = _prefixId.prefix "orgType"
    /// <summary>
    ///   <para>rdfs:label : registration</para>
    ///   <para>rdfs:comment : The registration is a fundamental relationship between a legal entity and the authority with which it is registered and that confers legal status upon it. rov:registration is a sub property of adms:identifier which has a range of adms:Identifier. rov:registration has a domain of rov:RegisteredOrganization.</para>
    ///   <para>dcterms:identifier : rov:registration^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/regorg#registration">rov:registration</a>
    /// </summary>
    let registration = _prefixId.prefix "registration"
