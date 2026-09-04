#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-ge`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/" "fibo-be-ge-ge"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : branch of government^^xsd:string</para>
    ///   <para>skos:definition : division of the government of a state, with separate and independent powers and areas of responsibility so that the powers of one branch are not in conflict with the powers associated with the other branches^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.usa.gov/branches-of-government^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/BranchOfGovernment">fibo-be-ge-ge:BranchOfGovernment</a>
    /// </summary>
    let BranchOfGovernment = _prefixId.prefix "BranchOfGovernment"
    /// <summary>
    ///   <para>rdfs:label : devolved government^^xsd:string</para>
    ///   <para>skos:definition : government and the politicians that that run a subnational territory with powers that may be temporary and reversible, ultimately residing with the central government^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/DevolvedGovernment">fibo-be-ge-ge:DevolvedGovernment</a>
    /// </summary>
    let DevolvedGovernment = _prefixId.prefix "DevolvedGovernment"
    /// <summary>
    ///   <para>rdfs:label : executive branch^^xsd:string</para>
    ///   <para>skos:definition : the branch of government that is authorized and responsible for the daily administration of the government^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.usa.gov/branches-of-government^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The executive branch executes and enforces the law.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/ExecutiveBranch">fibo-be-ge-ge:ExecutiveBranch</a>
    /// </summary>
    let ExecutiveBranch = _prefixId.prefix "ExecutiveBranch"
    /// <summary>
    ///   <para>rdfs:label : federal government^^xsd:string</para>
    ///   <para>skos:definition : union of states under a central government distinct from the individual governments of the separate states^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A federation is a political entity characterized by a union of partially self-governing states or regions under a central (federal) government. In a federation, the self-governing status of the component states, as well as the division of power between them and the central government, are typically constitutionally entrenched and may not be altered by a unilateral decision of either party, the states or the federal political body.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederalGovernment">fibo-be-ge-ge:FederalGovernment</a>
    /// </summary>
    let FederalGovernment = _prefixId.prefix "FederalGovernment"
    /// <summary>
    ///   <para>rdfs:label : federated sovereignty^^xsd:string</para>
    ///   <para>skos:definition : polity characterized by a union of partially self-governing states or regions under a central (federal) government^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The federated sovereignty is the legal entity that can incur debt for a federal government, as distinct from the Federal government.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederatedSovereignty">fibo-be-ge-ge:FederatedSovereignty</a>
    /// </summary>
    let FederatedSovereignty = _prefixId.prefix "FederatedSovereignty"
    /// <summary>
    ///   <para>rdfs:label : government^^xsd:string</para>
    ///   <para>skos:definition : system by which a state or community is controlled^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the Commonwealth of Nations, the word government is also used more narrowly to refer to the collective group of people that exercises executive authority in a state. This usage is analogous to what is called an 'administration' in American English. Furthermore, especially in American English, the concepts of the state and the government may be used synonymously to refer to the person or group of people exercising authority over a politically organized territory.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Government">fibo-be-ge-ge:Government</a>
    /// </summary>
    let Government = _prefixId.prefix "Government"
    /// <summary>
    ///   <para>rdfs:label : government agency^^xsd:string</para>
    ///   <para>skos:definition : permanent or semi-permanent organization, often an appointed commission, in the machinery of government that is responsible for the oversight and administration of specific functions^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There is a notable variety of agency types. Although usage differs, a government agency is normally distinct both from a department or ministry, and other types of public body established by government. The functions of an agency are normally executive in character, since different types of organizations (such as commissions) are most often constituted in an advisory role; this distinction is often blurred in practice however.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAgency">fibo-be-ge-ge:GovernmentAgency</a>
    /// </summary>
    let GovernmentAgency = _prefixId.prefix "GovernmentAgency"
    /// <summary>
    ///   <para>rdfs:label : government appointee^^xsd:string</para>
    ///   <para>skos:definition : individual designated by government decree to lead, or participate in some capacity in a government body^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAppointee">fibo-be-ge-ge:GovernmentAppointee</a>
    /// </summary>
    let GovernmentAppointee = _prefixId.prefix "GovernmentAppointee"
    /// <summary>
    ///   <para>rdfs:label : government body^^xsd:string</para>
    ///   <para>skos:definition : formal organization that is an agency, instrumentality, or other body of a supranational, national, federal, state, or local government, including certain multijurisdictional agencies and departments that carry out the business of government^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Identifying government bodies is a pre-requisite for identifying government officials. This information is needed to help ensure compliance with applicable laws relating to bribery or corruption, including the U.S. Foreign Corrupt Practices Act (FCPA), the UK Bribery Act 2010 (UKBA), the U.S. Bank Bribery Act (Bribery Act), and other anti-bribery and corruption laws in the jurisdictions where financial institutions conduct business.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentBody">fibo-be-ge-ge:GovernmentBody</a>
    /// </summary>
    let GovernmentBody = _prefixId.prefix "GovernmentBody"
    /// <summary>
    ///   <para>rdfs:label : government department^^xsd:string</para>
    ///   <para>skos:definition : specialized organization responsible for a sector of government public administration^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentDepartment">fibo-be-ge-ge:GovernmentDepartment</a>
    /// </summary>
    let GovernmentDepartment = _prefixId.prefix "GovernmentDepartment"
    /// <summary>
    ///   <para>rdfs:label : government minister^^xsd:string</para>
    ///   <para>skos:definition : government official that is an executive, who is either appointed or elected to a high office in the government^^xsd:string</para>
    ///   <para>skos:example : Minister of Finance, Secretary of State, Attorney General of California^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentMinister">fibo-be-ge-ge:GovernmentMinister</a>
    /// </summary>
    let GovernmentMinister = _prefixId.prefix "GovernmentMinister"
    /// <summary>
    ///   <para>rdfs:label : government official^^xsd:string</para>
    ///   <para>skos:definition : person elected or appointed to administer some aspect of a government^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentOfficial">fibo-be-ge-ge:GovernmentOfficial</a>
    /// </summary>
    let GovernmentOfficial = _prefixId.prefix "GovernmentOfficial"
    /// <summary>
    ///   <para>rdfs:label : instrumentality^^xsd:string</para>
    ///   <para>skos:definition : organization that serves a public purpose and is closely tied to a government, but is not a government agency^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An instrumentality is a non-governmental agency that acts independently but whose obligations are backed by a government because of its role in providing a public service. Many instrumentalities are private companies, and some are chartered directly by government. Instrumentalities are subject to a unique set of laws that shape their activities. Certain organizations, such as Sallie Mae in the United States, may be considered instrumentalities from some perspectives but not others. Sallie Mae's status was changed in 2004, when it was privatized, and since that time it is no longer considered a government-sponsored enterprise (GSE).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Instrumentality">fibo-be-ge-ge:Instrumentality</a>
    /// </summary>
    let Instrumentality = _prefixId.prefix "Instrumentality"
    /// <summary>
    ///   <para>rdfs:label : judiciary^^xsd:string</para>
    ///   <para>skos:definition : branch of government that comprises the system of courts that interprets and applies the law in the name of the supranational, national, federal, or regional government, depending on its jurisdiction^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The judiciary also provides a mechanism for the resolution of disputes. Under the doctrine of the separation of powers, the judiciary generally does not make law (that is, in a plenary fashion, which is the responsibility of the legislature) or enforce law (which is the responsibility of the executive), but rather interprets law and applies it to the facts of each case.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Judiciary">fibo-be-ge-ge:Judiciary</a>
    /// </summary>
    let Judiciary = _prefixId.prefix "Judiciary"
    /// <summary>
    ///   <para>rdfs:label : legislature^^xsd:string</para>
    ///   <para>skos:definition : the law-making body of a political unit, usually a national government, that has power to enact, amend, and repeal public policy^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Laws enacted by legislatures are known as legislation. Legislatures observe and steer governing actions and usually have exclusive authority to amend the budget or budgets involved in the process.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Legislature">fibo-be-ge-ge:Legislature</a>
    /// </summary>
    let Legislature = _prefixId.prefix "Legislature"
    /// <summary>
    ///   <para>rdfs:label : municipal entity^^xsd:string</para>
    ///   <para>skos:definition : polity that typically represents a city, township, or other administrative subdivision having corporate status and powers of self-government or jurisdiction^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Municipal entity in the sense of a legal entity, that is, what it is that incurs debt for a municipality, as distinct from the Municipal government. A municipal entity has a Government which sets laws applicable within the geographical area corresponding to its jurisdiction.^^xsd:string</para>
    ///   <para>cmns-av:synonym : municipality^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalEntity">fibo-be-ge-ge:MunicipalEntity</a>
    /// </summary>
    let MunicipalEntity = _prefixId.prefix "MunicipalEntity"
    /// <summary>
    ///   <para>rdfs:label : municipal government^^xsd:string</para>
    ///   <para>skos:definition : regional government of a city, township, or other administrative subdivision^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalGovernment">fibo-be-ge-ge:MunicipalGovernment</a>
    /// </summary>
    let MunicipalGovernment = _prefixId.prefix "MunicipalGovernment"
    /// <summary>
    ///   <para>rdfs:label : national government^^xsd:string</para>
    ///   <para>skos:definition : government and the politicians that that run a country as a whole (as opposed to local government)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/NationalGovernment">fibo-be-ge-ge:NationalGovernment</a>
    /// </summary>
    let NationalGovernment = _prefixId.prefix "NationalGovernment"
    /// <summary>
    ///   <para>rdfs:label : polity^^xsd:string</para>
    ///   <para>skos:definition : legal person that is a supranational entity, crown, state, or subordinate civil authority, such as a province, prefecture, county, municipality, city, or district representing the people of that entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Polity">fibo-be-ge-ge:Polity</a>
    /// </summary>
    let Polity = _prefixId.prefix "Polity"
    /// <summary>
    ///   <para>rdfs:label : regional government^^xsd:string</para>
    ///   <para>skos:definition : administrative body for a geographic area, such as a county, smaller town, or other similar community^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A local government will typically only have control over their specific geographical region, and cannot pass or enforce laws that will affect a wider area. Local governments can elect officials, enact taxes, and do many other things that a national government would do, just on a smaller scale.^^xsd:string</para>
    ///   <para>cmns-av:synonym : local government^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalGovernment">fibo-be-ge-ge:RegionalGovernment</a>
    /// </summary>
    let RegionalGovernment = _prefixId.prefix "RegionalGovernment"
    /// <summary>
    ///   <para>rdfs:label : regional sovereignty^^xsd:string</para>
    ///   <para>skos:definition : legal person that corresponds to an administrative division, administrative unit, administrative entity or country subdivision (or, sometimes, geopolitical division or subnational entity), that has the capacity to incur debt, issue contracts, and enter into relations with other similar entities^^xsd:string</para>
    ///   <para>skos:example : A country may be divided into provinces, which, in turn, are divided into counties, which, in turn, may be divided in whole or in part into municipalities; and so on.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalSovereignty">fibo-be-ge-ge:RegionalSovereignty</a>
    /// </summary>
    let RegionalSovereignty = _prefixId.prefix "RegionalSovereignty"
    /// <summary>
    ///   <para>rdfs:label : sovereign state^^xsd:string</para>
    ///   <para>skos:definition : non-physical juridical entity that is represented by one centralized government that has sovereignty over a geographic area^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A legal entity that is represented by one centralized government, has a permanent population, defined territory, and the capacity to enter into relations with other sovereign states.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SovereignState">fibo-be-ge-ge:SovereignState</a>
    /// </summary>
    let SovereignState = _prefixId.prefix "SovereignState"
    /// <summary>
    ///   <para>rdfs:label : supranational entity^^xsd:string</para>
    ///   <para>skos:definition : governmental or non-governmental entity that is established by international law or treaty or incorporated at an international level^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 20275:2017, Financial services - Entity legal forms (ELF), First Edition, July 2017.^^xsd:stringcmns-av:adaptedFrom : Kiljunen, Kimmo (2004). The European Constitution in the Making. Centre for European Policy Studies. pp. 21-26. ISBN 978-92-9079-493-6^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A supranational union is a supranational polity which lies somewhere between a confederation that is an association of states and a federation that is a state. Unlike states in a federal super-state, member states retain ultimate sovereignty, although some sovereignty is shared with, or ceded to, the supranational body.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SupranationalEntity">fibo-be-ge-ge:SupranationalEntity</a>
    /// </summary>
    let SupranationalEntity = _prefixId.prefix "SupranationalEntity"
    /// <summary>
    ///   <para>rdfs:label : tribal area^^xsd:string</para>
    ///   <para>skos:definition : designation for geographic region administered by a group of indigenous people rather than by a sovereign state or regional governmental entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalArea">fibo-be-ge-ge:TribalArea</a>
    /// </summary>
    let TribalArea = _prefixId.prefix "TribalArea"
    /// <summary>
    ///   <para>rdfs:label : tribal entity^^xsd:string</para>
    ///   <para>skos:definition : legal entity that represents fundamental unit of sovereign tribal (indigenous) government^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Any indigenous group or community which is recognized as having rights and obligations independent of the central government.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalEntity">fibo-be-ge-ge:TribalEntity</a>
    /// </summary>
    let TribalEntity = _prefixId.prefix "TribalEntity"
    /// <summary>
    ///   <para>rdfs:label : tribal government^^xsd:string</para>
    ///   <para>skos:definition : government representing a group of indigenous people that has legal authority to govern those people, including authority to legislate the existence of tribal entities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalGovernment">fibo-be-ge-ge:TribalGovernment</a>
    /// </summary>
    let TribalGovernment = _prefixId.prefix "TribalGovernment"
    /// <summary>
    ///   <para>rdfs:label : has full sovereignty over^^xsd:string</para>
    ///   <para>skos:definition : relates a polity to a geopolitical entity where the polity has absolute, supreme and ultimate dominion and authority of a political state subject to no higher power, expressed within its territory in full self-government and in complete freedom from any outside influence^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasFullSovereigntyOver">fibo-be-ge-ge:hasFullSovereigntyOver</a>
    /// </summary>
    let hasFullSovereigntyOver = _prefixId.prefix "hasFullSovereigntyOver"
    /// <summary>
    ///   <para>rdfs:label : has shared sovereignty over^^xsd:string</para>
    ///   <para>skos:definition : relates a polity to a geopolitical entity where the polity exercises shared dominion and authority of a political state^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSharedSovereigntyOver">fibo-be-ge-ge:hasSharedSovereigntyOver</a>
    /// </summary>
    let hasSharedSovereigntyOver = _prefixId.prefix "hasSharedSovereigntyOver"
    /// <summary>
    ///   <para>rdfs:label : has sovereignty over^^xsd:string</para>
    ///   <para>skos:definition : relates a polity to a geopolitical entity where the polity exercises dominion and authority of a political state^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSovereigntyOver">fibo-be-ge-ge:hasSovereigntyOver</a>
    /// </summary>
    let hasSovereigntyOver = _prefixId.prefix "hasSovereigntyOver"
    /// <summary>
    ///   <para>rdfs:label : is elected by^^xsd:string</para>
    ///   <para>skos:definition : identifies an official or government chosen to hold office by voting^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isElectedBy">fibo-be-ge-ge:isElectedBy</a>
    /// </summary>
    let isElectedBy = _prefixId.prefix "isElectedBy"
    /// <summary>
    ///   <para>rdfs:label : is an instrument of^^xsd:string</para>
    ///   <para>skos:definition : relates an instrumentality of some government to the government that it supports^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isInstrumentOf">fibo-be-ge-ge:isInstrumentOf</a>
    /// </summary>
    let isInstrumentOf = _prefixId.prefix "isInstrumentOf"
    /// <summary>
    ///   <para>rdfs:label : is represented by^^xsd:string</para>
    ///   <para>skos:definition : relates a system of governance to its chosen representatives^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isRepresentedBy">fibo-be-ge-ge:isRepresentedBy</a>
    /// </summary>
    let isRepresentedBy = _prefixId.prefix "isRepresentedBy"
