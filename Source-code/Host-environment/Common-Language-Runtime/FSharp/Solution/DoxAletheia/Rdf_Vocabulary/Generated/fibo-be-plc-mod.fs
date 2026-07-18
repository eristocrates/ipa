namespace https.spec.edmcouncil.org.fibo.ontology.BE.PrivateLimitedCompanies.MetadataBEPrivateLimitedCompanies.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_plc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/PrivateLimitedCompaniesModule"></see>
    /// </summary>
    let PrivateLimitedCompaniesModule =
        Namespaced_IRI.parse _namespace_name "PrivateLimitedCompaniesModule" |> NamespacedName
