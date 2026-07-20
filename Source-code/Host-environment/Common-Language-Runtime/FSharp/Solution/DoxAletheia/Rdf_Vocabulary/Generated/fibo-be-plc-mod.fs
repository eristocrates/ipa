namespace https.spec.edmcouncil.org.fibo.ontology.BE.PrivateLimitedCompanies.MetadataBEPrivateLimitedCompanies.slash

open DoxAletheia

module fibo_be_plc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/PrivateLimitedCompaniesModule"></see>
    /// </summary>
    let PrivateLimitedCompaniesModule = _prefix "PrivateLimitedCompaniesModule"
