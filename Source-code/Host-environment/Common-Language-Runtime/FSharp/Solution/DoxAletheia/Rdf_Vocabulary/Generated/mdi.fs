namespace https.w3id.org.multidimensional_interface.ontology.hash

open DoxAletheia

module mdi =
    let _namespace_name = "https://w3id.org/multidimensional-interface/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Linked Data Fragment that has an interval as selector, which apply to dimensional resources at one of its n dimensions.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#RangeFragment"></see></summary>
    let RangeFragment = _prefix "RangeFragment"
    /// <summary>
    /// A Linked Data interface through which Range Fragments can be selected by interval. This interface selects all Range Fragments whose interval overlap with the Range Gate’s interval.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#RangeGate"></see></summary>
    let RangeGate = _prefix "RangeGate"
    /// <summary>
    /// The upper bound of an interval, excluding this value.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#final"></see></summary>
    let final = _prefix "final"
    /// <summary>
    /// A link to the Range Gate of a Multidimensional Index of a datasource.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#hasRangeGate"></see></summary>
    let hasRangeGate = _prefix "hasRangeGate"
    /// <summary>
    /// The lower bound of an interval, including this value.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#initial"></see></summary>
    let initial = _prefix "initial"
