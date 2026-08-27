namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.RealEstateLoans.Mortgages.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_reln_mtg =
    let _namespace_iri = Namespace_Iri fibo_loan_reln_mtg |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-reln-mtg:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Mortgages Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_reln_mtg, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:ClosedEndMortgageLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"closed-end mortgage loan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndMortgageLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndMortgageLoan</seealso>
    let ClosedEndMortgageLoan =
        Prefixed_Name(fibo_loan_reln_mtg, "ClosedEndMortgageLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:ClosedEndReverseMortgage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"closed-end reverse mortgage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndReverseMortgage">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndReverseMortgage</seealso>
    let ClosedEndReverseMortgage =
        Prefixed_Name(fibo_loan_reln_mtg, "ClosedEndReverseMortgage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:LoanSecuredByRealEstate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan secured by real estate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/LoanSecuredByRealEstate">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/LoanSecuredByRealEstate</seealso>
    let LoanSecuredByRealEstate =
        Prefixed_Name(fibo_loan_reln_mtg, "LoanSecuredByRealEstate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:Mortgage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mortgage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/Mortgage">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/Mortgage</seealso>
    let Mortgage = Prefixed_Name(fibo_loan_reln_mtg, "Mortgage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:OpenEndMortgageLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"open-end mortgage loan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndMortgageLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndMortgageLoan</seealso>
    let OpenEndMortgageLoan =
        Prefixed_Name(fibo_loan_reln_mtg, "OpenEndMortgageLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:OpenEndReverseMortgage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"open-end reverse mortgage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndReverseMortgage">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndReverseMortgage</seealso>
    let OpenEndReverseMortgage =
        Prefixed_Name(fibo_loan_reln_mtg, "OpenEndReverseMortgage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:ReverseMortgageLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reverse mortgage loan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ReverseMortgageLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ReverseMortgageLoan</seealso>
    let ReverseMortgageLoan =
        Prefixed_Name(fibo_loan_reln_mtg, "ReverseMortgageLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:hasInitialFundingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has initial funding date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/hasInitialFundingDate">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/hasInitialFundingDate</seealso>
    let hasInitialFundingDate =
        Prefixed_Name(fibo_loan_reln_mtg, "hasInitialFundingDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mtg:isARMConvertible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is ARM convertible"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/isARMConvertible">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/isARMConvertible</seealso>
    let isARMConvertible =
        Prefixed_Name(fibo_loan_reln_mtg, "isARMConvertible") |> PrefixedName
