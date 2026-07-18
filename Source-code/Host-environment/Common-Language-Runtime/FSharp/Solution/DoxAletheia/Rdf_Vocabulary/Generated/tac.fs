namespace http.ns.bergnet.org.tac._0._1.triple_access_control.hash

open DoxAletheia.Rdf_Vocabulary

module tac =
    let _namespace_name = "http://ns.bergnet.org/tac/0.1/triple-access-control#"
    /// <summary>
    /// A triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#Filter"></see></summary>
    let Filter = Namespaced_IRI.parse _namespace_name "Filter" |> NamespacedName

    /// <summary>
    /// A triple authorization.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#TripleAuthorization"></see></summary>
    let TripleAuthorization =
        Namespaced_IRI.parse _namespace_name "TripleAuthorization" |> NamespacedName

    /// <summary>
    /// Contains triple authorization information.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#accessToTriple"></see></summary>
    let accessToTriple =
        Namespaced_IRI.parse _namespace_name "accessToTriple" |> NamespacedName

    /// <summary>
    /// Contains sub triple authorization informations.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#children"></see></summary>
    let children = Namespaced_IRI.parse _namespace_name "children" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#Authorization"></see>
    /// </summary>
    let Authorization =
        Namespaced_IRI.parse _namespace_name "Authorization" |> NamespacedName

    /// <summary>
    /// Contains triple filter rules.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#filter"></see></summary>
    let filter = Namespaced_IRI.parse _namespace_name "filter" |> NamespacedName
    /// <summary>
    /// Graph for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#graph"></see></summary>
    let graph = Namespaced_IRI.parse _namespace_name "graph" |> NamespacedName
    /// <summary>
    /// Access mode is defined per triple authorization.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#mode"></see></summary>
    let mode = Namespaced_IRI.parse _namespace_name "mode" |> NamespacedName
    /// <summary>
    /// Object for a triple filter
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// Predicate for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    /// If this property is true access to the parent triple is only granted if childrens are found.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#required"></see></summary>
    let required = Namespaced_IRI.parse _namespace_name "required" |> NamespacedName
    /// <summary>
    /// Statement for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#statement"></see></summary>
    let statement = Namespaced_IRI.parse _namespace_name "statement" |> NamespacedName
    /// <summary>
    /// Subject for a triple filter.
    /// <see href="http://ns.bergnet.org/tac/0.1/triple-access-control#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
