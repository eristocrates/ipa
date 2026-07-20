namespace http.purl.org.ontology.cco.core.hash

open DoxAletheia

module cog =
    let _namespace_name = "http://purl.org/ontology/cco/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An event concept for describing dynamics of characteristics, e.g. weight changes, periods of interest.
    /// <see href="http://purl.org/ontology/cco/core#CharacteristicDynamics"></see></summary>
    let CharacteristicDynamics = _prefix "CharacteristicDynamics"
    /// <summary>
    /// A cognitive characteristic object, which also can have weightings and characteristic dynamics etc. for describing a cognitive pattern.
    /// <see href="http://purl.org/ontology/cco/core#CognitiveCharacteristic"></see></summary>
    let CognitiveCharacteristic = _prefix "CognitiveCharacteristic"
    /// <summary>
    ///   <see href="http://purl.org/ontology/cco/core#ExplicitMining"></see>
    /// </summary>
    let ExplicitMining = _prefix "ExplicitMining"
    /// <summary>
    ///   <see href="http://purl.org/ontology/cco/core#ImplicitMining"></see>
    /// </summary>
    let ImplicitMining = _prefix "ImplicitMining"
    /// <summary>
    /// An activity, which is related to a topic of a cognitive charateristic description, e.g. if the topic is football a related activity can be playing or watching.
    /// <see href="http://purl.org/ontology/cco/core#activity"></see></summary>
    let activity = _prefix "activity"
    /// <summary>
    /// A link from a mined cognitive characteristic to the related person
    /// <see href="http://purl.org/ontology/cco/core#agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// A link between an agent and a cognitive characteristic description
    /// <see href="http://purl.org/ontology/cco/core#habit"></see></summary>
    let habit = _prefix "habit"
    /// <summary>
    /// The time when the cognitive pattern appears in a certain kind of scenario.
    /// <see href="http://purl.org/ontology/cco/core#appear_time"></see></summary>
    let appear_time = _prefix "appear_time"
    /// <summary>
    /// An interval of attention for a cognitive pattern.
    /// <see href="http://purl.org/ontology/cco/core#attention_duration"></see></summary>
    let attention_duration = _prefix "attention_duration"
    /// <summary>
    /// An uncertain relation for competence representation. That means beliefs, persuasions or opinions, which can also be misconceptions.
    /// <see href="http://purl.org/ontology/cco/core#belief"></see></summary>
    let belief = _prefix "belief"
    /// <summary>
    /// The competence to (be able to) do or know something. That means abilities, skills, knowledge, expertise, beliefs etc.
    /// <see href="http://purl.org/ontology/cco/core#competence"></see></summary>
    let competence = _prefix "competence"
    /// <summary>
    /// Relates to the applied cognitive characteristic (property), e.g. competence, belief, expertise, skill, interest or setting.
    /// <see href="http://purl.org/ontology/cco/core#characteristic"></see></summary>
    let characteristic = _prefix "characteristic"
    /// <summary>
    /// To relate a cognitive characteristic to its temporal dynamics.
    /// <see href="http://purl.org/ontology/cco/core#characteristic_dynamics"></see></summary>
    let characteristic_dynamics = _prefix "characteristic_dynamics"
    /// <summary>
    /// This is the super property to describe cognitive characteristics of the user of the cognitive pattern dimension, e.g. interests, skills, or expertise.
    /// <see href="http://purl.org/ontology/cco/core#cognitive_characteristic"></see></summary>
    let cognitive_characteristic = _prefix "cognitive_characteristic"
    /// <summary>
    /// A topic of the cognitive characteristic.
    /// <see href="http://purl.org/ontology/cco/core#topic"></see></summary>
    let topic = _prefix "topic"
    /// <summary>
    /// A link between a context and evidence supporting the interpretation of habits in a context
    /// <see href="http://purl.org/ontology/cco/core#evidence"></see></summary>
    let evidence = _prefix "evidence"
    /// <summary>
    /// The knowledge or expertise in a certain domain or specific topic, e.g. football, programming languages or music.
    /// <see href="http://purl.org/ontology/cco/core#expertise"></see></summary>
    let expertise = _prefix "expertise"
    /// <summary>
    /// This property relates a certain area of interest or preference to an agent. That means this agent likes this topic somehow.
    /// <see href="http://purl.org/ontology/cco/core#interest"></see></summary>
    let interest = _prefix "interest"
    /// <summary>
    /// The longest continuous interval of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.
    /// <see href="http://purl.org/ontology/cco/core#longest_duration"></see></summary>
    let longest_duration = _prefix "longest_duration"
    /// <summary>
    /// A link between an agent and a topic of no interest to them
    /// <see href="http://purl.org/ontology/cco/core#not_interested_in"></see></summary>
    let not_interested_in = _prefix "not_interested_in"
    /// <summary>
    /// This weight reflects the overall interest in a topic and should be different from the actual weight of a cognitive characteristic.
    /// <see href="http://purl.org/ontology/cco/core#overall_weight"></see></summary>
    let overall_weight = _prefix "overall_weight"
    /// <summary>
    /// A certain setting or preference. Often re. a specific environment, e.g. an application.
    /// <see href="http://purl.org/ontology/cco/core#setting"></see></summary>
    let setting = _prefix "setting"
    /// <summary>
    /// The ability or skill to (be able to) do something, e.g. to walk, to play the piano or to work in a team.
    /// <see href="http://purl.org/ontology/cco/core#skill"></see></summary>
    let skill = _prefix "skill"
    /// <summary>
    /// A link from a cognitive characteristic to statistics about itself
    /// <see href="http://purl.org/ontology/cco/core#statistical_item"></see></summary>
    let statistical_item = _prefix "statistical_item"
    /// <summary>
    /// The overall duration of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.
    /// <see href="http://purl.org/ontology/cco/core#ultimative_duration"></see></summary>
    let ultimative_duration = _prefix "ultimative_duration"
