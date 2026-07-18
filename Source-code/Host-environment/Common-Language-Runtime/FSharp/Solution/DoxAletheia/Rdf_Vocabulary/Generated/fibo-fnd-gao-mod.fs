namespace https.spec.edmcouncil.org.fibo.ontology.FND.GoalsAndObjectives.MetadataFNDGoalsAndObjectives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_gao_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/MetadataFNDGoalsAndObjectives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/MetadataFNDGoalsAndObjectives/GoalsAndObjectivesModule"></see>
    /// </summary>
    let GoalsAndObjectivesModule =
        Namespaced_IRI.parse _namespace_name "GoalsAndObjectivesModule" |> NamespacedName
