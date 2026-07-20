namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.MetadataFNDAgentsAndPeople.slash

open DoxAletheia

module fibo_fnd_aap_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/AgentsAndPeopleModule"></see>
    /// </summary>
    let AgentsAndPeopleModule = _prefix "AgentsAndPeopleModule"
