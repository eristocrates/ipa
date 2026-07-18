namespace http.www.w3.org._2000._10.swap.list.hash

open DoxAletheia.Rdf_Vocabulary

module list =
    let _namespace_name = "http://www.w3.org/2000/10/swap/list#"
    /// <summary>
    ///
    /// Iff the subject is a list of lists and the concatenation of all those lists
    /// is the object, then this is true.
    /// eg  ( (1 2) (3 4) ) list:append (1 2 3 4).
    /// The object can be calculated as a function of the subject.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/list#append"></see></summary>
    let append = Namespaced_IRI.parse _namespace_name "append" |> NamespacedName
    /// <summary>
    ///
    /// Iff the object is a list and the subject is in that list, then this is true.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/list#in"></see></summary>
    let in_ = Namespaced_IRI.parse _namespace_name "in" |> NamespacedName
    /// <summary>
    ///
    /// Iff the suject is a list and the obbject is the last thing that list, then this is true.
    /// The object can be calculated as a function of the list.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/list#last"></see></summary>
    let last = Namespaced_IRI.parse _namespace_name "last" |> NamespacedName
    /// <summary>
    ///
    /// Iff the subject is a list and the obbject is in that list, then this is true.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/list#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
