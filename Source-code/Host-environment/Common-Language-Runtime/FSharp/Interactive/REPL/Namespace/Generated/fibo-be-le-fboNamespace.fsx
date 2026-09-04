#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-le-fbo`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/" "fibo-be-le-fbo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : branch^^xsd:string</para>
    ///   <para>skos:definition : part of a larger organization that might not be co-located with it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Branch">fibo-be-le-fbo:Branch</a>
    /// </summary>
    let Branch = _prefixId.prefix "Branch"
    /// <summary>
    ///   <para>rdfs:label : division^^xsd:string</para>
    ///   <para>skos:definition : part of an organization, such as a line of business, that may have separate accounting and reporting requirements^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Division">fibo-be-le-fbo:Division</a>
    /// </summary>
    let Division = _prefixId.prefix "Division"
    /// <summary>
    ///   <para>rdfs:label : joint venture^^xsd:string</para>
    ///   <para>skos:definition : legal entity that is formed between parties that pool their resources for the purpose of accomplishing a specific task but otherwise retain their distinct identities^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In a joint venture, each of the participants is responsible for profits, losses, and costs associated with it. However, the venture is its own entity, separate from the participants' other business interests.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/JointVenture">fibo-be-le-fbo:JointVenture</a>
    /// </summary>
    let JointVenture = _prefixId.prefix "JointVenture"
    /// <summary>
    ///   <para>rdfs:label : non-governmental organization^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit organization that functions independently of government^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : NGO^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : NGOs, sometimes called civil societies, are organized on community, national and international levels to serve specific social or political purposes, and are cooperative, rather than commercial, in nature.^^xsd:stringcmns-av:explanatoryNote : Some NGOs avoid formal funding altogether and are run primarily by volunteers. NGOs are highly diverse groups of organizations engaged in a wide range of activities, and take different forms in different parts of the world. Some may have charitable status, while others may be registered for tax exemption based on recognition of social purposes. Others may be fronts for political, religious, or other interests.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NonGovernmentalOrganization">fibo-be-le-fbo:NonGovernmentalOrganization</a>
    /// </summary>
    let NonGovernmentalOrganization = _prefixId.prefix "NonGovernmentalOrganization"
    /// <summary>
    ///   <para>rdfs:label : not for profit organization^^xsd:string</para>
    ///   <para>skos:definition : organization that uses its surplus revenues to further achieve its purpose rather than distributing its surplus income to the organization's owners (directors, investors, and equivalents) as profit / dividends^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the US, a nonprofit organization is an association that explicitly is not required to pay taxes on its income. Such organizations are qualified for this exemption due to their socially desirable objective (e.g. hospitals, charitable organizations, etc., or because they meet some set of requirements as determined by the US Internal Revenue Service.^^xsd:stringcmns-av:explanatoryNote : The nonprofit landscape is highly varied, although many people have come to associate NPOs with charitable organizations. Although charities do comprise an often high profile or visible aspect of the sector, there are many other types of nonprofits. Overall, they tend to be either member-serving or community-serving. Member-serving organizations include mutual societies, cooperatives, trade unions, credit unions, industry associations, sports clubs, retired serviceman's clubs and other organizations that benefit a particular group of people - the members of the organization. Typically, community-serving organizations are focused on providing services to the community in general, either globally or locally: organizations delivering human services programs or projects, aid and development programs, medical research, education and health services, and so on.^^xsd:string</para>
    ///   <para>cmns-av:synonym : non-profit organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NotForProfitOrganization">fibo-be-le-fbo:NotForProfitOrganization</a>
    /// </summary>
    let NotForProfitOrganization = _prefixId.prefix "NotForProfitOrganization"
    /// <summary>
    ///   <para>rdfs:label : organization covering agreement^^xsd:string</para>
    ///   <para>skos:definition : contract between the principals in a formal organization that specifies the relationship between the principals, and between the principals and the entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Also covers the aims and purposes of the Entity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/OrganizationCoveringAgreement">fibo-be-le-fbo:OrganizationCoveringAgreement</a>
    /// </summary>
    let OrganizationCoveringAgreement = _prefixId.prefix "OrganizationCoveringAgreement"

    /// <summary>
    ///   <para>rdfs:label : value-added tax identification number^^xsd:string</para>
    ///   <para>skos:definition : tax identifier that identifies a taxable person (business) or non-taxable legal entity for a consumption tax that is assessed incrementally, levied on the price of a product or service at each stage of production, distribution, and sale to the end consumer^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : VATIN^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://ec.europa.eu/taxation_customs/business/vat/eu-vat-rules-topic/vat-identification-numbers_en^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : If the ultimate consumer is a business that collects and pays to the government VAT on its products or services, it can reclaim the tax paid. Not all localities require VAT to be charged, and exports are often exempt. VAT is usually implemented as a destination-based tax, where the tax rate is based on the location of the consumer and applied to the sales price.^^xsd:string</para>
    ///   <para>cmns-av:synonym : VAT identification number^^xsd:stringcmns-av:synonym : VAT registration number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/ValueAddedTaxIdentificationNumber">fibo-be-le-fbo:ValueAddedTaxIdentificationNumber</a>
    /// </summary>
    let ValueAddedTaxIdentificationNumber =
        _prefixId.prefix "ValueAddedTaxIdentificationNumber"

    /// <summary>
    ///   <para>rdfs:label : has equity^^xsd:string</para>
    ///   <para>skos:definition : indicates owners' equity associated with the entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasEquity">fibo-be-le-fbo:hasEquity</a>
    /// </summary>
    let hasEquity = _prefixId.prefix "hasEquity"
    /// <summary>
    ///   <para>rdfs:label : has headquarters address^^xsd:string</para>
    ///   <para>skos:definition : indicates the main address at which communications may be delivered for the organization^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/lei-cdf-format/lei-cdf-format-version-2-1^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasHeadquartersAddress">fibo-be-le-fbo:hasHeadquartersAddress</a>
    /// </summary>
    let hasHeadquartersAddress = _prefixId.prefix "hasHeadquartersAddress"
    /// <summary>
    ///   <para>rdfs:label : has operating address^^xsd:string</para>
    ///   <para>skos:definition : indicates an address at which an organization carries out operations^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasOperatingAddress">fibo-be-le-fbo:hasOperatingAddress</a>
    /// </summary>
    let hasOperatingAddress = _prefixId.prefix "hasOperatingAddress"
    /// <summary>
    ///   <para>rdfs:label : has registered address^^xsd:string</para>
    ///   <para>skos:definition : identifies an address that is officially recorded with some government authority and at which legal papers may be served^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasRegisteredAddress">fibo-be-le-fbo:hasRegisteredAddress</a>
    /// </summary>
    let hasRegisteredAddress = _prefixId.prefix "hasRegisteredAddress"
