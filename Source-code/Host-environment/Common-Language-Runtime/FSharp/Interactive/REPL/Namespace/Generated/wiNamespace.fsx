#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wi =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/wi/core#" "wi"
    let _namespaceIri = _prefixId.prefix ""
    let ExplicitMining = _prefixId.prefix "ExplicitMining"
    let ImplicitMining = _prefixId.prefix "ImplicitMining"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Interest Dynamics</para>
    ///   <para>rdfs:comment : An event concept for describing dynamics of interests, e.g. weight changes, periods of interest.</para>
    ///   <a href="http://purl.org/ontology/wi/core#InterestDynamics">wi:InterestDynamics</a>
    /// </summary>
    let InterestDynamics = _prefixId.prefix "InterestDynamics"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Weighted Interest</para>
    ///   <para>rdfs:comment : A weighted interest object, which also can have interest dynamics etc.</para>
    ///   <a href="http://purl.org/ontology/wi/core#WeightedInterest">wi:WeightedInterest</a>
    /// </summary>
    let WeightedInterest = _prefixId.prefix "WeightedInterest"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has agent</para>
    ///   <para>rdfs:comment : A link from a mined interest to the related person</para>
    ///   <a href="http://purl.org/ontology/wi/core#agent">wi:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has appear time</para>
    ///   <para>rdfs:comment : The time when the interest appears in a certain kind of scenario.</para>
    ///   <a href="http://purl.org/ontology/wi/core#appear_time">wi:appear_time</a>
    /// </summary>
    let appear_time = _prefixId.prefix "appear_time"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has attention duration</para>
    ///   <para>rdfs:comment : An interval of attention for an interest.</para>
    ///   <a href="http://purl.org/ontology/wi/core#attention_duration">wi:attention_duration</a>
    /// </summary>
    let attention_duration = _prefixId.prefix "attention_duration"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has evidence</para>
    ///   <para>rdfs:comment : A link between a context and evidence supporting the interpretation of preferences in a context</para>
    ///   <a href="http://purl.org/ontology/wi/core#evidence">wi:evidence</a>
    /// </summary>
    let evidence = _prefixId.prefix "evidence"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has interest dynamics</para>
    ///   <para>rdfs:comment : To relate a weighted interest to its temporal dynamics.</para>
    ///   <a href="http://purl.org/ontology/wi/core#interest_dynamics">wi:interest_dynamics</a>
    /// </summary>
    let interest_dynamics = _prefixId.prefix "interest_dynamics"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has longest duration</para>
    ///   <para>rdfs:comment : The longest continuous interval of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.</para>
    ///   <a href="http://purl.org/ontology/wi/core#longest_duration">wi:longest_duration</a>
    /// </summary>
    let longest_duration = _prefixId.prefix "longest_duration"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : is not interested in</para>
    ///   <para>rdfs:comment : A link between an agent and a topic of no interest to them</para>
    ///   <a href="http://purl.org/ontology/wi/core#not_interested_in">wi:not_interested_in</a>
    /// </summary>
    let not_interested_in = _prefixId.prefix "not_interested_in"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has overall weight</para>
    ///   <para>rdfs:comment : This weight reflects the overall interest in a topic and should be different from the actual weight of interest.</para>
    ///   <a href="http://purl.org/ontology/wi/core#overall_weight">wi:overall_weight</a>
    /// </summary>
    let overall_weight = _prefixId.prefix "overall_weight"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has preference</para>
    ///   <para>rdfs:comment : A link between an agent and a weighted interest</para>
    ///   <a href="http://purl.org/ontology/wi/core#preference">wi:preference</a>
    /// </summary>
    let preference = _prefixId.prefix "preference"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has statistical item</para>
    ///   <para>rdfs:comment : A link from an interest to statistics about itself</para>
    ///   <a href="http://purl.org/ontology/wi/core#statistical_item">wi:statistical_item</a>
    /// </summary>
    let statistical_item = _prefixId.prefix "statistical_item"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has topic</para>
    ///   <para>rdfs:comment : A topic of the weighted interest</para>
    ///   <a href="http://purl.org/ontology/wi/core#topic">wi:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has ultimative duration</para>
    ///   <para>rdfs:comment : The overall duration of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.</para>
    ///   <a href="http://purl.org/ontology/wi/core#ultimative_duration">wi:ultimative_duration</a>
    /// </summary>
    let ultimative_duration = _prefixId.prefix "ultimative_duration"
