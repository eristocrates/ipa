namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.RealEstateLoans.MetadataLOANRealEstateLoans.slash

open DoxAletheia

module fibo_loan_reln_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/RealEstateLoansModule"></see>
    /// </summary>
    let RealEstateLoansModule = _prefix "RealEstateLoansModule"
