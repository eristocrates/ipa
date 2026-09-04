#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-rel-rel`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/" "fibo-fnd-rel-rel"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : referent^^xsd:string</para>
    ///   <para>skos:definition : something that another concept stands for, exemplifies, symbolizes, or otherwise mentions^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/Referent">fibo-fnd-rel-rel:Referent</a>
    /// </summary>
    let Referent = _prefixId.prefix "Referent"
    /// <summary>
    ///   <para>rdfs:label : causes^^xsd:string</para>
    ///   <para>skos:definition : relationship between an event or set of events or factors (the cause) and a second event, phenomenon, situation, or result (the effect), where the second event or outcome is understood as a consequence of the first^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/causes">fibo-fnd-rel-rel:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    /// <summary>
    ///   <para>rdfs:label : confers^^xsd:string</para>
    ///   <para>skos:definition : grants or bestows by virtue of some authority^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This property should be read as describing the conferral of some legal power or duty, some commitment or some social construct, and is a property of some social construct such as an agreement or some legal authority. These concepts, which would describe the kind of thing of which this is a property, and the kinds of thing in terms of which this property is framed, are outside the scope of this mode land so are not shown.^^xsd:string</para>
    ///   <para>cmns-av:synonym : invests with^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/confers">fibo-fnd-rel-rel:confers</a>
    /// </summary>
    let confers = _prefixId.prefix "confers"
    /// <summary>
    ///   <para>rdfs:label : controls^^xsd:string</para>
    ///   <para>skos:definition : exercises authority or influence over^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/controls">fibo-fnd-rel-rel:controls</a>
    /// </summary>
    let controls = _prefixId.prefix "controls"
    /// <summary>
    ///   <para>rdfs:label : embodies^^xsd:string</para>
    ///   <para>skos:definition : is an expression of, gives a tangible or visible form to (an idea, quality, or feeling), makes concrete and perceptible^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/embodies">fibo-fnd-rel-rel:embodies</a>
    /// </summary>
    let embodies = _prefixId.prefix "embodies"
    /// <summary>
    ///   <para>rdfs:label : evaluates^^xsd:string</para>
    ///   <para>skos:definition : assesses the nature, quality, or ability of someone or something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/evaluates">fibo-fnd-rel-rel:evaluates</a>
    /// </summary>
    let evaluates = _prefixId.prefix "evaluates"
    /// <summary>
    ///   <para>rdfs:label : exchanges^^xsd:string</para>
    ///   <para>skos:definition : gives something in return something else^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exchanges">fibo-fnd-rel-rel:exchanges</a>
    /// </summary>
    let exchanges = _prefixId.prefix "exchanges"
    /// <summary>
    ///   <para>rdfs:label : exemplifies^^xsd:string</para>
    ///   <para>skos:definition : is a concrete realization or example of^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.merriam-webster.com/dictionary/exemplify^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exemplifies">fibo-fnd-rel-rel:exemplifies</a>
    /// </summary>
    let exemplifies = _prefixId.prefix "exemplifies"
    /// <summary>
    ///   <para>rdfs:label : generates^^xsd:string</para>
    ///   <para>skos:definition : produces through the application of one or more mathematical or logical steps or rules^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/generates">fibo-fnd-rel-rel:generates</a>
    /// </summary>
    let generates = _prefixId.prefix "generates"
    /// <summary>
    ///   <para>rdfs:label : has alias^^xsd:string</para>
    ///   <para>skos:definition : indicates an alternate name of by which something is known^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasAlias">fibo-fnd-rel-rel:hasAlias</a>
    /// </summary>
    let hasAlias = _prefixId.prefix "hasAlias"
    /// <summary>
    ///   <para>rdfs:label : has common name^^xsd:string</para>
    ///   <para>skos:definition : indicates a name by which something is frequently referred, without reference to any formal usage or structure^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasCommonName">fibo-fnd-rel-rel:hasCommonName</a>
    /// </summary>
    let hasCommonName = _prefixId.prefix "hasCommonName"
    /// <summary>
    ///   <para>rdfs:label : has designation^^xsd:string</para>
    ///   <para>skos:definition : relates an individual or organization to a position, role, or other designation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasDesignation">fibo-fnd-rel-rel:hasDesignation</a>
    /// </summary>
    let hasDesignation = _prefixId.prefix "hasDesignation"
    /// <summary>
    ///   <para>rdfs:label : has formal name^^xsd:string</para>
    ///   <para>skos:definition : indicates a name by which something is known for some official purpose or context, or which is structured in some way such as to always follow the same format regardless of usage^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasFormalName">fibo-fnd-rel-rel:hasFormalName</a>
    /// </summary>
    let hasFormalName = _prefixId.prefix "hasFormalName"
    /// <summary>
    ///   <para>rdfs:label : has legal name^^xsd:string</para>
    ///   <para>skos:definition : specifies the name used to refer to a party in legal communications^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasLegalName">fibo-fnd-rel-rel:hasLegalName</a>
    /// </summary>
    let hasLegalName = _prefixId.prefix "hasLegalName"
    /// <summary>
    ///   <para>rdfs:label : has tag^^xsd:string</para>
    ///   <para>skos:definition : combination of alphanumeric characters corresponding to a label for something^^xsd:string</para>
    ///   <para>skos:note : Text-valued tags may be useful for automated transformation or encoding systems, such as those used to produce IETF compliant language tags in XML. Such tags are required to be string-valued in FIBO, but not language-tagged strings.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasTag">fibo-fnd-rel-rel:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:label : holds^^xsd:string</para>
    ///   <para>skos:definition : is the relationship between a party and something it possesses, or over which it exercises some ownership or control or has at its discretion the ability to dispose of it as it sees fit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/holds">fibo-fnd-rel-rel:holds</a>
    /// </summary>
    let holds = _prefixId.prefix "holds"
    /// <summary>
    ///   <para>rdfs:label : involves^^xsd:string</para>
    ///   <para>skos:definition : (of a situation or event) includes (something) as a necessary part or result^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/involves">fibo-fnd-rel-rel:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>rdfs:label : is caused by^^xsd:string</para>
    ///   <para>skos:definition : is the relationship between an event (the effect) and a second event (the cause), where the first event is understood as a consequence of the second; also, the relationship between a set of factors (causes) and a phenomenon (the effect)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isCausedBy">fibo-fnd-rel-rel:isCausedBy</a>
    /// </summary>
    let isCausedBy = _prefixId.prefix "isCausedBy"
    /// <summary>
    ///   <para>rdfs:label : is conferred by^^xsd:string</para>
    ///   <para>skos:definition : a relationship between a right or obligation and the vehicle, such as an agreement or contract, that vests (or confers) said right or obligation^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This property should be read as describing some legal power or duty, some commitment or some social construct being conferred as a result of some social construct such as an agreement or some legal authority. These concepts, which would describe the kind of thing of which this is a property, and the kinds of thing in terms of which this property is framed, are outside the scope of this model and so are not shown.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isConferredBy">fibo-fnd-rel-rel:isConferredBy</a>
    /// </summary>
    let isConferredBy = _prefixId.prefix "isConferredBy"
    /// <summary>
    ///   <para>rdfs:label : is controlled by^^xsd:string</para>
    ///   <para>skos:definition : is influenced, managed, or directed by^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isControlledBy">fibo-fnd-rel-rel:isControlledBy</a>
    /// </summary>
    let isControlledBy = _prefixId.prefix "isControlledBy"
    /// <summary>
    ///   <para>rdfs:label : is evaluated by^^xsd:string</para>
    ///   <para>skos:definition : is ascertained or determined by^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isEvaluatedBy">fibo-fnd-rel-rel:isEvaluatedBy</a>
    /// </summary>
    let isEvaluatedBy = _prefixId.prefix "isEvaluatedBy"
    /// <summary>
    ///   <para>rdfs:label : is exemplified by^^xsd:string</para>
    ///   <para>skos:definition : is made concrete or is realized by^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isExemplifiedBy">fibo-fnd-rel-rel:isExemplifiedBy</a>
    /// </summary>
    let isExemplifiedBy = _prefixId.prefix "isExemplifiedBy"
    /// <summary>
    ///   <para>rdfs:label : is generated by^^xsd:string</para>
    ///   <para>skos:definition : identifies some party or something that produces something via some equation, logic, or rules^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isGeneratedBy">fibo-fnd-rel-rel:isGeneratedBy</a>
    /// </summary>
    let isGeneratedBy = _prefixId.prefix "isGeneratedBy"
    /// <summary>
    ///   <para>rdfs:label : is held by^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that possesses and has at least partial control of something, regardless of ownership^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isHeldBy">fibo-fnd-rel-rel:isHeldBy</a>
    /// </summary>
    let isHeldBy = _prefixId.prefix "isHeldBy"
    /// <summary>
    ///   <para>rdfs:label : is issued by^^xsd:string</para>
    ///   <para>skos:definition : indicates a functional entity or party responsible for circulating, distributing, or publishing something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isIssuedBy">fibo-fnd-rel-rel:isIssuedBy</a>
    /// </summary>
    let isIssuedBy = _prefixId.prefix "isIssuedBy"
    /// <summary>
    ///   <para>rdfs:label : is mandated by^^xsd:string</para>
    ///   <para>skos:definition : relates a responsibility, capacity, or action to that which requires it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isMandatedBy">fibo-fnd-rel-rel:isMandatedBy</a>
    /// </summary>
    let isMandatedBy = _prefixId.prefix "isMandatedBy"
    /// <summary>
    ///   <para>rdfs:label : is produced by^^xsd:string</para>
    ///   <para>skos:definition : identifies the producer that fabricates, manufactures or otherwise creates something through some production process^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isProducedBy">fibo-fnd-rel-rel:isProducedBy</a>
    /// </summary>
    let isProducedBy = _prefixId.prefix "isProducedBy"
    /// <summary>
    ///   <para>rdfs:label : issues^^xsd:string</para>
    ///   <para>skos:definition : officially makes something available^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/issues">fibo-fnd-rel-rel:issues</a>
    /// </summary>
    let issues = _prefixId.prefix "issues"
    /// <summary>
    ///   <para>rdfs:label : mandates^^xsd:string</para>
    ///   <para>skos:definition : relates something to a commitment, contract, law, obligation, requirement, regulation, or similar concept that requires it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/mandates">fibo-fnd-rel-rel:mandates</a>
    /// </summary>
    let mandates = _prefixId.prefix "mandates"
    /// <summary>
    ///   <para>rdfs:label : produces^^xsd:string</para>
    ///   <para>skos:definition : creates through a fabrication, manufacturing or production process^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/produces">fibo-fnd-rel-rel:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
    /// <summary>
    ///   <para>rdfs:label : was formerly known as^^xsd:string</para>
    ///   <para>skos:definition : indicates a name by which something was known in the past^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/wasFormerlyKnownAs">fibo-fnd-rel-rel:wasFormerlyKnownAs</a>
    /// </summary>
    let wasFormerlyKnownAs = _prefixId.prefix "wasFormerlyKnownAs"
