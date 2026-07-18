namespace http.www.ontologydesignpatterns.org.cp.owl.situation.owl.hash

open DoxAletheia.Rdf_Vocabulary

module situ =
    let _namespace_name = "http://www.ontologydesignpatterns.org/cp/owl/situation.owl#"
    /// <summary>
    /// A view on a set of entities. It can be seen as a 'relational context', reifying a relation.
    /// For example, a PlanExecution is a context including some actions executed by agents according to certain parameters and expected tasks to be achieved from a Plan; a DiagnosedSituation is a context of observed entities that is interpreted on the basis of a Diagnosis, etc.
    /// Situation is also able to represent reified n-ary relations, where isSettingFor is the top-level relation for all binary projections of the n-ary relation. If used in a transformation pattern for n-ary relations, the designer should take care of:
    /// - creating only one situation for each instance of an n-ary relation, otherwise the 'identification constraint' (Calvanese et al., IJCAI 2001) could be violated
    /// - adding an 'exact cardinality' restriction corresponding to the arity of the n-ary relation, otherwise the designer would actually represent a polymorphic relation.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#Situation"></see></summary>
    let Situation = Namespaced_IRI.parse _namespace_name "Situation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#isSettingFor"></see>
    /// </summary>
    let isSettingFor =
        Namespaced_IRI.parse _namespace_name "isSettingFor" |> NamespacedName

    /// <summary>
    /// A relation between entities and situations, e.g. 'this morning I've prepared my coffee with a new fantastic Arabica' (i.e.: (an amount of) a new fantastic Arabica hasSetting the preparation of my coffee this morning).
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/situation.owl#hasSetting"></see></summary>
    let hasSetting = Namespaced_IRI.parse _namespace_name "hasSetting" |> NamespacedName
