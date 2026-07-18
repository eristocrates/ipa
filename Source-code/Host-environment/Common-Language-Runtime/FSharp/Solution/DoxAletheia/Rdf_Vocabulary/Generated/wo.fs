namespace http.purl.org.ontology.wo.core.hash

open DoxAletheia.Rdf_Vocabulary

module wo =
    let _namespace_name = "http://purl.org/ontology/wo/core#"
    /// <summary>
    /// A concept for describing scales for weights.
    /// <see href="http://purl.org/ontology/wo/core#Scale"></see></summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName
    /// <summary>
    /// A weight class to enable timestamped (etc.) weights.
    /// <see href="http://purl.org/ontology/wo/core#Weight"></see></summary>
    let Weight = Namespaced_IRI.parse _namespace_name "Weight" |> NamespacedName

    /// <summary>
    /// The specific value of a weight.
    /// <see href="http://purl.org/ontology/wo/core#weight_value"></see></summary>
    let weight_value =
        Namespaced_IRI.parse _namespace_name "weight_value" |> NamespacedName

    /// <summary>
    /// A maximum weight of a scale.
    /// <see href="http://purl.org/ontology/wo/core#max_weight"></see></summary>
    let max_weight = Namespaced_IRI.parse _namespace_name "max_weight" |> NamespacedName
    /// <summary>
    /// A minimum weight of a scale.
    /// <see href="http://purl.org/ontology/wo/core#min_weight"></see></summary>
    let min_weight = Namespaced_IRI.parse _namespace_name "min_weight" |> NamespacedName
    /// <summary>
    /// A scale for the weighting of some relation.
    /// <see href="http://purl.org/ontology/wo/core#scale"></see></summary>
    let scale = Namespaced_IRI.parse _namespace_name "scale" |> NamespacedName
    /// <summary>
    /// A predefined step size for weight of a specific scale.
    /// <see href="http://purl.org/ontology/wo/core#step_size"></see></summary>
    let step_size = Namespaced_IRI.parse _namespace_name "step_size" |> NamespacedName
    /// <summary>
    /// The weight on some relation, e.g. a interest in a topic, or of an interest that is valid for a specific period of time or was raised up in a specific period of time.
    /// <see href="http://purl.org/ontology/wo/core#weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName
