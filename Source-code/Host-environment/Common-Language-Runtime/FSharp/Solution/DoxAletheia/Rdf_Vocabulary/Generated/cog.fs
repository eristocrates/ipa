namespace http.purl.org.ontology.cco.core.hash

open DoxAletheia.Rdf_Vocabulary

module cog =
    let _namespace_name = "http://purl.org/ontology/cco/core#"

    /// <summary>
    /// An event concept for describing dynamics of characteristics, e.g. weight changes, periods of interest.
    /// <see href="http://purl.org/ontology/cco/core#CharacteristicDynamics"></see></summary>
    let CharacteristicDynamics =
        Namespaced_IRI.parse _namespace_name "CharacteristicDynamics" |> NamespacedName

    /// <summary>
    /// A cognitive characteristic object, which also can have weightings and characteristic dynamics etc. for describing a cognitive pattern.
    /// <see href="http://purl.org/ontology/cco/core#CognitiveCharacteristic"></see></summary>
    let CognitiveCharacteristic =
        Namespaced_IRI.parse _namespace_name "CognitiveCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/cco/core#ExplicitMining"></see>
    /// </summary>
    let ExplicitMining =
        Namespaced_IRI.parse _namespace_name "ExplicitMining" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/cco/core#ImplicitMining"></see>
    /// </summary>
    let ImplicitMining =
        Namespaced_IRI.parse _namespace_name "ImplicitMining" |> NamespacedName

    /// <summary>
    /// An activity, which is related to a topic of a cognitive charateristic description, e.g. if the topic is football a related activity can be playing or watching.
    /// <see href="http://purl.org/ontology/cco/core#activity"></see></summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName
    /// <summary>
    /// A link from a mined cognitive characteristic to the related person
    /// <see href="http://purl.org/ontology/cco/core#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName
    /// <summary>
    /// A link between an agent and a cognitive characteristic description
    /// <see href="http://purl.org/ontology/cco/core#habit"></see></summary>
    let habit = Namespaced_IRI.parse _namespace_name "habit" |> NamespacedName

    /// <summary>
    /// The time when the cognitive pattern appears in a certain kind of scenario.
    /// <see href="http://purl.org/ontology/cco/core#appear_time"></see></summary>
    let appear_time =
        Namespaced_IRI.parse _namespace_name "appear_time" |> NamespacedName

    /// <summary>
    /// An interval of attention for a cognitive pattern.
    /// <see href="http://purl.org/ontology/cco/core#attention_duration"></see></summary>
    let attention_duration =
        Namespaced_IRI.parse _namespace_name "attention_duration" |> NamespacedName

    /// <summary>
    /// An uncertain relation for competence representation. That means beliefs, persuasions or opinions, which can also be misconceptions.
    /// <see href="http://purl.org/ontology/cco/core#belief"></see></summary>
    let belief = Namespaced_IRI.parse _namespace_name "belief" |> NamespacedName
    /// <summary>
    /// The competence to (be able to) do or know something. That means abilities, skills, knowledge, expertise, beliefs etc.
    /// <see href="http://purl.org/ontology/cco/core#competence"></see></summary>
    let competence = Namespaced_IRI.parse _namespace_name "competence" |> NamespacedName

    /// <summary>
    /// Relates to the applied cognitive characteristic (property), e.g. competence, belief, expertise, skill, interest or setting.
    /// <see href="http://purl.org/ontology/cco/core#characteristic"></see></summary>
    let characteristic =
        Namespaced_IRI.parse _namespace_name "characteristic" |> NamespacedName

    /// <summary>
    /// To relate a cognitive characteristic to its temporal dynamics.
    /// <see href="http://purl.org/ontology/cco/core#characteristic_dynamics"></see></summary>
    let characteristic_dynamics =
        Namespaced_IRI.parse _namespace_name "characteristic_dynamics" |> NamespacedName

    /// <summary>
    /// This is the super property to describe cognitive characteristics of the user of the cognitive pattern dimension, e.g. interests, skills, or expertise.
    /// <see href="http://purl.org/ontology/cco/core#cognitive_characteristic"></see></summary>
    let cognitive_characteristic =
        Namespaced_IRI.parse _namespace_name "cognitive_characteristic" |> NamespacedName

    /// <summary>
    /// A topic of the cognitive characteristic.
    /// <see href="http://purl.org/ontology/cco/core#topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName
    /// <summary>
    /// A link between a context and evidence supporting the interpretation of habits in a context
    /// <see href="http://purl.org/ontology/cco/core#evidence"></see></summary>
    let evidence = Namespaced_IRI.parse _namespace_name "evidence" |> NamespacedName
    /// <summary>
    /// The knowledge or expertise in a certain domain or specific topic, e.g. football, programming languages or music.
    /// <see href="http://purl.org/ontology/cco/core#expertise"></see></summary>
    let expertise = Namespaced_IRI.parse _namespace_name "expertise" |> NamespacedName
    /// <summary>
    /// This property relates a certain area of interest or preference to an agent. That means this agent likes this topic somehow.
    /// <see href="http://purl.org/ontology/cco/core#interest"></see></summary>
    let interest = Namespaced_IRI.parse _namespace_name "interest" |> NamespacedName

    /// <summary>
    /// The longest continuous interval of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.
    /// <see href="http://purl.org/ontology/cco/core#longest_duration"></see></summary>
    let longest_duration =
        Namespaced_IRI.parse _namespace_name "longest_duration" |> NamespacedName

    /// <summary>
    /// A link between an agent and a topic of no interest to them
    /// <see href="http://purl.org/ontology/cco/core#not_interested_in"></see></summary>
    let not_interested_in =
        Namespaced_IRI.parse _namespace_name "not_interested_in" |> NamespacedName

    /// <summary>
    /// This weight reflects the overall interest in a topic and should be different from the actual weight of a cognitive characteristic.
    /// <see href="http://purl.org/ontology/cco/core#overall_weight"></see></summary>
    let overall_weight =
        Namespaced_IRI.parse _namespace_name "overall_weight" |> NamespacedName

    /// <summary>
    /// A certain setting or preference. Often re. a specific environment, e.g. an application.
    /// <see href="http://purl.org/ontology/cco/core#setting"></see></summary>
    let setting = Namespaced_IRI.parse _namespace_name "setting" |> NamespacedName
    /// <summary>
    /// The ability or skill to (be able to) do something, e.g. to walk, to play the piano or to work in a team.
    /// <see href="http://purl.org/ontology/cco/core#skill"></see></summary>
    let skill = Namespaced_IRI.parse _namespace_name "skill" |> NamespacedName

    /// <summary>
    /// A link from a cognitive characteristic to statistics about itself
    /// <see href="http://purl.org/ontology/cco/core#statistical_item"></see></summary>
    let statistical_item =
        Namespaced_IRI.parse _namespace_name "statistical_item" |> NamespacedName

    /// <summary>
    /// The overall duration of attention for a cognitive pattern, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.
    /// <see href="http://purl.org/ontology/cco/core#ultimative_duration"></see></summary>
    let ultimative_duration =
        Namespaced_IRI.parse _namespace_name "ultimative_duration" |> NamespacedName
