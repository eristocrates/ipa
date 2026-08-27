namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.ConsumerLoans.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_spc_cns =
    let _namespace_iri = Namespace_Iri fibo_loan_spc_cns |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-spc-cns:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Consumer Loans Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_spc_cns, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-loan-spc-cns:ConsumerLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consumer loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/ConsumerLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/ConsumerLoan</seealso>
    let ConsumerLoan = Prefixed_Name(fibo_loan_spc_cns, "ConsumerLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-cns:HomeEquityLineOfCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"home equity line of credit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/HomeEquityLineOfCredit">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/HomeEquityLineOfCredit</seealso>
    let HomeEquityLineOfCredit =
        Prefixed_Name(fibo_loan_spc_cns, "HomeEquityLineOfCredit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-cns:MotorVehicleLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"motor vehicle loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/MotorVehicleLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/MotorVehicleLoan</seealso>
    let MotorVehicleLoan =
        Prefixed_Name(fibo_loan_spc_cns, "MotorVehicleLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-cns:SecuredConsumerLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"secured consumer loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/SecuredConsumerLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/SecuredConsumerLoan</seealso>
    let SecuredConsumerLoan =
        Prefixed_Name(fibo_loan_spc_cns, "SecuredConsumerLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-cns:UnsecuredConsumerLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unsecured consumer loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/UnsecuredConsumerLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/UnsecuredConsumerLoan</seealso>
    let UnsecuredConsumerLoan =
        Prefixed_Name(fibo_loan_spc_cns, "UnsecuredConsumerLoan") |> PrefixedName
