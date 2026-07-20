namespace http.ns.bergnet.org.tac._0._1.triple_access_control.hash

open DoxAletheia

module tac =
    let _namespace_name = "http://ns.bergnet.org/tac/0.1/triple-access-control#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#Filter"></see></summary>
    let Filter = _prefix "Filter"
    /// <summary>
    /// A triple authorization.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#TripleAuthorization"></see></summary>
    let TripleAuthorization = _prefix "TripleAuthorization"
    /// <summary>
    /// Contains triple authorization information.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#accessToTriple"></see></summary>
    let accessToTriple = _prefix "accessToTriple"
    /// <summary>
    /// Contains sub triple authorization informations.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#children"></see></summary>
    let children = _prefix "children"
    /// <summary>
    ///   <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#Authorization"></see>
    /// </summary>
    let Authorization = _prefix "Authorization"
    /// <summary>
    /// Contains triple filter rules.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#filter"></see></summary>
    let filter = _prefix "filter"
    /// <summary>
    /// Graph for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#graph"></see></summary>
    let graph = _prefix "graph"
    /// <summary>
    /// Access mode is defined per triple authorization.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#mode"></see></summary>
    let mode = _prefix "mode"
    /// <summary>
    /// Object for a triple filter
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// Predicate for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// If this property is true access to the parent triple is only granted if childrens are found.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#required"></see></summary>
    let required = _prefix "required"
    /// <summary>
    /// Statement for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#statement"></see></summary>
    let statement = _prefix "statement"
    /// <summary>
    /// Subject for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#subject"></see></summary>
    let subject = _prefix "subject"
