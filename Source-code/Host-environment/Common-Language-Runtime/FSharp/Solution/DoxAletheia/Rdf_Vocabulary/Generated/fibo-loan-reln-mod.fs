namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.RealEstateLoans.MetadataLOANRealEstateLoans.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_reln_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/RealEstateLoansModule"></see>
    /// </summary>
    let RealEstateLoansModule =
        Namespaced_IRI.parse _namespace_name "RealEstateLoansModule" |> NamespacedName
