namespace http.www.ontologydesignpatterns.org.cp.owl.sequence.owl.hash

open DoxAletheia

module seq =
    let _namespace_name = "http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The intransitive follows relation. For example, Wednesday directly precedes Thursday. Directness of precedence depends on the designer conceptualization.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyFollows"></see></summary>
    let directlyFollows = _prefix "directlyFollows"
    /// <summary>
    /// A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 2000 follows 1999', 'preparing coffee' follows 'deciding what coffee to use', 'II World War follows I World War', etc.
    /// It can be used between tasks, processes or time intervals, and subproperties would fit best in order to distinguish the different uses.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// The intransitive precedes relation. For example, Monday directly precedes Tuesday. Directness of precedence depends on the designer conceptualization.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyPrecedes"></see></summary>
    let directlyPrecedes = _prefix "directlyPrecedes"
    /// <summary>
    /// A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 1999 precedes 2000', 'deciding what coffee to use' precedes 'preparing coffee', 'World War II follows World War I', 'in the Milan to Rome autoroute, Bologna precedes Florence', etc.
    /// It can then be used between tasks, processes, time intervals, spatially locate objects, situations, etc.
    /// Subproperties can be defined in order to distinguish the different uses.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#precedes"></see></summary>
    let precedes = _prefix "precedes"
