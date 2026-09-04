#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-plc-plc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/" "fibo-be-plc-plc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : limited liability company^^xsd:string</para>
    ///   <para>skos:definition : private limited company that combines the pass through taxation of a sole proprietorship or partnership with the limited liability of a corporation^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LLC^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompany">fibo-be-plc-plc:LimitedLiabilityCompany</a>
    /// </summary>
    let LimitedLiabilityCompany = _prefixId.prefix "LimitedLiabilityCompany"
    /// <summary>
    ///   <para>rdfs:label : limited liability company member^^xsd:string</para>
    ///   <para>skos:definition : owner of an interest in a limited liability company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyMember">fibo-be-plc-plc:LimitedLiabilityCompanyMember</a>
    /// </summary>
    let LimitedLiabilityCompanyMember = _prefixId.prefix "LimitedLiabilityCompanyMember"

    /// <summary>
    ///   <para>rdfs:label : limited liability company taxed as a corporation^^xsd:string</para>
    ///   <para>skos:definition : limited liability company that has elected to have corporate tax status^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : C-LLC^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the United States, LLCs that elect to be taxed as a corporation do so by filing an IRS Form 8832.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyTaxedAsACorporation">fibo-be-plc-plc:LimitedLiabilityCompanyTaxedAsACorporation</a>
    /// </summary>
    let LimitedLiabilityCompanyTaxedAsACorporation =
        _prefixId.prefix "LimitedLiabilityCompanyTaxedAsACorporation"

    /// <summary>
    ///   <para>rdfs:label : manager-managed limited liability company^^xsd:string</para>
    ///   <para>skos:definition : limited liability company in which the members appoint one or more managers to handle the daily operations and administrative responsibilities of the organization^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : If no members are interested in managing the LLC, an external manager (someone who doesn't own any portion of the LLC) can be hired to run the business operations, including, in some jurisdictions, a third-party entity, such as another company.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagerManagedLimitedLiabilityCompany">fibo-be-plc-plc:ManagerManagedLimitedLiabilityCompany</a>
    /// </summary>
    let ManagerManagedLimitedLiabilityCompany =
        _prefixId.prefix "ManagerManagedLimitedLiabilityCompany"

    /// <summary>
    ///   <para>rdfs:label : managing member^^xsd:string</para>
    ///   <para>skos:definition : owner of an interest in a limited liability company who also runs the day-to-day business operations^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagingMember">fibo-be-plc-plc:ManagingMember</a>
    /// </summary>
    let ManagingMember = _prefixId.prefix "ManagingMember"

    /// <summary>
    ///   <para>rdfs:label : private company with limited liability^^xsd:string</para>
    ///   <para>skos:definition : hybrid business entity having characteristics of both a corporation and a partnership or sole proprietorship (depending on how many owners there are)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Limited_liability_company#Overview^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A private company with limited liability, although a business entity, is not a corporation. The primary characteristic this legal form shares with a corporation is limited liability, and the primary characteristic it shares with a partnership is the availability of pass-through income taxation. It is often more flexible than a corporation, and it is well-suited for companies with a single owner.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateCompanyWithLimitedLiability">fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</a>
    /// </summary>
    let PrivateCompanyWithLimitedLiability =
        _prefixId.prefix "PrivateCompanyWithLimitedLiability"

    /// <summary>
    ///   <para>rdfs:label : private limited company^^xsd:string</para>
    ///   <para>skos:definition : private limited company whose shareholders' liability is limited to the capital they originally invested^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : Ltd.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Private limited companies are common in countries including the U.K., Ireland, and Canada. They have one or more members, also called shareholders or owners, who buy in through private sales. Directors are company employees who keep up with all administrative tasks and tax filings but do not need to be shareholders.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateLimitedCompany">fibo-be-plc-plc:PrivateLimitedCompany</a>
    /// </summary>
    let PrivateLimitedCompany = _prefixId.prefix "PrivateLimitedCompany"
    /// <summary>
    ///   <para>rdfs:label : has managing member^^xsd:string</para>
    ///   <para>skos:definition : indicates a managing member in a controlling role of a limited liability company that has responsibility for the day-to-day business operations^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/hasManagingMember">fibo-be-plc-plc:hasManagingMember</a>
    /// </summary>
    let hasManagingMember = _prefixId.prefix "hasManagingMember"
    /// <summary>
    ///   <para>rdfs:label : is managing member of^^xsd:string</para>
    ///   <para>skos:definition : indicates the controlled limited liability company that the managing member runs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/isManagingMemberOf">fibo-be-plc-plc:isManagingMemberOf</a>
    /// </summary>
    let isManagingMemberOf = _prefixId.prefix "isManagingMemberOf"
