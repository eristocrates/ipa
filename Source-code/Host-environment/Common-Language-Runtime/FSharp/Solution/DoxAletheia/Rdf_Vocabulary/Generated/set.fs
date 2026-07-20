namespace http.www.w3.org._2000._10.swap.set.hash

open DoxAletheia

module set =
    let _namespace_name = "http://www.w3.org/2000/10/swap/set#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The subject is a list of sets,
    ///     and the objet is the difference of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#difference"></see></summary>
    let difference = _prefix "difference"
    /// <summary>
    /// This set contains that as a member.
    ///     Cwm will bind the subject to each of the members of the object.
    /// <see href="http://www.w3.org/2000/10/swap/set#in"></see></summary>
    let in_ = _prefix "in"
    /// <summary>
    /// The subject is a list of sets,
    ///     and the objet is the intersection of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#intersection"></see></summary>
    let intersection = _prefix "intersection"
    /// <summary>
    /// This is a member of that set.
    ///     Cwm will bind the object to each of the members of the suject.
    /// <see href="http://www.w3.org/2000/10/swap/set#member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// The subject is a list of sets,
    ///     and the objet is the symmetricDifference of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#symmetricDifference"></see></summary>
    let symmetricDifference = _prefix "symmetricDifference"
    /// <summary>
    /// The subject is a list [sic] of sets,
    ///     and the objet is the union of the sets in the object
    /// <see href="http://www.w3.org/2000/10/swap/set#union"></see></summary>
    let union = _prefix "union"
