namespace http.www.w3.org._2000._10.swap.set.hash

open DoxAletheia.Rdf_Vocabulary

module set =
    let _namespace_name = "http://www.w3.org/2000/10/swap/set#"
    /// <summary>
    /// The subject is a list of sets,
    ///     and the objet is the difference of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#difference"></see></summary>
    let difference = Namespaced_IRI.parse _namespace_name "difference" |> NamespacedName
    /// <summary>
    /// This set contains that as a member.
    ///     Cwm will bind the subject to each of the members of the object.
    /// <see href="http://www.w3.org/2000/10/swap/set#in"></see></summary>
    let in_ = Namespaced_IRI.parse _namespace_name "in" |> NamespacedName

    /// <summary>
    /// The subject is a list of sets,
    ///     and the objet is the intersection of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#intersection"></see></summary>
    let intersection =
        Namespaced_IRI.parse _namespace_name "intersection" |> NamespacedName

    /// <summary>
    /// This is a member of that set.
    ///     Cwm will bind the object to each of the members of the suject.
    /// <see href="http://www.w3.org/2000/10/swap/set#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// The subject is a list of sets,
    ///     and the objet is the symmetricDifference of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#symmetricDifference"></see></summary>
    let symmetricDifference =
        Namespaced_IRI.parse _namespace_name "symmetricDifference" |> NamespacedName

    /// <summary>
    /// The subject is a list [sic] of sets,
    ///     and the objet is the union of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#union"></see></summary>
    let union = Namespaced_IRI.parse _namespace_name "union" |> NamespacedName
