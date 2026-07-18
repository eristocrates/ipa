namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.ConsumerLoans.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_spc_cns =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/ConsumerLoan"></see>
    /// </summary>
    let ConsumerLoan =
        Namespaced_IRI.parse _namespace_name "ConsumerLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/HomeEquityLineOfCredit"></see>
    /// </summary>
    let HomeEquityLineOfCredit =
        Namespaced_IRI.parse _namespace_name "HomeEquityLineOfCredit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/SecuredConsumerLoan"></see>
    /// </summary>
    let SecuredConsumerLoan =
        Namespaced_IRI.parse _namespace_name "SecuredConsumerLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/MotorVehicleLoan"></see>
    /// </summary>
    let MotorVehicleLoan =
        Namespaced_IRI.parse _namespace_name "MotorVehicleLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/UnsecuredConsumerLoan"></see>
    /// </summary>
    let UnsecuredConsumerLoan =
        Namespaced_IRI.parse _namespace_name "UnsecuredConsumerLoan" |> NamespacedName
