namespace http.www.ontologydesignpatterns.org.cp.owl.timeindexedsituation.owl.bare

open DoxAletheia

module tis =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Situation that is explicitly indexed at some time for at least one entity.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#TimeIndexedSituation"></see></summary>
    let ``_#TimeIndexedSituation`` = _prefix "#TimeIndexedSituation"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#atTime"></see>
    /// </summary>
    let ``_#atTime`` = _prefix "#atTime"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#forEntity"></see>
    /// </summary>
    let ``_#forEntity`` = _prefix "#forEntity"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#hasTimeIndexedSetting"></see>
    /// </summary>
    let ``_#hasTimeIndexedSetting`` = _prefix "#hasTimeIndexedSetting"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#isTimeIndexFor"></see>
    /// </summary>
    let ``_#isTimeIndexFor`` = _prefix "#isTimeIndexFor"
