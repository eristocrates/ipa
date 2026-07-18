namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.MetadataFNDUtilities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_utl_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/UtilitiesModule"></see>
    /// </summary>
    let UtilitiesModule =
        Namespaced_IRI.parse _namespace_name "UtilitiesModule" |> NamespacedName
