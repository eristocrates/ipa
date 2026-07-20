namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.Agents.slash

open DoxAletheia

module fibo_fnd_aap_agt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/Agents/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/Agents/AutomatedSystem"></see>
    /// </summary>
    let AutomatedSystem = _prefix "AutomatedSystem"
