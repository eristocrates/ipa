namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.CommercialLoans.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_spc_com =
    let _namespace_iri = Namespace_Iri fibo_loan_spc_com |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-spc-com:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Commercial Loans Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_spc_com, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-com:CommercialLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commercial loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/CommercialLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/CommercialLoan</seealso>
    let CommercialLoan =
        Prefixed_Name(fibo_loan_spc_com, "CommercialLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-com:hasBusinessPurposeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has business purpose description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/hasBusinessPurposeDescription">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/hasBusinessPurposeDescription</seealso>
    let hasBusinessPurposeDescription =
        Prefixed_Name(fibo_loan_spc_com, "hasBusinessPurposeDescription") |> PrefixedName
