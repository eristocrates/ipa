namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.RealEstateLoans.Mortgages.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_reln_mtg =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndMortgageLoan"></see>
    /// </summary>
    let ClosedEndMortgageLoan =
        Namespaced_IRI.parse _namespace_name "ClosedEndMortgageLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/LoanSecuredByRealEstate"></see>
    /// </summary>
    let LoanSecuredByRealEstate =
        Namespaced_IRI.parse _namespace_name "LoanSecuredByRealEstate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndReverseMortgage"></see>
    /// </summary>
    let ClosedEndReverseMortgage =
        Namespaced_IRI.parse _namespace_name "ClosedEndReverseMortgage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ReverseMortgageLoan"></see>
    /// </summary>
    let ReverseMortgageLoan =
        Namespaced_IRI.parse _namespace_name "ReverseMortgageLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/hasInitialFundingDate"></see>
    /// </summary>
    let hasInitialFundingDate =
        Namespaced_IRI.parse _namespace_name "hasInitialFundingDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/Mortgage"></see>
    /// </summary>
    let Mortgage = Namespaced_IRI.parse _namespace_name "Mortgage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndMortgageLoan"></see>
    /// </summary>
    let OpenEndMortgageLoan =
        Namespaced_IRI.parse _namespace_name "OpenEndMortgageLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndReverseMortgage"></see>
    /// </summary>
    let OpenEndReverseMortgage =
        Namespaced_IRI.parse _namespace_name "OpenEndReverseMortgage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/isARMConvertible"></see>
    /// </summary>
    let isARMConvertible =
        Namespaced_IRI.parse _namespace_name "isARMConvertible" |> NamespacedName
