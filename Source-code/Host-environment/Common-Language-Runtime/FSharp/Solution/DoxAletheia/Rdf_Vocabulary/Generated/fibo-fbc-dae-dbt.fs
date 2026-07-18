namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.Debt.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_dae_dbt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Accrual"></see>
    /// </summary>
    let Accrual = Namespaced_IRI.parse _namespace_name "Accrual" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Interest"></see>
    /// </summary>
    let Interest = Namespaced_IRI.parse _namespace_name "Interest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AccruedInterest"></see>
    /// </summary>
    let AccruedInterest =
        Namespaced_IRI.parse _namespace_name "AccruedInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Amortization"></see>
    /// </summary>
    let Amortization =
        Namespaced_IRI.parse _namespace_name "Amortization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isAmortizationOf"></see>
    /// </summary>
    let isAmortizationOf =
        Namespaced_IRI.parse _namespace_name "isAmortizationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debt"></see>
    /// </summary>
    let Debt = Namespaced_IRI.parse _namespace_name "Debt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AmortizationSchedule"></see>
    /// </summary>
    let AmortizationSchedule =
        Namespaced_IRI.parse _namespace_name "AmortizationSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ProjectedContractEventSchedule"></see>
    /// </summary>
    let ProjectedContractEventSchedule =
        Namespaced_IRI.parse _namespace_name "ProjectedContractEventSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentSchedule"></see>
    /// </summary>
    let InterestPaymentSchedule =
        Namespaced_IRI.parse _namespace_name "InterestPaymentSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPaymentSchedule"></see>
    /// </summary>
    let PrincipalPaymentSchedule =
        Namespaced_IRI.parse _namespace_name "PrincipalPaymentSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Borrower"></see>
    /// </summary>
    let Borrower = Namespaced_IRI.parse _namespace_name "Borrower" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debtor"></see>
    /// </summary>
    let Debtor = Namespaced_IRI.parse _namespace_name "Debtor" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/owes"></see>
    /// </summary>
    let owes = Namespaced_IRI.parse _namespace_name "owes" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreement"></see>
    /// </summary>
    let CreditAgreement =
        Namespaced_IRI.parse _namespace_name "CreditAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentificationScheme"></see>
    /// </summary>
    let BorrowerIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "BorrowerIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentifier"></see>
    /// </summary>
    let BorrowerIdentifier =
        Namespaced_IRI.parse _namespace_name "BorrowerIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowingCapacity"></see>
    /// </summary>
    let BorrowingCapacity =
        Namespaced_IRI.parse _namespace_name "BorrowingCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CapitalLease"></see>
    /// </summary>
    let CapitalLease =
        Namespaced_IRI.parse _namespace_name "CapitalLease" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lease"></see>
    /// </summary>
    let Lease = Namespaced_IRI.parse _namespace_name "Lease" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Collateral"></see>
    /// </summary>
    let Collateral = Namespaced_IRI.parse _namespace_name "Collateral" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizationOf"></see>
    /// </summary>
    let isCollateralizationOf =
        Namespaced_IRI.parse _namespace_name "isCollateralizationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CollateralValueAsOfDate"></see>
    /// </summary>
    let CollateralValueAsOfDate =
        Namespaced_IRI.parse _namespace_name "CollateralValueAsOfDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedCreditFacility"></see>
    /// </summary>
    let CommittedCreditFacility =
        Namespaced_IRI.parse _namespace_name "CommittedCreditFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditFacility"></see>
    /// </summary>
    let CreditFacility =
        Namespaced_IRI.parse _namespace_name "CreditFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedSubFacility"></see>
    /// </summary>
    let CommittedSubFacility =
        Namespaced_IRI.parse _namespace_name "CommittedSubFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedCreditFacility"></see>
    /// </summary>
    let UncommittedCreditFacility =
        Namespaced_IRI.parse _namespace_name "UncommittedCreditFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SubFacility"></see>
    /// </summary>
    let SubFacility =
        Namespaced_IRI.parse _namespace_name "SubFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedSubFacility"></see>
    /// </summary>
    let UncommittedSubFacility =
        Namespaced_IRI.parse _namespace_name "UncommittedSubFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizedBy"></see>
    /// </summary>
    let isCollateralizedBy =
        Namespaced_IRI.parse _namespace_name "isCollateralizedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialExchangeDate"></see>
    /// </summary>
    let hasInitialExchangeDate =
        Namespaced_IRI.parse _namespace_name "hasInitialExchangeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaturityDate"></see>
    /// </summary>
    let hasMaturityDate =
        Namespaced_IRI.parse _namespace_name "hasMaturityDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Creditor"></see>
    /// </summary>
    let Creditor = Namespaced_IRI.parse _namespace_name "Creditor" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DebtTerms"></see>
    /// </summary>
    let DebtTerms = Namespaced_IRI.parse _namespace_name "DebtTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidAtMaturity"></see>
    /// </summary>
    let CreditAgreementRepaidAtMaturity =
        Namespaced_IRI.parse _namespace_name "CreditAgreementRepaidAtMaturity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidPeriodically"></see>
    /// </summary>
    let CreditAgreementRepaidPeriodically =
        Namespaced_IRI.parse _namespace_name "CreditAgreementRepaidPeriodically" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementAgreement"></see>
    /// </summary>
    let CreditEnhancementAgreement =
        Namespaced_IRI.parse _namespace_name "CreditEnhancementAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementBeneficiary"></see>
    /// </summary>
    let CreditEnhancementBeneficiary =
        Namespaced_IRI.parse _namespace_name "CreditEnhancementBeneficiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwed"></see>
    /// </summary>
    let isOwed = Namespaced_IRI.parse _namespace_name "isOwed" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention"></see>
    /// </summary>
    let DayCountConvention =
        Namespaced_IRI.parse _namespace_name "DayCountConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360BondBasis"></see>
    /// </summary>
    let ``DayCountConvention-30360BondBasis`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-30360BondBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360US"></see>
    /// </summary>
    let ``DayCountConvention-30360US`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-30360US" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30365"></see>
    /// </summary>
    let ``DayCountConvention-30365`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-30365" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360"></see>
    /// </summary>
    let ``DayCountConvention-30E360`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-30E360" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360ISDA"></see>
    /// </summary>
    let ``DayCountConvention-30E360ISDA`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-30E360ISDA" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual360"></see>
    /// </summary>
    let ``DayCountConvention-Actual360`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-Actual360" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual365Fixed"></see>
    /// </summary>
    let ``DayCountConvention-Actual365Fixed`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-Actual365Fixed" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualICMA"></see>
    /// </summary>
    let ``DayCountConvention-ActualActualICMA`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-ActualActualICMA" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualISDA"></see>
    /// </summary>
    let ``DayCountConvention-ActualActualISDA`` =
        Namespaced_IRI.parse _namespace_name "DayCountConvention-ActualActualISDA" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedBy"></see>
    /// </summary>
    let isOwedBy = Namespaced_IRI.parse _namespace_name "isOwedBy" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedTo"></see>
    /// </summary>
    let isOwedTo = Namespaced_IRI.parse _namespace_name "isOwedTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ExplicitContractEventSchedule"></see>
    /// </summary>
    let ExplicitContractEventSchedule =
        Namespaced_IRI.parse _namespace_name "ExplicitContractEventSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FixedInterestRate"></see>
    /// </summary>
    let FixedInterestRate =
        Namespaced_IRI.parse _namespace_name "FixedInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FloatingInterestRate"></see>
    /// </summary>
    let FloatingInterestRate =
        Namespaced_IRI.parse _namespace_name "FloatingInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/VariableInterestRate"></see>
    /// </summary>
    let VariableInterestRate =
        Namespaced_IRI.parse _namespace_name "VariableInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FullAmortization"></see>
    /// </summary>
    let FullAmortization =
        Namespaced_IRI.parse _namespace_name "FullAmortization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRate"></see>
    /// </summary>
    let hasInterestRate =
        Namespaced_IRI.parse _namespace_name "hasInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isInterestOn"></see>
    /// </summary>
    let isInterestOn =
        Namespaced_IRI.parse _namespace_name "isInterestOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculation"></see>
    /// </summary>
    let InterestCalculation =
        Namespaced_IRI.parse _namespace_name "InterestCalculation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculationSchedule"></see>
    /// </summary>
    let InterestCalculationSchedule =
        Namespaced_IRI.parse _namespace_name "InterestCalculationSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPayment"></see>
    /// </summary>
    let InterestPayment =
        Namespaced_IRI.parse _namespace_name "InterestPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentTerms"></see>
    /// </summary>
    let InterestPaymentTerms =
        Namespaced_IRI.parse _namespace_name "InterestPaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAccrualBasis"></see>
    /// </summary>
    let hasAccrualBasis =
        Namespaced_IRI.parse _namespace_name "hasAccrualBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRateCap"></see>
    /// </summary>
    let hasInterestRateCap =
        Namespaced_IRI.parse _namespace_name "hasInterestRateCap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentDay"></see>
    /// </summary>
    let hasInterestPaymentDay =
        Namespaced_IRI.parse _namespace_name "hasInterestPaymentDay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCompoundingFrequency"></see>
    /// </summary>
    let hasCompoundingFrequency =
        Namespaced_IRI.parse _namespace_name "hasCompoundingFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentFrequency"></see>
    /// </summary>
    let hasInterestPaymentFrequency =
        Namespaced_IRI.parse _namespace_name "hasInterestPaymentFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestAccrualDate"></see>
    /// </summary>
    let hasInitialInterestAccrualDate =
        Namespaced_IRI.parse _namespace_name "hasInitialInterestAccrualDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestPaymentDate"></see>
    /// </summary>
    let hasInitialInterestPaymentDate =
        Namespaced_IRI.parse _namespace_name "hasInitialInterestPaymentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/governsPaymentOf"></see>
    /// </summary>
    let governsPaymentOf =
        Namespaced_IRI.parse _namespace_name "governsPaymentOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateReset"></see>
    /// </summary>
    let InterestRateReset =
        Namespaced_IRI.parse _namespace_name "InterestRateReset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateResetSchedule"></see>
    /// </summary>
    let InterestRateResetSchedule =
        Namespaced_IRI.parse _namespace_name "InterestRateResetSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateSettingEvent"></see>
    /// </summary>
    let InterestRateSettingEvent =
        Namespaced_IRI.parse _namespace_name "InterestRateSettingEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lender"></see>
    /// </summary>
    let Lender = Namespaced_IRI.parse _namespace_name "Lender" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ManagedInterestRate"></see>
    /// </summary>
    let ManagedInterestRate =
        Namespaced_IRI.parse _namespace_name "ManagedInterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/MotorVehicleLease"></see>
    /// </summary>
    let MotorVehicleLease =
        Namespaced_IRI.parse _namespace_name "MotorVehicleLease" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NegativeAmortization"></see>
    /// </summary>
    let NegativeAmortization =
        Namespaced_IRI.parse _namespace_name "NegativeAmortization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NonPhysicalCollateral"></see>
    /// </summary>
    let NonPhysicalCollateral =
        Namespaced_IRI.parse _namespace_name "NonPhysicalCollateral" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PhysicalCollateral"></see>
    /// </summary>
    let PhysicalCollateral =
        Namespaced_IRI.parse _namespace_name "PhysicalCollateral" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PartialAmortization"></see>
    /// </summary>
    let PartialAmortization =
        Namespaced_IRI.parse _namespace_name "PartialAmortization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Principal"></see>
    /// </summary>
    let Principal = Namespaced_IRI.parse _namespace_name "Principal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isPrincipalOf"></see>
    /// </summary>
    let isPrincipalOf =
        Namespaced_IRI.parse _namespace_name "isPrincipalOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPayment"></see>
    /// </summary>
    let PrincipalPayment =
        Namespaced_IRI.parse _namespace_name "PrincipalPayment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalRepaymentTerms"></see>
    /// </summary>
    let PrincipalRepaymentTerms =
        Namespaced_IRI.parse _namespace_name "PrincipalRepaymentTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentDay"></see>
    /// </summary>
    let hasPrincipalPaymentDay =
        Namespaced_IRI.parse _namespace_name "hasPrincipalPaymentDay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentFrequency"></see>
    /// </summary>
    let hasPrincipalPaymentFrequency =
        Namespaced_IRI.parse _namespace_name "hasPrincipalPaymentFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialPrincipalPaymentDate"></see>
    /// </summary>
    let hasInitialPrincipalPaymentDate =
        Namespaced_IRI.parse _namespace_name "hasInitialPrincipalPaymentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalRepaymentDate"></see>
    /// </summary>
    let hasPrincipalRepaymentDate =
        Namespaced_IRI.parse _namespace_name "hasPrincipalRepaymentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAnticipatedNumberOfPayments"></see>
    /// </summary>
    let hasAnticipatedNumberOfPayments =
        Namespaced_IRI.parse _namespace_name "hasAnticipatedNumberOfPayments" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RateResetTimeOfDay"></see>
    /// </summary>
    let RateResetTimeOfDay =
        Namespaced_IRI.parse _namespace_name "RateResetTimeOfDay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RetailCreditFacility"></see>
    /// </summary>
    let RetailCreditFacility =
        Namespaced_IRI.parse _namespace_name "RetailCreditFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RevolvingLineOfCredit"></see>
    /// </summary>
    let RevolvingLineOfCredit =
        Namespaced_IRI.parse _namespace_name "RevolvingLineOfCredit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SecurityAgreement"></see>
    /// </summary>
    let SecurityAgreement =
        Namespaced_IRI.parse _namespace_name "SecurityAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAmountOfCreditExtended"></see>
    /// </summary>
    let hasAmountOfCreditExtended =
        Namespaced_IRI.parse _namespace_name "hasAmountOfCreditExtended" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAvailableAmount"></see>
    /// </summary>
    let hasAvailableAmount =
        Namespaced_IRI.parse _namespace_name "hasAvailableAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasBorrower"></see>
    /// </summary>
    let hasBorrower =
        Namespaced_IRI.parse _namespace_name "hasBorrower" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCreditLimit"></see>
    /// </summary>
    let hasCreditLimit =
        Namespaced_IRI.parse _namespace_name "hasCreditLimit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDebtAmount"></see>
    /// </summary>
    let hasDebtAmount =
        Namespaced_IRI.parse _namespace_name "hasDebtAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDenomination"></see>
    /// </summary>
    let hasDenomination =
        Namespaced_IRI.parse _namespace_name "hasDenomination" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasFinalInterestPaymentDate"></see>
    /// </summary>
    let hasFinalInterestPaymentDate =
        Namespaced_IRI.parse _namespace_name "hasFinalInterestPaymentDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasLender"></see>
    /// </summary>
    let hasLender = Namespaced_IRI.parse _namespace_name "hasLender" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaximumAdvanceAmount"></see>
    /// </summary>
    let hasMaximumAdvanceAmount =
        Namespaced_IRI.parse _namespace_name "hasMaximumAdvanceAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOriginalTimeToMaturity"></see>
    /// </summary>
    let hasOriginalTimeToMaturity =
        Namespaced_IRI.parse _namespace_name "hasOriginalTimeToMaturity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOutstandingAmount"></see>
    /// </summary>
    let hasOutstandingAmount =
        Namespaced_IRI.parse _namespace_name "hasOutstandingAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipal"></see>
    /// </summary>
    let hasPrincipal =
        Namespaced_IRI.parse _namespace_name "hasPrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isBasedOn"></see>
    /// </summary>
    let isBasedOn = Namespaced_IRI.parse _namespace_name "isBasedOn" |> NamespacedName
