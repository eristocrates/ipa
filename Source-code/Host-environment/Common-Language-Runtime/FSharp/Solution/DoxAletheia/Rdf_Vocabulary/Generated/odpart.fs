namespace http.www.ontologydesignpatterns.org.cp.owl.participation.owl.hash

open DoxAletheia

module odpart =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/cp/owl/participation.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Any physical, social, or mental process, event, or state.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Any physical, social, or mental object, or substance
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#hasParticipant"></see>
    /// </summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#isParticipantIn"></see>
    /// </summary>
    let isParticipantIn = _prefix "isParticipantIn"
