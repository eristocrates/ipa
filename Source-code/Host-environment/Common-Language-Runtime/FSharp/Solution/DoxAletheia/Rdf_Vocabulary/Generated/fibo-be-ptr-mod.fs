namespace https.spec.edmcouncil.org.fibo.ontology.BE.Partnerships.MetadataBEPartnerships.slash

open DoxAletheia

module fibo_be_ptr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/PartnershipsModule"></see>
    /// </summary>
    let PartnershipsModule = _prefix "PartnershipsModule"
