namespace https.spec.edmcouncil.org.fibo.ontology.BE.SoleProprietorships.SoleProprietorships.slash

open DoxAletheia

module fibo_be_sps_sps =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietor"></see>
    /// </summary>
    let SoleProprietor = _prefix "SoleProprietor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietorship"></see>
    /// </summary>
    let SoleProprietorship = _prefix "SoleProprietorship"
