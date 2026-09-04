#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-fct-fct`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/" "fibo-be-fct-fct"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : association^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit organization that is owned by and acts on behalf of its members^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Associations include trade or business associations, industry sector-specific groups, and professional associations, among others. They also commonly include cooperative farms and markets.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Association">fibo-be-fct-fct:Association</a>
    /// </summary>
    let Association = _prefixId.prefix "Association"
    /// <summary>
    ///   <para>rdfs:label : cooperative society^^xsd:string</para>
    ///   <para>skos:definition : organization owned by and operated for the benefit of those using its services^^xsd:string</para>
    ///   <para>skos:example : In agriculture, there are broadly three types of cooperatives: a machinery pool, a manufacturing/marketing cooperative, and a credit union^^xsd:string</para>
    ///   <para>cmns-av:synonym : cooperative^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/CooperativeSociety">fibo-be-fct-fct:CooperativeSociety</a>
    /// </summary>
    let CooperativeSociety = _prefixId.prefix "CooperativeSociety"
    /// <summary>
    ///   <para>rdfs:label : family office^^xsd:string</para>
    ///   <para>skos:definition : organization that assumes the day-to-day administration and management of a family's affairs^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Family offices are often privately held companies set up to handle investment and wealth management for wealthy families.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FamilyOffice">fibo-be-fct-fct:FamilyOffice</a>
    /// </summary>
    let FamilyOffice = _prefixId.prefix "FamilyOffice"
    /// <summary>
    ///   <para>rdfs:label : functional business entity^^xsd:string</para>
    ///   <para>skos:definition : functional entity defined in terms of the nature of the commercial activity it conducts^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalBusinessEntity">fibo-be-fct-fct:FunctionalBusinessEntity</a>
    /// </summary>
    let FunctionalBusinessEntity = _prefixId.prefix "FunctionalBusinessEntity"
    /// <summary>
    ///   <para>rdfs:label : functional entity^^xsd:string</para>
    ///   <para>skos:definition : party defined in terms of a function they or it performs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalEntity">fibo-be-fct-fct:FunctionalEntity</a>
    /// </summary>
    let FunctionalEntity = _prefixId.prefix "FunctionalEntity"
    /// <summary>
    ///   <para>rdfs:label : merchant^^xsd:string</para>
    ///   <para>skos:definition : party engaged in the purchase and sales of goods produced by others for profit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Merchant">fibo-be-fct-fct:Merchant</a>
    /// </summary>
    let Merchant = _prefixId.prefix "Merchant"
    /// <summary>
    ///   <para>rdfs:label : merchant category code^^xsd:string</para>
    ///   <para>skos:definition : code used internationally to classify a merchant^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : MCC^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 18245:2003 Retail financial services - Merchant category codes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Merchant categories are organized by the type of business, trade or services supplied. Certain category codes including those for very large businesses, such as airlines and some hotel chains, may be delineated to the point of identifying the business. Merchant category codes and/or the descriptions of the service categories are frequently used in credit card and other banking transactions for analysis, transaction classification, such as for use in promotional rewards, and sometimes tax-related purposes.^^xsd:stringcmns-av:explanatoryNote : Values are specified only for those merchant categories that are generally expected to originate retail financial transactions. Criteria for establishing a new category code includes (a) the merchant category is reasonable and substantially different from all other merchant categories currently represented in the list of code values; (b) the merchant category is separate and distinct from all other industries currently represented in the list of code values; (c) the proposal describes a merchant category or industry, and not a process; (d) the minimum annual sales volume of merchants included in the merchant category, taken as a whole, is USD 10 million; and (e) sufficient justification for the addition of a new code value is found.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCode">fibo-be-fct-fct:MerchantCategoryCode</a>
    /// </summary>
    let MerchantCategoryCode = _prefixId.prefix "MerchantCategoryCode"
    /// <summary>
    ///   <para>rdfs:label : merchant category code scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme defining a set of codes for classifying merchant services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 18245:2003 Retail financial services - Merchant category codes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : ISO 18245 provides a set of merchant category codes that are used internationally. Some countries, regional governments, banks, and other large organizations extend the basic codes with custom additions to fit business needs.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCodeScheme">fibo-be-fct-fct:MerchantCategoryCodeScheme</a>
    /// </summary>
    let MerchantCategoryCodeScheme = _prefixId.prefix "MerchantCategoryCodeScheme"
    /// <summary>
    ///   <para>rdfs:label : merchant identifier^^xsd:string</para>
    ///   <para>skos:definition : unique identifier for a merchant that is used, for example, for transaction interchange purposes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantIdentifier">fibo-be-fct-fct:MerchantIdentifier</a>
    /// </summary>
    let MerchantIdentifier = _prefixId.prefix "MerchantIdentifier"
    /// <summary>
    ///   <para>rdfs:label : syndicate</para>
    ///   <para>skos:definition : temporary, self-organizing group of people, companies, corporations or entities organized as an alliance whose purpose is to transact some specific business, or to pursue or promote a shared interest</para>
    ///   <para>skos:example : For example, when a group of investment banks work together to bring a new issue of securities to the market, they form a distributing syndicate. Other types of syndicates are created for underwriting, banking, and insurance.</para>
    ///   <para>cmns-av:explanatoryNote : A syndicate is a temporary alliance formed by people or businesses to handle a large transaction that would be hard to execute individually. Syndication makes it easy for businesses to pool their resources and share risks.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Syndicate">fibo-be-fct-fct:Syndicate</a>
    /// </summary>
    let Syndicate = _prefixId.prefix "Syndicate"
    /// <summary>
    ///   <para>rdfs:label : syndicate member</para>
    ///   <para>skos:definition : role of an individual or organization that is a member of an alliance set up to pool resources and share risk with respect to a large transaction</para>
    ///   <para>cmns-av:synonym : participating membercmns-av:synonym : syndicate participant</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/SyndicateMember">fibo-be-fct-fct:SyndicateMember</a>
    /// </summary>
    let SyndicateMember = _prefixId.prefix "SyndicateMember"

    /// <summary>
    ///   <para>rdfs:label : has merchant category description^^xsd:string</para>
    ///   <para>skos:definition : provides a text description of the sector to which the code applies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/hasMerchantCategoryDescription">fibo-be-fct-fct:hasMerchantCategoryDescription</a>
    /// </summary>
    let hasMerchantCategoryDescription =
        _prefixId.prefix "hasMerchantCategoryDescription"
