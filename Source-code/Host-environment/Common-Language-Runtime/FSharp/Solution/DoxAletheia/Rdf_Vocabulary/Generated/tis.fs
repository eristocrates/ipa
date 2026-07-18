namespace http.www.ontologydesignpatterns.org.cp.owl.timeindexedsituation.owl.bare

open DoxAletheia.Rdf_Vocabulary

module tis =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl"

    /// <summary>
    /// A Situation that is explicitly indexed at some time for at least one entity.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#TimeIndexedSituation"></see></summary>
    let ``_#TimeIndexedSituation`` =
        Namespaced_IRI.parse _namespace_name "#TimeIndexedSituation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#atTime"></see>
    /// </summary>
    let ``_#atTime`` = Namespaced_IRI.parse _namespace_name "#atTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#forEntity"></see>
    /// </summary>
    let ``_#forEntity`` =
        Namespaced_IRI.parse _namespace_name "#forEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#hasTimeIndexedSetting"></see>
    /// </summary>
    let ``_#hasTimeIndexedSetting`` =
        Namespaced_IRI.parse _namespace_name "#hasTimeIndexedSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#isTimeIndexFor"></see>
    /// </summary>
    let ``_#isTimeIndexFor`` =
        Namespaced_IRI.parse _namespace_name "#isTimeIndexFor" |> NamespacedName
