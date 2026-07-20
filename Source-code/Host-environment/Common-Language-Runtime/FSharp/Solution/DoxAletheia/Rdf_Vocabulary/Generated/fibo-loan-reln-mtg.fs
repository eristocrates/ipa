namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.RealEstateLoans.Mortgages.slash

open DoxAletheia

module fibo_loan_reln_mtg =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndMortgageLoan"></see>
    /// </summary>
    let ClosedEndMortgageLoan = _prefix "ClosedEndMortgageLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/LoanSecuredByRealEstate"></see>
    /// </summary>
    let LoanSecuredByRealEstate = _prefix "LoanSecuredByRealEstate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndReverseMortgage"></see>
    /// </summary>
    let ClosedEndReverseMortgage = _prefix "ClosedEndReverseMortgage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ReverseMortgageLoan"></see>
    /// </summary>
    let ReverseMortgageLoan = _prefix "ReverseMortgageLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/hasInitialFundingDate"></see>
    /// </summary>
    let hasInitialFundingDate = _prefix "hasInitialFundingDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/Mortgage"></see>
    /// </summary>
    let Mortgage = _prefix "Mortgage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndMortgageLoan"></see>
    /// </summary>
    let OpenEndMortgageLoan = _prefix "OpenEndMortgageLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndReverseMortgage"></see>
    /// </summary>
    let OpenEndReverseMortgage = _prefix "OpenEndReverseMortgage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/isARMConvertible"></see>
    /// </summary>
    let isARMConvertible = _prefix "isARMConvertible"
