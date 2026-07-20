namespace https.spec.edmcouncil.org.fibo.ontology.FND.Relations.MetadataFNDRelations.slash

open DoxAletheia

module fibo_fnd_rel_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/RelationsModule"></see>
    /// </summary>
    let RelationsModule = _prefix "RelationsModule"
