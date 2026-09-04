#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-value`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/value/" "ceon-value"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Economic Value^^xsd:string</para>
    ///   <para>rdfs:comment : Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/EconomicValue">ceon-value:EconomicValue</a>
    /// </summary>
    let EconomicValue = _prefixId.prefix "EconomicValue"
    /// <summary>
    ///   <para>rdfs:label : Environmental Value^^xsd:string</para>
    ///   <para>rdfs:comment : Environmental value represents how a thing (e.g., a product or service) match some environmental goals or needs of an actor under some circumstances.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/EnvironmentalValue">ceon-value:EnvironmentalValue</a>
    /// </summary>
    let EnvironmentalValue = _prefixId.prefix "EnvironmentalValue"
    /// <summary>
    ///   <para>rdfs:label : Exchange Value^^xsd:string</para>
    ///   <para>rdfs:comment : Exchange value represents the worth of a product, resource, service in a exchange setting, i.e., a product, resource, service is traded or sold.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/ExchangeValue">ceon-value:ExchangeValue</a>
    /// </summary>
    let ExchangeValue = _prefixId.prefix "ExchangeValue"
    /// <summary>
    ///   <para>rdfs:label : Social Value^^xsd:string</para>
    ///   <para>rdfs:comment : Social value represents how a thing (e.g., a product or service) match some social goals or needs of an actor under some circumstances.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/SocialValue">ceon-value:SocialValue</a>
    /// </summary>
    let SocialValue = _prefixId.prefix "SocialValue"
    /// <summary>
    ///   <para>rdfs:label : Use Value^^xsd:string</para>
    ///   <para>rdfs:comment : Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/UseValue">ceon-value:UseValue</a>
    /// </summary>
    let UseValue = _prefixId.prefix "UseValue"
    /// <summary>
    ///   <para>rdfs:label : Value^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : ISO 59004:2024 - 3.1.7 value^^xsd:string</para>
    ///   <para>rdfs:comment : Gain(s) or benefit(s) from satisfying needs and expectations,	in relation to the use	and conservation of resources. EXAMPLE: Revenue, savings, productivity, sustainability, satisfaction, empowerment, engagement, experience, public health, trust. Value is relative to, and determined by the perception of, those interested party(ies) able to capture it. Value can be financial or non-financial, e.g. social, environmental, other gains or benefits. Value is dynamic over time.</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/Value">ceon-value:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    let ValueConsumer = _prefixId.prefix "ValueConsumer"
    let ValueContributor = _prefixId.prefix "ValueContributor"
    let ValueCreator = _prefixId.prefix "ValueCreator"
    let ValueDestroyer = _prefixId.prefix "ValueDestroyer"
    let ValueDistributor = _prefixId.prefix "ValueDistributor"
    let ValueEvaluator = _prefixId.prefix "ValueEvaluator"
    /// <summary>
    ///   <para>rdfs:label : Value Participation^^xsd:string</para>
    ///   <para>rdfs:comment : A participation that may create/destory/miss value.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/ValueParticipation">ceon-value:ValueParticipation</a>
    /// </summary>
    let ValueParticipation = _prefixId.prefix "ValueParticipation"
    /// <summary>
    ///   <para>rdfs:label : Value Participation Role^^xsd:string</para>
    ///   <para>rdfs:comment : A role that a value participant can take.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/ValueParticipationRole">ceon-value:ValueParticipationRole</a>
    /// </summary>
    let ValueParticipationRole = _prefixId.prefix "ValueParticipationRole"
    /// <summary>
    ///   <para>rdfs:label : Value Perception^^xsd:string</para>
    ///   <para>rdfs:comment : Value perception of an actor determines specifc values.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/ValuePerception">ceon-value:ValuePerception</a>
    /// </summary>
    let ValuePerception = _prefixId.prefix "ValuePerception"
    /// <summary>
    ///   <para>rdfs:label : Value Proposition^^xsd:string</para>
    ///   <para>rdfs:comment : Proposed or intended value outcome of some process, action or collaboration.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/ValueProposition">ceon-value:ValueProposition</a>
    /// </summary>
    let ValueProposition = _prefixId.prefix "ValueProposition"
    /// <summary>
    ///   <para>rdfs:label : has aimed value^^xsd:string</para>
    ///   <para>rdfs:comment : A value proposition has specific aimed values.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/hasAimedValue">ceon-value:hasAimedValue</a>
    /// </summary>
    let hasAimedValue = _prefixId.prefix "hasAimedValue"
    /// <summary>
    ///   <para>rdfs:label : has associated value^^xsd:string</para>
    ///   <para>rdfs:comment : A value perception about creating/destoring/missing some value.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/hasAssociatedValue">ceon-value:hasAssociatedValue</a>
    /// </summary>
    let hasAssociatedValue = _prefixId.prefix "hasAssociatedValue"
    /// <summary>
    ///   <para>rdfs:label : has perception^^xsd:string</para>
    ///   <para>rdfs:comment : An actor perceive specific values, or a value proposition is about specific values.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/hasPerception">ceon-value:hasPerception</a>
    /// </summary>
    let hasPerception = _prefixId.prefix "hasPerception"
    /// <summary>
    ///   <para>rdfs:label : has value proposition targets^^xsd:string</para>
    ///   <para>rdfs:comment : A value proposition is proposed about specific actors, participations or resources.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/hasVPTargets">ceon-value:hasVPTargets</a>
    /// </summary>
    let hasVPTargets = _prefixId.prefix "hasVPTargets"
    /// <summary>
    ///   <para>rdfs:label : has valuable resource^^xsd:string</para>
    ///   <para>rdfs:comment : A value participation has participating resources.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/hasValuableResource">ceon-value:hasValuableResource</a>
    /// </summary>
    let hasValuableResource = _prefixId.prefix "hasValuableResource"
    /// <summary>
    ///   <para>rdfs:label : has value participant role^^xsd:string</para>
    ///   <para>rdfs:comment : Holds the value of the role of the value participant in this value participation relation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/hasValueParticipantRole">ceon-value:hasValueParticipantRole</a>
    /// </summary>
    let hasValueParticipantRole = _prefixId.prefix "hasValueParticipantRole"
    /// <summary>
    ///   <para>rdfs:label : on value participation^^xsd:string</para>
    ///   <para>rdfs:comment : A perception is on specific value participations.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/onValueParticipation">ceon-value:onValueParticipation</a>
    /// </summary>
    let onValueParticipation = _prefixId.prefix "onValueParticipation"
    /// <summary>
    ///   <para>rdfs:label : proposed by^^xsd:string</para>
    ///   <para>rdfs:comment : A value proposition is proposed by specific actors.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/proposedBy">ceon-value:proposedBy</a>
    /// </summary>
    let proposedBy = _prefixId.prefix "proposedBy"
    /// <summary>
    ///   <para>rdfs:label : targetting actor^^xsd:string</para>
    ///   <para>rdfs:comment : A value proposition is about some actors.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/targettingActor">ceon-value:targettingActor</a>
    /// </summary>
    let targettingActor = _prefixId.prefix "targettingActor"
    /// <summary>
    ///   <para>rdfs:label : targetting resource^^xsd:string</para>
    ///   <para>rdfs:comment : A value proposition is about some resources.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/targettingResource">ceon-value:targettingResource</a>
    /// </summary>
    let targettingResource = _prefixId.prefix "targettingResource"
    /// <summary>
    ///   <para>rdfs:label : targetting value participation^^xsd:string</para>
    ///   <para>rdfs:comment : A value proposition is about some participation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/value/targettingValueParticipation">ceon-value:targettingValueParticipation</a>
    /// </summary>
    let targettingValueParticipation = _prefixId.prefix "targettingValueParticipation"
