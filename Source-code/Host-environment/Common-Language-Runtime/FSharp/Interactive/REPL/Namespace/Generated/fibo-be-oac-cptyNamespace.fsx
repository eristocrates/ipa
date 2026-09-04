#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-oac-cpty`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/" "fibo-be-oac-cpty"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : contractual control^^xsd:string</para>
    ///   <para>skos:definition : control established through the terms of some contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ContractualControl">fibo-be-oac-cpty:ContractualControl</a>
    /// </summary>
    let ContractualControl = _prefixId.prefix "ContractualControl"
    /// <summary>
    ///   <para>rdfs:label : controlled party^^xsd:string</para>
    ///   <para>skos:definition : person or organization over which some party exercises some form of authority or influence with respect to some situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControlledParty">fibo-be-oac-cpty:ControlledParty</a>
    /// </summary>
    let ControlledParty = _prefixId.prefix "ControlledParty"
    /// <summary>
    ///   <para>rdfs:label : controlling alliance^^xsd:string</para>
    ///   <para>skos:definition : group that has formed some alliance to jointly exercise control over some entity^^xsd:string</para>
    ///   <para>skos:editorialNote : The types of entity which may enter into such an alliance are the same types of entity as may exercise control in their own right, i.e. independent parties (that is a logical union of natural persons, legal persons and formal organizations).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/ControllingAlliance">fibo-be-oac-cpty:ControllingAlliance</a>
    /// </summary>
    let ControllingAlliance = _prefixId.prefix "ControllingAlliance"
    /// <summary>
    ///   <para>rdfs:label : court appointed control^^xsd:string</para>
    ///   <para>skos:definition : control conferred by the actions of some court, for example in the context of receivership^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/CourtAppointedControl">fibo-be-oac-cpty:CourtAppointedControl</a>
    /// </summary>
    let CourtAppointedControl = _prefixId.prefix "CourtAppointedControl"

    /// <summary>
    ///   <para>rdfs:label : de facto controlling interest party^^xsd:string</para>
    ///   <para>skos:definition : party that exercises some control over an entity other than via explicit, legal means^^xsd:string</para>
    ///   <para>skos:example : a silent partner, i.e. where someone has made a large investment, which is bilateral (not part of the constitutional framework of the company)^^xsd:string</para>
    ///   <para>skos:scopeNote : divides further into financial leverage via loans; non fiscal types of leverage (influence)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeFactoControllingInterestParty">fibo-be-oac-cpty:DeFactoControllingInterestParty</a>
    /// </summary>
    let DeFactoControllingInterestParty =
        _prefixId.prefix "DeFactoControllingInterestParty"

    /// <summary>
    ///   <para>rdfs:label : de jure controlling interest party^^xsd:string</para>
    ///   <para>skos:definition : party that has the legal authority to exercise control^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/DeJureControllingInterestParty">fibo-be-oac-cpty:DeJureControllingInterestParty</a>
    /// </summary>
    let DeJureControllingInterestParty =
        _prefixId.prefix "DeJureControllingInterestParty"

    /// <summary>
    ///   <para>rdfs:label : entity controlling party^^xsd:string</para>
    ///   <para>skos:definition : party that has the authority to control some legal entity^^xsd:string</para>
    ///   <para>skos:editorialNote : This type of party is either asserted to be the case by the entity itself or some other party, or is determined through some analysis or calculation based on the available information about controlling interests.^^xsd:string</para>
    ///   <para>skos:scopeNote : It is assumed that since control follows from some form of ownership or contractual instrument, that the range of entities which may fulfil this party role is the same as that for entity ownership, namely a logical union of natural persons, legal persons and formal organizations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/EntityControllingParty">fibo-be-oac-cpty:EntityControllingParty</a>
    /// </summary>
    let EntityControllingParty = _prefixId.prefix "EntityControllingParty"
    /// <summary>
    ///   <para>rdfs:label : influence-based de facto control^^xsd:string</para>
    ///   <para>skos:definition : informal control that involves influence over some party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControl">fibo-be-oac-cpty:InfluenceBasedDeFactoControl</a>
    /// </summary>
    let InfluenceBasedDeFactoControl = _prefixId.prefix "InfluenceBasedDeFactoControl"

    /// <summary>
    ///   <para>rdfs:label : influence-based de facto controlling party^^xsd:string</para>
    ///   <para>skos:definition : party that holds influence-based control over some other party^^xsd:string</para>
    ///   <para>skos:editorialNote : Regulatory or jurisdictional control would fall under this control. Court appointed control is de jure control BUT the scenario in which a government takes over something and then hands it over to some new de jure controller i.e. administrator - in the meantime this is de facto control by e.g. the government.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InfluenceBasedDeFactoControllingParty">fibo-be-oac-cpty:InfluenceBasedDeFactoControllingParty</a>
    /// </summary>
    let InfluenceBasedDeFactoControllingParty =
        _prefixId.prefix "InfluenceBasedDeFactoControllingParty"

    /// <summary>
    ///   <para>rdfs:label : investment-based de facto control^^xsd:string</para>
    ///   <para>skos:definition : control that arises through some investment in some entity, other than via the holding of constitutional equity (shares etc.) in that entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControl">fibo-be-oac-cpty:InvestmentBasedDeFactoControl</a>
    /// </summary>
    let InvestmentBasedDeFactoControl = _prefixId.prefix "InvestmentBasedDeFactoControl"

    /// <summary>
    ///   <para>rdfs:label : investment-based de facto controlling interest party^^xsd:string</para>
    ///   <para>skos:definition : party that holds investment-based control over some other party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/InvestmentBasedDeFactoControllingInterestParty">fibo-be-oac-cpty:InvestmentBasedDeFactoControllingInterestParty</a>
    /// </summary>
    let InvestmentBasedDeFactoControllingInterestParty =
        _prefixId.prefix "InvestmentBasedDeFactoControllingInterestParty"

    /// <summary>
    ///   <para>rdfs:label : joint controlling party^^xsd:string</para>
    ///   <para>skos:definition : party that collectively has the authority to control the affairs of some business organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/JointControllingParty">fibo-be-oac-cpty:JointControllingParty</a>
    /// </summary>
    let JointControllingParty = _prefixId.prefix "JointControllingParty"
    /// <summary>
    ///   <para>rdfs:label : majority controlling party^^xsd:string</para>
    ///   <para>skos:definition : controlling party that possesses, either directly or indirectly, the power to direct or cause the direction of the management and policies of a legal person, whether through the ownership of a majority of voting securities, by contract, or otherwise^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Electronic Code of Federal Regulations, Title 17, Chapter 1, Section 49.2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/MajorityControllingParty">fibo-be-oac-cpty:MajorityControllingParty</a>
    /// </summary>
    let MajorityControllingParty = _prefixId.prefix "MajorityControllingParty"
    /// <summary>
    ///   <para>rdfs:label : receiver^^xsd:string</para>
    ///   <para>skos:definition : party appointed by some court for the purposes of winding up the affairs of some entity which is no longer solvent^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/Receiver">fibo-be-oac-cpty:Receiver</a>
    /// </summary>
    let Receiver = _prefixId.prefix "Receiver"
    /// <summary>
    ///   <para>rdfs:label : sole controlling party^^xsd:string</para>
    ///   <para>skos:definition : party that has sole control over and directs the affairs of some legal entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/SoleControllingParty">fibo-be-oac-cpty:SoleControllingParty</a>
    /// </summary>
    let SoleControllingParty = _prefixId.prefix "SoleControllingParty"
    /// <summary>
    ///   <para>rdfs:label : total owner^^xsd:string</para>
    ///   <para>skos:definition : party that has 100 percent ownership some legal entity^^xsd:string</para>
    ///   <para>skos:editorialNote : By virtue of holding 100 percent of the equity ownership, the Total Owner also holds 100 percent of the controlling equity, if there is a difference. Therefore it is both a total owner and a total controlling party.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/TotalOwner">fibo-be-oac-cpty:TotalOwner</a>
    /// </summary>
    let TotalOwner = _prefixId.prefix "TotalOwner"
    /// <summary>
    ///   <para>rdfs:label : advises^^xsd:string</para>
    ///   <para>skos:definition : provides counsel or guidance to^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/advises">fibo-be-oac-cpty:advises</a>
    /// </summary>
    let advises = _prefixId.prefix "advises"

    /// <summary>
    ///   <para>rdfs:label : has controlling organization member^^xsd:string</para>
    ///   <para>skos:definition : relates a controlled party to a controlling member of the organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasControllingOrganizationMember">fibo-be-oac-cpty:hasControllingOrganizationMember</a>
    /// </summary>
    let hasControllingOrganizationMember =
        _prefixId.prefix "hasControllingOrganizationMember"

    /// <summary>
    ///   <para>rdfs:label : has majority controlling party^^xsd:string</para>
    ///   <para>skos:definition : indicates a party that owns a controlling stake (over 50 percent) in the entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/hasMajorityControllingParty">fibo-be-oac-cpty:hasMajorityControllingParty</a>
    /// </summary>
    let hasMajorityControllingParty = _prefixId.prefix "hasMajorityControllingParty"
    /// <summary>
    ///   <para>rdfs:label : has advisor^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that acts in an advisory capacity to the controlled party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isAdvisedBy">fibo-be-oac-cpty:isAdvisedBy</a>
    /// </summary>
    let isAdvisedBy = _prefixId.prefix "isAdvisedBy"
    /// <summary>
    ///   <para>rdfs:label : is based on investment equity^^xsd:string</para>
    ///   <para>skos:definition : indicates investment-based de facto control, which is is based on the holding of some investment equity by some party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isBasedOnInvestmentEquity">fibo-be-oac-cpty:isBasedOnInvestmentEquity</a>
    /// </summary>
    let isBasedOnInvestmentEquity = _prefixId.prefix "isBasedOnInvestmentEquity"
    /// <summary>
    ///   <para>rdfs:label : is controlling member of^^xsd:string</para>
    ///   <para>skos:definition : identifies a controlled organization over which the member has some measure of control^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/isControllingMemberOf">fibo-be-oac-cpty:isControllingMemberOf</a>
    /// </summary>
    let isControllingMemberOf = _prefixId.prefix "isControllingMemberOf"
