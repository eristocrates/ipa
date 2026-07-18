namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansGeneral.Loans.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_ln_ln =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasFirstRateChangeTerm"></see>
    /// </summary>
    let hasFirstRateChangeTerm =
        Namespaced_IRI.parse _namespace_name "hasFirstRateChangeTerm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasBalloonPayment"></see>
    /// </summary>
    let hasBalloonPayment =
        Namespaced_IRI.parse _namespace_name "hasBalloonPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInitiallyPayable"></see>
    /// </summary>
    let isInitiallyPayable =
        Namespaced_IRI.parse _namespace_name "isInitiallyPayable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LenderLienPosition"></see>
    /// </summary>
    let LenderLienPosition =
        Namespaced_IRI.parse _namespace_name "LenderLienPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OwnershipInterest"></see>
    /// </summary>
    let OwnershipInterest =
        Namespaced_IRI.parse _namespace_name "OwnershipInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/ClosedEndCredit"></see>
    /// </summary>
    let ClosedEndCredit =
        Namespaced_IRI.parse _namespace_name "ClosedEndCredit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CollateralizedLoan"></see>
    /// </summary>
    let CollateralizedLoan =
        Namespaced_IRI.parse _namespace_name "CollateralizedLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SecuredLoan"></see>
    /// </summary>
    let SecuredLoan =
        Namespaced_IRI.parse _namespace_name "SecuredLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Comaker"></see>
    /// </summary>
    let Comaker = Namespaced_IRI.parse _namespace_name "Comaker" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CombinedLoanToValueRatio"></see>
    /// </summary>
    let CombinedLoanToValueRatio =
        Namespaced_IRI.parse _namespace_name "CombinedLoanToValueRatio" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/TotalOutstandingPrincipal"></see>
    /// </summary>
    let TotalOutstandingPrincipal =
        Namespaced_IRI.parse _namespace_name "TotalOutstandingPrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FeeSimpleOwnershipInterest"></see>
    /// </summary>
    let FeeSimpleOwnershipInterest =
        Namespaced_IRI.parse _namespace_name "FeeSimpleOwnershipInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FractionalOwnershipInterest"></see>
    /// </summary>
    let FractionalOwnershipInterest =
        Namespaced_IRI.parse _namespace_name "FractionalOwnershipInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/GuaranteedLoan"></see>
    /// </summary>
    let GuaranteedLoan =
        Namespaced_IRI.parse _namespace_name "GuaranteedLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/IndividualPaymentTransaction"></see>
    /// </summary>
    let IndividualPaymentTransaction =
        Namespaced_IRI.parse _namespace_name "IndividualPaymentTransaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Loan"></see>
    /// </summary>
    let Loan = Namespaced_IRI.parse _namespace_name "Loan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalClosingCosts"></see>
    /// </summary>
    let hasTotalClosingCosts =
        Namespaced_IRI.parse _namespace_name "hasTotalClosingCosts" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalPointsAndFees"></see>
    /// </summary>
    let hasTotalPointsAndFees =
        Namespaced_IRI.parse _namespace_name "hasTotalPointsAndFees" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanSpecificCustomerAccount"></see>
    /// </summary>
    let LoanSpecificCustomerAccount =
        Namespaced_IRI.parse _namespace_name "LoanSpecificCustomerAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isServicedBy"></see>
    /// </summary>
    let isServicedBy =
        Namespaced_IRI.parse _namespace_name "isServicedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Servicer"></see>
    /// </summary>
    let Servicer = Namespaced_IRI.parse _namespace_name "Servicer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasNegativeAmortization"></see>
    /// </summary>
    let hasNegativeAmortization =
        Namespaced_IRI.parse _namespace_name "hasNegativeAmortization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInterestOnly"></see>
    /// </summary>
    let isInterestOnly =
        Namespaced_IRI.parse _namespace_name "isInterestOnly" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrincipalAmount"></see>
    /// </summary>
    let hasPrincipalAmount =
        Namespaced_IRI.parse _namespace_name "hasPrincipalAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanPaymentSchedule"></see>
    /// </summary>
    let LoanPaymentSchedule =
        Namespaced_IRI.parse _namespace_name "LoanPaymentSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasLoanBalance"></see>
    /// </summary>
    let hasLoanBalance =
        Namespaced_IRI.parse _namespace_name "hasLoanBalance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPaymentHistory"></see>
    /// </summary>
    let hasPaymentHistory =
        Namespaced_IRI.parse _namespace_name "hasPaymentHistory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PaymentHistory"></see>
    /// </summary>
    let PaymentHistory =
        Namespaced_IRI.parse _namespace_name "PaymentHistory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanToValueRatio"></see>
    /// </summary>
    let LoanToValueRatio =
        Namespaced_IRI.parse _namespace_name "LoanToValueRatio" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OpenEndCredit"></see>
    /// </summary>
    let OpenEndCredit =
        Namespaced_IRI.parse _namespace_name "OpenEndCredit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasIndividualPayment"></see>
    /// </summary>
    let hasIndividualPayment =
        Namespaced_IRI.parse _namespace_name "hasIndividualPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrepaymentTerms"></see>
    /// </summary>
    let PrepaymentTerms =
        Namespaced_IRI.parse _namespace_name "PrepaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrePaymentPenaltyTerm"></see>
    /// </summary>
    let hasPrePaymentPenaltyTerm =
        Namespaced_IRI.parse _namespace_name "hasPrePaymentPenaltyTerm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrimaryLienPosition"></see>
    /// </summary>
    let PrimaryLienPosition =
        Namespaced_IRI.parse _namespace_name "PrimaryLienPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SubordinateLienPosition"></see>
    /// </summary>
    let SubordinateLienPosition =
        Namespaced_IRI.parse _namespace_name "SubordinateLienPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/UnsecuredLoan"></see>
    /// </summary>
    let UnsecuredLoan =
        Namespaced_IRI.parse _namespace_name "UnsecuredLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasCost"></see>
    /// </summary>
    let hasCost = Namespaced_IRI.parse _namespace_name "hasCost" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasScheduledUnpaidBalance"></see>
    /// </summary>
    let hasScheduledUnpaidBalance =
        Namespaced_IRI.parse _namespace_name "hasScheduledUnpaidBalance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isAssumable"></see>
    /// </summary>
    let isAssumable =
        Namespaced_IRI.parse _namespace_name "isAssumable" |> NamespacedName
