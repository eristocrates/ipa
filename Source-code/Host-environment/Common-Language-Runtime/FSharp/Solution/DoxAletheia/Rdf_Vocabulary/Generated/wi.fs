namespace http.purl.org.ontology.wi.core.hash

open DoxAletheia.Rdf_Vocabulary

module wi =
    let _namespace_name = "http://purl.org/ontology/wi/core#"

    /// <summary>
    ///   <see href="http://purl.org/ontology/wi/core#ExplicitMining"></see>
    /// </summary>
    let ExplicitMining =
        Namespaced_IRI.parse _namespace_name "ExplicitMining" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/wi/core#ImplicitMining"></see>
    /// </summary>
    let ImplicitMining =
        Namespaced_IRI.parse _namespace_name "ImplicitMining" |> NamespacedName

    /// <summary>
    /// An event concept for describing dynamics of interests, e.g. weight changes, periods of interest.
    /// <see href="http://purl.org/ontology/wi/core#InterestDynamics"></see></summary>
    let InterestDynamics =
        Namespaced_IRI.parse _namespace_name "InterestDynamics" |> NamespacedName

    /// <summary>
    /// A weighted interest object, which also can have interest dynamics etc.
    /// <see href="http://purl.org/ontology/wi/core#WeightedInterest"></see></summary>
    let WeightedInterest =
        Namespaced_IRI.parse _namespace_name "WeightedInterest" |> NamespacedName

    /// <summary>
    /// A link from a mined interest to the related person
    /// <see href="http://purl.org/ontology/wi/core#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName
    /// <summary>
    /// A link between an agent and a weighted interest
    /// <see href="http://purl.org/ontology/wi/core#preference"></see></summary>
    let preference = Namespaced_IRI.parse _namespace_name "preference" |> NamespacedName

    /// <summary>
    /// The time when the interest appears in a certain kind of scenario.
    /// <see href="http://purl.org/ontology/wi/core#appear_time"></see></summary>
    let appear_time =
        Namespaced_IRI.parse _namespace_name "appear_time" |> NamespacedName

    /// <summary>
    /// An interval of attention for an interest.
    /// <see href="http://purl.org/ontology/wi/core#attention_duration"></see></summary>
    let attention_duration =
        Namespaced_IRI.parse _namespace_name "attention_duration" |> NamespacedName

    /// <summary>
    /// A link between a context and evidence supporting the interpretation of preferences in a context
    /// <see href="http://purl.org/ontology/wi/core#evidence"></see></summary>
    let evidence = Namespaced_IRI.parse _namespace_name "evidence" |> NamespacedName

    /// <summary>
    /// To relate a weighted interest to its temporal dynamics.
    /// <see href="http://purl.org/ontology/wi/core#interest_dynamics"></see></summary>
    let interest_dynamics =
        Namespaced_IRI.parse _namespace_name "interest_dynamics" |> NamespacedName

    /// <summary>
    /// The longest continuous interval of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.
    /// <see href="http://purl.org/ontology/wi/core#longest_duration"></see></summary>
    let longest_duration =
        Namespaced_IRI.parse _namespace_name "longest_duration" |> NamespacedName

    /// <summary>
    /// A link between an agent and a topic of no interest to them
    /// <see href="http://purl.org/ontology/wi/core#not_interested_in"></see></summary>
    let not_interested_in =
        Namespaced_IRI.parse _namespace_name "not_interested_in" |> NamespacedName

    /// <summary>
    /// This weight reflects the overall interest in a topic and should be different from the actual weight of interest.
    /// <see href="http://purl.org/ontology/wi/core#overall_weight"></see></summary>
    let overall_weight =
        Namespaced_IRI.parse _namespace_name "overall_weight" |> NamespacedName

    /// <summary>
    /// A link from an interest to statistics about itself
    /// <see href="http://purl.org/ontology/wi/core#statistical_item"></see></summary>
    let statistical_item =
        Namespaced_IRI.parse _namespace_name "statistical_item" |> NamespacedName

    /// <summary>
    /// A topic of the weighted interest
    /// <see href="http://purl.org/ontology/wi/core#topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName

    /// <summary>
    /// The overall duration of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.
    /// <see href="http://purl.org/ontology/wi/core#ultimative_duration"></see></summary>
    let ultimative_duration =
        Namespaced_IRI.parse _namespace_name "ultimative_duration" |> NamespacedName
