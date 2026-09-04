#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-oac-cown`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/" "fibo-be-oac-cown"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : beneficial owner^^xsd:string</para>
    ///   <para>skos:definition : party that enjoys the benefits of ownership (such as receipt of income) of something even though its ownership (title) may be in the name of another party (called a nominee or registered owner)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Beneficial_ownership#Financial_Action_Task_Force_on_Money_Laundering_(FATF)^^xsd:anyURIcmns-av:adaptedFrom : https://www.fincen.gov/resources/statutes-regulations/guidance/guidance-obtaining-and-retaining-beneficial-ownership^^xsd:anyURIcmns-av:adaptedFrom : https://www.ncua.gov/regulation-supervision/letters-credit-unions-other-guidance/beneficial-ownership-requirements-legal-entity-customers-overview^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : From World Bank Report: In identifying the beneficial owner, the focus should be on two factors: the control exercised and the benefit derived. Control of a corporate vehicle will always depend on context, as control can be exercised in many different ways, including through ownership, contractually or informally.^^xsd:stringcmns-av:explanatoryNote : The Financial Action Task Force on Money Laundering (FATF) refers to a 'beneficial owner' as the natural person(s) who ultimately owns or controls a legal entity and/or the natural person on whose behalf a transaction is being conducted. It also includes those persons who exercise ultimate effective control over a legal person or arrangement.^^xsd:stringcmns-av:explanatoryNote : The National Credit Union Administration (NCUA) defines a 'beneficial owner' as (1) a single individual with significant responsibility to control, manage or direct a legal entity customer, or (2) each individual, if any, who, directly or indirectly, through any contract, arrangement, understanding, relationship or otherwise, owns 25 percent or more of the equity interests of a legal entity customer; if a trust owns directly or indirectly, through any contract, arrangement, understanding, relationship or otherwise, 25 percent or more of the equity interests of a legal entity customer, the beneficial owner is the trustee.^^xsd:stringcmns-av:explanatoryNote : Use of a nominee (who may be an agent, custodian, or a trustee) does not change the position regarding tax reporting and tax liability, and the beneficial owner remains responsible.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwner">fibo-be-oac-cown:BeneficialOwner</a>
    /// </summary>
    let BeneficialOwner = _prefixId.prefix "BeneficialOwner"
    /// <summary>
    ///   <para>rdfs:label : beneficial ownership^^xsd:string</para>
    ///   <para>skos:definition : situation linking party that enjoys the benefits of ownership (such as receipt of income) of something even though its ownership (title) may be in the name of another party (called a nominee or registered owner) to the asset that they own^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Beneficial ownership may be shared among a group of individuals. If a beneficial owner acquires a position of more than 5 percent in the United States, it must file Schedule 13D or 13G under Section 12 of the Securities Exchange Act of 1934.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwnership">fibo-be-oac-cown:BeneficialOwnership</a>
    /// </summary>
    let BeneficialOwnership = _prefixId.prefix "BeneficialOwnership"
    /// <summary>
    ///   <para>rdfs:label : purchase lot^^xsd:string</para>
    ///   <para>skos:definition : financial asset that is a block of securities or other financial assets bought in one transaction on a given date at a specific price^^xsd:string</para>
    ///   <para>skos:example : Buying 100 shares of Apple on Jan 10 at $150/share is one purchase lot; buying 50 more shares on Mar 15 at $160/share is another purchase lot.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Purchase lot is typically used as a trading term by brokers and portfolio managers to describe how holdings are grouped.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/PurchaseLot">fibo-be-oac-cown:PurchaseLot</a>
    /// </summary>
    let PurchaseLot = _prefixId.prefix "PurchaseLot"
    /// <summary>
    ///   <para>rdfs:label : shareholder^^xsd:string</para>
    ///   <para>skos:definition : party that owns shares in and has rights and responsibilities with respect to some asset, provided in exchange for investment^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The shares represent an ownership interest in a corporation, mutual fund, or partnership, or a unit of ownership in a structured product, such as a real estate investment trust.^^xsd:string</para>
    ///   <para>cmns-av:synonym : stockholder</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholder">fibo-be-oac-cown:Shareholder</a>
    /// </summary>
    let Shareholder = _prefixId.prefix "Shareholder"
    /// <summary>
    ///   <para>rdfs:label : shareholding^^xsd:string</para>
    ///   <para>skos:definition : ownership interest in the equity of a company, represented by shares that confer financial rights and governance privileges^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Shareholding refers to the total ownership a party has in some organization, and determines voting power, dividend entitlement, and exposure to risk.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholding">fibo-be-oac-cown:Shareholding</a>
    /// </summary>
    let Shareholding = _prefixId.prefix "Shareholding"
    /// <summary>
    ///   <para>rdfs:label : tax lot^^xsd:string</para>
    ///   <para>skos:definition : financial asset that is a block of securities or other financial assets with a distinct cost basis for tax reporting purposes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Tax lots reflect how shares or other assets are tracked for capital gains and may be adjusted by events including:
    /// - reinvested dividends (creates very small, new tax lots);
    /// - stock splits or mergers (adjusts basis, may create fractional lots);
    /// - Wash sale rules (can change which lots are recognized).
    /// When an investor sells, they select which tax lot to sell (specific ID, FIFO, etc.), which determines realized gain or loss.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/TaxLot">fibo-be-oac-cown:TaxLot</a>
    /// </summary>
    let TaxLot = _prefixId.prefix "TaxLot"
    /// <summary>
    ///   <para>rdfs:label : consists of number of units</para>
    ///   <para>skos:definition : indicates the number of units of</para>
    ///   <para>cmns-av:explanatoryNote : This property indicates the number of units (e.g., shares, fund units) of the asset held in a shareholding or position, for example.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/consistsOfNumberOfUnits">fibo-be-oac-cown:consistsOfNumberOfUnits</a>
    /// </summary>
    let consistsOfNumberOfUnits = _prefixId.prefix "consistsOfNumberOfUnits"
    /// <summary>
    ///   <para>rdfs:label : has beneficial owner^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that retains rights in the asset they own in a beneficial ownership situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/hasBeneficialOwner">fibo-be-oac-cown:hasBeneficialOwner</a>
    /// </summary>
    let hasBeneficialOwner = _prefixId.prefix "hasBeneficialOwner"
    /// <summary>
    ///   <para>rdfs:label : is beneficial owner of^^xsd:string</para>
    ///   <para>skos:definition : indicates an asset in which the beneficial owner holds rights (typically voting rights, management rights, etc.) in a beneficial ownership situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/isBeneficialOwnerOf">fibo-be-oac-cown:isBeneficialOwnerOf</a>
    /// </summary>
    let isBeneficialOwnerOf = _prefixId.prefix "isBeneficialOwnerOf"
