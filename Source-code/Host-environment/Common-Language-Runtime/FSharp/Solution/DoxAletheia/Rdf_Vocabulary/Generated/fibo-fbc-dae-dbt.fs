namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.Debt.slash

open DoxAletheia

module fibo_fbc_dae_dbt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Accrual"></see>
    /// </summary>
    let Accrual = _prefix "Accrual"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Interest"></see>
    /// </summary>
    let Interest = _prefix "Interest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AccruedInterest"></see>
    /// </summary>
    let AccruedInterest = _prefix "AccruedInterest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Amortization"></see>
    /// </summary>
    let Amortization = _prefix "Amortization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isAmortizationOf"></see>
    /// </summary>
    let isAmortizationOf = _prefix "isAmortizationOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debt"></see>
    /// </summary>
    let Debt = _prefix "Debt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AmortizationSchedule"></see>
    /// </summary>
    let AmortizationSchedule = _prefix "AmortizationSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ProjectedContractEventSchedule"></see>
    /// </summary>
    let ProjectedContractEventSchedule = _prefix "ProjectedContractEventSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentSchedule"></see>
    /// </summary>
    let InterestPaymentSchedule = _prefix "InterestPaymentSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPaymentSchedule"></see>
    /// </summary>
    let PrincipalPaymentSchedule = _prefix "PrincipalPaymentSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Borrower"></see>
    /// </summary>
    let Borrower = _prefix "Borrower"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debtor"></see>
    /// </summary>
    let Debtor = _prefix "Debtor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/owes"></see>
    /// </summary>
    let owes = _prefix "owes"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreement"></see>
    /// </summary>
    let CreditAgreement = _prefix "CreditAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentificationScheme"></see>
    /// </summary>
    let BorrowerIdentificationScheme = _prefix "BorrowerIdentificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentifier"></see>
    /// </summary>
    let BorrowerIdentifier = _prefix "BorrowerIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowingCapacity"></see>
    /// </summary>
    let BorrowingCapacity = _prefix "BorrowingCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CapitalLease"></see>
    /// </summary>
    let CapitalLease = _prefix "CapitalLease"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lease"></see>
    /// </summary>
    let Lease = _prefix "Lease"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Collateral"></see>
    /// </summary>
    let Collateral = _prefix "Collateral"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizationOf"></see>
    /// </summary>
    let isCollateralizationOf = _prefix "isCollateralizationOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CollateralValueAsOfDate"></see>
    /// </summary>
    let CollateralValueAsOfDate = _prefix "CollateralValueAsOfDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedCreditFacility"></see>
    /// </summary>
    let CommittedCreditFacility = _prefix "CommittedCreditFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditFacility"></see>
    /// </summary>
    let CreditFacility = _prefix "CreditFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedSubFacility"></see>
    /// </summary>
    let CommittedSubFacility = _prefix "CommittedSubFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedCreditFacility"></see>
    /// </summary>
    let UncommittedCreditFacility = _prefix "UncommittedCreditFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SubFacility"></see>
    /// </summary>
    let SubFacility = _prefix "SubFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedSubFacility"></see>
    /// </summary>
    let UncommittedSubFacility = _prefix "UncommittedSubFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizedBy"></see>
    /// </summary>
    let isCollateralizedBy = _prefix "isCollateralizedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialExchangeDate"></see>
    /// </summary>
    let hasInitialExchangeDate = _prefix "hasInitialExchangeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaturityDate"></see>
    /// </summary>
    let hasMaturityDate = _prefix "hasMaturityDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Creditor"></see>
    /// </summary>
    let Creditor = _prefix "Creditor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DebtTerms"></see>
    /// </summary>
    let DebtTerms = _prefix "DebtTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidAtMaturity"></see>
    /// </summary>
    let CreditAgreementRepaidAtMaturity = _prefix "CreditAgreementRepaidAtMaturity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidPeriodically"></see>
    /// </summary>
    let CreditAgreementRepaidPeriodically = _prefix "CreditAgreementRepaidPeriodically"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementAgreement"></see>
    /// </summary>
    let CreditEnhancementAgreement = _prefix "CreditEnhancementAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementBeneficiary"></see>
    /// </summary>
    let CreditEnhancementBeneficiary = _prefix "CreditEnhancementBeneficiary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwed"></see>
    /// </summary>
    let isOwed = _prefix "isOwed"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention"></see>
    /// </summary>
    let DayCountConvention = _prefix "DayCountConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360BondBasis"></see>
    /// </summary>
    let ``DayCountConvention-30360BondBasis`` =
        _prefix "DayCountConvention-30360BondBasis"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360US"></see>
    /// </summary>
    let ``DayCountConvention-30360US`` = _prefix "DayCountConvention-30360US"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30365"></see>
    /// </summary>
    let ``DayCountConvention-30365`` = _prefix "DayCountConvention-30365"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360"></see>
    /// </summary>
    let ``DayCountConvention-30E360`` = _prefix "DayCountConvention-30E360"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360ISDA"></see>
    /// </summary>
    let ``DayCountConvention-30E360ISDA`` = _prefix "DayCountConvention-30E360ISDA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual360"></see>
    /// </summary>
    let ``DayCountConvention-Actual360`` = _prefix "DayCountConvention-Actual360"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual365Fixed"></see>
    /// </summary>
    let ``DayCountConvention-Actual365Fixed`` =
        _prefix "DayCountConvention-Actual365Fixed"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualICMA"></see>
    /// </summary>
    let ``DayCountConvention-ActualActualICMA`` =
        _prefix "DayCountConvention-ActualActualICMA"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualISDA"></see>
    /// </summary>
    let ``DayCountConvention-ActualActualISDA`` =
        _prefix "DayCountConvention-ActualActualISDA"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedBy"></see>
    /// </summary>
    let isOwedBy = _prefix "isOwedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedTo"></see>
    /// </summary>
    let isOwedTo = _prefix "isOwedTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ExplicitContractEventSchedule"></see>
    /// </summary>
    let ExplicitContractEventSchedule = _prefix "ExplicitContractEventSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FixedInterestRate"></see>
    /// </summary>
    let FixedInterestRate = _prefix "FixedInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FloatingInterestRate"></see>
    /// </summary>
    let FloatingInterestRate = _prefix "FloatingInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/VariableInterestRate"></see>
    /// </summary>
    let VariableInterestRate = _prefix "VariableInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FullAmortization"></see>
    /// </summary>
    let FullAmortization = _prefix "FullAmortization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRate"></see>
    /// </summary>
    let hasInterestRate = _prefix "hasInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isInterestOn"></see>
    /// </summary>
    let isInterestOn = _prefix "isInterestOn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculation"></see>
    /// </summary>
    let InterestCalculation = _prefix "InterestCalculation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculationSchedule"></see>
    /// </summary>
    let InterestCalculationSchedule = _prefix "InterestCalculationSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPayment"></see>
    /// </summary>
    let InterestPayment = _prefix "InterestPayment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentTerms"></see>
    /// </summary>
    let InterestPaymentTerms = _prefix "InterestPaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAccrualBasis"></see>
    /// </summary>
    let hasAccrualBasis = _prefix "hasAccrualBasis"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRateCap"></see>
    /// </summary>
    let hasInterestRateCap = _prefix "hasInterestRateCap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentDay"></see>
    /// </summary>
    let hasInterestPaymentDay = _prefix "hasInterestPaymentDay"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCompoundingFrequency"></see>
    /// </summary>
    let hasCompoundingFrequency = _prefix "hasCompoundingFrequency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentFrequency"></see>
    /// </summary>
    let hasInterestPaymentFrequency = _prefix "hasInterestPaymentFrequency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestAccrualDate"></see>
    /// </summary>
    let hasInitialInterestAccrualDate = _prefix "hasInitialInterestAccrualDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestPaymentDate"></see>
    /// </summary>
    let hasInitialInterestPaymentDate = _prefix "hasInitialInterestPaymentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/governsPaymentOf"></see>
    /// </summary>
    let governsPaymentOf = _prefix "governsPaymentOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateReset"></see>
    /// </summary>
    let InterestRateReset = _prefix "InterestRateReset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateResetSchedule"></see>
    /// </summary>
    let InterestRateResetSchedule = _prefix "InterestRateResetSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateSettingEvent"></see>
    /// </summary>
    let InterestRateSettingEvent = _prefix "InterestRateSettingEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lender"></see>
    /// </summary>
    let Lender = _prefix "Lender"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ManagedInterestRate"></see>
    /// </summary>
    let ManagedInterestRate = _prefix "ManagedInterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/MotorVehicleLease"></see>
    /// </summary>
    let MotorVehicleLease = _prefix "MotorVehicleLease"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NegativeAmortization"></see>
    /// </summary>
    let NegativeAmortization = _prefix "NegativeAmortization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NonPhysicalCollateral"></see>
    /// </summary>
    let NonPhysicalCollateral = _prefix "NonPhysicalCollateral"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PhysicalCollateral"></see>
    /// </summary>
    let PhysicalCollateral = _prefix "PhysicalCollateral"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PartialAmortization"></see>
    /// </summary>
    let PartialAmortization = _prefix "PartialAmortization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Principal"></see>
    /// </summary>
    let Principal = _prefix "Principal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isPrincipalOf"></see>
    /// </summary>
    let isPrincipalOf = _prefix "isPrincipalOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPayment"></see>
    /// </summary>
    let PrincipalPayment = _prefix "PrincipalPayment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalRepaymentTerms"></see>
    /// </summary>
    let PrincipalRepaymentTerms = _prefix "PrincipalRepaymentTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentDay"></see>
    /// </summary>
    let hasPrincipalPaymentDay = _prefix "hasPrincipalPaymentDay"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentFrequency"></see>
    /// </summary>
    let hasPrincipalPaymentFrequency = _prefix "hasPrincipalPaymentFrequency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialPrincipalPaymentDate"></see>
    /// </summary>
    let hasInitialPrincipalPaymentDate = _prefix "hasInitialPrincipalPaymentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalRepaymentDate"></see>
    /// </summary>
    let hasPrincipalRepaymentDate = _prefix "hasPrincipalRepaymentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAnticipatedNumberOfPayments"></see>
    /// </summary>
    let hasAnticipatedNumberOfPayments = _prefix "hasAnticipatedNumberOfPayments"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RateResetTimeOfDay"></see>
    /// </summary>
    let RateResetTimeOfDay = _prefix "RateResetTimeOfDay"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RetailCreditFacility"></see>
    /// </summary>
    let RetailCreditFacility = _prefix "RetailCreditFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RevolvingLineOfCredit"></see>
    /// </summary>
    let RevolvingLineOfCredit = _prefix "RevolvingLineOfCredit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SecurityAgreement"></see>
    /// </summary>
    let SecurityAgreement = _prefix "SecurityAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAmountOfCreditExtended"></see>
    /// </summary>
    let hasAmountOfCreditExtended = _prefix "hasAmountOfCreditExtended"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAvailableAmount"></see>
    /// </summary>
    let hasAvailableAmount = _prefix "hasAvailableAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasBorrower"></see>
    /// </summary>
    let hasBorrower = _prefix "hasBorrower"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCreditLimit"></see>
    /// </summary>
    let hasCreditLimit = _prefix "hasCreditLimit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDebtAmount"></see>
    /// </summary>
    let hasDebtAmount = _prefix "hasDebtAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDenomination"></see>
    /// </summary>
    let hasDenomination = _prefix "hasDenomination"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasFinalInterestPaymentDate"></see>
    /// </summary>
    let hasFinalInterestPaymentDate = _prefix "hasFinalInterestPaymentDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasLender"></see>
    /// </summary>
    let hasLender = _prefix "hasLender"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaximumAdvanceAmount"></see>
    /// </summary>
    let hasMaximumAdvanceAmount = _prefix "hasMaximumAdvanceAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOriginalTimeToMaturity"></see>
    /// </summary>
    let hasOriginalTimeToMaturity = _prefix "hasOriginalTimeToMaturity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOutstandingAmount"></see>
    /// </summary>
    let hasOutstandingAmount = _prefix "hasOutstandingAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipal"></see>
    /// </summary>
    let hasPrincipal = _prefix "hasPrincipal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isBasedOn"></see>
    /// </summary>
    let isBasedOn = _prefix "isBasedOn"
