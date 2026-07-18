namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.MetadataFNDAgentsAndPeople.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_aap_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/AgentsAndPeopleModule"></see>
    /// </summary>
    let AgentsAndPeopleModule =
        Namespaced_IRI.parse _namespace_name "AgentsAndPeopleModule" |> NamespacedName
