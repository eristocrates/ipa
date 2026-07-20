namespace https.spec.edmcouncil.org.fibo.ontology.BE.MetadataBE.slash

open DoxAletheia

module fibo_be_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/BEDomain"></see>
    /// </summary>
    let BEDomain = _prefix "BEDomain"
