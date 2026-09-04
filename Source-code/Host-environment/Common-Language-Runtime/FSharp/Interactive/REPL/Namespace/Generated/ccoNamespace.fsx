#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cco =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/cco/core#" "cco"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Characteristic Dynamics</para>
    ///   <para>rdfs:comment : An event concept for describing dynamics of characteristics, e.g. weight changes, periods of interest.</para>
    ///   <a href="http://purl.org/ontology/cco/core#CharacteristicDynamics">cco:CharacteristicDynamics</a>
    /// </summary>
    let CharacteristicDynamics = _prefixId.prefix "CharacteristicDynamics"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Cognitive Characteristic</para>
    ///   <para>rdfs:comment : A cognitive characteristic object, which also can have weightings and characteristic dynamics etc. for describing a cognitive pattern.</para>
    ///   <a href="http://purl.org/ontology/cco/core#CognitiveCharacteristic">cco:CognitiveCharacteristic</a>
    /// </summary>
    let CognitiveCharacteristic = _prefixId.prefix "CognitiveCharacteristic"
    let ExplicitMining = _prefixId.prefix "ExplicitMining"
    let ImplicitMining = _prefixId.prefix "ImplicitMining"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has activity</para>
    ///   <para>rdfs:comment : An activity, which is related to a topic of a cognitive charateristic description, e.g. if the topic is football a related activity can be playing or watching.</para>
    ///   <a href="http://purl.org/ontology/cco/core#activity">cco:activity</a>
    /// </summary>
    let activity = _prefixId.prefix "activity"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has agent</para>
    ///   <para>rdfs:comment : A link from a mined cognitive characteristic to the related person</para>
    ///   <a href="http://purl.org/ontology/cco/core#agent">cco:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has appear time</para>
    ///   <para>rdfs:comment : The time when the cognitive pattern appears in a certain kind of scenario.</para>
    ///   <a href="http://purl.org/ontology/cco/core#appear_time">cco:appear_time</a>
    /// </summary>
    let appear_time = _prefixId.prefix "appear_time"
    /// <summary>
    ///   <para>rdfs:label : has attention duration</para>
    ///   <para>rdfs:comment : An interval of attention for a cognitive pattern.</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/ontology/cco/core#attention_duration">cco:attention_duration</a>
    /// </summary>
    let attention_duration = _prefixId.prefix "attention_duration"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has belief</para>
    ///   <para>rdfs:comment : An uncertain relation for competence representation. That means beliefs, persuasions or opinions, which can also be misconceptions.</para>
    ///   <a href="http://purl.org/ontology/cco/core#belief">cco:belief</a>
    /// </summary>
    let belief = _prefixId.prefix "belief"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has characteristic</para>
    ///   <para>rdfs:comment : Relates to the applied cognitive characteristic (property), e.g. competence, belief, expertise, skill, interest or setting.</para>
    ///   <a href="http://purl.org/ontology/cco/core#characteristic">cco:characteristic</a>
    /// </summary>
    let characteristic = _prefixId.prefix "characteristic"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has characteristic dynamics</para>
    ///   <para>rdfs:comment : To relate a cognitive characteristic to its temporal dynamics.</para>
    ///   <a href="http://purl.org/ontology/cco/core#characteristic_dynamics">cco:characteristic_dynamics</a>
    /// </summary>
    let characteristic_dynamics = _prefixId.prefix "characteristic_dynamics"
    /// <summary>
    ///   <para>rdfs:comment : This is the super property to describe cognitive characteristics of the user of the cognitive pattern dimension, e.g. interests, skills, or expertise.</para>
    ///   <para>rdfs:label : has cognitive characteristic</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/ontology/cco/core#cognitive_characteristic">cco:cognitive_characteristic</a>
    /// </summary>
    let cognitive_characteristic = _prefixId.prefix "cognitive_characteristic"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has competence</para>
    ///   <para>rdfs:comment : The competence to (be able to) do or know something. That means abilities, skills, knowledge, expertise, beliefs etc.</para>
    ///   <a href="http://purl.org/ontology/cco/core#competence">cco:competence</a>
    /// </summary>
    let competence = _prefixId.prefix "competence"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has evidence</para>
    ///   <para>rdfs:comment : A link between a context and evidence supporting the interpretation of habits in a context</para>
    ///   <a href="http://purl.org/ontology/cco/core#evidence">cco:evidence</a>
    /// </summary>
    let evidence = _prefixId.prefix "evidence"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has expertise</para>
    ///   <para>rdfs:comment : The knowledge or expertise in a certain domain or specific topic, e.g. football, programming languages or music.</para>
    ///   <a href="http://purl.org/ontology/cco/core#expertise">cco:expertise</a>
    /// </summary>
    let expertise = _prefixId.prefix "expertise"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has habit</para>
    ///   <para>rdfs:comment : A link between an agent and a cognitive characteristic description</para>
    ///   <a href="http://purl.org/ontology/cco/core#habit">cco:habit</a>
    /// </summary>
    let habit = _prefixId.prefix "habit"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has interest</para>
    ///   <para>rdfs:comment : This property relates a certain area of interest or preference to an agent. That means this agent likes this topic somehow.</para>
    ///   <a href="http://purl.org/ontology/cco/core#interest">cco:interest</a>
    /// </summary>
    let interest = _prefixId.prefix "interest"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has longest duration</para>
    ///   <para>rdfs:comment : The longest continuous interval of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.</para>
    ///   <a href="http://purl.org/ontology/cco/core#longest_duration">cco:longest_duration</a>
    /// </summary>
    let longest_duration = _prefixId.prefix "longest_duration"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : is not interested in</para>
    ///   <para>rdfs:comment : A link between an agent and a topic of no interest to them</para>
    ///   <a href="http://purl.org/ontology/cco/core#not_interested_in">cco:not_interested_in</a>
    /// </summary>
    let not_interested_in = _prefixId.prefix "not_interested_in"
    /// <summary>
    ///   <para>rdfs:label : has overall weight</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : This weight reflects the overall interest in a topic and should be different from the actual weight of a cognitive characteristic.</para>
    ///   <a href="http://purl.org/ontology/cco/core#overall_weight">cco:overall_weight</a>
    /// </summary>
    let overall_weight = _prefixId.prefix "overall_weight"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has setting</para>
    ///   <para>rdfs:comment : A certain setting or preference. Often re. a specific environment, e.g. an application.</para>
    ///   <a href="http://purl.org/ontology/cco/core#setting">cco:setting</a>
    /// </summary>
    let setting = _prefixId.prefix "setting"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has skill</para>
    ///   <para>rdfs:comment : The ability or skill to (be able to) do something, e.g. to walk, to play the piano or to work in a team.</para>
    ///   <a href="http://purl.org/ontology/cco/core#skill">cco:skill</a>
    /// </summary>
    let skill = _prefixId.prefix "skill"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has statistical item</para>
    ///   <para>rdfs:comment : A link from a cognitive characteristic to statistics about itself</para>
    ///   <a href="http://purl.org/ontology/cco/core#statistical_item">cco:statistical_item</a>
    /// </summary>
    let statistical_item = _prefixId.prefix "statistical_item"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has topic</para>
    ///   <para>rdfs:comment : A topic of the cognitive characteristic.</para>
    ///   <a href="http://purl.org/ontology/cco/core#topic">cco:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has ultimative duration</para>
    ///   <para>rdfs:comment : The overall duration of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.</para>
    ///   <a href="http://purl.org/ontology/cco/core#ultimative_duration">cco:ultimative_duration</a>
    /// </summary>
    let ultimative_duration = _prefixId.prefix "ultimative_duration"
