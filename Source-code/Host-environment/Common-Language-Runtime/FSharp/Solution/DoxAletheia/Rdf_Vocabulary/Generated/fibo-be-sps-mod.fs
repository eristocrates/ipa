namespace https.spec.edmcouncil.org.fibo.ontology.BE.SoleProprietorships.MetadataBESoleProprietorships.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_sps_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/SoleProprietorshipsModule"></see>
    /// </summary>
    let SoleProprietorshipsModule =
        Namespaced_IRI.parse _namespace_name "SoleProprietorshipsModule" |> NamespacedName
