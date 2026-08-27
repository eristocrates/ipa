namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.Debt.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_dae_dbt =
    let _namespace_iri = Namespace_Iri fibo_fbc_dae_dbt |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Debt Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_dae_dbt, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Accrual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"accrual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Accrual">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Accrual</seealso>
    let Accrual = Prefixed_Name(fibo_fbc_dae_dbt, "Accrual") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:AccruedInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"accrued interest"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AccruedInterest">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AccruedInterest</seealso>
    let AccruedInterest =
        Prefixed_Name(fibo_fbc_dae_dbt, "AccruedInterest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Amortization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amortization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Amortization">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Amortization</seealso>
    let Amortization = Prefixed_Name(fibo_fbc_dae_dbt, "Amortization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:AmortizationSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amortization schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AmortizationSchedule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AmortizationSchedule</seealso>
    let AmortizationSchedule =
        Prefixed_Name(fibo_fbc_dae_dbt, "AmortizationSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Borrower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"borrower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Borrower">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Borrower</seealso>
    let Borrower = Prefixed_Name(fibo_fbc_dae_dbt, "Borrower") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:BorrowerIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"borrower identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentificationScheme</seealso>
    let BorrowerIdentificationScheme =
        Prefixed_Name(fibo_fbc_dae_dbt, "BorrowerIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:BorrowerIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"borrower identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentifier</seealso>
    let BorrowerIdentifier =
        Prefixed_Name(fibo_fbc_dae_dbt, "BorrowerIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:BorrowingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"borrowing capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowingCapacity">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowingCapacity</seealso>
    let BorrowingCapacity =
        Prefixed_Name(fibo_fbc_dae_dbt, "BorrowingCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CapitalLease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capital lease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CapitalLease">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CapitalLease</seealso>
    let CapitalLease = Prefixed_Name(fibo_fbc_dae_dbt, "CapitalLease") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Collateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collateral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Collateral">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Collateral</seealso>
    let Collateral = Prefixed_Name(fibo_fbc_dae_dbt, "Collateral") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CollateralValueAsOfDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collateral value as of date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CollateralValueAsOfDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CollateralValueAsOfDate</seealso>
    let CollateralValueAsOfDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "CollateralValueAsOfDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CommittedCreditFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"committed credit facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedCreditFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedCreditFacility</seealso>
    let CommittedCreditFacility =
        Prefixed_Name(fibo_fbc_dae_dbt, "CommittedCreditFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CommittedSubFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"committed sub-facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedSubFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedSubFacility</seealso>
    let CommittedSubFacility =
        Prefixed_Name(fibo_fbc_dae_dbt, "CommittedSubFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CreditAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreement">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreement</seealso>
    let CreditAgreement =
        Prefixed_Name(fibo_fbc_dae_dbt, "CreditAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CreditAgreementRepaidAtMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit agreement repaid at maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidAtMaturity">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidAtMaturity</seealso>
    let CreditAgreementRepaidAtMaturity =
        Prefixed_Name(fibo_fbc_dae_dbt, "CreditAgreementRepaidAtMaturity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CreditAgreementRepaidPeriodically</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit agreement repaid periodically"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidPeriodically">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidPeriodically</seealso>
    let CreditAgreementRepaidPeriodically =
        Prefixed_Name(fibo_fbc_dae_dbt, "CreditAgreementRepaidPeriodically") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CreditEnhancementAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit enhancement agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementAgreement">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementAgreement</seealso>
    let CreditEnhancementAgreement =
        Prefixed_Name(fibo_fbc_dae_dbt, "CreditEnhancementAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CreditEnhancementBeneficiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit enhancement beneficiary"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementBeneficiary">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementBeneficiary</seealso>
    let CreditEnhancementBeneficiary =
        Prefixed_Name(fibo_fbc_dae_dbt, "CreditEnhancementBeneficiary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:CreditFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditFacility</seealso>
    let CreditFacility =
        Prefixed_Name(fibo_fbc_dae_dbt, "CreditFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Creditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"creditor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Creditor">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Creditor</seealso>
    let Creditor = Prefixed_Name(fibo_fbc_dae_dbt, "Creditor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"day-count convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention</seealso>
    let DayCountConvention =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-30360BondBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"day-count convention 30/360 bond basis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360BondBasis">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360BondBasis</seealso>
    let DayCountConvention_30360BondBasis =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-30360BondBasis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-30360US</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///
    /// labels<para>"day-count convention 30/360 US"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360US">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30360US</seealso>
    let DayCountConvention_30360US =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-30360US") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-30365</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"day-count convention 30/365"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30365">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30365</seealso>
    let DayCountConvention_30365 =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-30365") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-30E360</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///
    /// labels<para>"day-count convention 30E/360"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360</seealso>
    let DayCountConvention_30E360 =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-30E360") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-30E360ISDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"day-count convention 30E/360 ISDA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360ISDA">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-30E360ISDA</seealso>
    let DayCountConvention_30E360ISDA =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-30E360ISDA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-Actual360</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"day-count convention actual/360"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual360">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual360</seealso>
    let DayCountConvention_Actual360 =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-Actual360") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-Actual365Fixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///
    /// labels<para>"day-count convention actual/365 fixed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual365Fixed">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-Actual365Fixed</seealso>
    let DayCountConvention_Actual365Fixed =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-Actual365Fixed") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-ActualActualICMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///
    /// labels<para>"day-count convention actual/actual ICMA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualICMA">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualICMA</seealso>
    let DayCountConvention_ActualActualICMA =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-ActualActualICMA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention-ActualActualISDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-dae-dbt:DayCountConvention</para>
    ///
    /// labels<para>"day-count convention actual/actual ISDA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualISDA">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention-ActualActualISDA</seealso>
    let DayCountConvention_ActualActualISDA =
        Prefixed_Name(fibo_fbc_dae_dbt, "DayCountConvention-ActualActualISDA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Debt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debt">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debt</seealso>
    let Debt = Prefixed_Name(fibo_fbc_dae_dbt, "Debt") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:DebtTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DebtTerms">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DebtTerms</seealso>
    let DebtTerms = Prefixed_Name(fibo_fbc_dae_dbt, "DebtTerms") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Debtor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debtor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debtor">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debtor</seealso>
    let Debtor = Prefixed_Name(fibo_fbc_dae_dbt, "Debtor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:ExplicitContractEventSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"explicit contract event schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ExplicitContractEventSchedule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ExplicitContractEventSchedule</seealso>
    let ExplicitContractEventSchedule =
        Prefixed_Name(fibo_fbc_dae_dbt, "ExplicitContractEventSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:FixedInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FixedInterestRate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FixedInterestRate</seealso>
    let FixedInterestRate =
        Prefixed_Name(fibo_fbc_dae_dbt, "FixedInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:FloatingInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"floating interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FloatingInterestRate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FloatingInterestRate</seealso>
    let FloatingInterestRate =
        Prefixed_Name(fibo_fbc_dae_dbt, "FloatingInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:FullAmortization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"full amortization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FullAmortization">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FullAmortization</seealso>
    let FullAmortization =
        Prefixed_Name(fibo_fbc_dae_dbt, "FullAmortization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Interest">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Interest</seealso>
    let Interest = Prefixed_Name(fibo_fbc_dae_dbt, "Interest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestCalculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest calculation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculation">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculation</seealso>
    let InterestCalculation =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestCalculation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestCalculationSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest calculation schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculationSchedule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculationSchedule</seealso>
    let InterestCalculationSchedule =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestCalculationSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest payment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPayment">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPayment</seealso>
    let InterestPayment =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestPayment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestPaymentSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest payment schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentSchedule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentSchedule</seealso>
    let InterestPaymentSchedule =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestPaymentSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestPaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest payment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentTerms">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentTerms</seealso>
    let InterestPaymentTerms =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestPaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestRateReset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate reset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateReset">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateReset</seealso>
    let InterestRateReset =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestRateReset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestRateResetSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate reset schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateResetSchedule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateResetSchedule</seealso>
    let InterestRateResetSchedule =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestRateResetSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:InterestRateSettingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate setting event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateSettingEvent">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateSettingEvent</seealso>
    let InterestRateSettingEvent =
        Prefixed_Name(fibo_fbc_dae_dbt, "InterestRateSettingEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Lease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lease">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lease</seealso>
    let Lease = Prefixed_Name(fibo_fbc_dae_dbt, "Lease") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Lender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lender">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lender</seealso>
    let Lender = Prefixed_Name(fibo_fbc_dae_dbt, "Lender") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:ManagedInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"managed interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ManagedInterestRate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ManagedInterestRate</seealso>
    let ManagedInterestRate =
        Prefixed_Name(fibo_fbc_dae_dbt, "ManagedInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:MotorVehicleLease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"motor vehicle lease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/MotorVehicleLease">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/MotorVehicleLease</seealso>
    let MotorVehicleLease =
        Prefixed_Name(fibo_fbc_dae_dbt, "MotorVehicleLease") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:NegativeAmortization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negative amortization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NegativeAmortization">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NegativeAmortization</seealso>
    let NegativeAmortization =
        Prefixed_Name(fibo_fbc_dae_dbt, "NegativeAmortization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:NonPhysicalCollateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-physical collateral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NonPhysicalCollateral">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NonPhysicalCollateral</seealso>
    let NonPhysicalCollateral =
        Prefixed_Name(fibo_fbc_dae_dbt, "NonPhysicalCollateral") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:PartialAmortization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partial amortization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PartialAmortization">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PartialAmortization</seealso>
    let PartialAmortization =
        Prefixed_Name(fibo_fbc_dae_dbt, "PartialAmortization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:PhysicalCollateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical collateral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PhysicalCollateral">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PhysicalCollateral</seealso>
    let PhysicalCollateral =
        Prefixed_Name(fibo_fbc_dae_dbt, "PhysicalCollateral") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:Principal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Principal">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Principal</seealso>
    let Principal = Prefixed_Name(fibo_fbc_dae_dbt, "Principal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:PrincipalPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal payment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPayment">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPayment</seealso>
    let PrincipalPayment =
        Prefixed_Name(fibo_fbc_dae_dbt, "PrincipalPayment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:PrincipalPaymentSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal payment schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPaymentSchedule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPaymentSchedule</seealso>
    let PrincipalPaymentSchedule =
        Prefixed_Name(fibo_fbc_dae_dbt, "PrincipalPaymentSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:PrincipalRepaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal repayment terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalRepaymentTerms">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalRepaymentTerms</seealso>
    let PrincipalRepaymentTerms =
        Prefixed_Name(fibo_fbc_dae_dbt, "PrincipalRepaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:ProjectedContractEventSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"projected contract event schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ProjectedContractEventSchedule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ProjectedContractEventSchedule</seealso>
    let ProjectedContractEventSchedule =
        Prefixed_Name(fibo_fbc_dae_dbt, "ProjectedContractEventSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:RateResetTimeOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rate reset time of day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RateResetTimeOfDay">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RateResetTimeOfDay</seealso>
    let RateResetTimeOfDay =
        Prefixed_Name(fibo_fbc_dae_dbt, "RateResetTimeOfDay") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:RetailCreditFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"retail credit facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RetailCreditFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RetailCreditFacility</seealso>
    let RetailCreditFacility =
        Prefixed_Name(fibo_fbc_dae_dbt, "RetailCreditFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:RevolvingLineOfCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"revolving line of credit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RevolvingLineOfCredit">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RevolvingLineOfCredit</seealso>
    let RevolvingLineOfCredit =
        Prefixed_Name(fibo_fbc_dae_dbt, "RevolvingLineOfCredit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:SecurityAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SecurityAgreement">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SecurityAgreement</seealso>
    let SecurityAgreement =
        Prefixed_Name(fibo_fbc_dae_dbt, "SecurityAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:SubFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sub-facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SubFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SubFacility</seealso>
    let SubFacility = Prefixed_Name(fibo_fbc_dae_dbt, "SubFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:UncommittedCreditFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"uncommitted credit facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedCreditFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedCreditFacility</seealso>
    let UncommittedCreditFacility =
        Prefixed_Name(fibo_fbc_dae_dbt, "UncommittedCreditFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:UncommittedSubFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"uncommitted sub-facility"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedSubFacility">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedSubFacility</seealso>
    let UncommittedSubFacility =
        Prefixed_Name(fibo_fbc_dae_dbt, "UncommittedSubFacility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:VariableInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/VariableInterestRate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/VariableInterestRate</seealso>
    let VariableInterestRate =
        Prefixed_Name(fibo_fbc_dae_dbt, "VariableInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:governsPaymentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"governs payment of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/governsPaymentOf">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/governsPaymentOf</seealso>
    let governsPaymentOf =
        Prefixed_Name(fibo_fbc_dae_dbt, "governsPaymentOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasAccrualBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has accrual basis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAccrualBasis">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAccrualBasis</seealso>
    let hasAccrualBasis =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasAccrualBasis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasAmountOfCreditExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has amount of credit extended"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAmountOfCreditExtended">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAmountOfCreditExtended</seealso>
    let hasAmountOfCreditExtended =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasAmountOfCreditExtended") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasAnticipatedNumberOfPayments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has anticipated number of payments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAnticipatedNumberOfPayments">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAnticipatedNumberOfPayments</seealso>
    let hasAnticipatedNumberOfPayments =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasAnticipatedNumberOfPayments") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasAvailableAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has available amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAvailableAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAvailableAmount</seealso>
    let hasAvailableAmount =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasAvailableAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasBorrower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has borrower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasBorrower">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasBorrower</seealso>
    let hasBorrower = Prefixed_Name(fibo_fbc_dae_dbt, "hasBorrower") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasCompoundingFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has compounding frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCompoundingFrequency">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCompoundingFrequency</seealso>
    let hasCompoundingFrequency =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasCompoundingFrequency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasCreditLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has credit limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCreditLimit">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCreditLimit</seealso>
    let hasCreditLimit =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasCreditLimit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasDebtAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has debt amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDebtAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDebtAmount</seealso>
    let hasDebtAmount = Prefixed_Name(fibo_fbc_dae_dbt, "hasDebtAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasDenomination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has denomination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDenomination">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDenomination</seealso>
    let hasDenomination =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasDenomination") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasFinalInterestPaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has final interest payment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasFinalInterestPaymentDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasFinalInterestPaymentDate</seealso>
    let hasFinalInterestPaymentDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasFinalInterestPaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInitialExchangeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has initial exchange date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialExchangeDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialExchangeDate</seealso>
    let hasInitialExchangeDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInitialExchangeDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInitialInterestAccrualDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has initial interest accrual date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestAccrualDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestAccrualDate</seealso>
    let hasInitialInterestAccrualDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInitialInterestAccrualDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInitialInterestPaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has initial interest payment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestPaymentDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestPaymentDate</seealso>
    let hasInitialInterestPaymentDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInitialInterestPaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInitialPrincipalPaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has initial principal payment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialPrincipalPaymentDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialPrincipalPaymentDate</seealso>
    let hasInitialPrincipalPaymentDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInitialPrincipalPaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInterestPaymentDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has interest payment day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentDay">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentDay</seealso>
    let hasInterestPaymentDay =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInterestPaymentDay") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInterestPaymentFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has interest payment frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentFrequency">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentFrequency</seealso>
    let hasInterestPaymentFrequency =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInterestPaymentFrequency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRate</seealso>
    let hasInterestRate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasInterestRateCap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has interest rate cap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRateCap">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRateCap</seealso>
    let hasInterestRateCap =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasInterestRateCap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasLender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has lender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasLender">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasLender</seealso>
    let hasLender = Prefixed_Name(fibo_fbc_dae_dbt, "hasLender") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasMaturityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maturity date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaturityDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaturityDate</seealso>
    let hasMaturityDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasMaturityDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasMaximumAdvanceAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maximum advance amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaximumAdvanceAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaximumAdvanceAmount</seealso>
    let hasMaximumAdvanceAmount =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasMaximumAdvanceAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasOriginalTimeToMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has time to maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOriginalTimeToMaturity">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOriginalTimeToMaturity</seealso>
    let hasOriginalTimeToMaturity =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasOriginalTimeToMaturity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasOutstandingAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has outstanding amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOutstandingAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOutstandingAmount</seealso>
    let hasOutstandingAmount =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasOutstandingAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasPaymentDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPaymentDueDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPaymentDueDate</seealso>
    let hasPaymentDueDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasPaymentDueDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasPrincipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipal">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipal</seealso>
    let hasPrincipal = Prefixed_Name(fibo_fbc_dae_dbt, "hasPrincipal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasPrincipalPaymentDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal payment day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentDay">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentDay</seealso>
    let hasPrincipalPaymentDay =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasPrincipalPaymentDay") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasPrincipalPaymentFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal payment frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentFrequency">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentFrequency</seealso>
    let hasPrincipalPaymentFrequency =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasPrincipalPaymentFrequency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:hasPrincipalRepaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal repayment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalRepaymentDate">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalRepaymentDate</seealso>
    let hasPrincipalRepaymentDate =
        Prefixed_Name(fibo_fbc_dae_dbt, "hasPrincipalRepaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isAmortizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is amortization of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isAmortizationOf">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isAmortizationOf</seealso>
    let isAmortizationOf =
        Prefixed_Name(fibo_fbc_dae_dbt, "isAmortizationOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is based on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isBasedOn">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isBasedOn</seealso>
    let isBasedOn = Prefixed_Name(fibo_fbc_dae_dbt, "isBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isCollateralizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is collateralization of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizationOf">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizationOf</seealso>
    let isCollateralizationOf =
        Prefixed_Name(fibo_fbc_dae_dbt, "isCollateralizationOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isCollateralizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is collateralized by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizedBy">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizedBy</seealso>
    let isCollateralizedBy =
        Prefixed_Name(fibo_fbc_dae_dbt, "isCollateralizedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isInterestOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is interest on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isInterestOn">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isInterestOn</seealso>
    let isInterestOn = Prefixed_Name(fibo_fbc_dae_dbt, "isInterestOn") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isOwed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is owed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwed">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwed</seealso>
    let isOwed = Prefixed_Name(fibo_fbc_dae_dbt, "isOwed") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isOwedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is owed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedBy">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedBy</seealso>
    let isOwedBy = Prefixed_Name(fibo_fbc_dae_dbt, "isOwedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isOwedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is owed to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedTo">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedTo</seealso>
    let isOwedTo = Prefixed_Name(fibo_fbc_dae_dbt, "isOwedTo") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:isPrincipalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is principal of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isPrincipalOf">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isPrincipalOf</seealso>
    let isPrincipalOf = Prefixed_Name(fibo_fbc_dae_dbt, "isPrincipalOf") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-dbt:owes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/owes">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/owes</seealso>
    let owes = Prefixed_Name(fibo_fbc_dae_dbt, "owes") |> PrefixedName
