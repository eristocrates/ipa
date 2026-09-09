#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-rga`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/RegulatoryAgencies/" "cmns-rga"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : jurisdiction</para>
    ///   <para>skos:definition : power of a court or regulatory agency to adjudicate cases, issue orders, and interpret and apply the law with respect to some specific geographic area^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.law.cornell.edu/wex/jurisdiction^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/Jurisdiction">cmns-rga:Jurisdiction</a>
    /// </summary>
    let Jurisdiction = _prefixId.prefix "Jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : regulatory agency^^xsd:string</para>
    ///   <para>skos:definition : public authority or government agency responsible for exercising authority over something in a regulatory or supervisory capacity^^xsd:string</para>
    ///   <para>skos:example : See http://www.finra.org/AboutFINRA/ for an example describing a regulatory agency.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Typically, a regulatory agency is chartered to protect some constituancy, (e.g., investors in the financial industry, consumers with respect to product safety), to ensure the fairness and integrity of some market, and fair and safe business practices among the service providers in that market.^^xsd:string</para>
    ///   <para>cmns-av:synonym : regulator^^xsd:stringcmns-av:synonym : regulatory authority^^xsd:stringcmns-av:synonym : regulatory body^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/RegulatoryAgency">cmns-rga:RegulatoryAgency</a>
    /// </summary>
    let RegulatoryAgency = _prefixId.prefix "RegulatoryAgency"
    /// <summary>
    ///   <para>rdfs:label : regulatory report^^xsd:string</para>
    ///   <para>skos:definition : document required to support operational transparency that demonstrates compliance with some specification, law, policy, restriction, or other rule specified by a regulatory agency^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Such a report may be needed for licensing, monitoring, taxation, or for other purposes that demonstrate the integrity, fairness, safety, or other capacity of a given industry, organization, or product.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/RegulatoryReport">cmns-rga:RegulatoryReport</a>
    /// </summary>
    let RegulatoryReport = _prefixId.prefix "RegulatoryReport"
    /// <summary>
    ///   <para>rdfs:label : regulatory service^^xsd:string</para>
    ///   <para>skos:definition : service provided by a regulatory agency, which may include, but not be limited to, examination, monitoring, supervision, testing, or other capabilities required to ensure the integrity, fairness, safety, or other capacity of a given industry, organization, or product^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/RegulatoryService">cmns-rga:RegulatoryService</a>
    /// </summary>
    let RegulatoryService = _prefixId.prefix "RegulatoryService"
    /// <summary>
    ///   <para>rdfs:label : governs^^xsd:string</para>
    ///   <para>skos:definition : has and exercises authority over^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/governs">cmns-rga:governs</a>
    /// </summary>
    let governs = _prefixId.prefix "governs"
    /// <summary>
    ///   <para>rdfs:label : has jurisdiction^^xsd:string</para>
    ///   <para>skos:definition : relates a polity, government entity or regulatory agency to a jurisdiction over which it has some level of legal authority^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/hasJurisdiction">cmns-rga:hasJurisdiction</a>
    /// </summary>
    let hasJurisdiction = _prefixId.prefix "hasJurisdiction"
    /// <summary>
    ///   <para>rdfs:label : has reach^^xsd:string</para>
    ///   <para>skos:definition : indicates the geographic region covered by the jurisdiction^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/hasReach">cmns-rga:hasReach</a>
    /// </summary>
    let hasReach = _prefixId.prefix "hasReach"
    /// <summary>
    ///   <para>rdfs:label : is applicable in jurisdiction^^xsd:string</para>
    ///   <para>skos:definition : indicates the geopolitical region identifier for the jurisdiction in which something is applicable^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isApplicableInJurisdiction">cmns-rga:isApplicableInJurisdiction</a>
    /// </summary>
    let isApplicableInJurisdiction = _prefixId.prefix "isApplicableInJurisdiction"
    /// <summary>
    ///   <para>rdfs:label : is governed by^^xsd:string</para>
    ///   <para>skos:definition : relates a contract, agreement, jurisdiction, or other legal construct and the regulation, policy, procedure, or legal person that regulates or oversees (governs) it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isGovernedBy">cmns-rga:isGovernedBy</a>
    /// </summary>
    let isGovernedBy = _prefixId.prefix "isGovernedBy"
    /// <summary>
    ///   <para>rdfs:label : is jurisdiction of^^xsd:string</para>
    ///   <para>skos:definition : relates a jurisdiction to a polity or other government entity or court that has some level of legal authority over it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isJurisdictionOf">cmns-rga:isJurisdictionOf</a>
    /// </summary>
    let isJurisdictionOf = _prefixId.prefix "isJurisdictionOf"
    /// <summary>
    ///   <para>rdfs:label : is organized in^^xsd:string</para>
    ///   <para>skos:definition : indicates the jurisdiction whose laws a legal entity is organized under^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isOrganizedIn">cmns-rga:isOrganizedIn</a>
    /// </summary>
    let isOrganizedIn = _prefixId.prefix "isOrganizedIn"
    /// <summary>
    ///   <para>rdfs:label : is recognized in^^xsd:string</para>
    ///   <para>skos:definition : indicates the jurisdiction in which a legal person is considered competent to enter into a contract, conduct business, or participate in other activities, or in which an agreement may be acknowledged and possibly enforceable^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isRecognizedIn">cmns-rga:isRecognizedIn</a>
    /// </summary>
    let isRecognizedIn = _prefixId.prefix "isRecognizedIn"
    /// <summary>
    ///   <para>rdfs:label : is regulated by^^xsd:string</para>
    ///   <para>skos:definition : specifies a regulatory agency that has regulatory authority for something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/isRegulatedBy">cmns-rga:isRegulatedBy</a>
    /// </summary>
    let isRegulatedBy = _prefixId.prefix "isRegulatedBy"
    /// <summary>
    ///   <para>rdfs:label : regulates^^xsd:string</para>
    ///   <para>skos:definition : has regulatory authority over or directs according to rule or law, typically an industry, organization, or product^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.merriam-webster.com/dictionary/regulate^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/RegulatoryAgencies/regulates">cmns-rga:regulates</a>
    /// </summary>
    let regulates = _prefixId.prefix "regulates"
