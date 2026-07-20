namespace http.www.w3.org._2004._03.trix.rdfg_1.slash

open DoxAletheia

module trig =
    let _namespace_name = "http://www.w3.org/2004/03/trix/rdfg-1/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    /// An RDF graph (with intensional semantics).
    ///
    /// <see href="http://www.w3.org/2004/03/trix/rdfg-1/Graph"></see></summary>
    let Graph = _prefix "Graph"
    /// <summary>
    ///
    /// The graphs associated with the subject and object are equivalent.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/rdfg-1/equivalentGraph"></see></summary>
    let equivalentGraph = _prefix "equivalentGraph"
    /// <summary>
    ///
    /// The graph associated with the subject is a subgraph of a graph equivalent
    /// to that associated with the object.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/rdfg-1/subGraphOf"></see></summary>
    let subGraphOf = _prefix "subGraphOf"
