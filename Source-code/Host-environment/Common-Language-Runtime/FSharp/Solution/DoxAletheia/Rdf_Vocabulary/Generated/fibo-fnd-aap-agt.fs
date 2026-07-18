namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.Agents.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_aap_agt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/Agents/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/Agents/AutomatedSystem"></see>
    /// </summary>
    let AutomatedSystem =
        Namespaced_IRI.parse _namespace_name "AutomatedSystem" |> NamespacedName
