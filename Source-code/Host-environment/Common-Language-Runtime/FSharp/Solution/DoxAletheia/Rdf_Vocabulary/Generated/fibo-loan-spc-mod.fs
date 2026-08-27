namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.MetadataLOANLoansSpecific.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_spc_mod =
    let _namespace_iri = Namespace_Iri fibo_loan_spc_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-spc-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Loans (LOAN) Loans - Specific Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_spc_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-mod:LoansSpecificModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"loans specific module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/LoansSpecificModule">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/LoansSpecificModule</seealso>
    let LoansSpecificModule =
        Prefixed_Name(fibo_loan_spc_mod, "LoansSpecificModule") |> PrefixedName
