#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-oac-ctl`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/" "fibo-fnd-oac-ctl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : control^^xsd:string</para>
    ///   <para>skos:definition : situation in which some party has the power to direct or strongly influence the direction of the management and policies related to something^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Control may be direct (explicit) or indirect (implicit), derived through ownership of voting shares, beneficial ownership, other ownership relations, through provisions of a contract, or otherwise.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/Control">fibo-fnd-oac-ctl:Control</a>
    /// </summary>
    let Control = _prefixId.prefix "Control"
    /// <summary>
    ///   <para>rdfs:label : controlled thing^^xsd:string</para>
    ///   <para>skos:definition : something over which some party exercises some form of control with respect to some situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControlledThing">fibo-fnd-oac-ctl:ControlledThing</a>
    /// </summary>
    let ControlledThing = _prefixId.prefix "ControlledThing"
    /// <summary>
    ///   <para>rdfs:label : controlling party^^xsd:string</para>
    ///   <para>skos:definition : actor that exercises some form of control in the context of some situation^^xsd:string</para>
    ///   <para>skos:editorialNote : At this level of abstraction it is not defined whether the control is some degree of controlling interest, or some level of actual control (asserted or calculated) in some entity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControllingParty">fibo-fnd-oac-ctl:ControllingParty</a>
    /// </summary>
    let ControllingParty = _prefixId.prefix "ControllingParty"
    /// <summary>
    ///   <para>rdfs:label : de facto control^^xsd:string</para>
    ///   <para>skos:definition : control that exists informally and is accepted, although not formally recognized^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For example, de facto acquisition or change of control means the acquisition, directly or indirectly, by any person or group of persons acting jointly or in concert, of beneficial ownership of, or control or direction over, sufficient voting shares of some legal entity to permit such person or persons to exercise, or to control or direct the voting of, 50 percent or more of the total number of votes in that entity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeFactoControl">fibo-fnd-oac-ctl:DeFactoControl</a>
    /// </summary>
    let DeFactoControl = _prefixId.prefix "DeFactoControl"
    /// <summary>
    ///   <para>rdfs:label : de jure control^^xsd:string</para>
    ///   <para>skos:definition : control that exists as a matter of law, i.e., legitimate, legal control of something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeJureControl">fibo-fnd-oac-ctl:DeJureControl</a>
    /// </summary>
    let DeJureControl = _prefixId.prefix "DeJureControl"
    /// <summary>
    ///   <para>rdfs:label : has controlling party^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that exercises authority or influence over something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasControllingParty">fibo-fnd-oac-ctl:hasControllingParty</a>
    /// </summary>
    let hasControllingParty = _prefixId.prefix "hasControllingParty"
    /// <summary>
    ///   <para>rdfs:label : has party in control^^xsd:string</para>
    ///   <para>skos:definition : indicates the actor in the context of a control situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasPartyInControl">fibo-fnd-oac-ctl:hasPartyInControl</a>
    /// </summary>
    let hasPartyInControl = _prefixId.prefix "hasPartyInControl"
    /// <summary>
    ///   <para>rdfs:label : involves controlled thing^^xsd:string</para>
    ///   <para>skos:definition : indicates something controlled in the context of a control situation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/involvesControlledThing">fibo-fnd-oac-ctl:involvesControlledThing</a>
    /// </summary>
    let involvesControlledThing = _prefixId.prefix "involvesControlledThing"
    /// <summary>
    ///   <para>rdfs:label : is controlled party of^^xsd:string</para>
    ///   <para>skos:definition : indicates a controlling party that has some amount of authority or influence over it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledPartyOf">fibo-fnd-oac-ctl:isControlledPartyOf</a>
    /// </summary>
    let isControlledPartyOf = _prefixId.prefix "isControlledPartyOf"
    /// <summary>
    ///   <para>rdfs:label : is controlled thing in^^xsd:string</para>
    ///   <para>skos:definition : indicates the context of control in which something is being controlled^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledThingIn">fibo-fnd-oac-ctl:isControlledThingIn</a>
    /// </summary>
    let isControlledThingIn = _prefixId.prefix "isControlledThingIn"
    /// <summary>
    ///   <para>rdfs:label : is controlling party in^^xsd:string</para>
    ///   <para>skos:definition : indicates the context of control in which the party plays the role of controlling something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyIn">fibo-fnd-oac-ctl:isControllingPartyIn</a>
    /// </summary>
    let isControllingPartyIn = _prefixId.prefix "isControllingPartyIn"
    /// <summary>
    ///   <para>rdfs:label : is controlling party of^^xsd:string</para>
    ///   <para>skos:definition : indicates something that a controlling party has some amount of authority or influence over^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyOf">fibo-fnd-oac-ctl:isControllingPartyOf</a>
    /// </summary>
    let isControllingPartyOf = _prefixId.prefix "isControllingPartyOf"
    /// <summary>
    ///   <para>rdfs:label : is initially controlled on^^xsd:string</para>
    ///   <para>skos:definition : indicates the date or date and time that some level of authority or influence was first put in place^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isInitiallyControlledOn">fibo-fnd-oac-ctl:isInitiallyControlledOn</a>
    /// </summary>
    let isInitiallyControlledOn = _prefixId.prefix "isInitiallyControlledOn"
    /// <summary>
    ///   <para>rdfs:label : is party controlling^^xsd:string</para>
    ///   <para>skos:definition : indicates something controlled that a controlling party has some amount of authority or influence over^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isPartyControlling">fibo-fnd-oac-ctl:isPartyControlling</a>
    /// </summary>
    let isPartyControlling = _prefixId.prefix "isPartyControlling"
