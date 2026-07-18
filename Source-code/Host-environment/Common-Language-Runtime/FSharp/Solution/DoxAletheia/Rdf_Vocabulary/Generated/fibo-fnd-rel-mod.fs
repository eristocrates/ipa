namespace https.spec.edmcouncil.org.fibo.ontology.FND.Relations.MetadataFNDRelations.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_rel_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/RelationsModule"></see>
    /// </summary>
    let RelationsModule =
        Namespaced_IRI.parse _namespace_name "RelationsModule" |> NamespacedName
