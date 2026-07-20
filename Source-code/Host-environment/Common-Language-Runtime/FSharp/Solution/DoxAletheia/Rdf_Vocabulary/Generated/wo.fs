namespace http.purl.org.ontology.wo.core.hash

open DoxAletheia

module wo =
    let _namespace_name = "http://purl.org/ontology/wo/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A concept for describing scales for weights.
    /// <see href="http://purl.org/ontology/wo/core#Scale"></see></summary>
    let Scale = _prefix "Scale"
    /// <summary>
    /// A weight class to enable timestamped (etc.) weights.
    /// <see href="http://purl.org/ontology/wo/core#Weight"></see></summary>
    let Weight = _prefix "Weight"
    /// <summary>
    /// The specific value of a weight.
    /// <see href="http://purl.org/ontology/wo/core#weight_value"></see></summary>
    let weight_value = _prefix "weight_value"
    /// <summary>
    /// A maximum weight of a scale.
    /// <see href="http://purl.org/ontology/wo/core#max_weight"></see></summary>
    let max_weight = _prefix "max_weight"
    /// <summary>
    /// A minimum weight of a scale.
    /// <see href="http://purl.org/ontology/wo/core#min_weight"></see></summary>
    let min_weight = _prefix "min_weight"
    /// <summary>
    /// A scale for the weighting of some relation.
    /// <see href="http://purl.org/ontology/wo/core#scale"></see></summary>
    let scale = _prefix "scale"
    /// <summary>
    /// A predefined step size for weight of a specific scale.
    /// <see href="http://purl.org/ontology/wo/core#step_size"></see></summary>
    let step_size = _prefix "step_size"
    /// <summary>
    /// The weight on some relation, e.g. a interest in a topic, or of an interest that is valid for a specific period of time or was raised up in a specific period of time.
    /// <see href="http://purl.org/ontology/wo/core#weight"></see></summary>
    let weight = _prefix "weight"
