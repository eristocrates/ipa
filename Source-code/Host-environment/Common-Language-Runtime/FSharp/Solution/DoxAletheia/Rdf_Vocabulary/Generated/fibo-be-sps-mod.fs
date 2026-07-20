namespace https.spec.edmcouncil.org.fibo.ontology.BE.SoleProprietorships.MetadataBESoleProprietorships.slash

open DoxAletheia

module fibo_be_sps_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/SoleProprietorshipsModule"></see>
    /// </summary>
    let SoleProprietorshipsModule = _prefix "SoleProprietorshipsModule"
