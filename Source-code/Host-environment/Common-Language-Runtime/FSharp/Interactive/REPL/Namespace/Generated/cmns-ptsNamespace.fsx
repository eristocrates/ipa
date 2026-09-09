#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-pts`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/PartiesAndSituations/" "cmns-pts"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : actor^^xsd:string</para>
    ///   <para>skos:definition : primary performer in a relationship between parties, i.e., the party that does something, causes something to happen, or otherwise plays an agentive role in the relationship^^xsd:string</para>
    ///   <para>skos:example : Examples include owner, controlling party, beneficiary, guarantor, partner in a partnership, shareholder, etc.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 14813-1:2015(en), Intelligent transport systems - Reference model architecture(s) for the ITS sector - Part 1: ITS service domains, service groups and services, clause 3.1^^xsd:stringcmns-av:adaptedFrom : ISO 23234:2021(en), Buildings and civil engineering works - Security - Planning of security measures in the built environment, clause 3.4^^xsd:stringcmns-av:adaptedFrom : ISO/TR 21965:2019(en), Information and documentation - Records management in enterprise architecture, clause 3.2.1^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The concept of actor here is in a more linguistic sense, from core semantic theories reflecting actor/undergoer/null roles of an argument in an expression.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/Actor">cmns-pts:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : agent^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.jamesodell.com/WhatIsAnAgent.pdf^^xsd:anyURIrdfs:seeAlso : http://www.jamesodell.com/WhyShouldWeCareAboutAgents.pdf^^xsd:anyURI</para>
    ///   <para>skos:definition : something autonomous that can adapt to and interact with its environment^^xsd:string</para>
    ///   <para>skos:note : Agents can be human beings, organizations, software agents, robots and living things other than plants. They are defined as having the following three important properties: autonomy, interactive behavior, and adaptability. (1) Autonomy - an agent is capable of acting without direct external intervention. This includes software or other agents that have some degree of control over their internal state and can act based on their own experiences. They can also possess their own set of internal responsibilities and capabilities that enable them to act without any external choreography. This definition excludes agents that act on on behalf of (or as a proxy for) some person or thing (see AgentRole). (2) Interactive behavior - they are capable of exchanging communicating with other things in their environment. This includes, in the case of software agents, messages that can support requests for services and other kinds of resources, as well as event detection and notification. They can be synchronous or asynchronous in nature. The interaction can also be conversational in nature, such as negotiating contracts, marketplace-style bidding, or simply making a query. (3) Adaptability - an agent is capable of responding to other agents and/or its environment. Agents can react to communications and events and then respond appropriately. Software agents can be designed to make difficult decisions and even modify their behavior based on their experiences. In other words, they can learn and evolve.^^xsd:stringskos:note : Note that this does not necessarily imply that an agent is free to act as it sees fit, without constraint. Rather, an agent in the sense meant here is something which may or may not be subject to controls and constraints but is self-actualizing in its behavior in response to any such constraints.^^xsd:string</para>
    ///   <para>cmns-av:directSource : http://www.omg.org/techprocess/meetings/schedule/AMP.html^^xsd:anyURI</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/Agent">cmns-pts:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : agent role^^xsd:string</para>
    ///   <para>skos:definition : role played by any agent^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/AgentRole">cmns-pts:AgentRole</a>
    /// </summary>
    let AgentRole = _prefixId.prefix "AgentRole"
    /// <summary>
    ///   <para>rdfs:label : party^^xsd:string</para>
    ///   <para>skos:definition : person or organization^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/Party">cmns-pts:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    /// <summary>
    ///   <para>rdfs:label : party role^^xsd:string</para>
    ///   <para>skos:definition : role played by an organization or individual that may be time bound^^xsd:string</para>
    ///   <para>skos:example : Examples include organization member, employee, issuer, owner, partner in a partnership, shareholder, and so forth.^^xsd:string</para>
    ///   <para>skos:note : Note that there may be cases where the identity of the party playing the role is not known, as well as cases where in some situation, such as ownership, there may be more than one party playing the role of owner.^^xsd:string</para>
    ///   <para>skos:scopeNote : The concept of a party role is used in contexts in which one would call someone a 'party to something', such as party to a contract or to a transaction, a supplier, buyer, customer, student, employee, and so forth. More specific roles such as those that are performed in the context of some activity or process are actors in that situation.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 14813-1:2015(en), Intelligent transport systems - Reference model architecture(s) for the ITS sector - Part 1: ITS service domains, service groups and services, clause 3.1^^xsd:stringcmns-av:adaptedFrom : ISO 23234:2021(en), Buildings and civil engineering works - Security - Planning of security measures in the built environment, clause 3.4^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/PartyRole">cmns-pts:PartyRole</a>
    /// </summary>
    let PartyRole = _prefixId.prefix "PartyRole"
    /// <summary>
    ///   <para>rdfs:label : situation^^xsd:string</para>
    ///   <para>skos:definition : setting, state of being, or relationship that is relatively stable for some period of time^^xsd:string</para>
    ///   <para>skos:example : Examples include ownership, control, possession, affiliation, beneficial ownership, employment, and other similar situations.^^xsd:string</para>
    ///   <para>skos:note : From a usage perspective, situations are essentially reified relations, sometimes called mediating relationships.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/Situation">cmns-pts:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>rdfs:label : software agent^^xsd:string</para>
    ///   <para>dct:source : ISO/IEC TR 29119-11:2020(en), Software and systems engineering - Software testing - Part 11: Guidelines on the testing of AI-based systems, clause 3.1.73^^xsd:string</para>
    ///   <para>skos:definition : digital entity that perceives its environment and takes actions that maximize its chance of successfully achieving its goals^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/SoftwareAgent">cmns-pts:SoftwareAgent</a>
    /// </summary>
    let SoftwareAgent = _prefixId.prefix "SoftwareAgent"
    /// <summary>
    ///   <para>rdfs:label : undergoer^^xsd:string</para>
    ///   <para>skos:definition : something that plays the role of the object or recipient in a situation, i.e., the thing (or party) that the situation impacts, affects, or that otherwise plays a passive recipient / patient or thematic role^^xsd:string</para>
    ///   <para>skos:example : Examples include something that is owned or controlled.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/Undergoer">cmns-pts:Undergoer</a>
    /// </summary>
    let Undergoer = _prefixId.prefix "Undergoer"
    /// <summary>
    ///   <para>rdfs:label : acts in^^xsd:string</para>
    ///   <para>skos:definition : indicates a situation in which the actor plays a primary role^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/actsIn">cmns-pts:actsIn</a>
    /// </summary>
    let actsIn = _prefixId.prefix "actsIn"
    /// <summary>
    ///   <para>rdfs:label : acts on^^xsd:string</para>
    ///   <para>skos:definition : relates an actor in a given situation to the undergoer that they affect under the circumstances^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/actsOn">cmns-pts:actsOn</a>
    /// </summary>
    let actsOn = _prefixId.prefix "actsOn"
    /// <summary>
    ///   <para>rdfs:label : directly affects^^xsd:string</para>
    ///   <para>skos:definition : relates an actor in a given situation to the thing (or party) that they impact under the circumstances^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/directlyAffects">cmns-pts:directlyAffects</a>
    /// </summary>
    let directlyAffects = _prefixId.prefix "directlyAffects"
    /// <summary>
    ///   <para>rdfs:label : experiences^^xsd:string</para>
    ///   <para>skos:definition : relates something to a situation that affects them in some way^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/experiences">cmns-pts:experiences</a>
    /// </summary>
    let experiences = _prefixId.prefix "experiences"
    /// <summary>
    ///   <para>rdfs:label : experiences directly^^xsd:string</para>
    ///   <para>skos:definition : relates something directly to a party that drives a situation involving it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/experiencesDirectly">cmns-pts:experiencesDirectly</a>
    /// </summary>
    let experiencesDirectly = _prefixId.prefix "experiencesDirectly"
    /// <summary>
    ///   <para>rdfs:label : experiences with^^xsd:string</para>
    ///   <para>skos:definition : relates something to an actor that drives a situation involving it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/experiencesWith">cmns-pts:experiencesWith</a>
    /// </summary>
    let experiencesWith = _prefixId.prefix "experiencesWith"
    /// <summary>
    ///   <para>rdfs:label : has active party^^xsd:string</para>
    ///   <para>skos:definition : relates a situation to the person or organization acting in a primary (agentive) role^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasActiveParty">cmns-pts:hasActiveParty</a>
    /// </summary>
    let hasActiveParty = _prefixId.prefix "hasActiveParty"
    /// <summary>
    ///   <para>rdfs:label : has active role^^xsd:string</para>
    ///   <para>skos:definition : relates a situation to something that is acting in a primary (agentive) role^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasActiveRole">cmns-pts:hasActiveRole</a>
    /// </summary>
    let hasActiveRole = _prefixId.prefix "hasActiveRole"
    /// <summary>
    ///   <para>rdfs:label : has actor^^xsd:string</para>
    ///   <para>skos:definition : identifies the primary party acting in a specific role with respect to a given situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasActor">cmns-pts:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>rdfs:label : has object role^^xsd:string</para>
    ///   <para>skos:definition : identifies a person or thing that is affected by, or is a secondary argument in a specific role with respect to a given relation or situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasObjectRole">cmns-pts:hasObjectRole</a>
    /// </summary>
    let hasObjectRole = _prefixId.prefix "hasObjectRole"
    /// <summary>
    ///   <para>rdfs:label : has party^^xsd:string</para>
    ///   <para>skos:definition : identifies a party associated with an agreement, contract, policy, regulation, situation, or other arrangement^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasParty">cmns-pts:hasParty</a>
    /// </summary>
    let hasParty = _prefixId.prefix "hasParty"
    /// <summary>
    ///   <para>rdfs:label : has party role^^xsd:string</para>
    ///   <para>skos:definition : identifies a specific role played by some person or organization as related to a situation, agreement, contract, policy, regulation, activity or other relationship^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasPartyRole">cmns-pts:hasPartyRole</a>
    /// </summary>
    let hasPartyRole = _prefixId.prefix "hasPartyRole"
    /// <summary>
    ///   <para>rdfs:label : has related party role^^xsd:string</para>
    ///   <para>skos:definition : relates a party acting in a specific role directly to another party acting in the same or another role^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This property is intended as an abstract property, whose subproperties may or may not be symmetric, but could be inverses of one another.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasRelatedPartyRole">cmns-pts:hasRelatedPartyRole</a>
    /// </summary>
    let hasRelatedPartyRole = _prefixId.prefix "hasRelatedPartyRole"
    /// <summary>
    ///   <para>rdfs:label : has subject role^^xsd:string</para>
    ///   <para>skos:definition : identifies the person or thing that is being discussed, described, dealt with, or is the main topic in a specific role with respect to a given situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasSubjectRole">cmns-pts:hasSubjectRole</a>
    /// </summary>
    let hasSubjectRole = _prefixId.prefix "hasSubjectRole"
    /// <summary>
    ///   <para>rdfs:label : has undergoer^^xsd:string</para>
    ///   <para>skos:definition : identifies an experiencer / passive or other object role in a given situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasUndergoer">cmns-pts:hasUndergoer</a>
    /// </summary>
    let hasUndergoer = _prefixId.prefix "hasUndergoer"
    /// <summary>
    ///   <para>rdfs:label : holds during^^xsd:string</para>
    ///   <para>skos:definition : indicates a date period during which something is true^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/holdsDuring">cmns-pts:holdsDuring</a>
    /// </summary>
    let holdsDuring = _prefixId.prefix "holdsDuring"
    /// <summary>
    ///   <para>rdfs:label : is a party to^^xsd:string</para>
    ///   <para>skos:definition : identifies an agreement, contract, policy, regulation, situation, or other arrangement that a party is associated with^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/isAPartyTo">cmns-pts:isAPartyTo</a>
    /// </summary>
    let isAPartyTo = _prefixId.prefix "isAPartyTo"
    /// <summary>
    ///   <para>rdfs:label : is affected by^^xsd:string</para>
    ///   <para>skos:definition : relates an undergoer in a given situation to the actor that has an impact on them under the circumstances^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/isAffectedBy">cmns-pts:isAffectedBy</a>
    /// </summary>
    let isAffectedBy = _prefixId.prefix "isAffectedBy"
    /// <summary>
    ///   <para>rdfs:label : is directly affected by^^xsd:string</para>
    ///   <para>skos:definition : relates an undergoer in a given situation to the person or organization that has an impact on them under the circumstances^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/isDirectlyAffectedBy">cmns-pts:isDirectlyAffectedBy</a>
    /// </summary>
    let isDirectlyAffectedBy = _prefixId.prefix "isDirectlyAffectedBy"
    /// <summary>
    ///   <para>rdfs:label : is experienced by^^xsd:string</para>
    ///   <para>skos:definition : relates a situation to something that is directly involved in or affected by it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/isExperiencedBy">cmns-pts:isExperiencedBy</a>
    /// </summary>
    let isExperiencedBy = _prefixId.prefix "isExperiencedBy"
    /// <summary>
    ///   <para>rdfs:label : is object role in^^xsd:string</para>
    ///   <para>skos:definition : indicates a situation in which the role is secondary, such as an experiencer or passive participant^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/isObjectRoleIn">cmns-pts:isObjectRoleIn</a>
    /// </summary>
    let isObjectRoleIn = _prefixId.prefix "isObjectRoleIn"
    /// <summary>
    ///   <para>rdfs:label : is realized in^^xsd:string</para>
    ///   <para>skos:definition : relates a situation or constituency to something that is affected by, or is a secondary argument to in a specific role with respect to a given relation or situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/isRealizedIn">cmns-pts:isRealizedIn</a>
    /// </summary>
    let isRealizedIn = _prefixId.prefix "isRealizedIn"
    /// <summary>
    ///   <para>rdfs:label : is subject role in^^xsd:string</para>
    ///   <para>skos:definition : indicates a situation in which the role is the primary topic^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/isSubjectRoleIn">cmns-pts:isSubjectRoleIn</a>
    /// </summary>
    let isSubjectRoleIn = _prefixId.prefix "isSubjectRoleIn"
    /// <summary>
    ///   <para>rdfs:label : plays active party in^^xsd:string</para>
    ///   <para>skos:definition : relates a person or organization to a situation that they are directly involved in^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/playsActivePartyIn">cmns-pts:playsActivePartyIn</a>
    /// </summary>
    let playsActivePartyIn = _prefixId.prefix "playsActivePartyIn"
    /// <summary>
    ///   <para>rdfs:label : plays active role in^^xsd:string</para>
    ///   <para>skos:definition : relates something to a situation that it is directly involved in^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/playsActiveRoleIn">cmns-pts:playsActiveRoleIn</a>
    /// </summary>
    let playsActiveRoleIn = _prefixId.prefix "playsActiveRoleIn"
    /// <summary>
    ///   <para>rdfs:label : plays active role that affects^^xsd:string</para>
    ///   <para>skos:definition : relates a person or organization to an undergoer they have an impact on under the circumstances^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/playsActiveRoleThatAffects">cmns-pts:playsActiveRoleThatAffects</a>
    /// </summary>
    let playsActiveRoleThatAffects = _prefixId.prefix "playsActiveRoleThatAffects"

    /// <summary>
    ///   <para>rdfs:label : plays active role that directly affects^^xsd:string</para>
    ///   <para>skos:definition : relates a person or organization to something they have a direct impact on under the circumstances^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/playsActiveRoleThatDirectlyAffects">cmns-pts:playsActiveRoleThatDirectlyAffects</a>
    /// </summary>
    let playsActiveRoleThatDirectlyAffects =
        _prefixId.prefix "playsActiveRoleThatDirectlyAffects"

    /// <summary>
    ///   <para>rdfs:label : realizes^^xsd:string</para>
    ///   <para>skos:definition : relates something to a situation or constituency in which the role they play is secondary, such as an experiencer or passive participant^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/realizes">cmns-pts:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"
    /// <summary>
    ///   <para>rdfs:label : undergoes^^xsd:string</para>
    ///   <para>skos:definition : indicates a situation that the undergoer experiences^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/PartiesAndSituations/undergoes">cmns-pts:undergoes</a>
    /// </summary>
    let undergoes = _prefixId.prefix "undergoes"
