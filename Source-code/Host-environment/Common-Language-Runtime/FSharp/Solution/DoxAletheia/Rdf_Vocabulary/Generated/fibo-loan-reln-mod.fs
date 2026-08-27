namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.RealEstateLoans.MetadataLOANRealEstateLoans.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_reln_mod =
    let _namespace_iri = Namespace_Iri fibo_loan_reln_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-reln-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Loans (LOAN) Real Estate Loans Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_reln_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-reln-mod:RealEstateLoansModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"real estate loans module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/RealEstateLoansModule">https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/RealEstateLoansModule</seealso>
    let RealEstateLoansModule =
        Prefixed_Name(fibo_loan_reln_mod, "RealEstateLoansModule") |> PrefixedName
