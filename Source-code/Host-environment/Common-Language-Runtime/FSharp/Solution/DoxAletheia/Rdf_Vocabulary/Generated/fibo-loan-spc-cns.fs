namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.ConsumerLoans.slash

open DoxAletheia

module fibo_loan_spc_cns =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/ConsumerLoan"></see>
    /// </summary>
    let ConsumerLoan = _prefix "ConsumerLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/HomeEquityLineOfCredit"></see>
    /// </summary>
    let HomeEquityLineOfCredit = _prefix "HomeEquityLineOfCredit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/SecuredConsumerLoan"></see>
    /// </summary>
    let SecuredConsumerLoan = _prefix "SecuredConsumerLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/MotorVehicleLoan"></see>
    /// </summary>
    let MotorVehicleLoan = _prefix "MotorVehicleLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/UnsecuredConsumerLoan"></see>
    /// </summary>
    let UnsecuredConsumerLoan = _prefix "UnsecuredConsumerLoan"
