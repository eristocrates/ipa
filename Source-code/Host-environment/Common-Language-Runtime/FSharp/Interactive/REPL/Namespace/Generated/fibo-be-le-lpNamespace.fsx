#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-le-lp`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/" "fibo-be-le-lp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : business entity^^xsd:string</para>
    ///   <para>skos:definition : entity that is formed and administered as per commercial law in order to engage in business activities^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There are many types of business entities defined in the legal systems of various countries. These include corporations, cooperatives, partnerships, sole proprietorships, sole traders, limited liability companies, certain trusts and trust companies, and so forth. The rules vary by country and by state or province. Some of the more widely recognized types in the US, UK, and EU are defined in FIBO, by region. However, the regulations governing particular types of entity, even those described as roughly equivalent, differ from jurisdiction to jurisdiction.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessEntity">fibo-be-le-lp:BusinessEntity</a>
    /// </summary>
    let BusinessEntity = _prefixId.prefix "BusinessEntity"
    /// <summary>
    ///   <para>rdfs:label : business license^^xsd:string</para>
    ///   <para>skos:definition : license that allows the holder to conduct business or carry out a specific profession within some jurisdiction for some period of time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessLicense">fibo-be-le-lp:BusinessLicense</a>
    /// </summary>
    let BusinessLicense = _prefixId.prefix "BusinessLicense"
    /// <summary>
    ///   <para>rdfs:label : chartered legal person^^xsd:string</para>
    ///   <para>skos:definition : a legal person created by a royal charter or decree^^xsd:string</para>
    ///   <para>skos:example : Anything with 'Royal Institute' in the name. Also universities are generally set up by royal charter in a monarchy or principality, (often pre-dating any Privy Council i.e. directly be the monarch in the case of older universities). The Bank of England and the British Broadcasting Council (BBC) are also incorporated through Royal Charter.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In a monarchy or principality, the monarch typically vests the power to create such bodies, in an entity called (for example) the Privy Council.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/CharteredLegalPerson">fibo-be-le-lp:CharteredLegalPerson</a>
    /// </summary>
    let CharteredLegalPerson = _prefixId.prefix "CharteredLegalPerson"
    /// <summary>
    ///   <para>rdfs:label : legally competent natural person^^xsd:string</para>
    ///   <para>skos:definition : person who is considered competent, under the circumstances, to enter into a contract, conduct business, or participate in other activities that generally require the mental ability to understand problems and make decisions on his or her own behalf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The definition of mental competence, and potentially of the age of majority, is a function of the situation and law in a given jurisdiction.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/LegallyCompetentNaturalPerson">fibo-be-le-lp:LegallyCompetentNaturalPerson</a>
    /// </summary>
    let LegallyCompetentNaturalPerson = _prefixId.prefix "LegallyCompetentNaturalPerson"
    /// <summary>
    ///   <para>rdfs:label : not for profit objective^^xsd:string</para>
    ///   <para>skos:definition : objective that reflects the charitable, educational, religious, humanitarian, public services, or other not for profit goals of an organization^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The objective of all business activities is not to earn profits for its owners. All of the money earned by or donated to a not for profit organization is used in pursuing the organization's objectives.^^xsd:string</para>
    ///   <para>cmns-av:synonym : nonprofit objective^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/NotForProfitObjective">fibo-be-le-lp:NotForProfitObjective</a>
    /// </summary>
    let NotForProfitObjective = _prefixId.prefix "NotForProfitObjective"
    /// <summary>
    ///   <para>rdfs:label : power of attorney^^xsd:string</para>
    ///   <para>skos:definition : legal authorization given by one party (the principal) to another (the agent or attorney-in-fact) to perform certain acts on the principal's behalf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The appointment can be effective immediately or if the principal is unable to make decisions or perform certain actions on their own. It may be a (1) general power of attorney that authorizes the agent to act generally on behalf of the principal, such as to transfer funds from one account to another, pay debts, make investments, and so forth, or (2) limited to a specific act or situation, such as for management of an individual's finances in a single account, such as a brokerage account, or for management of healthcare. Decisions made and actions taken by an attorney in fact (within the scope of his or her authority) are legally binding on the principal.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PowerOfAttorney">fibo-be-le-lp:PowerOfAttorney</a>
    /// </summary>
    let PowerOfAttorney = _prefixId.prefix "PowerOfAttorney"
    /// <summary>
    ///   <para>rdfs:label : profit objective^^xsd:string</para>
    ///   <para>skos:definition : objective that reflects pursuit of a financial benefit that may be realized when the amount of revenue gained from a business activity exceeds the expenses, costs and taxes needed to sustain that activity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Any profit that is gained goes to the business's owners, who may or may not decide to spend it on the business.^^xsd:string</para>
    ///   <para>cmns-av:synonym : for profit objective^^xsd:stringcmns-av:synonym : profit motive^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ProfitObjective">fibo-be-le-lp:ProfitObjective</a>
    /// </summary>
    let ProfitObjective = _prefixId.prefix "ProfitObjective"
    /// <summary>
    ///   <para>rdfs:label : public purpose^^xsd:string</para>
    ///   <para>skos:definition : objective that reflects values generally thought to be shared by and that is intended to benefit the populace as a whole^^xsd:string</para>
    ///   <para>cmns-av:synonym : public interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PublicPurpose">fibo-be-le-lp:PublicPurpose</a>
    /// </summary>
    let PublicPurpose = _prefixId.prefix "PublicPurpose"
    /// <summary>
    ///   <para>rdfs:label : religious objective^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit objective that reflects the religious goals of an organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ReligiousObjective">fibo-be-le-lp:ReligiousObjective</a>
    /// </summary>
    let ReligiousObjective = _prefixId.prefix "ReligiousObjective"
    /// <summary>
    ///   <para>rdfs:label : fonds commun de placementrdfs:label : special purpose vehicle</para>
    ///   <para>skos:definition : legal entity created to fulfill narrow, specific, and frequently temporary objectives</para>
    ///   <para>cmns-av:abbreviation : SPEcmns-av:abbreviation : SPV</para>
    ///   <para>cmns-av:explanatoryNote : A special purpose vehicle (SPV), also known as a special purpose entity (SPE), refers to a legal entity, typically a limited company or partnership, created to isolate a parent company from financial risk, including bankruptcy.</para>
    ///   <para>cmns-av:synonym : special purpose entity</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/SpecialPurposeVehicle">fibo-be-le-lp:SpecialPurposeVehicle</a>
    /// </summary>
    let SpecialPurposeVehicle = _prefixId.prefix "SpecialPurposeVehicle"
    /// <summary>
    ///   <para>rdfs:label : statutory body^^xsd:string</para>
    ///   <para>skos:definition : legal entity established by a government to consider evidence and make judgements in some field of activity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/StatutoryBody">fibo-be-le-lp:StatutoryBody</a>
    /// </summary>
    let StatutoryBody = _prefixId.prefix "StatutoryBody"
    /// <summary>
    ///   <para>rdfs:label : variable interest entity</para>
    ///   <para>skos:definition : legal entity whose shareholders are entitled to a percentage of a named company's profits via a private contract</para>
    ///   <para>cmns-av:abbreviation : VIE</para>
    ///   <para>cmns-av:explanatoryNote : Variable interest entity (VIE) is a term used by the Financial Accounting Standards Board (FASB) to refer to a legal entity with certain characteristics such that a public company with a financial interest in the entity is subject to certain financial reporting requirements. Examples include certain Chinese companies, such as Alibaba, that leverage VIEs to gain access to foreign capital that would otherwise not be available due to Chinese government regulations.</para>
    ///   <para>cmns-av:synonym : shell company</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/VariableInterestEntity">fibo-be-le-lp:VariableInterestEntity</a>
    /// </summary>
    let VariableInterestEntity = _prefixId.prefix "VariableInterestEntity"
    /// <summary>
    ///   <para>rdfs:label : has intended liquidation date</para>
    ///   <para>skos:definition : links an agreement, contract, or legal entity to a date on which it is scheduled to be sold</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/hasIntendedLiquidationDate">fibo-be-le-lp:hasIntendedLiquidationDate</a>
    /// </summary>
    let hasIntendedLiquidationDate = _prefixId.prefix "hasIntendedLiquidationDate"
