namespace https.spec.edmcouncil.org.fibo.ontology.BE.Partnerships.MetadataBEPartnerships.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_ptr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/PartnershipsModule"></see>
    /// </summary>
    let PartnershipsModule =
        Namespaced_IRI.parse _namespace_name "PartnershipsModule" |> NamespacedName
