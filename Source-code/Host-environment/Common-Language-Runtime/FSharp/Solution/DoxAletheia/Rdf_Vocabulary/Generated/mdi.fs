namespace https.w3id.org.multidimensional_interface.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module mdi =
    let _namespace_name = "https://w3id.org/multidimensional-interface/ontology#"

    /// <summary>
    /// A Linked Data Fragment that has an interval as selector, which apply to dimensional resources at one of its n dimensions.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#RangeFragment"></see></summary>
    let RangeFragment =
        Namespaced_IRI.parse _namespace_name "RangeFragment" |> NamespacedName

    /// <summary>
    /// A Linked Data interface through which Range Fragments can be selected by interval. This interface selects all Range Fragments whose interval overlap with the Range Gate’s interval.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#RangeGate"></see></summary>
    let RangeGate = Namespaced_IRI.parse _namespace_name "RangeGate" |> NamespacedName
    /// <summary>
    /// The upper bound of an interval, excluding this value.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#final"></see></summary>
    let final = Namespaced_IRI.parse _namespace_name "final" |> NamespacedName

    /// <summary>
    /// A link to the Range Gate of a Multidimensional Index of a datasource.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#hasRangeGate"></see></summary>
    let hasRangeGate =
        Namespaced_IRI.parse _namespace_name "hasRangeGate" |> NamespacedName

    /// <summary>
    /// The lower bound of an interval, including this value.
    /// <see href="https://w3id.org/multidimensional-interface/ontology#initial"></see></summary>
    let initial = Namespaced_IRI.parse _namespace_name "initial" |> NamespacedName
