namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.MetadataFNDUtilities.slash

open DoxAletheia

module fibo_fnd_utl_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/UtilitiesModule"></see>
    /// </summary>
    let UtilitiesModule = _prefix "UtilitiesModule"
