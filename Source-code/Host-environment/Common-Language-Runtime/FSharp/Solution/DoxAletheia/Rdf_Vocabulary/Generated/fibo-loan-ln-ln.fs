namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansGeneral.Loans.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_ln_ln =
    let _namespace_iri = Namespace_Iri fibo_loan_ln_ln |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-ln-ln:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Loans Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_ln_ln, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:ClosedEndCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"closed-end credit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/ClosedEndCredit">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/ClosedEndCredit</seealso>
    let ClosedEndCredit =
        Prefixed_Name(fibo_loan_ln_ln, "ClosedEndCredit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:CollateralizedLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collateralized loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CollateralizedLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CollateralizedLoan</seealso>
    let CollateralizedLoan =
        Prefixed_Name(fibo_loan_ln_ln, "CollateralizedLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:Comaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"co-maker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Comaker">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Comaker</seealso>
    let Comaker = Prefixed_Name(fibo_loan_ln_ln, "Comaker") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:CombinedLoanToValueRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"combined loan-to-value ratio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CombinedLoanToValueRatio">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CombinedLoanToValueRatio</seealso>
    let CombinedLoanToValueRatio =
        Prefixed_Name(fibo_loan_ln_ln, "CombinedLoanToValueRatio") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:FeeSimpleOwnershipInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-loan-ln-ln:OwnershipInterest</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"fee-simple ownership interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FeeSimpleOwnershipInterest">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FeeSimpleOwnershipInterest</seealso>
    let FeeSimpleOwnershipInterest =
        Prefixed_Name(fibo_loan_ln_ln, "FeeSimpleOwnershipInterest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:FractionalOwnershipInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-loan-ln-ln:OwnershipInterest</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"fractional ownership interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FractionalOwnershipInterest">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/FractionalOwnershipInterest</seealso>
    let FractionalOwnershipInterest =
        Prefixed_Name(fibo_loan_ln_ln, "FractionalOwnershipInterest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:GuaranteedLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"guaranteed loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/GuaranteedLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/GuaranteedLoan</seealso>
    let GuaranteedLoan =
        Prefixed_Name(fibo_loan_ln_ln, "GuaranteedLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:IndividualPaymentTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"individual payment transaction"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/IndividualPaymentTransaction">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/IndividualPaymentTransaction</seealso>
    let IndividualPaymentTransaction =
        Prefixed_Name(fibo_loan_ln_ln, "IndividualPaymentTransaction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:LenderLienPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lender lien position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LenderLienPosition">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LenderLienPosition</seealso>
    let LenderLienPosition =
        Prefixed_Name(fibo_loan_ln_ln, "LenderLienPosition") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:Loan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Loan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Loan</seealso>
    let Loan = Prefixed_Name(fibo_loan_ln_ln, "Loan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:LoanPaymentSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan payment schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanPaymentSchedule">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanPaymentSchedule</seealso>
    let LoanPaymentSchedule =
        Prefixed_Name(fibo_loan_ln_ln, "LoanPaymentSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:LoanSpecificCustomerAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan-specific customer account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanSpecificCustomerAccount">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanSpecificCustomerAccount</seealso>
    let LoanSpecificCustomerAccount =
        Prefixed_Name(fibo_loan_ln_ln, "LoanSpecificCustomerAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:LoanToValueRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan-to-value ratio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanToValueRatio">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanToValueRatio</seealso>
    let LoanToValueRatio =
        Prefixed_Name(fibo_loan_ln_ln, "LoanToValueRatio") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:OpenEndCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"open-end credit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OpenEndCredit">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OpenEndCredit</seealso>
    let OpenEndCredit = Prefixed_Name(fibo_loan_ln_ln, "OpenEndCredit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:OwnershipInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ownership interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OwnershipInterest">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OwnershipInterest</seealso>
    let OwnershipInterest =
        Prefixed_Name(fibo_loan_ln_ln, "OwnershipInterest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:PaymentHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment history"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PaymentHistory">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PaymentHistory</seealso>
    let PaymentHistory =
        Prefixed_Name(fibo_loan_ln_ln, "PaymentHistory") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:PrepaymentTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pre-payment terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrepaymentTerms">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrepaymentTerms</seealso>
    let PrepaymentTerms =
        Prefixed_Name(fibo_loan_ln_ln, "PrepaymentTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:PrimaryLienPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-loan-ln-ln:LenderLienPosition</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"primary lien position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrimaryLienPosition">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrimaryLienPosition</seealso>
    let PrimaryLienPosition =
        Prefixed_Name(fibo_loan_ln_ln, "PrimaryLienPosition") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:SecuredLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secured loan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SecuredLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SecuredLoan</seealso>
    let SecuredLoan = Prefixed_Name(fibo_loan_ln_ln, "SecuredLoan") |> PrefixedName
    /// <summary>
    ///   <para>fibo-loan-ln-ln:Servicer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"servicer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Servicer">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Servicer</seealso>
    let Servicer = Prefixed_Name(fibo_loan_ln_ln, "Servicer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:SubordinateLienPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-loan-ln-ln:LenderLienPosition</para>
    ///
    /// labels<para>"subordinate lien position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SubordinateLienPosition">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SubordinateLienPosition</seealso>
    let SubordinateLienPosition =
        Prefixed_Name(fibo_loan_ln_ln, "SubordinateLienPosition") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:TotalOutstandingPrincipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"total outstanding principal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/TotalOutstandingPrincipal">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/TotalOutstandingPrincipal</seealso>
    let TotalOutstandingPrincipal =
        Prefixed_Name(fibo_loan_ln_ln, "TotalOutstandingPrincipal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:UnsecuredLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unsecured loan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/UnsecuredLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/UnsecuredLoan</seealso>
    let UnsecuredLoan = Prefixed_Name(fibo_loan_ln_ln, "UnsecuredLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasBalloonPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has balloon payment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasBalloonPayment">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasBalloonPayment</seealso>
    let hasBalloonPayment =
        Prefixed_Name(fibo_loan_ln_ln, "hasBalloonPayment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has cost"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasCost">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasCost</seealso>
    let hasCost = Prefixed_Name(fibo_loan_ln_ln, "hasCost") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasFirstRateChangeTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first rate change term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasFirstRateChangeTerm">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasFirstRateChangeTerm</seealso>
    let hasFirstRateChangeTerm =
        Prefixed_Name(fibo_loan_ln_ln, "hasFirstRateChangeTerm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasIndividualPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has individual payment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasIndividualPayment">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasIndividualPayment</seealso>
    let hasIndividualPayment =
        Prefixed_Name(fibo_loan_ln_ln, "hasIndividualPayment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasLoanBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has loan balance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasLoanBalance">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasLoanBalance</seealso>
    let hasLoanBalance =
        Prefixed_Name(fibo_loan_ln_ln, "hasLoanBalance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasNegativeAmortization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has negative amortization"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasNegativeAmortization">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasNegativeAmortization</seealso>
    let hasNegativeAmortization =
        Prefixed_Name(fibo_loan_ln_ln, "hasNegativeAmortization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasPaymentHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has payment history"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPaymentHistory">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPaymentHistory</seealso>
    let hasPaymentHistory =
        Prefixed_Name(fibo_loan_ln_ln, "hasPaymentHistory") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasPrePaymentPenaltyTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has pre-payment penalty term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrePaymentPenaltyTerm">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrePaymentPenaltyTerm</seealso>
    let hasPrePaymentPenaltyTerm =
        Prefixed_Name(fibo_loan_ln_ln, "hasPrePaymentPenaltyTerm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasPrincipalAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrincipalAmount">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrincipalAmount</seealso>
    let hasPrincipalAmount =
        Prefixed_Name(fibo_loan_ln_ln, "hasPrincipalAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasScheduledUnpaidBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has scheduled unpaid balance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasScheduledUnpaidBalance">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasScheduledUnpaidBalance</seealso>
    let hasScheduledUnpaidBalance =
        Prefixed_Name(fibo_loan_ln_ln, "hasScheduledUnpaidBalance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasTotalClosingCosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has total closing costs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalClosingCosts">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalClosingCosts</seealso>
    let hasTotalClosingCosts =
        Prefixed_Name(fibo_loan_ln_ln, "hasTotalClosingCosts") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:hasTotalPointsAndFees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has total points and fees"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalPointsAndFees">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalPointsAndFees</seealso>
    let hasTotalPointsAndFees =
        Prefixed_Name(fibo_loan_ln_ln, "hasTotalPointsAndFees") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:isAssumable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is assumable"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isAssumable">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isAssumable</seealso>
    let isAssumable = Prefixed_Name(fibo_loan_ln_ln, "isAssumable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:isInitiallyPayable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is initially payable"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInitiallyPayable">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInitiallyPayable</seealso>
    let isInitiallyPayable =
        Prefixed_Name(fibo_loan_ln_ln, "isInitiallyPayable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:isInterestOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is interest only"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInterestOnly">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInterestOnly</seealso>
    let isInterestOnly =
        Prefixed_Name(fibo_loan_ln_ln, "isInterestOnly") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-ln:isServicedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is performed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isServicedBy">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isServicedBy</seealso>
    let isServicedBy = Prefixed_Name(fibo_loan_ln_ln, "isServicedBy") |> PrefixedName
