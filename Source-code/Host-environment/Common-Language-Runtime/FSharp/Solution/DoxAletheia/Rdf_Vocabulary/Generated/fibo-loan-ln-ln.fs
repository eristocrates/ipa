namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansGeneral.Loans.slash

open DoxAletheia

module fibo_loan_ln_ln =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasFirstRateChangeTerm"></see>
    /// </summary>
    let hasFirstRateChangeTerm = _prefix "hasFirstRateChangeTerm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasBalloonPayment"></see>
    /// </summary>
    let hasBalloonPayment = _prefix "hasBalloonPayment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInitiallyPayable"></see>
    /// </summary>
    let isInitiallyPayable = _prefix "isInitiallyPayable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LenderLienPosition"></see>
    /// </summary>
    let LenderLienPosition = _prefix "LenderLienPosition"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OwnershipInterest"></see>
    /// </summary>
    let OwnershipInterest = _prefix "OwnershipInterest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/ClosedEndCredit"></see>
    /// </summary>
    let ClosedEndCredit = _prefix "ClosedEndCredit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CollateralizedLoan"></see>
    /// </summary>
    let CollateralizedLoan = _prefix "CollateralizedLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SecuredLoan"></see>
    /// </summary>
    let SecuredLoan = _prefix "SecuredLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Comaker"></see>
    /// </summary>
    let Comaker = _prefix "Comaker"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CombinedLoanToValueRatio"></see>
    /// </summary>
    let CombinedLoanToValueRatio = _prefix "CombinedLoanToValueRatio"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/TotalOutstandingPrincipal"></see>
    /// </summary>
    let TotalOutstandingPrincipal = _prefix "TotalOutstandingPrincipal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FeeSimpleOwnershipInterest"></see>
    /// </summary>
    let FeeSimpleOwnershipInterest = _prefix "FeeSimpleOwnershipInterest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FractionalOwnershipInterest"></see>
    /// </summary>
    let FractionalOwnershipInterest = _prefix "FractionalOwnershipInterest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/GuaranteedLoan"></see>
    /// </summary>
    let GuaranteedLoan = _prefix "GuaranteedLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/IndividualPaymentTransaction"></see>
    /// </summary>
    let IndividualPaymentTransaction = _prefix "IndividualPaymentTransaction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Loan"></see>
    /// </summary>
    let Loan = _prefix "Loan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalClosingCosts"></see>
    /// </summary>
    let hasTotalClosingCosts = _prefix "hasTotalClosingCosts"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalPointsAndFees"></see>
    /// </summary>
    let hasTotalPointsAndFees = _prefix "hasTotalPointsAndFees"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanSpecificCustomerAccount"></see>
    /// </summary>
    let LoanSpecificCustomerAccount = _prefix "LoanSpecificCustomerAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isServicedBy"></see>
    /// </summary>
    let isServicedBy = _prefix "isServicedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Servicer"></see>
    /// </summary>
    let Servicer = _prefix "Servicer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasNegativeAmortization"></see>
    /// </summary>
    let hasNegativeAmortization = _prefix "hasNegativeAmortization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInterestOnly"></see>
    /// </summary>
    let isInterestOnly = _prefix "isInterestOnly"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrincipalAmount"></see>
    /// </summary>
    let hasPrincipalAmount = _prefix "hasPrincipalAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanPaymentSchedule"></see>
    /// </summary>
    let LoanPaymentSchedule = _prefix "LoanPaymentSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasLoanBalance"></see>
    /// </summary>
    let hasLoanBalance = _prefix "hasLoanBalance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPaymentHistory"></see>
    /// </summary>
    let hasPaymentHistory = _prefix "hasPaymentHistory"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PaymentHistory"></see>
    /// </summary>
    let PaymentHistory = _prefix "PaymentHistory"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanToValueRatio"></see>
    /// </summary>
    let LoanToValueRatio = _prefix "LoanToValueRatio"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OpenEndCredit"></see>
    /// </summary>
    let OpenEndCredit = _prefix "OpenEndCredit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasIndividualPayment"></see>
    /// </summary>
    let hasIndividualPayment = _prefix "hasIndividualPayment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrepaymentTerms"></see>
    /// </summary>
    let PrepaymentTerms = _prefix "PrepaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrePaymentPenaltyTerm"></see>
    /// </summary>
    let hasPrePaymentPenaltyTerm = _prefix "hasPrePaymentPenaltyTerm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrimaryLienPosition"></see>
    /// </summary>
    let PrimaryLienPosition = _prefix "PrimaryLienPosition"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SubordinateLienPosition"></see>
    /// </summary>
    let SubordinateLienPosition = _prefix "SubordinateLienPosition"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/UnsecuredLoan"></see>
    /// </summary>
    let UnsecuredLoan = _prefix "UnsecuredLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasCost"></see>
    /// </summary>
    let hasCost = _prefix "hasCost"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasScheduledUnpaidBalance"></see>
    /// </summary>
    let hasScheduledUnpaidBalance = _prefix "hasScheduledUnpaidBalance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isAssumable"></see>
    /// </summary>
    let isAssumable = _prefix "isAssumable"
