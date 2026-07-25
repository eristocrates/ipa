namespace http.purl.org.ontology.cco.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cog =
    let _namespace_iri = Namespace_Iri cog |> NamespaceIRI

    /// <summary>
    ///   <para>cog:CharacteristicDynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An event concept for describing dynamics of characteristics, e.g. weight changes, periods of interest.</para>
    /// labels<para>Characteristic Dynamics</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#CharacteristicDynamics">http://purl.org/ontology/cco/core#CharacteristicDynamics</seealso>
    let CharacteristicDynamics =
        Prefixed_Name(cog, "CharacteristicDynamics") |> PrefixedName

    /// <summary>
    ///   <para>cog:competence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The competence to (be able to) do or know something. That means abilities, skills, knowledge, expertise, beliefs etc.</para>
    /// labels<para>has competence</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#competence">http://purl.org/ontology/cco/core#competence</seealso>
    let competence = Prefixed_Name(cog, "competence") |> PrefixedName
    /// <summary>
    ///   <para>cog:characteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Relates to the applied cognitive characteristic (property), e.g. competence, belief, expertise, skill, interest or setting.</para>
    /// labels<para>has characteristic</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#characteristic">http://purl.org/ontology/cco/core#characteristic</seealso>
    let characteristic = Prefixed_Name(cog, "characteristic") |> PrefixedName

    /// <summary>
    ///   <para>cog:characteristic_dynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>To relate a cognitive characteristic to its temporal dynamics.</para>
    /// labels<para>has characteristic dynamics</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#characteristic_dynamics">http://purl.org/ontology/cco/core#characteristic_dynamics</seealso>
    let characteristic_dynamics =
        Prefixed_Name(cog, "characteristic_dynamics") |> PrefixedName

    /// <summary>
    ///   <para>cog:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A topic of the cognitive characteristic.</para>
    /// labels<para>has topic</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#topic">http://purl.org/ontology/cco/core#topic</seealso>
    let topic = Prefixed_Name(cog, "topic") |> PrefixedName
    /// <summary>
    ///   <para>cog:expertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The knowledge or expertise in a certain domain or specific topic, e.g. football, programming languages or music.</para>
    /// labels<para>has expertise</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#expertise">http://purl.org/ontology/cco/core#expertise</seealso>
    let expertise = Prefixed_Name(cog, "expertise") |> PrefixedName
    /// <summary>
    ///   <para>cog:longest_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The longest continuous interval of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.</para>
    /// labels<para>has longest duration</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#longest_duration">http://purl.org/ontology/cco/core#longest_duration</seealso>
    let longest_duration = Prefixed_Name(cog, "longest_duration") |> PrefixedName
    /// <summary>
    ///   <para>cog:not_interested_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link between an agent and a topic of no interest to them</para>
    /// labels<para>is not interested in</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#not_interested_in">http://purl.org/ontology/cco/core#not_interested_in</seealso>
    let not_interested_in = Prefixed_Name(cog, "not_interested_in") |> PrefixedName
    /// <summary>
    ///   <para>cog:overall_weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This weight reflects the overall interest in a topic and should be different from the actual weight of a cognitive characteristic.</para>
    /// labels<para>has overall weight</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#overall_weight">http://purl.org/ontology/cco/core#overall_weight</seealso>
    let overall_weight = Prefixed_Name(cog, "overall_weight") |> PrefixedName
    /// <summary>
    ///   <para>cog:setting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A certain setting or preference. Often re. a specific environment, e.g. an application.</para>
    /// labels<para>has setting</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#setting">http://purl.org/ontology/cco/core#setting</seealso>
    let setting = Prefixed_Name(cog, "setting") |> PrefixedName
    /// <summary>
    ///   <para>cog:skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ability or skill to (be able to) do something, e.g. to walk, to play the piano or to work in a team.</para>
    /// labels<para>has skill</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#skill">http://purl.org/ontology/cco/core#skill</seealso>
    let skill = Prefixed_Name(cog, "skill") |> PrefixedName
    /// <summary>
    ///   <para>cog:ultimative_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The overall duration of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.</para>
    /// labels<para>has ultimative duration</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#ultimative_duration">http://purl.org/ontology/cco/core#ultimative_duration</seealso>
    let ultimative_duration = Prefixed_Name(cog, "ultimative_duration") |> PrefixedName
    /// <summary>
    ///   <para>cog:ImplicitMining</para>
    /// </summary>
    /// <remarks>
    ///   <para>scovo:Dimension</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#ImplicitMining">http://purl.org/ontology/cco/core#ImplicitMining</seealso>
    let ImplicitMining = Prefixed_Name(cog, "ImplicitMining") |> PrefixedName
    /// <summary>
    ///   <para>cog:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link from a mined cognitive characteristic to the related person</para>
    /// labels<para>has agent</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#agent">http://purl.org/ontology/cco/core#agent</seealso>
    let agent = Prefixed_Name(cog, "agent") |> PrefixedName
    /// <summary>
    ///   <para>cog:attention_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An interval of attention for a cognitive pattern.</para>
    /// labels<para>has attention duration</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#attention_duration">http://purl.org/ontology/cco/core#attention_duration</seealso>
    let attention_duration = Prefixed_Name(cog, "attention_duration") |> PrefixedName
    /// <summary>
    ///   <para>cog:belief</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An uncertain relation for competence representation. That means beliefs, persuasions or opinions, which can also be misconceptions.</para>
    /// labels<para>has belief</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#belief">http://purl.org/ontology/cco/core#belief</seealso>
    let belief = Prefixed_Name(cog, "belief") |> PrefixedName

    /// <summary>
    ///   <para>cog:cognitive_characteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the super property to describe cognitive characteristics of the user of the cognitive pattern dimension, e.g. interests, skills, or expertise.</para>
    /// labels<para>has cognitive characteristic</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#cognitive_characteristic">http://purl.org/ontology/cco/core#cognitive_characteristic</seealso>
    let cognitive_characteristic =
        Prefixed_Name(cog, "cognitive_characteristic") |> PrefixedName

    /// <summary>
    ///   <para>cog:evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link between a context and evidence supporting the interpretation of habits in a context</para>
    /// labels<para>has evidence</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#evidence">http://purl.org/ontology/cco/core#evidence</seealso>
    let evidence = Prefixed_Name(cog, "evidence") |> PrefixedName

    /// <summary>
    ///   <para>cog:CognitiveCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A cognitive characteristic object, which also can have weightings and characteristic dynamics etc. for describing a cognitive pattern.</para>
    /// labels<para>Cognitive Characteristic</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#CognitiveCharacteristic">http://purl.org/ontology/cco/core#CognitiveCharacteristic</seealso>
    let CognitiveCharacteristic =
        Prefixed_Name(cog, "CognitiveCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>cog:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An activity, which is related to a topic of a cognitive charateristic description, e.g. if the topic is football a related activity can be playing or watching.</para>
    /// labels<para>has activity</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#activity">http://purl.org/ontology/cco/core#activity</seealso>
    let activity = Prefixed_Name(cog, "activity") |> PrefixedName
    /// <summary>
    ///   <para>cog:interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property relates a certain area of interest or preference to an agent. That means this agent likes this topic somehow.</para>
    /// labels<para>has interest</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#interest">http://purl.org/ontology/cco/core#interest</seealso>
    let interest = Prefixed_Name(cog, "interest") |> PrefixedName
    /// <summary>
    ///   <para>cog:ExplicitMining</para>
    /// </summary>
    /// <remarks>
    ///   <para>scovo:Dimension</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#ExplicitMining">http://purl.org/ontology/cco/core#ExplicitMining</seealso>
    let ExplicitMining = Prefixed_Name(cog, "ExplicitMining") |> PrefixedName
    /// <summary>
    ///   <para>cog:appear_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The time when the cognitive pattern appears in a certain kind of scenario.</para>
    /// labels<para>has appear time</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#appear_time">http://purl.org/ontology/cco/core#appear_time</seealso>
    let appear_time = Prefixed_Name(cog, "appear_time") |> PrefixedName
    /// <summary>
    ///   <para>cog:statistical_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link from a cognitive characteristic to statistics about itself</para>
    /// labels<para>has statistical item</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#statistical_item">http://purl.org/ontology/cco/core#statistical_item</seealso>
    let statistical_item = Prefixed_Name(cog, "statistical_item") |> PrefixedName
    /// <summary>
    ///   <para>cog:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#">http://purl.org/ontology/cco/core#</seealso>
    let _prefix_iri = Prefixed_Name(cog, "") |> PrefixedName
    /// <summary>
    ///   <para>cog:habit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link between an agent and a cognitive characteristic description</para>
    /// labels<para>has habit</para></remarks>
    /// <seealso href="http://purl.org/ontology/cco/core#habit">http://purl.org/ontology/cco/core#habit</seealso>
    let habit = Prefixed_Name(cog, "habit") |> PrefixedName
