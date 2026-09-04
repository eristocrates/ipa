#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-oac-opty`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/" "fibo-be-oac-opty"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : constitutional owner^^xsd:string</para>
    ///   <para>skos:definition : entity owner that holds an equity stake in said entity, in the form of shareholders' equity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Typically this would be share ownership or the holding of partnership equity. Ownership in this 'constitutional' sense means that the owner is in some way a member of the organization, such as an employee or director, as distinct from some outside investor.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ConstitutionalOwner">fibo-be-oac-opty:ConstitutionalOwner</a>
    /// </summary>
    let ConstitutionalOwner = _prefixId.prefix "ConstitutionalOwner"
    /// <summary>
    ///   <para>rdfs:label : controlling equity^^xsd:string</para>
    ///   <para>skos:definition : shareholders's equity that formally confers control in the entity, either by law or as explicitly stated in a corresponding equity instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ControllingEquity">fibo-be-oac-opty:ControllingEquity</a>
    /// </summary>
    let ControllingEquity = _prefixId.prefix "ControllingEquity"
    /// <summary>
    ///   <para>rdfs:label : direct consolidation^^xsd:string</para>
    ///   <para>skos:definition : direct ownership of an entity recorded as accounting consolidation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/DirectConsolidation">fibo-be-oac-opty:DirectConsolidation</a>
    /// </summary>
    let DirectConsolidation = _prefixId.prefix "DirectConsolidation"
    /// <summary>
    ///   <para>rdfs:label : entity owner^^xsd:string</para>
    ///   <para>skos:definition : owner (person, group of people, or other business entity) that owns, or holds an ownership interest in, a formal business organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwner">fibo-be-oac-opty:EntityOwner</a>
    /// </summary>
    let EntityOwner = _prefixId.prefix "EntityOwner"
    /// <summary>
    ///   <para>rdfs:label : entity ownership^^xsd:string</para>
    ///   <para>skos:definition : ownership by some party of an interest in some non-governmental formal organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwnership">fibo-be-oac-opty:EntityOwnership</a>
    /// </summary>
    let EntityOwnership = _prefixId.prefix "EntityOwnership"
    /// <summary>
    ///   <para>rdfs:label : foreign branch ownership^^xsd:string</para>
    ///   <para>skos:definition : ownership by some party of some formal organization or organizational sub-unit that is a foreign affiliate and legally part of the owning entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ForeignBranchOwnership">fibo-be-oac-opty:ForeignBranchOwnership</a>
    /// </summary>
    let ForeignBranchOwnership = _prefixId.prefix "ForeignBranchOwnership"
    /// <summary>
    ///   <para>rdfs:label : investment equity^^xsd:string</para>
    ///   <para>skos:definition : equity that represents an ownership interest in some entity, but may or may not take the form of shareholders's equity^^xsd:string</para>
    ///   <para>skos:editorialNote : Typically an investment in some entity may take the form of shares (issued or privately held), i.e., shareholders' equity, or it may take the form of some capital amount which is not reflected in shareholders' equity. In each case, there would typically be a contractual basis for the investment setting out what controls or other benefits accrue to the investor.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestmentEquity">fibo-be-oac-opty:InvestmentEquity</a>
    /// </summary>
    let InvestmentEquity = _prefixId.prefix "InvestmentEquity"
    /// <summary>
    ///   <para>rdfs:label : investor^^xsd:string</para>
    ///   <para>skos:definition : party that owns some stake in some organization by way of investment^^xsd:string</para>
    ///   <para>skos:editorialNote : This is regardless of whether or not the investor is also a constitutional owner (e.g. shareholder) in the entity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/Investor">fibo-be-oac-opty:Investor</a>
    /// </summary>
    let Investor = _prefixId.prefix "Investor"
    /// <summary>
    ///   <para>rdfs:label : investor contract^^xsd:string</para>
    ///   <para>skos:definition : Contract setting out the terms under which some investor invests in the entity and setting out the rights which are conferred on that investor.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestorContract">fibo-be-oac-opty:InvestorContract</a>
    /// </summary>
    let InvestorContract = _prefixId.prefix "InvestorContract"
    /// <summary>
    ///   <para>rdfs:label : ultimate ownership^^xsd:string</para>
    ///   <para>skos:definition : highest-level (top, end) ancestral ownership, evidenced by accounting consolidation, by some party of some other legal entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/UltimateConsolidation">fibo-be-oac-opty:UltimateConsolidation</a>
    /// </summary>
    let UltimateConsolidation = _prefixId.prefix "UltimateConsolidation"
    /// <summary>
    ///   <para>rdfs:label : guarantees^^xsd:string</para>
    ///   <para>skos:definition : provides a formal assurance or promise, esp. that certain conditions shall be fulfilled relating to a product, service, or transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/guarantees">fibo-be-oac-opty:guarantees</a>
    /// </summary>
    let guarantees = _prefixId.prefix "guarantees"
    /// <summary>
    ///   <para>rdfs:label : has direct ownership^^xsd:string</para>
    ///   <para>skos:definition : relates a formal organization to the situation in which it is owned directly by another entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwnership">fibo-be-oac-opty:hasDirectOwnership</a>
    /// </summary>
    let hasDirectOwnership = _prefixId.prefix "hasDirectOwnership"
    /// <summary>
    ///   <para>rdfs:label : has direct owning entity^^xsd:string</para>
    ///   <para>skos:definition : relates a formal organization to a direct legal person / owner^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwningEntity">fibo-be-oac-opty:hasDirectOwningEntity</a>
    /// </summary>
    let hasDirectOwningEntity = _prefixId.prefix "hasDirectOwningEntity"
    /// <summary>
    ///   <para>rdfs:label : has investment entity^^xsd:string</para>
    ///   <para>skos:definition : relates a legal person to a directly owned formal organization or subsidiary, depending on the percent ownership interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentEntity">fibo-be-oac-opty:hasInvestmentEntity</a>
    /// </summary>
    let hasInvestmentEntity = _prefixId.prefix "hasInvestmentEntity"
    /// <summary>
    ///   <para>rdfs:label : has investment ownership^^xsd:string</para>
    ///   <para>skos:definition : relates a legal person to the context in which it owns a formal organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentOwnership">fibo-be-oac-opty:hasInvestmentOwnership</a>
    /// </summary>
    let hasInvestmentOwnership = _prefixId.prefix "hasInvestmentOwnership"
    /// <summary>
    ///   <para>rdfs:label : has owned entity^^xsd:string</para>
    ///   <para>skos:definition : indicates a formal organization, including potentially a sole proprietorship, that is owned by a legal person^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwnedEntity">fibo-be-oac-opty:hasOwnedEntity</a>
    /// </summary>
    let hasOwnedEntity = _prefixId.prefix "hasOwnedEntity"
    /// <summary>
    ///   <para>rdfs:label : has owning entity^^xsd:string</para>
    ///   <para>skos:definition : indicates a party that owns a formal organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwningEntity">fibo-be-oac-opty:hasOwningEntity</a>
    /// </summary>
    let hasOwningEntity = _prefixId.prefix "hasOwningEntity"
