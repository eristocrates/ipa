#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-oac-cctl`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/" "fibo-be-oac-cctl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : affiliate^^xsd:string</para>
    ///   <para>skos:definition : party that is related to a legal entity, directly, or indirectly through one or more intermediaries, and controls, or is controlled by, or is under common control with that entity, typically determined by the degree of ownership^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliate">fibo-be-oac-cctl:Affiliate</a>
    /// </summary>
    let Affiliate = _prefixId.prefix "Affiliate"
    /// <summary>
    ///   <para>rdfs:label : affiliation^^xsd:string</para>
    ///   <para>skos:definition : situation in which a controlled party is affiliated with a controlling party for some period of time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliation">fibo-be-oac-cctl:Affiliation</a>
    /// </summary>
    let Affiliation = _prefixId.prefix "Affiliation"
    /// <summary>
    ///   <para>rdfs:label : controlled affiliate^^xsd:string</para>
    ///   <para>skos:definition : controlled party in an affiliation situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControlledAffiliate">fibo-be-oac-cctl:ControlledAffiliate</a>
    /// </summary>
    let ControlledAffiliate = _prefixId.prefix "ControlledAffiliate"
    /// <summary>
    ///   <para>rdfs:label : controlling affiliate^^xsd:string</para>
    ///   <para>skos:definition : controlling party in an affiliation situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControllingAffiliate">fibo-be-oac-cctl:ControllingAffiliate</a>
    /// </summary>
    let ControllingAffiliate = _prefixId.prefix "ControllingAffiliate"
    /// <summary>
    ///   <para>rdfs:label : domestic ultimate parent^^xsd:string</para>
    ///   <para>skos:definition : party that is recognized as the ultimate parent of a given organization within the country or jurisdiction of incorporation or organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/DomesticUltimateParent">fibo-be-oac-cctl:DomesticUltimateParent</a>
    /// </summary>
    let DomesticUltimateParent = _prefixId.prefix "DomesticUltimateParent"
    /// <summary>
    ///   <para>rdfs:label : global ultimate parent^^xsd:string</para>
    ///   <para>skos:definition : party that is recognized as the ultimate parent of a given organization world-wide^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/GlobalUltimateParent">fibo-be-oac-cctl:GlobalUltimateParent</a>
    /// </summary>
    let GlobalUltimateParent = _prefixId.prefix "GlobalUltimateParent"
    /// <summary>
    ///   <para>rdfs:label : joint venture partner^^xsd:string</para>
    ///   <para>skos:definition : party that shares capital, technology, human resources, risks, and benefits of an entity under shared control^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/JointVenturePartner">fibo-be-oac-cctl:JointVenturePartner</a>
    /// </summary>
    let JointVenturePartner = _prefixId.prefix "JointVenturePartner"
    /// <summary>
    ///   <para>rdfs:label : significant shareholder^^xsd:string</para>
    ///   <para>skos:definition : party that owns a significant voting stake in an organization that is less than 50 percent but greater than some threshold^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that the concept of significance varies depending on the jurisdiction, and particularly with respect to reporting requirements. For example, in some cases, three (3) percent ownership of any class or series of shares is considered significant, and in others it means more than five or ten percent of the total combined voting power across all classes of securities.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/SignificantShareholder">fibo-be-oac-cctl:SignificantShareholder</a>
    /// </summary>
    let SignificantShareholder = _prefixId.prefix "SignificantShareholder"
    /// <summary>
    ///   <para>rdfs:label : subsidiary^^xsd:string</para>
    ///   <para>skos:definition : legal entity that is entirely or majority owned and controlled by another legal entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A subsidiary is a separate, distinct legal entity from its parent company(ies) for the purposes of taxation, regulatory compliance, and with respect to liability.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Subsidiary">fibo-be-oac-cctl:Subsidiary</a>
    /// </summary>
    let Subsidiary = _prefixId.prefix "Subsidiary"
    /// <summary>
    ///   <para>rdfs:label : total controlling interest party^^xsd:string</para>
    ///   <para>skos:definition : voting shareholder that owns 100 percent of the voting shares in some legal entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : By virtue of holding 100 percent of the share ownership, the total controlling interest company also holds 100 percent of the controlling equity, if there is a difference. Therefore, it is both a total owner and a total controlling party.^^xsd:string</para>
    ///   <para>cmns-av:synonym : parent company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/TotalControllingInterestParty">fibo-be-oac-cctl:TotalControllingInterestParty</a>
    /// </summary>
    let TotalControllingInterestParty = _prefixId.prefix "TotalControllingInterestParty"
    /// <summary>
    ///   <para>rdfs:label : voting shareholder^^xsd:string</para>
    ///   <para>skos:definition : shareholder whose shares confer the right to vote in corporate elections, including the right to elect directors at annual or special meetings, and to express their views to corporate management and directors on significant issues that may affect the value of those shares^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/VotingShareholder">fibo-be-oac-cctl:VotingShareholder</a>
    /// </summary>
    let VotingShareholder = _prefixId.prefix "VotingShareholder"
    /// <summary>
    ///   <para>rdfs:label : has affiliate^^xsd:string</para>
    ///   <para>skos:definition : has a party which directly, or indirectly through one or more intermediaries, controls, or is controlled by, or is under common control with the company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasAffiliate">fibo-be-oac-cctl:hasAffiliate</a>
    /// </summary>
    let hasAffiliate = _prefixId.prefix "hasAffiliate"
    /// <summary>
    ///   <para>rdfs:label : has controlling affiliate^^xsd:string</para>
    ///   <para>skos:definition : is directly, or indirectly through one or more intermediaries, controlled by^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasControllingAffiliate">fibo-be-oac-cctl:hasControllingAffiliate</a>
    /// </summary>
    let hasControllingAffiliate = _prefixId.prefix "hasControllingAffiliate"
    /// <summary>
    ///   <para>rdfs:label : has domestic ultimate parent^^xsd:string</para>
    ///   <para>skos:definition : relates an organization to another recognized as its ultimate parent, within its country or jurisdiction of incorporation, if it has one^^xsd:string</para>
    ///   <para>skos:editorialNote : In the case of companies that are subsidiaries of another company that itself has a parent, this identifies the organization at the top of the hierarchy of organizations in the country of registration. Adapted from consensus definition of Ultimate Parent, now that this is split into national and global parent.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : consensus definition of ultimate parent, with the split between domestic and global parent^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasDomesticUltimateParent">fibo-be-oac-cctl:hasDomesticUltimateParent</a>
    /// </summary>
    let hasDomesticUltimateParent = _prefixId.prefix "hasDomesticUltimateParent"
    /// <summary>
    ///   <para>rdfs:label : has global ultimate parent^^xsd:string</para>
    ///   <para>skos:definition : relates an organization to another recognized as its ultimate parent, if it has one^^xsd:string</para>
    ///   <para>skos:editorialNote : In the case of companies that are subsidiaries of another company that itself has a parent, this identifies the organization at the top of the hierarchy, world-wide. Adapted from consensus definition of Ultimate Parent, now that this is split into national and global parent.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : consensus definition of ultimate parent, with the split between domestic and global parent^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasGlobalUltimateParent">fibo-be-oac-cctl:hasGlobalUltimateParent</a>
    /// </summary>
    let hasGlobalUltimateParent = _prefixId.prefix "hasGlobalUltimateParent"
    /// <summary>
    ///   <para>rdfs:label : has subsidiary^^xsd:string</para>
    ///   <para>skos:definition : relates a legal entity to another organization that it owns at least 50 percent of^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasSubsidiary">fibo-be-oac-cctl:hasSubsidiary</a>
    /// </summary>
    let hasSubsidiary = _prefixId.prefix "hasSubsidiary"
    /// <summary>
    ///   <para>rdfs:label : is affiliate of^^xsd:string</para>
    ///   <para>skos:definition : relates a party which directly, or indirectly through one or more intermediaries, controls, or is controlled by, or is under common control by another party to that party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isAffiliateOf">fibo-be-oac-cctl:isAffiliateOf</a>
    /// </summary>
    let isAffiliateOf = _prefixId.prefix "isAffiliateOf"
    /// <summary>
    ///   <para>rdfs:label : is controlling affiliate of^^xsd:string</para>
    ///   <para>skos:definition : controls directly, or indirectly through one or more intermediaries^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isControllingAffiliateOf">fibo-be-oac-cctl:isControllingAffiliateOf</a>
    /// </summary>
    let isControllingAffiliateOf = _prefixId.prefix "isControllingAffiliateOf"
    /// <summary>
    ///   <para>rdfs:label : is parent company of^^xsd:string</para>
    ///   <para>skos:definition : indicates a controlled affiliate that it owns at least 50 percent of^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isParentCompanyOf">fibo-be-oac-cctl:isParentCompanyOf</a>
    /// </summary>
    let isParentCompanyOf = _prefixId.prefix "isParentCompanyOf"
    /// <summary>
    ///   <para>rdfs:label : is subsidiary of^^xsd:string</para>
    ///   <para>skos:definition : is controlled directly, or indirectly through one or more intermediaries and owned at least 50 percent by^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isSubsidiaryOf">fibo-be-oac-cctl:isSubsidiaryOf</a>
    /// </summary>
    let isSubsidiaryOf = _prefixId.prefix "isSubsidiaryOf"
    /// <summary>
    ///   <para>rdfs:label : is wholly owned by^^xsd:string</para>
    ///   <para>skos:definition : relates a legal entity to a party that has 100 percent ownership and control over it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isWhollyOwnedBy">fibo-be-oac-cctl:isWhollyOwnedBy</a>
    /// </summary>
    let isWhollyOwnedBy = _prefixId.prefix "isWhollyOwnedBy"
