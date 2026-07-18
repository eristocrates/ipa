namespace http.www.ontologydesignpatterns.org.cp.owl.participation.owl.hash

open DoxAletheia.Rdf_Vocabulary

module odpart =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/cp/owl/participation.owl#"

    /// <summary>
    /// Any physical, social, or mental process, event, or state.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// Any physical, social, or mental object, or substance
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#hasParticipant"></see>
    /// </summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#isParticipantIn"></see>
    /// </summary>
    let isParticipantIn =
        Namespaced_IRI.parse _namespace_name "isParticipantIn" |> NamespacedName
