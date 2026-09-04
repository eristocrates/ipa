#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-le-cb`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/" "fibo-be-le-cb"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : benefit corporation^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit corporation set up under specific state legislation, typically to provide some social benefit, without an obligation to maximize shareholder return^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is a US-specific type of non-profit corporation defined in recent legislation in a number of states. In California, for example, benefit corporations may be defined as public benefit or mutual benefit corporations, depending on their purpose.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BenefitCorporation">fibo-be-le-cb:BenefitCorporation</a>
    /// </summary>
    let BenefitCorporation = _prefixId.prefix "BenefitCorporation"
    /// <summary>
    ///   <para>rdfs:label : board agreement^^xsd:string</para>
    ///   <para>skos:definition : formal, legally binding agreement between members of the Board of Directors of the organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BoardAgreement">fibo-be-le-cb:BoardAgreement</a>
    /// </summary>
    let BoardAgreement = _prefixId.prefix "BoardAgreement"

    /// <summary>
    ///   <para>rdfs:label : common interest development corporation^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit corporation set up under specific state legislation as a business entity for homeowners' associations^^xsd:string</para>
    ///   <para>skos:example : http://www.dre.ca.gov/files/pdf/re39.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A common interest development is typically a type of housing, composed of individually owned units, such as condominiums, townhouses, or single-family homes, that share ownership of common areas, such as swimming pools, landscaping, and parking. Common interest developments (also known as community interest developments or CIDs) are managed by homeowners' associations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/CommonInterestDevelopmentCorporation">fibo-be-le-cb:CommonInterestDevelopmentCorporation</a>
    /// </summary>
    let CommonInterestDevelopmentCorporation =
        _prefixId.prefix "CommonInterestDevelopmentCorporation"

    /// <summary>
    ///   <para>rdfs:label : corporation</para>
    ///   <para>skos:definition : formal organization that is a legal entity (artificial person) distinct from its owners, created under the jurisdiction of the laws of a state or nation^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A corporation has three distinguishing characteristics: (1) separation of ownership from management and general liability, i.e., its liability to creditors is limited to its resources, unlike some partnerships and sole proprietorships, (2) the ability to negotiate contracts and own property, and (3) transferable ownership, irrespective of changes in membership or the lifetimes of its stockholders.^^xsd:stringcmns-av:explanatoryNote : A corporation is managed by or under the direction of a board of directors, which generally determines corporate policy. Officers manage the day-to-day affairs of the corporation.^^xsd:string</para>
    ///   <para>cmns-av:synonym : body corporate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/Corporation">fibo-be-le-cb:Corporation</a>
    /// </summary>
    let Corporation = _prefixId.prefix "Corporation"
    /// <summary>
    ///   <para>rdfs:label : for profit corporation^^xsd:string</para>
    ///   <para>skos:definition : corporation whose objective is to make money, i.e., to ensure realization of a financial benefit such that the amount of revenue gained from a business activity exceeds the expenses, costs and taxes needed to sustain that activity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ForProfitCorporation">fibo-be-le-cb:ForProfitCorporation</a>
    /// </summary>
    let ForProfitCorporation = _prefixId.prefix "ForProfitCorporation"
    /// <summary>
    ///   <para>rdfs:label : incorporation guarantee^^xsd:string</para>
    ///   <para>skos:definition : guarantee that is part of the financial basis by which some legal entity is incorporated^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/IncorporationGuarantee">fibo-be-le-cb:IncorporationGuarantee</a>
    /// </summary>
    let IncorporationGuarantee = _prefixId.prefix "IncorporationGuarantee"
    /// <summary>
    ///   <para>rdfs:label : instrument of incorporation^^xsd:string</para>
    ///   <para>skos:definition : memorandum and articles of association by which some legal entity is established^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This may be the issuance of shares, the existence of some agreement, guaranties and so on.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/InstrumentOfIncorporation">fibo-be-le-cb:InstrumentOfIncorporation</a>
    /// </summary>
    let InstrumentOfIncorporation = _prefixId.prefix "InstrumentOfIncorporation"
    /// <summary>
    ///   <para>rdfs:label : joint stock company^^xsd:string</para>
    ///   <para>skos:definition : for-profit, unincorporated business that has some characteristics of a corporation and some features of a partnership, with ownership interests represented by shares of stock^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : 1. In the UK, the original (17th century) name for a corporation in which the liability of the owners is limited to the nominal value of the stock (shares) held by them.
    /// 2. In the US, a joint stock company is similar to a corporation, but with unlimited liability for the shareholders. Investors in a US joint stock company receive stock (shares) which can be transferred, and can elect a board of directors, but are jointly-and-severally liable for the company's debts and obligations. A US joint stock company cannot hold title to a real property.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/JointStockCompany">fibo-be-le-cb:JointStockCompany</a>
    /// </summary>
    let JointStockCompany = _prefixId.prefix "JointStockCompany"
    /// <summary>
    ///   <para>rdfs:label : not-for-profit corporation^^xsd:string</para>
    ///   <para>skos:definition : corporation approved by its jurisdictional oversight and tax authorities as operating for educational, charitable, social, religious, civic or humanitarian purposes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A not-for-profit corporation is formed by incorporators, and has a board of directors and officers, but no shareholders. These incorporators, directors and officers may not receive a distribution of (any money from) profits, but officers and management may be paid reasonable salaries for services to the corporation.^^xsd:string</para>
    ///   <para>cmns-av:synonym : non-profit corporation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/NotForProfitCorporation">fibo-be-le-cb:NotForProfitCorporation</a>
    /// </summary>
    let NotForProfitCorporation = _prefixId.prefix "NotForProfitCorporation"
    /// <summary>
    ///   <para>rdfs:label : privately held company^^xsd:string</para>
    ///   <para>skos:definition : corporation whose issued shares are all held by a family or a small group of investors and, therefore, cannot be bought by the public^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For British or Commonwealth companies, a privately held company limited by shares is a type of company incorporated under the laws of England and Wales, Scotland, certain Commonwealth countries and the Republic of Ireland. It has shareholders with limited liability and its shares may not be offered to the general public, unlike those of public limited companies. Limited by shares means that the company has shareholders, and that the liability of the shareholders to creditors of the company is limited to the capital originally invested, i.e. the nominal value of the shares and any premium paid in return for the issue of the shares by the company. A shareholders personal assets are thereby protected in the event of the company's insolvency, but money invested in the company will be lost. A limited company may be private or public. A private limited companys disclosure requirements are lighter, but for this reason its shares may not be offered to the general public (and therefore cannot be traded on a public stock exchange). This is the major distinguishing feature between a private limited company and a public limited company. Most companies, particularly small companies, are private. Private companies limited by shares are required to have the suffix Limited (often written Ltd or Ltd.) or Incorporated (Inc.) as part of their name, though the latter cannot be used in the UK or the Republic of Ireland. In the Republic of Ireland, Teoranta (Teo.) may be used instead, largely by Gaeltacht companies. Cyfyngedig (Cyf.) may be used by Welsh companies in a similar fashion.^^xsd:string</para>
    ///   <para>cmns-av:synonym : closed corporation^^xsd:stringcmns-av:synonym : privately held corporation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PrivatelyHeldCompany">fibo-be-le-cb:PrivatelyHeldCompany</a>
    /// </summary>
    let PrivatelyHeldCompany = _prefixId.prefix "PrivatelyHeldCompany"
    /// <summary>
    ///   <para>rdfs:label : publicly held company^^xsd:string</para>
    ///   <para>skos:definition : corporation whose shares are traded and held publicly^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PubliclyHeldCompany">fibo-be-le-cb:PubliclyHeldCompany</a>
    /// </summary>
    let PubliclyHeldCompany = _prefixId.prefix "PubliclyHeldCompany"
    /// <summary>
    ///   <para>rdfs:label : registration identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that is officially allocated to an organization at the time of registration, typically in a jurisdiction in which said organization is organized or registered and used in that jurisdiction to identify the organization^^xsd:string</para>
    ///   <para>skos:scopeNote : In some jurisdictions, such as the State of California, registration identifiers are issued to corporations, including non-profit corporations, limited liability companies, certain partnerships, and foreign corporations doing business in California. The same or a very similar process is used for registration of corporations across the US.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A registration identifier may be required for official communications and is publicly available. The relationship to the jurisdiction in which the organization is organized or registered is typically required, but is optional here to cover cases where jurisdictions may overlap or are not as clearly defined.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifier">fibo-be-le-cb:RegistrationIdentifier</a>
    /// </summary>
    let RegistrationIdentifier = _prefixId.prefix "RegistrationIdentifier"
    /// <summary>
    ///   <para>rdfs:label : registration identifier scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme that defines the registration identifier per the issuing registration authority^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifierScheme">fibo-be-le-cb:RegistrationIdentifierScheme</a>
    /// </summary>
    let RegistrationIdentifierScheme = _prefixId.prefix "RegistrationIdentifierScheme"
    /// <summary>
    ///   <para>rdfs:label : religious corporation^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit corporation whose objective is specific to some fundamental set of beliefs and practices generally agreed upon by a number of people, and that is incorporated under the law^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Often religious corporations are recognized under the law on a sub-national level, for instance by a state or provincial government. The government agency responsible for regulating such corporations is usually the official holder of records, for instance a state department of corporations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ReligiousCorporation">fibo-be-le-cb:ReligiousCorporation</a>
    /// </summary>
    let ReligiousCorporation = _prefixId.prefix "ReligiousCorporation"
    /// <summary>
    ///   <para>rdfs:label : stock corporation</para>
    ///   <para>skos:definition : corporation that has shareholders, each of whom receives a portion of the ownership of the corporation through shares of stock^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.oecd.org/corporate/OECD-Corporate-Governance-Factbook.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The shares in a stock corporation may receive a return on their investment in the form of dividends. Shares are used for voting on matters of corporate policy or to elect directors, at the corporation's annual meeting and at other meetings of the corporation.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/StockCorporation">fibo-be-le-cb:StockCorporation</a>
    /// </summary>
    let StockCorporation = _prefixId.prefix "StockCorporation"
    /// <summary>
    ///   <para>rdfs:label : has date of incorporation^^xsd:string</para>
    ///   <para>skos:definition : indicates the formal date of incorporation as stated in filing documents^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfIncorporation">fibo-be-le-cb:hasDateOfIncorporation</a>
    /// </summary>
    let hasDateOfIncorporation = _prefixId.prefix "hasDateOfIncorporation"
    /// <summary>
    ///   <para>rdfs:label : has date of registration^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which the corporation has registered in some jurisdiction for regulatory and / or for tax purposes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfRegistration">fibo-be-le-cb:hasDateOfRegistration</a>
    /// </summary>
    let hasDateOfRegistration = _prefixId.prefix "hasDateOfRegistration"
    /// <summary>
    ///   <para>rdfs:label : has issued capital^^xsd:string</para>
    ///   <para>skos:definition : indicates the aggregate value of all shares held by shareholders^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A corporation can, at any time, issue new shares up to the full amount of authorized share capital.^^xsd:string</para>
    ///   <para>cmns-av:synonym : has subscribed capital^^xsd:stringcmns-av:synonym : has subscribed share capital^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasIssuedCapital">fibo-be-le-cb:hasIssuedCapital</a>
    /// </summary>
    let hasIssuedCapital = _prefixId.prefix "hasIssuedCapital"
    /// <summary>
    ///   <para>rdfs:label : has shares authorized</para>
    ///   <para>skos:definition : indicates the maximum number of shares that are permitted to be issued, as established by the board of directors</para>
    ///   <para>cmns-av:explanatoryNote : An initial number of authorized shares is typically established at the time of incorporation, and is documented in articles of incorporation. The number of shares authorized may be extended from time to time by the board of directors as needed, and articles of incorporation and other legal documentation will be amended accordingly. It includes shares that are available, but not yet issued, for sale to generate capital, and shares available for distribution to insiders as part of their compensation packages.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasSharesAuthorized">fibo-be-le-cb:hasSharesAuthorized</a>
    /// </summary>
    let hasSharesAuthorized = _prefixId.prefix "hasSharesAuthorized"
    /// <summary>
    ///   <para>rdfs:label : is constituted by^^xsd:string</para>
    ///   <para>skos:definition : the instrument by which an entity is incorporated^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isConstitutedBy">fibo-be-le-cb:isConstitutedBy</a>
    /// </summary>
    let isConstitutedBy = _prefixId.prefix "isConstitutedBy"
    /// <summary>
    ///   <para>rdfs:label : is incorporated in^^xsd:string</para>
    ///   <para>skos:definition : the legal jurisdiction under which the legal entity is incorporated^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : It is the laws of this jurisdiction that cause and allow the legal entity to exist and to incur debt and be sued at law as a legal entity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isIncorporatedIn">fibo-be-le-cb:isIncorporatedIn</a>
    /// </summary>
    let isIncorporatedIn = _prefixId.prefix "isIncorporatedIn"
