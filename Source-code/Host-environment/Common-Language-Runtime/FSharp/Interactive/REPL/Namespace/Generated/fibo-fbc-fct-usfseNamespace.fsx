#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-usfse`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/" "fibo-fbc-fct-usfse"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : agency of a foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : place of business of a foreign bank, located in any state, at which credit balances are maintained, checks are paid, money is lent, or, to the extent not prohibited by state or federal law, deposits are accepted from a person or entity that is not a citizen or resident of the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Obligations shall not be considered credit balances unless they are:
    /// (1) Incidental to, or arise out of the exercise of, other lawful banking powers;
    /// (2) To serve a specific purpose;
    /// (3) Not solicited from the general public;
    /// (4) Not used to pay routine operating expenses in the United States such as salaries, rent, or taxes;
    /// (5) Withdrawn within a reasonable period of time after the specific purpose for which they were placed has been accomplished; and
    /// (6) Drawn upon in a manner reasonable in relation to the size and nature of the account.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgencyOfAForeignBankingOrganization">fibo-fbc-fct-usfse:AgencyOfAForeignBankingOrganization</a>
    /// </summary>
    let AgencyOfAForeignBankingOrganization =
        _prefixId.prefix "AgencyOfAForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : agreement corporation^^xsd:string</para>
    ///   <para>skos:definition : corporation chartered by a state to engage in international banking, so named because the corporation enters into an 'agreement' with the Fed's Board of Governors that it will limit its activities to those permitted^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation">fibo-fbc-fct-usfse:AgreementCorporation</a>
    /// </summary>
    let AgreementCorporation = _prefixId.prefix "AgreementCorporation"
    /// <summary>
    ///   <para>rdfs:label : agreement corporation - banking^^xsd:string</para>
    ///   <para>skos:definition : agreement corporation whose charter allows the corporation to engage in international banking^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation-Banking">fibo-fbc-fct-usfse:AgreementCorporation-Banking</a>
    /// </summary>
    let AgreementCorporation_Banking = _prefixId.prefix "AgreementCorporation-Banking"

    /// <summary>
    ///   <para>rdfs:label : agreement corporation - investment^^xsd:string</para>
    ///   <para>skos:definition : agreement corporation whose charter allows the corporation to engage in international investment banking^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation-Investment">fibo-fbc-fct-usfse:AgreementCorporation-Investment</a>
    /// </summary>
    let AgreementCorporation_Investment =
        _prefixId.prefix "AgreementCorporation-Investment"

    /// <summary>
    ///   <para>rdfs:label : bankers' bank^^xsd:string</para>
    ///   <para>skos:definition : commercial bank owned exclusively (except to the extent directors' qualifying shares are required by law) by other depository institutions or depository institution holding companies, the activities of which are limited by its articles of association exclusively to providing services to or for other depository institutions, their holding companies, and the officers, directors, and employees of such institutions and companies, and to providing correspondent banking services at the request of other depository institutions or their holding companies^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Depository Institutions Deregulation and Monetary Control Act of 1980, available at https://www.govinfo.gov/content/pkg/STATUTE-94/pdf/STATUTE-94-Pg132.pdf, section 711^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Bankers' banks are typically (1) organized solely to do business with other financial institutions (with the exceptions defined herein), (2) owned primarily by the financial institutions with which they conduct business, and (3) do not do business with the general public.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBank">fibo-fbc-fct-usfse:BankersBank</a>
    /// </summary>
    let BankersBank = _prefixId.prefix "BankersBank"

    /// <summary>
    ///   <para>rdfs:label : bankers' bank that is not subject to reserve requirements^^xsd:string</para>
    ///   <para>skos:definition : bankers' bank whose activities are not limited by specific requirements of the Federal Reserve^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/DataDownload/NPW%20Data%20Dictionary.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBankNotSubjectToReserveRequirements">fibo-fbc-fct-usfse:BankersBankNotSubjectToReserveRequirements</a>
    /// </summary>
    let BankersBankNotSubjectToReserveRequirements =
        _prefixId.prefix "BankersBankNotSubjectToReserveRequirements"

    /// <summary>
    ///   <para>rdfs:label : bankers' bank subject to reserve requirements^^xsd:string</para>
    ///   <para>skos:definition : bankers' bank whose activities are limited by specific requirements of the Federal Reserve^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/DataDownload/NPW%20Data%20Dictionary.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBankSubjectToReserveRequirements">fibo-fbc-fct-usfse:BankersBankSubjectToReserveRequirements</a>
    /// </summary>
    let BankersBankSubjectToReserveRequirements =
        _prefixId.prefix "BankersBankSubjectToReserveRequirements"

    /// <summary>
    ///   <para>rdfs:label : branch of a depository institution^^xsd:string</para>
    ///   <para>skos:definition : any office or any place of business located in any State of the United States at which deposits are received^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BranchOfADepositoryInstitution">fibo-fbc-fct-usfse:BranchOfADepositoryInstitution</a>
    /// </summary>
    let BranchOfADepositoryInstitution =
        _prefixId.prefix "BranchOfADepositoryInstitution"

    /// <summary>
    ///   <para>rdfs:label : commercial lending company^^xsd:string</para>
    ///   <para>skos:definition : any institution, other than a bank or an organization operating under section 25 of the Federal Reserve Act [12 U.S.C. 601 et seq.], organized under the laws of any State of the United States, or the District of Columbia which maintains credit balances incidental to or arising out of the exercise of banking powers and engages in the business of making commercial loans^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/USCODE-2021-title12/pdf/USCODE-2021-title12-chap32-sec3101.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/CommercialLendingCompany">fibo-fbc-fct-usfse:CommercialLendingCompany</a>
    /// </summary>
    let CommercialLendingCompany = _prefixId.prefix "CommercialLendingCompany"
    /// <summary>
    ///   <para>rdfs:label : cooperative bank^^xsd:string</para>
    ///   <para>skos:definition : state-chartered savings association that is organized and operates according to the laws of the state in which it is chartered or organized, including Massachusetts, New Hampshire, Rhode Island or Vermont^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/CooperativeBank">fibo-fbc-fct-usfse:CooperativeBank</a>
    /// </summary>
    let CooperativeBank = _prefixId.prefix "CooperativeBank"
    /// <summary>
    ///   <para>rdfs:label : domestic branch of a foreign bank^^xsd:string</para>
    ///   <para>skos:definition : place of business of a foreign bank, located in any state, at which deposits are received, and that is not an agency as defined in https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticBranchOfAForeignBank">fibo-fbc-fct-usfse:DomesticBranchOfAForeignBank</a>
    /// </summary>
    let DomesticBranchOfAForeignBank = _prefixId.prefix "DomesticBranchOfAForeignBank"
    /// <summary>
    ///   <para>rdfs:label : domestic branch of domestic bank^^xsd:string</para>
    ///   <para>skos:definition : branch that resides in the United States, and whose parent is also located in the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticBranchOfDomesticBank">fibo-fbc-fct-usfse:DomesticBranchOfDomesticBank</a>
    /// </summary>
    let DomesticBranchOfDomesticBank = _prefixId.prefix "DomesticBranchOfDomesticBank"
    /// <summary>
    ///   <para>rdfs:label : domestic entity^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that is incorporated and domiciled in the United States^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticEntity">fibo-fbc-fct-usfse:DomesticEntity</a>
    /// </summary>
    let DomesticEntity = _prefixId.prefix "DomesticEntity"
    /// <summary>
    ///   <para>rdfs:label : domestic entity other^^xsd:string</para>
    ///   <para>skos:definition : domestic institution that engages in banking activities usually in connection with the business of banking in the United States^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : DEO^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : This classification is used primarily to cover organizations acting as financial institutions in the US that are not otherwise classified in the context of the National Information Center (NIC).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticEntityOther">fibo-fbc-fct-usfse:DomesticEntityOther</a>
    /// </summary>
    let DomesticEntityOther = _prefixId.prefix "DomesticEntityOther"

    /// <summary>
    ///   <para>rdfs:label : domestic non-bank subsidiary of a domestic entity^^xsd:string</para>
    ///   <para>skos:definition : non-bank financial service provider based in the United States of which 25 percent or more of whose voting shares are owned or controlled by an entity that is also based in the United States, or of which a majority of its directors are controlled by such domestic entity, or of which 25 percent or more of whose voting shares are held by trustees for the benefit of the shareholders or members of such domestic entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticNonBankSubsidiaryOfADomesticEntity">fibo-fbc-fct-usfse:DomesticNonBankSubsidiaryOfADomesticEntity</a>
    /// </summary>
    let DomesticNonBankSubsidiaryOfADomesticEntity =
        _prefixId.prefix "DomesticNonBankSubsidiaryOfADomesticEntity"

    /// <summary>
    ///   <para>rdfs:label : edge corporation^^xsd:string</para>
    ///   <para>skos:definition : corporation chartered by the Federal Reserve to engage in international banking and financial operations^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation">fibo-fbc-fct-usfse:EdgeCorporation</a>
    /// </summary>
    let EdgeCorporation = _prefixId.prefix "EdgeCorporation"
    /// <summary>
    ///   <para>rdfs:label : edge corporation - banking^^xsd:string</para>
    ///   <para>skos:definition : edge corporation whose charter allows the corporation to engage in international banking^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-Banking">fibo-fbc-fct-usfse:EdgeCorporation-Banking</a>
    /// </summary>
    let EdgeCorporation_Banking = _prefixId.prefix "EdgeCorporation-Banking"

    /// <summary>
    ///   <para>rdfs:label : edge corporation - domestic branch^^xsd:string</para>
    ///   <para>skos:definition : branch of an edge corporation that is located in the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-DomesticBranch">fibo-fbc-fct-usfse:EdgeCorporation-DomesticBranch</a>
    /// </summary>
    let EdgeCorporation_DomesticBranch =
        _prefixId.prefix "EdgeCorporation-DomesticBranch"

    /// <summary>
    ///   <para>rdfs:label : edge corporation - investment^^xsd:string</para>
    ///   <para>skos:definition : edge corporation whose charter allows the corporation to engage in international investment banking^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-Investment">fibo-fbc-fct-usfse:EdgeCorporation-Investment</a>
    /// </summary>
    let EdgeCorporation_Investment = _prefixId.prefix "EdgeCorporation-Investment"
    /// <summary>
    ///   <para>rdfs:label : farm credit system institution^^xsd:string</para>
    ///   <para>skos:definition : federally-chartered financial institution that is supervised, examined, and regulated by the Farm Credit Administration and operates in accordance with the Farm Credit Act of 1971, as amended, 12 U.S.C. 2001 et seq^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : All Farm Credit System institutions are federally-chartered instrumentalities of the United States.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FarmCreditSystemInstitution">fibo-fbc-fct-usfse:FarmCreditSystemInstitution</a>
    /// </summary>
    let FarmCreditSystemInstitution = _prefixId.prefix "FarmCreditSystemInstitution"

    /// <summary>
    ///   <para>rdfs:label : federal agency of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : agency of a foreign bank established and operating under section 3102 of CFR Title 12, Chapter 32 and section 4 of the International Banking Act of 1978^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/USCODE-2021-title12/pdf/USCODE-2021-title12-chap32-sec3101.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalAgencyOfForeignBankingOrganization">fibo-fbc-fct-usfse:FederalAgencyOfForeignBankingOrganization</a>
    /// </summary>
    let FederalAgencyOfForeignBankingOrganization =
        _prefixId.prefix "FederalAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : federal branch of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : branch of a foreign bank established and operating under section 3102 of CFR Title 12, Chapter 32 and section 4 of the International Banking Act of 1978^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/USCODE-2021-title12/pdf/USCODE-2021-title12-chap32-sec3101.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalBranchOfForeignBankingOrganization">fibo-fbc-fct-usfse:FederalBranchOfForeignBankingOrganization</a>
    /// </summary>
    let FederalBranchOfForeignBankingOrganization =
        _prefixId.prefix "FederalBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : federal credit union^^xsd:string</para>
    ///   <para>skos:definition : credit union that has a federal affiliation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalCreditUnion">fibo-fbc-fct-usfse:FederalCreditUnion</a>
    /// </summary>
    let FederalCreditUnion = _prefixId.prefix "FederalCreditUnion"
    /// <summary>
    ///   <para>rdfs:label : federal savings bank^^xsd:string</para>
    ///   <para>skos:definition : savings bank that has a federal affiliation^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalSavingsBank">fibo-fbc-fct-usfse:FederalSavingsBank</a>
    /// </summary>
    let FederalSavingsBank = _prefixId.prefix "FederalSavingsBank"
    /// <summary>
    ///   <para>rdfs:label : financial holding company^^xsd:string</para>
    ///   <para>skos:definition : financial entity engaged in a broad range of banking-related activities as permitted under the Gramm-Leach-Bliley Act of 1999^^xsd:string</para>
    ///   <para>skos:note : Can be a domestic or foreign domiciled holding company^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : These activities include: insurance underwriting, securities dealing and underwriting, financial and investment advisory services, merchant banking, issuing or selling securitized interests in bank-eligible assets, and generally engaging in any non-banking activity authorized by the Bank Holding Company Act. The Federal Reserve Board is responsible for supervising the financial condition and activities of financial holding companies. Similarly, any non-bank commercial company that is predominantly engaged in financial activities, earning 85 percent or more of its gross revenues from financial services, may choose to become a financial holding company. These companies are required to sell any non-financial (commercial) businesses within ten years.^^xsd:string</para>
    ///   <para>cmns-av:synonym : Financial Holding Company / BHC^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FinancialHoldingCompany">fibo-fbc-fct-usfse:FinancialHoldingCompany</a>
    /// </summary>
    let FinancialHoldingCompany = _prefixId.prefix "FinancialHoldingCompany"
    /// <summary>
    ///   <para>rdfs:label : foreign bank^^xsd:string</para>
    ///   <para>skos:definition : financial institution organized under the laws of a foreign country, a territory of the United States, Puerto Rico, Guam, American Samoa, or the Virgin Islands, which engages in the business of banking, or any subsidiary or affiliate, organized under such laws, of any such institution^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/HELP/Institution%20Type%20Description.htm^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : For the purposes of the International Banking Act of 1978, the term 'foreign bank' includes, without limitation, foreign commercial banks, foreign merchant banks and other foreign institutions that engage in banking activities usual in connection with the business of banking in the countries where such foreign institutions are organized or operating.^^xsd:stringcmns-av:explanatoryNote : Foreign bank means an organization that is organized under the laws of a foreign country and that engages directly in the business of banking outside the United States. The term foreign bank does not include a central bank of a foreign country that does not engage or seek to engage in a commercial banking business in the United States through an office.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBank">fibo-fbc-fct-usfse:ForeignBank</a>
    /// </summary>
    let ForeignBank = _prefixId.prefix "ForeignBank"
    /// <summary>
    ///   <para>rdfs:label : foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that is headquartered outside the United States and that can acquire or establish freestanding banks or bank holding companies in the United States^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : FBO^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/HELP/Institution%20Type%20Description.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Foreign banking organization means:
    /// (1) A foreign bank, as defined in section 1(b)(7) of the International Banking Act of 1978 (12 U.S.C. 3101(7)), that:
    /// 	(i) Operates a branch, agency, or commercial lending company subsidiary in the United States;
    /// 	(ii) Controls a bank in the United States; or
    /// 	(iii) Controls an Edge corporation acquired after March 5, 1987; and
    /// (2) Any company of which the foreign bank is a subsidiary.^^xsd:stringcmns-av:explanatoryNote : These entities are regulated and supervised as domestic institutions.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganization">fibo-fbc-fct-usfse:ForeignBankingOrganization</a>
    /// </summary>
    let ForeignBankingOrganization = _prefixId.prefix "ForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : foreign banking organization as a bank holding company^^xsd:string</para>
    ///   <para>skos:definition : foreign banking organization that is a bank holding company in the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/HELP/Institution%20Type%20Description.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A foreign banking organization that also acts as a bank holding company is thus supervised by the Board of Governors of the Federal Reserve.^^xsd:string</para>
    ///   <para>cmns-av:synonym : Financial Holding Company / FBO^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganizationAsABankHoldingCompany">fibo-fbc-fct-usfse:ForeignBankingOrganizationAsABankHoldingCompany</a>
    /// </summary>
    let ForeignBankingOrganizationAsABankHoldingCompany =
        _prefixId.prefix "ForeignBankingOrganizationAsABankHoldingCompany"

    /// <summary>
    ///   <para>rdfs:label : foreign banking organization of a bank holding company^^xsd:string</para>
    ///   <para>skos:definition : foreign banking organization that is owned or controlled by a bank holding company^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/nicpubweb/Content/HELP/Institution%20Type%20Description.htm^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganizationOfABankHoldingCompany">fibo-fbc-fct-usfse:ForeignBankingOrganizationOfABankHoldingCompany</a>
    /// </summary>
    let ForeignBankingOrganizationOfABankHoldingCompany =
        _prefixId.prefix "ForeignBankingOrganizationOfABankHoldingCompany"

    /// <summary>
    ///   <para>rdfs:label : foreign branch of foreign bank^^xsd:string</para>
    ///   <para>skos:definition : branch that resides outside of the United States whose parent is located outside of the United States^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfForeignBank">fibo-fbc-fct-usfse:ForeignBranchOfForeignBank</a>
    /// </summary>
    let ForeignBranchOfForeignBank = _prefixId.prefix "ForeignBranchOfForeignBank"

    /// <summary>
    ///   <para>rdfs:label : foreign branch of foreign bank managed by US office^^xsd:string</para>
    ///   <para>skos:definition : branch that resides outside of the United States whose parent is located outside of the United States that is managed by a US branch or agency of the foreign bank^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfForeignBankManagedByUSOffice">fibo-fbc-fct-usfse:ForeignBranchOfForeignBankManagedByUSOffice</a>
    /// </summary>
    let ForeignBranchOfForeignBankManagedByUSOffice =
        _prefixId.prefix "ForeignBranchOfForeignBankManagedByUSOffice"

    /// <summary>
    ///   <para>rdfs:label : foreign branch of US bank^^xsd:string</para>
    ///   <para>skos:definition : branch that resides outside of the United States, but has a parent that is located in the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfUSBank">fibo-fbc-fct-usfse:ForeignBranchOfUSBank</a>
    /// </summary>
    let ForeignBranchOfUSBank = _prefixId.prefix "ForeignBranchOfUSBank"
    /// <summary>
    ///   <para>rdfs:label : foreign entity other^^xsd:string</para>
    ///   <para>skos:definition : foreign institution that engages in banking activities usually in connection with the business of banking in the countries where such foreign institutions are organized or operating^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignEntityOther">fibo-fbc-fct-usfse:ForeignEntityOther</a>
    /// </summary>
    let ForeignEntityOther = _prefixId.prefix "ForeignEntityOther"
    /// <summary>
    ///   <para>rdfs:label : industrial bank^^xsd:string</para>
    ///   <para>skos:definition : limited service financial institution that raises funds by selling certificates called 'investment shares' and by accepting deposits^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Often called Morris Plan banks or industrial loan companies, industrial banks are distinguished from commercial loan companies because industrial banks accept deposits in addition to making consumer loans. Industrial banks differ from commercial banks because they do not offer demand deposit (checking) accounts. Industrial banks are not regulated by the Federal Reserve.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/IndustrialBank">fibo-fbc-fct-usfse:IndustrialBank</a>
    /// </summary>
    let IndustrialBank = _prefixId.prefix "IndustrialBank"

    /// <summary>
    ///   <para>rdfs:label : insured federal branch of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : any office or any place of business of a foreign bank located in any State of the United States at which deposits are received established and operating under section 4 of the International Banking Act of 1978 that is insured and regulated by the Federal Deposit Insurance Corporation (FDIC)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InsuredFederalBranchOfForeignBankingOrganization">fibo-fbc-fct-usfse:InsuredFederalBranchOfForeignBankingOrganization</a>
    /// </summary>
    let InsuredFederalBranchOfForeignBankingOrganization =
        _prefixId.prefix "InsuredFederalBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : insured state branch of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : any office or any place of business of a foreign bank located in any State of the United States at which deposits are received, established and operating under the laws of that State that is insured and regulated by the Federal Deposit Insurance Corporation (FDIC)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InsuredStateBranchOfForeignBankingOrganization">fibo-fbc-fct-usfse:InsuredStateBranchOfForeignBankingOrganization</a>
    /// </summary>
    let InsuredStateBranchOfForeignBankingOrganization =
        _prefixId.prefix "InsuredStateBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : intermediate holding company^^xsd:string</para>
    ///   <para>skos:definition : bank holding company established or designated by a foreign banking organization under subpart O of the Federal Reserve Board's Regulation YY (12 CFR part 252)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/IntermediateHoldingCompany">fibo-fbc-fct-usfse:IntermediateHoldingCompany</a>
    /// </summary>
    let IntermediateHoldingCompany = _prefixId.prefix "IntermediateHoldingCompany"

    /// <summary>
    ///   <para>rdfs:label : international bank of US depositary, edge, trust company^^xsd:string</para>
    ///   <para>skos:definition : bank that is owned or controlled by a US depository institution, Edge Act corporation or trust company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InternationalBankOfUSDepositoryEdgeTrustCompany">fibo-fbc-fct-usfse:InternationalBankOfUSDepositoryEdgeTrustCompany</a>
    /// </summary>
    let InternationalBankOfUSDepositoryEdgeTrustCompany =
        _prefixId.prefix "InternationalBankOfUSDepositoryEdgeTrustCompany"

    /// <summary>
    ///   <para>rdfs:label : international non-bank subsidiary of a domestic entity^^xsd:string</para>
    ///   <para>skos:definition : non-bank financial service provider based outside of the United States of which 25 percent or more of whose voting shares are owned or controlled by an entity that is based in the United States, or of which a majority of its directors are controlled by such domestic entity, or of which 25 percent or more of whose voting shares are held by trustees for the benefit of the shareholders or members of such domestic entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InternationalNonBankSubsidiaryOfADomesticEntity">fibo-fbc-fct-usfse:InternationalNonBankSubsidiaryOfADomesticEntity</a>
    /// </summary>
    let InternationalNonBankSubsidiaryOfADomesticEntity =
        _prefixId.prefix "InternationalNonBankSubsidiaryOfADomesticEntity"

    /// <summary>
    ///   <para>rdfs:label : limited branch of a foreign bank^^xsd:string</para>
    ///   <para>skos:definition : branch of a foreign bank that receives only such deposits as would be permitted for a corporation organized under section 25A of the Federal Reserve Act (12 U.S.C. 611-631)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/LimitedBranchOfAForeignBank">fibo-fbc-fct-usfse:LimitedBranchOfAForeignBank</a>
    /// </summary>
    let LimitedBranchOfAForeignBank = _prefixId.prefix "LimitedBranchOfAForeignBank"
    /// <summary>
    ///   <para>rdfs:label : mutual savings bank^^xsd:string</para>
    ///   <para>skos:definition : financial institution that accepts deposits primarily from individuals and places a large portion of its funds into mortgage loans^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/MutualSavingsBank">fibo-fbc-fct-usfse:MutualSavingsBank</a>
    /// </summary>
    let MutualSavingsBank = _prefixId.prefix "MutualSavingsBank"
    /// <summary>
    ///   <para>rdfs:label : national bank^^xsd:string</para>
    ///   <para>skos:definition : commercial bank whose charter is approved by the Office of the Comptroller of the Currency (OCC) rather than by a state banking agency^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes#non-mem-banks^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : National Banks are required to be members of the Federal Reserve System and belong to the Federal Deposit Insurance Corporation.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NationalBank">fibo-fbc-fct-usfse:NationalBank</a>
    /// </summary>
    let NationalBank = _prefixId.prefix "NationalBank"

    /// <summary>
    ///   <para>rdfs:label : New York Article XII investment company^^xsd:string</para>
    ///   <para>skos:definition : specialized non-depository lending institution that has broad borrowing and lending powers and may invest in stocks and bonds^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.dfs.ny.gov/institution_definition^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An Article XII Investment Company is not an 'investment company' subject to registration under the Investment Company Act of 1940. An Article XII Investment Company may accept credit balances in New York that are incidental to the exercise of its other powers and may accept deposits outside New York with the approval of the Superintendent. Article XII Investment Companies may specialize in commercial or retail sales finance; others are involved in domestic and international commercial and merchant banking.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NewYorkArticleXIIInvestmentCompany">fibo-fbc-fct-usfse:NewYorkArticleXIIInvestmentCompany</a>
    /// </summary>
    let NewYorkArticleXIIInvestmentCompany =
        _prefixId.prefix "NewYorkArticleXIIInvestmentCompany"

    /// <summary>
    ///   <para>rdfs:label : non-bank subsidiary of a domestic entity^^xsd:string</para>
    ///   <para>skos:definition : non-bank entity of which 25 percent or more of whose voting shares are owned or controlled by an entity that is based in the United States, or of which a majority of its directors are controlled by such domestic entity, or of which 25 percent or more of whose voting shares are held by trustees for the benefit of the shareholders or members of such domestic entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NonBankSubsidiaryOfADomesticEntity">fibo-fbc-fct-usfse:NonBankSubsidiaryOfADomesticEntity</a>
    /// </summary>
    let NonBankSubsidiaryOfADomesticEntity =
        _prefixId.prefix "NonBankSubsidiaryOfADomesticEntity"

    /// <summary>
    ///   <para>rdfs:label : non-depository trust company^^xsd:string</para>
    ///   <para>skos:definition : trust company that accepts and executes trusts, but does not issue currency; non-depository trust companies can either be Federal Reserve Members or Federal Reserve Non-members^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NonDepositoryTrustCompany">fibo-fbc-fct-usfse:NonDepositoryTrustCompany</a>
    /// </summary>
    let NonDepositoryTrustCompany = _prefixId.prefix "NonDepositoryTrustCompany"
    /// <summary>
    ///   <para>rdfs:label : office of a foreign bank^^xsd:string</para>
    ///   <para>skos:definition : facility that is any branch, agency, representative office, or commercial lending company subsidiary of a foreign bank in the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/OfficeOfAForeignBank">fibo-fbc-fct-usfse:OfficeOfAForeignBank</a>
    /// </summary>
    let OfficeOfAForeignBank = _prefixId.prefix "OfficeOfAForeignBank"

    /// <summary>
    ///   <para>rdfs:label : regional administrative office of a foreign bank^^xsd:string</para>
    ///   <para>skos:definition : representative office that
    /// (1) Is established by a foreign bank that operates two or more branches, agencies, commercial lending companies, or banks in the United States;
    /// (2) Is located in the same city as one or more of the foreign bank's branches, agencies, commercial lending companies, or banks in the United States;
    /// (3) Manages, supervises, or coordinates the operations of the foreign bank or its affiliates, if any, in a particular geographic area that includes the United States or a region thereof, including by exercising credit approval authority in that area pursuant to written standards, credit policies, and procedures established by the foreign bank; and
    /// (4) Does not solicit business from actual or potential customers of the foreign bank or its affiliates.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : regional administrative office^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/RegionalAdministrativeOfficeOfAForeignBank">fibo-fbc-fct-usfse:RegionalAdministrativeOfficeOfAForeignBank</a>
    /// </summary>
    let RegionalAdministrativeOfficeOfAForeignBank =
        _prefixId.prefix "RegionalAdministrativeOfficeOfAForeignBank"

    /// <summary>
    ///   <para>rdfs:label : representative office of a foreign bank^^xsd:string</para>
    ///   <para>skos:definition : office of a foreign bank which is located in any state and is not a federal branch, federal agency, state branch, state agency, or commercial lending company subsidiary^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : representative office^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/RepresentativeOfficeOfAForeignBank">fibo-fbc-fct-usfse:RepresentativeOfficeOfAForeignBank</a>
    /// </summary>
    let RepresentativeOfficeOfAForeignBank =
        _prefixId.prefix "RepresentativeOfficeOfAForeignBank"

    /// <summary>
    ///   <para>rdfs:label : savings bank^^xsd:string</para>
    ///   <para>skos:definition : banking institution organized to accept savings deposits and pay interest on those savings deposits^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Savings banks can have state and federal affiliations, for example, State Savings Banks and Federal Savings Banks^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsBank">fibo-fbc-fct-usfse:SavingsBank</a>
    /// </summary>
    let SavingsBank = _prefixId.prefix "SavingsBank"
    /// <summary>
    ///   <para>rdfs:label : savings loan association^^xsd:string</para>
    ///   <para>skos:definition : financial institution that accepts deposits primarily from individuals and channels its funds primarily into residential mortgage loans^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : savings and loan association^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsLoanAssociation">fibo-fbc-fct-usfse:SavingsLoanAssociation</a>
    /// </summary>
    let SavingsLoanAssociation = _prefixId.prefix "SavingsLoanAssociation"
    /// <summary>
    ///   <para>rdfs:label : savings loan holding company^^xsd:string</para>
    ///   <para>skos:definition : company that directly or indirectly controls a savings association or related holding company, and explicitly excludes any company that is also a bank holding company^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : savings and loan holding company^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsLoanHoldingCompany">fibo-fbc-fct-usfse:SavingsLoanHoldingCompany</a>
    /// </summary>
    let SavingsLoanHoldingCompany = _prefixId.prefix "SavingsLoanHoldingCompany"

    /// <summary>
    ///   <para>rdfs:label : state agency of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : agency of a foreign bank established and operating under the laws of any state, where state means any State of the United States or the District of Columbia^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURIcmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/USCODE-2021-title12/pdf/USCODE-2021-title12-chap32-sec3101.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateAgencyOfForeignBankingOrganization">fibo-fbc-fct-usfse:StateAgencyOfForeignBankingOrganization</a>
    /// </summary>
    let StateAgencyOfForeignBankingOrganization =
        _prefixId.prefix "StateAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : state branch of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : branch of a foreign bank located in any State of the United States at which deposits are received, established and operating under the laws of that State, where state means any State of the United States or the District of Columbia^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateBranchOfForeignBankingOrganization">fibo-fbc-fct-usfse:StateBranchOfForeignBankingOrganization</a>
    /// </summary>
    let StateBranchOfForeignBankingOrganization =
        _prefixId.prefix "StateBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : state-chartered bank^^xsd:string</para>
    ///   <para>skos:definition : commercial bank whose charter is approved by a state banking regulator^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A state bank is defined as any bank, banking association, trust company, savings bank, industrial bank (or similar depository institution operating substantially in the same manner as an industrial bank), or other banking institution which is engaged in the business of receiving deposits other than trust funds, and in the US, is incorporated under the laws of any State or which is operating under the Code of Law for the District of Columbia, including any cooperative bank or other unincorporated bank the deposits of which were insured by the Federal Deposit Insurance Corporation on the day before the date of the enactment of the Financial Institutions Reform, Recovery, and Enforcement Act of 1989.^^xsd:stringcmns-av:explanatoryNote : State-chartered banks may or may not be members of the Federal Reserve System, but typically belong to the Federal Deposit Insurance Corporation, who may be their primary federal regulator for those that are not FRS members.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateCharteredBank">fibo-fbc-fct-usfse:StateCharteredBank</a>
    /// </summary>
    let StateCharteredBank = _prefixId.prefix "StateCharteredBank"
    /// <summary>
    ///   <para>rdfs:label : state credit union^^xsd:string</para>
    ///   <para>skos:definition : credit union that has a state affiliation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateCreditUnion">fibo-fbc-fct-usfse:StateCreditUnion</a>
    /// </summary>
    let StateCreditUnion = _prefixId.prefix "StateCreditUnion"
    /// <summary>
    ///   <para>rdfs:label : state savings bank^^xsd:string</para>
    ///   <para>skos:definition : savings bank that has a state affiliation^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateSavingsBank">fibo-fbc-fct-usfse:StateSavingsBank</a>
    /// </summary>
    let StateSavingsBank = _prefixId.prefix "StateSavingsBank"
    /// <summary>
    ///   <para>rdfs:label : subsidiary of a domestic entity^^xsd:string</para>
    ///   <para>skos:definition : entity of which 25 percent or more of whose voting shares are owned or controlled by an entity that is based in the United States, or of which a majority of its directors are controlled by such domestic entity, or of which 25 percent or more of whose voting shares are held by trustees for the benefit of the shareholders or members of such domestic entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : From the perspective of the International Banking Act of 1978, the definition of subsidiary is the definition from the Bank Holding Act of 1956. Thus, the meaining of the term 'subsidiary' with respect to the NIC repository and, specifically, with respect to the definition of an 'international non-bank subsidiary of a domestic entity', is the definition from the Bank Holding Company Act of 1956.^^xsd:stringcmns-av:explanatoryNote : The Bank Holding Company Act of 1956 defines a 'Subsidiary', with respect to a specified bank holding company, means (1) any company 25 per centum or more of whose voting shares (excluding shares owned by the United States or by any company wholly owned by the United States) is owned or controlled by such bank holding company; or (2) any company the election of a majority of whose directors is controlled in any manner by such bank holding company; or (3) any company 25 per centum or more of whose voting shares are held by trustees for the benefit of the shareholders or members of such bank holding company.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SubsidiaryOfADomesticEntity">fibo-fbc-fct-usfse:SubsidiaryOfADomesticEntity</a>
    /// </summary>
    let SubsidiaryOfADomesticEntity = _prefixId.prefix "SubsidiaryOfADomesticEntity"
    /// <summary>
    ///   <para>rdfs:label : thrift institution^^xsd:string</para>
    ///   <para>skos:definition : savings association that primarily accepts savings account deposits and invests most of the proceeds in mortgages^^xsd:string</para>
    ///   <para>skos:example : Savings banks and savings and loan associations and credit unions are examples of thrift institutions.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ThriftInstitution">fibo-fbc-fct-usfse:ThriftInstitution</a>
    /// </summary>
    let ThriftInstitution = _prefixId.prefix "ThriftInstitution"
    /// <summary>
    ///   <para>rdfs:label : U.S. bank^^xsd:string</para>
    ///   <para>skos:definition : bank that is licensed to conduct business in the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : As defined in the Federal Deposit Insurance Act, https://www.fdic.gov/regulations/laws/rules/1000-400.html#fdic1000sec.3a^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A bank, as specified in the Investment Company Act of 1940, is a financial intermediary that is (a) a depository institution (as defined in section 3 of the Federal Deposit Insurance Act) or a branch or agency of a foreign bank (as such terms are defined in section 1(b) of the International Banking Act of 1978), (b) a member bank of the Federal Reserve System, (c) any other banking institution or trust company, whether incorporated or not, doing business under the laws of any State or of the United States, a substantial portion of the business of which consists of receiving deposits or exercising fiduciary powers similar to those permitted to national banks under the authority of the Comptroller of the Currency, and which is supervised and examined by State or Federal authority having supervision over banks, and which is not operated for the purpose of evading the provisions of this title, and (d) a receiver, conservator, or other liquidating agent of any institution or firm included in clause (a), (b), or (c) of this paragraph.^^xsd:stringcmns-av:explanatoryNote : The Bank Holding Company Act of 1956 defines a bank as any depository financial intermediary that accepts checking accounts (checks) or makes commercial loans, and its deposits are insured by a federal deposit insurance agency. A bank acts as a middleman between suppliers of funds and users of funds, substituting its own credit judgement for that of the ultimate suppliers of funds, collecting those funds from three sources: checking accounts, savings and time deposits; short-term borrowings from other banks; and equity capital. A bank earns money by reinvesting these funds in longer-term assets.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USBank">fibo-fbc-fct-usfse:USBank</a>
    /// </summary>
    let USBank = _prefixId.prefix "USBank"
    /// <summary>
    ///   <para>rdfs:label : U.S. bank holding company^^xsd:string</para>
    ///   <para>skos:definition : bank holding company that is licensed to conduct business in the United States and is regulated and supervised by the Federal Reserve in accordance with the Bank Holding Company Act of 1956^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : According to the FFIEC, a bank holding company is a company that owns and/or controls one or more U.S. banks or one that owns, or has controlling interest in, one or more banks. A bank holding company may also own another bank holding company, which in turn owns or controls a bank; the company at the top of the ownership chain is called the top holder. The Board of Governors is responsible for regulating and supervising bank holding companies, even if the bank owned by the holding company is under the primary supervision of a different federal agency (OCC or FDIC).^^xsd:stringcmns-av:explanatoryNote : From the Bank Holding Company Act of 1956, a 'bank holding company' means any company (1) which directly or indirectly owns, controls, or holds with power to vote, 25 per centum or more of the voting shares of each of two or more banks or of a company which is or becomes a bank holding company by virtue of this Act, or (2) which controls in any manner the election of a majority of the directors of each of two or more banks, or (3) for the benefit of whose shareholders or members 25 per centum or more of the voting shares of each of two or more banks or a bank holding company is held by trustees; and for the purposes of this Act, any successor to any such company shall be deemed to be a bank holding company from the date as of which such predecessor company became a bank holding company. Notwithstanding the foregoing, (A) no bank shall be a bank holding company by virtue of its ownership or control of shares in a fiduciary capacity, except where such shares are held for the benefit of the shareholders of such bank, (B) no company shall be a bank holding company which is registered under the Investment Company Act of 1940, and was so registered prior to May 15, 1955 (or which is affiliated with any such company in such manner as to constitute an affiliated company within the meaning of such Act), unless such company (or such affiliated company), as the case may be, directly owns 25 per centum or more of the voting shares of each of two or more banks, (C) no company shall be a bank holding company by virtue of its ownership or control of shares acquired by it in connection with its underwriting of securities and which are held only for such period of time as will permit the sale thereof upon a reasonable basis, (D) no company formed for the sole purpose of participating in a proxy solicitation shall be a bank holding company by virtue of its control of voting rights of shares acquired in the course of such solicitation, and (E) no company shall be a bank holding company if at least 80 per centum of its total assets are composed of holdings in the field of agriculture.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USBankHoldingCompany">fibo-fbc-fct-usfse:USBankHoldingCompany</a>
    /// </summary>
    let USBankHoldingCompany = _prefixId.prefix "USBankHoldingCompany"
    /// <summary>
    ///   <para>rdfs:label : U.S. credit union^^xsd:string</para>
    ///   <para>skos:definition : cooperative association organized for the purpose of promoting thrift among its members and creating a source of credit for provident or productive purposes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : As soon as you deposit funds into a credit union account, you become a partial owner and participate in the union's profitability. Credit unions may be formed by large corporations and organizations for their employees and members.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USCreditUnion">fibo-fbc-fct-usfse:USCreditUnion</a>
    /// </summary>
    let USCreditUnion = _prefixId.prefix "USCreditUnion"

    /// <summary>
    ///   <para>rdfs:label : uninsured federal agency of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : agency of a foreign bank established and operating under section 3102 of CFR Title 12, Chapter 32 and section 4 of the International Banking Act of 1978 that is not insured or regulated by the Federal Deposit Insurance Corporation (FDIC)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredFederalAgencyOfForeignBankingOrganization">fibo-fbc-fct-usfse:UninsuredFederalAgencyOfForeignBankingOrganization</a>
    /// </summary>
    let UninsuredFederalAgencyOfForeignBankingOrganization =
        _prefixId.prefix "UninsuredFederalAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : uninsured federal branch of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : any office or any place of business of a foreign bank located in any State of the United States at which deposits are received established and operating under section 4 of the International Banking Act of 1978 that is not insured or regulated by the Federal Deposit Insurance Corporation (FDIC)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An uninsured branch does not accept retail deposits and need not apply for federal deposit insurance.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredFederalBranchOfForeignBankingOrganization">fibo-fbc-fct-usfse:UninsuredFederalBranchOfForeignBankingOrganization</a>
    /// </summary>
    let UninsuredFederalBranchOfForeignBankingOrganization =
        _prefixId.prefix "UninsuredFederalBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : uninsured state agency of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : agency of a foreign bank established and operating under the laws of any state that is not insured or regulated by the Federal Deposit Insurance Corporation (FDIC)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredStateAgencyOfForeignBankingOrganization">fibo-fbc-fct-usfse:UninsuredStateAgencyOfForeignBankingOrganization</a>
    /// </summary>
    let UninsuredStateAgencyOfForeignBankingOrganization =
        _prefixId.prefix "UninsuredStateAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : uninsured state branch of foreign banking organization^^xsd:string</para>
    ///   <para>skos:definition : any office or any place of business of a foreign bank located in any State of the United States at which deposits are received, established and operating under the laws of that State that is not insured or regulated by the Federal Deposit Insurance Corporation (FDIC)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURIcmns-av:adaptedFrom : https://www.govinfo.gov/content/pkg/COMPS-275/pdf/COMPS-275.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An uninsured branch does not accept retail deposits and need not apply for federal deposit insurance.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredStateBranchOfForeignBankingOrganization">fibo-fbc-fct-usfse:UninsuredStateBranchOfForeignBankingOrganization</a>
    /// </summary>
    let UninsuredStateBranchOfForeignBankingOrganization =
        _prefixId.prefix "UninsuredStateBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <para>rdfs:label : has home country^^xsd:string</para>
    ///   <para>skos:definition : indicates, with respect to a foreign bank, the country in which the foreign bank is chartered or incorporated^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/hasHomeCountry">fibo-fbc-fct-usfse:hasHomeCountry</a>
    /// </summary>
    let hasHomeCountry = _prefixId.prefix "hasHomeCountry"
    /// <summary>
    ///   <para>rdfs:label : has home country supervisor^^xsd:string</para>
    ///   <para>skos:definition : indicates, with respect to a foreign bank, the governmental entity or entities in the foreign bank's home country with responsibility for the supervision and regulation of the foreign bank^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ecfr.gov/current/title-12/chapter-II/subchapter-A/part-211/subpart-B/section-211.21^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/hasHomeCountrySupervisor">fibo-fbc-fct-usfse:hasHomeCountrySupervisor</a>
    /// </summary>
    let hasHomeCountrySupervisor = _prefixId.prefix "hasHomeCountrySupervisor"

    /// <summary>
    ///   <para>rdfs:label : is subject to reserve requirements^^xsd:string</para>
    ///   <para>skos:definition : indicates whether some capability of a financial service provider is contingent on conformance with certain Federal Reserve policies, regulations, or other requirements^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/isSubjectToReserveRequirements">fibo-fbc-fct-usfse:isSubjectToReserveRequirements</a>
    /// </summary>
    let isSubjectToReserveRequirements =
        _prefixId.prefix "isSubjectToReserveRequirements"
