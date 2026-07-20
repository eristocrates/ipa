namespace http.purl.org.ontology.wi.core.hash

open DoxAletheia

module wi =
    let _namespace_name = "http://purl.org/ontology/wi/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/wi/core#ExplicitMining"></see>
    /// </summary>
    let ExplicitMining = _prefix "ExplicitMining"
    /// <summary>
    ///   <see href="http://purl.org/ontology/wi/core#ImplicitMining"></see>
    /// </summary>
    let ImplicitMining = _prefix "ImplicitMining"
    /// <summary>
    /// An event concept for describing dynamics of interests, e.g. weight changes, periods of interest.
    /// <see href="http://purl.org/ontology/wi/core#InterestDynamics"></see></summary>
    let InterestDynamics = _prefix "InterestDynamics"
    /// <summary>
    /// A weighted interest object, which also can have interest dynamics etc.
    /// <see href="http://purl.org/ontology/wi/core#WeightedInterest"></see></summary>
    let WeightedInterest = _prefix "WeightedInterest"
    /// <summary>
    /// A link from a mined interest to the related person
    /// <see href="http://purl.org/ontology/wi/core#agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// A link between an agent and a weighted interest
    /// <see href="http://purl.org/ontology/wi/core#preference"></see></summary>
    let preference = _prefix "preference"
    /// <summary>
    /// The time when the interest appears in a certain kind of scenario.
    /// <see href="http://purl.org/ontology/wi/core#appear_time"></see></summary>
    let appear_time = _prefix "appear_time"
    /// <summary>
    /// An interval of attention for an interest.
    /// <see href="http://purl.org/ontology/wi/core#attention_duration"></see></summary>
    let attention_duration = _prefix "attention_duration"
    /// <summary>
    /// A link between a context and evidence supporting the interpretation of preferences in a context
    /// <see href="http://purl.org/ontology/wi/core#evidence"></see></summary>
    let evidence = _prefix "evidence"
    /// <summary>
    /// To relate a weighted interest to its temporal dynamics.
    /// <see href="http://purl.org/ontology/wi/core#interest_dynamics"></see></summary>
    let interest_dynamics = _prefix "interest_dynamics"
    /// <summary>
    /// The longest continuous interval of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.
    /// <see href="http://purl.org/ontology/wi/core#longest_duration"></see></summary>
    let longest_duration = _prefix "longest_duration"
    /// <summary>
    /// A link between an agent and a topic of no interest to them
    /// <see href="http://purl.org/ontology/wi/core#not_interested_in"></see></summary>
    let not_interested_in = _prefix "not_interested_in"
    /// <summary>
    /// This weight reflects the overall interest in a topic and should be different from the actual weight of interest.
    /// <see href="http://purl.org/ontology/wi/core#overall_weight"></see></summary>
    let overall_weight = _prefix "overall_weight"
    /// <summary>
    /// A link from an interest to statistics about itself
    /// <see href="http://purl.org/ontology/wi/core#statistical_item"></see></summary>
    let statistical_item = _prefix "statistical_item"
    /// <summary>
    /// A topic of the weighted interest
    /// <see href="http://purl.org/ontology/wi/core#topic"></see></summary>
    let topic = _prefix "topic"
    /// <summary>
    /// The overall duration of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.
    /// <see href="http://purl.org/ontology/wi/core#ultimative_duration"></see></summary>
    let ultimative_duration = _prefix "ultimative_duration"
