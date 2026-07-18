namespace https.spec.edmcouncil.org.fibo.ontology.BE.SoleProprietorships.SoleProprietorships.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_sps_sps =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietor"></see>
    /// </summary>
    let SoleProprietor =
        Namespaced_IRI.parse _namespace_name "SoleProprietor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietorship"></see>
    /// </summary>
    let SoleProprietorship =
        Namespaced_IRI.parse _namespace_name "SoleProprietorship" |> NamespacedName
